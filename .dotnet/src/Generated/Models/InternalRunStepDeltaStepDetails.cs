// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    internal abstract partial class InternalRunStepDeltaStepDetails
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; }
        protected InternalRunStepDeltaStepDetails()
        {
        }

        internal InternalRunStepDeltaStepDetails(string type, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Type = type;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal string Type { get; set; }
    }
}
