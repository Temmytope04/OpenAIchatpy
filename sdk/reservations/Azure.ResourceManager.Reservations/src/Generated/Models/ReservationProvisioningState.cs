// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> Represent the current state of the Reservation. </summary>
    public readonly partial struct ReservationProvisioningState : IEquatable<ReservationProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ReservationProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ReservationProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string PendingResourceHoldValue = "PendingResourceHold";
        private const string ConfirmedResourceHoldValue = "ConfirmedResourceHold";
        private const string PendingBillingValue = "PendingBilling";
        private const string ConfirmedBillingValue = "ConfirmedBilling";
        private const string CreatedValue = "Created";
        private const string SucceededValue = "Succeeded";
        private const string CancelledValue = "Cancelled";
        private const string ExpiredValue = "Expired";
        private const string BillingFailedValue = "BillingFailed";
        private const string FailedValue = "Failed";
        private const string SplitValue = "Split";
        private const string MergedValue = "Merged";

        /// <summary> Creating. </summary>
        public static ReservationProvisioningState Creating { get; } = new ReservationProvisioningState(CreatingValue);
        /// <summary> PendingResourceHold. </summary>
        public static ReservationProvisioningState PendingResourceHold { get; } = new ReservationProvisioningState(PendingResourceHoldValue);
        /// <summary> ConfirmedResourceHold. </summary>
        public static ReservationProvisioningState ConfirmedResourceHold { get; } = new ReservationProvisioningState(ConfirmedResourceHoldValue);
        /// <summary> PendingBilling. </summary>
        public static ReservationProvisioningState PendingBilling { get; } = new ReservationProvisioningState(PendingBillingValue);
        /// <summary> ConfirmedBilling. </summary>
        public static ReservationProvisioningState ConfirmedBilling { get; } = new ReservationProvisioningState(ConfirmedBillingValue);
        /// <summary> Created. </summary>
        public static ReservationProvisioningState Created { get; } = new ReservationProvisioningState(CreatedValue);
        /// <summary> Succeeded. </summary>
        public static ReservationProvisioningState Succeeded { get; } = new ReservationProvisioningState(SucceededValue);
        /// <summary> Cancelled. </summary>
        public static ReservationProvisioningState Cancelled { get; } = new ReservationProvisioningState(CancelledValue);
        /// <summary> Expired. </summary>
        public static ReservationProvisioningState Expired { get; } = new ReservationProvisioningState(ExpiredValue);
        /// <summary> BillingFailed. </summary>
        public static ReservationProvisioningState BillingFailed { get; } = new ReservationProvisioningState(BillingFailedValue);
        /// <summary> Failed. </summary>
        public static ReservationProvisioningState Failed { get; } = new ReservationProvisioningState(FailedValue);
        /// <summary> Split. </summary>
        public static ReservationProvisioningState Split { get; } = new ReservationProvisioningState(SplitValue);
        /// <summary> Merged. </summary>
        public static ReservationProvisioningState Merged { get; } = new ReservationProvisioningState(MergedValue);
        /// <summary> Determines if two <see cref="ReservationProvisioningState"/> values are the same. </summary>
        public static bool operator ==(ReservationProvisioningState left, ReservationProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ReservationProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(ReservationProvisioningState left, ReservationProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ReservationProvisioningState"/>. </summary>
        public static implicit operator ReservationProvisioningState(string value) => new ReservationProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ReservationProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ReservationProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
