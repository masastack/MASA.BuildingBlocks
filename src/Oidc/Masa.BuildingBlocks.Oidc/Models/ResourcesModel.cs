namespace Masa.BuildingBlocks.Oidc.Storage.Models;

public class ResourcesModel
{
    /// <summary>
    /// Gets or sets a value indicating whether [offline access].
    /// </summary>
    public bool OfflineAccess { get; set; }

    public IEnumerable<IdentityResourceModel>? IdentityResources { get; set; }

    public IEnumerable<ApiResourceModel>? ApiResources { get; set; }

    public IEnumerable<ApiScopeModel>? ApiScopes { get; set; }

    public ResourcesModel(ResourcesModel other) : this(other.IdentityResources, other.ApiResources, other.ApiScopes)
    {
        OfflineAccess = other.OfflineAccess;
    }

    public ResourcesModel(IEnumerable<IdentityResourceModel>? identityResources, IEnumerable<ApiResourceModel>? apiResources, IEnumerable<ApiScopeModel>? apiScopes)
    {
        IdentityResources = identityResources;
        ApiResources = apiResources;
        ApiScopes = apiScopes;
    }
}

