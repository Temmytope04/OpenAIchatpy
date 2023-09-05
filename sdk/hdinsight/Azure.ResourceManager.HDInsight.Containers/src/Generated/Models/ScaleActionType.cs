// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> The action type. </summary>
    public readonly partial struct ScaleActionType : IEquatable<ScaleActionType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ScaleActionType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ScaleActionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ScaleUpValue = "scaleup";
        private const string ScaleDownValue = "scaledown";

        /// <summary> scaleup. </summary>
        public static ScaleActionType ScaleUp { get; } = new ScaleActionType(ScaleUpValue);
        /// <summary> scaledown. </summary>
        public static ScaleActionType ScaleDown { get; } = new ScaleActionType(ScaleDownValue);
        /// <summary> Determines if two <see cref="ScaleActionType"/> values are the same. </summary>
        public static bool operator ==(ScaleActionType left, ScaleActionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ScaleActionType"/> values are not the same. </summary>
        public static bool operator !=(ScaleActionType left, ScaleActionType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ScaleActionType"/>. </summary>
        public static implicit operator ScaleActionType(string value) => new ScaleActionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ScaleActionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ScaleActionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
