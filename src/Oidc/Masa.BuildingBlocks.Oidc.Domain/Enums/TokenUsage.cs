// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.Oidc.Domain.Enums;

/// <summary>
/// Token usage types.
/// </summary>
public enum TokenUsage
{
    /// <summary>
    /// Re-use the refresh token handle
    /// </summary>
    ReUse = 0,

    /// <summary>
    /// Issue a new refresh token handle every time
    /// </summary>
    OneTimeOnly = 1
}
