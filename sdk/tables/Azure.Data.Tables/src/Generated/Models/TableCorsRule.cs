// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Data.Tables.Models
{
    /// <summary> CORS is an HTTP feature that enables a web application running under one domain to access resources in another domain. Web browsers implement a security restriction known as same-origin policy that prevents a web page from calling APIs in a different domain; CORS provides a secure way to allow one domain (the origin domain) to call APIs in another domain. </summary>
    public partial class TableCorsRule
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="TableCorsRule"/>. </summary>
        /// <param name="allowedOrigins"> The origin domains that are permitted to make a request against the service via CORS. The origin domain is the domain from which the request originates. Note that the origin must be an exact case-sensitive match with the origin that the user age sends to the service. You can also use the wildcard character '*' to allow all origin domains to make requests via CORS. </param>
        /// <param name="allowedMethods"> The methods (HTTP request verbs) that the origin domain may use for a CORS request. (comma separated). </param>
        /// <param name="allowedHeaders"> The request headers that the origin domain may specify on the CORS request. </param>
        /// <param name="exposedHeaders"> The response headers that may be sent in the response to the CORS request and exposed by the browser to the request issuer. </param>
        /// <param name="maxAgeInSeconds"> The maximum amount time that a browser should cache the preflight OPTIONS request. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="allowedOrigins"/>, <paramref name="allowedMethods"/>, <paramref name="allowedHeaders"/> or <paramref name="exposedHeaders"/> is null. </exception>
        public TableCorsRule(string allowedOrigins, string allowedMethods, string allowedHeaders, string exposedHeaders, int maxAgeInSeconds)
        {
            Argument.AssertNotNull(allowedOrigins, nameof(allowedOrigins));
            Argument.AssertNotNull(allowedMethods, nameof(allowedMethods));
            Argument.AssertNotNull(allowedHeaders, nameof(allowedHeaders));
            Argument.AssertNotNull(exposedHeaders, nameof(exposedHeaders));

            AllowedOrigins = allowedOrigins;
            AllowedMethods = allowedMethods;
            AllowedHeaders = allowedHeaders;
            ExposedHeaders = exposedHeaders;
            MaxAgeInSeconds = maxAgeInSeconds;
        }

        /// <summary> Initializes a new instance of <see cref="TableCorsRule"/>. </summary>
        /// <param name="allowedOrigins"> The origin domains that are permitted to make a request against the service via CORS. The origin domain is the domain from which the request originates. Note that the origin must be an exact case-sensitive match with the origin that the user age sends to the service. You can also use the wildcard character '*' to allow all origin domains to make requests via CORS. </param>
        /// <param name="allowedMethods"> The methods (HTTP request verbs) that the origin domain may use for a CORS request. (comma separated). </param>
        /// <param name="allowedHeaders"> The request headers that the origin domain may specify on the CORS request. </param>
        /// <param name="exposedHeaders"> The response headers that may be sent in the response to the CORS request and exposed by the browser to the request issuer. </param>
        /// <param name="maxAgeInSeconds"> The maximum amount time that a browser should cache the preflight OPTIONS request. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal TableCorsRule(string allowedOrigins, string allowedMethods, string allowedHeaders, string exposedHeaders, int maxAgeInSeconds, Dictionary<string, BinaryData> rawData)
        {
            AllowedOrigins = allowedOrigins;
            AllowedMethods = allowedMethods;
            AllowedHeaders = allowedHeaders;
            ExposedHeaders = exposedHeaders;
            MaxAgeInSeconds = maxAgeInSeconds;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="TableCorsRule"/> for deserialization. </summary>
        internal TableCorsRule()
        {
        }

        /// <summary> The origin domains that are permitted to make a request against the service via CORS. The origin domain is the domain from which the request originates. Note that the origin must be an exact case-sensitive match with the origin that the user age sends to the service. You can also use the wildcard character '*' to allow all origin domains to make requests via CORS. </summary>
        public string AllowedOrigins { get; set; }
        /// <summary> The methods (HTTP request verbs) that the origin domain may use for a CORS request. (comma separated). </summary>
        public string AllowedMethods { get; set; }
        /// <summary> The request headers that the origin domain may specify on the CORS request. </summary>
        public string AllowedHeaders { get; set; }
        /// <summary> The response headers that may be sent in the response to the CORS request and exposed by the browser to the request issuer. </summary>
        public string ExposedHeaders { get; set; }
        /// <summary> The maximum amount time that a browser should cache the preflight OPTIONS request. </summary>
        public int MaxAgeInSeconds { get; set; }
    }
}
