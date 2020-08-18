// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Management.Storage.Models
{
    /// <summary> The blob container properties be listed out. </summary>
    public partial class ListContainerItem : AzureEntityResource
    {
        /// <summary> Initializes a new instance of ListContainerItem. </summary>
        public ListContainerItem()
        {
            Metadata = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of ListContainerItem. </summary>
        /// <param name="id"> Fully qualified resource Id for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. </param>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="type"> The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts. </param>
        /// <param name="etag"> Resource Etag. </param>
        /// <param name="version"> The version of the deleted blob container. </param>
        /// <param name="deleted"> Indicates whether the blob container was deleted. </param>
        /// <param name="deletedTime"> Blob container deletion time. </param>
        /// <param name="remainingRetentionDays"> Remaining retention days for soft deleted blob container. </param>
        /// <param name="defaultEncryptionScope"> Default the container to use specified encryption scope for all writes. </param>
        /// <param name="denyEncryptionScopeOverride"> Block override of encryption scope from the container default. </param>
        /// <param name="publicAccess"> Specifies whether data in the container may be accessed publicly and the level of access. </param>
        /// <param name="lastModifiedTime"> Returns the date and time the container was last modified. </param>
        /// <param name="leaseStatus"> The lease status of the container. </param>
        /// <param name="leaseState"> Lease state of the container. </param>
        /// <param name="leaseDuration"> Specifies whether the lease on a container is of infinite or fixed duration, only when the container is leased. </param>
        /// <param name="metadata"> A name-value pair to associate with the container as metadata. </param>
        /// <param name="immutabilityPolicy"> The ImmutabilityPolicy property of the container. </param>
        /// <param name="legalHold"> The LegalHold property of the container. </param>
        /// <param name="hasLegalHold"> The hasLegalHold public property is set to true by SRP if there are at least one existing tag. The hasLegalHold public property is set to false by SRP if all existing legal hold tags are cleared out. There can be a maximum of 1000 blob containers with hasLegalHold=true for a given account. </param>
        /// <param name="hasImmutabilityPolicy"> The hasImmutabilityPolicy public property is set to true by SRP if ImmutabilityPolicy has been created for this container. The hasImmutabilityPolicy public property is set to false by SRP if ImmutabilityPolicy has not been created for this container. </param>
        internal ListContainerItem(string id, string name, string type, string etag, string version, bool? deleted, DateTimeOffset? deletedTime, int? remainingRetentionDays, string defaultEncryptionScope, bool? denyEncryptionScopeOverride, PublicAccess? publicAccess, DateTimeOffset? lastModifiedTime, LeaseStatus? leaseStatus, LeaseState? leaseState, LeaseDuration? leaseDuration, IDictionary<string, string> metadata, ImmutabilityPolicyProperties immutabilityPolicy, LegalHoldProperties legalHold, bool? hasLegalHold, bool? hasImmutabilityPolicy) : base(id, name, type, etag)
        {
            Version = version;
            Deleted = deleted;
            DeletedTime = deletedTime;
            RemainingRetentionDays = remainingRetentionDays;
            DefaultEncryptionScope = defaultEncryptionScope;
            DenyEncryptionScopeOverride = denyEncryptionScopeOverride;
            PublicAccess = publicAccess;
            LastModifiedTime = lastModifiedTime;
            LeaseStatus = leaseStatus;
            LeaseState = leaseState;
            LeaseDuration = leaseDuration;
            Metadata = metadata;
            ImmutabilityPolicy = immutabilityPolicy;
            LegalHold = legalHold;
            HasLegalHold = hasLegalHold;
            HasImmutabilityPolicy = hasImmutabilityPolicy;
        }

        /// <summary> The version of the deleted blob container. </summary>
        public string Version { get; }
        /// <summary> Indicates whether the blob container was deleted. </summary>
        public bool? Deleted { get; }
        /// <summary> Blob container deletion time. </summary>
        public DateTimeOffset? DeletedTime { get; }
        /// <summary> Remaining retention days for soft deleted blob container. </summary>
        public int? RemainingRetentionDays { get; }
        /// <summary> Default the container to use specified encryption scope for all writes. </summary>
        public string DefaultEncryptionScope { get; set; }
        /// <summary> Block override of encryption scope from the container default. </summary>
        public bool? DenyEncryptionScopeOverride { get; set; }
        /// <summary> Specifies whether data in the container may be accessed publicly and the level of access. </summary>
        public PublicAccess? PublicAccess { get; set; }
        /// <summary> Returns the date and time the container was last modified. </summary>
        public DateTimeOffset? LastModifiedTime { get; }
        /// <summary> The lease status of the container. </summary>
        public LeaseStatus? LeaseStatus { get; }
        /// <summary> Lease state of the container. </summary>
        public LeaseState? LeaseState { get; }
        /// <summary> Specifies whether the lease on a container is of infinite or fixed duration, only when the container is leased. </summary>
        public LeaseDuration? LeaseDuration { get; }
        /// <summary> A name-value pair to associate with the container as metadata. </summary>
        public IDictionary<string, string> Metadata { get; }
        /// <summary> The ImmutabilityPolicy property of the container. </summary>
        public ImmutabilityPolicyProperties ImmutabilityPolicy { get; }
        /// <summary> The LegalHold property of the container. </summary>
        public LegalHoldProperties LegalHold { get; }
        /// <summary> The hasLegalHold public property is set to true by SRP if there are at least one existing tag. The hasLegalHold public property is set to false by SRP if all existing legal hold tags are cleared out. There can be a maximum of 1000 blob containers with hasLegalHold=true for a given account. </summary>
        public bool? HasLegalHold { get; }
        /// <summary> The hasImmutabilityPolicy public property is set to true by SRP if ImmutabilityPolicy has been created for this container. The hasImmutabilityPolicy public property is set to false by SRP if ImmutabilityPolicy has not been created for this container. </summary>
        public bool? HasImmutabilityPolicy { get; }
    }
}
