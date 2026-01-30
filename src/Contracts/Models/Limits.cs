namespace IndustrialTestPlatform.Contracts.Models;

public sealed record LimitsInfo(
    string Name,
    string Version,
    string Source,
    string Hash,
    double? Lsl,
    double? Usl,
    double? Target,
    string? Unit,
    int? Precision,
    int? Scale,
    IReadOnlyList<string>? AllowedValues,
    int? MinLength,
    int? MaxLength);
