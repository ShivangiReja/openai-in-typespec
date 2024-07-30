// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenAI.Assistants
{
    public partial class MessageCreationOptions
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }

        internal MessageCreationOptions(MessageRole role, IList<MessageContent> content, IList<MessageCreationAttachment> attachments, IDictionary<string, string> metadata, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Role = role;
            Content = content;
            Attachments = attachments;
            Metadata = metadata;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }
        public IList<MessageCreationAttachment> Attachments { get; set; }
        public IDictionary<string, string> Metadata { get; set; }
    }
}
