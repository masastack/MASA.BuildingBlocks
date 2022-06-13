// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.Oidc.Domain.Entities;

public class ApiResourceProperty : Property
{
    public int ApiResourceId { get; private set; }

    public ApiResource ApiResource { get; private set; } = null!;
}

