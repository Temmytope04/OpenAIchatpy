// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary>
    /// Describes how to ingest the records in the file.
    /// Serialized Name: IngestionMode
    /// </summary>
    public readonly partial struct IngestionMode : IEquatable<IngestionMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IngestionMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IngestionMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IngestOnlyIfAllAreValidValue = "IngestOnlyIfAllAreValid";
        private const string IngestAnyValidRecordsValue = "IngestAnyValidRecords";
        private const string UnspecifiedValue = "Unspecified";

        /// <summary>
        /// No records should be ingested when invalid records are detected.
        /// Serialized Name: IngestionMode.IngestOnlyIfAllAreValid
        /// </summary>
        public static IngestionMode IngestOnlyIfAllAreValid { get; } = new IngestionMode(IngestOnlyIfAllAreValidValue);
        /// <summary>
        /// Valid records should still be ingested when invalid records are detected.
        /// Serialized Name: IngestionMode.IngestAnyValidRecords
        /// </summary>
        public static IngestionMode IngestAnyValidRecords { get; } = new IngestionMode(IngestAnyValidRecordsValue);
        /// <summary>
        /// Unspecified
        /// Serialized Name: IngestionMode.Unspecified
        /// </summary>
        public static IngestionMode Unspecified { get; } = new IngestionMode(UnspecifiedValue);
        /// <summary> Determines if two <see cref="IngestionMode"/> values are the same. </summary>
        public static bool operator ==(IngestionMode left, IngestionMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IngestionMode"/> values are not the same. </summary>
        public static bool operator !=(IngestionMode left, IngestionMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="IngestionMode"/>. </summary>
        public static implicit operator IngestionMode(string value) => new IngestionMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IngestionMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IngestionMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
