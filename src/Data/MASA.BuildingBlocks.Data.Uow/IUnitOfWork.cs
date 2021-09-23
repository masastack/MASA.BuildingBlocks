namespace MASA.BuildingBlocks.Data.Uow;
public interface IUnitOfWork : IAsyncDisposable
{
    DbTransaction Transaction { get; set; }

    bool TransactionHasBegun { get; set; }

    bool DisableRollbackOnFailure { get; set; }

    Task SaveChangesAsync(CancellationToken cancellationToken = default);

    Task CommitAsync(CancellationToken cancellationToken = default);

    Task RollbackAsync(CancellationToken cancellationToken = default);
}
