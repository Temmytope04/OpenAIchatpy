// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The status of the packet capture session. </summary>
    public readonly partial struct PcStatus : IEquatable<PcStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PcStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PcStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotStartedValue = "NotStarted";
        private const string RunningValue = "Running";
        private const string StoppedValue = "Stopped";
        private const string ErrorValue = "Error";
        private const string UnknownValue = "Unknown";

        /// <summary> NotStarted. </summary>
        public static PcStatus NotStarted { get; } = new PcStatus(NotStartedValue);
        /// <summary> Running. </summary>
        public static PcStatus Running { get; } = new PcStatus(RunningValue);
        /// <summary> Stopped. </summary>
        public static PcStatus Stopped { get; } = new PcStatus(StoppedValue);
        /// <summary> Error. </summary>
        public static PcStatus Error { get; } = new PcStatus(ErrorValue);
        /// <summary> Unknown. </summary>
        public static PcStatus Unknown { get; } = new PcStatus(UnknownValue);
        /// <summary> Determines if two <see cref="PcStatus"/> values are the same. </summary>
        public static bool operator ==(PcStatus left, PcStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PcStatus"/> values are not the same. </summary>
        public static bool operator !=(PcStatus left, PcStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="PcStatus"/>. </summary>
        public static implicit operator PcStatus(string value) => new PcStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PcStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PcStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
