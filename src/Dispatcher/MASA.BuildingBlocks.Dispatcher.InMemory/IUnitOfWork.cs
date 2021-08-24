namespace MASA.BuildingBlocks.Dispatcher.InMemory;

public interface IUnitOfWork : IDisposable
{
    bool DisableRollbackOnFailure { get; set; }

    Task SaveChangesAsync(CancellationToken cancellationToken = default);

    Task CommitAsync(CancellationToken cancellationToken = default);

    Task RollbackAsync(CancellationToken cancellationToken = default);
}
