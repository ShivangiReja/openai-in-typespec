// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Audio
{
    public partial class AudioTranscription : IJsonModel<AudioTranscription>
    {
        void IJsonModel<AudioTranscription>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AudioTranscription>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AudioTranscription)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("task"u8);
            writer.WriteStringValue(Task.ToString());
            writer.WritePropertyName("language"u8);
            writer.WriteStringValue(Language);
            writer.WritePropertyName("duration"u8);
            writer.WriteNumberValue(Convert.ToDouble(Duration.Value.ToString("s\\.fff")));
            writer.WritePropertyName("text"u8);
            writer.WriteStringValue(Text);
            if (Optional.IsCollectionDefined(Words))
            {
                writer.WritePropertyName("words"u8);
                writer.WriteStartArray();
                foreach (var item in Words)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Segments))
            {
                writer.WritePropertyName("segments"u8);
                writer.WriteStartArray();
                foreach (var item in Segments)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (true && _serializedAdditionalRawData != null)
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

        AudioTranscription IJsonModel<AudioTranscription>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AudioTranscription>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AudioTranscription)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAudioTranscription(document.RootElement, options);
        }

        internal static AudioTranscription DeserializeAudioTranscription(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InternalCreateTranscriptionResponseVerboseJsonTask task = default;
            string language = default;
            TimeSpan? duration = default;
            string text = default;
            IReadOnlyList<TranscribedWord> words = default;
            IReadOnlyList<TranscribedSegment> segments = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("task"u8))
                {
                    task = new InternalCreateTranscriptionResponseVerboseJsonTask(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("language"u8))
                {
                    language = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("duration"u8))
                {
                    duration = TimeSpan.FromSeconds(property.Value.GetDouble());
                    continue;
                }
                if (property.NameEquals("text"u8))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("words"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TranscribedWord> array = new List<TranscribedWord>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TranscribedWord.DeserializeTranscribedWord(item, options));
                    }
                    words = array;
                    continue;
                }
                if (property.NameEquals("segments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TranscribedSegment> array = new List<TranscribedSegment>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TranscribedSegment.DeserializeTranscribedSegment(item, options));
                    }
                    segments = array;
                    continue;
                }
                if (true)
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AudioTranscription(
                task,
                language,
                duration,
                text,
                words ?? new ChangeTrackingList<TranscribedWord>(),
                segments ?? new ChangeTrackingList<TranscribedSegment>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AudioTranscription>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AudioTranscription>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AudioTranscription)} does not support writing '{options.Format}' format.");
            }
        }

        AudioTranscription IPersistableModel<AudioTranscription>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AudioTranscription>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAudioTranscription(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AudioTranscription)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AudioTranscription>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
