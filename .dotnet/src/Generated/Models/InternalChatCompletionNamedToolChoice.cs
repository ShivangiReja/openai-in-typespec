// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Chat
{
    internal partial class InternalChatCompletionNamedToolChoice
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; }
        public InternalChatCompletionNamedToolChoice(InternalChatCompletionNamedToolChoiceFunction function)
        {
            Argument.AssertNotNull(function, nameof(function));

            Function = function;
        }

        internal InternalChatCompletionNamedToolChoice(InternalChatCompletionNamedToolChoiceType type, InternalChatCompletionNamedToolChoiceFunction function, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Type = type;
            Function = function;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal InternalChatCompletionNamedToolChoice()
        {
        }

        public InternalChatCompletionNamedToolChoiceType Type { get; } = InternalChatCompletionNamedToolChoiceType.Function;

        public InternalChatCompletionNamedToolChoiceFunction Function { get; }
    }
}
