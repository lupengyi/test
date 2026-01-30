using IndustrialTestPlatform.Contracts.Models;

namespace IndustrialTestPlatform.Contracts.Interfaces;

public interface IMesClient
{
    ValueTask<MesValidationResult> ValidateBarcodeAsync(StationInfo station, UutInfo uut, CancellationToken cancellationToken);
    ValueTask UploadResultAsync(RunResult runResult, CancellationToken cancellationToken);
    ValueTask<MesWorkOrderInfo?> QueryWorkOrderAsync(string workOrder, CancellationToken cancellationToken);
}

public sealed record MesValidationResult(
    bool IsValid,
    string? Message,
    bool IsRetest);

public sealed record MesWorkOrderInfo(
    string WorkOrder,
    string ProductId,
    int TargetQuantity,
    int CompletedQuantity);
