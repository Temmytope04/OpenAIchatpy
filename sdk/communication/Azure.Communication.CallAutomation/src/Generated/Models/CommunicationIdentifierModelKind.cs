// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication
{
    /// <summary> The identifier kind, for example 'communicationUser' or 'phoneNumber'. </summary>
    internal readonly partial struct CommunicationIdentifierModelKind : IEquatable<CommunicationIdentifierModelKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CommunicationIdentifierModelKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CommunicationIdentifierModelKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "unknown";
        private const string CommunicationUserValue = "communicationUser";
        private const string PhoneNumberValue = "phoneNumber";
        private const string MicrosoftTeamsUserValue = "microsoftTeamsUser";
        private const string MicrosoftTeamsAppValue = "microsoftTeamsApp";

        /// <summary> unknown. </summary>
        public static CommunicationIdentifierModelKind Unknown { get; } = new CommunicationIdentifierModelKind(UnknownValue);
        /// <summary> communicationUser. </summary>
        public static CommunicationIdentifierModelKind CommunicationUser { get; } = new CommunicationIdentifierModelKind(CommunicationUserValue);
        /// <summary> phoneNumber. </summary>
        public static CommunicationIdentifierModelKind PhoneNumber { get; } = new CommunicationIdentifierModelKind(PhoneNumberValue);
        /// <summary> microsoftTeamsUser. </summary>
        public static CommunicationIdentifierModelKind MicrosoftTeamsUser { get; } = new CommunicationIdentifierModelKind(MicrosoftTeamsUserValue);
        /// <summary> microsoftTeamsApp. </summary>
        public static CommunicationIdentifierModelKind MicrosoftTeamsApp { get; } = new CommunicationIdentifierModelKind(MicrosoftTeamsAppValue);
        /// <summary> Determines if two <see cref="CommunicationIdentifierModelKind"/> values are the same. </summary>
        public static bool operator ==(CommunicationIdentifierModelKind left, CommunicationIdentifierModelKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CommunicationIdentifierModelKind"/> values are not the same. </summary>
        public static bool operator !=(CommunicationIdentifierModelKind left, CommunicationIdentifierModelKind right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="CommunicationIdentifierModelKind"/>. </summary>
        public static implicit operator CommunicationIdentifierModelKind(string value) => new CommunicationIdentifierModelKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CommunicationIdentifierModelKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CommunicationIdentifierModelKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
