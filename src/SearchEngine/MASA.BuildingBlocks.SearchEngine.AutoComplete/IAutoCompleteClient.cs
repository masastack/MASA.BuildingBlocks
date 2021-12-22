namespace MASA.BuildingBlocks.SearchEngine.AutoComplete;

public interface IAutoCompleteClient
{
    Task<GetResponse<Dropdown<TValue>, TValue>> GetAsync<TValue>(
        string value,
        AutoCompleteOptions? options = null,
        CancellationToken cancellationToken = default)
        where TValue : struct;

    Task<GetResponse<TResponse, TValue>> GetAsync<TResponse, TValue>(
        string value,
        AutoCompleteOptions? options = null,
        CancellationToken cancellationToken = default)
        where TResponse : Dropdown<TValue>
        where TValue : struct;

    SetResponse Set<TValue>(
        Dropdown<TValue>[] results,
        CancellationToken cancellationToken = default)
        where TValue : struct;

    SetResponse Set<TResponse, TValue>(
        TResponse[] results,
        CancellationToken cancellationToken = default)
        where TResponse : Dropdown<TValue>
        where TValue : struct;
}
