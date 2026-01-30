using IndustrialTestPlatform.Contracts.Models;

namespace IndustrialTestPlatform.Contracts.Interfaces;

public interface IResultStore
{
    ValueTask PersistAsync(RunResult runResult, CancellationToken cancellationToken);
}
