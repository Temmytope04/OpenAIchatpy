// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventHub.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Single item in List or Get Alias(Disaster Recovery configuration)
    /// operation
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ArmDisasterRecovery : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ArmDisasterRecovery class.
        /// </summary>
        public ArmDisasterRecovery()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ArmDisasterRecovery class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="provisioningState">Provisioning state of the
        /// Alias(Disaster Recovery configuration) - possible values 'Accepted'
        /// or 'Succeeded' or 'Failed'. Possible values include: 'Accepted',
        /// 'Succeeded', 'Failed'</param>
        /// <param name="partnerNamespace">ARM Id of the Primary/Secondary
        /// eventhub namespace name, which is part of GEO DR pairing</param>
        /// <param name="alternateName">Alternate name specified when alias and
        /// namespace names are same.</param>
        /// <param name="role">role of namespace in GEO DR - possible values
        /// 'Primary' or 'PrimaryNotReplicating' or 'Secondary'. Possible
        /// values include: 'Primary', 'PrimaryNotReplicating',
        /// 'Secondary'</param>
        /// <param name="pendingReplicationOperationsCount">Number of entities
        /// pending to be replicated.</param>
        /// <param name="systemData">The system meta data relating to this
        /// resource.</param>
        public ArmDisasterRecovery(string id = default(string), string name = default(string), string type = default(string), ProvisioningStateDR? provisioningState = default(ProvisioningStateDR?), string partnerNamespace = default(string), string alternateName = default(string), RoleDisasterRecovery? role = default(RoleDisasterRecovery?), long? pendingReplicationOperationsCount = default(long?), SystemData systemData = default(SystemData))
            : base(id, name, type)
        {
            ProvisioningState = provisioningState;
            PartnerNamespace = partnerNamespace;
            AlternateName = alternateName;
            Role = role;
            PendingReplicationOperationsCount = pendingReplicationOperationsCount;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets provisioning state of the Alias(Disaster Recovery
        /// configuration) - possible values 'Accepted' or 'Succeeded' or
        /// 'Failed'. Possible values include: 'Accepted', 'Succeeded',
        /// 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningStateDR? ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets ARM Id of the Primary/Secondary eventhub namespace
        /// name, which is part of GEO DR pairing
        /// </summary>
        [JsonProperty(PropertyName = "properties.partnerNamespace")]
        public string PartnerNamespace { get; set; }

        /// <summary>
        /// Gets or sets alternate name specified when alias and namespace
        /// names are same.
        /// </summary>
        [JsonProperty(PropertyName = "properties.alternateName")]
        public string AlternateName { get; set; }

        /// <summary>
        /// Gets role of namespace in GEO DR - possible values 'Primary' or
        /// 'PrimaryNotReplicating' or 'Secondary'. Possible values include:
        /// 'Primary', 'PrimaryNotReplicating', 'Secondary'
        /// </summary>
        [JsonProperty(PropertyName = "properties.role")]
        public RoleDisasterRecovery? Role { get; private set; }

        /// <summary>
        /// Gets number of entities pending to be replicated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.pendingReplicationOperationsCount")]
        public long? PendingReplicationOperationsCount { get; private set; }

        /// <summary>
        /// Gets the system meta data relating to this resource.
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; private set; }

    }
}
