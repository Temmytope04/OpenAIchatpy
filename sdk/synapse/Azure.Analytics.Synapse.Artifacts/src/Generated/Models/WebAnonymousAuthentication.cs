// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A WebLinkedService that uses anonymous authentication to communicate with an HTTP endpoint. </summary>
    public partial class WebAnonymousAuthentication : WebLinkedServiceTypeProperties
    {
        /// <summary> Initializes a new instance of <see cref="WebAnonymousAuthentication"/>. </summary>
        /// <param name="url"> The URL of the web service endpoint, e.g. http://www.microsoft.com . Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="url"/> is null. </exception>
        public WebAnonymousAuthentication(object url) : base(url)
        {
            Argument.AssertNotNull(url, nameof(url));

            AuthenticationType = WebAuthenticationType.Anonymous;
        }

        /// <summary> Initializes a new instance of <see cref="WebAnonymousAuthentication"/>. </summary>
        /// <param name="url"> The URL of the web service endpoint, e.g. http://www.microsoft.com . Type: string (or Expression with resultType string). </param>
        /// <param name="authenticationType"> Type of authentication used to connect to the web table source. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal WebAnonymousAuthentication(object url, WebAuthenticationType authenticationType, Dictionary<string, BinaryData> rawData) : base(url, authenticationType, rawData)
        {
            AuthenticationType = authenticationType;
        }

        /// <summary> Initializes a new instance of <see cref="WebAnonymousAuthentication"/> for deserialization. </summary>
        internal WebAnonymousAuthentication()
        {
        }
    }
}
