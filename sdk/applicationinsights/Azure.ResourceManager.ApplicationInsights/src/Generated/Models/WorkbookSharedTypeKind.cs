// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> The kind of workbook. Only valid value is shared. </summary>
    public readonly partial struct WorkbookSharedTypeKind : IEquatable<WorkbookSharedTypeKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="WorkbookSharedTypeKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public WorkbookSharedTypeKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SharedValue = "shared";

        /// <summary> shared. </summary>
        public static WorkbookSharedTypeKind Shared { get; } = new WorkbookSharedTypeKind(SharedValue);
        /// <summary> Determines if two <see cref="WorkbookSharedTypeKind"/> values are the same. </summary>
        public static bool operator ==(WorkbookSharedTypeKind left, WorkbookSharedTypeKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="WorkbookSharedTypeKind"/> values are not the same. </summary>
        public static bool operator !=(WorkbookSharedTypeKind left, WorkbookSharedTypeKind right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="WorkbookSharedTypeKind"/>. </summary>
        public static implicit operator WorkbookSharedTypeKind(string value) => new WorkbookSharedTypeKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is WorkbookSharedTypeKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(WorkbookSharedTypeKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
