// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Provisioning state of the resource. </summary>
    public readonly partial struct HDInsightProvisioningStatus : IEquatable<HDInsightProvisioningStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HDInsightProvisioningStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HDInsightProvisioningStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AcceptedValue = "Accepted";
        private const string SucceededValue = "Succeeded";
        private const string CanceledValue = "Canceled";
        private const string FailedValue = "Failed";

        /// <summary> Accepted. </summary>
        public static HDInsightProvisioningStatus Accepted { get; } = new HDInsightProvisioningStatus(AcceptedValue);
        /// <summary> Succeeded. </summary>
        public static HDInsightProvisioningStatus Succeeded { get; } = new HDInsightProvisioningStatus(SucceededValue);
        /// <summary> Canceled. </summary>
        public static HDInsightProvisioningStatus Canceled { get; } = new HDInsightProvisioningStatus(CanceledValue);
        /// <summary> Failed. </summary>
        public static HDInsightProvisioningStatus Failed { get; } = new HDInsightProvisioningStatus(FailedValue);
        /// <summary> Determines if two <see cref="HDInsightProvisioningStatus"/> values are the same. </summary>
        public static bool operator ==(HDInsightProvisioningStatus left, HDInsightProvisioningStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HDInsightProvisioningStatus"/> values are not the same. </summary>
        public static bool operator !=(HDInsightProvisioningStatus left, HDInsightProvisioningStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="HDInsightProvisioningStatus"/>. </summary>
        public static implicit operator HDInsightProvisioningStatus(string value) => new HDInsightProvisioningStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HDInsightProvisioningStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HDInsightProvisioningStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
