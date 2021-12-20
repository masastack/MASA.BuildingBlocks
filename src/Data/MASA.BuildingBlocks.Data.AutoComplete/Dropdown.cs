namespace MASA.BuildingBlocks.Data.AutoComplete;

public class Dropdown<TValue> where TValue : struct
{
    public string Id { get; set; }

    public string Text { get; set; }

    public TValue Value { get; set; }
}
