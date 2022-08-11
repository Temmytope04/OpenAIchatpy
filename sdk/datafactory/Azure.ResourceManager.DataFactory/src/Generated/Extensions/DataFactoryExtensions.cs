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
using Azure.ResourceManager.DataFactory.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DataFactory
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.DataFactory. </summary>
    public static partial class DataFactoryExtensions
    {
        private static SubscriptionResourceExtensionClient GetExtensionClient(SubscriptionResource subscriptionResource)
        {
            return subscriptionResource.GetCachedClient((client) =>
            {
                return new SubscriptionResourceExtensionClient(client, subscriptionResource.Id);
            }
            );
        }

        /// <summary>
        /// Lists factories under the specified subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataFactory/factories
        /// Operation Id: Factories_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataFactoryResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DataFactoryResource> GetDataFactoriesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetDataFactoriesAsync(cancellationToken);
        }

        /// <summary>
        /// Lists factories under the specified subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataFactory/factories
        /// Operation Id: Factories_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataFactoryResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<DataFactoryResource> GetDataFactories(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetDataFactories(cancellationToken);
        }

        /// <summary>
        /// Updates a factory&apos;s repo information.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataFactory/locations/{locationId}/configureFactoryRepo
        /// Operation Id: Factories_ConfigureFactoryRepo
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationId"> The location identifier. </param>
        /// <param name="factoryRepoUpdate"> Update factory repo request definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="factoryRepoUpdate"/> is null. </exception>
        public static async Task<Response<DataFactoryResource>> ConfigureFactoryRepoInformationAsync(this SubscriptionResource subscriptionResource, AzureLocation locationId, FactoryRepoUpdate factoryRepoUpdate, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(factoryRepoUpdate, nameof(factoryRepoUpdate));

            return await GetExtensionClient(subscriptionResource).ConfigureFactoryRepoInformationAsync(locationId, factoryRepoUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates a factory&apos;s repo information.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataFactory/locations/{locationId}/configureFactoryRepo
        /// Operation Id: Factories_ConfigureFactoryRepo
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationId"> The location identifier. </param>
        /// <param name="factoryRepoUpdate"> Update factory repo request definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="factoryRepoUpdate"/> is null. </exception>
        public static Response<DataFactoryResource> ConfigureFactoryRepoInformation(this SubscriptionResource subscriptionResource, AzureLocation locationId, FactoryRepoUpdate factoryRepoUpdate, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(factoryRepoUpdate, nameof(factoryRepoUpdate));

            return GetExtensionClient(subscriptionResource).ConfigureFactoryRepoInformation(locationId, factoryRepoUpdate, cancellationToken);
        }

        /// <summary>
        /// Get exposure control feature for specific location.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataFactory/locations/{locationId}/getFeatureValue
        /// Operation Id: ExposureControl_GetFeatureValue
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationId"> The location identifier. </param>
        /// <param name="content"> The exposure control request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<ExposureControlResult>> GetFeatureValueExposureControlAsync(this SubscriptionResource subscriptionResource, AzureLocation locationId, ExposureControlContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return await GetExtensionClient(subscriptionResource).GetFeatureValueExposureControlAsync(locationId, content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get exposure control feature for specific location.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataFactory/locations/{locationId}/getFeatureValue
        /// Operation Id: ExposureControl_GetFeatureValue
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationId"> The location identifier. </param>
        /// <param name="content"> The exposure control request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<ExposureControlResult> GetFeatureValueExposureControl(this SubscriptionResource subscriptionResource, AzureLocation locationId, ExposureControlContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return GetExtensionClient(subscriptionResource).GetFeatureValueExposureControl(locationId, content, cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of DataFactoryResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of DataFactoryResources and their operations over a DataFactoryResource. </returns>
        public static DataFactoryCollection GetDataFactories(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetDataFactories();
        }

        /// <summary>
        /// Gets a factory.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}
        /// Operation Id: Factories_Get
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
            return await resourceGroupResource.GetDataFactories().GetAsync(factoryName, ifNoneMatch, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a factory.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}
        /// Operation Id: Factories_Get
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
            return resourceGroupResource.GetDataFactories().Get(factoryName, ifNoneMatch, cancellationToken);
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
            return client.GetResourceClient(() =>
            {
                DataFactoryResource.ValidateResourceId(id);
                return new DataFactoryResource(client, id);
            }
            );
        }
        #endregion

        #region FactoryIntegrationRuntimeResource
        /// <summary>
        /// Gets an object representing a <see cref="FactoryIntegrationRuntimeResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FactoryIntegrationRuntimeResource.CreateResourceIdentifier" /> to create a <see cref="FactoryIntegrationRuntimeResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FactoryIntegrationRuntimeResource" /> object. </returns>
        public static FactoryIntegrationRuntimeResource GetFactoryIntegrationRuntimeResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                FactoryIntegrationRuntimeResource.ValidateResourceId(id);
                return new FactoryIntegrationRuntimeResource(client, id);
            }
            );
        }
        #endregion

        #region FactoryLinkedServiceResource
        /// <summary>
        /// Gets an object representing a <see cref="FactoryLinkedServiceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FactoryLinkedServiceResource.CreateResourceIdentifier" /> to create a <see cref="FactoryLinkedServiceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FactoryLinkedServiceResource" /> object. </returns>
        public static FactoryLinkedServiceResource GetFactoryLinkedServiceResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                FactoryLinkedServiceResource.ValidateResourceId(id);
                return new FactoryLinkedServiceResource(client, id);
            }
            );
        }
        #endregion

        #region FactoryDatasetResource
        /// <summary>
        /// Gets an object representing a <see cref="FactoryDatasetResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FactoryDatasetResource.CreateResourceIdentifier" /> to create a <see cref="FactoryDatasetResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FactoryDatasetResource" /> object. </returns>
        public static FactoryDatasetResource GetFactoryDatasetResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                FactoryDatasetResource.ValidateResourceId(id);
                return new FactoryDatasetResource(client, id);
            }
            );
        }
        #endregion

        #region FactoryPipelineResource
        /// <summary>
        /// Gets an object representing a <see cref="FactoryPipelineResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FactoryPipelineResource.CreateResourceIdentifier" /> to create a <see cref="FactoryPipelineResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FactoryPipelineResource" /> object. </returns>
        public static FactoryPipelineResource GetFactoryPipelineResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                FactoryPipelineResource.ValidateResourceId(id);
                return new FactoryPipelineResource(client, id);
            }
            );
        }
        #endregion

        #region FactoryTriggerResource
        /// <summary>
        /// Gets an object representing a <see cref="FactoryTriggerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FactoryTriggerResource.CreateResourceIdentifier" /> to create a <see cref="FactoryTriggerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FactoryTriggerResource" /> object. </returns>
        public static FactoryTriggerResource GetFactoryTriggerResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                FactoryTriggerResource.ValidateResourceId(id);
                return new FactoryTriggerResource(client, id);
            }
            );
        }
        #endregion

        #region FactoryDataFlowResource
        /// <summary>
        /// Gets an object representing a <see cref="FactoryDataFlowResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FactoryDataFlowResource.CreateResourceIdentifier" /> to create a <see cref="FactoryDataFlowResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FactoryDataFlowResource" /> object. </returns>
        public static FactoryDataFlowResource GetFactoryDataFlowResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                FactoryDataFlowResource.ValidateResourceId(id);
                return new FactoryDataFlowResource(client, id);
            }
            );
        }
        #endregion

        #region FactoryVirtualNetworkResource
        /// <summary>
        /// Gets an object representing a <see cref="FactoryVirtualNetworkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FactoryVirtualNetworkResource.CreateResourceIdentifier" /> to create a <see cref="FactoryVirtualNetworkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FactoryVirtualNetworkResource" /> object. </returns>
        public static FactoryVirtualNetworkResource GetFactoryVirtualNetworkResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                FactoryVirtualNetworkResource.ValidateResourceId(id);
                return new FactoryVirtualNetworkResource(client, id);
            }
            );
        }
        #endregion

        #region FactoryPrivateEndpointResource
        /// <summary>
        /// Gets an object representing a <see cref="FactoryPrivateEndpointResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FactoryPrivateEndpointResource.CreateResourceIdentifier" /> to create a <see cref="FactoryPrivateEndpointResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FactoryPrivateEndpointResource" /> object. </returns>
        public static FactoryPrivateEndpointResource GetFactoryPrivateEndpointResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                FactoryPrivateEndpointResource.ValidateResourceId(id);
                return new FactoryPrivateEndpointResource(client, id);
            }
            );
        }
        #endregion

        #region FactoryPrivateEndpointConnectionResource
        /// <summary>
        /// Gets an object representing a <see cref="FactoryPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FactoryPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="FactoryPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FactoryPrivateEndpointConnectionResource" /> object. </returns>
        public static FactoryPrivateEndpointConnectionResource GetFactoryPrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                FactoryPrivateEndpointConnectionResource.ValidateResourceId(id);
                return new FactoryPrivateEndpointConnectionResource(client, id);
            }
            );
        }
        #endregion

        #region FactoryGlobalParameterResource
        /// <summary>
        /// Gets an object representing a <see cref="FactoryGlobalParameterResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FactoryGlobalParameterResource.CreateResourceIdentifier" /> to create a <see cref="FactoryGlobalParameterResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FactoryGlobalParameterResource" /> object. </returns>
        public static FactoryGlobalParameterResource GetFactoryGlobalParameterResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                FactoryGlobalParameterResource.ValidateResourceId(id);
                return new FactoryGlobalParameterResource(client, id);
            }
            );
        }
        #endregion
    }
}
