// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> Represents a single block in a block blob.  It describes the block&apos;s ID and size. </summary>
    public readonly partial struct BlobBlock
    {
        /// <summary> Initializes a new instance of BlobBlock. </summary>
        /// <param name="name"> The base64 encoded block ID. </param>
        /// <param name="size"> The block size in bytes. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        internal BlobBlock(string name, int size)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
            Size = size;
        }

        /// <summary> The base64 encoded block ID. </summary>
        public string Name { get; }
        /// <summary> The block size in bytes. </summary>
        public int Size { get; }
    }
}
