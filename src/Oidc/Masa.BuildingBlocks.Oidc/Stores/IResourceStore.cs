using Masa.BuildingBlocks.Oidc.Models.Models;

namespace Masa.BuildingBlocks.Oidc.Storage.Stores;

public interface IResourceStore
{
    /// <summary>
    /// Gets identity resources by scope name.
    /// </summary>
    /// <param name="scopeNames"></param>
    /// <returns></returns>
    Task<IEnumerable<IdentityResourceModel>> FindIdentityResourcesByScopeNameAsync(IEnumerable<string> scopeNames);

    /// <summary>
    /// Gets API scopes by scope name.
    /// </summary>
    /// <param name="scopeNames"></param>
    /// <returns></returns>
    Task<IEnumerable<ApiScopeModel>> FindApiScopesByNameAsync(IEnumerable<string> scopeNames);

    /// <summary>
    /// Gets API resources by scope name.
    /// </summary>
    /// <param name="scopeNames"></param>
    /// <returns></returns>
    Task<IEnumerable<ApiResourceModel>> FindApiResourcesByScopeNameAsync(IEnumerable<string> scopeNames);

    /// <summary>
    /// Gets API resources by API resource name.
    /// </summary>
    /// <param name="apiResourceNames"></param>
    /// <returns></returns>
    Task<IEnumerable<ApiResourceModel>> FindApiResourcesByNameAsync(IEnumerable<string> apiResourceNames);

    /// <summary>
    /// Gets all resources.
    /// </summary>
    /// <returns></returns>
    Task<ResourcesModel> GetAllResourcesAsync();
}

