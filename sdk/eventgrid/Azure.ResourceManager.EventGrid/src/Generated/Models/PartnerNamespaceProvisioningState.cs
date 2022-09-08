// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Provisioning state of the partner namespace. </summary>
    public readonly partial struct PartnerNamespaceProvisioningState : IEquatable<PartnerNamespaceProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PartnerNamespaceProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PartnerNamespaceProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string UpdatingValue = "Updating";
        private const string DeletingValue = "Deleting";
        private const string SucceededValue = "Succeeded";
        private const string CanceledValue = "Canceled";
        private const string FailedValue = "Failed";

        /// <summary> Creating. </summary>
        public static PartnerNamespaceProvisioningState Creating { get; } = new PartnerNamespaceProvisioningState(CreatingValue);
        /// <summary> Updating. </summary>
        public static PartnerNamespaceProvisioningState Updating { get; } = new PartnerNamespaceProvisioningState(UpdatingValue);
        /// <summary> Deleting. </summary>
        public static PartnerNamespaceProvisioningState Deleting { get; } = new PartnerNamespaceProvisioningState(DeletingValue);
        /// <summary> Succeeded. </summary>
        public static PartnerNamespaceProvisioningState Succeeded { get; } = new PartnerNamespaceProvisioningState(SucceededValue);
        /// <summary> Canceled. </summary>
        public static PartnerNamespaceProvisioningState Canceled { get; } = new PartnerNamespaceProvisioningState(CanceledValue);
        /// <summary> Failed. </summary>
        public static PartnerNamespaceProvisioningState Failed { get; } = new PartnerNamespaceProvisioningState(FailedValue);
        /// <summary> Determines if two <see cref="PartnerNamespaceProvisioningState"/> values are the same. </summary>
        public static bool operator ==(PartnerNamespaceProvisioningState left, PartnerNamespaceProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PartnerNamespaceProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(PartnerNamespaceProvisioningState left, PartnerNamespaceProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PartnerNamespaceProvisioningState"/>. </summary>
        public static implicit operator PartnerNamespaceProvisioningState(string value) => new PartnerNamespaceProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PartnerNamespaceProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PartnerNamespaceProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
