// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Assistants
{
    internal readonly partial struct InternalRunToolCallObjectType : IEquatable<InternalRunToolCallObjectType>
    {
        private readonly string _value;

        public InternalRunToolCallObjectType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FunctionValue = "function";

        public static InternalRunToolCallObjectType Function { get; } = new InternalRunToolCallObjectType(FunctionValue);
        public static bool operator ==(InternalRunToolCallObjectType left, InternalRunToolCallObjectType right) => left.Equals(right);
        public static bool operator !=(InternalRunToolCallObjectType left, InternalRunToolCallObjectType right) => !left.Equals(right);
        public static implicit operator InternalRunToolCallObjectType(string value) => new InternalRunToolCallObjectType(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalRunToolCallObjectType other && Equals(other);
        public bool Equals(InternalRunToolCallObjectType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        public override string ToString() => _value;
    }
}