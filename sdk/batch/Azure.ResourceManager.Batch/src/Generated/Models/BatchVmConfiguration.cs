// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> The configuration for compute nodes in a pool based on the Azure Virtual Machines infrastructure. </summary>
    public partial class BatchVmConfiguration
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BatchVmConfiguration"/>. </summary>
        /// <param name="imageReference"> A reference to an Azure Virtual Machines Marketplace image or the Azure Image resource of a custom Virtual Machine. To get the list of all imageReferences verified by Azure Batch, see the 'List supported node agent SKUs' operation. </param>
        /// <param name="nodeAgentSkuId"> The Batch node agent is a program that runs on each node in the pool, and provides the command-and-control interface between the node and the Batch service. There are different implementations of the node agent, known as SKUs, for different operating systems. You must specify a node agent SKU which matches the selected image reference. To get the list of supported node agent SKUs along with their list of verified image references, see the 'List supported node agent SKUs' operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="imageReference"/> or <paramref name="nodeAgentSkuId"/> is null. </exception>
        public BatchVmConfiguration(BatchImageReference imageReference, string nodeAgentSkuId)
        {
            if (imageReference == null)
            {
                throw new ArgumentNullException(nameof(imageReference));
            }
            if (nodeAgentSkuId == null)
            {
                throw new ArgumentNullException(nameof(nodeAgentSkuId));
            }

            ImageReference = imageReference;
            NodeAgentSkuId = nodeAgentSkuId;
            DataDisks = new ChangeTrackingList<BatchVmDataDisk>();
            Extensions = new ChangeTrackingList<BatchVmExtension>();
        }

        /// <summary> Initializes a new instance of <see cref="BatchVmConfiguration"/>. </summary>
        /// <param name="imageReference"> A reference to an Azure Virtual Machines Marketplace image or the Azure Image resource of a custom Virtual Machine. To get the list of all imageReferences verified by Azure Batch, see the 'List supported node agent SKUs' operation. </param>
        /// <param name="nodeAgentSkuId"> The Batch node agent is a program that runs on each node in the pool, and provides the command-and-control interface between the node and the Batch service. There are different implementations of the node agent, known as SKUs, for different operating systems. You must specify a node agent SKU which matches the selected image reference. To get the list of supported node agent SKUs along with their list of verified image references, see the 'List supported node agent SKUs' operation. </param>
        /// <param name="windowsConfiguration"> This property must not be specified if the imageReference specifies a Linux OS image. </param>
        /// <param name="dataDisks"> This property must be specified if the compute nodes in the pool need to have empty data disks attached to them. </param>
        /// <param name="licenseType">
        /// This only applies to images that contain the Windows operating system, and should only be used when you hold valid on-premises licenses for the nodes which will be deployed. If omitted, no on-premises licensing discount is applied. Values are:
        ///
        ///  Windows_Server - The on-premises license is for Windows Server.
        ///  Windows_Client - The on-premises license is for Windows Client.
        ///
        /// </param>
        /// <param name="containerConfiguration"> If specified, setup is performed on each node in the pool to allow tasks to run in containers. All regular tasks and job manager tasks run on this pool must specify the containerSettings property, and all other tasks may specify it. </param>
        /// <param name="diskEncryptionConfiguration"> If specified, encryption is performed on each node in the pool during node provisioning. </param>
        /// <param name="nodePlacementConfiguration"> This configuration will specify rules on how nodes in the pool will be physically allocated. </param>
        /// <param name="extensions"> If specified, the extensions mentioned in this configuration will be installed on each node. </param>
        /// <param name="osDisk"> Contains configuration for ephemeral OSDisk settings. </param>
        /// <param name="securityProfile"> Specifies the security profile settings for the virtual machine or virtual machine scale set. </param>
        /// <param name="serviceArtifactReference"> The service artifact reference id in the form of /subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Compute/galleries/{galleryName}/serviceArtifacts/{serviceArtifactName}/vmArtifactsProfiles/{vmArtifactsProfilesName}. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchVmConfiguration(BatchImageReference imageReference, string nodeAgentSkuId, WindowsConfiguration windowsConfiguration, IList<BatchVmDataDisk> dataDisks, string licenseType, BatchVmContainerConfiguration containerConfiguration, DiskEncryptionConfiguration diskEncryptionConfiguration, NodePlacementConfiguration nodePlacementConfiguration, IList<BatchVmExtension> extensions, BatchOSDisk osDisk, BatchSecurityProfile securityProfile, WritableSubResource serviceArtifactReference, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ImageReference = imageReference;
            NodeAgentSkuId = nodeAgentSkuId;
            WindowsConfiguration = windowsConfiguration;
            DataDisks = dataDisks;
            LicenseType = licenseType;
            ContainerConfiguration = containerConfiguration;
            DiskEncryptionConfiguration = diskEncryptionConfiguration;
            NodePlacementConfiguration = nodePlacementConfiguration;
            Extensions = extensions;
            OSDisk = osDisk;
            SecurityProfile = securityProfile;
            ServiceArtifactReference = serviceArtifactReference;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BatchVmConfiguration"/> for deserialization. </summary>
        internal BatchVmConfiguration()
        {
        }

        /// <summary> A reference to an Azure Virtual Machines Marketplace image or the Azure Image resource of a custom Virtual Machine. To get the list of all imageReferences verified by Azure Batch, see the 'List supported node agent SKUs' operation. </summary>
        public BatchImageReference ImageReference { get; set; }
        /// <summary> The Batch node agent is a program that runs on each node in the pool, and provides the command-and-control interface between the node and the Batch service. There are different implementations of the node agent, known as SKUs, for different operating systems. You must specify a node agent SKU which matches the selected image reference. To get the list of supported node agent SKUs along with their list of verified image references, see the 'List supported node agent SKUs' operation. </summary>
        public string NodeAgentSkuId { get; set; }
        /// <summary> This property must not be specified if the imageReference specifies a Linux OS image. </summary>
        internal WindowsConfiguration WindowsConfiguration { get; set; }
        /// <summary> If omitted, the default value is true. </summary>
        public bool? IsAutomaticUpdateEnabled
        {
            get => WindowsConfiguration is null ? default : WindowsConfiguration.IsAutomaticUpdateEnabled;
            set
            {
                if (WindowsConfiguration is null)
                    WindowsConfiguration = new WindowsConfiguration();
                WindowsConfiguration.IsAutomaticUpdateEnabled = value;
            }
        }

        /// <summary> This property must be specified if the compute nodes in the pool need to have empty data disks attached to them. </summary>
        public IList<BatchVmDataDisk> DataDisks { get; }
        /// <summary>
        /// This only applies to images that contain the Windows operating system, and should only be used when you hold valid on-premises licenses for the nodes which will be deployed. If omitted, no on-premises licensing discount is applied. Values are:
        ///
        ///  Windows_Server - The on-premises license is for Windows Server.
        ///  Windows_Client - The on-premises license is for Windows Client.
        ///
        /// </summary>
        public string LicenseType { get; set; }
        /// <summary> If specified, setup is performed on each node in the pool to allow tasks to run in containers. All regular tasks and job manager tasks run on this pool must specify the containerSettings property, and all other tasks may specify it. </summary>
        public BatchVmContainerConfiguration ContainerConfiguration { get; set; }
        /// <summary> If specified, encryption is performed on each node in the pool during node provisioning. </summary>
        internal DiskEncryptionConfiguration DiskEncryptionConfiguration { get; set; }
        /// <summary> On Linux pool, only "TemporaryDisk" is supported; on Windows pool, "OsDisk" and "TemporaryDisk" must be specified. </summary>
        public IList<BatchDiskEncryptionTarget> DiskEncryptionTargets
        {
            get
            {
                if (DiskEncryptionConfiguration is null)
                    DiskEncryptionConfiguration = new DiskEncryptionConfiguration();
                return DiskEncryptionConfiguration.Targets;
            }
        }

        /// <summary> This configuration will specify rules on how nodes in the pool will be physically allocated. </summary>
        internal NodePlacementConfiguration NodePlacementConfiguration { get; set; }
        /// <summary> Allocation policy used by Batch Service to provision the nodes. If not specified, Batch will use the regional policy. </summary>
        public BatchNodePlacementPolicyType? NodePlacementPolicy
        {
            get => NodePlacementConfiguration is null ? default : NodePlacementConfiguration.Policy;
            set
            {
                if (NodePlacementConfiguration is null)
                    NodePlacementConfiguration = new NodePlacementConfiguration();
                NodePlacementConfiguration.Policy = value;
            }
        }

        /// <summary> If specified, the extensions mentioned in this configuration will be installed on each node. </summary>
        public IList<BatchVmExtension> Extensions { get; }
        /// <summary> Contains configuration for ephemeral OSDisk settings. </summary>
        public BatchOSDisk OSDisk { get; set; }
        /// <summary> Specifies the security profile settings for the virtual machine or virtual machine scale set. </summary>
        public BatchSecurityProfile SecurityProfile { get; set; }
        /// <summary> The service artifact reference id in the form of /subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Compute/galleries/{galleryName}/serviceArtifacts/{serviceArtifactName}/vmArtifactsProfiles/{vmArtifactsProfilesName}. </summary>
        internal WritableSubResource ServiceArtifactReference { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier ServiceArtifactReferenceId
        {
            get => ServiceArtifactReference is null ? default : ServiceArtifactReference.Id;
            set
            {
                if (ServiceArtifactReference is null)
                    ServiceArtifactReference = new WritableSubResource();
                ServiceArtifactReference.Id = value;
            }
        }
    }
}
