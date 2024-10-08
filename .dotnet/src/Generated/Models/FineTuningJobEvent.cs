// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.FineTuning
{
    internal partial class FineTuningJobEvent
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
        internal FineTuningJobEvent(string id, DateTimeOffset createdAt, FineTuningJobEventLevel level, string message)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(message, nameof(message));

            Id = id;
            CreatedAt = createdAt;
            Level = level;
            Message = message;
        }

        internal FineTuningJobEvent(string id, DateTimeOffset createdAt, FineTuningJobEventLevel level, string message, InternalFineTuningJobEventObject @object, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            CreatedAt = createdAt;
            Level = level;
            Message = message;
            Object = @object;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal FineTuningJobEvent()
        {
        }

        public string Id { get; }
        public DateTimeOffset CreatedAt { get; }
        public FineTuningJobEventLevel Level { get; }
        public string Message { get; }
        public InternalFineTuningJobEventObject Object { get; } = InternalFineTuningJobEventObject.FineTuningJobEvent;
    }
}
