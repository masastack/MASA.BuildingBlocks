namespace Masa.BuildingBlocks.Ddd.Domain.Repositories;
public class PaginatedList<TEntity> : BasePaginatedList<TEntity>
    where TEntity : class, IEntity
{
}
