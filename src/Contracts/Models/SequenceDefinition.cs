using System.Text.Json;
using System.Text.Json.Serialization;

namespace IndustrialTestPlatform.Contracts.Models;

public sealed record SequenceDefinition(
    string Name,
    string Version,
    StationInfo Station,
    string ProductId,
    string ProcessId,
    IReadOnlyList<StepDefinition> Steps,
    HookDefinition? Hooks,
    IReadOnlyList<SequenceVariable>? Variables);

public sealed record HookDefinition(
    IReadOnlyList<StepDefinition>? PreUutLoop,
    IReadOnlyList<StepDefinition>? PreUut,
    IReadOnlyList<StepDefinition>? PostUut,
    IReadOnlyList<StepDefinition>? PostUutLoop);

public sealed record SequenceVariable(
    string Name,
    JsonElement DefaultValue,
    string? Description);

public sealed record StepDefinition(
    string Id,
    string Name,
    string Plugin,
    IReadOnlyDictionary<string, JsonElement>? Inputs,
    string? LimitsRef,
    StepRetryPolicy? Retry,
    TimeSpan? Timeout,
    StepCondition? Condition);

public sealed record StepRetryPolicy(
    int MaxRetries,
    TimeSpan? Delay,
    RetryMode Mode);

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum RetryMode
{
    None,
    Immediate,
    FixedDelay,
    ExponentialBackoff
}

public sealed record StepCondition(
    string Expression,
    ConditionAction OnFalse);

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ConditionAction
{
    Skip,
    Abort
}
