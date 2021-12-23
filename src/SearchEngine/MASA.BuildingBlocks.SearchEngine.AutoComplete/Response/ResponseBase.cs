namespace MASA.BuildingBlocks.SearchEngine.AutoComplete.Response;
public class ResponseBase
{
    public bool IsValid { get; }

    public string Message { get; }

    public ResponseBase(bool isValid, string message)
    {
        IsValid = isValid;

        if (isValid)
        {
            message = "success";
        }

        Message = message;
    }
}
