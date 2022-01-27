﻿using Orleans.Concurrency;

namespace Vertex.Abstractions.Event
{
    /// <summary>
    /// Record the meta information of the event
    /// </summary>
    [Immutable]
    public record EventMeta
    {
        public string FlowId { get; set; }

        /// <summary>
        /// Used to describe the sequence of events produced by an actor
        /// </summary>
        public long Version { get; init; }

        /// <summary>
        /// Records the timestamp generated by the event, accurate to seconds
        /// </summary>
        public long Timestamp { get; init; }
    }
}
