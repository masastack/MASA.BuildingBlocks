namespace Masa.BuildingBlocks.SearchEngine.AutoComplete;
public class AutoCompleteDocument<TValue> where TValue : notnull
{
    private string _id;

    public string Id
    {
        get
        {
            if (string.IsNullOrEmpty(_id))
                return Value?.ToString() ?? throw new ArgumentException("{Id} cannot be empty", nameof(Id));

            return _id;
        }
        init
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("{Id} cannot be empty", nameof(Id));

            _id = value;
        }
    }

    public string Text { get; set; }

    public TValue Value { get; set; }

    public AutoCompleteDocument()
    {
    }

    public AutoCompleteDocument(string text, TValue value)
        : this(value?.ToString() ?? throw new ArgumentException($"{value} cannot be empty", nameof(value)), text, value)
    {
    }

    public AutoCompleteDocument(string id, string text, TValue value) : this()
    {
        Id = id;
        Text = text;
        Value = value;
    }
}
