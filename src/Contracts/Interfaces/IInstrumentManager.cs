using IndustrialTestPlatform.Contracts.Models;

namespace IndustrialTestPlatform.Contracts.Interfaces;

public interface IInstrumentManager
{
    ValueTask<IInstrumentLease> AcquireLeaseAsync(
        string slotId,
        string capabilityName,
        TimeSpan timeout,
        CancellationToken cancellationToken);

    ValueTask<IReadOnlyList<InstrumentDescriptor>> ListInstrumentsAsync(CancellationToken cancellationToken);
}

public interface IInstrumentLease : IAsyncDisposable
{
    string LeaseId { get; }
    string SlotId { get; }
    DateTimeOffset AcquiredAt { get; }
    IInstrument Instrument { get; }
}
