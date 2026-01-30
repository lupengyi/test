using System.Text.Json;
using IndustrialTestPlatform.Contracts.Models;

namespace IndustrialTestPlatform.Contracts.Interfaces;

public interface ITestStep
{
    string Id { get; }
    string Name { get; }
    string Version { get; }
    IReadOnlyList<InstrumentCapability> RequiredInstruments { get; }

    ValueTask<StepResult> ExecuteAsync(StepContext context, CancellationToken cancellationToken);
}

public sealed record StepContext(
    string RunId,
    string TraceId,
    StationInfo Station,
    SlotInfo Slot,
    UutInfo Uut,
    IReadOnlyDictionary<string, JsonElement>? Inputs,
    LimitsInfo? Limits,
    IReadOnlyDictionary<string, string> Tags);
