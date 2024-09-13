// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ComputeFleet.Models
{
    /// <summary> Specifies how the virtual machine should be created. </summary>
    public readonly partial struct ComputeFleetDiskCreateOptionType : IEquatable<ComputeFleetDiskCreateOptionType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ComputeFleetDiskCreateOptionType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ComputeFleetDiskCreateOptionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FromImageValue = "FromImage";
        private const string EmptyValue = "Empty";
        private const string AttachValue = "Attach";
        private const string CopyValue = "Copy";
        private const string RestoreValue = "Restore";

        /// <summary>
        /// This value is used when you are using an image to create the virtual machine.
        /// If you are using a platform image, you also use the imageReference element
        /// described above. If you are using a marketplace image, you also use the
        /// plan element previously described.
        /// </summary>
        public static ComputeFleetDiskCreateOptionType FromImage { get; } = new ComputeFleetDiskCreateOptionType(FromImageValue);
        /// <summary> This value is used when creating an empty data disk. </summary>
        public static ComputeFleetDiskCreateOptionType Empty { get; } = new ComputeFleetDiskCreateOptionType(EmptyValue);
        /// <summary> This value is used when you are using a specialized disk to create the virtual machine. </summary>
        public static ComputeFleetDiskCreateOptionType Attach { get; } = new ComputeFleetDiskCreateOptionType(AttachValue);
        /// <summary> This value is used to create a data disk from a snapshot or another disk. </summary>
        public static ComputeFleetDiskCreateOptionType Copy { get; } = new ComputeFleetDiskCreateOptionType(CopyValue);
        /// <summary> This value is used to create a data disk from a disk restore point. </summary>
        public static ComputeFleetDiskCreateOptionType Restore { get; } = new ComputeFleetDiskCreateOptionType(RestoreValue);
        /// <summary> Determines if two <see cref="ComputeFleetDiskCreateOptionType"/> values are the same. </summary>
        public static bool operator ==(ComputeFleetDiskCreateOptionType left, ComputeFleetDiskCreateOptionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ComputeFleetDiskCreateOptionType"/> values are not the same. </summary>
        public static bool operator !=(ComputeFleetDiskCreateOptionType left, ComputeFleetDiskCreateOptionType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ComputeFleetDiskCreateOptionType"/>. </summary>
        public static implicit operator ComputeFleetDiskCreateOptionType(string value) => new ComputeFleetDiskCreateOptionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ComputeFleetDiskCreateOptionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ComputeFleetDiskCreateOptionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
