// Copyright (c) MASA Stack All rights reserved.
// Licensed under the Apache License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.BasicAbility.Scheduler.Model;

public class JobContext
{
    public DateTimeOffset ExcuteTime { get; set; }

    public string ExcuteMethodName { get; set; } = string.Empty;
}
