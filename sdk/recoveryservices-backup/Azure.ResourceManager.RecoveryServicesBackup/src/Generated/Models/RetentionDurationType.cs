// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Retention duration type of retention policy. </summary>
    public readonly partial struct RetentionDurationType : IEquatable<RetentionDurationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RetentionDurationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RetentionDurationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidValue = "Invalid";
        private const string DaysValue = "Days";
        private const string WeeksValue = "Weeks";
        private const string MonthsValue = "Months";
        private const string YearsValue = "Years";

        /// <summary> Invalid. </summary>
        public static RetentionDurationType Invalid { get; } = new RetentionDurationType(InvalidValue);
        /// <summary> Days. </summary>
        public static RetentionDurationType Days { get; } = new RetentionDurationType(DaysValue);
        /// <summary> Weeks. </summary>
        public static RetentionDurationType Weeks { get; } = new RetentionDurationType(WeeksValue);
        /// <summary> Months. </summary>
        public static RetentionDurationType Months { get; } = new RetentionDurationType(MonthsValue);
        /// <summary> Years. </summary>
        public static RetentionDurationType Years { get; } = new RetentionDurationType(YearsValue);
        /// <summary> Determines if two <see cref="RetentionDurationType"/> values are the same. </summary>
        public static bool operator ==(RetentionDurationType left, RetentionDurationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RetentionDurationType"/> values are not the same. </summary>
        public static bool operator !=(RetentionDurationType left, RetentionDurationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RetentionDurationType"/>. </summary>
        public static implicit operator RetentionDurationType(string value) => new RetentionDurationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RetentionDurationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RetentionDurationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
