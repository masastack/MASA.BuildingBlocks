// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.Data;

public interface IIdGenerator<in T,out T2>
    where T : notnull
    where T2 : notnull
{
    public T2 Create();
}
