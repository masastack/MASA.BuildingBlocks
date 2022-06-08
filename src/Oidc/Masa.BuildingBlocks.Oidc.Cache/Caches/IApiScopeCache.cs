// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.Oidc.Cache.Caches;

public interface IApiScopeCache
{
    Task<List<ApiScopeModel>> GetListAsync(IEnumerable<string> names);

    Task<List<ApiScopeModel>> GetListAsync();

    Task AddOrUpdateAsync(ApiScope ApiScope);

    Task RemoveAsync(ApiScope ApiScope);
}
