// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    internal abstract partial class InternalRunStepDeltaStepDetailsToolCallsObjectToolCallsObject
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; }
        protected InternalRunStepDeltaStepDetailsToolCallsObjectToolCallsObject()
        {
        }

        internal InternalRunStepDeltaStepDetailsToolCallsObjectToolCallsObject(string type, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Type = type;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal string Type { get; set; }
    }
}
