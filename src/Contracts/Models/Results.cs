using System.Text.Json.Serialization;

namespace IndustrialTestPlatform.Contracts.Models;

public sealed record RunResult(
    string RunId,
    string TraceId,
    StationInfo Station,
    SlotInfo Slot,
    UutInfo Uut,
    DateTimeOffset StartedAt,
    DateTimeOffset FinishedAt,
    RunOutcome Outcome,
    IReadOnlyList<StepResult> Steps,
    IReadOnlyList<ErrorInfo> Errors);

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum RunOutcome
{
    Pass,
    Fail,
    Aborted,
    Error
}

public sealed record StepResult(
    string StepId,
    string StepName,
    StepOutcome Outcome,
    DateTimeOffset StartedAt,
    DateTimeOffset FinishedAt,
    TimeSpan Duration,
    IReadOnlyList<MeasurementResult> Measurements,
    IReadOnlyList<ErrorInfo> Errors,
    string? LogReference);

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum StepOutcome
{
    Pass,
    Fail,
    NotApplicable,
    Skipped,
    Error
}

public sealed record MeasurementResult(
    string Name,
    double? NumericValue,
    string? TextValue,
    string? Unit,
    LimitsInfo? Limits,
    MeasurementOutcome Outcome,
    string? FailReason);

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum MeasurementOutcome
{
    Pass,
    Fail,
    NotApplicable,
    Error
}

public sealed record ErrorInfo(
    string Code,
    ErrorSeverity Severity,
    string Message,
    ErrorContext Context);

public sealed record ErrorContext(
    string? StepId,
    string? SlotId,
    string? UutId,
    string? InstrumentId,
    string? Operation);

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ErrorSeverity
{
    Recoverable,
    Fatal
}
