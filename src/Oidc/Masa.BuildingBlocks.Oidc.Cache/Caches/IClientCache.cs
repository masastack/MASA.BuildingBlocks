// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.Oidc.Cache.Caches;

public interface IClientCache
{
    Task<List<ClientModel>> GetListAsync();

    Task AddOrUpdateAsync(Client client);

    Task RemoveAsync(Client client);
}
