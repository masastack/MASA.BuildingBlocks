namespace Masa.BuildingBlocks.Oidc.Model;

public class Secret
{
    public string? Value { get; set; }

    public string? Description { get; set; }
  
    public DateTime? Expiration { get; set; }

    public string Type { get; set; } = "SharedSecret";

    public Secret(string? value = null, string? description = null, DateTime? expiration = null)
    {
        Value = value;
        Description = description;
        Expiration = expiration;
    }

    public override int GetHashCode()
    {
        return (17 * 23 + (Value?.GetHashCode() ?? 0)) * 23 + Type.GetHashCode();
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if(obj is Secret secret)
        {
            if (secret == this) return true;
            return string.Equals(secret.Type, Type, StringComparison.Ordinal) && string.Equals(secret.Value, Value, StringComparison.Ordinal);
        }

        return false;
    }
}

