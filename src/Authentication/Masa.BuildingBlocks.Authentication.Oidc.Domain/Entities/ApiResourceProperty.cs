// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

using Masa.BuildingBlocks.Authentication.Oidc.Domain.Entities.Abstract;

namespace Masa.BuildingBlocks.Authentication.Oidc.Domain.Entities;

public class ApiResourceProperty : Property
{
    public int ApiResourceId { get; private set; }

    public ApiResource ApiResource { get; private set; } = null!;

    public ApiResourceProperty(string key, string value)
    {
        Key = key;
        Value = value;
    }
}

