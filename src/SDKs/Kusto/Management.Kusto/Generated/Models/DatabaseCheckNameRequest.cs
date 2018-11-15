// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Kusto.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DatabaseCheckNameRequest
    {
        /// <summary>
        /// Initializes a new instance of the DatabaseCheckNameRequest class.
        /// </summary>
        public DatabaseCheckNameRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DatabaseCheckNameRequest class.
        /// </summary>
        /// <param name="name">Database name.</param>
        public DatabaseCheckNameRequest(string name)
        {
            Name = name;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for DatabaseCheckNameRequest class.
        /// </summary>
        static DatabaseCheckNameRequest()
        {
            Type = "Microsoft.Kusto/clusters/databases";
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets database name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The type of resource, Microsoft.Kusto/clusters/databases.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public static string Type { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
