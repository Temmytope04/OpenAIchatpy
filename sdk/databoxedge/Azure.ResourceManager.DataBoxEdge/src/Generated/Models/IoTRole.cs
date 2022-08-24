// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataBoxEdge;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Compute role. </summary>
    public partial class IoTRole : RoleData
    {
        /// <summary> Initializes a new instance of IoTRole. </summary>
        public IoTRole()
        {
            ShareMappings = new ChangeTrackingList<MountPointMap>();
            Kind = RoleType.IOT;
        }

        /// <summary> Initializes a new instance of IoTRole. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Role type. </param>
        /// <param name="hostPlatform"> Host OS supported by the IoT role. </param>
        /// <param name="ioTDeviceDetails"> IoT device metadata to which data box edge device needs to be connected. </param>
        /// <param name="ioTEdgeDeviceDetails"> IoT edge device to which the IoT role needs to be configured. </param>
        /// <param name="shareMappings"> Mount points of shares in role(s). </param>
        /// <param name="ioTEdgeAgentInfo"> Iot edge agent details to download the agent and bootstrap iot runtime. </param>
        /// <param name="hostPlatformType"> Platform where the Iot runtime is hosted. </param>
        /// <param name="computeResource"> Resource allocation. </param>
        /// <param name="roleStatus"> Role status. </param>
        internal IoTRole(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, RoleType kind, PlatformType? hostPlatform, IoTDeviceInfo ioTDeviceDetails, IoTDeviceInfo ioTEdgeDeviceDetails, IList<MountPointMap> shareMappings, IoTEdgeAgentInfo ioTEdgeAgentInfo, HostPlatformType? hostPlatformType, ComputeResource computeResource, RoleStatus? roleStatus) : base(id, name, resourceType, systemData, kind)
        {
            HostPlatform = hostPlatform;
            IoTDeviceDetails = ioTDeviceDetails;
            IoTEdgeDeviceDetails = ioTEdgeDeviceDetails;
            ShareMappings = shareMappings;
            IoTEdgeAgentInfo = ioTEdgeAgentInfo;
            HostPlatformType = hostPlatformType;
            ComputeResource = computeResource;
            RoleStatus = roleStatus;
            Kind = kind;
        }

        /// <summary> Host OS supported by the IoT role. </summary>
        public PlatformType? HostPlatform { get; set; }
        /// <summary> IoT device metadata to which data box edge device needs to be connected. </summary>
        public IoTDeviceInfo IoTDeviceDetails { get; set; }
        /// <summary> IoT edge device to which the IoT role needs to be configured. </summary>
        public IoTDeviceInfo IoTEdgeDeviceDetails { get; set; }
        /// <summary> Mount points of shares in role(s). </summary>
        public IList<MountPointMap> ShareMappings { get; }
        /// <summary> Iot edge agent details to download the agent and bootstrap iot runtime. </summary>
        public IoTEdgeAgentInfo IoTEdgeAgentInfo { get; set; }
        /// <summary> Platform where the Iot runtime is hosted. </summary>
        public HostPlatformType? HostPlatformType { get; }
        /// <summary> Resource allocation. </summary>
        public ComputeResource ComputeResource { get; set; }
        /// <summary> Role status. </summary>
        public RoleStatus? RoleStatus { get; set; }
    }
}
