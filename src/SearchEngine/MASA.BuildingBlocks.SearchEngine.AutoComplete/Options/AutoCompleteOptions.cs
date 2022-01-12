namespace MASA.BuildingBlocks.SearchEngine.AutoComplete.Options;
public class AutoCompleteOptions
{
    public string Field { get; set; }

    private int _pageIndex;

    public int PageIndex
    {
        get => _pageIndex;
        set
        {
            if (value <= 0)
                throw new ArgumentException($"{nameof(PageIndex)} must be greater than or equal to 1", nameof(PageIndex));

            _pageIndex = value;
        }
    }

    private int _pageSize;

    public int PageSize
    {
        get => _pageSize;
        set
        {
            if (value <= 0)
                throw new ArgumentException($"{nameof(PageSize)} must be greater than or equal to 1", nameof(PageSize));

            _pageSize = value;
        }
    }

    public SearchType SearchType { get; }

    public AutoCompleteOptions(SearchType searchType = SearchType.Fuzzy)
    {
        this.Field = "id";
        this.PageIndex = 1;
        this.PageSize = 10;
        this.SearchType = searchType;
    }
}
