// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.OpenAI.Assistants
{
    /// <summary> The OpenAIPageableListOfThreadMessage_object. </summary>
    internal readonly partial struct OpenAIPageableListOfThreadMessageObject : IEquatable<OpenAIPageableListOfThreadMessageObject>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OpenAIPageableListOfThreadMessageObject"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OpenAIPageableListOfThreadMessageObject(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ListValue = "list";

        /// <summary> list. </summary>
        public static OpenAIPageableListOfThreadMessageObject List { get; } = new OpenAIPageableListOfThreadMessageObject(ListValue);
        /// <summary> Determines if two <see cref="OpenAIPageableListOfThreadMessageObject"/> values are the same. </summary>
        public static bool operator ==(OpenAIPageableListOfThreadMessageObject left, OpenAIPageableListOfThreadMessageObject right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OpenAIPageableListOfThreadMessageObject"/> values are not the same. </summary>
        public static bool operator !=(OpenAIPageableListOfThreadMessageObject left, OpenAIPageableListOfThreadMessageObject right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="OpenAIPageableListOfThreadMessageObject"/>. </summary>
        public static implicit operator OpenAIPageableListOfThreadMessageObject(string value) => new OpenAIPageableListOfThreadMessageObject(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OpenAIPageableListOfThreadMessageObject other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OpenAIPageableListOfThreadMessageObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
