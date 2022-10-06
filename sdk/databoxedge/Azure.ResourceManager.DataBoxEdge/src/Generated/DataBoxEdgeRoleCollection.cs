// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.DataBoxEdge
{
    /// <summary>
    /// A class representing a collection of <see cref="DataBoxEdgeRoleResource" /> and their operations.
    /// Each <see cref="DataBoxEdgeRoleResource" /> in the collection will belong to the same instance of <see cref="DataBoxEdgeDeviceResource" />.
    /// To get a <see cref="DataBoxEdgeRoleCollection" /> instance call the GetDataBoxEdgeRoles method from an instance of <see cref="DataBoxEdgeDeviceResource" />.
    /// </summary>
    public partial class DataBoxEdgeRoleCollection : ArmCollection, IEnumerable<DataBoxEdgeRoleResource>, IAsyncEnumerable<DataBoxEdgeRoleResource>
    {
        private readonly ClientDiagnostics _dataBoxEdgeRoleRolesClientDiagnostics;
        private readonly RolesRestOperations _dataBoxEdgeRoleRolesRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataBoxEdgeRoleCollection"/> class for mocking. </summary>
        protected DataBoxEdgeRoleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataBoxEdgeRoleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataBoxEdgeRoleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataBoxEdgeRoleRolesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataBoxEdge", DataBoxEdgeRoleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataBoxEdgeRoleResource.ResourceType, out string dataBoxEdgeRoleRolesApiVersion);
            _dataBoxEdgeRoleRolesRestClient = new RolesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataBoxEdgeRoleRolesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DataBoxEdgeDeviceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DataBoxEdgeDeviceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a role.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/roles/{name}
        /// Operation Id: Roles_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> The role name. </param>
        /// <param name="data"> The role properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DataBoxEdgeRoleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, DataBoxEdgeRoleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataBoxEdgeRoleRolesClientDiagnostics.CreateScope("DataBoxEdgeRoleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dataBoxEdgeRoleRolesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, cancellationToken).ConfigureAwait(false);
                var operation = new DataBoxEdgeArmOperation<DataBoxEdgeRoleResource>(new DataBoxEdgeRoleOperationSource(Client), _dataBoxEdgeRoleRolesClientDiagnostics, Pipeline, _dataBoxEdgeRoleRolesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update a role.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/roles/{name}
        /// Operation Id: Roles_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> The role name. </param>
        /// <param name="data"> The role properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DataBoxEdgeRoleResource> CreateOrUpdate(WaitUntil waitUntil, string name, DataBoxEdgeRoleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataBoxEdgeRoleRolesClientDiagnostics.CreateScope("DataBoxEdgeRoleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dataBoxEdgeRoleRolesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, cancellationToken);
                var operation = new DataBoxEdgeArmOperation<DataBoxEdgeRoleResource>(new DataBoxEdgeRoleOperationSource(Client), _dataBoxEdgeRoleRolesClientDiagnostics, Pipeline, _dataBoxEdgeRoleRolesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a specific role by name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/roles/{name}
        /// Operation Id: Roles_Get
        /// </summary>
        /// <param name="name"> The role name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<DataBoxEdgeRoleResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _dataBoxEdgeRoleRolesClientDiagnostics.CreateScope("DataBoxEdgeRoleCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataBoxEdgeRoleRolesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataBoxEdgeRoleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a specific role by name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/roles/{name}
        /// Operation Id: Roles_Get
        /// </summary>
        /// <param name="name"> The role name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<DataBoxEdgeRoleResource> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _dataBoxEdgeRoleRolesClientDiagnostics.CreateScope("DataBoxEdgeRoleCollection.Get");
            scope.Start();
            try
            {
                var response = _dataBoxEdgeRoleRolesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataBoxEdgeRoleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the roles configured in a Data Box Edge/Data Box Gateway device.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/roles
        /// Operation Id: Roles_ListByDataBoxEdgeDevice
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataBoxEdgeRoleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataBoxEdgeRoleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DataBoxEdgeRoleResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _dataBoxEdgeRoleRolesClientDiagnostics.CreateScope("DataBoxEdgeRoleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _dataBoxEdgeRoleRolesRestClient.ListByDataBoxEdgeDeviceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DataBoxEdgeRoleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DataBoxEdgeRoleResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _dataBoxEdgeRoleRolesClientDiagnostics.CreateScope("DataBoxEdgeRoleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _dataBoxEdgeRoleRolesRestClient.ListByDataBoxEdgeDeviceNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DataBoxEdgeRoleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists all the roles configured in a Data Box Edge/Data Box Gateway device.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/roles
        /// Operation Id: Roles_ListByDataBoxEdgeDevice
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataBoxEdgeRoleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataBoxEdgeRoleResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<DataBoxEdgeRoleResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _dataBoxEdgeRoleRolesClientDiagnostics.CreateScope("DataBoxEdgeRoleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _dataBoxEdgeRoleRolesRestClient.ListByDataBoxEdgeDevice(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DataBoxEdgeRoleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DataBoxEdgeRoleResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _dataBoxEdgeRoleRolesClientDiagnostics.CreateScope("DataBoxEdgeRoleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _dataBoxEdgeRoleRolesRestClient.ListByDataBoxEdgeDeviceNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DataBoxEdgeRoleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/roles/{name}
        /// Operation Id: Roles_Get
        /// </summary>
        /// <param name="name"> The role name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _dataBoxEdgeRoleRolesClientDiagnostics.CreateScope("DataBoxEdgeRoleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataBoxEdgeRoleRolesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/roles/{name}
        /// Operation Id: Roles_Get
        /// </summary>
        /// <param name="name"> The role name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _dataBoxEdgeRoleRolesClientDiagnostics.CreateScope("DataBoxEdgeRoleCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataBoxEdgeRoleRolesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataBoxEdgeRoleResource> IEnumerable<DataBoxEdgeRoleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataBoxEdgeRoleResource> IAsyncEnumerable<DataBoxEdgeRoleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
