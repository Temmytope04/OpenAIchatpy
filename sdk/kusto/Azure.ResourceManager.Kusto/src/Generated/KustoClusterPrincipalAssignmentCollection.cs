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
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Kusto
{
    /// <summary>
    /// A class representing a collection of <see cref="KustoClusterPrincipalAssignmentResource" /> and their operations.
    /// Each <see cref="KustoClusterPrincipalAssignmentResource" /> in the collection will belong to the same instance of <see cref="KustoClusterResource" />.
    /// To get a <see cref="KustoClusterPrincipalAssignmentCollection" /> instance call the GetKustoClusterPrincipalAssignments method from an instance of <see cref="KustoClusterResource" />.
    /// </summary>
    public partial class KustoClusterPrincipalAssignmentCollection : ArmCollection, IEnumerable<KustoClusterPrincipalAssignmentResource>, IAsyncEnumerable<KustoClusterPrincipalAssignmentResource>
    {
        private readonly ClientDiagnostics _kustoClusterPrincipalAssignmentClusterPrincipalAssignmentsClientDiagnostics;
        private readonly ClusterPrincipalAssignmentsRestOperations _kustoClusterPrincipalAssignmentClusterPrincipalAssignmentsRestClient;

        /// <summary> Initializes a new instance of the <see cref="KustoClusterPrincipalAssignmentCollection"/> class for mocking. </summary>
        protected KustoClusterPrincipalAssignmentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="KustoClusterPrincipalAssignmentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal KustoClusterPrincipalAssignmentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _kustoClusterPrincipalAssignmentClusterPrincipalAssignmentsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Kusto", KustoClusterPrincipalAssignmentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(KustoClusterPrincipalAssignmentResource.ResourceType, out string kustoClusterPrincipalAssignmentClusterPrincipalAssignmentsApiVersion);
            _kustoClusterPrincipalAssignmentClusterPrincipalAssignmentsRestClient = new ClusterPrincipalAssignmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, kustoClusterPrincipalAssignmentClusterPrincipalAssignmentsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != KustoClusterResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, KustoClusterResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a Kusto cluster principalAssignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/principalAssignments/{principalAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterPrincipalAssignments_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="principalAssignmentName"> The name of the Kusto principalAssignment. </param>
        /// <param name="data"> The Kusto cluster principalAssignment's parameters supplied for the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="principalAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="principalAssignmentName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<KustoClusterPrincipalAssignmentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string principalAssignmentName, KustoClusterPrincipalAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(principalAssignmentName, nameof(principalAssignmentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _kustoClusterPrincipalAssignmentClusterPrincipalAssignmentsClientDiagnostics.CreateScope("KustoClusterPrincipalAssignmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _kustoClusterPrincipalAssignmentClusterPrincipalAssignmentsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, principalAssignmentName, data, cancellationToken).ConfigureAwait(false);
                var operation = new KustoArmOperation<KustoClusterPrincipalAssignmentResource>(new KustoClusterPrincipalAssignmentOperationSource(Client), _kustoClusterPrincipalAssignmentClusterPrincipalAssignmentsClientDiagnostics, Pipeline, _kustoClusterPrincipalAssignmentClusterPrincipalAssignmentsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, principalAssignmentName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create a Kusto cluster principalAssignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/principalAssignments/{principalAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterPrincipalAssignments_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="principalAssignmentName"> The name of the Kusto principalAssignment. </param>
        /// <param name="data"> The Kusto cluster principalAssignment's parameters supplied for the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="principalAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="principalAssignmentName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<KustoClusterPrincipalAssignmentResource> CreateOrUpdate(WaitUntil waitUntil, string principalAssignmentName, KustoClusterPrincipalAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(principalAssignmentName, nameof(principalAssignmentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _kustoClusterPrincipalAssignmentClusterPrincipalAssignmentsClientDiagnostics.CreateScope("KustoClusterPrincipalAssignmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _kustoClusterPrincipalAssignmentClusterPrincipalAssignmentsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, principalAssignmentName, data, cancellationToken);
                var operation = new KustoArmOperation<KustoClusterPrincipalAssignmentResource>(new KustoClusterPrincipalAssignmentOperationSource(Client), _kustoClusterPrincipalAssignmentClusterPrincipalAssignmentsClientDiagnostics, Pipeline, _kustoClusterPrincipalAssignmentClusterPrincipalAssignmentsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, principalAssignmentName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a Kusto cluster principalAssignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/principalAssignments/{principalAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterPrincipalAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="principalAssignmentName"> The name of the Kusto principalAssignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="principalAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="principalAssignmentName"/> is null. </exception>
        public virtual async Task<Response<KustoClusterPrincipalAssignmentResource>> GetAsync(string principalAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(principalAssignmentName, nameof(principalAssignmentName));

            using var scope = _kustoClusterPrincipalAssignmentClusterPrincipalAssignmentsClientDiagnostics.CreateScope("KustoClusterPrincipalAssignmentCollection.Get");
            scope.Start();
            try
            {
                var response = await _kustoClusterPrincipalAssignmentClusterPrincipalAssignmentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, principalAssignmentName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new KustoClusterPrincipalAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a Kusto cluster principalAssignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/principalAssignments/{principalAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterPrincipalAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="principalAssignmentName"> The name of the Kusto principalAssignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="principalAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="principalAssignmentName"/> is null. </exception>
        public virtual Response<KustoClusterPrincipalAssignmentResource> Get(string principalAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(principalAssignmentName, nameof(principalAssignmentName));

            using var scope = _kustoClusterPrincipalAssignmentClusterPrincipalAssignmentsClientDiagnostics.CreateScope("KustoClusterPrincipalAssignmentCollection.Get");
            scope.Start();
            try
            {
                var response = _kustoClusterPrincipalAssignmentClusterPrincipalAssignmentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, principalAssignmentName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new KustoClusterPrincipalAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all Kusto cluster principalAssignments.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/principalAssignments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterPrincipalAssignments_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="KustoClusterPrincipalAssignmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<KustoClusterPrincipalAssignmentResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _kustoClusterPrincipalAssignmentClusterPrincipalAssignmentsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, (e, o) => new KustoClusterPrincipalAssignmentResource(Client, KustoClusterPrincipalAssignmentData.DeserializeKustoClusterPrincipalAssignmentData(e)), _kustoClusterPrincipalAssignmentClusterPrincipalAssignmentsClientDiagnostics, Pipeline, "KustoClusterPrincipalAssignmentCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists all Kusto cluster principalAssignments.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/principalAssignments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterPrincipalAssignments_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="KustoClusterPrincipalAssignmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<KustoClusterPrincipalAssignmentResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _kustoClusterPrincipalAssignmentClusterPrincipalAssignmentsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, (e, o) => new KustoClusterPrincipalAssignmentResource(Client, KustoClusterPrincipalAssignmentData.DeserializeKustoClusterPrincipalAssignmentData(e)), _kustoClusterPrincipalAssignmentClusterPrincipalAssignmentsClientDiagnostics, Pipeline, "KustoClusterPrincipalAssignmentCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/principalAssignments/{principalAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterPrincipalAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="principalAssignmentName"> The name of the Kusto principalAssignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="principalAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="principalAssignmentName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string principalAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(principalAssignmentName, nameof(principalAssignmentName));

            using var scope = _kustoClusterPrincipalAssignmentClusterPrincipalAssignmentsClientDiagnostics.CreateScope("KustoClusterPrincipalAssignmentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _kustoClusterPrincipalAssignmentClusterPrincipalAssignmentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, principalAssignmentName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/principalAssignments/{principalAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterPrincipalAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="principalAssignmentName"> The name of the Kusto principalAssignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="principalAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="principalAssignmentName"/> is null. </exception>
        public virtual Response<bool> Exists(string principalAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(principalAssignmentName, nameof(principalAssignmentName));

            using var scope = _kustoClusterPrincipalAssignmentClusterPrincipalAssignmentsClientDiagnostics.CreateScope("KustoClusterPrincipalAssignmentCollection.Exists");
            scope.Start();
            try
            {
                var response = _kustoClusterPrincipalAssignmentClusterPrincipalAssignmentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, principalAssignmentName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/principalAssignments/{principalAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterPrincipalAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="principalAssignmentName"> The name of the Kusto principalAssignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="principalAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="principalAssignmentName"/> is null. </exception>
        public virtual async Task<NullableResponse<KustoClusterPrincipalAssignmentResource>> GetIfExistsAsync(string principalAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(principalAssignmentName, nameof(principalAssignmentName));

            using var scope = _kustoClusterPrincipalAssignmentClusterPrincipalAssignmentsClientDiagnostics.CreateScope("KustoClusterPrincipalAssignmentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _kustoClusterPrincipalAssignmentClusterPrincipalAssignmentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, principalAssignmentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<KustoClusterPrincipalAssignmentResource>(response.GetRawResponse());
                return Response.FromValue(new KustoClusterPrincipalAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/principalAssignments/{principalAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterPrincipalAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="principalAssignmentName"> The name of the Kusto principalAssignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="principalAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="principalAssignmentName"/> is null. </exception>
        public virtual NullableResponse<KustoClusterPrincipalAssignmentResource> GetIfExists(string principalAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(principalAssignmentName, nameof(principalAssignmentName));

            using var scope = _kustoClusterPrincipalAssignmentClusterPrincipalAssignmentsClientDiagnostics.CreateScope("KustoClusterPrincipalAssignmentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _kustoClusterPrincipalAssignmentClusterPrincipalAssignmentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, principalAssignmentName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<KustoClusterPrincipalAssignmentResource>(response.GetRawResponse());
                return Response.FromValue(new KustoClusterPrincipalAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<KustoClusterPrincipalAssignmentResource> IEnumerable<KustoClusterPrincipalAssignmentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<KustoClusterPrincipalAssignmentResource> IAsyncEnumerable<KustoClusterPrincipalAssignmentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
