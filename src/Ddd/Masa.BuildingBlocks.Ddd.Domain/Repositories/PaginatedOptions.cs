namespace Masa.BuildingBlocks.Ddd.Domain.Repositories;
public class PaginatedOptions
{
    public int Page { get; set; }

    public int PageSize { get; set; }

    public Dictionary<string, bool>? Sorting { get; set; }

    public PaginatedOptions()
    {
    }

    public PaginatedOptions(int page, int pageSize, Dictionary<string, bool>? sorting = null)
    {
        Page = page;
        PageSize = pageSize;
        Sorting = sorting;
    }

    /// <summary>
    /// Initialize a new instance of PaginatedOptions.
    /// </summary>
    /// <param name="page">page number</param>
    /// <param name="pageSize">returns per page</param>
    /// <param name="sorting">sort parameters</param>
    /// <param name="isDescending">true descending order, false ascending order, default: true</param>
    public PaginatedOptions(int page, int pageSize, string sorting, bool isDescending = true)
        : this(page, pageSize, new Dictionary<string, bool>(new List<KeyValuePair<string, bool>> { new(sorting, isDescending) }))
    {
    }
}
