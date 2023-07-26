// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.DataFactory.Mocking;
using Azure.ResourceManager.DataFactory.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DataFactory
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.DataFactory. </summary>
    public static partial class DataFactoryExtensions
    {
        private static DataFactoryArmClientMockingExtension GetDataFactoryArmClientMockingExtension(ArmClient client)
        {
            return client.GetCachedClient(client =>
            {
                return new DataFactoryArmClientMockingExtension(client);
            });
        }

        private static DataFactoryResourceGroupMockingExtension GetDataFactoryResourceGroupMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new DataFactoryResourceGroupMockingExtension(client, resource.Id);
            });
        }

        private static DataFactorySubscriptionMockingExtension GetDataFactorySubscriptionMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new DataFactorySubscriptionMockingExtension(client, resource.Id);
            });
        }

        #region DataFactoryResource
        /// <summary>
        /// Gets an object representing a <see cref="DataFactoryResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataFactoryResource.CreateResourceIdentifier" /> to create a <see cref="DataFactoryResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataFactoryResource" /> object. </returns>
        public static DataFactoryResource GetDataFactoryResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetDataFactoryArmClientMockingExtension(client).GetDataFactoryResource(id);
        }
        #endregion

        #region DataFactoryIntegrationRuntimeResource
        /// <summary>
        /// Gets an object representing a <see cref="DataFactoryIntegrationRuntimeResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataFactoryIntegrationRuntimeResource.CreateResourceIdentifier" /> to create a <see cref="DataFactoryIntegrationRuntimeResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataFactoryIntegrationRuntimeResource" /> object. </returns>
        public static DataFactoryIntegrationRuntimeResource GetDataFactoryIntegrationRuntimeResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetDataFactoryArmClientMockingExtension(client).GetDataFactoryIntegrationRuntimeResource(id);
        }
        #endregion

        #region DataFactoryLinkedServiceResource
        /// <summary>
        /// Gets an object representing a <see cref="DataFactoryLinkedServiceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataFactoryLinkedServiceResource.CreateResourceIdentifier" /> to create a <see cref="DataFactoryLinkedServiceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataFactoryLinkedServiceResource" /> object. </returns>
        public static DataFactoryLinkedServiceResource GetDataFactoryLinkedServiceResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetDataFactoryArmClientMockingExtension(client).GetDataFactoryLinkedServiceResource(id);
        }
        #endregion

        #region DataFactoryDatasetResource
        /// <summary>
        /// Gets an object representing a <see cref="DataFactoryDatasetResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataFactoryDatasetResource.CreateResourceIdentifier" /> to create a <see cref="DataFactoryDatasetResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataFactoryDatasetResource" /> object. </returns>
        public static DataFactoryDatasetResource GetDataFactoryDatasetResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetDataFactoryArmClientMockingExtension(client).GetDataFactoryDatasetResource(id);
        }
        #endregion

        #region DataFactoryPipelineResource
        /// <summary>
        /// Gets an object representing a <see cref="DataFactoryPipelineResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataFactoryPipelineResource.CreateResourceIdentifier" /> to create a <see cref="DataFactoryPipelineResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataFactoryPipelineResource" /> object. </returns>
        public static DataFactoryPipelineResource GetDataFactoryPipelineResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetDataFactoryArmClientMockingExtension(client).GetDataFactoryPipelineResource(id);
        }
        #endregion

        #region DataFactoryTriggerResource
        /// <summary>
        /// Gets an object representing a <see cref="DataFactoryTriggerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataFactoryTriggerResource.CreateResourceIdentifier" /> to create a <see cref="DataFactoryTriggerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataFactoryTriggerResource" /> object. </returns>
        public static DataFactoryTriggerResource GetDataFactoryTriggerResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetDataFactoryArmClientMockingExtension(client).GetDataFactoryTriggerResource(id);
        }
        #endregion

        #region DataFactoryDataFlowResource
        /// <summary>
        /// Gets an object representing a <see cref="DataFactoryDataFlowResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataFactoryDataFlowResource.CreateResourceIdentifier" /> to create a <see cref="DataFactoryDataFlowResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataFactoryDataFlowResource" /> object. </returns>
        public static DataFactoryDataFlowResource GetDataFactoryDataFlowResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetDataFactoryArmClientMockingExtension(client).GetDataFactoryDataFlowResource(id);
        }
        #endregion

        #region DataFactoryManagedVirtualNetworkResource
        /// <summary>
        /// Gets an object representing a <see cref="DataFactoryManagedVirtualNetworkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataFactoryManagedVirtualNetworkResource.CreateResourceIdentifier" /> to create a <see cref="DataFactoryManagedVirtualNetworkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataFactoryManagedVirtualNetworkResource" /> object. </returns>
        public static DataFactoryManagedVirtualNetworkResource GetDataFactoryManagedVirtualNetworkResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetDataFactoryArmClientMockingExtension(client).GetDataFactoryManagedVirtualNetworkResource(id);
        }
        #endregion

        #region DataFactoryPrivateEndpointResource
        /// <summary>
        /// Gets an object representing a <see cref="DataFactoryPrivateEndpointResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataFactoryPrivateEndpointResource.CreateResourceIdentifier" /> to create a <see cref="DataFactoryPrivateEndpointResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataFactoryPrivateEndpointResource" /> object. </returns>
        public static DataFactoryPrivateEndpointResource GetDataFactoryPrivateEndpointResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetDataFactoryArmClientMockingExtension(client).GetDataFactoryPrivateEndpointResource(id);
        }
        #endregion

        #region DataFactoryManagedIdentityCredentialResource
        /// <summary>
        /// Gets an object representing a <see cref="DataFactoryManagedIdentityCredentialResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataFactoryManagedIdentityCredentialResource.CreateResourceIdentifier" /> to create a <see cref="DataFactoryManagedIdentityCredentialResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataFactoryManagedIdentityCredentialResource" /> object. </returns>
        public static DataFactoryManagedIdentityCredentialResource GetDataFactoryManagedIdentityCredentialResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetDataFactoryArmClientMockingExtension(client).GetDataFactoryManagedIdentityCredentialResource(id);
        }
        #endregion

        #region DataFactoryPrivateEndpointConnectionResource
        /// <summary>
        /// Gets an object representing a <see cref="DataFactoryPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataFactoryPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="DataFactoryPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataFactoryPrivateEndpointConnectionResource" /> object. </returns>
        public static DataFactoryPrivateEndpointConnectionResource GetDataFactoryPrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetDataFactoryArmClientMockingExtension(client).GetDataFactoryPrivateEndpointConnectionResource(id);
        }
        #endregion

        #region DataFactoryGlobalParameterResource
        /// <summary>
        /// Gets an object representing a <see cref="DataFactoryGlobalParameterResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataFactoryGlobalParameterResource.CreateResourceIdentifier" /> to create a <see cref="DataFactoryGlobalParameterResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataFactoryGlobalParameterResource" /> object. </returns>
        public static DataFactoryGlobalParameterResource GetDataFactoryGlobalParameterResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetDataFactoryArmClientMockingExtension(client).GetDataFactoryGlobalParameterResource(id);
        }
        #endregion

        /// <summary> Gets a collection of DataFactoryResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of DataFactoryResources and their operations over a DataFactoryResource. </returns>
        public static DataFactoryCollection GetDataFactories(this ResourceGroupResource resourceGroupResource)
        {
            return GetDataFactoryResourceGroupMockingExtension(resourceGroupResource).GetDataFactories();
        }

        /// <summary>
        /// Gets a factory.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Factories_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="factoryName"> The factory name. </param>
        /// <param name="ifNoneMatch"> ETag of the factory entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="factoryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="factoryName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<DataFactoryResource>> GetDataFactoryAsync(this ResourceGroupResource resourceGroupResource, string factoryName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            return await GetDataFactoryResourceGroupMockingExtension(resourceGroupResource).GetDataFactoryAsync(factoryName, ifNoneMatch, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a factory.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Factories_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="factoryName"> The factory name. </param>
        /// <param name="ifNoneMatch"> ETag of the factory entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="factoryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="factoryName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<DataFactoryResource> GetDataFactory(this ResourceGroupResource resourceGroupResource, string factoryName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            return GetDataFactoryResourceGroupMockingExtension(resourceGroupResource).GetDataFactory(factoryName, ifNoneMatch, cancellationToken);
        }

        /// <summary>
        /// Lists factories under the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataFactory/factories</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Factories_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataFactoryResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DataFactoryResource> GetDataFactoriesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetDataFactorySubscriptionMockingExtension(subscriptionResource).GetDataFactoriesAsync(cancellationToken);
        }

        /// <summary>
        /// Lists factories under the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataFactory/factories</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Factories_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataFactoryResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<DataFactoryResource> GetDataFactories(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetDataFactorySubscriptionMockingExtension(subscriptionResource).GetDataFactories(cancellationToken);
        }

        /// <summary>
        /// Updates a factory's repo information.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataFactory/locations/{locationId}/configureFactoryRepo</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Factories_ConfigureFactoryRepo</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationId"> The location identifier. </param>
        /// <param name="factoryRepoUpdate"> Update factory repo request definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="factoryRepoUpdate"/> is null. </exception>
        public static async Task<Response<DataFactoryResource>> ConfigureFactoryRepoInformationAsync(this SubscriptionResource subscriptionResource, AzureLocation locationId, FactoryRepoUpdate factoryRepoUpdate, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(factoryRepoUpdate, nameof(factoryRepoUpdate));

            return await GetDataFactorySubscriptionMockingExtension(subscriptionResource).ConfigureFactoryRepoInformationAsync(locationId, factoryRepoUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates a factory's repo information.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataFactory/locations/{locationId}/configureFactoryRepo</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Factories_ConfigureFactoryRepo</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationId"> The location identifier. </param>
        /// <param name="factoryRepoUpdate"> Update factory repo request definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="factoryRepoUpdate"/> is null. </exception>
        public static Response<DataFactoryResource> ConfigureFactoryRepoInformation(this SubscriptionResource subscriptionResource, AzureLocation locationId, FactoryRepoUpdate factoryRepoUpdate, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(factoryRepoUpdate, nameof(factoryRepoUpdate));

            return GetDataFactorySubscriptionMockingExtension(subscriptionResource).ConfigureFactoryRepoInformation(locationId, factoryRepoUpdate, cancellationToken);
        }

        /// <summary>
        /// Get exposure control feature for specific location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataFactory/locations/{locationId}/getFeatureValue</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExposureControl_GetFeatureValue</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationId"> The location identifier. </param>
        /// <param name="content"> The exposure control request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<ExposureControlResult>> GetFeatureValueExposureControlAsync(this SubscriptionResource subscriptionResource, AzureLocation locationId, ExposureControlContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return await GetDataFactorySubscriptionMockingExtension(subscriptionResource).GetFeatureValueExposureControlAsync(locationId, content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get exposure control feature for specific location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataFactory/locations/{locationId}/getFeatureValue</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExposureControl_GetFeatureValue</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationId"> The location identifier. </param>
        /// <param name="content"> The exposure control request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<ExposureControlResult> GetFeatureValueExposureControl(this SubscriptionResource subscriptionResource, AzureLocation locationId, ExposureControlContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return GetDataFactorySubscriptionMockingExtension(subscriptionResource).GetFeatureValueExposureControl(locationId, content, cancellationToken);
        }
    }
}
