using System.Text.Json.Serialization;

namespace IndustrialTestPlatform.Contracts.Interfaces;

public interface ILog
{
    void Log(LogLevel level, string message, Exception? exception = null);
}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum LogLevel
{
    Trace,
    Debug,
    Information,
    Warning,
    Error,
    Critical
}
