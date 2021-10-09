namespace MASA.BuildingBlocks.DDD.Domain.Repositories;
public interface IRepository<TEntity>
    where TEntity : class, IAggregateRoot
{
    IUnitOfWork UnitOfWork { get; }

    #region Add

    ValueTask<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken = default);

    Task AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default);

    #endregion

    #region Update

    Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default);

    Task UpdateRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default);

    #endregion

    #region Remove

    Task<TEntity> RemoveAsync(TEntity entity, CancellationToken cancellationToken = default);

    Task RemoveRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default);

    Task RemoveAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default);

    #endregion

    #region Find

    ValueTask<TEntity?> FindAsync(params object?[]? keyValues);

    ValueTask<TEntity?> FindAsync(object?[]? keyValues, CancellationToken cancellationToken);

    Task<TEntity?> FindAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default);

    #endregion

    #region Get

    Task<IEnumerable<TEntity>> GetListAsync(CancellationToken cancellationToken);

    Task<IEnumerable<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken);

    Task<long> GetCountAsync(CancellationToken cancellationToken);

    Task<long> GetCountAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken);

    Task<List<TEntity>> GetPaginatedListAsync(int skip, int take, string? sorting, CancellationToken cancellationToken);

    Task<List<TEntity>> GetPaginatedListAsync(Expression<Func<TEntity, bool>> predicate, int skip, int take, string? sorting, CancellationToken cancellationToken);

    Task<PaginatedList<TEntity>> GetPaginatedListAsync(PaginatedOptions options, CancellationToken cancellationToken);

    Task<PaginatedList<TEntity>> GetPaginatedListAsync(Expression<Func<TEntity, bool>> predicate, PaginatedOptions options, CancellationToken cancellationToken);

    #endregion
}

public interface IRepository<TAggregateRoot, TKey> : IRepository<TAggregateRoot>
    where TAggregateRoot : class, IAggregateRoot<TKey>
{

}
