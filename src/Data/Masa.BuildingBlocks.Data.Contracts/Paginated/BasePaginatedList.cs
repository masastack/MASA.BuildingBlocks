namespace Masa.BuildingBlocks.Data.Contracts.Paginated;
public class BasePaginatedList<TEntity>
    where TEntity : class
{
    public long Total { get; set; }

    public int TotalPages { get; set; }

    public List<TEntity> Result { get; set; } = default!;
}
