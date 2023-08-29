// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Storage;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The ListTableServices. </summary>
    internal partial class ListTableServices
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ListTableServices"/>. </summary>
        internal ListTableServices()
        {
            Value = new ChangeTrackingList<TableServiceData>();
        }

        /// <summary> Initializes a new instance of <see cref="ListTableServices"/>. </summary>
        /// <param name="value"> List of table services returned. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ListTableServices(IReadOnlyList<TableServiceData> value, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            _rawData = rawData;
        }

        /// <summary> List of table services returned. </summary>
        public IReadOnlyList<TableServiceData> Value { get; }
    }
}
