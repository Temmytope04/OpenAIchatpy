// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.Storage.Files.Shares.Models;

namespace Azure.Storage.Files.Shares
{
    internal partial class ShareGetPropertiesHeaders
    {
        private readonly Response _response;
        public ShareGetPropertiesHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> A set of name-value pairs that contain the user-defined metadata of the share. </summary>
        public IDictionary<string, string> Metadata => _response.Headers.TryGetValue("x-ms-meta-", out IDictionary<string, string> value) ? value : null;
        /// <summary> Returns the date and time the share was last modified. Any operation that modifies the share or its properties updates the last modified time. Operations on files do not affect the last modified time of the share. </summary>
        public DateTimeOffset? LastModified => _response.Headers.TryGetValue("Last-Modified", out DateTimeOffset? value) ? value : null;
        /// <summary> Indicates the version of the File service used to execute the request. </summary>
        public string Version => _response.Headers.TryGetValue("x-ms-version", out string value) ? value : null;
        /// <summary> Returns the current share quota in GB. </summary>
        public int? Quota => _response.Headers.TryGetValue("x-ms-share-quota", out int? value) ? value : null;
        /// <summary> Returns the current share provisioned ipos. </summary>
        public int? ProvisionedIops => _response.Headers.TryGetValue("x-ms-share-provisioned-iops", out int? value) ? value : null;
        /// <summary> Returns the current share provisioned ingress in megabytes per second. </summary>
        public int? ProvisionedIngressMBps => _response.Headers.TryGetValue("x-ms-share-provisioned-ingress-mbps", out int? value) ? value : null;
        /// <summary> Returns the current share provisioned egress in megabytes per second. </summary>
        public int? ProvisionedEgressMBps => _response.Headers.TryGetValue("x-ms-share-provisioned-egress-mbps", out int? value) ? value : null;
        /// <summary> Returns the current share next allowed quota downgrade time. </summary>
        public DateTimeOffset? NextAllowedQuotaDowngradeTime => _response.Headers.TryGetValue("x-ms-share-next-allowed-quota-downgrade-time", out DateTimeOffset? value) ? value : null;
        /// <summary> When a share is leased, specifies whether the lease is of infinite or fixed duration. </summary>
        public ShareLeaseDuration? LeaseDuration => _response.Headers.TryGetValue("x-ms-lease-duration", out string value) ? value.ToShareLeaseDuration() : null;
        /// <summary> Lease state of the share. </summary>
        public ShareLeaseState? LeaseState => _response.Headers.TryGetValue("x-ms-lease-state", out string value) ? value.ToShareLeaseState() : null;
        /// <summary> The current lease status of the share. </summary>
        public ShareLeaseStatus? LeaseStatus => _response.Headers.TryGetValue("x-ms-lease-status", out string value) ? value.ToShareLeaseStatus() : null;
        /// <summary> Returns the access tier set on the share. </summary>
        public string AccessTier => _response.Headers.TryGetValue("x-ms-access-tier", out string value) ? value : null;
        /// <summary> Returns the last modified time (in UTC) of the access tier of the share. </summary>
        public DateTimeOffset? AccessTierChangeTime => _response.Headers.TryGetValue("x-ms-access-tier-change-time", out DateTimeOffset? value) ? value : null;
        /// <summary> Returns the transition state betweeen access tiers, when present. </summary>
        public string AccessTierTransitionState => _response.Headers.TryGetValue("x-ms-access-tier-transition-state", out string value) ? value : null;
        /// <summary> The protocols that have been enabled on the share. </summary>
        public string EnabledProtocols => _response.Headers.TryGetValue("x-ms-enabled-protocols", out string value) ? value : null;
        /// <summary> Valid for NFS shares only. </summary>
        public ShareRootSquash? RootSquash => _response.Headers.TryGetValue("x-ms-root-squash", out string value) ? value.ToShareRootSquash() : null;
    }
}
