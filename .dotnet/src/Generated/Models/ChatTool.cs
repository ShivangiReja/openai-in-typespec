// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Chat
{
    public partial class ChatTool
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; }

        internal ChatTool(ChatToolKind kind, InternalFunctionDefinition function, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Kind = kind;
            Function = function;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal ChatTool()
        {
        }
    }
}
