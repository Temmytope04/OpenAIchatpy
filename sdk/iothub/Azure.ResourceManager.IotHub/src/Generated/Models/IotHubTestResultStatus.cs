// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> Result of testing route. </summary>
    public readonly partial struct IotHubTestResultStatus : IEquatable<IotHubTestResultStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IotHubTestResultStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IotHubTestResultStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UndefinedValue = "undefined";
        private const string FalseValue = "false";
        private const string TrueValue = "true";

        /// <summary> undefined. </summary>
        public static IotHubTestResultStatus Undefined { get; } = new IotHubTestResultStatus(UndefinedValue);
        /// <summary> false. </summary>
        public static IotHubTestResultStatus False { get; } = new IotHubTestResultStatus(FalseValue);
        /// <summary> true. </summary>
        public static IotHubTestResultStatus True { get; } = new IotHubTestResultStatus(TrueValue);
        /// <summary> Determines if two <see cref="IotHubTestResultStatus"/> values are the same. </summary>
        public static bool operator ==(IotHubTestResultStatus left, IotHubTestResultStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IotHubTestResultStatus"/> values are not the same. </summary>
        public static bool operator !=(IotHubTestResultStatus left, IotHubTestResultStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="IotHubTestResultStatus"/>. </summary>
        public static implicit operator IotHubTestResultStatus(string value) => new IotHubTestResultStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IotHubTestResultStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IotHubTestResultStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
