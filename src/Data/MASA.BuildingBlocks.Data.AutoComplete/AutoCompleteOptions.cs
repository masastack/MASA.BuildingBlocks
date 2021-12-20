namespace MASA.BuildingBlocks.Data.AutoComplete;

public class AutoCompleteOptions
{
    public string Field { get; set; }

    public int PageSize { get; set; }

    public AutoCompleteOptions()
    {
        this.Field = "Id";
        this.PageSize = 10;
    }
}
