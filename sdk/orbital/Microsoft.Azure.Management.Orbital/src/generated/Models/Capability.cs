// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace AzureOrbital.Models
{
    /// <summary> Capability of the Ground Station. </summary>
    public readonly partial struct Capability : IEquatable<Capability>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="Capability"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Capability(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EarthObservationValue = "EarthObservation";
        private const string CommunicationValue = "Communication";

        /// <summary> EarthObservation. </summary>
        public static Capability EarthObservation { get; } = new Capability(EarthObservationValue);
        /// <summary> Communication. </summary>
        public static Capability Communication { get; } = new Capability(CommunicationValue);
        /// <summary> Determines if two <see cref="Capability"/> values are the same. </summary>
        public static bool operator ==(Capability left, Capability right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Capability"/> values are not the same. </summary>
        public static bool operator !=(Capability left, Capability right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Capability"/>. </summary>
        public static implicit operator Capability(string value) => new Capability(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Capability other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Capability other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
