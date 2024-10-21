// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Enum of weekday. </summary>
    public readonly partial struct MachineLearningComputeWeekDay : IEquatable<MachineLearningComputeWeekDay>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MachineLearningComputeWeekDay"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MachineLearningComputeWeekDay(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MondayValue = "Monday";
        private const string TuesdayValue = "Tuesday";
        private const string WednesdayValue = "Wednesday";
        private const string ThursdayValue = "Thursday";
        private const string FridayValue = "Friday";
        private const string SaturdayValue = "Saturday";
        private const string SundayValue = "Sunday";

        /// <summary> Monday weekday. </summary>
        public static MachineLearningComputeWeekDay Monday { get; } = new MachineLearningComputeWeekDay(MondayValue);
        /// <summary> Tuesday weekday. </summary>
        public static MachineLearningComputeWeekDay Tuesday { get; } = new MachineLearningComputeWeekDay(TuesdayValue);
        /// <summary> Wednesday weekday. </summary>
        public static MachineLearningComputeWeekDay Wednesday { get; } = new MachineLearningComputeWeekDay(WednesdayValue);
        /// <summary> Thursday weekday. </summary>
        public static MachineLearningComputeWeekDay Thursday { get; } = new MachineLearningComputeWeekDay(ThursdayValue);
        /// <summary> Friday weekday. </summary>
        public static MachineLearningComputeWeekDay Friday { get; } = new MachineLearningComputeWeekDay(FridayValue);
        /// <summary> Saturday weekday. </summary>
        public static MachineLearningComputeWeekDay Saturday { get; } = new MachineLearningComputeWeekDay(SaturdayValue);
        /// <summary> Sunday weekday. </summary>
        public static MachineLearningComputeWeekDay Sunday { get; } = new MachineLearningComputeWeekDay(SundayValue);
        /// <summary> Determines if two <see cref="MachineLearningComputeWeekDay"/> values are the same. </summary>
        public static bool operator ==(MachineLearningComputeWeekDay left, MachineLearningComputeWeekDay right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MachineLearningComputeWeekDay"/> values are not the same. </summary>
        public static bool operator !=(MachineLearningComputeWeekDay left, MachineLearningComputeWeekDay right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="MachineLearningComputeWeekDay"/>. </summary>
        public static implicit operator MachineLearningComputeWeekDay(string value) => new MachineLearningComputeWeekDay(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MachineLearningComputeWeekDay other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MachineLearningComputeWeekDay other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
