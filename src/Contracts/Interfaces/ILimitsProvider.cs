using IndustrialTestPlatform.Contracts.Models;

namespace IndustrialTestPlatform.Contracts.Interfaces;

public interface ILimitsProvider
{
    ValueTask<LimitsInfo?> GetLimitsAsync(string reference, CancellationToken cancellationToken);
}
