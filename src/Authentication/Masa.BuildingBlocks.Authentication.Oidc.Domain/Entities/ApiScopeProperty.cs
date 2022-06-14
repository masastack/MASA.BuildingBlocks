// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

using Masa.BuildingBlocks.Authentication.Oidc.Domain.Entities.Abstract;

namespace Masa.BuildingBlocks.Authentication.Oidc.Domain.Entities;

public class ApiScopeProperty : Property
{
    public int ScopeId { get; private set; }

    public ApiScope Scope { get; private set; } = null!;

    public ApiScopeProperty(string key, string value)
    {
        Key = key;
        Value = value;
    }
}
