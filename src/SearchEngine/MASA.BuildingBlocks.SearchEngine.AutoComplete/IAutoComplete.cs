namespace MASA.BuildingBlocks.SearchEngine.AutoComplete;

public interface IAutoComplete
{
    GetResponse<Dropdown<TValue>, TValue> Get<TValue>(string query, AutoCompleteOptions? options = null)
        where TValue : struct;

    GetResponse<TResponse, TValue> Get<TResponse, TValue>(string query, AutoCompleteOptions? options = null)
        where TResponse : Dropdown<TValue>
        where TValue : struct;

    SetResponse Set<TValue>(params Dropdown<TValue>[] results)
        where TValue : struct;

    SetResponse Set<TResponse, TValue>(params TResponse[] results)
        where TResponse : Dropdown<TValue>
        where TValue : struct;
}
