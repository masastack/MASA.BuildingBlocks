// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.BasicAbility.Mc.Model;

public class SendOrdinaryMessageModel
{
    public Guid ChannelId { get; set; }

    public ChannelTypes? ChannelType { get; set; }

    public SendTargets ReceiverType { get; set; }

    public List<MessageTaskReceiverModel> Receivers { get; set; } = new();

    public SendRuleModel SendRules { get; set; } = new();

    public MessageInfoUpsertModel MessageInfo { get; set; } = new();

    public ExtraPropertyDictionary Variables { get; set; } = new();

    public static implicit operator MessageTaskUpsertModel(SendOrdinaryMessageModel model)
    {
        return new MessageTaskUpsertModel
        {
            ChannelId = model.ChannelId,
            ChannelType = model.ChannelType,
            EntityType = MessageTypes.Ordinary,
            IsDraft = false,
            IsEnabled = true,
            ReceiverType = model.ReceiverType,
            SelectReceiverType = MessageTaskSelectReceiverTypes.ManualSelection,
            Receivers = model.Receivers,
            SendRules = model.SendRules,
            MessageInfo = model.MessageInfo,
            Variables = model.Variables,
            Source = MessageTaskSources.SDK
        };
    }
}
