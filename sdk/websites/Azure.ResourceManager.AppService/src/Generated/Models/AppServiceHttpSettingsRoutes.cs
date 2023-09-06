// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The configuration settings of the paths HTTP requests. </summary>
    internal partial class AppServiceHttpSettingsRoutes
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AppServiceHttpSettingsRoutes"/>. </summary>
        public AppServiceHttpSettingsRoutes()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceHttpSettingsRoutes"/>. </summary>
        /// <param name="apiPrefix"> The prefix that should precede all the authentication/authorization paths. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AppServiceHttpSettingsRoutes(string apiPrefix, Dictionary<string, BinaryData> rawData)
        {
            ApiPrefix = apiPrefix;
            _rawData = rawData;
        }

        /// <summary> The prefix that should precede all the authentication/authorization paths. </summary>
        public string ApiPrefix { get; set; }
    }
}
