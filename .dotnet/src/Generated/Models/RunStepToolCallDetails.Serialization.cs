// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;
using OpenAI.Internal.Models;

namespace OpenAI.Assistants
{
    [PersistableModelProxy(typeof(InternalUnknownRunStepDetailsToolCallsObjectToolCallsObject))]
    public partial class RunStepToolCallDetails : IJsonModel<RunStepToolCallDetails>
    {
        void IJsonModel<RunStepToolCallDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunStepToolCallDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RunStepToolCallDetails)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
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

        RunStepToolCallDetails IJsonModel<RunStepToolCallDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunStepToolCallDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RunStepToolCallDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRunStepToolCallDetails(document.RootElement, options);
        }

        internal static RunStepToolCallDetails DeserializeRunStepToolCallDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "code_interpreter": return RunStepCodeInterpreterToolCallDetails.DeserializeRunStepCodeInterpreterToolCallDetails(element, options);
                    case "file_search": return RunStepFileSearchToolCallDetails.DeserializeRunStepFileSearchToolCallDetails(element, options);
                    case "function": return RunStepFunctionToolCallDetails.DeserializeRunStepFunctionToolCallDetails(element, options);
                }
            }
            return InternalUnknownRunStepDetailsToolCallsObjectToolCallsObject.DeserializeInternalUnknownRunStepDetailsToolCallsObjectToolCallsObject(element, options);
        }

        BinaryData IPersistableModel<RunStepToolCallDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunStepToolCallDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RunStepToolCallDetails)} does not support writing '{options.Format}' format.");
            }
        }

        RunStepToolCallDetails IPersistableModel<RunStepToolCallDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunStepToolCallDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRunStepToolCallDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RunStepToolCallDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RunStepToolCallDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static RunStepToolCallDetails FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeRunStepToolCallDetails(document.RootElement);
        }

        /// <summary> Convert into a <see cref="BinaryContent"/>. </summary>
        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
