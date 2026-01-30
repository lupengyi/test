using System.Text.Json.Serialization;

namespace IndustrialTestPlatform.Contracts.Models;

public sealed record InstrumentDescriptor(
    string InstrumentId,
    string Name,
    string Vendor,
    string Model,
    string FirmwareVersion,
    IReadOnlyList<InstrumentCapability> Capabilities);

public sealed record InstrumentCapability(
    string Name,
    string Version);

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum InstrumentState
{
    Disconnected,
    Connecting,
    Ready,
    Faulted
}
