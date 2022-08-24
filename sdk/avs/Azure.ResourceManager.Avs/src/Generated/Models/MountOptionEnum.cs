// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> Mode that describes whether the LUN has to be mounted as a datastore or attached as a LUN. </summary>
    public readonly partial struct MountOptionEnum : IEquatable<MountOptionEnum>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MountOptionEnum"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MountOptionEnum(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MountValue = "MOUNT";
        private const string AttachValue = "ATTACH";

        /// <summary> MOUNT. </summary>
        public static MountOptionEnum Mount { get; } = new MountOptionEnum(MountValue);
        /// <summary> ATTACH. </summary>
        public static MountOptionEnum Attach { get; } = new MountOptionEnum(AttachValue);
        /// <summary> Determines if two <see cref="MountOptionEnum"/> values are the same. </summary>
        public static bool operator ==(MountOptionEnum left, MountOptionEnum right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MountOptionEnum"/> values are not the same. </summary>
        public static bool operator !=(MountOptionEnum left, MountOptionEnum right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MountOptionEnum"/>. </summary>
        public static implicit operator MountOptionEnum(string value) => new MountOptionEnum(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MountOptionEnum other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MountOptionEnum other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
