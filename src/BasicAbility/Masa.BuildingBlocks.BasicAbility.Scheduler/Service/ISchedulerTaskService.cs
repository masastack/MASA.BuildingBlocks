// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.BasicAbility.Scheduler.Service;

public interface ISchedulerTaskService
{
    Task<bool> StopSchedulerTaskAsync(BaseSchedulerTaskRequest request);

    Task<bool> StartSchedulerTaskAsync(BaseSchedulerTaskRequest request);
}
