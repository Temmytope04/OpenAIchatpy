// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Consumption.Models
{
    /// <summary> The billing frequency. </summary>
    public readonly partial struct ConsumptionBillingFrequency : IEquatable<ConsumptionBillingFrequency>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ConsumptionBillingFrequency"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ConsumptionBillingFrequency(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MonthValue = "Month";
        private const string QuarterValue = "Quarter";
        private const string YearValue = "Year";

        /// <summary> Month. </summary>
        public static ConsumptionBillingFrequency Month { get; } = new ConsumptionBillingFrequency(MonthValue);
        /// <summary> Quarter. </summary>
        public static ConsumptionBillingFrequency Quarter { get; } = new ConsumptionBillingFrequency(QuarterValue);
        /// <summary> Year. </summary>
        public static ConsumptionBillingFrequency Year { get; } = new ConsumptionBillingFrequency(YearValue);
        /// <summary> Determines if two <see cref="ConsumptionBillingFrequency"/> values are the same. </summary>
        public static bool operator ==(ConsumptionBillingFrequency left, ConsumptionBillingFrequency right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ConsumptionBillingFrequency"/> values are not the same. </summary>
        public static bool operator !=(ConsumptionBillingFrequency left, ConsumptionBillingFrequency right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ConsumptionBillingFrequency"/>. </summary>
        public static implicit operator ConsumptionBillingFrequency(string value) => new ConsumptionBillingFrequency(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ConsumptionBillingFrequency other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ConsumptionBillingFrequency other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
