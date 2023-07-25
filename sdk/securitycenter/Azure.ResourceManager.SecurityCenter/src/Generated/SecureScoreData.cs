// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing the SecureScore data model.
    /// Secure score item data model
    /// </summary>
    public partial class SecureScoreData : ResourceData
    {
        /// <summary> Initializes a new instance of SecureScoreData. </summary>
        public SecureScoreData()
        {
        }

        /// <summary> Initializes a new instance of SecureScoreData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="displayName"> The initiative’s name. </param>
        /// <param name="weight"> The relative weight for each subscription. Used when calculating an aggregated secure score for multiple subscriptions. </param>
        /// <param name="max"> Maximum score available. </param>
        /// <param name="current"> Current score. </param>
        /// <param name="percentage"> Ratio of the current score divided by the maximum. Rounded to 4 digits after the decimal point. </param>
        internal SecureScoreData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string displayName, long? weight, int? max, double? current, double? percentage) : base(id, name, resourceType, systemData)
        {
            DisplayName = displayName;
            Weight = weight;
            Max = max;
            Current = current;
            Percentage = percentage;
        }

        /// <summary> The initiative’s name. </summary>
        public string DisplayName { get; }
        /// <summary> The relative weight for each subscription. Used when calculating an aggregated secure score for multiple subscriptions. </summary>
        public long? Weight { get; }
        /// <summary> Maximum score available. </summary>
        public int? Max { get; }
        /// <summary> Current score. </summary>
        public double? Current { get; }
        /// <summary> Ratio of the current score divided by the maximum. Rounded to 4 digits after the decimal point. </summary>
        public double? Percentage { get; }
    }
}
