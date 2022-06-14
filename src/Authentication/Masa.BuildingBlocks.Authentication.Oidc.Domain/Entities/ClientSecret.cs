// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

using Masa.BuildingBlocks.Authentication.Oidc.Domain.Entities.Abstract;

namespace Masa.BuildingBlocks.Authentication.Oidc.Domain.Entities;

public class ClientSecret : Secret
{
    public int ClientId { get; private set; }

    public Client Client { get; private set; } = null!;
}