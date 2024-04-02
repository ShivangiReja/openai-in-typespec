// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Internal.Models
{
    /// <summary> Enum for size in CreateImageRequest. </summary>
    internal readonly partial struct CreateImageRequestSize : IEquatable<CreateImageRequestSize>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CreateImageRequestSize"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CreateImageRequestSize(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string _256x256Value = "256x256";
        private const string _512x512Value = "512x512";
        private const string _1024x1024Value = "1024x1024";
        private const string _1792x1024Value = "1792x1024";
        private const string _1024x1792Value = "1024x1792";

        /// <summary> 256x256. </summary>
        public static CreateImageRequestSize _256x256 { get; } = new CreateImageRequestSize(_256x256Value);
        /// <summary> 512x512. </summary>
        public static CreateImageRequestSize _512x512 { get; } = new CreateImageRequestSize(_512x512Value);
        /// <summary> 1024x1024. </summary>
        public static CreateImageRequestSize _1024x1024 { get; } = new CreateImageRequestSize(_1024x1024Value);
        /// <summary> 1792x1024. </summary>
        public static CreateImageRequestSize _1792x1024 { get; } = new CreateImageRequestSize(_1792x1024Value);
        /// <summary> 1024x1792. </summary>
        public static CreateImageRequestSize _1024x1792 { get; } = new CreateImageRequestSize(_1024x1792Value);
        /// <summary> Determines if two <see cref="CreateImageRequestSize"/> values are the same. </summary>
        public static bool operator ==(CreateImageRequestSize left, CreateImageRequestSize right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CreateImageRequestSize"/> values are not the same. </summary>
        public static bool operator !=(CreateImageRequestSize left, CreateImageRequestSize right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CreateImageRequestSize"/>. </summary>
        public static implicit operator CreateImageRequestSize(string value) => new CreateImageRequestSize(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CreateImageRequestSize other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CreateImageRequestSize other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
