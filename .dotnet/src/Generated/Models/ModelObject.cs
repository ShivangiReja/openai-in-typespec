// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Internal.Models
{
    /// <summary> The Model_object. </summary>
    internal readonly partial struct ModelObject : IEquatable<ModelObject>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ModelObject"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ModelObject(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ModelValue = "model";

        /// <summary> model. </summary>
        public static ModelObject Model { get; } = new ModelObject(ModelValue);
        /// <summary> Determines if two <see cref="ModelObject"/> values are the same. </summary>
        public static bool operator ==(ModelObject left, ModelObject right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ModelObject"/> values are not the same. </summary>
        public static bool operator !=(ModelObject left, ModelObject right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ModelObject"/>. </summary>
        public static implicit operator ModelObject(string value) => new ModelObject(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ModelObject other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ModelObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
