// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing the SiteSourceControl data model.
    /// Source control configuration for an app.
    /// </summary>
    public partial class SiteSourceControlData : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SiteSourceControlData"/>. </summary>
        public SiteSourceControlData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SiteSourceControlData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="repoUri"> Repository or source control URL. </param>
        /// <param name="branch"> Name of branch to use for deployment. </param>
        /// <param name="isManualIntegration"> &lt;code&gt;true&lt;/code&gt; to limit to manual integration; &lt;code&gt;false&lt;/code&gt; to enable continuous integration (which configures webhooks into online repos like GitHub). </param>
        /// <param name="isGitHubAction"> &lt;code&gt;true&lt;/code&gt; if this is deployed via GitHub action. </param>
        /// <param name="isDeploymentRollbackEnabled"> &lt;code&gt;true&lt;/code&gt; to enable deployment rollback; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="isMercurial"> &lt;code&gt;true&lt;/code&gt; for a Mercurial repository; &lt;code&gt;false&lt;/code&gt; for a Git repository. </param>
        /// <param name="gitHubActionConfiguration"> If GitHub Action is selected, than the associated configuration. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SiteSourceControlData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, Uri repoUri, string branch, bool? isManualIntegration, bool? isGitHubAction, bool? isDeploymentRollbackEnabled, bool? isMercurial, GitHubActionConfiguration gitHubActionConfiguration, string kind, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            RepoUri = repoUri;
            Branch = branch;
            IsManualIntegration = isManualIntegration;
            IsGitHubAction = isGitHubAction;
            IsDeploymentRollbackEnabled = isDeploymentRollbackEnabled;
            IsMercurial = isMercurial;
            GitHubActionConfiguration = gitHubActionConfiguration;
            Kind = kind;
            _rawData = rawData;
        }

        /// <summary> Repository or source control URL. </summary>
        public Uri RepoUri { get; set; }
        /// <summary> Name of branch to use for deployment. </summary>
        public string Branch { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; to limit to manual integration; &lt;code&gt;false&lt;/code&gt; to enable continuous integration (which configures webhooks into online repos like GitHub). </summary>
        public bool? IsManualIntegration { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if this is deployed via GitHub action. </summary>
        public bool? IsGitHubAction { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; to enable deployment rollback; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? IsDeploymentRollbackEnabled { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; for a Mercurial repository; &lt;code&gt;false&lt;/code&gt; for a Git repository. </summary>
        public bool? IsMercurial { get; set; }
        /// <summary> If GitHub Action is selected, than the associated configuration. </summary>
        public GitHubActionConfiguration GitHubActionConfiguration { get; set; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
