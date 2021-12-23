namespace MASA.BuildingBlocks.SearchEngine.AutoComplete;
public interface IAutoCompleteClient
{
    Task<GetResponse<Dropdown<TValue>, TValue>> GetAsync<TValue>(
        string value,
        AutoCompleteOptions? options = null,
        CancellationToken cancellationToken = default);

    Task<GetResponse<TResponse, TValue>> GetAsync<TResponse, TValue>(
        string value,
        AutoCompleteOptions? options = null,
        CancellationToken cancellationToken = default)
        where TResponse : Dropdown<TValue>;

    Task<SetResponse[]> SetAsync<TValue>(
        Dropdown<TValue>[] results,
        SetOptions? options = null,
        CancellationToken cancellationToken = default);

    Task<SetResponse[]> SetAsync<TDocument, TValue>(
        TDocument[] documents,
        SetOptions? options = null,
        CancellationToken cancellationToken = default) where TDocument : Dropdown<TValue> ;
}
