// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.Ddd.Domain.Entities.Auditing;

public abstract class AuditAggregateRoot<TUserId> : AuditEntity<TUserId>, IAuditAggregateRoot<TUserId>
{

}

public abstract class AuditAggregateRoot<TKey, TUserId> : AuditEntity<TKey, TUserId>, IAuditAggregateRoot<TKey, TUserId>
{

}
