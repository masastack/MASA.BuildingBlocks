// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.BasicAbility.Mc.Model;

public class GetWebsiteMessageModel 
{
    public int Page { get; set; } = 1;

    public int PageSize { get; set; } = 10;

    public string Sorting { get; set; }

    public string Filter { get; set; } = string.Empty;

    public WebsiteMessageFilterType? FilterType { get; set; }

    public Guid? ChannelId { get; set; }

    public bool? IsRead { get; set; }
}
