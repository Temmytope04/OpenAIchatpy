// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.PowerBIDedicated;

namespace Azure.ResourceManager.PowerBIDedicated.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmPowerBIDedicatedModelFactory
    {
        /// <summary> Initializes a new instance of DedicatedCapacityData. </summary>
        /// <param name="id"> An identifier that represents the PowerBI Dedicated resource. </param>
        /// <param name="name"> The name of the PowerBI Dedicated resource. </param>
        /// <param name="resourceType"> The type of the PowerBI Dedicated resource. </param>
        /// <param name="location"> Location of the PowerBI Dedicated resource. </param>
        /// <param name="tags"> Key-value pairs of additional resource provisioning properties. </param>
        /// <param name="systemData"> Metadata pertaining to creation and last modification of the resource. </param>
        /// <param name="sku"> The SKU of the PowerBI Dedicated capacity resource. </param>
        /// <param name="administrationMembers"> A collection of Dedicated capacity administrators. </param>
        /// <param name="mode"> Specifies the generation of the Power BI Embedded capacity. If no value is specified, the default value 'Gen2' is used. [Learn More](https://docs.microsoft.com/power-bi/developer/embedded/power-bi-embedded-generation-2). </param>
        /// <param name="tenantId"> Tenant ID for the capacity. Used for creating Pro Plus capacity. </param>
        /// <param name="friendlyName"> Capacity name. </param>
        /// <param name="state"> The current state of PowerBI Dedicated resource. The state is to indicate more states outside of resource provisioning. </param>
        /// <param name="provisioningState"> The current deployment state of PowerBI Dedicated resource. The provisioningState is to indicate states for resource provisioning. </param>
        /// <returns> A new <see cref="PowerBIDedicated.DedicatedCapacityData"/> instance for mocking. </returns>
        public static DedicatedCapacityData DedicatedCapacityData(string id = null, string name = null, string resourceType = null, AzureLocation location = default, IDictionary<string, string> tags = null, SystemData systemData = null, CapacitySku sku = null, IEnumerable<string> administrationMembers = null, Mode? mode = null, Guid? tenantId = null, string friendlyName = null, State? state = null, CapacityProvisioningState? provisioningState = null)
        {
            tags ??= new Dictionary<string, string>();
            administrationMembers ??= new List<string>();

            return new DedicatedCapacityData(id, name, resourceType, location, tags, systemData, sku, administrationMembers != null ? new DedicatedCapacityAdministrators(administrationMembers?.ToList()) : null, mode, tenantId, friendlyName, state, provisioningState);
        }

        /// <summary> Initializes a new instance of PowerBIDedicatedResourceData. </summary>
        /// <param name="id"> An identifier that represents the PowerBI Dedicated resource. </param>
        /// <param name="name"> The name of the PowerBI Dedicated resource. </param>
        /// <param name="resourceType"> The type of the PowerBI Dedicated resource. </param>
        /// <param name="location"> Location of the PowerBI Dedicated resource. </param>
        /// <param name="tags"> Key-value pairs of additional resource provisioning properties. </param>
        /// <param name="systemData"> Metadata pertaining to creation and last modification of the resource. </param>
        /// <returns> A new <see cref="Models.PowerBIDedicatedResourceData"/> instance for mocking. </returns>
        public static PowerBIDedicatedResourceData PowerBIDedicatedResourceData(string id = null, string name = null, string resourceType = null, AzureLocation location = default, IDictionary<string, string> tags = null, SystemData systemData = null)
        {
            tags ??= new Dictionary<string, string>();

            return new PowerBIDedicatedResourceData(id, name, resourceType, location, tags, systemData);
        }

        /// <summary> Initializes a new instance of SkuDetails. </summary>
        /// <param name="resourceType"> The resource type. </param>
        /// <param name="sku"> The SKU in SKU details for existing resources. </param>
        /// <returns> A new <see cref="Models.SkuDetails"/> instance for mocking. </returns>
        public static SkuDetails SkuDetails(string resourceType = null, CapacitySku sku = null)
        {
            return new SkuDetails(resourceType, sku);
        }

        /// <summary> Initializes a new instance of CheckCapacityNameAvailabilityResult. </summary>
        /// <param name="nameAvailable"> Indicator of availability of the capacity name. </param>
        /// <param name="reason"> The reason of unavailability. </param>
        /// <param name="message"> The detailed message of the request unavailability. </param>
        /// <returns> A new <see cref="Models.CheckCapacityNameAvailabilityResult"/> instance for mocking. </returns>
        public static CheckCapacityNameAvailabilityResult CheckCapacityNameAvailabilityResult(bool? nameAvailable = null, string reason = null, string message = null)
        {
            return new CheckCapacityNameAvailabilityResult(nameAvailable, reason, message);
        }

        /// <summary> Initializes a new instance of AutoScaleVCoreData. </summary>
        /// <param name="id"> An identifier that represents the PowerBI Dedicated resource. </param>
        /// <param name="name"> The name of the PowerBI Dedicated resource. </param>
        /// <param name="resourceType"> The type of the PowerBI Dedicated resource. </param>
        /// <param name="location"> Location of the PowerBI Dedicated resource. </param>
        /// <param name="tags"> Key-value pairs of additional resource provisioning properties. </param>
        /// <param name="systemData"> Metadata pertaining to creation and last modification of the resource. </param>
        /// <param name="sku"> The SKU of the auto scale v-core resource. </param>
        /// <param name="capacityLimit"> The maximum capacity of an auto scale v-core resource. </param>
        /// <param name="capacityObjectId"> The object ID of the capacity resource associated with the auto scale v-core resource. </param>
        /// <param name="provisioningState"> The current deployment state of an auto scale v-core resource. The provisioningState is to indicate states for resource provisioning. </param>
        /// <returns> A new <see cref="PowerBIDedicated.AutoScaleVCoreData"/> instance for mocking. </returns>
        public static AutoScaleVCoreData AutoScaleVCoreData(string id = null, string name = null, string resourceType = null, AzureLocation location = default, IDictionary<string, string> tags = null, SystemData systemData = null, AutoScaleVCoreSku sku = null, int? capacityLimit = null, string capacityObjectId = null, VCoreProvisioningState? provisioningState = null)
        {
            tags ??= new Dictionary<string, string>();

            return new AutoScaleVCoreData(id, name, resourceType, location, tags, systemData, sku, capacityLimit, capacityObjectId, provisioningState);
        }
    }
}
