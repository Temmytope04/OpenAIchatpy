// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MongoCluster.Models
{
    /// <summary> Replication role of the mongo cluster. </summary>
    public readonly partial struct MongoClusterReplicationRole : IEquatable<MongoClusterReplicationRole>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MongoClusterReplicationRole"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MongoClusterReplicationRole(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PrimaryValue = "Primary";
        private const string AsyncReplicaValue = "AsyncReplica";
        private const string GeoAsyncReplicaValue = "GeoAsyncReplica";

        /// <summary> The cluster is a primary replica. </summary>
        public static MongoClusterReplicationRole Primary { get; } = new MongoClusterReplicationRole(PrimaryValue);
        /// <summary> The cluster is a local asynchronous replica. </summary>
        public static MongoClusterReplicationRole AsyncReplica { get; } = new MongoClusterReplicationRole(AsyncReplicaValue);
        /// <summary> The cluster is a geo-asynchronous replica. </summary>
        public static MongoClusterReplicationRole GeoAsyncReplica { get; } = new MongoClusterReplicationRole(GeoAsyncReplicaValue);
        /// <summary> Determines if two <see cref="MongoClusterReplicationRole"/> values are the same. </summary>
        public static bool operator ==(MongoClusterReplicationRole left, MongoClusterReplicationRole right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MongoClusterReplicationRole"/> values are not the same. </summary>
        public static bool operator !=(MongoClusterReplicationRole left, MongoClusterReplicationRole right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="MongoClusterReplicationRole"/>. </summary>
        public static implicit operator MongoClusterReplicationRole(string value) => new MongoClusterReplicationRole(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MongoClusterReplicationRole other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MongoClusterReplicationRole other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
