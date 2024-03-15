// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    /// <summary> State of Private Link Connection. </summary>
    public readonly partial struct NotificationHubPrivateLinkConnectionStatus : IEquatable<NotificationHubPrivateLinkConnectionStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NotificationHubPrivateLinkConnectionStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NotificationHubPrivateLinkConnectionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DisconnectedValue = "Disconnected";
        private const string PendingValue = "Pending";
        private const string ApprovedValue = "Approved";
        private const string RejectedValue = "Rejected";

        /// <summary> Disconnected. </summary>
        public static NotificationHubPrivateLinkConnectionStatus Disconnected { get; } = new NotificationHubPrivateLinkConnectionStatus(DisconnectedValue);
        /// <summary> Pending. </summary>
        public static NotificationHubPrivateLinkConnectionStatus Pending { get; } = new NotificationHubPrivateLinkConnectionStatus(PendingValue);
        /// <summary> Approved. </summary>
        public static NotificationHubPrivateLinkConnectionStatus Approved { get; } = new NotificationHubPrivateLinkConnectionStatus(ApprovedValue);
        /// <summary> Rejected. </summary>
        public static NotificationHubPrivateLinkConnectionStatus Rejected { get; } = new NotificationHubPrivateLinkConnectionStatus(RejectedValue);
        /// <summary> Determines if two <see cref="NotificationHubPrivateLinkConnectionStatus"/> values are the same. </summary>
        public static bool operator ==(NotificationHubPrivateLinkConnectionStatus left, NotificationHubPrivateLinkConnectionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NotificationHubPrivateLinkConnectionStatus"/> values are not the same. </summary>
        public static bool operator !=(NotificationHubPrivateLinkConnectionStatus left, NotificationHubPrivateLinkConnectionStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="NotificationHubPrivateLinkConnectionStatus"/>. </summary>
        public static implicit operator NotificationHubPrivateLinkConnectionStatus(string value) => new NotificationHubPrivateLinkConnectionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NotificationHubPrivateLinkConnectionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NotificationHubPrivateLinkConnectionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
