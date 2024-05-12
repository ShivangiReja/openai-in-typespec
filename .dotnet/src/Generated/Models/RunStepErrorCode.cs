// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Models
{
    /// <summary> Enum for code in RunStepError. </summary>
    public readonly partial struct RunStepErrorCode : IEquatable<RunStepErrorCode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RunStepErrorCode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RunStepErrorCode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ServerErrorValue = "server_error";
        private const string RateLimitExceededValue = "rate_limit_exceeded";

        /// <summary> server_error. </summary>
        public static RunStepErrorCode ServerError { get; } = new RunStepErrorCode(ServerErrorValue);
        /// <summary> rate_limit_exceeded. </summary>
        public static RunStepErrorCode RateLimitExceeded { get; } = new RunStepErrorCode(RateLimitExceededValue);
        /// <summary> Determines if two <see cref="RunStepErrorCode"/> values are the same. </summary>
        public static bool operator ==(RunStepErrorCode left, RunStepErrorCode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RunStepErrorCode"/> values are not the same. </summary>
        public static bool operator !=(RunStepErrorCode left, RunStepErrorCode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RunStepErrorCode"/>. </summary>
        public static implicit operator RunStepErrorCode(string value) => new RunStepErrorCode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RunStepErrorCode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RunStepErrorCode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
