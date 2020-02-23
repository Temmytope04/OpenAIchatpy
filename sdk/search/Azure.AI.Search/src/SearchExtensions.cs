﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Diagnostics;

namespace Azure.AI.Search
{
    /// <summary>
    /// Search extension methods.
    /// </summary>
    internal static partial class SearchExtensions
    {
        /// <summary>
        /// Assert that the given URI uses HTTPS as its scheme.
        /// </summary>
        /// <param name="endpoint">The URI to validate.</param>
        /// <param name="paramName">
        /// The name of the parameter for this URI, to use with an
        /// <see cref="ArgumentException"/>.
        /// </param>
        /// <exception cref="ArgumentException">
        /// Thrown when the <paramref name="endpoint"/> is not using HTTPS as
        /// its scheme.
        /// </exception>
        public static void AssertHttpsScheme(this Uri endpoint, string paramName)
        {
            Debug.Assert(endpoint != null);
            if (!string.Equals(endpoint.Scheme, Uri.UriSchemeHttps, StringComparison.OrdinalIgnoreCase))
            {
                throw new ArgumentException($"{paramName} only supports https.", paramName);
            }
        }

        /// <summary>
        /// Get the name of the Search Service from its
        /// <paramref name="endpoint"/>.
        /// </summary>
        /// <param name="endpoint">The endpoint of the Search Service.</param>
        /// <returns>The name of the Search Service.</returns>
        public static string GetSearchServiceName(this Uri endpoint)
        {
            Debug.Assert(endpoint != null);
            string host = endpoint.Host;
            int separator = host.IndexOf('.');
            return (separator > 0) ?
                host.Substring(0, separator) :
                null;
        }
    }
}
