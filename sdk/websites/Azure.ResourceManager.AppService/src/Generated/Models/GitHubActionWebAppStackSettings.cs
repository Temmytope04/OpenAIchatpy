// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> GitHub Actions Web App stack settings. </summary>
    public partial class GitHubActionWebAppStackSettings
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="GitHubActionWebAppStackSettings"/>. </summary>
        internal GitHubActionWebAppStackSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="GitHubActionWebAppStackSettings"/>. </summary>
        /// <param name="isSupported"> &lt;code&gt;true&lt;/code&gt; if GitHub Actions is supported for the stack; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="supportedVersion"> The minor version that is supported for GitHub Actions. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal GitHubActionWebAppStackSettings(bool? isSupported, string supportedVersion, Dictionary<string, BinaryData> rawData)
        {
            IsSupported = isSupported;
            SupportedVersion = supportedVersion;
            _rawData = rawData;
        }

        /// <summary> &lt;code&gt;true&lt;/code&gt; if GitHub Actions is supported for the stack; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? IsSupported { get; }
        /// <summary> The minor version that is supported for GitHub Actions. </summary>
        public string SupportedVersion { get; }
    }
}
