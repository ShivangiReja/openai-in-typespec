// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    internal partial class InternalCreateThreadAndRunRequestToolResources
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; }
        public InternalCreateThreadAndRunRequestToolResources()
        {
        }

        internal InternalCreateThreadAndRunRequestToolResources(InternalCreateThreadAndRunRequestToolResourcesCodeInterpreter codeInterpreter, InternalCreateThreadAndRunRequestToolResourcesFileSearch fileSearch, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CodeInterpreter = codeInterpreter;
            FileSearch = fileSearch;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        public InternalCreateThreadAndRunRequestToolResourcesCodeInterpreter CodeInterpreter { get; set; }
        public InternalCreateThreadAndRunRequestToolResourcesFileSearch FileSearch { get; set; }
    }
}
