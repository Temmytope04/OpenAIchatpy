// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Profiles.hybrid_2020_09_01.WebSites.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Details about restoring a deleted app.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DeletedAppRestoreRequest : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the DeletedAppRestoreRequest class.
        /// </summary>
        public DeletedAppRestoreRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeletedAppRestoreRequest class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="deletedSiteId">ARM resource ID of the deleted app.
        /// Example:
        /// /subscriptions/{subId}/providers/Microsoft.Web/deletedSites/{deletedSiteId}</param>
        /// <param name="recoverConfiguration">If true, deleted site
        /// configuration, in addition to content, will be restored.</param>
        /// <param name="snapshotTime">Point in time to restore the deleted app
        /// from, formatted as a DateTime string.
        /// If unspecified, default value is the time that the app was
        /// deleted.</param>
        /// <param name="useDRSecondary">If true, the snapshot is retrieved
        /// from DRSecondary endpoint.</param>
        public DeletedAppRestoreRequest(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), string deletedSiteId = default(string), bool? recoverConfiguration = default(bool?), string snapshotTime = default(string), bool? useDRSecondary = default(bool?))
            : base(id, name, kind, type)
        {
            DeletedSiteId = deletedSiteId;
            RecoverConfiguration = recoverConfiguration;
            SnapshotTime = snapshotTime;
            UseDRSecondary = useDRSecondary;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets ARM resource ID of the deleted app. Example:
        /// /subscriptions/{subId}/providers/Microsoft.Web/deletedSites/{deletedSiteId}
        /// </summary>
        [JsonProperty(PropertyName = "properties.deletedSiteId")]
        public string DeletedSiteId { get; set; }

        /// <summary>
        /// Gets or sets if true, deleted site configuration, in addition to
        /// content, will be restored.
        /// </summary>
        [JsonProperty(PropertyName = "properties.recoverConfiguration")]
        public bool? RecoverConfiguration { get; set; }

        /// <summary>
        /// Gets or sets point in time to restore the deleted app from,
        /// formatted as a DateTime string.
        /// If unspecified, default value is the time that the app was deleted.
        /// </summary>
        [JsonProperty(PropertyName = "properties.snapshotTime")]
        public string SnapshotTime { get; set; }

        /// <summary>
        /// Gets or sets if true, the snapshot is retrieved from DRSecondary
        /// endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "properties.useDRSecondary")]
        public bool? UseDRSecondary { get; set; }

    }
}
