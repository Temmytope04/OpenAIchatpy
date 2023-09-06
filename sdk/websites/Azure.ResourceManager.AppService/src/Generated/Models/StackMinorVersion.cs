// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Application stack minor version. </summary>
    public partial class StackMinorVersion
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="StackMinorVersion"/>. </summary>
        public StackMinorVersion()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StackMinorVersion"/>. </summary>
        /// <param name="displayVersion"> Application stack minor version (display only). </param>
        /// <param name="runtimeVersion"> Application stack minor version (runtime only). </param>
        /// <param name="isDefault"> &lt;code&gt;true&lt;/code&gt; if this is the default minor version; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="isRemoteDebuggingEnabled"> &lt;code&gt;true&lt;/code&gt; if this supports Remote Debugging, otherwise &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal StackMinorVersion(string displayVersion, string runtimeVersion, bool? isDefault, bool? isRemoteDebuggingEnabled, Dictionary<string, BinaryData> rawData)
        {
            DisplayVersion = displayVersion;
            RuntimeVersion = runtimeVersion;
            IsDefault = isDefault;
            IsRemoteDebuggingEnabled = isRemoteDebuggingEnabled;
            _rawData = rawData;
        }

        /// <summary> Application stack minor version (display only). </summary>
        public string DisplayVersion { get; set; }
        /// <summary> Application stack minor version (runtime only). </summary>
        public string RuntimeVersion { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if this is the default minor version; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? IsDefault { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if this supports Remote Debugging, otherwise &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? IsRemoteDebuggingEnabled { get; set; }
    }
}
