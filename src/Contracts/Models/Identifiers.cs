namespace IndustrialTestPlatform.Contracts.Models;

public sealed record StationInfo(
    string StationId,
    string ProcessId,
    string LineId,
    string StationName);

public sealed record SlotInfo(
    string SlotId,
    int Index,
    string? FixtureId);

public sealed record UutInfo(
    string SerialNumber,
    string? WorkOrder,
    string? ProductId,
    string? ProductVersion,
    string? Barcode,
    bool IsRetest);
