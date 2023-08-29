// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary>
    /// Base type for data deletion detection policies.
    /// Please note <see cref="DataDeletionDetectionPolicy"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="SoftDeleteColumnDeletionDetectionPolicy"/>.
    /// </summary>
    public partial class DataDeletionDetectionPolicy
    {
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataDeletionDetectionPolicy"/>. </summary>
        /// <param name="oDataType"> Identifies the concrete type of the data deletion detection policy. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataDeletionDetectionPolicy(string oDataType, Dictionary<string, BinaryData> rawData)
        {
            ODataType = oDataType;
            _rawData = rawData;
        }

        /// <summary> Identifies the concrete type of the data deletion detection policy. </summary>
        internal string ODataType { get; set; }
    }
}
