// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> Type of issue. </summary>
    public readonly partial struct BatchIssueType : IEquatable<BatchIssueType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BatchIssueType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BatchIssueType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string ConfigurationPropagationFailureValue = "ConfigurationPropagationFailure";
        private const string MissingPerimeterConfigurationValue = "MissingPerimeterConfiguration";
        private const string MissingIdentityConfigurationValue = "MissingIdentityConfiguration";

        /// <summary> Unknown issue type. </summary>
        public static BatchIssueType Unknown { get; } = new BatchIssueType(UnknownValue);
        /// <summary> An error occurred while applying the network security perimeter (NSP) configuration. </summary>
        public static BatchIssueType ConfigurationPropagationFailure { get; } = new BatchIssueType(ConfigurationPropagationFailureValue);
        /// <summary> A network connectivity issue is happening on the resource which could be addressed either by adding new resources to the network security perimeter (NSP) or by modifying access rules. </summary>
        public static BatchIssueType MissingPerimeterConfiguration { get; } = new BatchIssueType(MissingPerimeterConfigurationValue);
        /// <summary> An managed identity hasn't been associated with the resource. The resource will still be able to validate inbound traffic from the network security perimeter (NSP) or matching inbound access rules, but it won't be able to perform outbound access as a member of the NSP. </summary>
        public static BatchIssueType MissingIdentityConfiguration { get; } = new BatchIssueType(MissingIdentityConfigurationValue);
        /// <summary> Determines if two <see cref="BatchIssueType"/> values are the same. </summary>
        public static bool operator ==(BatchIssueType left, BatchIssueType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BatchIssueType"/> values are not the same. </summary>
        public static bool operator !=(BatchIssueType left, BatchIssueType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="BatchIssueType"/>. </summary>
        public static implicit operator BatchIssueType(string value) => new BatchIssueType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BatchIssueType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BatchIssueType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
