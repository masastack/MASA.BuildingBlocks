// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.Isolation.Options;

public class IsolationDbConnectionOptions
{
    public string DefaultConnection { get; set; }

    public List<DbConnectionOptions> Isolations { get; set; } = new();
}
