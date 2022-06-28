// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.BasicAbility.Scheduler.Service;

public interface ISchedulerJobService
{
    Task<Guid> AddSchedulerJobAsync(AddSchedulerJobRequest job);

    Task<bool> StartSchedulerJobAsync(BaseSchedulerJobRequest request);

    Task<bool> RemoveSchedulerJobAsync(BaseSchedulerJobRequest request);

    Task<bool> EnableSchedulerJob(BaseSchedulerJobRequest request);

    Task<bool> DisableSchedulerJob(BaseSchedulerJobRequest request);
}
