// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.Oidc.Models.Enums;

public enum AccessTokenType
{
    [Description("Self-contained Json Web Token")]
    Jwt,
    [Description("Reference token")]
    Reference
}

