// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    /// <summary>
    /// Operator for a given condition.
    /// Serialized Name: Operator
    /// </summary>
    public readonly partial struct AlertProcessingRuleOperator : IEquatable<AlertProcessingRuleOperator>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AlertProcessingRuleOperator"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AlertProcessingRuleOperator(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EqualsValueValue = "Equals";
        private const string NotEqualsValue = "NotEquals";
        private const string ContainsValue = "Contains";
        private const string DoesNotContainValue = "DoesNotContain";

        /// <summary>
        /// Equals
        /// Serialized Name: Operator.Equals
        /// </summary>
        public static AlertProcessingRuleOperator EqualsValue { get; } = new AlertProcessingRuleOperator(EqualsValueValue);
        /// <summary>
        /// NotEquals
        /// Serialized Name: Operator.NotEquals
        /// </summary>
        public static AlertProcessingRuleOperator NotEquals { get; } = new AlertProcessingRuleOperator(NotEqualsValue);
        /// <summary>
        /// Contains
        /// Serialized Name: Operator.Contains
        /// </summary>
        public static AlertProcessingRuleOperator Contains { get; } = new AlertProcessingRuleOperator(ContainsValue);
        /// <summary>
        /// DoesNotContain
        /// Serialized Name: Operator.DoesNotContain
        /// </summary>
        public static AlertProcessingRuleOperator DoesNotContain { get; } = new AlertProcessingRuleOperator(DoesNotContainValue);
        /// <summary> Determines if two <see cref="AlertProcessingRuleOperator"/> values are the same. </summary>
        public static bool operator ==(AlertProcessingRuleOperator left, AlertProcessingRuleOperator right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AlertProcessingRuleOperator"/> values are not the same. </summary>
        public static bool operator !=(AlertProcessingRuleOperator left, AlertProcessingRuleOperator right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AlertProcessingRuleOperator"/>. </summary>
        public static implicit operator AlertProcessingRuleOperator(string value) => new AlertProcessingRuleOperator(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AlertProcessingRuleOperator other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AlertProcessingRuleOperator other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
