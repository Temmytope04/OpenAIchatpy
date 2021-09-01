// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using Azure.Core;

namespace Azure.Monitor.Query.Models
{
    /// <summary> Kind of namespace. </summary>
    public readonly partial struct NamespaceClassification : IEquatable<NamespaceClassification>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="NamespaceClassification"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NamespaceClassification(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PlatformValue = "Platform";
        private const string CustomValue = "Custom";
        private const string QosValue = "Qos";

        /// <summary> Platform. </summary>
        public static NamespaceClassification Platform { get; } = new NamespaceClassification(PlatformValue);
        /// <summary> Custom. </summary>
        public static NamespaceClassification Custom { get; } = new NamespaceClassification(CustomValue);

        /// <summary> Qos. </summary>
        [CodeGenMember("Qos")]
        public static NamespaceClassification QualityOfService { get; } = new NamespaceClassification(QosValue);
        /// <summary> Determines if two <see cref="NamespaceClassification"/> values are the same. </summary>
        public static bool operator ==(NamespaceClassification left, NamespaceClassification right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NamespaceClassification"/> values are not the same. </summary>
        public static bool operator !=(NamespaceClassification left, NamespaceClassification right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="NamespaceClassification"/>. </summary>
        public static implicit operator NamespaceClassification(string value) => new NamespaceClassification(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NamespaceClassification other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NamespaceClassification other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
