namespace Masa.BuildingBlocks.Storage.ObjectStorage.Response;
public class ResponseBase
{
    public bool IsValid { get; }

    public string Message { get; }

    protected ResponseBase(bool isValid, string message)
    {
        IsValid = isValid;
        Message = message;
    }
}

public class ResponseBase<TData> : ResponseBase
{
    public TData? Data { get; }

    public ResponseBase(bool isValid, string message, TData? data) : base(isValid, message)
    {
        Data = data;
    }

    public static ResponseBase<TData> Success(TData? data, string message = "success") => new(true, message, data);

    public static ResponseBase<TData> Error(string message, TData? data = default) => new(false, message, data);
}
