// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.Ddd.Domain.Entities.Auditing;

public abstract class FullAuditEntity<TUserId>
    : AuditEntity<TUserId>, IFullAuditEntity<TUserId>
{
    public bool IsDeleted { get; protected set; }
}

public abstract class FullAuditEntity<TKey, TUserId>
    : AuditEntity<TKey, TUserId>, IFullAuditEntity<TKey, TUserId>
{
    public bool IsDeleted { get; protected set; }
}
