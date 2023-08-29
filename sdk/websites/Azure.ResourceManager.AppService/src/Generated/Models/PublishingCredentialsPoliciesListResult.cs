// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Publishing Credentials Policies entity collection ARM resource. </summary>
    internal partial class PublishingCredentialsPoliciesListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PublishingCredentialsPoliciesListResult"/>. </summary>
        /// <param name="value"> Collection of resources. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal PublishingCredentialsPoliciesListResult(IEnumerable<CsmPublishingCredentialsPoliciesEntityData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="PublishingCredentialsPoliciesListResult"/>. </summary>
        /// <param name="value"> Collection of resources. </param>
        /// <param name="nextLink"> Link to next page of resources. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PublishingCredentialsPoliciesListResult(IReadOnlyList<CsmPublishingCredentialsPoliciesEntityData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="PublishingCredentialsPoliciesListResult"/> for deserialization. </summary>
        internal PublishingCredentialsPoliciesListResult()
        {
        }

        /// <summary> Collection of resources. </summary>
        public IReadOnlyList<CsmPublishingCredentialsPoliciesEntityData> Value { get; }
        /// <summary> Link to next page of resources. </summary>
        public string NextLink { get; }
    }
}
