using System;
using System.Collections.Generic;

namespace Grouchy.Abstractions
{
    // TODO: Do other events' interfaces need to inherit this, or just the concretes?
    public interface IEvent
    {
        string EventType { get; }

        DateTimeOffset Timestamp { get; }

        IDictionary<string, object> Tags { get; }
    }
}