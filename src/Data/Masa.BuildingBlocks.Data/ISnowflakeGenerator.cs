// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.Data;

public interface ISnowflakeGenerator : IIdGenerator<long>
{
    public long Generate(int workerId);

    public long Generate(TimestampType timestampType, int workerId);
}
