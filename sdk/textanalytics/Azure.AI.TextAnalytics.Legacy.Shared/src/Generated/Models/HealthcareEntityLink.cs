// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Legacy
{
    /// <summary> The HealthcareEntityLink. </summary>
    internal partial class HealthcareEntityLink
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="HealthcareEntityLink"/>. </summary>
        /// <param name="dataSource"> Entity Catalog. Examples include: UMLS, CHV, MSH, etc. </param>
        /// <param name="id"> Entity id in the given source catalog. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSource"/> or <paramref name="id"/> is null. </exception>
        internal HealthcareEntityLink(string dataSource, string id)
        {
            Argument.AssertNotNull(dataSource, nameof(dataSource));
            Argument.AssertNotNull(id, nameof(id));

            DataSource = dataSource;
            Id = id;
        }

        /// <summary> Initializes a new instance of <see cref="HealthcareEntityLink"/>. </summary>
        /// <param name="dataSource"> Entity Catalog. Examples include: UMLS, CHV, MSH, etc. </param>
        /// <param name="id"> Entity id in the given source catalog. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal HealthcareEntityLink(string dataSource, string id, Dictionary<string, BinaryData> rawData)
        {
            DataSource = dataSource;
            Id = id;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="HealthcareEntityLink"/> for deserialization. </summary>
        internal HealthcareEntityLink()
        {
        }

        /// <summary> Entity Catalog. Examples include: UMLS, CHV, MSH, etc. </summary>
        public string DataSource { get; }
        /// <summary> Entity id in the given source catalog. </summary>
        public string Id { get; }
    }
}
