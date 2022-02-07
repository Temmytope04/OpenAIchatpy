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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    /// <summary> A class representing collection of VMwareHost and their operations over its parent. </summary>
    public partial class VMwareHostCollection : ArmCollection, IEnumerable<VMwareHost>, IAsyncEnumerable<VMwareHost>
    {
        private readonly ClientDiagnostics _vMwareHostHostsClientDiagnostics;
        private readonly HostsRestOperations _vMwareHostHostsRestClient;

        /// <summary> Initializes a new instance of the <see cref="VMwareHostCollection"/> class for mocking. </summary>
        protected VMwareHostCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VMwareHostCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VMwareHostCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _vMwareHostHostsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ConnectedVMwarevSphere", VMwareHost.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(VMwareHost.ResourceType, out string vMwareHostHostsApiVersion);
            _vMwareHostHostsRestClient = new HostsRestOperations(_vMwareHostHostsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, vMwareHostHostsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/hosts/{hostName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Hosts_Create
        /// <summary> Create Or Update host. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="hostName"> Name of the host. </param>
        /// <param name="body"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> is null. </exception>
        public async virtual Task<ArmOperation<VMwareHost>> CreateOrUpdateAsync(bool waitForCompletion, string hostName, VMwareHostData body = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostName, nameof(hostName));

            using var scope = _vMwareHostHostsClientDiagnostics.CreateScope("VMwareHostCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _vMwareHostHostsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, hostName, body, cancellationToken).ConfigureAwait(false);
                var operation = new ConnectedVMwarevSphereArmOperation<VMwareHost>(new VMwareHostOperationSource(Client), _vMwareHostHostsClientDiagnostics, Pipeline, _vMwareHostHostsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, hostName, body).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/hosts/{hostName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Hosts_Create
        /// <summary> Create Or Update host. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="hostName"> Name of the host. </param>
        /// <param name="body"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> is null. </exception>
        public virtual ArmOperation<VMwareHost> CreateOrUpdate(bool waitForCompletion, string hostName, VMwareHostData body = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostName, nameof(hostName));

            using var scope = _vMwareHostHostsClientDiagnostics.CreateScope("VMwareHostCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _vMwareHostHostsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, hostName, body, cancellationToken);
                var operation = new ConnectedVMwarevSphereArmOperation<VMwareHost>(new VMwareHostOperationSource(Client), _vMwareHostHostsClientDiagnostics, Pipeline, _vMwareHostHostsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, hostName, body).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/hosts/{hostName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Hosts_Get
        /// <summary> Implements host GET method. </summary>
        /// <param name="hostName"> Name of the host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> is null. </exception>
        public async virtual Task<Response<VMwareHost>> GetAsync(string hostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostName, nameof(hostName));

            using var scope = _vMwareHostHostsClientDiagnostics.CreateScope("VMwareHostCollection.Get");
            scope.Start();
            try
            {
                var response = await _vMwareHostHostsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, hostName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _vMwareHostHostsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VMwareHost(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/hosts/{hostName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Hosts_Get
        /// <summary> Implements host GET method. </summary>
        /// <param name="hostName"> Name of the host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> is null. </exception>
        public virtual Response<VMwareHost> Get(string hostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostName, nameof(hostName));

            using var scope = _vMwareHostHostsClientDiagnostics.CreateScope("VMwareHostCollection.Get");
            scope.Start();
            try
            {
                var response = _vMwareHostHostsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, hostName, cancellationToken);
                if (response.Value == null)
                    throw _vMwareHostHostsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VMwareHost(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/hosts
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Hosts_ListByResourceGroup
        /// <summary> List of hosts in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VMwareHost" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VMwareHost> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VMwareHost>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _vMwareHostHostsClientDiagnostics.CreateScope("VMwareHostCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _vMwareHostHostsRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VMwareHost(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VMwareHost>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _vMwareHostHostsClientDiagnostics.CreateScope("VMwareHostCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _vMwareHostHostsRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VMwareHost(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/hosts
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Hosts_ListByResourceGroup
        /// <summary> List of hosts in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VMwareHost" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VMwareHost> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VMwareHost> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _vMwareHostHostsClientDiagnostics.CreateScope("VMwareHostCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _vMwareHostHostsRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VMwareHost(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VMwareHost> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _vMwareHostHostsClientDiagnostics.CreateScope("VMwareHostCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _vMwareHostHostsRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VMwareHost(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/hosts/{hostName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Hosts_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="hostName"> Name of the host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string hostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostName, nameof(hostName));

            using var scope = _vMwareHostHostsClientDiagnostics.CreateScope("VMwareHostCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(hostName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/hosts/{hostName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Hosts_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="hostName"> Name of the host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> is null. </exception>
        public virtual Response<bool> Exists(string hostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostName, nameof(hostName));

            using var scope = _vMwareHostHostsClientDiagnostics.CreateScope("VMwareHostCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(hostName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/hosts/{hostName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Hosts_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="hostName"> Name of the host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> is null. </exception>
        public async virtual Task<Response<VMwareHost>> GetIfExistsAsync(string hostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostName, nameof(hostName));

            using var scope = _vMwareHostHostsClientDiagnostics.CreateScope("VMwareHostCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _vMwareHostHostsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, hostName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<VMwareHost>(null, response.GetRawResponse());
                return Response.FromValue(new VMwareHost(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/hosts/{hostName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Hosts_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="hostName"> Name of the host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> is null. </exception>
        public virtual Response<VMwareHost> GetIfExists(string hostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostName, nameof(hostName));

            using var scope = _vMwareHostHostsClientDiagnostics.CreateScope("VMwareHostCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _vMwareHostHostsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, hostName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<VMwareHost>(null, response.GetRawResponse());
                return Response.FromValue(new VMwareHost(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VMwareHost> IEnumerable<VMwareHost>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VMwareHost> IAsyncEnumerable<VMwareHost>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
