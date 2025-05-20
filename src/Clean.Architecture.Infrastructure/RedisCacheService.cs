using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Clean.Architecture.Core.Interfaces;
using StackExchange.Redis;

namespace Clean.Architecture.Infrastructure;
public class RedisCacheService : ICacheService
{
  private readonly IDatabase _database;

  public RedisCacheService(IConnectionMultiplexer redis)
  {
    _database = redis.GetDatabase();
  }

  public async Task<T?> GetAsync<T>(string key)
  {
    var data = await _database.StringGetAsync(key);
    if (data.IsNullOrEmpty) return default;

    return JsonSerializer.Deserialize<T>(data!);
  }

  public async Task SetAsync<T>(string key, T value, TimeSpan? expiry = null)
  {
    var json = JsonSerializer.Serialize(value);
    await _database.StringSetAsync(key, json, expiry);
  }

  public async Task RemoveAsync(string key)
  {
    await _database.KeyDeleteAsync(key);
  }
}
