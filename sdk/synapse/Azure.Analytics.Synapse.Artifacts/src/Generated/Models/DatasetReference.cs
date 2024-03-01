// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Dataset reference type. </summary>
    public partial class DatasetReference
    {
        /// <summary> Initializes a new instance of <see cref="DatasetReference"/>. </summary>
        /// <param name="type"> Dataset reference type. </param>
        /// <param name="referenceName"> Reference dataset name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="referenceName"/> is null. </exception>
        public DatasetReference(DatasetReferenceType type, string referenceName)
        {
            if (referenceName == null)
            {
                throw new ArgumentNullException(nameof(referenceName));
            }

            Type = type;
            ReferenceName = referenceName;
            Parameters = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of <see cref="DatasetReference"/>. </summary>
        /// <param name="type"> Dataset reference type. </param>
        /// <param name="referenceName"> Reference dataset name. </param>
        /// <param name="parameters"> Arguments for dataset. </param>
        internal DatasetReference(DatasetReferenceType type, string referenceName, IDictionary<string, object> parameters)
        {
            Type = type;
            ReferenceName = referenceName;
            Parameters = parameters;
        }

        /// <summary> Dataset reference type. </summary>
        public DatasetReferenceType Type { get; set; }
        /// <summary> Reference dataset name. </summary>
        public string ReferenceName { get; set; }
        /// <summary> Arguments for dataset. </summary>
        public IDictionary<string, object> Parameters { get; }
    }
}
