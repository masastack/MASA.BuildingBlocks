namespace Masa.BuildingBlocks.Ddd.Domain.Repositories;
public interface IRepository<TAggregateRoot>
    where TEntity : class, IEntity
{
    IUnitOfWork UnitOfWork { get; }

    #region Add

    ValueTask<TAggregateRoot> AddAsync(TAggregateRoot entity, CancellationToken cancellationToken = default);

    Task AddRangeAsync(IEnumerable<TAggregateRoot> entities, CancellationToken cancellationToken = default);

    #endregion

    #region Update

    Task<TAggregateRoot> UpdateAsync(TAggregateRoot entity, CancellationToken cancellationToken = default);

    Task UpdateRangeAsync(IEnumerable<TAggregateRoot> entities, CancellationToken cancellationToken = default);

    #endregion

    #region Remove

    Task<TAggregateRoot> RemoveAsync(TAggregateRoot entity, CancellationToken cancellationToken = default);

    Task RemoveRangeAsync(IEnumerable<TAggregateRoot> entities, CancellationToken cancellationToken = default);

    Task RemoveAsync(Expression<Func<TAggregateRoot, bool>> predicate, CancellationToken cancellationToken = default);

    #endregion

    #region Find

    Task<TEntity?> FindAsync(IEnumerable<KeyValuePair<string, object>> keyValues, CancellationToken cancellationToken = default);

    Task<TAggregateRoot?> FindAsync(Expression<Func<TAggregateRoot, bool>> predicate, CancellationToken cancellationToken = default);

    #endregion

    #region Get

    Task<IEnumerable<TAggregateRoot>> GetListAsync(CancellationToken cancellationToken = default);

    Task<IEnumerable<TAggregateRoot>> GetListAsync(Expression<Func<TAggregateRoot, bool>> predicate, CancellationToken cancellationToken = default);

    Task<long> GetCountAsync(CancellationToken cancellationToken = default);

    Task<long> GetCountAsync(Expression<Func<TAggregateRoot, bool>> predicate, CancellationToken cancellationToken = default);

    Task<List<TEntity>> GetPaginatedListAsync(int skip, int take, Dictionary<string, bool>? sorting,
        CancellationToken cancellationToken = default);

    Task<List<TEntity>> GetPaginatedListAsync(Expression<Func<TEntity, bool>> predicate, int skip, int take,
        Dictionary<string, bool>? sorting, CancellationToken cancellationToken = default);

    Task<PaginatedList<TAggregateRoot>> GetPaginatedListAsync(PaginatedOptions options, CancellationToken cancellationToken = default);

    Task<PaginatedList<TEntity>> GetPaginatedListAsync(Expression<Func<TEntity, bool>> predicate, PaginatedOptions options,
        CancellationToken cancellationToken = default);

    #endregion

}

public interface IRepository<TEntity, TKey> : IRepository<TEntity>
    where TEntity : class, IEntity<TKey>
    where TKey : IComparable
{
    #region Find

    Task<TEntity?> FindAsync(TKey id);

    #endregion
}
