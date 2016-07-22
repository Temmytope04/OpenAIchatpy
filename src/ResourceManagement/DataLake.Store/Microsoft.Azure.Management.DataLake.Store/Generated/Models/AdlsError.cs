// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Store.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Data Lake Store filesystem error containing a specific WebHDFS
    /// exception.
    /// </summary>
    public partial class AdlsError
    {
        /// <summary>
        /// Initializes a new instance of the AdlsError class.
        /// </summary>
        public AdlsError() { }

        /// <summary>
        /// Initializes a new instance of the AdlsError class.
        /// </summary>
        /// <param name="remoteException">the object representing the actual WebHDFS exception being returned.</param>
        public AdlsError(AdlsRemoteException remoteException = default(AdlsRemoteException))
        {
            RemoteException = remoteException;
        }

        /// <summary>
        /// Gets the object representing the actual WebHDFS exception being
        /// returned.
        /// </summary>
        [JsonProperty(PropertyName = "RemoteException")]
        public AdlsRemoteException RemoteException { get; private set; }

    }
}
