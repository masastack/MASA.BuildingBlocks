// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.Oidc.Domain.Repositories;

public interface IClientRepository : IRepository<Client, int>
{
    Task<Client> GetByIdAsync(int id);
}