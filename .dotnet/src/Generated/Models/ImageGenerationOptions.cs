// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Images
{
    public partial class ImageGenerationOptions
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; }

        internal ImageGenerationOptions(string prompt, InternalCreateImageRequestModel? model, long? n, GeneratedImageQuality? quality, GeneratedImageFormat? responseFormat, GeneratedImageSize? size, GeneratedImageStyle? style, string user, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Prompt = prompt;
            Model = model;
            N = n;
            Quality = quality;
            ResponseFormat = responseFormat;
            Size = size;
            Style = style;
            User = user;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }
        public GeneratedImageQuality? Quality { get; init; }
        public GeneratedImageFormat? ResponseFormat { get; init; }
        public GeneratedImageSize? Size { get; init; }
        public GeneratedImageStyle? Style { get; init; }
        public string User { get; init; }
    }
}
