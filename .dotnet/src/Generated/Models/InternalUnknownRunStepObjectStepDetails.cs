// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI.Assistants;

namespace OpenAI.Internal.Models
{
    /// <summary> Unknown version of RunStepObjectStepDetails. </summary>
    internal partial class InternalUnknownRunStepObjectStepDetails : RunStepDetails
    {
        /// <summary> Initializes a new instance of <see cref="InternalUnknownRunStepObjectStepDetails"/>. </summary>
        /// <param name="type"> The discriminated type identifier for the details object. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InternalUnknownRunStepObjectStepDetails(string type, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(type, serializedAdditionalRawData)
        {
        }

        /// <summary> Initializes a new instance of <see cref="InternalUnknownRunStepObjectStepDetails"/> for deserialization. </summary>
        internal InternalUnknownRunStepObjectStepDetails()
        {
        }
    }
}
