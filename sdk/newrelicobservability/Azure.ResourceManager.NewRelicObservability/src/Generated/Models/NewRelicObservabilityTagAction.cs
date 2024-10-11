// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    /// <summary> Valid actions for a filtering tag. Exclusion takes priority over inclusion. </summary>
    public readonly partial struct NewRelicObservabilityTagAction : IEquatable<NewRelicObservabilityTagAction>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NewRelicObservabilityTagAction"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NewRelicObservabilityTagAction(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IncludeValue = "Include";
        private const string ExcludeValue = "Exclude";

        /// <summary> Include. </summary>
        public static NewRelicObservabilityTagAction Include { get; } = new NewRelicObservabilityTagAction(IncludeValue);
        /// <summary> Exclude. </summary>
        public static NewRelicObservabilityTagAction Exclude { get; } = new NewRelicObservabilityTagAction(ExcludeValue);
        /// <summary> Determines if two <see cref="NewRelicObservabilityTagAction"/> values are the same. </summary>
        public static bool operator ==(NewRelicObservabilityTagAction left, NewRelicObservabilityTagAction right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NewRelicObservabilityTagAction"/> values are not the same. </summary>
        public static bool operator !=(NewRelicObservabilityTagAction left, NewRelicObservabilityTagAction right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="NewRelicObservabilityTagAction"/>. </summary>
        public static implicit operator NewRelicObservabilityTagAction(string value) => new NewRelicObservabilityTagAction(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NewRelicObservabilityTagAction other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NewRelicObservabilityTagAction other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
