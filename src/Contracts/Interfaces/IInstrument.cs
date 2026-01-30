using IndustrialTestPlatform.Contracts.Models;

namespace IndustrialTestPlatform.Contracts.Interfaces;

public interface IInstrument : IAsyncDisposable
{
    InstrumentDescriptor Descriptor { get; }
    InstrumentState State { get; }

    ValueTask ConnectAsync(CancellationToken cancellationToken);
    ValueTask DisconnectAsync(CancellationToken cancellationToken);
    ValueTask<string> QueryAsync(string command, TimeSpan? timeout, CancellationToken cancellationToken);
    ValueTask SendAsync(string command, TimeSpan? timeout, CancellationToken cancellationToken);
    ValueTask<MeasurementResult> MeasureAsync(string measurementId, TimeSpan? timeout, CancellationToken cancellationToken);
    ValueTask HealthCheckAsync(CancellationToken cancellationToken);
}
