namespace MASA.BuildingBlocks.SearchEngine.AutoComplete.Response;

public class SetResponse : ResponseBase
{
    public List<SetResponseItems> Items { get; set; }

    public SetResponse(bool isValid, string message) : base(isValid, message)
    {
    }

    public class SetResponseItems
    {
        public string Id { get; }

        public bool IsValid { get; }

        public string Message { get; }

        public SetResponseItems(string id, bool isValid, string message)
        {
            Id = id;
            IsValid = isValid;
            Message = message;
        }
    }
}
