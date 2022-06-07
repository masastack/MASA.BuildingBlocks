// Copyright (c) MASA Stack All rights reserved.
// Licensed under the Apache License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.Oidc.Domain.Enums;

/// <summary>
/// Token expiration types.
/// </summary>
public enum TokenExpiration
{
    /// <summary>
    /// Sliding token expiration
    /// </summary>
    Sliding = 0,

    /// <summary>
    /// Absolute token expiration
    /// </summary>
    Absolute = 1
}
