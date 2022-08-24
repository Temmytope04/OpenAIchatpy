// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> Defines the action to take on rule match. </summary>
    public readonly partial struct ActionType : IEquatable<ActionType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ActionType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ActionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AllowValue = "Allow";
        private const string BlockValue = "Block";
        private const string LogValue = "Log";
        private const string RedirectValue = "Redirect";

        /// <summary> Allow. </summary>
        public static ActionType Allow { get; } = new ActionType(AllowValue);
        /// <summary> Block. </summary>
        public static ActionType Block { get; } = new ActionType(BlockValue);
        /// <summary> Log. </summary>
        public static ActionType Log { get; } = new ActionType(LogValue);
        /// <summary> Redirect. </summary>
        public static ActionType Redirect { get; } = new ActionType(RedirectValue);
        /// <summary> Determines if two <see cref="ActionType"/> values are the same. </summary>
        public static bool operator ==(ActionType left, ActionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ActionType"/> values are not the same. </summary>
        public static bool operator !=(ActionType left, ActionType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ActionType"/>. </summary>
        public static implicit operator ActionType(string value) => new ActionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ActionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ActionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
