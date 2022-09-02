// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.CallingServer
{
    /// <summary> The RecordingState. </summary>
    public readonly partial struct RecordingState : IEquatable<RecordingState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RecordingState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RecordingState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ActiveValue = "active";
        private const string InactiveValue = "inactive";

        /// <summary> active. </summary>
        public static RecordingState Active { get; } = new RecordingState(ActiveValue);
        /// <summary> inactive. </summary>
        public static RecordingState Inactive { get; } = new RecordingState(InactiveValue);
        /// <summary> Determines if two <see cref="RecordingState"/> values are the same. </summary>
        public static bool operator ==(RecordingState left, RecordingState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RecordingState"/> values are not the same. </summary>
        public static bool operator !=(RecordingState left, RecordingState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RecordingState"/>. </summary>
        public static implicit operator RecordingState(string value) => new RecordingState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RecordingState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RecordingState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
