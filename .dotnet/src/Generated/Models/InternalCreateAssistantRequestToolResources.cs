// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    internal partial class InternalCreateAssistantRequestToolResources
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; }
        public InternalCreateAssistantRequestToolResources()
        {
        }

        internal InternalCreateAssistantRequestToolResources(InternalCreateAssistantRequestToolResourcesCodeInterpreter codeInterpreter, BinaryData fileSearch, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CodeInterpreter = codeInterpreter;
            FileSearch = fileSearch;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        public InternalCreateAssistantRequestToolResourcesCodeInterpreter CodeInterpreter { get; set; }
        public BinaryData FileSearch { get; set; }
    }
}
