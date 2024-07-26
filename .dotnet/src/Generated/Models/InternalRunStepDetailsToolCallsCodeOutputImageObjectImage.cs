// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    internal partial class InternalRunStepDetailsToolCallsCodeOutputImageObjectImage
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; }
        internal InternalRunStepDetailsToolCallsCodeOutputImageObjectImage(string fileId)
        {
            Argument.AssertNotNull(fileId, nameof(fileId));

            FileId = fileId;
        }

        internal InternalRunStepDetailsToolCallsCodeOutputImageObjectImage(string fileId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FileId = fileId;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal InternalRunStepDetailsToolCallsCodeOutputImageObjectImage()
        {
        }

        public string FileId { get; }
    }
}
