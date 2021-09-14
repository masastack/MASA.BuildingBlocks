namespace MASA.BuildingBlocks.DDD.Domain.Repositories;
public interface IRepository<TEntity>
    where TEntity : class, IEntity
{
    #region Add

    ValueTask<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken = default);

    Task AddRangeAsync(params TEntity[] entities);

    Task AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default);

    #endregion

    #region Update

    ValueTask<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default);

    Task UpdateRangeAsync(params TEntity[] entities);

    Task UpdateRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default);

    #endregion

    #region Remove

    ValueTask<TEntity> RemoveAsync(TEntity entity, CancellationToken cancellationToken = default);

    Task RemoveRangeAsync(params TEntity[] entities);

    Task RemoveRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default);

    Task RemoveAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default);

    #endregion

    #region Find

    ValueTask<TEntity?> FindAsync(params object?[]? keyValues);

    ValueTask<TEntity?> FindAsync(object?[]? keyValues, CancellationToken cancellationToken);

    Task<TEntity?> FindAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default);

    #endregion
}

public interface IRepository<TEntity, TKey> : IRepository<TEntity>
    where TEntity : class, IEntity<TKey>
{

}
