// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.Http.Parser;

public interface IParserProvider
{
    string Name { get; }

    Task<bool> ResolveAsync(IServiceProvider serviceProvider, string key, Action<string> action);
}
