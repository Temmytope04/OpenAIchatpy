// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Migrate.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines the move collection properties.
    /// </summary>
    public partial class MoveCollectionProperties
    {
        /// <summary>
        /// Initializes a new instance of the MoveCollectionProperties class.
        /// </summary>
        public MoveCollectionProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MoveCollectionProperties class.
        /// </summary>
        /// <param name="sourceRegion">Gets or sets the source region.</param>
        /// <param name="targetRegion">Gets or sets the target region.</param>
        /// <param name="provisioningState">Possible values include:
        /// 'Succeeded', 'Updating', 'Creating', 'Failed'</param>
        public MoveCollectionProperties(string sourceRegion, string targetRegion, string provisioningState = default(string))
        {
            SourceRegion = sourceRegion;
            TargetRegion = targetRegion;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the source region.
        /// </summary>
        [JsonProperty(PropertyName = "sourceRegion")]
        public string SourceRegion { get; set; }

        /// <summary>
        /// Gets or sets the target region.
        /// </summary>
        [JsonProperty(PropertyName = "targetRegion")]
        public string TargetRegion { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Succeeded', 'Updating',
        /// 'Creating', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; set; }

    }
}
