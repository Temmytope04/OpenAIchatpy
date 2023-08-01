// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.DeviceProvisioningServices;

namespace Azure.ResourceManager.DeviceProvisioningServices.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    internal partial class DeviceProvisioningServicesArmClientMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="DeviceProvisioningServicesArmClientMockingExtension"/> class for mocking. </summary>
        protected DeviceProvisioningServicesArmClientMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DeviceProvisioningServicesArmClientMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DeviceProvisioningServicesArmClientMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal DeviceProvisioningServicesArmClientMockingExtension(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="DeviceProvisioningServicesCertificateResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DeviceProvisioningServicesCertificateResource.CreateResourceIdentifier" /> to create a <see cref="DeviceProvisioningServicesCertificateResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DeviceProvisioningServicesCertificateResource" /> object. </returns>
        public virtual DeviceProvisioningServicesCertificateResource GetDeviceProvisioningServicesCertificateResource(ResourceIdentifier id)
        {
            DeviceProvisioningServicesCertificateResource.ValidateResourceId(id);
            return new DeviceProvisioningServicesCertificateResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DeviceProvisioningServiceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DeviceProvisioningServiceResource.CreateResourceIdentifier" /> to create a <see cref="DeviceProvisioningServiceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DeviceProvisioningServiceResource" /> object. </returns>
        public virtual DeviceProvisioningServiceResource GetDeviceProvisioningServiceResource(ResourceIdentifier id)
        {
            DeviceProvisioningServiceResource.ValidateResourceId(id);
            return new DeviceProvisioningServiceResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DeviceProvisioningServicesPrivateLinkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DeviceProvisioningServicesPrivateLinkResource.CreateResourceIdentifier" /> to create a <see cref="DeviceProvisioningServicesPrivateLinkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DeviceProvisioningServicesPrivateLinkResource" /> object. </returns>
        public virtual DeviceProvisioningServicesPrivateLinkResource GetDeviceProvisioningServicesPrivateLinkResource(ResourceIdentifier id)
        {
            DeviceProvisioningServicesPrivateLinkResource.ValidateResourceId(id);
            return new DeviceProvisioningServicesPrivateLinkResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DeviceProvisioningServicesPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DeviceProvisioningServicesPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="DeviceProvisioningServicesPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DeviceProvisioningServicesPrivateEndpointConnectionResource" /> object. </returns>
        public virtual DeviceProvisioningServicesPrivateEndpointConnectionResource GetDeviceProvisioningServicesPrivateEndpointConnectionResource(ResourceIdentifier id)
        {
            DeviceProvisioningServicesPrivateEndpointConnectionResource.ValidateResourceId(id);
            return new DeviceProvisioningServicesPrivateEndpointConnectionResource(Client, id);
        }
    }
}
