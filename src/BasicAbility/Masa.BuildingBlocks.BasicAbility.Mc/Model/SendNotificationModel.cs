// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.BasicAbility.Mc.Model;

public class SendNotificationModel
{
    public string MethodName { get; set; } = string.Empty;

    public string GroupId { get; set; } = string.Empty;

    public List<string> UserIds { get; set; } = new();
}
