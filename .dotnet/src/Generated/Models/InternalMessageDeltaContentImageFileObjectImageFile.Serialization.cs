// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Internal.Models
{
    internal partial class InternalMessageDeltaContentImageFileObjectImageFile : IJsonModel<InternalMessageDeltaContentImageFileObjectImageFile>
    {
        void IJsonModel<InternalMessageDeltaContentImageFileObjectImageFile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalMessageDeltaContentImageFileObjectImageFile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalMessageDeltaContentImageFileObjectImageFile)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(FileId))
            {
                writer.WritePropertyName("file_id"u8);
                writer.WriteStringValue(FileId);
            }
            if (Optional.IsDefined(InternalDetail))
            {
                writer.WritePropertyName("detail"u8);
                writer.WriteStringValue(InternalDetail);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
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

        InternalMessageDeltaContentImageFileObjectImageFile IJsonModel<InternalMessageDeltaContentImageFileObjectImageFile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalMessageDeltaContentImageFileObjectImageFile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalMessageDeltaContentImageFileObjectImageFile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalMessageDeltaContentImageFileObjectImageFile(document.RootElement, options);
        }

        internal static InternalMessageDeltaContentImageFileObjectImageFile DeserializeInternalMessageDeltaContentImageFileObjectImageFile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string fileId = default;
            string detail = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("file_id"u8))
                {
                    fileId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("detail"u8))
                {
                    detail = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InternalMessageDeltaContentImageFileObjectImageFile(fileId, detail, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InternalMessageDeltaContentImageFileObjectImageFile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalMessageDeltaContentImageFileObjectImageFile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalMessageDeltaContentImageFileObjectImageFile)} does not support writing '{options.Format}' format.");
            }
        }

        InternalMessageDeltaContentImageFileObjectImageFile IPersistableModel<InternalMessageDeltaContentImageFileObjectImageFile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalMessageDeltaContentImageFileObjectImageFile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInternalMessageDeltaContentImageFileObjectImageFile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalMessageDeltaContentImageFileObjectImageFile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalMessageDeltaContentImageFileObjectImageFile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static InternalMessageDeltaContentImageFileObjectImageFile FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeInternalMessageDeltaContentImageFileObjectImageFile(document.RootElement);
        }

        /// <summary> Convert into a <see cref="BinaryContent"/>. </summary>
        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}