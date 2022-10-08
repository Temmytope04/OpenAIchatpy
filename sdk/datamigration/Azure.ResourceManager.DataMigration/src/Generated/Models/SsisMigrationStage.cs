// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Current stage of SSIS migration. </summary>
    public readonly partial struct SsisMigrationStage : IEquatable<SsisMigrationStage>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SsisMigrationStage"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SsisMigrationStage(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string InitializeValue = "Initialize";
        private const string InProgressValue = "InProgress";
        private const string CompletedValue = "Completed";

        /// <summary> None. </summary>
        public static SsisMigrationStage None { get; } = new SsisMigrationStage(NoneValue);
        /// <summary> Initialize. </summary>
        public static SsisMigrationStage Initialize { get; } = new SsisMigrationStage(InitializeValue);
        /// <summary> InProgress. </summary>
        public static SsisMigrationStage InProgress { get; } = new SsisMigrationStage(InProgressValue);
        /// <summary> Completed. </summary>
        public static SsisMigrationStage Completed { get; } = new SsisMigrationStage(CompletedValue);
        /// <summary> Determines if two <see cref="SsisMigrationStage"/> values are the same. </summary>
        public static bool operator ==(SsisMigrationStage left, SsisMigrationStage right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SsisMigrationStage"/> values are not the same. </summary>
        public static bool operator !=(SsisMigrationStage left, SsisMigrationStage right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SsisMigrationStage"/>. </summary>
        public static implicit operator SsisMigrationStage(string value) => new SsisMigrationStage(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SsisMigrationStage other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SsisMigrationStage other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
