// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.HybridConnectivity.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableHybridConnectivityArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableHybridConnectivityArmClient"/> class for mocking. </summary>
        protected MockableHybridConnectivityArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableHybridConnectivityArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableHybridConnectivityArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableHybridConnectivityArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of SolutionConfigurationResources in the ArmClient. </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <returns> An object representing collection of SolutionConfigurationResources and their operations over a SolutionConfigurationResource. </returns>
        public virtual SolutionConfigurationCollection GetSolutionConfigurations(ResourceIdentifier scope)
        {
            return new SolutionConfigurationCollection(Client, scope);
        }

        /// <summary>
        /// Get a SolutionConfiguration
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/solutionConfigurations/{solutionConfiguration}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SolutionConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SolutionConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="solutionConfiguration"> Represent Solution Configuration Resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="solutionConfiguration"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="solutionConfiguration"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SolutionConfigurationResource>> GetSolutionConfigurationAsync(ResourceIdentifier scope, string solutionConfiguration, CancellationToken cancellationToken = default)
        {
            return await GetSolutionConfigurations(scope).GetAsync(solutionConfiguration, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a SolutionConfiguration
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/solutionConfigurations/{solutionConfiguration}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SolutionConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SolutionConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="solutionConfiguration"> Represent Solution Configuration Resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="solutionConfiguration"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="solutionConfiguration"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<SolutionConfigurationResource> GetSolutionConfiguration(ResourceIdentifier scope, string solutionConfiguration, CancellationToken cancellationToken = default)
        {
            return GetSolutionConfigurations(scope).Get(solutionConfiguration, cancellationToken);
        }

        /// <summary> Gets a collection of EndpointResources in the ArmClient. </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <returns> An object representing collection of EndpointResources and their operations over a EndpointResource. </returns>
        public virtual EndpointResourceCollection GetEndpointResources(ResourceIdentifier scope)
        {
            return new EndpointResourceCollection(Client, scope);
        }

        /// <summary>
        /// Gets the endpoint to the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/endpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="endpointName"> The endpoint name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<EndpointResource>> GetEndpointResourceAsync(ResourceIdentifier scope, string endpointName, CancellationToken cancellationToken = default)
        {
            return await GetEndpointResources(scope).GetAsync(endpointName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the endpoint to the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/endpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="endpointName"> The endpoint name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<EndpointResource> GetEndpointResource(ResourceIdentifier scope, string endpointName, CancellationToken cancellationToken = default)
        {
            return GetEndpointResources(scope).Get(endpointName, cancellationToken);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SolutionConfigurationResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SolutionConfigurationResource.CreateResourceIdentifier" /> to create a <see cref="SolutionConfigurationResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SolutionConfigurationResource"/> object. </returns>
        public virtual SolutionConfigurationResource GetSolutionConfigurationResource(ResourceIdentifier id)
        {
            SolutionConfigurationResource.ValidateResourceId(id);
            return new SolutionConfigurationResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="HybridConnectivityInventoryResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HybridConnectivityInventoryResource.CreateResourceIdentifier" /> to create a <see cref="HybridConnectivityInventoryResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HybridConnectivityInventoryResource"/> object. </returns>
        public virtual HybridConnectivityInventoryResource GetHybridConnectivityInventoryResource(ResourceIdentifier id)
        {
            HybridConnectivityInventoryResource.ValidateResourceId(id);
            return new HybridConnectivityInventoryResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PublicCloudConnectorResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PublicCloudConnectorResource.CreateResourceIdentifier" /> to create a <see cref="PublicCloudConnectorResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PublicCloudConnectorResource"/> object. </returns>
        public virtual PublicCloudConnectorResource GetPublicCloudConnectorResource(ResourceIdentifier id)
        {
            PublicCloudConnectorResource.ValidateResourceId(id);
            return new PublicCloudConnectorResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SolutionTypeResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SolutionTypeResource.CreateResourceIdentifier" /> to create a <see cref="SolutionTypeResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SolutionTypeResource"/> object. </returns>
        public virtual SolutionTypeResource GetSolutionTypeResource(ResourceIdentifier id)
        {
            SolutionTypeResource.ValidateResourceId(id);
            return new SolutionTypeResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="EndpointResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EndpointResource.CreateResourceIdentifier" /> to create an <see cref="EndpointResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EndpointResource"/> object. </returns>
        public virtual EndpointResource GetEndpointResource(ResourceIdentifier id)
        {
            EndpointResource.ValidateResourceId(id);
            return new EndpointResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ServiceConfigurationResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceConfigurationResource.CreateResourceIdentifier" /> to create a <see cref="ServiceConfigurationResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceConfigurationResource"/> object. </returns>
        public virtual ServiceConfigurationResource GetServiceConfigurationResource(ResourceIdentifier id)
        {
            ServiceConfigurationResource.ValidateResourceId(id);
            return new ServiceConfigurationResource(Client, id);
        }
    }
}
