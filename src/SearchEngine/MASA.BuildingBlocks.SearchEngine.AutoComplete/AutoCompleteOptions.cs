namespace MASA.BuildingBlocks.SearchEngine.AutoComplete;

public class AutoCompleteOptions
{
    public string Field { get; set; }

    public int PageSize { get; set; }

    public SearchType SearchType { get; set; }

    public AutoCompleteOptions()
    {
        this.Field = "Id";
        this.PageSize = 10;
        this.SearchType = SearchType.Fuzzy;
    }
}
