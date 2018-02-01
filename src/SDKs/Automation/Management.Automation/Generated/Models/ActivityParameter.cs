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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Definition of the activity parameter.
    /// </summary>
    public partial class ActivityParameter
    {
        /// <summary>
        /// Initializes a new instance of the ActivityParameter class.
        /// </summary>
        public ActivityParameter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ActivityParameter class.
        /// </summary>
        /// <param name="name">Gets or sets the name of the activity
        /// parameter.</param>
        /// <param name="type">Gets or sets the type of the activity
        /// parameter.</param>
        /// <param name="isMandatory">Gets or sets a Boolean value that
        /// indicates true if the parameter is required. If the value is false,
        /// the parameter is optional.</param>
        /// <param name="isDynamic">Gets or sets a Boolean value that indicates
        /// true if the parameter is dynamic.</param>
        /// <param name="position">Gets or sets the position of the activity
        /// parameter.</param>
        /// <param name="valueFromPipeline">Gets or sets a Boolean value that
        /// indicates true if the parameter can take values from the incoming
        /// pipeline objects. This setting is used if the cmdlet must access
        /// the complete input object. false indicates that the parameter
        /// cannot take values from the complete input object.</param>
        /// <param name="valueFromPipelineByPropertyName">Gets or sets a
        /// Boolean value that indicates true if the parameter can be filled
        /// from a property of the incoming pipeline object that has the same
        /// name as this parameter. false indicates that the parameter cannot
        /// be filled from the incoming pipeline object property with the same
        /// name. </param>
        /// <param name="valueFromRemainingArguments">Gets or sets a Boolean
        /// value that indicates true if the cmdlet parameter accepts all the
        /// remaining command-line arguments that are associated with this
        /// parameter in the form of an array. false if the cmdlet parameter
        /// does not accept all the remaining argument values.</param>
        public ActivityParameter(string name = default(string), string type = default(string), bool? isMandatory = default(bool?), bool? isDynamic = default(bool?), bool? position = default(bool?), bool? valueFromPipeline = default(bool?), bool? valueFromPipelineByPropertyName = default(bool?), bool? valueFromRemainingArguments = default(bool?))
        {
            Name = name;
            Type = type;
            IsMandatory = isMandatory;
            IsDynamic = isDynamic;
            Position = position;
            ValueFromPipeline = valueFromPipeline;
            ValueFromPipelineByPropertyName = valueFromPipelineByPropertyName;
            ValueFromRemainingArguments = valueFromRemainingArguments;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the activity parameter.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the type of the activity parameter.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets a Boolean value that indicates true if the parameter
        /// is required. If the value is false, the parameter is optional.
        /// </summary>
        [JsonProperty(PropertyName = "isMandatory")]
        public bool? IsMandatory { get; set; }

        /// <summary>
        /// Gets or sets a Boolean value that indicates true if the parameter
        /// is dynamic.
        /// </summary>
        [JsonProperty(PropertyName = "isDynamic")]
        public bool? IsDynamic { get; set; }

        /// <summary>
        /// Gets or sets the position of the activity parameter.
        /// </summary>
        [JsonProperty(PropertyName = "position")]
        public bool? Position { get; set; }

        /// <summary>
        /// Gets or sets a Boolean value that indicates true if the parameter
        /// can take values from the incoming pipeline objects. This setting is
        /// used if the cmdlet must access the complete input object. false
        /// indicates that the parameter cannot take values from the complete
        /// input object.
        /// </summary>
        [JsonProperty(PropertyName = "valueFromPipeline")]
        public bool? ValueFromPipeline { get; set; }

        /// <summary>
        /// Gets or sets a Boolean value that indicates true if the parameter
        /// can be filled from a property of the incoming pipeline object that
        /// has the same name as this parameter. false indicates that the
        /// parameter cannot be filled from the incoming pipeline object
        /// property with the same name.
        /// </summary>
        [JsonProperty(PropertyName = "valueFromPipelineByPropertyName")]
        public bool? ValueFromPipelineByPropertyName { get; set; }

        /// <summary>
        /// Gets or sets a Boolean value that indicates true if the cmdlet
        /// parameter accepts all the remaining command-line arguments that are
        /// associated with this parameter in the form of an array. false if
        /// the cmdlet parameter does not accept all the remaining argument
        /// values.
        /// </summary>
        [JsonProperty(PropertyName = "valueFromRemainingArguments")]
        public bool? ValueFromRemainingArguments { get; set; }

    }
}
