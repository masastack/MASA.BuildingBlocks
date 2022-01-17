namespace MASA.BuildingBlocks.SearchEngine.AutoComplete.Response;
public class GetResponse<TDropdownBox, TValue> : ResponseBase
    where TDropdownBox : AudoCompleteDocument<TValue>
{
    public long Total { get; set; }

    public long TotalPages { get; set; }

    public List<TDropdownBox> Data { get; set; }

    public GetResponse(bool isValid, string message) : base(isValid, message)
    {
    }
}
