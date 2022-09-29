// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SignalR.Models
{
    /// <summary>
    /// FeatureFlags is the supported features of Azure SignalR service.
    /// - ServiceMode: Flag for backend server for SignalR service. Values allowed: &quot;Default&quot;: have your own backend server; &quot;Serverless&quot;: your application doesn&apos;t have a backend server; &quot;Classic&quot;: for backward compatibility. Support both Default and Serverless mode but not recommended; &quot;PredefinedOnly&quot;: for future use.
    /// - EnableConnectivityLogs: &quot;true&quot;/&quot;false&quot;, to enable/disable the connectivity log category respectively.
    /// - EnableMessagingLogs: &quot;true&quot;/&quot;false&quot;, to enable/disable the connectivity log category respectively.
    /// - EnableLiveTrace: Live Trace allows you to know what&apos;s happening inside Azure SignalR service, it will give you live traces in real time, it will be helpful when you developing your own Azure SignalR based web application or self-troubleshooting some issues. Please note that live traces are counted as outbound messages that will be charged. Values allowed: &quot;true&quot;/&quot;false&quot;, to enable/disable live trace feature.
    /// </summary>
    public readonly partial struct FeatureFlag : IEquatable<FeatureFlag>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FeatureFlag"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FeatureFlag(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ServiceModeValue = "ServiceMode";
        private const string EnableConnectivityLogsValue = "EnableConnectivityLogs";
        private const string EnableMessagingLogsValue = "EnableMessagingLogs";
        private const string EnableLiveTraceValue = "EnableLiveTrace";

        /// <summary> ServiceMode. </summary>
        public static FeatureFlag ServiceMode { get; } = new FeatureFlag(ServiceModeValue);
        /// <summary> EnableConnectivityLogs. </summary>
        public static FeatureFlag EnableConnectivityLogs { get; } = new FeatureFlag(EnableConnectivityLogsValue);
        /// <summary> EnableMessagingLogs. </summary>
        public static FeatureFlag EnableMessagingLogs { get; } = new FeatureFlag(EnableMessagingLogsValue);
        /// <summary> EnableLiveTrace. </summary>
        public static FeatureFlag EnableLiveTrace { get; } = new FeatureFlag(EnableLiveTraceValue);
        /// <summary> Determines if two <see cref="FeatureFlag"/> values are the same. </summary>
        public static bool operator ==(FeatureFlag left, FeatureFlag right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FeatureFlag"/> values are not the same. </summary>
        public static bool operator !=(FeatureFlag left, FeatureFlag right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FeatureFlag"/>. </summary>
        public static implicit operator FeatureFlag(string value) => new FeatureFlag(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FeatureFlag other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FeatureFlag other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
