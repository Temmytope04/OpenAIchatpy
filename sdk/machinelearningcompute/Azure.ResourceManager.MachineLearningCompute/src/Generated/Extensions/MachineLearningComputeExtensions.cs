// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.MachineLearningCompute.Mocking;
using Azure.ResourceManager.MachineLearningCompute.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.MachineLearningCompute
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.MachineLearningCompute. </summary>
    public static partial class MachineLearningComputeExtensions
    {
        private static MockableMachineLearningComputeArmClient GetMockableMachineLearningComputeArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableMachineLearningComputeArmClient(client0));
        }

        private static MockableMachineLearningComputeResourceGroupResource GetMockableMachineLearningComputeResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableMachineLearningComputeResourceGroupResource(client, resource.Id));
        }

        private static MockableMachineLearningComputeSubscriptionResource GetMockableMachineLearningComputeSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableMachineLearningComputeSubscriptionResource(client, resource.Id));
        }

        private static MockableMachineLearningComputeTenantResource GetMockableMachineLearningComputeTenantResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableMachineLearningComputeTenantResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing an <see cref="OperationalizationClusterResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="OperationalizationClusterResource.CreateResourceIdentifier" /> to create an <see cref="OperationalizationClusterResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableMachineLearningComputeArmClient.GetOperationalizationClusterResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="OperationalizationClusterResource"/> object. </returns>
        public static OperationalizationClusterResource GetOperationalizationClusterResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableMachineLearningComputeArmClient(client).GetOperationalizationClusterResource(id);
        }

        /// <summary>
        /// Gets a collection of OperationalizationClusterResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableMachineLearningComputeResourceGroupResource.GetOperationalizationClusters()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of OperationalizationClusterResources and their operations over a OperationalizationClusterResource. </returns>
        public static OperationalizationClusterCollection GetOperationalizationClusters(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableMachineLearningComputeResourceGroupResource(resourceGroupResource).GetOperationalizationClusters();
        }

        /// <summary>
        /// Gets the operationalization cluster resource view. Note that the credentials are not returned by this call. Call ListKeys to get them.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningCompute/operationalizationClusters/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OperationalizationClusters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-08-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="OperationalizationClusterResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableMachineLearningComputeResourceGroupResource.GetOperationalizationClusterAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="clusterName"> The name of the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="clusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<OperationalizationClusterResource>> GetOperationalizationClusterAsync(this ResourceGroupResource resourceGroupResource, string clusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableMachineLearningComputeResourceGroupResource(resourceGroupResource).GetOperationalizationClusterAsync(clusterName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the operationalization cluster resource view. Note that the credentials are not returned by this call. Call ListKeys to get them.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningCompute/operationalizationClusters/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OperationalizationClusters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-08-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="OperationalizationClusterResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableMachineLearningComputeResourceGroupResource.GetOperationalizationCluster(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="clusterName"> The name of the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="clusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<OperationalizationClusterResource> GetOperationalizationCluster(this ResourceGroupResource resourceGroupResource, string clusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableMachineLearningComputeResourceGroupResource(resourceGroupResource).GetOperationalizationCluster(clusterName, cancellationToken);
        }

        /// <summary>
        /// Gets the operationalization clusters in the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MachineLearningCompute/operationalizationClusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OperationalizationClusters_ListBySubscriptionId</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-08-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="OperationalizationClusterResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableMachineLearningComputeSubscriptionResource.GetOperationalizationClusters(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="skiptoken"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="OperationalizationClusterResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<OperationalizationClusterResource> GetOperationalizationClustersAsync(this SubscriptionResource subscriptionResource, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableMachineLearningComputeSubscriptionResource(subscriptionResource).GetOperationalizationClustersAsync(skiptoken, cancellationToken);
        }

        /// <summary>
        /// Gets the operationalization clusters in the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MachineLearningCompute/operationalizationClusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OperationalizationClusters_ListBySubscriptionId</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-08-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="OperationalizationClusterResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableMachineLearningComputeSubscriptionResource.GetOperationalizationClusters(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="skiptoken"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="OperationalizationClusterResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<OperationalizationClusterResource> GetOperationalizationClusters(this SubscriptionResource subscriptionResource, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableMachineLearningComputeSubscriptionResource(subscriptionResource).GetOperationalizationClusters(skiptoken, cancellationToken);
        }

        /// <summary>
        /// Gets all available operations.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.MachineLearningCompute/operations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MachineLearningCompute_ListAvailableOperations</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-08-01-preview</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableMachineLearningComputeTenantResource.GetAvailableOperationsMachineLearningComputes(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="ResourceOperation"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ResourceOperation> GetAvailableOperationsMachineLearningComputesAsync(this TenantResource tenantResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tenantResource, nameof(tenantResource));

            return GetMockableMachineLearningComputeTenantResource(tenantResource).GetAvailableOperationsMachineLearningComputesAsync(cancellationToken);
        }

        /// <summary>
        /// Gets all available operations.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.MachineLearningCompute/operations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MachineLearningCompute_ListAvailableOperations</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-08-01-preview</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableMachineLearningComputeTenantResource.GetAvailableOperationsMachineLearningComputes(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantResource"/> is null. </exception>
        /// <returns> A collection of <see cref="ResourceOperation"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ResourceOperation> GetAvailableOperationsMachineLearningComputes(this TenantResource tenantResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tenantResource, nameof(tenantResource));

            return GetMockableMachineLearningComputeTenantResource(tenantResource).GetAvailableOperationsMachineLearningComputes(cancellationToken);
        }
    }
}
