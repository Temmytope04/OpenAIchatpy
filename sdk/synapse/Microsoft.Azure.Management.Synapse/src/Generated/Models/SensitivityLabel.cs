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
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A sensitivity label.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SensitivityLabel : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the SensitivityLabel class.
        /// </summary>
        public SensitivityLabel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SensitivityLabel class.
        /// </summary>
        /// <param name="id">Fully qualified resource Id for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. Ex-
        /// Microsoft.Compute/virtualMachines or
        /// Microsoft.Storage/storageAccounts.</param>
        /// <param name="labelName">The label name.</param>
        /// <param name="labelId">The label ID.</param>
        /// <param name="informationType">The information type.</param>
        /// <param name="informationTypeId">The information type ID.</param>
        /// <param name="isDisabled">Is sensitivity recommendation disabled.
        /// Applicable for recommended sensitivity label only. Specifies
        /// whether the sensitivity recommendation on this column is disabled
        /// (dismissed) or not.</param>
        public SensitivityLabel(string id = default(string), string name = default(string), string type = default(string), string labelName = default(string), string labelId = default(string), string informationType = default(string), string informationTypeId = default(string), bool? isDisabled = default(bool?))
            : base(id, name, type)
        {
            LabelName = labelName;
            LabelId = labelId;
            InformationType = informationType;
            InformationTypeId = informationTypeId;
            IsDisabled = isDisabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the label name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.labelName")]
        public string LabelName { get; set; }

        /// <summary>
        /// Gets or sets the label ID.
        /// </summary>
        [JsonProperty(PropertyName = "properties.labelId")]
        public string LabelId { get; set; }

        /// <summary>
        /// Gets or sets the information type.
        /// </summary>
        [JsonProperty(PropertyName = "properties.informationType")]
        public string InformationType { get; set; }

        /// <summary>
        /// Gets or sets the information type ID.
        /// </summary>
        [JsonProperty(PropertyName = "properties.informationTypeId")]
        public string InformationTypeId { get; set; }

        /// <summary>
        /// Gets is sensitivity recommendation disabled. Applicable for
        /// recommended sensitivity label only. Specifies whether the
        /// sensitivity recommendation on this column is disabled (dismissed)
        /// or not.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isDisabled")]
        public bool? IsDisabled { get; private set; }

    }
}
