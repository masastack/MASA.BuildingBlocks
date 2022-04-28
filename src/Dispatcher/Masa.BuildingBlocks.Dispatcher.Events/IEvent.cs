// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.Dispatcher.Events;

public interface IEvent
{
    [JsonIgnore]
    Guid Id { get; }

    [JsonIgnore]
    DateTime CreationTime { get; }
}

public interface IEvent<TResult> : IEvent
    where TResult : notnull
{
    TResult Result { get; set; }
}
