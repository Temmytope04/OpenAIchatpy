// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.PolicyInsights.Models;

namespace Azure.ResourceManager.PolicyInsights
{
    /// <summary>
    /// A class representing the PolicyAttestation data model.
    /// An attestation resource.
    /// </summary>
    public partial class PolicyAttestationData : ResourceData
    {
        /// <summary> Initializes a new instance of PolicyAttestationData. </summary>
        /// <param name="policyAssignmentId"> The resource ID of the policy assignment that the attestation is setting the state for. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyAssignmentId"/> is null. </exception>
        public PolicyAttestationData(ResourceIdentifier policyAssignmentId)
        {
            Argument.AssertNotNull(policyAssignmentId, nameof(policyAssignmentId));

            PolicyAssignmentId = policyAssignmentId;
            Evidence = new ChangeTrackingList<AttestationEvidence>();
        }

        /// <summary> Initializes a new instance of PolicyAttestationData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="policyAssignmentId"> The resource ID of the policy assignment that the attestation is setting the state for. </param>
        /// <param name="policyDefinitionReferenceId"> The policy definition reference ID from a policy set definition that the attestation is setting the state for. If the policy assignment assigns a policy set definition the attestation can choose a definition within the set definition with this property or omit this and set the state for the entire set definition. </param>
        /// <param name="complianceState"> The compliance state that should be set on the resource. </param>
        /// <param name="expireOn"> The time the compliance state should expire. </param>
        /// <param name="owner"> The person responsible for setting the state of the resource. This value is typically an Azure Active Directory object ID. </param>
        /// <param name="comments"> Comments describing why this attestation was created. </param>
        /// <param name="evidence"> The evidence supporting the compliance state set in this attestation. </param>
        /// <param name="provisioningState"> The status of the attestation. </param>
        /// <param name="lastComplianceStateChangeOn"> The time the compliance state was last changed in this attestation. </param>
        /// <param name="assessOn"> The time the evidence was assessed. </param>
        /// <param name="metadata"> Additional metadata for this attestation. </param>
        internal PolicyAttestationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ResourceIdentifier policyAssignmentId, string policyDefinitionReferenceId, PolicyComplianceState? complianceState, DateTimeOffset? expireOn, string owner, string comments, IList<AttestationEvidence> evidence, string provisioningState, DateTimeOffset? lastComplianceStateChangeOn, DateTimeOffset? assessOn, BinaryData metadata) : base(id, name, resourceType, systemData)
        {
            PolicyAssignmentId = policyAssignmentId;
            PolicyDefinitionReferenceId = policyDefinitionReferenceId;
            ComplianceState = complianceState;
            ExpireOn = expireOn;
            Owner = owner;
            Comments = comments;
            Evidence = evidence;
            ProvisioningState = provisioningState;
            LastComplianceStateChangeOn = lastComplianceStateChangeOn;
            AssessOn = assessOn;
            Metadata = metadata;
        }

        /// <summary> The resource ID of the policy assignment that the attestation is setting the state for. </summary>
        public ResourceIdentifier PolicyAssignmentId { get; set; }
        /// <summary> The policy definition reference ID from a policy set definition that the attestation is setting the state for. If the policy assignment assigns a policy set definition the attestation can choose a definition within the set definition with this property or omit this and set the state for the entire set definition. </summary>
        public string PolicyDefinitionReferenceId { get; set; }
        /// <summary> The compliance state that should be set on the resource. </summary>
        public PolicyComplianceState? ComplianceState { get; set; }
        /// <summary> The time the compliance state should expire. </summary>
        public DateTimeOffset? ExpireOn { get; set; }
        /// <summary> The person responsible for setting the state of the resource. This value is typically an Azure Active Directory object ID. </summary>
        public string Owner { get; set; }
        /// <summary> Comments describing why this attestation was created. </summary>
        public string Comments { get; set; }
        /// <summary> The evidence supporting the compliance state set in this attestation. </summary>
        public IList<AttestationEvidence> Evidence { get; }
        /// <summary> The status of the attestation. </summary>
        public string ProvisioningState { get; }
        /// <summary> The time the compliance state was last changed in this attestation. </summary>
        public DateTimeOffset? LastComplianceStateChangeOn { get; }
        /// <summary> The time the evidence was assessed. </summary>
        public DateTimeOffset? AssessOn { get; set; }
        /// <summary>
        /// Additional metadata for this attestation
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData Metadata { get; set; }
    }
}
