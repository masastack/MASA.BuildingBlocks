namespace MASA.BuildingBlocks.Configuration;
public class Properties
{
    private readonly Dictionary<string, string> _dict;

    public Properties() => _dict = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

    public Properties(IDictionary<string, string>? dictionary) =>
        _dict = dictionary == null
            ? new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            : new Dictionary<string, string>(dictionary, StringComparer.OrdinalIgnoreCase);

    public Properties(Properties source) => _dict = source._dict;

    public bool TryGetProperty(string key, [NotNullWhen(true)] out string? value) => _dict.TryGetValue(key, out value);

    public string? GetProperty(string key)
    {
        _dict.TryGetValue(key, out var result);

        return result;
    }

    public ISet<string> GetPropertyNames() => new HashSet<string>(_dict.Keys);
}
