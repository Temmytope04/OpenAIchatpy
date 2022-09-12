// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Maps.Route.Models
{
    /// <summary> Type of the incident. Can currently be JAM, ROAD_WORK, ROAD_CLOSURE, or OTHER. See &quot;tec&quot; for detailed information. </summary>
    public readonly partial struct TrafficIncidentCategory : IEquatable<TrafficIncidentCategory>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TrafficIncidentCategory"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TrafficIncidentCategory(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string JamValue = "JAM";
        private const string RoadWorkValue = "ROAD_WORK";
        private const string RoadClosureValue = "ROAD_CLOSURE";
        private const string OtherValue = "OTHER";

        /// <summary> Traffic jam. </summary>
        public static TrafficIncidentCategory Jam { get; } = new TrafficIncidentCategory(JamValue);
        /// <summary> Road work. </summary>
        public static TrafficIncidentCategory RoadWork { get; } = new TrafficIncidentCategory(RoadWorkValue);
        /// <summary> Road closure. </summary>
        public static TrafficIncidentCategory RoadClosure { get; } = new TrafficIncidentCategory(RoadClosureValue);
        /// <summary> Other. </summary>
        public static TrafficIncidentCategory Other { get; } = new TrafficIncidentCategory(OtherValue);
        /// <summary> Determines if two <see cref="TrafficIncidentCategory"/> values are the same. </summary>
        public static bool operator ==(TrafficIncidentCategory left, TrafficIncidentCategory right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TrafficIncidentCategory"/> values are not the same. </summary>
        public static bool operator !=(TrafficIncidentCategory left, TrafficIncidentCategory right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="TrafficIncidentCategory"/>. </summary>
        public static implicit operator TrafficIncidentCategory(string value) => new TrafficIncidentCategory(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TrafficIncidentCategory other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TrafficIncidentCategory other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
