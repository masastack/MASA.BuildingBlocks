namespace MASA.BuildingBlocks.SearchEngine.AutoComplete;
public class Dropdown<TValue> where TValue : struct
{
    public string Id { get; set; }

    public string Text { get; set; }

    public TValue Value { get; set; }

    public Dropdown()
    {
    }

    public Dropdown(string text, TValue value) : this()
    {
        Id = $"[{value}]{text}";
        Text = text;
        Value = value;
    }

    public Dropdown(string id, string text, TValue value) : this(text, value)
    {
        Id = id;
    }
}
