// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.KubernetesConfiguration.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The Flux Configuration Patch Request object.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class FluxConfigurationPatch
    {
        /// <summary>
        /// Initializes a new instance of the FluxConfigurationPatch class.
        /// </summary>
        public FluxConfigurationPatch()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FluxConfigurationPatch class.
        /// </summary>
        /// <param name="sourceKind">Source Kind to pull the configuration data
        /// from. Possible values include: 'GitRepository', 'Bucket'</param>
        /// <param name="suspend">Whether this configuration should suspend its
        /// reconciliation of its kustomizations and sources.</param>
        /// <param name="gitRepository">Parameters to reconcile to the
        /// GitRepository source kind type.</param>
        /// <param name="bucket">Parameters to reconcile to the Bucket source
        /// kind type.</param>
        /// <param name="kustomizations">Array of kustomizations used to
        /// reconcile the artifact pulled by the source type on the
        /// cluster.</param>
        /// <param name="configurationProtectedSettings">Key-value pairs of
        /// protected configuration settings for the configuration</param>
        public FluxConfigurationPatch(string sourceKind = default(string), bool? suspend = default(bool?), GitRepositoryPatchDefinition gitRepository = default(GitRepositoryPatchDefinition), BucketPatchDefinition bucket = default(BucketPatchDefinition), IDictionary<string, KustomizationPatchDefinition> kustomizations = default(IDictionary<string, KustomizationPatchDefinition>), IDictionary<string, string> configurationProtectedSettings = default(IDictionary<string, string>))
        {
            SourceKind = sourceKind;
            Suspend = suspend;
            GitRepository = gitRepository;
            Bucket = bucket;
            Kustomizations = kustomizations;
            ConfigurationProtectedSettings = configurationProtectedSettings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets source Kind to pull the configuration data from.
        /// Possible values include: 'GitRepository', 'Bucket'
        /// </summary>
        [JsonProperty(PropertyName = "properties.sourceKind")]
        public string SourceKind { get; set; }

        /// <summary>
        /// Gets or sets whether this configuration should suspend its
        /// reconciliation of its kustomizations and sources.
        /// </summary>
        [JsonProperty(PropertyName = "properties.suspend")]
        public bool? Suspend { get; set; }

        /// <summary>
        /// Gets or sets parameters to reconcile to the GitRepository source
        /// kind type.
        /// </summary>
        [JsonProperty(PropertyName = "properties.gitRepository")]
        public GitRepositoryPatchDefinition GitRepository { get; set; }

        /// <summary>
        /// Gets or sets parameters to reconcile to the Bucket source kind
        /// type.
        /// </summary>
        [JsonProperty(PropertyName = "properties.bucket")]
        public BucketPatchDefinition Bucket { get; set; }

        /// <summary>
        /// Gets or sets array of kustomizations used to reconcile the artifact
        /// pulled by the source type on the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "properties.kustomizations")]
        public IDictionary<string, KustomizationPatchDefinition> Kustomizations { get; set; }

        /// <summary>
        /// Gets or sets key-value pairs of protected configuration settings
        /// for the configuration
        /// </summary>
        [JsonProperty(PropertyName = "properties.configurationProtectedSettings")]
        public IDictionary<string, string> ConfigurationProtectedSettings { get; set; }

    }
}
