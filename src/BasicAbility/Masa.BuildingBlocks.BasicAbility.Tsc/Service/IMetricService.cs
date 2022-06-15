// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.BasicAbility.Tsc.Service;

public interface IMetricService
{
    Task<IEnumerable<string>> GetMetricsAsync();

    Task<IEnumerable<KeyValuePair<string,IEnumerable<string>>>> GetLabelAndValuesAsync();

    Task<IEnumerable<KeyValuePair<string,string>>> QueryAsync();
}
