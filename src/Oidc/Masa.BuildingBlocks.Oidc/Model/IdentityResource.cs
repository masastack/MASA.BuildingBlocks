namespace Masa.BuildingBlocks.Oidc.Model;

public class IdentityResource : Resource
{
    public bool Required { get; set; }

    public bool Emphasize { get; set; }

    public override ICollection<string> UserClaims { get; set; }

    public IdentityResource(string name, string displayName, ICollection<string> userClaims)
    {
        Name = name;
        DisplayName = displayName;
        UserClaims = userClaims;
    }

    public IdentityResource(string name, ICollection<string> userClaims) : this(name, name, userClaims)
    {
    }

    public IdentityResource(string name, string displayName, string? description, bool enabled, bool showInDiscoveryDocument, bool required, bool emphasize, ICollection<string> userClaims, IDictionary<string, string>? properties) : this(name, displayName, userClaims)
    {
        Description = description;
        Enabled = enabled;
        ShowInDiscoveryDocument = showInDiscoveryDocument;
        Required = required;
        Emphasize = emphasize;
        Properties = properties;
    }
}

