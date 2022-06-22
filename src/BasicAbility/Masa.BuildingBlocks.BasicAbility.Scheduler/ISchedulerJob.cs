// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.BasicAbility.Scheduler;

public interface ISchedulerJob
{
    Action<JobContext> BeforeExcute { get; }

    Action<JobContext> AfterExcute { get; }
}
