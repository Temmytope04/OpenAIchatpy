// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.WebSites;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A setting difference between two deployment slots of an app.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SlotDifference : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the SlotDifference class.
        /// </summary>
        public SlotDifference()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SlotDifference class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="slotDifferenceType">Type of the difference:
        /// Information, Warning or Error.</param>
        /// <param name="settingType">The type of the setting: General,
        /// AppSetting or ConnectionString.</param>
        /// <param name="diffRule">Rule that describes how to process the
        /// setting difference during a slot swap.</param>
        /// <param name="settingName">Name of the setting.</param>
        /// <param name="valueInCurrentSlot">Value of the setting in the
        /// current slot.</param>
        /// <param name="valueInTargetSlot">Value of the setting in the target
        /// slot.</param>
        /// <param name="description">Description of the setting
        /// difference.</param>
        public SlotDifference(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), string slotDifferenceType = default(string), string settingType = default(string), string diffRule = default(string), string settingName = default(string), string valueInCurrentSlot = default(string), string valueInTargetSlot = default(string), string description = default(string))
            : base(id, name, kind, type)
        {
            SlotDifferenceType = slotDifferenceType;
            SettingType = settingType;
            DiffRule = diffRule;
            SettingName = settingName;
            ValueInCurrentSlot = valueInCurrentSlot;
            ValueInTargetSlot = valueInTargetSlot;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets type of the difference: Information, Warning or Error.
        /// </summary>
        [JsonProperty(PropertyName = "properties.type")]
        public string SlotDifferenceType { get; private set; }

        /// <summary>
        /// Gets the type of the setting: General, AppSetting or
        /// ConnectionString.
        /// </summary>
        [JsonProperty(PropertyName = "properties.settingType")]
        public string SettingType { get; private set; }

        /// <summary>
        /// Gets rule that describes how to process the setting difference
        /// during a slot swap.
        /// </summary>
        [JsonProperty(PropertyName = "properties.diffRule")]
        public string DiffRule { get; private set; }

        /// <summary>
        /// Gets name of the setting.
        /// </summary>
        [JsonProperty(PropertyName = "properties.settingName")]
        public string SettingName { get; private set; }

        /// <summary>
        /// Gets value of the setting in the current slot.
        /// </summary>
        [JsonProperty(PropertyName = "properties.valueInCurrentSlot")]
        public string ValueInCurrentSlot { get; private set; }

        /// <summary>
        /// Gets value of the setting in the target slot.
        /// </summary>
        [JsonProperty(PropertyName = "properties.valueInTargetSlot")]
        public string ValueInTargetSlot { get; private set; }

        /// <summary>
        /// Gets description of the setting difference.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; private set; }

    }
}
