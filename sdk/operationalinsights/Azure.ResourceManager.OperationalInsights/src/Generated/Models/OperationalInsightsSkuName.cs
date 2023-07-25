// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> The name of the Service Tier. </summary>
    public readonly partial struct OperationalInsightsSkuName : IEquatable<OperationalInsightsSkuName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OperationalInsightsSkuName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OperationalInsightsSkuName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FreeValue = "Free";
        private const string StandardValue = "Standard";
        private const string PremiumValue = "Premium";
        private const string PerNodeValue = "PerNode";
        private const string PerGB2018Value = "PerGB2018";
        private const string StandaloneValue = "Standalone";
        private const string CapacityReservationValue = "CapacityReservation";

        /// <summary> Free. </summary>
        public static OperationalInsightsSkuName Free { get; } = new OperationalInsightsSkuName(FreeValue);
        /// <summary> Standard. </summary>
        public static OperationalInsightsSkuName Standard { get; } = new OperationalInsightsSkuName(StandardValue);
        /// <summary> Premium. </summary>
        public static OperationalInsightsSkuName Premium { get; } = new OperationalInsightsSkuName(PremiumValue);
        /// <summary> PerNode. </summary>
        public static OperationalInsightsSkuName PerNode { get; } = new OperationalInsightsSkuName(PerNodeValue);
        /// <summary> PerGB2018. </summary>
        public static OperationalInsightsSkuName PerGB2018 { get; } = new OperationalInsightsSkuName(PerGB2018Value);
        /// <summary> Standalone. </summary>
        public static OperationalInsightsSkuName Standalone { get; } = new OperationalInsightsSkuName(StandaloneValue);
        /// <summary> CapacityReservation. </summary>
        public static OperationalInsightsSkuName CapacityReservation { get; } = new OperationalInsightsSkuName(CapacityReservationValue);
        /// <summary> Determines if two <see cref="OperationalInsightsSkuName"/> values are the same. </summary>
        public static bool operator ==(OperationalInsightsSkuName left, OperationalInsightsSkuName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OperationalInsightsSkuName"/> values are not the same. </summary>
        public static bool operator !=(OperationalInsightsSkuName left, OperationalInsightsSkuName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="OperationalInsightsSkuName"/>. </summary>
        public static implicit operator OperationalInsightsSkuName(string value) => new OperationalInsightsSkuName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OperationalInsightsSkuName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OperationalInsightsSkuName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
