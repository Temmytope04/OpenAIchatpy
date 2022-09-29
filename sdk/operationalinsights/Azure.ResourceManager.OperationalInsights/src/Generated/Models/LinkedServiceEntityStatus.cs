// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> The provisioning state of the linked service. </summary>
    public readonly partial struct LinkedServiceEntityStatus : IEquatable<LinkedServiceEntityStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LinkedServiceEntityStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LinkedServiceEntityStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string DeletingValue = "Deleting";
        private const string ProvisioningAccountValue = "ProvisioningAccount";
        private const string UpdatingValue = "Updating";

        /// <summary> Succeeded. </summary>
        public static LinkedServiceEntityStatus Succeeded { get; } = new LinkedServiceEntityStatus(SucceededValue);
        /// <summary> Deleting. </summary>
        public static LinkedServiceEntityStatus Deleting { get; } = new LinkedServiceEntityStatus(DeletingValue);
        /// <summary> ProvisioningAccount. </summary>
        public static LinkedServiceEntityStatus ProvisioningAccount { get; } = new LinkedServiceEntityStatus(ProvisioningAccountValue);
        /// <summary> Updating. </summary>
        public static LinkedServiceEntityStatus Updating { get; } = new LinkedServiceEntityStatus(UpdatingValue);
        /// <summary> Determines if two <see cref="LinkedServiceEntityStatus"/> values are the same. </summary>
        public static bool operator ==(LinkedServiceEntityStatus left, LinkedServiceEntityStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LinkedServiceEntityStatus"/> values are not the same. </summary>
        public static bool operator !=(LinkedServiceEntityStatus left, LinkedServiceEntityStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="LinkedServiceEntityStatus"/>. </summary>
        public static implicit operator LinkedServiceEntityStatus(string value) => new LinkedServiceEntityStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LinkedServiceEntityStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LinkedServiceEntityStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
