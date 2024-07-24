// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Assistants
{
    internal partial class MessageContentTextAnnotationsFilePathObject : IJsonModel<MessageContentTextAnnotationsFilePathObject>
    {
        void IJsonModel<MessageContentTextAnnotationsFilePathObject>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MessageContentTextAnnotationsFilePathObject>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MessageContentTextAnnotationsFilePathObject)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (SerializedAdditionalRawData?.ContainsKey("text") != true)
            {
                writer.WritePropertyName("text"u8);
                writer.WriteStringValue(Text);
            }
            if (SerializedAdditionalRawData?.ContainsKey("file_path") != true)
            {
                writer.WritePropertyName("file_path"u8);
                writer.WriteObjectValue(FilePath, options);
            }
            if (SerializedAdditionalRawData?.ContainsKey("start_index") != true)
            {
                writer.WritePropertyName("start_index"u8);
                writer.WriteNumberValue(StartIndex);
            }
            if (SerializedAdditionalRawData?.ContainsKey("end_index") != true)
            {
                writer.WritePropertyName("end_index"u8);
                writer.WriteNumberValue(EndIndex);
            }
            if (SerializedAdditionalRawData?.ContainsKey("type") != true)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(Type);
            }
            if (SerializedAdditionalRawData != null)
            {
                foreach (var item in SerializedAdditionalRawData)
                {
                    if (ModelSerializationExtensions.IsSentinelValue(item.Value))
                    {
                        continue;
                    }
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        MessageContentTextAnnotationsFilePathObject IJsonModel<MessageContentTextAnnotationsFilePathObject>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MessageContentTextAnnotationsFilePathObject>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MessageContentTextAnnotationsFilePathObject)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMessageContentTextAnnotationsFilePathObject(document.RootElement, options);
        }

        internal static MessageContentTextAnnotationsFilePathObject DeserializeMessageContentTextAnnotationsFilePathObject(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string text = default;
            InternalMessageContentTextAnnotationsFilePathObjectFilePath filePath = default;
            int startIndex = default;
            int endIndex = default;
            string type = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("text"u8))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("file_path"u8))
                {
                    filePath = InternalMessageContentTextAnnotationsFilePathObjectFilePath.DeserializeInternalMessageContentTextAnnotationsFilePathObjectFilePath(property.Value, options);
                    continue;
                }
                if (property.NameEquals("start_index"u8))
                {
                    startIndex = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("end_index"u8))
                {
                    endIndex = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary ??= new Dictionary<string, BinaryData>();
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MessageContentTextAnnotationsFilePathObject(
                type,
                serializedAdditionalRawData,
                text,
                filePath,
                startIndex,
                endIndex);
        }

        BinaryData IPersistableModel<MessageContentTextAnnotationsFilePathObject>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MessageContentTextAnnotationsFilePathObject>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MessageContentTextAnnotationsFilePathObject)} does not support writing '{options.Format}' format.");
            }
        }

        MessageContentTextAnnotationsFilePathObject IPersistableModel<MessageContentTextAnnotationsFilePathObject>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MessageContentTextAnnotationsFilePathObject>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMessageContentTextAnnotationsFilePathObject(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MessageContentTextAnnotationsFilePathObject)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MessageContentTextAnnotationsFilePathObject>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal static new MessageContentTextAnnotationsFilePathObject FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeMessageContentTextAnnotationsFilePathObject(document.RootElement);
        }

        internal override BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
