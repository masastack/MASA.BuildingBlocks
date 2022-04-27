// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.Dispatcher.Events;

public delegate Task EventHandlerDelegate();

/// <summary>
/// Middleware is assembled into an event pipeline to handle invoke event and result
/// </summary>
public interface IMiddleware<TEvent>
    where TEvent : notnull, IEvent
{
    Task HandleAsync(TEvent @event, EventHandlerDelegate next);
}
