// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.IdentityModel;

public enum IdentityType
{
    /// <summary>
    /// Only use user information
    /// </summary>
    Simple = 1,

    /// <summary>
    /// User Information + Multi-tenant
    /// </summary>
    MultiTenant,

    /// <summary>
    /// User Information + Multi-Environment
    /// </summary>
    MultiEnvironment,

    /// <summary>
    /// User Information + Multi-tenant + Multi-Environment
    /// </summary>
    Isolation
}
