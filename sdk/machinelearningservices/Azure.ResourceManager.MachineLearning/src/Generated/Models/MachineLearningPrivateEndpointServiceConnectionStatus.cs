// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Connection status of the service consumer with the service provider. </summary>
    public readonly partial struct MachineLearningPrivateEndpointServiceConnectionStatus : IEquatable<MachineLearningPrivateEndpointServiceConnectionStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MachineLearningPrivateEndpointServiceConnectionStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MachineLearningPrivateEndpointServiceConnectionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ApprovedValue = "Approved";
        private const string PendingValue = "Pending";
        private const string RejectedValue = "Rejected";
        private const string DisconnectedValue = "Disconnected";
        private const string TimeoutValue = "Timeout";

        /// <summary> Approved. </summary>
        public static MachineLearningPrivateEndpointServiceConnectionStatus Approved { get; } = new MachineLearningPrivateEndpointServiceConnectionStatus(ApprovedValue);
        /// <summary> Pending. </summary>
        public static MachineLearningPrivateEndpointServiceConnectionStatus Pending { get; } = new MachineLearningPrivateEndpointServiceConnectionStatus(PendingValue);
        /// <summary> Rejected. </summary>
        public static MachineLearningPrivateEndpointServiceConnectionStatus Rejected { get; } = new MachineLearningPrivateEndpointServiceConnectionStatus(RejectedValue);
        /// <summary> Disconnected. </summary>
        public static MachineLearningPrivateEndpointServiceConnectionStatus Disconnected { get; } = new MachineLearningPrivateEndpointServiceConnectionStatus(DisconnectedValue);
        /// <summary> Timeout. </summary>
        public static MachineLearningPrivateEndpointServiceConnectionStatus Timeout { get; } = new MachineLearningPrivateEndpointServiceConnectionStatus(TimeoutValue);
        /// <summary> Determines if two <see cref="MachineLearningPrivateEndpointServiceConnectionStatus"/> values are the same. </summary>
        public static bool operator ==(MachineLearningPrivateEndpointServiceConnectionStatus left, MachineLearningPrivateEndpointServiceConnectionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MachineLearningPrivateEndpointServiceConnectionStatus"/> values are not the same. </summary>
        public static bool operator !=(MachineLearningPrivateEndpointServiceConnectionStatus left, MachineLearningPrivateEndpointServiceConnectionStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MachineLearningPrivateEndpointServiceConnectionStatus"/>. </summary>
        public static implicit operator MachineLearningPrivateEndpointServiceConnectionStatus(string value) => new MachineLearningPrivateEndpointServiceConnectionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MachineLearningPrivateEndpointServiceConnectionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MachineLearningPrivateEndpointServiceConnectionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
