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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="ManagedInstanceAdministratorResource" /> and their operations.
    /// Each <see cref="ManagedInstanceAdministratorResource" /> in the collection will belong to the same instance of <see cref="ManagedInstanceResource" />.
    /// To get a <see cref="ManagedInstanceAdministratorCollection" /> instance call the GetManagedInstanceAdministrators method from an instance of <see cref="ManagedInstanceResource" />.
    /// </summary>
    public partial class ManagedInstanceAdministratorCollection : ArmCollection, IEnumerable<ManagedInstanceAdministratorResource>, IAsyncEnumerable<ManagedInstanceAdministratorResource>
    {
        private readonly ClientDiagnostics _managedInstanceAdministratorClientDiagnostics;
        private readonly ManagedInstanceAdministratorsRestOperations _managedInstanceAdministratorRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceAdministratorCollection"/> class for mocking. </summary>
        protected ManagedInstanceAdministratorCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceAdministratorCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ManagedInstanceAdministratorCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedInstanceAdministratorClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ManagedInstanceAdministratorResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ManagedInstanceAdministratorResource.ResourceType, out string managedInstanceAdministratorApiVersion);
            _managedInstanceAdministratorRestClient = new ManagedInstanceAdministratorsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managedInstanceAdministratorApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ManagedInstanceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ManagedInstanceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a managed instance administrator.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/administrators/{administratorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedInstanceAdministrators_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="administratorName"> The SqlAdministratorName to use. </param>
        /// <param name="data"> The requested administrator parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ManagedInstanceAdministratorResource>> CreateOrUpdateAsync(WaitUntil waitUntil, SqlAdministratorName administratorName, ManagedInstanceAdministratorData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managedInstanceAdministratorClientDiagnostics.CreateScope("ManagedInstanceAdministratorCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _managedInstanceAdministratorRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, administratorName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<ManagedInstanceAdministratorResource>(new ManagedInstanceAdministratorOperationSource(Client), _managedInstanceAdministratorClientDiagnostics, Pipeline, _managedInstanceAdministratorRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, administratorName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a managed instance administrator.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/administrators/{administratorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedInstanceAdministrators_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="administratorName"> The SqlAdministratorName to use. </param>
        /// <param name="data"> The requested administrator parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ManagedInstanceAdministratorResource> CreateOrUpdate(WaitUntil waitUntil, SqlAdministratorName administratorName, ManagedInstanceAdministratorData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managedInstanceAdministratorClientDiagnostics.CreateScope("ManagedInstanceAdministratorCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _managedInstanceAdministratorRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, administratorName, data, cancellationToken);
                var operation = new SqlArmOperation<ManagedInstanceAdministratorResource>(new ManagedInstanceAdministratorOperationSource(Client), _managedInstanceAdministratorClientDiagnostics, Pipeline, _managedInstanceAdministratorRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, administratorName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a managed instance administrator.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/administrators/{administratorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedInstanceAdministrators_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="administratorName"> The SqlAdministratorName to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ManagedInstanceAdministratorResource>> GetAsync(SqlAdministratorName administratorName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceAdministratorClientDiagnostics.CreateScope("ManagedInstanceAdministratorCollection.Get");
            scope.Start();
            try
            {
                var response = await _managedInstanceAdministratorRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, administratorName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceAdministratorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a managed instance administrator.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/administrators/{administratorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedInstanceAdministrators_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="administratorName"> The SqlAdministratorName to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedInstanceAdministratorResource> Get(SqlAdministratorName administratorName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceAdministratorClientDiagnostics.CreateScope("ManagedInstanceAdministratorCollection.Get");
            scope.Start();
            try
            {
                var response = _managedInstanceAdministratorRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, administratorName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceAdministratorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of managed instance administrators.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/administrators</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedInstanceAdministrators_ListByInstance</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedInstanceAdministratorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedInstanceAdministratorResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _managedInstanceAdministratorRestClient.CreateListByInstanceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _managedInstanceAdministratorRestClient.CreateListByInstanceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new ManagedInstanceAdministratorResource(Client, ManagedInstanceAdministratorData.DeserializeManagedInstanceAdministratorData(e)), _managedInstanceAdministratorClientDiagnostics, Pipeline, "ManagedInstanceAdministratorCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of managed instance administrators.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/administrators</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedInstanceAdministrators_ListByInstance</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedInstanceAdministratorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedInstanceAdministratorResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _managedInstanceAdministratorRestClient.CreateListByInstanceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _managedInstanceAdministratorRestClient.CreateListByInstanceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new ManagedInstanceAdministratorResource(Client, ManagedInstanceAdministratorData.DeserializeManagedInstanceAdministratorData(e)), _managedInstanceAdministratorClientDiagnostics, Pipeline, "ManagedInstanceAdministratorCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/administrators/{administratorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedInstanceAdministrators_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="administratorName"> The SqlAdministratorName to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(SqlAdministratorName administratorName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceAdministratorClientDiagnostics.CreateScope("ManagedInstanceAdministratorCollection.Exists");
            scope.Start();
            try
            {
                var response = await _managedInstanceAdministratorRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, administratorName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/administrators/{administratorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedInstanceAdministrators_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="administratorName"> The SqlAdministratorName to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(SqlAdministratorName administratorName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceAdministratorClientDiagnostics.CreateScope("ManagedInstanceAdministratorCollection.Exists");
            scope.Start();
            try
            {
                var response = _managedInstanceAdministratorRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, administratorName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ManagedInstanceAdministratorResource> IEnumerable<ManagedInstanceAdministratorResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ManagedInstanceAdministratorResource> IAsyncEnumerable<ManagedInstanceAdministratorResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
