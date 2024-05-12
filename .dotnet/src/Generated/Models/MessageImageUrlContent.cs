// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI.Internal.Models;
using OpenAI.Models;

namespace OpenAI.Assistants
{
    /// <summary> References an image URL in the content of a message. </summary>
    public partial class MessageImageUrlContent : MessageContent
    {
        /// <summary> Initializes a new instance of <see cref="MessageImageUrlContent"/>. </summary>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="internalType"> The type of the content part. </param>
        /// <param name="internalImageUrl"></param>
        internal MessageImageUrlContent(IDictionary<string, BinaryData> serializedAdditionalRawData, string internalType, InternalMessageContentImageUrlObjectImageUrl internalImageUrl) : base(serializedAdditionalRawData)
        {
            InternalType = internalType;
            InternalImageUrl = internalImageUrl;
        }

        /// <summary> Initializes a new instance of <see cref="MessageImageUrlContent"/> for deserialization. </summary>
        internal MessageImageUrlContent()
        {
        }
    }
}