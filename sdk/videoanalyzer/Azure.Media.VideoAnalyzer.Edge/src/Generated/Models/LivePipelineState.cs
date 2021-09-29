// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Current pipeline state (read-only). </summary>
    public readonly partial struct LivePipelineState : IEquatable<LivePipelineState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LivePipelineState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LivePipelineState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InactiveValue = "inactive";
        private const string ActivatingValue = "activating";
        private const string ActiveValue = "active";
        private const string DeactivatingValue = "deactivating";

        /// <summary> The live pipeline is idle and not processing media. </summary>
        public static LivePipelineState Inactive { get; } = new LivePipelineState(InactiveValue);
        /// <summary> The live pipeline is transitioning into the active state. </summary>
        public static LivePipelineState Activating { get; } = new LivePipelineState(ActivatingValue);
        /// <summary> The live pipeline is active and able to process media. If your data source is not available, for instance, if your RTSP camera is powered off or unreachable, the pipeline will still be active and periodically retrying the connection. Your Azure subscription will be billed for the duration in which the live pipeline is in the active state. </summary>
        public static LivePipelineState Active { get; } = new LivePipelineState(ActiveValue);
        /// <summary> The live pipeline is transitioning into the inactive state. </summary>
        public static LivePipelineState Deactivating { get; } = new LivePipelineState(DeactivatingValue);
        /// <summary> Determines if two <see cref="LivePipelineState"/> values are the same. </summary>
        public static bool operator ==(LivePipelineState left, LivePipelineState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LivePipelineState"/> values are not the same. </summary>
        public static bool operator !=(LivePipelineState left, LivePipelineState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="LivePipelineState"/>. </summary>
        public static implicit operator LivePipelineState(string value) => new LivePipelineState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LivePipelineState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LivePipelineState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
