// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenAI.Chat
{
    public partial class StreamingChatCompletionUpdate
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
        internal StreamingChatCompletionUpdate(string id, IEnumerable<InternalCreateChatCompletionStreamResponseChoice> choices, DateTimeOffset createdAt, string model)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(choices, nameof(choices));
            Argument.AssertNotNull(model, nameof(model));

            Id = id;
            Choices = choices.ToList();
            CreatedAt = createdAt;
            Model = model;
        }

        internal StreamingChatCompletionUpdate(string id, IReadOnlyList<InternalCreateChatCompletionStreamResponseChoice> choices, DateTimeOffset createdAt, string model, InternalCreateChatCompletionStreamResponseServiceTier? serviceTier, string systemFingerprint, InternalCreateChatCompletionStreamResponseObject @object, ChatTokenUsage usage, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Choices = choices;
            CreatedAt = createdAt;
            Model = model;
            ServiceTier = serviceTier;
            SystemFingerprint = systemFingerprint;
            Object = @object;
            Usage = usage;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal StreamingChatCompletionUpdate()
        {
        }

        public string Id { get; }
        public string Model { get; }
        public string SystemFingerprint { get; }
    }
}
