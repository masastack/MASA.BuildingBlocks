// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.Data;

public class IdGeneratorOptions
{
    public string Name { get; set; }

    public Func<IServiceProvider, IIdGenerator> Func { get; set; }

    public IdGeneratorOptions(string name)
    {
        Name = name;
    }
}
