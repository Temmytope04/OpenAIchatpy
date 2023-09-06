// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> SparkConfiguration Artifact information. </summary>
    public partial class SparkConfiguration
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SparkConfiguration"/>. </summary>
        /// <param name="configs"> SparkConfiguration configs. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="configs"/> is null. </exception>
        public SparkConfiguration(IDictionary<string, string> configs)
        {
            Argument.AssertNotNull(configs, nameof(configs));

            Configs = configs;
            Annotations = new ChangeTrackingList<string>();
            ConfigMergeRule = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="SparkConfiguration"/>. </summary>
        /// <param name="description"> Description about the SparkConfiguration. </param>
        /// <param name="configs"> SparkConfiguration configs. </param>
        /// <param name="annotations"> Annotations for SparkConfiguration. </param>
        /// <param name="notes"> additional Notes. </param>
        /// <param name="createdBy"> The identity that created the resource. </param>
        /// <param name="created"> The timestamp of resource creation. </param>
        /// <param name="configMergeRule"> SparkConfiguration configMergeRule. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SparkConfiguration(string description, IDictionary<string, string> configs, IList<string> annotations, string notes, string createdBy, DateTimeOffset? created, IDictionary<string, string> configMergeRule, Dictionary<string, BinaryData> rawData)
        {
            Description = description;
            Configs = configs;
            Annotations = annotations;
            Notes = notes;
            CreatedBy = createdBy;
            Created = created;
            ConfigMergeRule = configMergeRule;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="SparkConfiguration"/> for deserialization. </summary>
        internal SparkConfiguration()
        {
        }

        /// <summary> Description about the SparkConfiguration. </summary>
        public string Description { get; set; }
        /// <summary> SparkConfiguration configs. </summary>
        public IDictionary<string, string> Configs { get; }
        /// <summary> Annotations for SparkConfiguration. </summary>
        public IList<string> Annotations { get; }
        /// <summary> additional Notes. </summary>
        public string Notes { get; set; }
        /// <summary> The identity that created the resource. </summary>
        public string CreatedBy { get; set; }
        /// <summary> The timestamp of resource creation. </summary>
        public DateTimeOffset? Created { get; set; }
        /// <summary> SparkConfiguration configMergeRule. </summary>
        public IDictionary<string, string> ConfigMergeRule { get; }
    }
}
