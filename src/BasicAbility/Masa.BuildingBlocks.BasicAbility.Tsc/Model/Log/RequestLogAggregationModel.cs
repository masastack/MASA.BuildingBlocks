// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.BasicAbility.Tsc.Model;

public class RequestLogAggregationModel
{
    public string IndexName { get; set; }

    public IEnumerable<KeyValuePair<string, string>> FieldMap { get; set; }

    public string Query { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }
}
