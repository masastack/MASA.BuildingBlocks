// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

using Masa.BuildingBlocks.BasicAbility.Tsc.Service;

namespace Masa.BuildingBlocks.BasicAbility.Tsc;

public interface ITscClient
{
    public ILogService LogService { get; init; }

    public IMetricService MetricService { get; init; }
}
