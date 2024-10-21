// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> The current provisioning state. </summary>
    public readonly partial struct KeyVaultPrivateEndpointConnectionProvisioningState : IEquatable<KeyVaultPrivateEndpointConnectionProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="KeyVaultPrivateEndpointConnectionProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public KeyVaultPrivateEndpointConnectionProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string CreatingValue = "Creating";
        private const string UpdatingValue = "Updating";
        private const string DeletingValue = "Deleting";
        private const string FailedValue = "Failed";
        private const string DisconnectedValue = "Disconnected";

        /// <summary> Succeeded. </summary>
        public static KeyVaultPrivateEndpointConnectionProvisioningState Succeeded { get; } = new KeyVaultPrivateEndpointConnectionProvisioningState(SucceededValue);
        /// <summary> Creating. </summary>
        public static KeyVaultPrivateEndpointConnectionProvisioningState Creating { get; } = new KeyVaultPrivateEndpointConnectionProvisioningState(CreatingValue);
        /// <summary> Updating. </summary>
        public static KeyVaultPrivateEndpointConnectionProvisioningState Updating { get; } = new KeyVaultPrivateEndpointConnectionProvisioningState(UpdatingValue);
        /// <summary> Deleting. </summary>
        public static KeyVaultPrivateEndpointConnectionProvisioningState Deleting { get; } = new KeyVaultPrivateEndpointConnectionProvisioningState(DeletingValue);
        /// <summary> Failed. </summary>
        public static KeyVaultPrivateEndpointConnectionProvisioningState Failed { get; } = new KeyVaultPrivateEndpointConnectionProvisioningState(FailedValue);
        /// <summary> Disconnected. </summary>
        public static KeyVaultPrivateEndpointConnectionProvisioningState Disconnected { get; } = new KeyVaultPrivateEndpointConnectionProvisioningState(DisconnectedValue);
        /// <summary> Determines if two <see cref="KeyVaultPrivateEndpointConnectionProvisioningState"/> values are the same. </summary>
        public static bool operator ==(KeyVaultPrivateEndpointConnectionProvisioningState left, KeyVaultPrivateEndpointConnectionProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="KeyVaultPrivateEndpointConnectionProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(KeyVaultPrivateEndpointConnectionProvisioningState left, KeyVaultPrivateEndpointConnectionProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="KeyVaultPrivateEndpointConnectionProvisioningState"/>. </summary>
        public static implicit operator KeyVaultPrivateEndpointConnectionProvisioningState(string value) => new KeyVaultPrivateEndpointConnectionProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is KeyVaultPrivateEndpointConnectionProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(KeyVaultPrivateEndpointConnectionProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
