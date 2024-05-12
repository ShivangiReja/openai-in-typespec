// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    /// <summary> Text output from the Code Interpreter tool call as part of a run step. </summary>
    public partial class RunStepCodeInterpreterLogOutput : RunStepCodeInterpreterOutput
    {
        /// <summary> Initializes a new instance of <see cref="RunStepCodeInterpreterLogOutput"/>. </summary>
        /// <param name="logs"> The text output from the Code Interpreter tool call. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="logs"/> is null. </exception>
        internal RunStepCodeInterpreterLogOutput(string logs)
        {
            Argument.AssertNotNull(logs, nameof(logs));

            Type = "logs";
            Logs = logs;
        }

        /// <summary> Initializes a new instance of <see cref="RunStepCodeInterpreterLogOutput"/>. </summary>
        /// <param name="type"> The discriminated type identifier for the details object. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="logs"> The text output from the Code Interpreter tool call. </param>
        internal RunStepCodeInterpreterLogOutput(string type, IDictionary<string, BinaryData> serializedAdditionalRawData, string logs) : base(type, serializedAdditionalRawData)
        {
            Logs = logs;
        }

        /// <summary> Initializes a new instance of <see cref="RunStepCodeInterpreterLogOutput"/> for deserialization. </summary>
        internal RunStepCodeInterpreterLogOutput()
        {
        }

        /// <summary> The text output from the Code Interpreter tool call. </summary>
        public string Logs { get; }
    }
}
