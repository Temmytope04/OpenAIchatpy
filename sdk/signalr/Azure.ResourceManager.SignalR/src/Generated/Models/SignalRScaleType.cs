// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SignalR.Models
{
    /// <summary> The scale type applicable to the sku. </summary>
    public readonly partial struct SignalRScaleType : IEquatable<SignalRScaleType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SignalRScaleType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SignalRScaleType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string ManualValue = "Manual";
        private const string AutomaticValue = "Automatic";

        /// <summary> None. </summary>
        public static SignalRScaleType None { get; } = new SignalRScaleType(NoneValue);
        /// <summary> Manual. </summary>
        public static SignalRScaleType Manual { get; } = new SignalRScaleType(ManualValue);
        /// <summary> Automatic. </summary>
        public static SignalRScaleType Automatic { get; } = new SignalRScaleType(AutomaticValue);
        /// <summary> Determines if two <see cref="SignalRScaleType"/> values are the same. </summary>
        public static bool operator ==(SignalRScaleType left, SignalRScaleType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SignalRScaleType"/> values are not the same. </summary>
        public static bool operator !=(SignalRScaleType left, SignalRScaleType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SignalRScaleType"/>. </summary>
        public static implicit operator SignalRScaleType(string value) => new SignalRScaleType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SignalRScaleType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SignalRScaleType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
