namespace MASA.BuildingBlocks.DDD.Domain.Repositories;
public class PaginatedOptions
{
    public int Page { get; set; }

    public int PageSize { get; set; }

    public string? Sorting { get; set; }
}