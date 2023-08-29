// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Spark configuration reference. </summary>
    public partial class SparkConfigurationParametrizationReference
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SparkConfigurationParametrizationReference"/>. </summary>
        /// <param name="type"> Spark configuration reference type. </param>
        /// <param name="referenceName"> Reference spark configuration name. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="referenceName"/> is null. </exception>
        public SparkConfigurationParametrizationReference(SparkConfigurationReferenceType type, object referenceName)
        {
            Argument.AssertNotNull(referenceName, nameof(referenceName));

            Type = type;
            ReferenceName = referenceName;
        }

        /// <summary> Initializes a new instance of <see cref="SparkConfigurationParametrizationReference"/>. </summary>
        /// <param name="type"> Spark configuration reference type. </param>
        /// <param name="referenceName"> Reference spark configuration name. Type: string (or Expression with resultType string). </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SparkConfigurationParametrizationReference(SparkConfigurationReferenceType type, object referenceName, Dictionary<string, BinaryData> rawData)
        {
            Type = type;
            ReferenceName = referenceName;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="SparkConfigurationParametrizationReference"/> for deserialization. </summary>
        internal SparkConfigurationParametrizationReference()
        {
        }

        /// <summary> Spark configuration reference type. </summary>
        public SparkConfigurationReferenceType Type { get; set; }
        /// <summary> Reference spark configuration name. Type: string (or Expression with resultType string). </summary>
        public object ReferenceName { get; set; }
    }
}
