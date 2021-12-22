namespace MASA.BuildingBlocks.SearchEngine.AutoComplete.Response;

public class GetResponse<TResponse, TValue> : ResponseBase
    where TResponse : Dropdown<TValue>
    where TValue : struct
{
    public long Total { get; set; }

    public int TotalPages { get; set; }

    public List<TResponse> Data { get; set; }

    public GetResponse(bool isValid, string message) : base(isValid, message)
    {
    }
}
