namespace MASA.Contrib.Data.UoW.EF;

public class UnitOfWork<TDbContext> : IAsyncDisposable, IUnitOfWork
    where TDbContext : MasaDbContext
{
    public DbTransaction Transaction
    {
        get
        {
            if (!UseTransaction)
                throw new NotSupportedException("Doesn't support transaction opening");

            if (TransactionHasBegun)
                return _context.Database.CurrentTransaction!.GetDbTransaction();

            return _context.Database.BeginTransaction().GetDbTransaction();
        }
    }

    public bool TransactionHasBegun => _context.Database.CurrentTransaction != null;

    public bool DisableRollbackOnFailure { get; set; }

    public EntityState EntityState { get; set; }

    public CommitState CommitState { get; set; }

    public bool UseTransaction { get; set; } = true;

    private readonly DbContext _context;

    private readonly ILogger<UnitOfWork<TDbContext>>? _logger;

    public UnitOfWork(TDbContext dbContext, ILogger<UnitOfWork<TDbContext>>? logger = null)
    {
        _context = dbContext;
        _logger = logger;
    }

    public async Task SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        await _context.SaveChangesAsync(cancellationToken);
        EntityState = EntityState.Unchanged;
    }

    public async Task CommitAsync(CancellationToken cancellationToken = default)
    {
        if (!UseTransaction || !TransactionHasBegun)
            throw new NotSupportedException("Transaction not opened");

        await _context.Database.CommitTransactionAsync(cancellationToken);
        CommitState = CommitState.Commited;
    }

    public async Task RollbackAsync(CancellationToken cancellationToken = default)
    {
        if (!UseTransaction || !TransactionHasBegun)
            throw new NotSupportedException("Transactions are not opened and rollback is not supported");

        await _context.Database.RollbackTransactionAsync(cancellationToken);
    }

    public ValueTask DisposeAsync() => _context.DisposeAsync();

    public void Dispose() => _context.Dispose();
}
