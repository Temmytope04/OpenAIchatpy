// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication
{
    /// <summary> The CommunicationCloudEnvironmentModel. </summary>
    internal readonly partial struct CommunicationCloudEnvironmentModel : IEquatable<CommunicationCloudEnvironmentModel>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CommunicationCloudEnvironmentModel"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CommunicationCloudEnvironmentModel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PublicValue = "public";
        private const string DodValue = "dod";
        private const string GcchValue = "gcch";

        /// <summary> public. </summary>
        public static CommunicationCloudEnvironmentModel Public { get; } = new CommunicationCloudEnvironmentModel(PublicValue);
        /// <summary> dod. </summary>
        public static CommunicationCloudEnvironmentModel Dod { get; } = new CommunicationCloudEnvironmentModel(DodValue);
        /// <summary> gcch. </summary>
        public static CommunicationCloudEnvironmentModel Gcch { get; } = new CommunicationCloudEnvironmentModel(GcchValue);
        /// <summary> Determines if two <see cref="CommunicationCloudEnvironmentModel"/> values are the same. </summary>
        public static bool operator ==(CommunicationCloudEnvironmentModel left, CommunicationCloudEnvironmentModel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CommunicationCloudEnvironmentModel"/> values are not the same. </summary>
        public static bool operator !=(CommunicationCloudEnvironmentModel left, CommunicationCloudEnvironmentModel right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CommunicationCloudEnvironmentModel"/>. </summary>
        public static implicit operator CommunicationCloudEnvironmentModel(string value) => new CommunicationCloudEnvironmentModel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CommunicationCloudEnvironmentModel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CommunicationCloudEnvironmentModel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
