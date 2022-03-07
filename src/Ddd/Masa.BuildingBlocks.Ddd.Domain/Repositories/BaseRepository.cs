namespace Masa.BuildingBlocks.Ddd.Domain.Repositories;
public abstract class BaseRepository<TAggregateRoot> :
    IRepository<TAggregateRoot>, IUnitOfWork
    where TAggregateRoot : class, IAggregateRoot
{
    #region IRepository<TEntity>

    public abstract ValueTask<TAggregateRoot> AddAsync(TAggregateRoot entity, CancellationToken cancellationToken = default);

    public virtual async Task AddRangeAsync(IEnumerable<TAggregateRoot> entities, CancellationToken cancellationToken = default)
    {
        foreach (var entity in entities)
        {
            await AddAsync(entity, cancellationToken);
        }
    }

    public abstract Task<TAggregateRoot?> FindAsync(IEnumerable<KeyValuePair<string, object>> keyValues, CancellationToken cancellationToken = default);

    public abstract Task<TAggregateRoot?> FindAsync(Expression<Func<TAggregateRoot, bool>> predicate, CancellationToken cancellationToken = default);

    public abstract Task<TAggregateRoot> RemoveAsync(TAggregateRoot entity, CancellationToken cancellationToken = default);

    public abstract Task RemoveAsync(Expression<Func<TAggregateRoot, bool>> predicate, CancellationToken cancellationToken = default);

    public virtual async Task RemoveRangeAsync(IEnumerable<TAggregateRoot> entities, CancellationToken cancellationToken = default)
    {
        foreach (var entity in entities)
        {
            await RemoveAsync(entity, cancellationToken);
        }
    }

    public abstract Task<TAggregateRoot> UpdateAsync(TAggregateRoot entity, CancellationToken cancellationToken = default);

    public virtual async Task UpdateRangeAsync(IEnumerable<TAggregateRoot> entities, CancellationToken cancellationToken = default)
    {
        foreach (var entity in entities)
        {
            await UpdateAsync(entity, cancellationToken);
        }
    }

    public abstract Task<IEnumerable<TAggregateRoot>> GetListAsync(CancellationToken cancellationToken = default);

    public abstract Task<IEnumerable<TAggregateRoot>> GetListAsync(Expression<Func<TAggregateRoot, bool>> predicate, CancellationToken cancellationToken = default);

    public abstract Task<long> GetCountAsync(CancellationToken cancellationToken = default);

    public abstract Task<long> GetCountAsync(Expression<Func<TAggregateRoot, bool>> predicate, CancellationToken cancellationToken = default);

    public abstract Task<List<TAggregateRoot>> GetPaginatedListAsync(int skip, int take, Dictionary<string, bool>? sorting, CancellationToken cancellationToken = default);

    public abstract Task<List<TAggregateRoot>> GetPaginatedListAsync(Expression<Func<TAggregateRoot, bool>> predicate, int skip, int take, Dictionary<string, bool>? sorting, CancellationToken cancellationToken = default);

    public virtual async Task<PaginatedList<TAggregateRoot>> GetPaginatedListAsync(PaginatedOptions options, CancellationToken cancellationToken = default)
    {
        var result = await GetPaginatedListAsync(
            (options.Page - 1) * options.PageSize,
            options.PageSize <= 0 ? int.MaxValue : options.PageSize,
            options.Sorting,
            cancellationToken
        );

        var total = await GetCountAsync(cancellationToken);

        return new PaginatedList<TAggregateRoot>()
        {
            Total = total,
            Result = result,
            TotalPages = (int)Math.Ceiling(total / (decimal)options.PageSize)
        };
    }

    public async Task<PaginatedList<TAggregateRoot>> GetPaginatedListAsync(Expression<Func<TAggregateRoot, bool>> predicate, PaginatedOptions options, CancellationToken cancellationToken = default)
    {
        var result = await GetPaginatedListAsync(
            predicate,
            (options.Page - 1) * options.PageSize,
            options.PageSize <= 0 ? int.MaxValue : options.PageSize,
            options.Sorting,
            cancellationToken
        );

        var total = await GetCountAsync(predicate, cancellationToken);

        return new PaginatedList<TAggregateRoot>()
        {
            Total = total,
            Result = result,
            TotalPages = (int)Math.Ceiling(total / (decimal)options.PageSize)
        };
    }

    #endregion

    #region IUnitOfWork

    public abstract DbTransaction Transaction { get; }

    public abstract bool TransactionHasBegun { get; }

    public abstract bool UseTransaction { get; set; }

    public bool DisableRollbackOnFailure { get; set; }

    public virtual EntityState EntityState
    {
        get => UnitOfWork.EntityState;
        set => UnitOfWork.EntityState = value;
    }

    public virtual CommitState CommitState
    {
        get => UnitOfWork.CommitState;
        set => UnitOfWork.CommitState = value;
    }

    public abstract IUnitOfWork UnitOfWork { get; }

    public abstract Task CommitAsync(CancellationToken cancellationToken = default);

    public abstract ValueTask DisposeAsync();

    public abstract void Dispose();

    public abstract Task RollbackAsync(CancellationToken cancellationToken = default);

    public abstract Task SaveChangesAsync(CancellationToken cancellationToken = default);

    #endregion
}
