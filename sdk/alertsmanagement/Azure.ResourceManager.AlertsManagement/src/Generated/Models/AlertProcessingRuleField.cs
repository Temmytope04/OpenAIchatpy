// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    /// <summary>
    /// Field for a given condition.
    /// Serialized Name: Field
    /// </summary>
    public readonly partial struct AlertProcessingRuleField : IEquatable<AlertProcessingRuleField>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AlertProcessingRuleField"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AlertProcessingRuleField(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SeverityValue = "Severity";
        private const string MonitorServiceValue = "MonitorService";
        private const string MonitorConditionValue = "MonitorCondition";
        private const string SignalTypeValue = "SignalType";
        private const string TargetResourceTypeValue = "TargetResourceType";
        private const string TargetResourceValue = "TargetResource";
        private const string TargetResourceGroupValue = "TargetResourceGroup";
        private const string AlertRuleIdValue = "AlertRuleId";
        private const string AlertRuleNameValue = "AlertRuleName";
        private const string DescriptionValue = "Description";
        private const string AlertContextValue = "AlertContext";

        /// <summary>
        /// Severity
        /// Serialized Name: Field.Severity
        /// </summary>
        public static AlertProcessingRuleField Severity { get; } = new AlertProcessingRuleField(SeverityValue);
        /// <summary>
        /// MonitorService
        /// Serialized Name: Field.MonitorService
        /// </summary>
        public static AlertProcessingRuleField MonitorService { get; } = new AlertProcessingRuleField(MonitorServiceValue);
        /// <summary>
        /// MonitorCondition
        /// Serialized Name: Field.MonitorCondition
        /// </summary>
        public static AlertProcessingRuleField MonitorCondition { get; } = new AlertProcessingRuleField(MonitorConditionValue);
        /// <summary>
        /// SignalType
        /// Serialized Name: Field.SignalType
        /// </summary>
        public static AlertProcessingRuleField SignalType { get; } = new AlertProcessingRuleField(SignalTypeValue);
        /// <summary>
        /// TargetResourceType
        /// Serialized Name: Field.TargetResourceType
        /// </summary>
        public static AlertProcessingRuleField TargetResourceType { get; } = new AlertProcessingRuleField(TargetResourceTypeValue);
        /// <summary>
        /// TargetResource
        /// Serialized Name: Field.TargetResource
        /// </summary>
        public static AlertProcessingRuleField TargetResource { get; } = new AlertProcessingRuleField(TargetResourceValue);
        /// <summary>
        /// TargetResourceGroup
        /// Serialized Name: Field.TargetResourceGroup
        /// </summary>
        public static AlertProcessingRuleField TargetResourceGroup { get; } = new AlertProcessingRuleField(TargetResourceGroupValue);
        /// <summary>
        /// AlertRuleId
        /// Serialized Name: Field.AlertRuleId
        /// </summary>
        public static AlertProcessingRuleField AlertRuleId { get; } = new AlertProcessingRuleField(AlertRuleIdValue);
        /// <summary>
        /// AlertRuleName
        /// Serialized Name: Field.AlertRuleName
        /// </summary>
        public static AlertProcessingRuleField AlertRuleName { get; } = new AlertProcessingRuleField(AlertRuleNameValue);
        /// <summary>
        /// Description
        /// Serialized Name: Field.Description
        /// </summary>
        public static AlertProcessingRuleField Description { get; } = new AlertProcessingRuleField(DescriptionValue);
        /// <summary>
        /// AlertContext
        /// Serialized Name: Field.AlertContext
        /// </summary>
        public static AlertProcessingRuleField AlertContext { get; } = new AlertProcessingRuleField(AlertContextValue);
        /// <summary> Determines if two <see cref="AlertProcessingRuleField"/> values are the same. </summary>
        public static bool operator ==(AlertProcessingRuleField left, AlertProcessingRuleField right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AlertProcessingRuleField"/> values are not the same. </summary>
        public static bool operator !=(AlertProcessingRuleField left, AlertProcessingRuleField right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AlertProcessingRuleField"/>. </summary>
        public static implicit operator AlertProcessingRuleField(string value) => new AlertProcessingRuleField(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AlertProcessingRuleField other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AlertProcessingRuleField other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
