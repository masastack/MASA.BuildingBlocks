// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.Oidc.Domain.Entities;

public class ClientScope : Entity<int>
{
    public string Scope { get; private set; } = string.Empty;

    public int ClientId { get; private set; }

    public Client Client { get; private set; } = null!;

    public ClientScope(string scope)
    {
        Scope = scope;
    }
}
