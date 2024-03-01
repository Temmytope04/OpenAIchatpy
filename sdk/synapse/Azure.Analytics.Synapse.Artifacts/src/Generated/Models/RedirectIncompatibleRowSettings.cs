// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Redirect incompatible row settings. </summary>
    public partial class RedirectIncompatibleRowSettings
    {
        /// <summary> Initializes a new instance of <see cref="RedirectIncompatibleRowSettings"/>. </summary>
        /// <param name="linkedServiceName"> Name of the Azure Storage, Storage SAS, or Azure Data Lake Store linked service used for redirecting incompatible row. Must be specified if redirectIncompatibleRowSettings is specified. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> is null. </exception>
        public RedirectIncompatibleRowSettings(object linkedServiceName)
        {
            if (linkedServiceName == null)
            {
                throw new ArgumentNullException(nameof(linkedServiceName));
            }

            LinkedServiceName = linkedServiceName;
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of <see cref="RedirectIncompatibleRowSettings"/>. </summary>
        /// <param name="linkedServiceName"> Name of the Azure Storage, Storage SAS, or Azure Data Lake Store linked service used for redirecting incompatible row. Must be specified if redirectIncompatibleRowSettings is specified. Type: string (or Expression with resultType string). </param>
        /// <param name="path"> The path for storing the redirect incompatible row data. Type: string (or Expression with resultType string). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal RedirectIncompatibleRowSettings(object linkedServiceName, object path, IDictionary<string, object> additionalProperties)
        {
            LinkedServiceName = linkedServiceName;
            Path = path;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Name of the Azure Storage, Storage SAS, or Azure Data Lake Store linked service used for redirecting incompatible row. Must be specified if redirectIncompatibleRowSettings is specified. Type: string (or Expression with resultType string). </summary>
        public object LinkedServiceName { get; set; }
        /// <summary> The path for storing the redirect incompatible row data. Type: string (or Expression with resultType string). </summary>
        public object Path { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, object> AdditionalProperties { get; }
    }
}
