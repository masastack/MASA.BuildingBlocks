namespace MASA.BuildingBlocks.SearchEngine.AutoComplete;
public interface IAutoCompleteClient
{
    Task<GetResponse<AudoCompleteDocument<TValue>, TValue>> GetAsync<TValue>(
        string value,
        AutoCompleteOptions? options = null,
        CancellationToken cancellationToken = default);

    Task<GetResponse<TAudoCompleteDocument, TValue>> GetAsync<TAudoCompleteDocument, TValue>(
        string value,
        AutoCompleteOptions? options = null,
        CancellationToken cancellationToken = default)
        where TAudoCompleteDocument : AudoCompleteDocument<TValue>;

    Task<SetResponse> SetAsync<TValue>(
        AudoCompleteDocument<TValue>[] results,
        SetOptions? options = null,
        CancellationToken cancellationToken = default);

    Task<SetResponse> SetAsync<TAudoCompleteDocument, TValue>(
        TAudoCompleteDocument[] documents,
        SetOptions? options = null,
        CancellationToken cancellationToken = default) where TAudoCompleteDocument : AudoCompleteDocument<TValue> ;
}
