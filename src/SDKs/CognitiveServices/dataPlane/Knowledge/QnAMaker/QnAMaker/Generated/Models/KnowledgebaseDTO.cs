// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Knowledge.QnAMaker.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Response schema for CreateKb operation.
    /// </summary>
    public partial class KnowledgebaseDTO
    {
        /// <summary>
        /// Initializes a new instance of the KnowledgebaseDTO class.
        /// </summary>
        public KnowledgebaseDTO()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KnowledgebaseDTO class.
        /// </summary>
        /// <param name="id">Unique id that identifies a knowledgebase.</param>
        /// <param name="hostName">URL host name at which the knowledgebase is
        /// hosted.</param>
        /// <param name="lastAccessedTimestamp">Time stamp at which the
        /// knowledgebase was last accessed (UTC).</param>
        /// <param name="lastChangedTimestamp">Time stamp at which the
        /// knowledgebase was last modified (UTC).</param>
        /// <param name="lastPublishedTimestamp">Time stamp at which the
        /// knowledgebase was last published (UTC).</param>
        /// <param name="name">Friendly name of the knowledgebase.</param>
        /// <param name="userId">User who created / owns the
        /// knowledgebase.</param>
        /// <param name="urls">URL sources from which Q-A were extracted and
        /// added to the knowledgebase.</param>
        /// <param name="sources">Custom sources from which Q-A were extracted
        /// or explicitly added to the knowledgebase.</param>
        public KnowledgebaseDTO(string id = default(string), string hostName = default(string), string lastAccessedTimestamp = default(string), string lastChangedTimestamp = default(string), string lastPublishedTimestamp = default(string), string name = default(string), string userId = default(string), IList<string> urls = default(IList<string>), IList<string> sources = default(IList<string>))
        {
            Id = id;
            HostName = hostName;
            LastAccessedTimestamp = lastAccessedTimestamp;
            LastChangedTimestamp = lastChangedTimestamp;
            LastPublishedTimestamp = lastPublishedTimestamp;
            Name = name;
            UserId = userId;
            Urls = urls;
            Sources = sources;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique id that identifies a knowledgebase.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets URL host name at which the knowledgebase is hosted.
        /// </summary>
        [JsonProperty(PropertyName = "hostName")]
        public string HostName { get; set; }

        /// <summary>
        /// Gets or sets time stamp at which the knowledgebase was last
        /// accessed (UTC).
        /// </summary>
        [JsonProperty(PropertyName = "lastAccessedTimestamp")]
        public string LastAccessedTimestamp { get; set; }

        /// <summary>
        /// Gets or sets time stamp at which the knowledgebase was last
        /// modified (UTC).
        /// </summary>
        [JsonProperty(PropertyName = "lastChangedTimestamp")]
        public string LastChangedTimestamp { get; set; }

        /// <summary>
        /// Gets or sets time stamp at which the knowledgebase was last
        /// published (UTC).
        /// </summary>
        [JsonProperty(PropertyName = "lastPublishedTimestamp")]
        public string LastPublishedTimestamp { get; set; }

        /// <summary>
        /// Gets or sets friendly name of the knowledgebase.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets user who created / owns the knowledgebase.
        /// </summary>
        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets URL sources from which Q-A were extracted and added to
        /// the knowledgebase.
        /// </summary>
        [JsonProperty(PropertyName = "urls")]
        public IList<string> Urls { get; set; }

        /// <summary>
        /// Gets or sets custom sources from which Q-A were extracted or
        /// explicitly added to the knowledgebase.
        /// </summary>
        [JsonProperty(PropertyName = "sources")]
        public IList<string> Sources { get; set; }

    }
}
