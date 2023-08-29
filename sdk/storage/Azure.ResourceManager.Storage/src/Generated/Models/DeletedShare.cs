// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The deleted share to be restored. </summary>
    public partial class DeletedShare
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DeletedShare"/>. </summary>
        /// <param name="deletedShareName"> Required. Identify the name of the deleted share that will be restored. </param>
        /// <param name="deletedShareVersion"> Required. Identify the version of the deleted share that will be restored. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deletedShareName"/> or <paramref name="deletedShareVersion"/> is null. </exception>
        public DeletedShare(string deletedShareName, string deletedShareVersion)
        {
            Argument.AssertNotNull(deletedShareName, nameof(deletedShareName));
            Argument.AssertNotNull(deletedShareVersion, nameof(deletedShareVersion));

            DeletedShareName = deletedShareName;
            DeletedShareVersion = deletedShareVersion;
        }

        /// <summary> Initializes a new instance of <see cref="DeletedShare"/>. </summary>
        /// <param name="deletedShareName"> Required. Identify the name of the deleted share that will be restored. </param>
        /// <param name="deletedShareVersion"> Required. Identify the version of the deleted share that will be restored. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DeletedShare(string deletedShareName, string deletedShareVersion, Dictionary<string, BinaryData> rawData)
        {
            DeletedShareName = deletedShareName;
            DeletedShareVersion = deletedShareVersion;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="DeletedShare"/> for deserialization. </summary>
        internal DeletedShare()
        {
        }

        /// <summary> Required. Identify the name of the deleted share that will be restored. </summary>
        public string DeletedShareName { get; }
        /// <summary> Required. Identify the version of the deleted share that will be restored. </summary>
        public string DeletedShareVersion { get; }
    }
}
