// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The LegalHold property of a blob container. </summary>
    public partial class LegalHold
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="LegalHold"/>. </summary>
        /// <param name="tags"> Each tag should be 3 to 23 alphanumeric characters and is normalized to lower case at SRP. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public LegalHold(IEnumerable<string> tags)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            Tags = tags.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="LegalHold"/>. </summary>
        /// <param name="hasLegalHold"> The hasLegalHold public property is set to true by SRP if there are at least one existing tag. The hasLegalHold public property is set to false by SRP if all existing legal hold tags are cleared out. There can be a maximum of 1000 blob containers with hasLegalHold=true for a given account. </param>
        /// <param name="tags"> Each tag should be 3 to 23 alphanumeric characters and is normalized to lower case at SRP. </param>
        /// <param name="allowProtectedAppendWritesAll"> When enabled, new blocks can be written to both 'Append and Bock Blobs' while maintaining legal hold protection and compliance. Only new blocks can be added and any existing blocks cannot be modified or deleted. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal LegalHold(bool? hasLegalHold, IList<string> tags, bool? allowProtectedAppendWritesAll, Dictionary<string, BinaryData> rawData)
        {
            HasLegalHold = hasLegalHold;
            Tags = tags;
            AllowProtectedAppendWritesAll = allowProtectedAppendWritesAll;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="LegalHold"/> for deserialization. </summary>
        internal LegalHold()
        {
        }

        /// <summary> The hasLegalHold public property is set to true by SRP if there are at least one existing tag. The hasLegalHold public property is set to false by SRP if all existing legal hold tags are cleared out. There can be a maximum of 1000 blob containers with hasLegalHold=true for a given account. </summary>
        public bool? HasLegalHold { get; }
        /// <summary> Each tag should be 3 to 23 alphanumeric characters and is normalized to lower case at SRP. </summary>
        public IList<string> Tags { get; }
        /// <summary> When enabled, new blocks can be written to both 'Append and Bock Blobs' while maintaining legal hold protection and compliance. Only new blocks can be added and any existing blocks cannot be modified or deleted. </summary>
        public bool? AllowProtectedAppendWritesAll { get; set; }
    }
}
