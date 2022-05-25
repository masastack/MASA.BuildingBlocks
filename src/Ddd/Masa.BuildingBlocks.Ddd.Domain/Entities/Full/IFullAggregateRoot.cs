// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.Ddd.Domain.Entities.Full;

public interface IFullAggregateRoot<TUserId> : IAuditAggregateRoot<TUserId>, ISoftDelete
{

}

public interface IFullAggregateRoot<TKey, TUserId> : IAuditAggregateRoot<TKey, TUserId>, ISoftDelete
{

}
