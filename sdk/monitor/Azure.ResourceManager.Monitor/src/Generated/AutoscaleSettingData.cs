// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Monitor.Models;

namespace Azure.ResourceManager.Monitor
{
    /// <summary> A class representing the AutoscaleSetting data model. </summary>
    public partial class AutoscaleSettingData : TrackedResource
    {
        /// <summary> Initializes a new instance of AutoscaleSettingData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="profiles"> the collection of automatic scaling profiles that specify different scaling parameters for different time periods. A maximum of 20 profiles can be specified. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="profiles"/> is null. </exception>
        public AutoscaleSettingData(AzureLocation location, IEnumerable<AutoscaleProfile> profiles) : base(location)
        {
            if (profiles == null)
            {
                throw new ArgumentNullException(nameof(profiles));
            }

            Profiles = profiles.ToList();
            Notifications = new ChangeTrackingList<AutoscaleNotification>();
        }

        /// <summary> Initializes a new instance of AutoscaleSettingData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="profiles"> the collection of automatic scaling profiles that specify different scaling parameters for different time periods. A maximum of 20 profiles can be specified. </param>
        /// <param name="notifications"> the collection of notifications. </param>
        /// <param name="enabled"> the enabled flag. Specifies whether automatic scaling is enabled for the resource. The default value is &apos;true&apos;. </param>
        /// <param name="namePropertiesName"> the name of the autoscale setting. </param>
        /// <param name="targetResourceUri"> the resource identifier of the resource that the autoscale setting should be added to. </param>
        /// <param name="targetResourceLocation"> the location of the resource that the autoscale setting should be added to. </param>
        internal AutoscaleSettingData(ResourceIdentifier id, string name, ResourceType type, IDictionary<string, string> tags, AzureLocation location, IList<AutoscaleProfile> profiles, IList<AutoscaleNotification> notifications, bool? enabled, string namePropertiesName, string targetResourceUri, string targetResourceLocation) : base(id, name, type, tags, location)
        {
            Profiles = profiles;
            Notifications = notifications;
            Enabled = enabled;
            NamePropertiesName = namePropertiesName;
            TargetResourceUri = targetResourceUri;
            TargetResourceLocation = targetResourceLocation;
        }

        /// <summary> the collection of automatic scaling profiles that specify different scaling parameters for different time periods. A maximum of 20 profiles can be specified. </summary>
        public IList<AutoscaleProfile> Profiles { get; }
        /// <summary> the collection of notifications. </summary>
        public IList<AutoscaleNotification> Notifications { get; set; }
        /// <summary> the enabled flag. Specifies whether automatic scaling is enabled for the resource. The default value is &apos;true&apos;. </summary>
        public bool? Enabled { get; set; }
        /// <summary> the name of the autoscale setting. </summary>
        public string NamePropertiesName { get; set; }
        /// <summary> the resource identifier of the resource that the autoscale setting should be added to. </summary>
        public string TargetResourceUri { get; set; }
        /// <summary> the location of the resource that the autoscale setting should be added to. </summary>
        public string TargetResourceLocation { get; set; }
    }
}
