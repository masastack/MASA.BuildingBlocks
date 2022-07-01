// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.BasicAbility.Mc.Model;

public class MessageTaskUpsertModel
{
    public string DisplayName { get; set; } = string.Empty;

    public Guid ChannelId { get; set; }

    public ChannelTypes? ChannelType { get; set; }

    public MessageTypes EntityType { get; set; }

    public Guid EntityId { get; set; }

    public bool IsDraft { get; set; }

    public bool IsEnabled { get; set; }

    public SendTargets ReceiverType { get; set; }

    public MessageTaskSelectRecipientTypes SelectReceiverType { get; set; } = MessageTaskSelectRecipientTypes.ManualSelection;

    public string Sign { get; set; } = string.Empty;

    public List<MessageTaskReceiverModel> Receivers { get; set; } = new();

    public SendRuleModel SendRules { get; set; } = new();

    public MessageInfoUpsertModel MessageInfo { get; set; } = new();

    public ExtraPropertyDictionary Variables { get; set; } = new();
}
