// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing the ManagedInstanceDtc data model.
    /// SQL Managed Instance DTC
    /// </summary>
    public partial class ManagedInstanceDtcData : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ManagedInstanceDtcData"/>. </summary>
        public ManagedInstanceDtcData()
        {
            ExternalDnsSuffixSearchList = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedInstanceDtcData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="dtcEnabled"> Active status of managed instance DTC. </param>
        /// <param name="securitySettings"> Security settings of managed instance DTC. </param>
        /// <param name="externalDnsSuffixSearchList"> External dns suffix search list of managed instance DTC. </param>
        /// <param name="dtcHostNameDnsSuffix"> Host name dns suffix of managed instance DTC. </param>
        /// <param name="provisioningState"> Provisioning state of managed instance DTC. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedInstanceDtcData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, bool? dtcEnabled, ManagedInstanceDtcSecuritySettings securitySettings, IList<string> externalDnsSuffixSearchList, string dtcHostNameDnsSuffix, JobExecutionProvisioningState? provisioningState, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            DtcEnabled = dtcEnabled;
            SecuritySettings = securitySettings;
            ExternalDnsSuffixSearchList = externalDnsSuffixSearchList;
            DtcHostNameDnsSuffix = dtcHostNameDnsSuffix;
            ProvisioningState = provisioningState;
            _rawData = rawData;
        }

        /// <summary> Active status of managed instance DTC. </summary>
        public bool? DtcEnabled { get; set; }
        /// <summary> Security settings of managed instance DTC. </summary>
        public ManagedInstanceDtcSecuritySettings SecuritySettings { get; set; }
        /// <summary> External dns suffix search list of managed instance DTC. </summary>
        public IList<string> ExternalDnsSuffixSearchList { get; }
        /// <summary> Host name dns suffix of managed instance DTC. </summary>
        public string DtcHostNameDnsSuffix { get; }
        /// <summary> Provisioning state of managed instance DTC. </summary>
        public JobExecutionProvisioningState? ProvisioningState { get; }
    }
}
