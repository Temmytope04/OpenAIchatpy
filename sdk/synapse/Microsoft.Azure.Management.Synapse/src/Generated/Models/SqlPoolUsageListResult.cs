// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The response to a list Sql pool usages request.
    /// </summary>
    public partial class SqlPoolUsageListResult
    {
        /// <summary>
        /// Initializes a new instance of the SqlPoolUsageListResult class.
        /// </summary>
        public SqlPoolUsageListResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SqlPoolUsageListResult class.
        /// </summary>
        /// <param name="value">The list of usages for the Sql pool.</param>
        /// <param name="nextLink">Link to retrieve next page of
        /// results.</param>
        public SqlPoolUsageListResult(IList<SqlPoolUsage> value, string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of usages for the Sql pool.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<SqlPoolUsage> Value { get; set; }

        /// <summary>
        /// Gets link to retrieve next page of results.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Value == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Value");
            }
        }
    }
}
