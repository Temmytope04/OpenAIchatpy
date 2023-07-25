// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> The name of blob storage event type to process. </summary>
    public readonly partial struct SynapseBlobStorageEventType : IEquatable<SynapseBlobStorageEventType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SynapseBlobStorageEventType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SynapseBlobStorageEventType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MicrosoftStorageBlobCreatedValue = "Microsoft.Storage.BlobCreated";
        private const string MicrosoftStorageBlobRenamedValue = "Microsoft.Storage.BlobRenamed";

        /// <summary> Microsoft.Storage.BlobCreated. </summary>
        public static SynapseBlobStorageEventType MicrosoftStorageBlobCreated { get; } = new SynapseBlobStorageEventType(MicrosoftStorageBlobCreatedValue);
        /// <summary> Microsoft.Storage.BlobRenamed. </summary>
        public static SynapseBlobStorageEventType MicrosoftStorageBlobRenamed { get; } = new SynapseBlobStorageEventType(MicrosoftStorageBlobRenamedValue);
        /// <summary> Determines if two <see cref="SynapseBlobStorageEventType"/> values are the same. </summary>
        public static bool operator ==(SynapseBlobStorageEventType left, SynapseBlobStorageEventType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SynapseBlobStorageEventType"/> values are not the same. </summary>
        public static bool operator !=(SynapseBlobStorageEventType left, SynapseBlobStorageEventType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SynapseBlobStorageEventType"/>. </summary>
        public static implicit operator SynapseBlobStorageEventType(string value) => new SynapseBlobStorageEventType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SynapseBlobStorageEventType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SynapseBlobStorageEventType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
