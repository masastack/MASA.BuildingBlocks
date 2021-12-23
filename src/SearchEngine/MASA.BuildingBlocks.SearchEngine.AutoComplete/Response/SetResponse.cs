namespace MASA.BuildingBlocks.SearchEngine.AutoComplete.Response;

public class SetResponse : ResponseBase
{
    public string Id { get; }

    public SetResponse(string id, bool isValid, string message) : base(isValid, message)
    {
        Id = id;
    }
}
