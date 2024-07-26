// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.FineTuning
{
    internal partial class InternalFinetuneCompletionRequestInput
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; }
        public InternalFinetuneCompletionRequestInput()
        {
        }

        internal InternalFinetuneCompletionRequestInput(string prompt, string completion, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Prompt = prompt;
            Completion = completion;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        public string Prompt { get; set; }
        public string Completion { get; set; }
    }
}
