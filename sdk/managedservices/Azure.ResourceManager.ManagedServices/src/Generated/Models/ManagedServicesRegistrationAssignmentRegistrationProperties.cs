// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ManagedServices.Models
{
    /// <summary> The properties of the registration definition associated with the registration assignment. </summary>
    public partial class ManagedServicesRegistrationAssignmentRegistrationProperties
    {
        /// <summary> Initializes a new instance of <see cref="ManagedServicesRegistrationAssignmentRegistrationProperties"/>. </summary>
        internal ManagedServicesRegistrationAssignmentRegistrationProperties()
        {
            Authorizations = new ChangeTrackingList<ManagedServicesAuthorization>();
            EligibleAuthorizations = new ChangeTrackingList<ManagedServicesEligibleAuthorization>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedServicesRegistrationAssignmentRegistrationProperties"/>. </summary>
        /// <param name="description"> The description of the registration definition. </param>
        /// <param name="authorizations"> The collection of authorization objects describing the access Azure Active Directory principals in the managedBy tenant will receive on the delegated resource in the managed tenant. </param>
        /// <param name="eligibleAuthorizations"> The collection of eligible authorization objects describing the just-in-time access Azure Active Directory principals in the managedBy tenant will receive on the delegated resource in the managed tenant. </param>
        /// <param name="registrationDefinitionName"> The name of the registration definition. </param>
        /// <param name="provisioningState"> The current provisioning state of the registration definition. </param>
        /// <param name="manageeTenantId"> The identifier of the managed tenant. </param>
        /// <param name="manageeTenantName"> The name of the managed tenant. </param>
        /// <param name="managedByTenantId"> The identifier of the managedBy tenant. </param>
        /// <param name="managedByTenantName"> The name of the managedBy tenant. </param>
        internal ManagedServicesRegistrationAssignmentRegistrationProperties(string description, IReadOnlyList<ManagedServicesAuthorization> authorizations, IReadOnlyList<ManagedServicesEligibleAuthorization> eligibleAuthorizations, string registrationDefinitionName, ManagedServicesProvisioningState? provisioningState, Guid? manageeTenantId, string manageeTenantName, Guid? managedByTenantId, string managedByTenantName)
        {
            Description = description;
            Authorizations = authorizations;
            EligibleAuthorizations = eligibleAuthorizations;
            RegistrationDefinitionName = registrationDefinitionName;
            ProvisioningState = provisioningState;
            ManageeTenantId = manageeTenantId;
            ManageeTenantName = manageeTenantName;
            ManagedByTenantId = managedByTenantId;
            ManagedByTenantName = managedByTenantName;
        }

        /// <summary> The description of the registration definition. </summary>
        public string Description { get; }
        /// <summary> The collection of authorization objects describing the access Azure Active Directory principals in the managedBy tenant will receive on the delegated resource in the managed tenant. </summary>
        public IReadOnlyList<ManagedServicesAuthorization> Authorizations { get; }
        /// <summary> The collection of eligible authorization objects describing the just-in-time access Azure Active Directory principals in the managedBy tenant will receive on the delegated resource in the managed tenant. </summary>
        public IReadOnlyList<ManagedServicesEligibleAuthorization> EligibleAuthorizations { get; }
        /// <summary> The name of the registration definition. </summary>
        public string RegistrationDefinitionName { get; }
        /// <summary> The current provisioning state of the registration definition. </summary>
        public ManagedServicesProvisioningState? ProvisioningState { get; }
        /// <summary> The identifier of the managed tenant. </summary>
        public Guid? ManageeTenantId { get; }
        /// <summary> The name of the managed tenant. </summary>
        public string ManageeTenantName { get; }
        /// <summary> The identifier of the managedBy tenant. </summary>
        public Guid? ManagedByTenantId { get; }
        /// <summary> The name of the managedBy tenant. </summary>
        public string ManagedByTenantName { get; }
    }
}
