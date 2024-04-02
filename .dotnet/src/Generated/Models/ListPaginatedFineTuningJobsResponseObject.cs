// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Internal.Models
{
    /// <summary> The ListPaginatedFineTuningJobsResponse_object. </summary>
    internal readonly partial struct ListPaginatedFineTuningJobsResponseObject : IEquatable<ListPaginatedFineTuningJobsResponseObject>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ListPaginatedFineTuningJobsResponseObject"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ListPaginatedFineTuningJobsResponseObject(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ListValue = "list";

        /// <summary> list. </summary>
        public static ListPaginatedFineTuningJobsResponseObject List { get; } = new ListPaginatedFineTuningJobsResponseObject(ListValue);
        /// <summary> Determines if two <see cref="ListPaginatedFineTuningJobsResponseObject"/> values are the same. </summary>
        public static bool operator ==(ListPaginatedFineTuningJobsResponseObject left, ListPaginatedFineTuningJobsResponseObject right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ListPaginatedFineTuningJobsResponseObject"/> values are not the same. </summary>
        public static bool operator !=(ListPaginatedFineTuningJobsResponseObject left, ListPaginatedFineTuningJobsResponseObject right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ListPaginatedFineTuningJobsResponseObject"/>. </summary>
        public static implicit operator ListPaginatedFineTuningJobsResponseObject(string value) => new ListPaginatedFineTuningJobsResponseObject(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ListPaginatedFineTuningJobsResponseObject other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ListPaginatedFineTuningJobsResponseObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
