namespace MASA.BuildingBlocks.Data.UoW;
public interface IUnitOfWork : IDisposable, IAsyncDisposable
{
    DbTransaction Transaction { get; }

    /// <summary>
    /// Whether the transaction has been opened
    /// </summary>
    bool TransactionHasBegun { get; }

    /// <summary>
    /// Do you need to use transactions
    /// </summary>
    bool UseTransaction { get; set; }

    /// <summary>
    /// Disable transaction rollback after failure
    /// </summary>
    bool DisableRollbackOnFailure { get; set; }

    EntityState EntityState { get; set; }

    Task SaveChangesAsync(CancellationToken cancellationToken = default);

    Task CommitAsync(CancellationToken cancellationToken = default);

    Task RollbackAsync(CancellationToken cancellationToken = default);
}
