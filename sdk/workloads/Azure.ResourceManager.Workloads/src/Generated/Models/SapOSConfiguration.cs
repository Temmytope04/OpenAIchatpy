// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary>
    /// Defines the OS configuration.
    /// Please note <see cref="SapOSConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="SapLinuxConfiguration"/> and <see cref="SapWindowsConfiguration"/>.
    /// </summary>
    [AbstractTypeDeserializer(typeof(UnknownOSConfiguration))]
    public abstract partial class SapOSConfiguration
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SapOSConfiguration"/>. </summary>
        protected SapOSConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SapOSConfiguration"/>. </summary>
        /// <param name="osType"> The OS Type. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SapOSConfiguration(SapOSType osType, Dictionary<string, BinaryData> rawData)
        {
            OSType = osType;
            _rawData = rawData;
        }

        /// <summary> The OS Type. </summary>
        internal SapOSType OSType { get; set; }
    }
}
