namespace Masa.BuildingBlocks.Oidc.Model;

public class Resources
{
    /// <summary>
    /// Gets or sets a value indicating whether [offline access].
    /// </summary>
    public bool OfflineAccess { get; set; }

    public IEnumerable<IdentityResource>? IdentityResources { get; set; }

    public IEnumerable<ApiResource>? ApiResources { get; set; }

    public IEnumerable<ApiScope>? ApiScopes { get; set; }

    public Resources(Resources other) : this(other.IdentityResources, other.ApiResources, other.ApiScopes)
    {
        OfflineAccess = other.OfflineAccess;
    }

    public Resources(IEnumerable<IdentityResource>? identityResources, IEnumerable<ApiResource>? apiResources, IEnumerable<ApiScope>? apiScopes)
    {
        IdentityResources = identityResources;
        ApiResources = apiResources;
        ApiScopes = apiScopes;
    }
}

