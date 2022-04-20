namespace Masa.BuildingBlocks.SearchEngine.AutoComplete.Response;
public class DeleteRangeResponseItems
{
    public string Id { get; }

    public bool IsValid { get; }

    public string Message { get; }

    public DeleteRangeResponseItems(string id, bool isValid, string message)
    {
        this.Id = id;
        this.IsValid = isValid;
        this.Message = message;
    }
}
