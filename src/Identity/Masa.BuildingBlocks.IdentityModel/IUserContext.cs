// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.IdentityModel;

public interface IUserContext
{
    IdentityUser? User { get; }

    bool IsAuthenticated { get; }

    string? UserId { get; }

    string? UserName { get; }

    string? TenantId { get; }

    string? Environment { get; }

    TUserId? GetUserId<TUserId>();

    TTenantId? GetTenantId<TTenantId>();
}
