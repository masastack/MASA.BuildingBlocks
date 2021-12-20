namespace MASA.BuildingBlocks.Data.AutoComplete;

public interface IAutoComplete
{
    List<Dropdown<TValue>> GetList<TValue>(string keyword, AutoCompleteOptions? options = null)
        where TValue : struct;

    List<TResponse> GetList<TResponse, TValue>(string keyword, AutoCompleteOptions? options = null)
        where TResponse : Dropdown<TValue>
        where TValue : struct;

    void Set<TValue>(params Dropdown<TValue>[] results)
        where TValue : struct;

    void Set<TResponse, TValue>(params TResponse[] results)
        where TResponse : Dropdown<TValue>
        where TValue : struct;
}
