// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Peering.Models
{
    /// <summary> The size of the peering SKU. </summary>
    public readonly partial struct PeeringSize : IEquatable<PeeringSize>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PeeringSize"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PeeringSize(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FreeValue = "Free";
        private const string MeteredValue = "Metered";
        private const string UnlimitedValue = "Unlimited";

        /// <summary> Free. </summary>
        public static PeeringSize Free { get; } = new PeeringSize(FreeValue);
        /// <summary> Metered. </summary>
        public static PeeringSize Metered { get; } = new PeeringSize(MeteredValue);
        /// <summary> Unlimited. </summary>
        public static PeeringSize Unlimited { get; } = new PeeringSize(UnlimitedValue);
        /// <summary> Determines if two <see cref="PeeringSize"/> values are the same. </summary>
        public static bool operator ==(PeeringSize left, PeeringSize right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PeeringSize"/> values are not the same. </summary>
        public static bool operator !=(PeeringSize left, PeeringSize right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PeeringSize"/>. </summary>
        public static implicit operator PeeringSize(string value) => new PeeringSize(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PeeringSize other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PeeringSize other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
