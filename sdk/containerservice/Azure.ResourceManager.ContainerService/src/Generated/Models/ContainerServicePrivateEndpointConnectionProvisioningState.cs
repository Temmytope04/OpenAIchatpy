// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> The current provisioning state. </summary>
    public readonly partial struct ContainerServicePrivateEndpointConnectionProvisioningState : IEquatable<ContainerServicePrivateEndpointConnectionProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContainerServicePrivateEndpointConnectionProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContainerServicePrivateEndpointConnectionProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string CreatingValue = "Creating";
        private const string DeletingValue = "Deleting";
        private const string FailedValue = "Failed";

        /// <summary> Succeeded. </summary>
        public static ContainerServicePrivateEndpointConnectionProvisioningState Succeeded { get; } = new ContainerServicePrivateEndpointConnectionProvisioningState(SucceededValue);
        /// <summary> Creating. </summary>
        public static ContainerServicePrivateEndpointConnectionProvisioningState Creating { get; } = new ContainerServicePrivateEndpointConnectionProvisioningState(CreatingValue);
        /// <summary> Deleting. </summary>
        public static ContainerServicePrivateEndpointConnectionProvisioningState Deleting { get; } = new ContainerServicePrivateEndpointConnectionProvisioningState(DeletingValue);
        /// <summary> Failed. </summary>
        public static ContainerServicePrivateEndpointConnectionProvisioningState Failed { get; } = new ContainerServicePrivateEndpointConnectionProvisioningState(FailedValue);
        /// <summary> Determines if two <see cref="ContainerServicePrivateEndpointConnectionProvisioningState"/> values are the same. </summary>
        public static bool operator ==(ContainerServicePrivateEndpointConnectionProvisioningState left, ContainerServicePrivateEndpointConnectionProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContainerServicePrivateEndpointConnectionProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(ContainerServicePrivateEndpointConnectionProvisioningState left, ContainerServicePrivateEndpointConnectionProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ContainerServicePrivateEndpointConnectionProvisioningState"/>. </summary>
        public static implicit operator ContainerServicePrivateEndpointConnectionProvisioningState(string value) => new ContainerServicePrivateEndpointConnectionProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContainerServicePrivateEndpointConnectionProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContainerServicePrivateEndpointConnectionProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
