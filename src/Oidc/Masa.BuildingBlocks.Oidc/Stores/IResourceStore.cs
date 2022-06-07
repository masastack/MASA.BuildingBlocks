using Masa.BuildingBlocks.Oidc.Storage.Models;

namespace Masa.BuildingBlocks.Oidc.Storage.Stores;

public interface IResourceStore
{
    /// <summary>
    /// Gets identity resources by scope name.
    /// </summary>
    /// <param name="scopeNames"></param>
    /// <returns></returns>
    Task<IEnumerable<IdentityResource>> FindIdentityResourcesByScopeNameAsync(IEnumerable<string> scopeNames);

    /// <summary>
    /// Gets API scopes by scope name.
    /// </summary>
    /// <param name="scopeNames"></param>
    /// <returns></returns>
    Task<IEnumerable<ApiScope>> FindApiScopesByNameAsync(IEnumerable<string> scopeNames);

    /// <summary>
    /// Gets API resources by scope name.
    /// </summary>
    /// <param name="scopeNames"></param>
    /// <returns></returns>
    Task<IEnumerable<ApiResource>> FindApiResourcesByScopeNameAsync(IEnumerable<string> scopeNames);

    /// <summary>
    /// Gets API resources by API resource name.
    /// </summary>
    /// <param name="apiResourceNames"></param>
    /// <returns></returns>
    Task<IEnumerable<ApiResource>> FindApiResourcesByNameAsync(IEnumerable<string> apiResourceNames);

    /// <summary>
    /// Gets all resources.
    /// </summary>
    /// <returns></returns>
    Task<Resources> GetAllResourcesAsync();
}

