// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ManagedServices.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The registration definition associated with the registration
    /// assignment.
    /// </summary>
    public partial class RegistrationAssignmentPropertiesRegistrationDefinition
    {
        /// <summary>
        /// Initializes a new instance of the
        /// RegistrationAssignmentPropertiesRegistrationDefinition class.
        /// </summary>
        public RegistrationAssignmentPropertiesRegistrationDefinition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// RegistrationAssignmentPropertiesRegistrationDefinition class.
        /// </summary>
        /// <param name="properties">The properties of the registration
        /// definition associated with the registration assignment.</param>
        /// <param name="plan">The details for the Managed Services offer’s
        /// plan in Azure Marketplace.</param>
        /// <param name="id">The fully qualified path of the registration
        /// definition.</param>
        /// <param name="type">The type of the Azure resource
        /// (Microsoft.ManagedServices/registrationDefinitions).</param>
        /// <param name="name">The name of the registration definition.</param>
        public RegistrationAssignmentPropertiesRegistrationDefinition(RegistrationAssignmentPropertiesRegistrationDefinitionProperties properties = default(RegistrationAssignmentPropertiesRegistrationDefinitionProperties), Plan plan = default(Plan), string id = default(string), string type = default(string), string name = default(string))
        {
            Properties = properties;
            Plan = plan;
            Id = id;
            Type = type;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the properties of the registration definition
        /// associated with the registration assignment.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public RegistrationAssignmentPropertiesRegistrationDefinitionProperties Properties { get; set; }

        /// <summary>
        /// Gets or sets the details for the Managed Services offer’s plan in
        /// Azure Marketplace.
        /// </summary>
        [JsonProperty(PropertyName = "plan")]
        public Plan Plan { get; set; }

        /// <summary>
        /// Gets the fully qualified path of the registration definition.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the type of the Azure resource
        /// (Microsoft.ManagedServices/registrationDefinitions).
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets the name of the registration definition.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Plan != null)
            {
                Plan.Validate();
            }
        }
    }
}
