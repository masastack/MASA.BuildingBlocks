// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.Oidc.Models.Enums;

public enum TokenUsage
{
    [Description("Re-use the refresh token handle")]
    ReUse,
    [Description("Issue a new refresh token handle every time")]
    OneTimeOnly
}

