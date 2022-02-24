﻿namespace MASA.Contrib.Dispatcher.Events.Tests.Events;

/// <summary>
/// Just event, not handler, so let's see what happens when you publish an event
/// </summary>
public record AddUserEvent : Event
{
    public string Account { get; set; }

    public string Phone { get; set; }

    public bool Gender { get; set; }

    public string Abstract { get; set; }
}
