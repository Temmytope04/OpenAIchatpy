// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> The type of managed identity used. The type 'SystemAssigned, UserAssigned' includes both an implicitly created identity and a set of user-assigned identities. The type 'None' will remove any identity. </summary>
    public readonly partial struct EventSubscriptionIdentityType : IEquatable<EventSubscriptionIdentityType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EventSubscriptionIdentityType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EventSubscriptionIdentityType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SystemAssignedValue = "SystemAssigned";
        private const string UserAssignedValue = "UserAssigned";

        /// <summary> SystemAssigned. </summary>
        public static EventSubscriptionIdentityType SystemAssigned { get; } = new EventSubscriptionIdentityType(SystemAssignedValue);
        /// <summary> UserAssigned. </summary>
        public static EventSubscriptionIdentityType UserAssigned { get; } = new EventSubscriptionIdentityType(UserAssignedValue);
        /// <summary> Determines if two <see cref="EventSubscriptionIdentityType"/> values are the same. </summary>
        public static bool operator ==(EventSubscriptionIdentityType left, EventSubscriptionIdentityType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EventSubscriptionIdentityType"/> values are not the same. </summary>
        public static bool operator !=(EventSubscriptionIdentityType left, EventSubscriptionIdentityType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EventSubscriptionIdentityType"/>. </summary>
        public static implicit operator EventSubscriptionIdentityType(string value) => new EventSubscriptionIdentityType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EventSubscriptionIdentityType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EventSubscriptionIdentityType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
