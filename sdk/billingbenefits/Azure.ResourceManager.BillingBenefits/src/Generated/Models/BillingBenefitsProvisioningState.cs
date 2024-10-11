// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.BillingBenefits.Models
{
    /// <summary> Provisioning state. </summary>
    public readonly partial struct BillingBenefitsProvisioningState : IEquatable<BillingBenefitsProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BillingBenefitsProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BillingBenefitsProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string PendingBillingValue = "PendingBilling";
        private const string ConfirmedBillingValue = "ConfirmedBilling";
        private const string CreatedValue = "Created";
        private const string SucceededValue = "Succeeded";
        private const string CancelledValue = "Cancelled";
        private const string ExpiredValue = "Expired";
        private const string FailedValue = "Failed";

        /// <summary> Creating. </summary>
        public static BillingBenefitsProvisioningState Creating { get; } = new BillingBenefitsProvisioningState(CreatingValue);
        /// <summary> PendingBilling. </summary>
        public static BillingBenefitsProvisioningState PendingBilling { get; } = new BillingBenefitsProvisioningState(PendingBillingValue);
        /// <summary> ConfirmedBilling. </summary>
        public static BillingBenefitsProvisioningState ConfirmedBilling { get; } = new BillingBenefitsProvisioningState(ConfirmedBillingValue);
        /// <summary> Created. </summary>
        public static BillingBenefitsProvisioningState Created { get; } = new BillingBenefitsProvisioningState(CreatedValue);
        /// <summary> Succeeded. </summary>
        public static BillingBenefitsProvisioningState Succeeded { get; } = new BillingBenefitsProvisioningState(SucceededValue);
        /// <summary> Cancelled. </summary>
        public static BillingBenefitsProvisioningState Cancelled { get; } = new BillingBenefitsProvisioningState(CancelledValue);
        /// <summary> Expired. </summary>
        public static BillingBenefitsProvisioningState Expired { get; } = new BillingBenefitsProvisioningState(ExpiredValue);
        /// <summary> Failed. </summary>
        public static BillingBenefitsProvisioningState Failed { get; } = new BillingBenefitsProvisioningState(FailedValue);
        /// <summary> Determines if two <see cref="BillingBenefitsProvisioningState"/> values are the same. </summary>
        public static bool operator ==(BillingBenefitsProvisioningState left, BillingBenefitsProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BillingBenefitsProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(BillingBenefitsProvisioningState left, BillingBenefitsProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="BillingBenefitsProvisioningState"/>. </summary>
        public static implicit operator BillingBenefitsProvisioningState(string value) => new BillingBenefitsProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BillingBenefitsProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BillingBenefitsProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
