namespace Masa.BuildingBlocks.Oidc.Storage.Models;

public class ApiResource : Resource
{
    public ICollection<string>? Scopes { get; set; }

    public ICollection<Secret>? ApiSecrets { get; set; }

    public ICollection<string>? AllowedAccessTokenSigningAlgorithms { get; set; }

    public ApiResource(string name, string? displayName = null, ICollection<string>? userClaims = null)
    {
        Name = name;
        DisplayName = displayName ?? name;
        if (userClaims is not null) UserClaims = userClaims;
    }

    public ApiResource(string name, string displayName, string? description, bool enabled, bool showInDiscoveryDocument, ICollection<string>? userClaims, ICollection<string>? scopes, IDictionary<string, string>? properties, ICollection<Secret>? apiSecrets, ICollection<string>? allowedAccessTokenSigningAlgorithms) : this(name, displayName, userClaims)
    {
        Description = description;
        Enabled = enabled;
        ShowInDiscoveryDocument = showInDiscoveryDocument;
        Scopes = scopes;
        Properties = properties;
        ApiSecrets = apiSecrets;
        AllowedAccessTokenSigningAlgorithms = allowedAccessTokenSigningAlgorithms;
    }
}

