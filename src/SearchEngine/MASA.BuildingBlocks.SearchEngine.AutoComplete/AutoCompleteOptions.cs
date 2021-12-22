namespace MASA.BuildingBlocks.SearchEngine.AutoComplete;

public class AutoCompleteOptions
{
    public string Field { get; private set; }

    public int PageIndex { get; private set; }

    public int PageSize { get; private set; }

    public SearchType SearchType { get; }

    public static AutoCompleteOptions Default = new AutoCompleteOptions();

    public AutoCompleteOptions(SearchType searchType = SearchType.Fuzzy)
    {
        this.Field = "Id";
        this.PageIndex = 1;
        this.PageSize = 10;
        this.SearchType = searchType;
    }

    public AutoCompleteOptions UseField(string field)
    {
        if (string.IsNullOrWhiteSpace(field))
            throw new ArgumentException($"{nameof(field)} cannot be empty", nameof(field));

        Field = field;
        return this;
    }

    public AutoCompleteOptions UsePageIndex(int pageIndex)
    {
        if (pageIndex <= 0)
            throw new ArgumentException($"{nameof(pageIndex)} must be greater than or equal to 1", nameof(pageIndex));

        PageIndex = pageIndex;
        return this;
    }

    public AutoCompleteOptions UsePageSize(int pageSize)
    {
        if (pageSize <= 0)
            throw new ArgumentException($"{nameof(pageSize)} must be greater than or equal to 1", nameof(pageSize));

        PageSize = pageSize;
        return this;
    }
}
