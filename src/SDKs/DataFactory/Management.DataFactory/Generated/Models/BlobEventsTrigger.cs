// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Trigger that runs every time a Blob event occurs.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class BlobEventsTrigger : MultiplePipelineTrigger
    {
        /// <summary>
        /// Initializes a new instance of the BlobEventsTrigger class.
        /// </summary>
        public BlobEventsTrigger()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BlobEventsTrigger class.
        /// </summary>
        /// <param name="events">The type of events that cause this trigger to
        /// fire.</param>
        /// <param name="scope">The ARM resource ID of the Storage
        /// Account.</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="description">Trigger description.</param>
        /// <param name="runtimeState">Indicates if trigger is running or not.
        /// Updated when Start/Stop APIs are called on the Trigger. Possible
        /// values include: 'Started', 'Stopped', 'Disabled'</param>
        /// <param name="pipelines">Pipelines that need to be started.</param>
        /// <param name="blobPathBeginsWith">The blob path must begin with the
        /// pattern provided for trigger to fire. For example,
        /// '/records/blobs/december/' will only fire the trigger for blobs in
        /// the december folder under the records container. At least one of
        /// these must be provided: blobPathBeginsWith,
        /// blobPathEndsWith.</param>
        /// <param name="blobPathEndsWith">The blob path must end with the
        /// pattern provided for trigger to fire. For example,
        /// 'december/boxes.csv' will only fire the trigger for blobs named
        /// boxes in a december folder. At least one of these must be provided:
        /// blobPathBeginsWith, blobPathEndsWith.</param>
        public BlobEventsTrigger(IList<string> events, string scope, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string description = default(string), string runtimeState = default(string), IList<TriggerPipelineReference> pipelines = default(IList<TriggerPipelineReference>), string blobPathBeginsWith = default(string), string blobPathEndsWith = default(string))
            : base(additionalProperties, description, runtimeState, pipelines)
        {
            BlobPathBeginsWith = blobPathBeginsWith;
            BlobPathEndsWith = blobPathEndsWith;
            Events = events;
            Scope = scope;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the blob path must begin with the pattern provided for
        /// trigger to fire. For example, '/records/blobs/december/' will only
        /// fire the trigger for blobs in the december folder under the records
        /// container. At least one of these must be provided:
        /// blobPathBeginsWith, blobPathEndsWith.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.blobPathBeginsWith")]
        public string BlobPathBeginsWith { get; set; }

        /// <summary>
        /// Gets or sets the blob path must end with the pattern provided for
        /// trigger to fire. For example, 'december/boxes.csv' will only fire
        /// the trigger for blobs named boxes in a december folder. At least
        /// one of these must be provided: blobPathBeginsWith,
        /// blobPathEndsWith.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.blobPathEndsWith")]
        public string BlobPathEndsWith { get; set; }

        /// <summary>
        /// Gets or sets the type of events that cause this trigger to fire.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.events")]
        public IList<string> Events { get; set; }

        /// <summary>
        /// Gets or sets the ARM resource ID of the Storage Account.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.scope")]
        public string Scope { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Events == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Events");
            }
            if (Scope == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Scope");
            }
        }
    }
}
