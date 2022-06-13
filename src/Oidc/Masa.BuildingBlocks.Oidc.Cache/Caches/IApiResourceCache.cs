// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.Oidc.Cache.Caches;

public interface IApiResourceCache
{
    Task<List<ApiResourceModel>> GetListAsync(IEnumerable<string> names);

    Task<List<ApiResourceModel>> GetListAsync();

    Task SetAsync(ApiResource apiResource);

    Task SetRangeAsync(IEnumerable<ApiResource> apiResources);

    Task RemoveAsync(ApiResource apiResource);

    Task AddAllAsync(IEnumerable<ApiResource> identityResources);
}