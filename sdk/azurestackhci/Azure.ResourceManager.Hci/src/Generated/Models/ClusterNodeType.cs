// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> The node type of all the nodes of the cluster. </summary>
    public readonly partial struct ClusterNodeType : IEquatable<ClusterNodeType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ClusterNodeType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ClusterNodeType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FirstPartyValue = "FirstParty";
        private const string ThirdPartyValue = "ThirdParty";

        /// <summary> FirstParty. </summary>
        public static ClusterNodeType FirstParty { get; } = new ClusterNodeType(FirstPartyValue);
        /// <summary> ThirdParty. </summary>
        public static ClusterNodeType ThirdParty { get; } = new ClusterNodeType(ThirdPartyValue);
        /// <summary> Determines if two <see cref="ClusterNodeType"/> values are the same. </summary>
        public static bool operator ==(ClusterNodeType left, ClusterNodeType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ClusterNodeType"/> values are not the same. </summary>
        public static bool operator !=(ClusterNodeType left, ClusterNodeType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ClusterNodeType"/>. </summary>
        public static implicit operator ClusterNodeType(string value) => new ClusterNodeType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ClusterNodeType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ClusterNodeType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
