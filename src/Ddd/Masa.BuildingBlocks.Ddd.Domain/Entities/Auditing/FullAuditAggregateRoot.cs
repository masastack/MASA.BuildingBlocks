// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.Ddd.Domain.Entities.Auditing;

public abstract class FullAuditAggregateRoot<TUserId>
    : AuditAggregateRoot<TUserId>, IFullAuditAggregateRoot<TUserId>, ISoftDelete
{
    public bool IsDeleted { get; protected set; }
}

public abstract class FullAuditAggregateRoot<TKey, TUserId>
    : AuditAggregateRoot<TKey, TUserId>, IFullAuditAggregateRoot<TKey, TUserId>, ISoftDelete
{
    public bool IsDeleted { get; protected set; }
}
