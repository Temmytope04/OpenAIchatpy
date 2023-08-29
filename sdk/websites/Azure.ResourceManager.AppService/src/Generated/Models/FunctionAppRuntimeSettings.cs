// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Function App runtime settings. </summary>
    public partial class FunctionAppRuntimeSettings
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="FunctionAppRuntimeSettings"/>. </summary>
        internal FunctionAppRuntimeSettings()
        {
            AppSettingsDictionary = new ChangeTrackingDictionary<string, string>();
            SupportedFunctionsExtensionVersions = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="FunctionAppRuntimeSettings"/>. </summary>
        /// <param name="runtimeVersion"> Function App stack minor version (runtime only). </param>
        /// <param name="isRemoteDebuggingSupported"> &lt;code&gt;true&lt;/code&gt; if remote debugging is supported for the stack; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="appInsightsSettings"> Application Insights settings associated with the minor version. </param>
        /// <param name="gitHubActionSettings"> GitHub Actions settings associated with the minor version. </param>
        /// <param name="appSettingsDictionary"> Application settings associated with the minor version. </param>
        /// <param name="siteConfigPropertiesDictionary"> Configuration settings associated with the minor version. </param>
        /// <param name="supportedFunctionsExtensionVersions"> List of supported Functions extension versions. </param>
        /// <param name="isPreview"> &lt;code&gt;true&lt;/code&gt; if the stack is in preview; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="isDeprecated"> &lt;code&gt;true&lt;/code&gt; if the stack is deprecated; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="isHidden"> &lt;code&gt;true&lt;/code&gt; if the stack should be hidden; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="endOfLifeOn"> End-of-life date for the minor version. </param>
        /// <param name="isAutoUpdate"> &lt;code&gt;true&lt;/code&gt; if the stack version is auto-updated; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="isEarlyAccess"> &lt;code&gt;true&lt;/code&gt; if the minor version is early-access; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="isDefault"> &lt;code&gt;true&lt;/code&gt; if the minor version the default; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal FunctionAppRuntimeSettings(string runtimeVersion, bool? isRemoteDebuggingSupported, AppInsightsWebAppStackSettings appInsightsSettings, GitHubActionWebAppStackSettings gitHubActionSettings, IReadOnlyDictionary<string, string> appSettingsDictionary, SiteConfigPropertiesDictionary siteConfigPropertiesDictionary, IReadOnlyList<string> supportedFunctionsExtensionVersions, bool? isPreview, bool? isDeprecated, bool? isHidden, DateTimeOffset? endOfLifeOn, bool? isAutoUpdate, bool? isEarlyAccess, bool? isDefault, Dictionary<string, BinaryData> rawData)
        {
            RuntimeVersion = runtimeVersion;
            IsRemoteDebuggingSupported = isRemoteDebuggingSupported;
            AppInsightsSettings = appInsightsSettings;
            GitHubActionSettings = gitHubActionSettings;
            AppSettingsDictionary = appSettingsDictionary;
            SiteConfigPropertiesDictionary = siteConfigPropertiesDictionary;
            SupportedFunctionsExtensionVersions = supportedFunctionsExtensionVersions;
            IsPreview = isPreview;
            IsDeprecated = isDeprecated;
            IsHidden = isHidden;
            EndOfLifeOn = endOfLifeOn;
            IsAutoUpdate = isAutoUpdate;
            IsEarlyAccess = isEarlyAccess;
            IsDefault = isDefault;
            _rawData = rawData;
        }

        /// <summary> Function App stack minor version (runtime only). </summary>
        public string RuntimeVersion { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if remote debugging is supported for the stack; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? IsRemoteDebuggingSupported { get; }
        /// <summary> Application Insights settings associated with the minor version. </summary>
        public AppInsightsWebAppStackSettings AppInsightsSettings { get; }
        /// <summary> GitHub Actions settings associated with the minor version. </summary>
        public GitHubActionWebAppStackSettings GitHubActionSettings { get; }
        /// <summary> Application settings associated with the minor version. </summary>
        public IReadOnlyDictionary<string, string> AppSettingsDictionary { get; }
        /// <summary> Configuration settings associated with the minor version. </summary>
        public SiteConfigPropertiesDictionary SiteConfigPropertiesDictionary { get; }
        /// <summary> List of supported Functions extension versions. </summary>
        public IReadOnlyList<string> SupportedFunctionsExtensionVersions { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if the stack is in preview; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? IsPreview { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if the stack is deprecated; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? IsDeprecated { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if the stack should be hidden; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? IsHidden { get; }
        /// <summary> End-of-life date for the minor version. </summary>
        public DateTimeOffset? EndOfLifeOn { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if the stack version is auto-updated; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? IsAutoUpdate { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if the minor version is early-access; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? IsEarlyAccess { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if the minor version the default; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? IsDefault { get; }
    }
}
