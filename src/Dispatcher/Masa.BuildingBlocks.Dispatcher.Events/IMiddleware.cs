// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.Dispatcher.Events;

public delegate Task EventHandlerDelegate();

/// <summary>
/// Middleware is assembled into an event pipeline to handle invoke event and result
/// </summary>
public interface IMiddleware<TEvent>
    where TEvent : IEvent
{
    Task HandleAsync(TEvent @event, EventHandlerDelegate next);

    /// <summary>
    /// If loops are not supported, execute only once
    /// If looping is supported, EventBus will be executed multiple times when nested
    /// </summary>
    bool SupportLoop { get; }
}
