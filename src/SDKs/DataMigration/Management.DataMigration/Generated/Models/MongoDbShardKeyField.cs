// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes a field reference within a MongoDB shard key
    /// </summary>
    public partial class MongoDbShardKeyField
    {
        /// <summary>
        /// Initializes a new instance of the MongoDbShardKeyField class.
        /// </summary>
        public MongoDbShardKeyField()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MongoDbShardKeyField class.
        /// </summary>
        /// <param name="name">The name of the field</param>
        /// <param name="order">The field ordering. Possible values include:
        /// 'Forward', 'Reverse', 'Hashed'</param>
        public MongoDbShardKeyField(string name, string order)
        {
            Name = name;
            Order = order;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the field
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the field ordering. Possible values include:
        /// 'Forward', 'Reverse', 'Hashed'
        /// </summary>
        [JsonProperty(PropertyName = "order")]
        public string Order { get; set; }

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
            if (Order == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Order");
            }
        }
    }
}
