// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The managed server family capability. </summary>
    public partial class ManagedInstanceFamilyCapability
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ManagedInstanceFamilyCapability"/>. </summary>
        internal ManagedInstanceFamilyCapability()
        {
            SupportedLicenseTypes = new ChangeTrackingList<LicenseTypeCapability>();
            SupportedVcoresValues = new ChangeTrackingList<ManagedInstanceVcoresCapability>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedInstanceFamilyCapability"/>. </summary>
        /// <param name="name"> Family name. </param>
        /// <param name="sku"> SKU name. </param>
        /// <param name="supportedLicenseTypes"> List of supported license types. </param>
        /// <param name="supportedVcoresValues"> List of supported virtual cores values. </param>
        /// <param name="status"> The status of the capability. </param>
        /// <param name="reason"> The reason for the capability not being available. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedInstanceFamilyCapability(string name, string sku, IReadOnlyList<LicenseTypeCapability> supportedLicenseTypes, IReadOnlyList<ManagedInstanceVcoresCapability> supportedVcoresValues, SqlCapabilityStatus? status, string reason, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            Sku = sku;
            SupportedLicenseTypes = supportedLicenseTypes;
            SupportedVcoresValues = supportedVcoresValues;
            Status = status;
            Reason = reason;
            _rawData = rawData;
        }

        /// <summary> Family name. </summary>
        public string Name { get; }
        /// <summary> SKU name. </summary>
        public string Sku { get; }
        /// <summary> List of supported license types. </summary>
        public IReadOnlyList<LicenseTypeCapability> SupportedLicenseTypes { get; }
        /// <summary> List of supported virtual cores values. </summary>
        public IReadOnlyList<ManagedInstanceVcoresCapability> SupportedVcoresValues { get; }
        /// <summary> The status of the capability. </summary>
        public SqlCapabilityStatus? Status { get; }
        /// <summary> The reason for the capability not being available. </summary>
        public string Reason { get; }
    }
}
