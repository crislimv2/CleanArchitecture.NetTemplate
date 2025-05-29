using Clean.Architecture.Web.EndPoints.Contributors;

namespace Clean.Architecture.Web.Contributors;

public class ContributorListResponse
{
  public List<ContributorRecord> Contributors { get; set; } = [];
}
