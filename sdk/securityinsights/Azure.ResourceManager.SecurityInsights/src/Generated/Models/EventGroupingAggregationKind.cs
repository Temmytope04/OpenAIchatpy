// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The event grouping aggregation kinds. </summary>
    public readonly partial struct EventGroupingAggregationKind : IEquatable<EventGroupingAggregationKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EventGroupingAggregationKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EventGroupingAggregationKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SingleAlertValue = "SingleAlert";
        private const string AlertPerResultValue = "AlertPerResult";

        /// <summary> SingleAlert. </summary>
        public static EventGroupingAggregationKind SingleAlert { get; } = new EventGroupingAggregationKind(SingleAlertValue);
        /// <summary> AlertPerResult. </summary>
        public static EventGroupingAggregationKind AlertPerResult { get; } = new EventGroupingAggregationKind(AlertPerResultValue);
        /// <summary> Determines if two <see cref="EventGroupingAggregationKind"/> values are the same. </summary>
        public static bool operator ==(EventGroupingAggregationKind left, EventGroupingAggregationKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EventGroupingAggregationKind"/> values are not the same. </summary>
        public static bool operator !=(EventGroupingAggregationKind left, EventGroupingAggregationKind right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="EventGroupingAggregationKind"/>. </summary>
        public static implicit operator EventGroupingAggregationKind(string value) => new EventGroupingAggregationKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EventGroupingAggregationKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EventGroupingAggregationKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
