// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.Ddd.Domain.Entities.Full;

public abstract class FullAggregateRoot<TUserId>
    : AuditAggregateRoot<TUserId>, IFullAggregateRoot<TUserId>
{
    public bool IsDeleted { get; protected set; }
}

public abstract class FullAuditAggregateRoot<TKey, TUserId>
    : AuditAggregateRoot<TKey, TUserId>, IFullAuditAggregateRoot<TKey, TUserId>
{
    public bool IsDeleted { get; protected set; }
}
