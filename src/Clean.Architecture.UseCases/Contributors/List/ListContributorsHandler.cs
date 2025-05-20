using Clean.Architecture.Core.Interfaces;

namespace Clean.Architecture.UseCases.Contributors.List;

public class ListContributorsHandler(IListContributorsQueryService _query, ICacheService _cache)
  : IQueryHandler<ListContributorsQuery, Result<IEnumerable<ContributorDTO>>>
{
  private const string CacheKey = "contributors_list";
  public async Task<Result<IEnumerable<ContributorDTO>>> Handle(ListContributorsQuery request, CancellationToken cancellationToken)
  {
    //var result = await _query.ListAsync();

    //return Result.Success(result);
    // 1. Try get from Redis cache
    var cachedData = await _cache.GetAsync<IEnumerable<ContributorDTO>>(CacheKey);
    if (cachedData != null)
    {
      return Result.Success(cachedData);
    }

    // 2. Cache miss: fetch from DB
    var result = await _query.ListAsync();

    // 3. Store in Redis cache for next calls
    await _cache.SetAsync(CacheKey, result, TimeSpan.FromMinutes(10)); // e.g. cache for 10 minutes

    return Result.Success(result);
  }
}
