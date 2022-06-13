// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.IdentityModel;

public class IdentityMultiTenantUser : IdentityUser, IIdentityMultiTenantUser
{
    public string? TenantId { get; set; }
}
