namespace IndustrialTestPlatform.Contracts.Interfaces;

public interface IClock
{
    DateTimeOffset UtcNow { get; }
}
