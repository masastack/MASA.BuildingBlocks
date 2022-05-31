// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.Data.Mapping;

public class MapperConfiguration
{
    private readonly IServiceCollection _services;

    internal IMapperOptionsExtension Extension { get; set; } = default!;

    public static MapperConfiguration Instance = new();

    public MapperConfiguration() => _services = new ServiceCollection();

    public void ConfigurationMapperOptions(IMapperOptionsExtension extension) => Extension = extension;

    public Mapper CreateMapper()
    {
        Extension.AddService(_services);
        return new(_services);
    }
}
