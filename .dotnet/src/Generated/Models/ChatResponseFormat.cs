// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Chat
{
    public partial class ChatResponseFormat
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; }

        internal ChatResponseFormat(InternalCreateChatCompletionRequestResponseFormatType? type, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Type = type;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }
    }
}
