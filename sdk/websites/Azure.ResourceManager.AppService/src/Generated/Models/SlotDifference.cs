// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> A setting difference between two deployment slots of an app. </summary>
    public partial class SlotDifference : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of SlotDifference. </summary>
        public SlotDifference()
        {
        }

        /// <summary> Initializes a new instance of SlotDifference. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="level"> Level of the difference: Information, Warning or Error. </param>
        /// <param name="settingType"> The type of the setting: General, AppSetting or ConnectionString. </param>
        /// <param name="diffRule"> Rule that describes how to process the setting difference during a slot swap. </param>
        /// <param name="settingName"> Name of the setting. </param>
        /// <param name="valueInCurrentSlot"> Value of the setting in the current slot. </param>
        /// <param name="valueInTargetSlot"> Value of the setting in the target slot. </param>
        /// <param name="description"> Description of the setting difference. </param>
        internal SlotDifference(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string kind, string level, string settingType, string diffRule, string settingName, string valueInCurrentSlot, string valueInTargetSlot, string description) : base(id, name, resourceType, systemData, kind)
        {
            Level = level;
            SettingType = settingType;
            DiffRule = diffRule;
            SettingName = settingName;
            ValueInCurrentSlot = valueInCurrentSlot;
            ValueInTargetSlot = valueInTargetSlot;
            Description = description;
        }

        /// <summary> Level of the difference: Information, Warning or Error. </summary>
        public string Level { get; }
        /// <summary> The type of the setting: General, AppSetting or ConnectionString. </summary>
        public string SettingType { get; }
        /// <summary> Rule that describes how to process the setting difference during a slot swap. </summary>
        public string DiffRule { get; }
        /// <summary> Name of the setting. </summary>
        public string SettingName { get; }
        /// <summary> Value of the setting in the current slot. </summary>
        public string ValueInCurrentSlot { get; }
        /// <summary> Value of the setting in the target slot. </summary>
        public string ValueInTargetSlot { get; }
        /// <summary> Description of the setting difference. </summary>
        public string Description { get; }
    }
}
