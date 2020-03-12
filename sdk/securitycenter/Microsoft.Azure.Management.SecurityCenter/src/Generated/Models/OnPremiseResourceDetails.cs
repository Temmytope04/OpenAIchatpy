// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Details of the On Premise resource that was assessed
    /// </summary>
    [Newtonsoft.Json.JsonObject("OnPremise")]
    public partial class OnPremiseResourceDetails : ResourceDetails
    {
        /// <summary>
        /// Initializes a new instance of the OnPremiseResourceDetails class.
        /// </summary>
        public OnPremiseResourceDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OnPremiseResourceDetails class.
        /// </summary>
        /// <param name="workspaceId">Azure resource Id of the workspace the
        /// machine is attached to</param>
        /// <param name="vmuuid">The unique Id of the machine</param>
        /// <param name="sourceComputerId">The oms agent Id installed on the
        /// machine</param>
        /// <param name="machineName">The name of the machine</param>
        public OnPremiseResourceDetails(string workspaceId, string vmuuid, string sourceComputerId, string machineName)
        {
            WorkspaceId = workspaceId;
            Vmuuid = vmuuid;
            SourceComputerId = sourceComputerId;
            MachineName = machineName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets azure resource Id of the workspace the machine is
        /// attached to
        /// </summary>
        [JsonProperty(PropertyName = "workspaceId")]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// Gets or sets the unique Id of the machine
        /// </summary>
        [JsonProperty(PropertyName = "vmuuid")]
        public string Vmuuid { get; set; }

        /// <summary>
        /// Gets or sets the oms agent Id installed on the machine
        /// </summary>
        [JsonProperty(PropertyName = "sourceComputerId")]
        public string SourceComputerId { get; set; }

        /// <summary>
        /// Gets or sets the name of the machine
        /// </summary>
        [JsonProperty(PropertyName = "machineName")]
        public string MachineName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (WorkspaceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "WorkspaceId");
            }
            if (Vmuuid == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Vmuuid");
            }
            if (SourceComputerId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SourceComputerId");
            }
            if (MachineName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MachineName");
            }
        }
    }
}
