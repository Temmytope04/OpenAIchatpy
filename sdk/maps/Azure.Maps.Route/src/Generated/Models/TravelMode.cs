// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Maps.Route.Models
{
    /// <summary> The TravelMode. </summary>
    public readonly partial struct TravelMode : IEquatable<TravelMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TravelMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TravelMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CarValue = "car";
        private const string TruckValue = "truck";
        private const string TaxiValue = "taxi";
        private const string BusValue = "bus";
        private const string VanValue = "van";
        private const string MotorcycleValue = "motorcycle";
        private const string BicycleValue = "bicycle";
        private const string PedestrianValue = "pedestrian";

        /// <summary> The returned routes are optimized for cars. </summary>
        public static TravelMode Car { get; } = new TravelMode(CarValue);
        /// <summary> The returned routes are optimized for commercial vehicles, like for trucks. </summary>
        public static TravelMode Truck { get; } = new TravelMode(TruckValue);
        /// <summary> The returned routes are optimized for taxis. BETA functionality. </summary>
        public static TravelMode Taxi { get; } = new TravelMode(TaxiValue);
        /// <summary> The returned routes are optimized for buses, including the use of bus only lanes. BETA functionality. </summary>
        public static TravelMode Bus { get; } = new TravelMode(BusValue);
        /// <summary> The returned routes are optimized for vans. BETA functionality. </summary>
        public static TravelMode Van { get; } = new TravelMode(VanValue);
        /// <summary> The returned routes are optimized for motorcycles. BETA functionality. </summary>
        public static TravelMode Motorcycle { get; } = new TravelMode(MotorcycleValue);
        /// <summary> The returned routes are optimized for bicycles, including use of bicycle lanes. </summary>
        public static TravelMode Bicycle { get; } = new TravelMode(BicycleValue);
        /// <summary> The returned routes are optimized for pedestrians, including the use of sidewalks. </summary>
        public static TravelMode Pedestrian { get; } = new TravelMode(PedestrianValue);
        /// <summary> Determines if two <see cref="TravelMode"/> values are the same. </summary>
        public static bool operator ==(TravelMode left, TravelMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TravelMode"/> values are not the same. </summary>
        public static bool operator !=(TravelMode left, TravelMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="TravelMode"/>. </summary>
        public static implicit operator TravelMode(string value) => new TravelMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TravelMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TravelMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
