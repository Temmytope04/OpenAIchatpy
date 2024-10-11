// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Language.Text
{
    /// <summary> The weight Unit of measurement. </summary>
    public readonly partial struct WeightUnit : IEquatable<WeightUnit>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="WeightUnit"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public WeightUnit(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnspecifiedValue = "Unspecified";
        private const string KilogramValue = "Kilogram";
        private const string GramValue = "Gram";
        private const string MilligramValue = "Milligram";
        private const string GallonValue = "Gallon";
        private const string MetricTonValue = "MetricTon";
        private const string TonValue = "Ton";
        private const string PoundValue = "Pound";
        private const string OunceValue = "Ounce";
        private const string GrainValue = "Grain";
        private const string PennyWeightValue = "PennyWeight";
        private const string LongTonBritishValue = "LongTonBritish";
        private const string ShortTonUsValue = "ShortTonUS";
        private const string ShortHundredWeightUsValue = "ShortHundredWeightUS";
        private const string StoneValue = "Stone";
        private const string DramValue = "Dram";

        /// <summary> Unspecified weight unit. </summary>
        public static WeightUnit Unspecified { get; } = new WeightUnit(UnspecifiedValue);
        /// <summary> Weight unit in kilograms. </summary>
        public static WeightUnit Kilogram { get; } = new WeightUnit(KilogramValue);
        /// <summary> Weight unit in grams. </summary>
        public static WeightUnit Gram { get; } = new WeightUnit(GramValue);
        /// <summary> Weight unit in milligrams. </summary>
        public static WeightUnit Milligram { get; } = new WeightUnit(MilligramValue);
        /// <summary> Volume unit in gallons. </summary>
        public static WeightUnit Gallon { get; } = new WeightUnit(GallonValue);
        /// <summary> Weight unit in metric tons. </summary>
        public static WeightUnit MetricTon { get; } = new WeightUnit(MetricTonValue);
        /// <summary> Weight unit in tons. </summary>
        public static WeightUnit Ton { get; } = new WeightUnit(TonValue);
        /// <summary> Weight unit in pounds. </summary>
        public static WeightUnit Pound { get; } = new WeightUnit(PoundValue);
        /// <summary> Weight unit in ounces. </summary>
        public static WeightUnit Ounce { get; } = new WeightUnit(OunceValue);
        /// <summary> Weight unit in grains. </summary>
        public static WeightUnit Grain { get; } = new WeightUnit(GrainValue);
        /// <summary> Weight unit in pennyweights. </summary>
        public static WeightUnit PennyWeight { get; } = new WeightUnit(PennyWeightValue);
        /// <summary> Weight unit in long tons (British). </summary>
        public static WeightUnit LongTonBritish { get; } = new WeightUnit(LongTonBritishValue);
        /// <summary> Weight unit in short tons (US). </summary>
        public static WeightUnit ShortTonUs { get; } = new WeightUnit(ShortTonUsValue);
        /// <summary> Weight unit in short hundredweights (US). </summary>
        public static WeightUnit ShortHundredWeightUs { get; } = new WeightUnit(ShortHundredWeightUsValue);
        /// <summary> Weight unit in stones. </summary>
        public static WeightUnit Stone { get; } = new WeightUnit(StoneValue);
        /// <summary> Weight unit in drams. </summary>
        public static WeightUnit Dram { get; } = new WeightUnit(DramValue);
        /// <summary> Determines if two <see cref="WeightUnit"/> values are the same. </summary>
        public static bool operator ==(WeightUnit left, WeightUnit right) => left.Equals(right);
        /// <summary> Determines if two <see cref="WeightUnit"/> values are not the same. </summary>
        public static bool operator !=(WeightUnit left, WeightUnit right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="WeightUnit"/>. </summary>
        public static implicit operator WeightUnit(string value) => new WeightUnit(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is WeightUnit other && Equals(other);
        /// <inheritdoc />
        public bool Equals(WeightUnit other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
