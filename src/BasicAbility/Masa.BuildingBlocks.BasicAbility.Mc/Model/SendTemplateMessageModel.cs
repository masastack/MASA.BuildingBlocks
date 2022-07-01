// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.BasicAbility.Mc.Model;

public class SendTemplateMessageModel
{
    public Guid ChannelId { get; set; }

    public ChannelTypes? ChannelType { get; set; }

    public Guid EntityId { get; set; }

    public ReceiverTypes ReceiverType { get; set; }

    public string Sign { get; set; } = string.Empty;

    public List<MessageTaskReceiverModel> Receivers { get; set; } = new();

    public SendRuleModel SendRules { get; set; } = new();

    public ExtraPropertyDictionary Variables { get; set; } = new();

    public static implicit operator MessageTaskUpsertModel(SendTemplateMessageModel model)
    {
        return new MessageTaskUpsertModel
        {
            ChannelId = model.ChannelId,
            ChannelType = model.ChannelType,
            EntityType = MessageTypes.Template,
            EntityId = model.EntityId,
            IsDraft = false,
            IsEnabled = true,
            ReceiverType = model.ReceiverType,
            SelectReceiverType = MessageTaskSelectRecipientTypes.ManualSelection,
            Sign = model.Sign,
            Receivers = model.Receivers,
            SendRules = model.SendRules,
            Variables = model.Variables,
        };
    }
}
