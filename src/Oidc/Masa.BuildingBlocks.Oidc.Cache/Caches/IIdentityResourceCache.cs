// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.Oidc.Cache.Caches;

public interface IIdentityResourceCache
{
    Task<List<IdentityResourceModel>> GetListAsync(IEnumerable<string> names);

    Task<List<IdentityResourceModel>> GetListAsync();

    Task AddOrUpdateAsync(IdentityResource identityResource);

    Task RemoveAsync(IdentityResource identityResource);

    Task AddAllAsync(List<IdentityResource> identityResources);
}
