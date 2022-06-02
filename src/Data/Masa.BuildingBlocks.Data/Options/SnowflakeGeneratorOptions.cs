// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.Data;

public class SnowflakeGeneratorOptions
{
    public TimestampType TimestampType { get; set; }

    public uint? WorkerId { get; private set; }

    public uint? BusinessId { get; private set;}

    public SnowflakeGeneratorOptions() => TimestampType = TimestampType.Milliseconds;

    public SnowflakeGeneratorOptions(uint workerId, uint businessId)
    {
        WorkerId = workerId;
        BusinessId = businessId;
    }

    public SnowflakeGeneratorOptions SetWorkerId(uint workerId)
    {
        WorkerId = workerId;
        return this;
    }

    public SnowflakeGeneratorOptions SetBusinessId(uint businessId)
    {
        BusinessId = businessId;
        return this;
    }
}
