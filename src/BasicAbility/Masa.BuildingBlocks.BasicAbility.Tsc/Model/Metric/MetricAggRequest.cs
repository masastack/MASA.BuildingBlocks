// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.BasicAbility.Tsc.Model;

public class MetricAggRequest
{
    public string Match { get; set; }

    public IEnumerable<string> Lables { get; set; }

    public DateTime Start { get; set; }

    public DateTime End { get; set; }
}
