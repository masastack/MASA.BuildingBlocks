// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.BasicAbility.Tsc.Model;

public class MetricLableValuesRequest
{
    [JsonIgnore]
    public string Match { get { return _match[0]; } set { _match[0] = value; } }

    private string[] _match = new string[1];

    [JsonPropertyName("match")]
    public IEnumerable<string> Matches { get { return _match; } }

    public DateTime Start { get; set; }

    public DateTime End { get; set; }
}
