namespace Masa.BuildingBlocks.Oidc.Model;

public class ApiScope : Resource
{
    public bool Required { get; set; }

    public bool Emphasize { get; set; }

    public ApiScope(string name, string? displayName = null, ICollection<string>? userClaims = null)
    {
        Name = name;
        DisplayName = displayName ?? name;
        if (userClaims is not null) UserClaims = userClaims;
    }

    public ApiScope(string name, string displayName, string? description, bool enabled, bool showInDiscoveryDocument, bool required, bool emphasize, ICollection<string>? userClaims, IDictionary<string, string>? properties) : this(name, displayName, userClaims)
    {
        Description = description;
        Enabled = enabled;
        ShowInDiscoveryDocument = showInDiscoveryDocument;
        Required = required;
        Emphasize = emphasize;
        Properties = properties;
    }
}

