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
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.ServiceFabric.Mocking;
using Azure.ResourceManager.ServiceFabric.Models;

namespace Azure.ResourceManager.ServiceFabric
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.ServiceFabric. </summary>
    public static partial class ServiceFabricExtensions
    {
        private static MockableServiceFabricArmClient GetMockableServiceFabricArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableServiceFabricArmClient(client0));
        }

        private static MockableServiceFabricResourceGroupResource GetMockableServiceFabricResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableServiceFabricResourceGroupResource(client, resource.Id));
        }

        private static MockableServiceFabricSubscriptionResource GetMockableServiceFabricSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableServiceFabricSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="ServiceFabricClusterResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceFabricClusterResource.CreateResourceIdentifier" /> to create a <see cref="ServiceFabricClusterResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceFabricArmClient.GetServiceFabricClusterResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceFabricClusterResource" /> object. </returns>
        public static ServiceFabricClusterResource GetServiceFabricClusterResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableServiceFabricArmClient(client).GetServiceFabricClusterResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ServiceFabricApplicationTypeResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceFabricApplicationTypeResource.CreateResourceIdentifier" /> to create a <see cref="ServiceFabricApplicationTypeResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceFabricArmClient.GetServiceFabricApplicationTypeResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceFabricApplicationTypeResource" /> object. </returns>
        public static ServiceFabricApplicationTypeResource GetServiceFabricApplicationTypeResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableServiceFabricArmClient(client).GetServiceFabricApplicationTypeResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ServiceFabricApplicationTypeVersionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceFabricApplicationTypeVersionResource.CreateResourceIdentifier" /> to create a <see cref="ServiceFabricApplicationTypeVersionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceFabricArmClient.GetServiceFabricApplicationTypeVersionResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceFabricApplicationTypeVersionResource" /> object. </returns>
        public static ServiceFabricApplicationTypeVersionResource GetServiceFabricApplicationTypeVersionResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableServiceFabricArmClient(client).GetServiceFabricApplicationTypeVersionResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ServiceFabricApplicationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceFabricApplicationResource.CreateResourceIdentifier" /> to create a <see cref="ServiceFabricApplicationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceFabricArmClient.GetServiceFabricApplicationResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceFabricApplicationResource" /> object. </returns>
        public static ServiceFabricApplicationResource GetServiceFabricApplicationResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableServiceFabricArmClient(client).GetServiceFabricApplicationResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ServiceFabricServiceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceFabricServiceResource.CreateResourceIdentifier" /> to create a <see cref="ServiceFabricServiceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceFabricArmClient.GetServiceFabricServiceResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceFabricServiceResource" /> object. </returns>
        public static ServiceFabricServiceResource GetServiceFabricServiceResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableServiceFabricArmClient(client).GetServiceFabricServiceResource(id);
        }

        /// <summary>
        /// Gets a collection of ServiceFabricClusterResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceFabricResourceGroupResource.GetServiceFabricClusters()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of ServiceFabricClusterResources and their operations over a ServiceFabricClusterResource. </returns>
        public static ServiceFabricClusterCollection GetServiceFabricClusters(this ResourceGroupResource resourceGroupResource)
        {
            return GetMockableServiceFabricResourceGroupResource(resourceGroupResource).GetServiceFabricClusters();
        }

        /// <summary>
        /// Get a Service Fabric cluster resource created or in the process of being created in the specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/clusters/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceFabricResourceGroupResource.GetServiceFabricClusterAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="clusterName"> The name of the cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<ServiceFabricClusterResource>> GetServiceFabricClusterAsync(this ResourceGroupResource resourceGroupResource, string clusterName, CancellationToken cancellationToken = default)
        {
            return await GetMockableServiceFabricResourceGroupResource(resourceGroupResource).GetServiceFabricClusterAsync(clusterName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a Service Fabric cluster resource created or in the process of being created in the specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/clusters/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceFabricResourceGroupResource.GetServiceFabricCluster(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="clusterName"> The name of the cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<ServiceFabricClusterResource> GetServiceFabricCluster(this ResourceGroupResource resourceGroupResource, string clusterName, CancellationToken cancellationToken = default)
        {
            return GetMockableServiceFabricResourceGroupResource(resourceGroupResource).GetServiceFabricCluster(clusterName, cancellationToken);
        }

        /// <summary>
        /// Gets all Service Fabric cluster resources created or in the process of being created in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/clusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceFabricSubscriptionResource.GetServiceFabricClusters(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceFabricClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ServiceFabricClusterResource> GetServiceFabricClustersAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetMockableServiceFabricSubscriptionResource(subscriptionResource).GetServiceFabricClustersAsync(cancellationToken);
        }

        /// <summary>
        /// Gets all Service Fabric cluster resources created or in the process of being created in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/clusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceFabricSubscriptionResource.GetServiceFabricClusters(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceFabricClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ServiceFabricClusterResource> GetServiceFabricClusters(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetMockableServiceFabricSubscriptionResource(subscriptionResource).GetServiceFabricClusters(cancellationToken);
        }

        /// <summary>
        /// Gets information about an available Service Fabric cluster code version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/clusterVersions/{clusterVersion}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterVersions_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceFabricSubscriptionResource.GetClusterVersions(AzureLocation,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="clusterVersion"> The cluster code version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterVersion"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterVersion"/> is null. </exception>
        /// <returns> An async collection of <see cref="ClusterCodeVersionsResult" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ClusterCodeVersionsResult> GetClusterVersionsAsync(this SubscriptionResource subscriptionResource, AzureLocation location, string clusterVersion, CancellationToken cancellationToken = default)
        {
            return GetMockableServiceFabricSubscriptionResource(subscriptionResource).GetClusterVersionsAsync(location, clusterVersion, cancellationToken);
        }

        /// <summary>
        /// Gets information about an available Service Fabric cluster code version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/clusterVersions/{clusterVersion}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterVersions_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceFabricSubscriptionResource.GetClusterVersions(AzureLocation,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="clusterVersion"> The cluster code version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterVersion"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterVersion"/> is null. </exception>
        /// <returns> A collection of <see cref="ClusterCodeVersionsResult" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ClusterCodeVersionsResult> GetClusterVersions(this SubscriptionResource subscriptionResource, AzureLocation location, string clusterVersion, CancellationToken cancellationToken = default)
        {
            return GetMockableServiceFabricSubscriptionResource(subscriptionResource).GetClusterVersions(location, clusterVersion, cancellationToken);
        }

        /// <summary>
        /// Gets information about an available Service Fabric cluster code version by environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/environments/{environment}/clusterVersions/{clusterVersion}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterVersions_GetByEnvironment</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceFabricSubscriptionResource.GetClusterVersionsByEnvironment(AzureLocation,ClusterVersionsEnvironment,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="environment"> The operating system of the cluster. The default means all. </param>
        /// <param name="clusterVersion"> The cluster code version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterVersion"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterVersion"/> is null. </exception>
        /// <returns> An async collection of <see cref="ClusterCodeVersionsResult" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ClusterCodeVersionsResult> GetClusterVersionsByEnvironmentAsync(this SubscriptionResource subscriptionResource, AzureLocation location, ClusterVersionsEnvironment environment, string clusterVersion, CancellationToken cancellationToken = default)
        {
            return GetMockableServiceFabricSubscriptionResource(subscriptionResource).GetClusterVersionsByEnvironmentAsync(location, environment, clusterVersion, cancellationToken);
        }

        /// <summary>
        /// Gets information about an available Service Fabric cluster code version by environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/environments/{environment}/clusterVersions/{clusterVersion}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterVersions_GetByEnvironment</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceFabricSubscriptionResource.GetClusterVersionsByEnvironment(AzureLocation,ClusterVersionsEnvironment,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="environment"> The operating system of the cluster. The default means all. </param>
        /// <param name="clusterVersion"> The cluster code version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterVersion"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterVersion"/> is null. </exception>
        /// <returns> A collection of <see cref="ClusterCodeVersionsResult" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ClusterCodeVersionsResult> GetClusterVersionsByEnvironment(this SubscriptionResource subscriptionResource, AzureLocation location, ClusterVersionsEnvironment environment, string clusterVersion, CancellationToken cancellationToken = default)
        {
            return GetMockableServiceFabricSubscriptionResource(subscriptionResource).GetClusterVersionsByEnvironment(location, environment, clusterVersion, cancellationToken);
        }

        /// <summary>
        /// Gets all available code versions for Service Fabric cluster resources by location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/clusterVersions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterVersions_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceFabricSubscriptionResource.GetClusterVersions(AzureLocation,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ClusterCodeVersionsResult" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ClusterCodeVersionsResult> GetClusterVersionsAsync(this SubscriptionResource subscriptionResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            return GetMockableServiceFabricSubscriptionResource(subscriptionResource).GetClusterVersionsAsync(location, cancellationToken);
        }

        /// <summary>
        /// Gets all available code versions for Service Fabric cluster resources by location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/clusterVersions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterVersions_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceFabricSubscriptionResource.GetClusterVersions(AzureLocation,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ClusterCodeVersionsResult" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ClusterCodeVersionsResult> GetClusterVersions(this SubscriptionResource subscriptionResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            return GetMockableServiceFabricSubscriptionResource(subscriptionResource).GetClusterVersions(location, cancellationToken);
        }

        /// <summary>
        /// Gets all available code versions for Service Fabric cluster resources by environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/environments/{environment}/clusterVersions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterVersions_ListByEnvironment</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceFabricSubscriptionResource.GetClusterVersionsByEnvironment(AzureLocation,ClusterVersionsEnvironment,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="environment"> The operating system of the cluster. The default means all. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ClusterCodeVersionsResult" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ClusterCodeVersionsResult> GetClusterVersionsByEnvironmentAsync(this SubscriptionResource subscriptionResource, AzureLocation location, ClusterVersionsEnvironment environment, CancellationToken cancellationToken = default)
        {
            return GetMockableServiceFabricSubscriptionResource(subscriptionResource).GetClusterVersionsByEnvironmentAsync(location, environment, cancellationToken);
        }

        /// <summary>
        /// Gets all available code versions for Service Fabric cluster resources by environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/environments/{environment}/clusterVersions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterVersions_ListByEnvironment</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceFabricSubscriptionResource.GetClusterVersionsByEnvironment(AzureLocation,ClusterVersionsEnvironment,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="environment"> The operating system of the cluster. The default means all. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ClusterCodeVersionsResult" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ClusterCodeVersionsResult> GetClusterVersionsByEnvironment(this SubscriptionResource subscriptionResource, AzureLocation location, ClusterVersionsEnvironment environment, CancellationToken cancellationToken = default)
        {
            return GetMockableServiceFabricSubscriptionResource(subscriptionResource).GetClusterVersionsByEnvironment(location, environment, cancellationToken);
        }
    }
}
