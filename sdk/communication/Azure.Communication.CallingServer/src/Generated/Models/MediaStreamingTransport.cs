// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.CallingServer
{
    /// <summary> The type of transport to be used for media streaming, eg. Websocket. </summary>
    public readonly partial struct MediaStreamingTransport : IEquatable<MediaStreamingTransport>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MediaStreamingTransport"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MediaStreamingTransport(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string WebsocketValue = "websocket";

        /// <summary> websocket. </summary>
        public static MediaStreamingTransport Websocket { get; } = new MediaStreamingTransport(WebsocketValue);
        /// <summary> Determines if two <see cref="MediaStreamingTransport"/> values are the same. </summary>
        public static bool operator ==(MediaStreamingTransport left, MediaStreamingTransport right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MediaStreamingTransport"/> values are not the same. </summary>
        public static bool operator !=(MediaStreamingTransport left, MediaStreamingTransport right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="MediaStreamingTransport"/>. </summary>
        public static implicit operator MediaStreamingTransport(string value) => new MediaStreamingTransport(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MediaStreamingTransport other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MediaStreamingTransport other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
