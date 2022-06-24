// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.BasicAbility.Tsc.Service;

public interface IMetricService
{
    Task<IEnumerable<string>> GetMetricsAsync(IEnumerable<string>? match);

    Task<Dictionary<string, List<string>>> GetLabelAndValuesAsync(MetricLableValuesRequest query);

    Task<string> GetMetricAggAsync(MetricAggRequest query);
}
