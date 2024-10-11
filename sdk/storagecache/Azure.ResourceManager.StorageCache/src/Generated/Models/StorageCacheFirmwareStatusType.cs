// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> True if there is a firmware update ready to install on this cache. The firmware will automatically be installed after firmwareUpdateDeadline if not triggered earlier via the upgrade operation. </summary>
    public readonly partial struct StorageCacheFirmwareStatusType : IEquatable<StorageCacheFirmwareStatusType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="StorageCacheFirmwareStatusType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StorageCacheFirmwareStatusType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AvailableValue = "available";
        private const string UnavailableValue = "unavailable";

        /// <summary> available. </summary>
        public static StorageCacheFirmwareStatusType Available { get; } = new StorageCacheFirmwareStatusType(AvailableValue);
        /// <summary> unavailable. </summary>
        public static StorageCacheFirmwareStatusType Unavailable { get; } = new StorageCacheFirmwareStatusType(UnavailableValue);
        /// <summary> Determines if two <see cref="StorageCacheFirmwareStatusType"/> values are the same. </summary>
        public static bool operator ==(StorageCacheFirmwareStatusType left, StorageCacheFirmwareStatusType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StorageCacheFirmwareStatusType"/> values are not the same. </summary>
        public static bool operator !=(StorageCacheFirmwareStatusType left, StorageCacheFirmwareStatusType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="StorageCacheFirmwareStatusType"/>. </summary>
        public static implicit operator StorageCacheFirmwareStatusType(string value) => new StorageCacheFirmwareStatusType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StorageCacheFirmwareStatusType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StorageCacheFirmwareStatusType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
