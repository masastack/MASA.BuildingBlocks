namespace Masa.BuildingBlocks.SearchEngine.AutoComplete;

public abstract class BaseAutoCompleteClient : IAutoCompleteClient
{
    public virtual Task<GetResponse<AutoCompleteDocument<Guid>, Guid>> GetAsync(string keyword, AutoCompleteOptions? options = null,
        CancellationToken cancellationToken = default)
        => GetAsync<Guid>(keyword, options, cancellationToken);

    public virtual Task<GetResponse<AutoCompleteDocument<TValue>, TValue>> GetAsync<TValue>(string keyword,
        AutoCompleteOptions? options = null,
        CancellationToken cancellationToken = default) where TValue : notnull
        => GetAsync<AutoCompleteDocument<TValue>, TValue>(keyword, options, cancellationToken);

    public abstract Task<GetResponse<TAudoCompleteDocument, TValue>> GetAsync<TAudoCompleteDocument, TValue>(string keyword,
        AutoCompleteOptions? options = null,
        CancellationToken cancellationToken = default) where TAudoCompleteDocument : AutoCompleteDocument<TValue> where TValue : notnull;

    public virtual Task<SetResponse> SetAsync(AutoCompleteDocument<Guid> document, SetOptions? options = null,
        CancellationToken cancellationToken = default)
        => SetAsync<AutoCompleteDocument<Guid>, Guid>(document, options, cancellationToken);

    public virtual Task<SetResponse> SetMultiAsync(IEnumerable<AutoCompleteDocument<Guid>> documents, SetOptions? options = null,
        CancellationToken cancellationToken = default)
        => SetMultiAsync<AutoCompleteDocument<Guid>, Guid>(documents, options, cancellationToken);

    public virtual Task<SetResponse> SetAsync<TValue>(AutoCompleteDocument<TValue> document, SetOptions? options = null,
        CancellationToken cancellationToken = default) where TValue : notnull
        => SetAsync<AutoCompleteDocument<TValue>, TValue>(document, options, cancellationToken);

    public virtual Task<SetResponse> SetMultiAsync<TValue>(IEnumerable<AutoCompleteDocument<TValue>> documents, SetOptions? options = null,
        CancellationToken cancellationToken = default) where TValue : notnull
        => SetMultiAsync<AutoCompleteDocument<TValue>, TValue>(documents, options, cancellationToken);

    public virtual Task<SetResponse> SetAsync<TAudoCompleteDocument, TValue>(TAudoCompleteDocument document, SetOptions? options = null,
        CancellationToken cancellationToken = default) where TAudoCompleteDocument : AutoCompleteDocument<TValue> where TValue : notnull
        => SetMultiAsync<TAudoCompleteDocument, TValue>(new List<TAudoCompleteDocument> { document }, options, cancellationToken);

    public abstract Task<SetResponse> SetMultiAsync<TAudoCompleteDocument, TValue>(IEnumerable<TAudoCompleteDocument> documents,
        SetOptions? options = null,
        CancellationToken cancellationToken = default) where TAudoCompleteDocument : AutoCompleteDocument<TValue> where TValue : notnull;

    public abstract Task<DeleteResponse> DeleteAsync(string id);

    public virtual Task<DeleteResponse> DeleteAsync<T>(T id) where T : notnull
        => DeleteAsync(id!.ToString() ?? throw new ArgumentNullException($"{id} is not null", nameof(id)));

    public abstract Task<DeleteMultiResponse> DeleteMultiAsync(IEnumerable<string> ids);

    public virtual Task<DeleteMultiResponse> DeleteMultiAsync<T>(IEnumerable<T> ids) where T : notnull
    {
        var type = typeof(T);
        if (!type.IsPrimitive && type != typeof(Guid) && type != typeof(string))
            throw new NotSupportedException("Unsupported types, id only supports simple types or guid, string");

        return DeleteMultiAsync(ids.Select(id => id.ToString() ?? throw new ArgumentNullException($"{id} is not null", nameof(id))));
    }
}
