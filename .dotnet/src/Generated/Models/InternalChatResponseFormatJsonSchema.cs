// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI.Internal;

namespace OpenAI.Chat
{
    internal partial class InternalChatResponseFormatJsonSchema : ChatResponseFormat
    {
        public InternalChatResponseFormatJsonSchema(InternalResponseFormatJsonSchemaJsonSchema jsonSchema)
        {
            Argument.AssertNotNull(jsonSchema, nameof(jsonSchema));

            Type = "json_schema";
            JsonSchema = jsonSchema;
        }

        internal InternalChatResponseFormatJsonSchema(string type, IDictionary<string, BinaryData> serializedAdditionalRawData, InternalResponseFormatJsonSchemaJsonSchema jsonSchema) : base(type, serializedAdditionalRawData)
        {
            JsonSchema = jsonSchema;
        }

        internal InternalChatResponseFormatJsonSchema()
        {
        }

        public InternalResponseFormatJsonSchemaJsonSchema JsonSchema { get; }
    }
}
