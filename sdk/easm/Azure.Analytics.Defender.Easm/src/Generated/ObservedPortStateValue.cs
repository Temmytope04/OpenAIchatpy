// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Defender.Easm
{
    /// <summary> state of observed port. </summary>
    public readonly partial struct ObservedPortStateValue : IEquatable<ObservedPortStateValue>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ObservedPortStateValue"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ObservedPortStateValue(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OpenValue = "open";
        private const string ClosedValue = "closed";
        private const string FilteredValue = "filtered";

        /// <summary> open. </summary>
        public static ObservedPortStateValue Open { get; } = new ObservedPortStateValue(OpenValue);
        /// <summary> closed. </summary>
        public static ObservedPortStateValue Closed { get; } = new ObservedPortStateValue(ClosedValue);
        /// <summary> filtered. </summary>
        public static ObservedPortStateValue Filtered { get; } = new ObservedPortStateValue(FilteredValue);
        /// <summary> Determines if two <see cref="ObservedPortStateValue"/> values are the same. </summary>
        public static bool operator ==(ObservedPortStateValue left, ObservedPortStateValue right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ObservedPortStateValue"/> values are not the same. </summary>
        public static bool operator !=(ObservedPortStateValue left, ObservedPortStateValue right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ObservedPortStateValue"/>. </summary>
        public static implicit operator ObservedPortStateValue(string value) => new ObservedPortStateValue(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ObservedPortStateValue other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ObservedPortStateValue other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
