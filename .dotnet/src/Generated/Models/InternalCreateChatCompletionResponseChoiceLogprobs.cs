// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenAI.Chat
{
    internal partial class InternalCreateChatCompletionResponseChoiceLogprobs
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; }
        internal InternalCreateChatCompletionResponseChoiceLogprobs(IEnumerable<ChatTokenLogProbabilityInfo> content)
        {
            Content = content?.ToList();
        }

        internal InternalCreateChatCompletionResponseChoiceLogprobs(IReadOnlyList<ChatTokenLogProbabilityInfo> content, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Content = content;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal InternalCreateChatCompletionResponseChoiceLogprobs()
        {
        }

        public IReadOnlyList<ChatTokenLogProbabilityInfo> Content { get; }
    }
}
