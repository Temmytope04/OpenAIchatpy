// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Definition of the webhook type.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Webhook : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the Webhook class.
        /// </summary>
        public Webhook()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Webhook class.
        /// </summary>
        /// <param name="id">Fully qualified resource Id for the
        /// resource</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource.</param>
        /// <param name="isEnabled">Gets or sets the value of the enabled flag
        /// of the webhook.</param>
        /// <param name="uri">Gets or sets the webhook uri.</param>
        /// <param name="expiryTime">Gets or sets the expiry time.</param>
        /// <param name="lastInvokedTime">Gets or sets the last invoked
        /// time.</param>
        /// <param name="parameters">Gets or sets the parameters of the job
        /// that is created when the webhook calls the runbook it is associated
        /// with.</param>
        /// <param name="runbook">Gets or sets the runbook the webhook is
        /// associated with.</param>
        /// <param name="runOn">Gets or sets the name of the hybrid worker
        /// group the webhook job will run on.</param>
        /// <param name="creationTime">Gets or sets the creation time.</param>
        /// <param name="lastModifiedTime">Gets or sets the last modified
        /// time.</param>
        /// <param name="description">Gets or sets the description.</param>
        public Webhook(string id = default(string), string name = default(string), string type = default(string), bool? isEnabled = default(bool?), string uri = default(string), System.DateTimeOffset expiryTime = default(System.DateTimeOffset), System.DateTimeOffset lastInvokedTime = default(System.DateTimeOffset), IDictionary<string, string> parameters = default(IDictionary<string, string>), RunbookAssociationProperty runbook = default(RunbookAssociationProperty), string runOn = default(string), System.DateTimeOffset creationTime = default(System.DateTimeOffset), System.DateTimeOffset lastModifiedTime = default(System.DateTimeOffset), string description = default(string))
            : base(id, name, type)
        {
            IsEnabled = isEnabled;
            Uri = uri;
            ExpiryTime = expiryTime;
            LastInvokedTime = lastInvokedTime;
            Parameters = parameters;
            Runbook = runbook;
            RunOn = runOn;
            CreationTime = creationTime;
            LastModifiedTime = lastModifiedTime;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the value of the enabled flag of the webhook.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isEnabled")]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// Gets or sets the webhook uri.
        /// </summary>
        [JsonProperty(PropertyName = "properties.uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or sets the expiry time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.expiryTime")]
        public System.DateTimeOffset ExpiryTime { get; set; }

        /// <summary>
        /// Gets or sets the last invoked time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastInvokedTime")]
        public System.DateTimeOffset LastInvokedTime { get; set; }

        /// <summary>
        /// Gets or sets the parameters of the job that is created when the
        /// webhook calls the runbook it is associated with.
        /// </summary>
        [JsonProperty(PropertyName = "properties.parameters")]
        public IDictionary<string, string> Parameters { get; set; }

        /// <summary>
        /// Gets or sets the runbook the webhook is associated with.
        /// </summary>
        [JsonProperty(PropertyName = "properties.runbook")]
        public RunbookAssociationProperty Runbook { get; set; }

        /// <summary>
        /// Gets or sets the name of the hybrid worker group the webhook job
        /// will run on.
        /// </summary>
        [JsonProperty(PropertyName = "properties.runOn")]
        public string RunOn { get; set; }

        /// <summary>
        /// Gets or sets the creation time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.creationTime")]
        public System.DateTimeOffset CreationTime { get; set; }

        /// <summary>
        /// Gets or sets the last modified time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModifiedTime")]
        public System.DateTimeOffset LastModifiedTime { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

    }
}
