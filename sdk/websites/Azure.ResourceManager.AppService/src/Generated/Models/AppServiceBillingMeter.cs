// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> App Service billing entity that contains information about meter which the Azure billing system utilizes to charge users for services. </summary>
    public partial class AppServiceBillingMeter : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AppServiceBillingMeter"/>. </summary>
        public AppServiceBillingMeter()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceBillingMeter"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="meterId"> Meter GUID onboarded in Commerce. </param>
        /// <param name="billingLocation"> Azure Location of billable resource. </param>
        /// <param name="shortName"> Short Name from App Service Azure pricing Page. </param>
        /// <param name="friendlyName"> Friendly name of the meter. </param>
        /// <param name="osType"> App Service OS type meter used for. </param>
        /// <param name="multiplier"> Meter Multiplier. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AppServiceBillingMeter(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, Guid? meterId, AzureLocation? billingLocation, string shortName, string friendlyName, string osType, double? multiplier, string kind, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            MeterId = meterId;
            BillingLocation = billingLocation;
            ShortName = shortName;
            FriendlyName = friendlyName;
            OSType = osType;
            Multiplier = multiplier;
            Kind = kind;
            _rawData = rawData;
        }

        /// <summary> Meter GUID onboarded in Commerce. </summary>
        public Guid? MeterId { get; set; }
        /// <summary> Azure Location of billable resource. </summary>
        public AzureLocation? BillingLocation { get; set; }
        /// <summary> Short Name from App Service Azure pricing Page. </summary>
        public string ShortName { get; set; }
        /// <summary> Friendly name of the meter. </summary>
        public string FriendlyName { get; set; }
        /// <summary> App Service OS type meter used for. </summary>
        public string OSType { get; set; }
        /// <summary> Meter Multiplier. </summary>
        public double? Multiplier { get; set; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
