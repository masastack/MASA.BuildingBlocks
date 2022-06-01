// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.Data.Mapping;

public class MapperFactory
{
    private readonly IServiceCollection _services;

    internal IMapperExtension Extension { get; set; } = default!;

    public static MapperFactory Instance = new();

    public MapperFactory() => _services = new ServiceCollection();

    public void ConfigurationMapperOptions(IMapperExtension extension) => Extension = extension;

    public Mapper CreateMapper()
    {
        Extension.AddService(_services);
        var mapper = new Mapper(_services);
        Mapper.Instance ??= mapper;
        return mapper;
    }
}
