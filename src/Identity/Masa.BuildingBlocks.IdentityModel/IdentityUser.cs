// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.IdentityModel;

public class IdentityUser
{
    public virtual string Id { get; set; }

    public virtual string? UserName { get; set; }

    public string? TenantId { get; set; }

    public string? Environment { get; set; }
}
