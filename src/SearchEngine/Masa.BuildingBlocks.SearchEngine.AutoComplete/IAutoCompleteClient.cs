namespace Masa.BuildingBlocks.SearchEngine.AutoComplete;

public interface IAutoCompleteClient
{
    Task<GetResponse<AutoCompleteDocument<Guid>, Guid>> GetAsync(
        string keyword,
        AutoCompleteOptions? options = null,
        CancellationToken cancellationToken = default);

    Task<GetResponse<AutoCompleteDocument<TValue>, TValue>> GetAsync<TValue>(
        string keyword,
        AutoCompleteOptions? options = null,
        CancellationToken cancellationToken = default) where TValue : notnull;

    Task<GetResponse<TAudoCompleteDocument, TValue>> GetAsync<TAudoCompleteDocument, TValue>(
        string keyword,
        AutoCompleteOptions? options = null,
        CancellationToken cancellationToken = default)
        where TAudoCompleteDocument : AutoCompleteDocument<TValue> where TValue : notnull;

    Task<SetResponse> SetAsync(
        AutoCompleteDocument<Guid> document,
        SetOptions? options = null,
        CancellationToken cancellationToken = default);

    Task<SetResponse> SetMultiAsync(
        IEnumerable<AutoCompleteDocument<Guid>> documents,
        SetOptions? options = null,
        CancellationToken cancellationToken = default);

    Task<SetResponse> SetAsync<TValue>(
        AutoCompleteDocument<TValue> document,
        SetOptions? options = null,
        CancellationToken cancellationToken = default) where TValue : notnull;

    Task<SetResponse> SetMultiAsync<TValue>(
        IEnumerable<AutoCompleteDocument<TValue>> documents,
        SetOptions? options = null,
        CancellationToken cancellationToken = default) where TValue : notnull;

    Task<SetResponse> SetAsync<TAudoCompleteDocument, TValue>(
        TAudoCompleteDocument document,
        SetOptions? options = null,
        CancellationToken cancellationToken = default) where TAudoCompleteDocument : AutoCompleteDocument<TValue> where TValue : notnull;

    Task<SetResponse> SetMultiAsync<TAudoCompleteDocument, TValue>(
        IEnumerable<TAudoCompleteDocument> documents,
        SetOptions? options = null,
        CancellationToken cancellationToken = default) where TAudoCompleteDocument : AutoCompleteDocument<TValue> where TValue : notnull;

    Task<DeleteResponse> DeleteAsync(string id);

    Task<DeleteResponse> DeleteAsync<T>(T id) where T : notnull;

    Task<DeleteMultiResponse> DeleteMultiAsync(IEnumerable<string> ids);

    Task<DeleteMultiResponse> DeleteMultiAsync<T>(IEnumerable<T> ids) where T : notnull;
}
