// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.Data;

public class SerializerOptionsBuilder
{
    public string Name { get; set; }

    public Func<IServiceProvider, ISerializer> Func { get; set; }

    public bool? IsDefault { get; set; }

    public SerializerOptionsBuilder() { }

    public SerializerOptionsBuilder(string name, Func<IServiceProvider, ISerializer> func, bool? isDefault)
    {
        Name = name;
        Func = func;
        IsDefault = isDefault;
    }
}
