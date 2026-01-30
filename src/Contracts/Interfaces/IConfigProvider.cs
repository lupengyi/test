using System.Text.Json;

namespace IndustrialTestPlatform.Contracts.Interfaces;

public interface IConfigProvider
{
    ValueTask<JsonElement?> GetSectionAsync(string key, CancellationToken cancellationToken);
    ValueTask<T?> GetAsync<T>(string key, CancellationToken cancellationToken);
}
