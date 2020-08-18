// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Management.Compute.Models
{
    /// <summary> The provisioning state, which only appears in the response. </summary>
    public readonly partial struct GalleryImagePropertiesProvisioningState : IEquatable<GalleryImagePropertiesProvisioningState>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="GalleryImagePropertiesProvisioningState"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public GalleryImagePropertiesProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string UpdatingValue = "Updating";
        private const string FailedValue = "Failed";
        private const string SucceededValue = "Succeeded";
        private const string DeletingValue = "Deleting";
        private const string MigratingValue = "Migrating";

        /// <summary> Creating. </summary>
        public static GalleryImagePropertiesProvisioningState Creating { get; } = new GalleryImagePropertiesProvisioningState(CreatingValue);
        /// <summary> Updating. </summary>
        public static GalleryImagePropertiesProvisioningState Updating { get; } = new GalleryImagePropertiesProvisioningState(UpdatingValue);
        /// <summary> Failed. </summary>
        public static GalleryImagePropertiesProvisioningState Failed { get; } = new GalleryImagePropertiesProvisioningState(FailedValue);
        /// <summary> Succeeded. </summary>
        public static GalleryImagePropertiesProvisioningState Succeeded { get; } = new GalleryImagePropertiesProvisioningState(SucceededValue);
        /// <summary> Deleting. </summary>
        public static GalleryImagePropertiesProvisioningState Deleting { get; } = new GalleryImagePropertiesProvisioningState(DeletingValue);
        /// <summary> Migrating. </summary>
        public static GalleryImagePropertiesProvisioningState Migrating { get; } = new GalleryImagePropertiesProvisioningState(MigratingValue);
        /// <summary> Determines if two <see cref="GalleryImagePropertiesProvisioningState"/> values are the same. </summary>
        public static bool operator ==(GalleryImagePropertiesProvisioningState left, GalleryImagePropertiesProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="GalleryImagePropertiesProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(GalleryImagePropertiesProvisioningState left, GalleryImagePropertiesProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="GalleryImagePropertiesProvisioningState"/>. </summary>
        public static implicit operator GalleryImagePropertiesProvisioningState(string value) => new GalleryImagePropertiesProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is GalleryImagePropertiesProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(GalleryImagePropertiesProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
