namespace MASA.BuildingBlocks.Data.Uow;
public interface IUnitOfWork : IAsyncDisposable, ITransaction
{
    bool DisableRollbackOnFailure { get; set; }

    Task<DbTransaction> BeginTransaction(CancellationToken cancellationToken = default);

    Task SaveChangesAsync(CancellationToken cancellationToken = default);

    Task CommitAsync(CancellationToken cancellationToken = default);

    Task RollbackAsync(CancellationToken cancellationToken = default);
}
