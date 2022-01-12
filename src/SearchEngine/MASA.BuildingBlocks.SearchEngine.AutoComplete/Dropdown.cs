namespace MASA.BuildingBlocks.SearchEngine.AutoComplete;
public class DropdownBox<TValue>
{
    public string Id { get; set; }

    public string Text { get; set; }

    public TValue Value { get; set; }


    public DropdownBox()
    {
    }

    public DropdownBox(string text, TValue value) : this()
    {
        Text = text;
        Value = value;
        Id = GetId();
    }

    public DropdownBox(string id, string text, TValue value) : this(text, value)
    {
        Id = id;
    }

    protected virtual string GetId()
    {
        return $"[{Value}]{Text}";
    }
}
