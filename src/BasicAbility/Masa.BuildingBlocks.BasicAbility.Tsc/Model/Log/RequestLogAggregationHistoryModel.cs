// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.BasicAbility.Tsc.Model;

public class RequestLogAggregationHistoryModel : RequestLogAggregationModel
{
    public string Interval { get; set; }

    public bool IsDesc { get; set; }
}
