// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Internal.Models
{
    internal partial class CreateTranscriptionRequest : IJsonModel<CreateTranscriptionRequest>
    {
        void IJsonModel<CreateTranscriptionRequest>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateTranscriptionRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CreateTranscriptionRequest)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("file"u8);
            writer.WriteBase64StringValue(File.ToArray(), "D");
            writer.WritePropertyName("model"u8);
            writer.WriteStringValue(Model.ToString());
            if (Optional.IsDefined(Language))
            {
                writer.WritePropertyName("language"u8);
                writer.WriteStringValue(Language);
            }
            if (Optional.IsDefined(Prompt))
            {
                writer.WritePropertyName("prompt"u8);
                writer.WriteStringValue(Prompt);
            }
            if (Optional.IsDefined(ResponseFormat))
            {
                writer.WritePropertyName("response_format"u8);
                writer.WriteStringValue(ResponseFormat.Value.ToString());
            }
            if (Optional.IsDefined(Temperature))
            {
                writer.WritePropertyName("temperature"u8);
                writer.WriteNumberValue(Temperature.Value);
            }
            if (Optional.IsCollectionDefined(TimestampGranularities))
            {
                writer.WritePropertyName("timestamp_granularities"u8);
                writer.WriteStartArray();
                foreach (var item in TimestampGranularities)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    using (JsonDocument document = JsonDocument.Parse(item))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndArray();
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

        CreateTranscriptionRequest IJsonModel<CreateTranscriptionRequest>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateTranscriptionRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CreateTranscriptionRequest)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCreateTranscriptionRequest(document.RootElement, options);
        }

        internal static CreateTranscriptionRequest DeserializeCreateTranscriptionRequest(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BinaryData file = default;
            CreateTranscriptionRequestModel model = default;
            string language = default;
            string prompt = default;
            CreateTranscriptionRequestResponseFormat? responseFormat = default;
            double? temperature = default;
            IList<BinaryData> timestampGranularities = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("file"u8))
                {
                    file = BinaryData.FromBytes(property.Value.GetBytesFromBase64("D"));
                    continue;
                }
                if (property.NameEquals("model"u8))
                {
                    model = new CreateTranscriptionRequestModel(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("language"u8))
                {
                    language = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("prompt"u8))
                {
                    prompt = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("response_format"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    responseFormat = new CreateTranscriptionRequestResponseFormat(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("temperature"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    temperature = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("timestamp_granularities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(BinaryData.FromString(item.GetRawText()));
                        }
                    }
                    timestampGranularities = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CreateTranscriptionRequest(
                file,
                model,
                language,
                prompt,
                responseFormat,
                temperature,
                timestampGranularities ?? new ChangeTrackingList<BinaryData>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CreateTranscriptionRequest>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateTranscriptionRequest>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CreateTranscriptionRequest)} does not support writing '{options.Format}' format.");
            }
        }

        CreateTranscriptionRequest IPersistableModel<CreateTranscriptionRequest>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateTranscriptionRequest>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCreateTranscriptionRequest(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CreateTranscriptionRequest)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CreateTranscriptionRequest>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static CreateTranscriptionRequest FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeCreateTranscriptionRequest(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestBody. </summary>
        internal virtual BinaryContent ToBinaryBody()
        {
            return BinaryContent.Create(this, new ModelReaderWriterOptions("W"));
        }
    }
}
