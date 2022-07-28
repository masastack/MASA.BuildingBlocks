// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.Data.TypeConverts;

public class TypeConvertOptionsBuilder
{
    public string Name { get; set; }

    public Func<IServiceProvider, ITypeConvertProvider> Func { get; set; }

    public bool? IsDefault { get; set; }

    public TypeConvertOptionsBuilder() { }

    public TypeConvertOptionsBuilder(string name, Func<IServiceProvider, ITypeConvertProvider> func, bool? isDefault)
    {
        Name = name;
        Func = func;
        IsDefault = isDefault;
    }
}
