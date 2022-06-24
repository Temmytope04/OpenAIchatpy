// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The ResourceNotRenewableReason. </summary>
    public readonly partial struct ResourceNotRenewableReason : IEquatable<ResourceNotRenewableReason>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ResourceNotRenewableReason"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ResourceNotRenewableReason(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RegistrationStatusNotSupportedForRenewalValue = "RegistrationStatusNotSupportedForRenewal";
        private const string ExpirationNotInRenewalTimeRangeValue = "ExpirationNotInRenewalTimeRange";
        private const string SubscriptionNotActiveValue = "SubscriptionNotActive";

        /// <summary> RegistrationStatusNotSupportedForRenewal. </summary>
        public static ResourceNotRenewableReason RegistrationStatusNotSupportedForRenewal { get; } = new ResourceNotRenewableReason(RegistrationStatusNotSupportedForRenewalValue);
        /// <summary> ExpirationNotInRenewalTimeRange. </summary>
        public static ResourceNotRenewableReason ExpirationNotInRenewalTimeRange { get; } = new ResourceNotRenewableReason(ExpirationNotInRenewalTimeRangeValue);
        /// <summary> SubscriptionNotActive. </summary>
        public static ResourceNotRenewableReason SubscriptionNotActive { get; } = new ResourceNotRenewableReason(SubscriptionNotActiveValue);
        /// <summary> Determines if two <see cref="ResourceNotRenewableReason"/> values are the same. </summary>
        public static bool operator ==(ResourceNotRenewableReason left, ResourceNotRenewableReason right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ResourceNotRenewableReason"/> values are not the same. </summary>
        public static bool operator !=(ResourceNotRenewableReason left, ResourceNotRenewableReason right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ResourceNotRenewableReason"/>. </summary>
        public static implicit operator ResourceNotRenewableReason(string value) => new ResourceNotRenewableReason(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ResourceNotRenewableReason other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ResourceNotRenewableReason other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
