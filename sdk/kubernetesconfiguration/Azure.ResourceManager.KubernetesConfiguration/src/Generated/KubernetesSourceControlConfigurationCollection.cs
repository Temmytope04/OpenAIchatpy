// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.KubernetesConfiguration
{
    /// <summary>
    /// A class representing a collection of <see cref="KubernetesSourceControlConfigurationResource" /> and their operations.
    /// Each <see cref="KubernetesSourceControlConfigurationResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="KubernetesSourceControlConfigurationCollection" /> instance call the GetKubernetesSourceControlConfigurations method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class KubernetesSourceControlConfigurationCollection : ArmCollection, IEnumerable<KubernetesSourceControlConfigurationResource>, IAsyncEnumerable<KubernetesSourceControlConfigurationResource>
    {
        private readonly ClientDiagnostics _kubernetesSourceControlConfigurationSourceControlConfigurationsClientDiagnostics;
        private readonly SourceControlConfigurationsRestOperations _kubernetesSourceControlConfigurationSourceControlConfigurationsRestClient;
        private readonly string _clusterRp;
        private readonly string _clusterResourceName;
        private readonly string _clusterName;

        /// <summary> Initializes a new instance of the <see cref="KubernetesSourceControlConfigurationCollection"/> class for mocking. </summary>
        protected KubernetesSourceControlConfigurationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="KubernetesSourceControlConfigurationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="clusterRp"> The Kubernetes cluster RP - i.e. Microsoft.ContainerService, Microsoft.Kubernetes, Microsoft.HybridContainerService. </param>
        /// <param name="clusterResourceName"> The Kubernetes cluster resource name - i.e. managedClusters, connectedClusters, provisionedClusters. </param>
        /// <param name="clusterName"> The name of the kubernetes cluster. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterRp"/>, <paramref name="clusterResourceName"/> or <paramref name="clusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="clusterRp"/>, <paramref name="clusterResourceName"/> or <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        internal KubernetesSourceControlConfigurationCollection(ArmClient client, ResourceIdentifier id, string clusterRp, string clusterResourceName, string clusterName) : base(client, id)
        {
            _clusterRp = clusterRp;
            _clusterResourceName = clusterResourceName;
            _clusterName = clusterName;
            _kubernetesSourceControlConfigurationSourceControlConfigurationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.KubernetesConfiguration", KubernetesSourceControlConfigurationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(KubernetesSourceControlConfigurationResource.ResourceType, out string kubernetesSourceControlConfigurationSourceControlConfigurationsApiVersion);
            _kubernetesSourceControlConfigurationSourceControlConfigurationsRestClient = new SourceControlConfigurationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, kubernetesSourceControlConfigurationSourceControlConfigurationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a new Kubernetes Source Control Configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{clusterRp}/{clusterResourceName}/{clusterName}/providers/Microsoft.KubernetesConfiguration/sourceControlConfigurations/{sourceControlConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SourceControlConfigurations_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sourceControlConfigurationName"> Name of the Source Control Configuration. </param>
        /// <param name="data"> Properties necessary to Create KubernetesConfiguration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceControlConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlConfigurationName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<KubernetesSourceControlConfigurationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string sourceControlConfigurationName, KubernetesSourceControlConfigurationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceControlConfigurationName, nameof(sourceControlConfigurationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _kubernetesSourceControlConfigurationSourceControlConfigurationsClientDiagnostics.CreateScope("KubernetesSourceControlConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _kubernetesSourceControlConfigurationSourceControlConfigurationsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, _clusterRp, _clusterResourceName, _clusterName, sourceControlConfigurationName, data, cancellationToken).ConfigureAwait(false);
                var operation = new KubernetesConfigurationArmOperation<KubernetesSourceControlConfigurationResource>(Response.FromValue(new KubernetesSourceControlConfigurationResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create a new Kubernetes Source Control Configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{clusterRp}/{clusterResourceName}/{clusterName}/providers/Microsoft.KubernetesConfiguration/sourceControlConfigurations/{sourceControlConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SourceControlConfigurations_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sourceControlConfigurationName"> Name of the Source Control Configuration. </param>
        /// <param name="data"> Properties necessary to Create KubernetesConfiguration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceControlConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlConfigurationName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<KubernetesSourceControlConfigurationResource> CreateOrUpdate(WaitUntil waitUntil, string sourceControlConfigurationName, KubernetesSourceControlConfigurationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceControlConfigurationName, nameof(sourceControlConfigurationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _kubernetesSourceControlConfigurationSourceControlConfigurationsClientDiagnostics.CreateScope("KubernetesSourceControlConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _kubernetesSourceControlConfigurationSourceControlConfigurationsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, _clusterRp, _clusterResourceName, _clusterName, sourceControlConfigurationName, data, cancellationToken);
                var operation = new KubernetesConfigurationArmOperation<KubernetesSourceControlConfigurationResource>(Response.FromValue(new KubernetesSourceControlConfigurationResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets details of the Source Control Configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{clusterRp}/{clusterResourceName}/{clusterName}/providers/Microsoft.KubernetesConfiguration/sourceControlConfigurations/{sourceControlConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SourceControlConfigurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sourceControlConfigurationName"> Name of the Source Control Configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceControlConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlConfigurationName"/> is null. </exception>
        public virtual async Task<Response<KubernetesSourceControlConfigurationResource>> GetAsync(string sourceControlConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceControlConfigurationName, nameof(sourceControlConfigurationName));

            using var scope = _kubernetesSourceControlConfigurationSourceControlConfigurationsClientDiagnostics.CreateScope("KubernetesSourceControlConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = await _kubernetesSourceControlConfigurationSourceControlConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _clusterRp, _clusterResourceName, _clusterName, sourceControlConfigurationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new KubernetesSourceControlConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets details of the Source Control Configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{clusterRp}/{clusterResourceName}/{clusterName}/providers/Microsoft.KubernetesConfiguration/sourceControlConfigurations/{sourceControlConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SourceControlConfigurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sourceControlConfigurationName"> Name of the Source Control Configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceControlConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlConfigurationName"/> is null. </exception>
        public virtual Response<KubernetesSourceControlConfigurationResource> Get(string sourceControlConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceControlConfigurationName, nameof(sourceControlConfigurationName));

            using var scope = _kubernetesSourceControlConfigurationSourceControlConfigurationsClientDiagnostics.CreateScope("KubernetesSourceControlConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = _kubernetesSourceControlConfigurationSourceControlConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _clusterRp, _clusterResourceName, _clusterName, sourceControlConfigurationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new KubernetesSourceControlConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all Source Control Configurations.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{clusterRp}/{clusterResourceName}/{clusterName}/providers/Microsoft.KubernetesConfiguration/sourceControlConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SourceControlConfigurations_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="KubernetesSourceControlConfigurationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<KubernetesSourceControlConfigurationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _kubernetesSourceControlConfigurationSourceControlConfigurationsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, _clusterRp, _clusterResourceName, _clusterName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _kubernetesSourceControlConfigurationSourceControlConfigurationsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _clusterRp, _clusterResourceName, _clusterName);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new KubernetesSourceControlConfigurationResource(Client, KubernetesSourceControlConfigurationData.DeserializeKubernetesSourceControlConfigurationData(e)), _kubernetesSourceControlConfigurationSourceControlConfigurationsClientDiagnostics, Pipeline, "KubernetesSourceControlConfigurationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all Source Control Configurations.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{clusterRp}/{clusterResourceName}/{clusterName}/providers/Microsoft.KubernetesConfiguration/sourceControlConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SourceControlConfigurations_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="KubernetesSourceControlConfigurationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<KubernetesSourceControlConfigurationResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _kubernetesSourceControlConfigurationSourceControlConfigurationsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, _clusterRp, _clusterResourceName, _clusterName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _kubernetesSourceControlConfigurationSourceControlConfigurationsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _clusterRp, _clusterResourceName, _clusterName);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new KubernetesSourceControlConfigurationResource(Client, KubernetesSourceControlConfigurationData.DeserializeKubernetesSourceControlConfigurationData(e)), _kubernetesSourceControlConfigurationSourceControlConfigurationsClientDiagnostics, Pipeline, "KubernetesSourceControlConfigurationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{clusterRp}/{clusterResourceName}/{clusterName}/providers/Microsoft.KubernetesConfiguration/sourceControlConfigurations/{sourceControlConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SourceControlConfigurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sourceControlConfigurationName"> Name of the Source Control Configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceControlConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlConfigurationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string sourceControlConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceControlConfigurationName, nameof(sourceControlConfigurationName));

            using var scope = _kubernetesSourceControlConfigurationSourceControlConfigurationsClientDiagnostics.CreateScope("KubernetesSourceControlConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _kubernetesSourceControlConfigurationSourceControlConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _clusterRp, _clusterResourceName, _clusterName, sourceControlConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{clusterRp}/{clusterResourceName}/{clusterName}/providers/Microsoft.KubernetesConfiguration/sourceControlConfigurations/{sourceControlConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SourceControlConfigurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sourceControlConfigurationName"> Name of the Source Control Configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceControlConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlConfigurationName"/> is null. </exception>
        public virtual Response<bool> Exists(string sourceControlConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceControlConfigurationName, nameof(sourceControlConfigurationName));

            using var scope = _kubernetesSourceControlConfigurationSourceControlConfigurationsClientDiagnostics.CreateScope("KubernetesSourceControlConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = _kubernetesSourceControlConfigurationSourceControlConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _clusterRp, _clusterResourceName, _clusterName, sourceControlConfigurationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<KubernetesSourceControlConfigurationResource> IEnumerable<KubernetesSourceControlConfigurationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<KubernetesSourceControlConfigurationResource> IAsyncEnumerable<KubernetesSourceControlConfigurationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
