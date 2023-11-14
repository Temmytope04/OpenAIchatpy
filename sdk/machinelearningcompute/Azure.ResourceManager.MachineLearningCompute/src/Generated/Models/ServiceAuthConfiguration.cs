// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningCompute.Models
{
    /// <summary> Global service auth configuration properties. These are the data-plane authorization keys and are used if a service doesn't define it's own. </summary>
    public partial class ServiceAuthConfiguration
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ServiceAuthConfiguration"/>. </summary>
        /// <param name="primaryAuthKeyHash"> The primary auth key hash. This is not returned in response of GET/PUT on the resource.. To see this please call listKeys API. </param>
        /// <param name="secondaryAuthKeyHash"> The secondary auth key hash. This is not returned in response of GET/PUT on the resource.. To see this please call listKeys API. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="primaryAuthKeyHash"/> or <paramref name="secondaryAuthKeyHash"/> is null. </exception>
        public ServiceAuthConfiguration(string primaryAuthKeyHash, string secondaryAuthKeyHash)
        {
            Argument.AssertNotNull(primaryAuthKeyHash, nameof(primaryAuthKeyHash));
            Argument.AssertNotNull(secondaryAuthKeyHash, nameof(secondaryAuthKeyHash));

            PrimaryAuthKeyHash = primaryAuthKeyHash;
            SecondaryAuthKeyHash = secondaryAuthKeyHash;
        }

        /// <summary> Initializes a new instance of <see cref="ServiceAuthConfiguration"/>. </summary>
        /// <param name="primaryAuthKeyHash"> The primary auth key hash. This is not returned in response of GET/PUT on the resource.. To see this please call listKeys API. </param>
        /// <param name="secondaryAuthKeyHash"> The secondary auth key hash. This is not returned in response of GET/PUT on the resource.. To see this please call listKeys API. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServiceAuthConfiguration(string primaryAuthKeyHash, string secondaryAuthKeyHash, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PrimaryAuthKeyHash = primaryAuthKeyHash;
            SecondaryAuthKeyHash = secondaryAuthKeyHash;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ServiceAuthConfiguration"/> for deserialization. </summary>
        internal ServiceAuthConfiguration()
        {
        }

        /// <summary> The primary auth key hash. This is not returned in response of GET/PUT on the resource.. To see this please call listKeys API. </summary>
        public string PrimaryAuthKeyHash { get; set; }
        /// <summary> The secondary auth key hash. This is not returned in response of GET/PUT on the resource.. To see this please call listKeys API. </summary>
        public string SecondaryAuthKeyHash { get; set; }
    }
}
