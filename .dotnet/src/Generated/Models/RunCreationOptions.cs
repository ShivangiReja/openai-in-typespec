// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    public partial class RunCreationOptions
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; }

        internal RunCreationOptions(string assistantId, string modelOverride, string instructionsOverride, string additionalInstructions, IList<MessageCreationOptions> internalMessages, IList<ToolDefinition> toolsOverride, IDictionary<string, string> metadata, float? temperature, float? nucleusSamplingFactor, bool? stream, int? maxPromptTokens, int? maxCompletionTokens, RunTruncationStrategy truncationStrategy, ToolConstraint toolConstraint, bool? parallelToolCallsEnabled, AssistantResponseFormat responseFormat, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AssistantId = assistantId;
            ModelOverride = modelOverride;
            InstructionsOverride = instructionsOverride;
            AdditionalInstructions = additionalInstructions;
            InternalMessages = internalMessages;
            ToolsOverride = toolsOverride;
            Metadata = metadata;
            Temperature = temperature;
            NucleusSamplingFactor = nucleusSamplingFactor;
            Stream = stream;
            MaxPromptTokens = maxPromptTokens;
            MaxCompletionTokens = maxCompletionTokens;
            TruncationStrategy = truncationStrategy;
            ToolConstraint = toolConstraint;
            ParallelToolCallsEnabled = parallelToolCallsEnabled;
            ResponseFormat = responseFormat;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }
    }
}
