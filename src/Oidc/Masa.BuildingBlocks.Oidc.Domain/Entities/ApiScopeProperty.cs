// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.Oidc.Domain.Entities;

public class ApiScopeProperty : Property
{
    public int ScopeId { get; private set; }

    public ApiScope Scope { get; private set; } = null!;
}
