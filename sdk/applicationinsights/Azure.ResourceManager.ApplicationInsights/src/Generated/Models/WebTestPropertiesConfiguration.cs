// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> An XML configuration specification for a WebTest. </summary>
    internal partial class WebTestPropertiesConfiguration
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="WebTestPropertiesConfiguration"/>. </summary>
        public WebTestPropertiesConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="WebTestPropertiesConfiguration"/>. </summary>
        /// <param name="webTest"> The XML specification of a WebTest to run against an application. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal WebTestPropertiesConfiguration(string webTest, Dictionary<string, BinaryData> rawData)
        {
            WebTest = webTest;
            _rawData = rawData;
        }

        /// <summary> The XML specification of a WebTest to run against an application. </summary>
        public string WebTest { get; set; }
    }
}
