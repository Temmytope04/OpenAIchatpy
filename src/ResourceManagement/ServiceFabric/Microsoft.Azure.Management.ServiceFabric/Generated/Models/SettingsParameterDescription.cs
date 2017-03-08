// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ServiceFabric.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// Settings parameter description
    /// </summary>
    public partial class SettingsParameterDescription
    {
        /// <summary>
        /// Initializes a new instance of the SettingsParameterDescription
        /// class.
        /// </summary>
        public SettingsParameterDescription() { }

        /// <summary>
        /// Initializes a new instance of the SettingsParameterDescription
        /// class.
        /// </summary>
        public SettingsParameterDescription(string name = default(string), string value = default(string))
        {
            Name = name;
            Value = value;
        }

        /// <summary>
        /// The name of settings parameter description
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The value of the property
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

    }
}
