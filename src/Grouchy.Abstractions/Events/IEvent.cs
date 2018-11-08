using System;
using System.Collections.Generic;

namespace Grouchy.Abstractions.Events
{
    public interface IEvent
    {
        string EventType { get; }

        DateTimeOffset Timestamp { get; }

        IDictionary<string, object> Tags { get; }
    }
}