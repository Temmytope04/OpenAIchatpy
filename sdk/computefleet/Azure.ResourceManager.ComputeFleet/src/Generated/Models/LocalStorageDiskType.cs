// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ComputeFleet.Models
{
    /// <summary> Different kind of Local storage disk types supported by Azure VMs. </summary>
    public readonly partial struct LocalStorageDiskType : IEquatable<LocalStorageDiskType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LocalStorageDiskType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LocalStorageDiskType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string HDDValue = "HDD";
        private const string SSDValue = "SSD";

        /// <summary> HDD DiskType. </summary>
        public static LocalStorageDiskType HDD { get; } = new LocalStorageDiskType(HDDValue);
        /// <summary> SDD DiskType. </summary>
        public static LocalStorageDiskType SSD { get; } = new LocalStorageDiskType(SSDValue);
        /// <summary> Determines if two <see cref="LocalStorageDiskType"/> values are the same. </summary>
        public static bool operator ==(LocalStorageDiskType left, LocalStorageDiskType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LocalStorageDiskType"/> values are not the same. </summary>
        public static bool operator !=(LocalStorageDiskType left, LocalStorageDiskType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="LocalStorageDiskType"/>. </summary>
        public static implicit operator LocalStorageDiskType(string value) => new LocalStorageDiskType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LocalStorageDiskType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LocalStorageDiskType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
