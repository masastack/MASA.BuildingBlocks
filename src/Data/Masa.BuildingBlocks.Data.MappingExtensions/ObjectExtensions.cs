// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace System;

public static class ObjectExtensions
{
    public static TDestination Map<TSource, TDestination>(this TSource source, MapOptions? options = null)
        => Mapper.Map<TSource, TDestination>(source, options);

    public static TDestination Map<TDestination>(this object obj, MapOptions? options = null)
        => Mapper.Map<TDestination>(obj, options);

    public static TDestination Map<TSource, TDestination>(this TSource source, TDestination destination, MapOptions? options = null)
        => Mapper.Map(source, destination, options);
}
