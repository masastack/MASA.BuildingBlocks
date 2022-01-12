namespace MASA.BuildingBlocks.SearchEngine.AutoComplete;
public interface IAutoCompleteClient
{
    Task<GetResponse<DropdownBox<TValue>, TValue>> GetAsync<TValue>(
        string value,
        AutoCompleteOptions? options = null,
        CancellationToken cancellationToken = default);

    Task<GetResponse<TDropdownBox, TValue>> GetAsync<TDropdownBox, TValue>(
        string value,
        AutoCompleteOptions? options = null,
        CancellationToken cancellationToken = default)
        where TDropdownBox : DropdownBox<TValue>;

    Task<SetResponse> SetAsync<TValue>(
        DropdownBox<TValue>[] results,
        SetOptions? options = null,
        CancellationToken cancellationToken = default);

    Task<SetResponse> SetAsync<TDropdownBox, TValue>(
        TDropdownBox[] documents,
        SetOptions? options = null,
        CancellationToken cancellationToken = default) where TDropdownBox : DropdownBox<TValue> ;
}
