// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Internal.Models
{
    /// <summary> Enum for purpose in OpenAIFile. </summary>
    internal readonly partial struct OpenAIFilePurpose : IEquatable<OpenAIFilePurpose>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OpenAIFilePurpose"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OpenAIFilePurpose(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FineTuneValue = "fine-tune";
        private const string FineTuneResultsValue = "fine-tune-results";
        private const string AssistantsValue = "assistants";
        private const string AssistantsOutputValue = "assistants_output";

        /// <summary> fine-tune. </summary>
        public static OpenAIFilePurpose FineTune { get; } = new OpenAIFilePurpose(FineTuneValue);
        /// <summary> fine-tune-results. </summary>
        public static OpenAIFilePurpose FineTuneResults { get; } = new OpenAIFilePurpose(FineTuneResultsValue);
        /// <summary> assistants. </summary>
        public static OpenAIFilePurpose Assistants { get; } = new OpenAIFilePurpose(AssistantsValue);
        /// <summary> assistants_output. </summary>
        public static OpenAIFilePurpose AssistantsOutput { get; } = new OpenAIFilePurpose(AssistantsOutputValue);
        /// <summary> Determines if two <see cref="OpenAIFilePurpose"/> values are the same. </summary>
        public static bool operator ==(OpenAIFilePurpose left, OpenAIFilePurpose right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OpenAIFilePurpose"/> values are not the same. </summary>
        public static bool operator !=(OpenAIFilePurpose left, OpenAIFilePurpose right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="OpenAIFilePurpose"/>. </summary>
        public static implicit operator OpenAIFilePurpose(string value) => new OpenAIFilePurpose(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OpenAIFilePurpose other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OpenAIFilePurpose other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
