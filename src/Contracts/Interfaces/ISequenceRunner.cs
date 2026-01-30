using IndustrialTestPlatform.Contracts.Models;

namespace IndustrialTestPlatform.Contracts.Interfaces;

public interface ISequenceRunner
{
    ValueTask<RunResult> RunAsync(SequenceDefinition definition, RunContext context, CancellationToken cancellationToken);
}

public sealed record RunContext(
    string RunId,
    string TraceId,
    StationInfo Station,
    SlotInfo Slot,
    UutInfo Uut,
    string RunDirectory,
    IReadOnlyDictionary<string, string> Tags);
