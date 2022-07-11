// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The API resource policies. </summary>
    public partial class ApiResourcePolicies
    {
        /// <summary> Initializes a new instance of ApiResourcePolicies. </summary>
        internal ApiResourcePolicies()
        {
        }

        /// <summary> Initializes a new instance of ApiResourcePolicies. </summary>
        /// <param name="content"> The API level only policies XML as embedded content. </param>
        /// <param name="contentLink"> The content link to the policies. </param>
        internal ApiResourcePolicies(string content, string contentLink)
        {
            Content = content;
            ContentLink = contentLink;
        }

        /// <summary> The API level only policies XML as embedded content. </summary>
        public string Content { get; }
        /// <summary> The content link to the policies. </summary>
        public string ContentLink { get; }
    }
}
