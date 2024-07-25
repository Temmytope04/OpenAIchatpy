// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> The UnmanageActionResourceGroupMode. </summary>
    public readonly partial struct UnmanageActionResourceGroupMode : IEquatable<UnmanageActionResourceGroupMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="UnmanageActionResourceGroupMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public UnmanageActionResourceGroupMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DeleteValue = "delete";
        private const string DetachValue = "detach";

        /// <summary> delete. </summary>
        public static UnmanageActionResourceGroupMode Delete { get; } = new UnmanageActionResourceGroupMode(DeleteValue);
        /// <summary> detach. </summary>
        public static UnmanageActionResourceGroupMode Detach { get; } = new UnmanageActionResourceGroupMode(DetachValue);
        /// <summary> Determines if two <see cref="UnmanageActionResourceGroupMode"/> values are the same. </summary>
        public static bool operator ==(UnmanageActionResourceGroupMode left, UnmanageActionResourceGroupMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="UnmanageActionResourceGroupMode"/> values are not the same. </summary>
        public static bool operator !=(UnmanageActionResourceGroupMode left, UnmanageActionResourceGroupMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="UnmanageActionResourceGroupMode"/>. </summary>
        public static implicit operator UnmanageActionResourceGroupMode(string value) => new UnmanageActionResourceGroupMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is UnmanageActionResourceGroupMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(UnmanageActionResourceGroupMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
