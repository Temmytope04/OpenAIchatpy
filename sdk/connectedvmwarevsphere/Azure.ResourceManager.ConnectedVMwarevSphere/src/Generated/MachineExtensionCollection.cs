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

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    /// <summary> A class representing collection of MachineExtension and their operations over its parent. </summary>
    public partial class MachineExtensionCollection : ArmCollection, IEnumerable<MachineExtension>, IAsyncEnumerable<MachineExtension>
    {
        private readonly ClientDiagnostics _machineExtensionClientDiagnostics;
        private readonly MachineExtensionsRestOperations _machineExtensionRestClient;

        /// <summary> Initializes a new instance of the <see cref="MachineExtensionCollection"/> class for mocking. </summary>
        protected MachineExtensionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MachineExtensionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MachineExtensionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _machineExtensionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ConnectedVMwarevSphere", MachineExtension.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(MachineExtension.ResourceType, out string machineExtensionApiVersion);
            _machineExtensionRestClient = new MachineExtensionsRestOperations(_machineExtensionClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, machineExtensionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != VirtualMachine.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, VirtualMachine.ResourceType), nameof(id));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{name}/extensions/{extensionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}
        /// OperationId: MachineExtensions_CreateOrUpdate
        /// <summary> The operation to create or update the extension. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="extensionParameters"> Parameters supplied to the Create Machine Extension operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> or <paramref name="extensionParameters"/> is null. </exception>
        public async virtual Task<ArmOperation<MachineExtension>> CreateOrUpdateAsync(bool waitForCompletion, string extensionName, MachineExtensionData extensionParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(extensionName, nameof(extensionName));
            if (extensionParameters == null)
            {
                throw new ArgumentNullException(nameof(extensionParameters));
            }

            using var scope = _machineExtensionClientDiagnostics.CreateScope("MachineExtensionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _machineExtensionRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionName, extensionParameters, cancellationToken).ConfigureAwait(false);
                var operation = new ConnectedVMwarevSphereArmOperation<MachineExtension>(new MachineExtensionOperationSource(Client), _machineExtensionClientDiagnostics, Pipeline, _machineExtensionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionName, extensionParameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{name}/extensions/{extensionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}
        /// OperationId: MachineExtensions_CreateOrUpdate
        /// <summary> The operation to create or update the extension. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="extensionParameters"> Parameters supplied to the Create Machine Extension operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> or <paramref name="extensionParameters"/> is null. </exception>
        public virtual ArmOperation<MachineExtension> CreateOrUpdate(bool waitForCompletion, string extensionName, MachineExtensionData extensionParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(extensionName, nameof(extensionName));
            if (extensionParameters == null)
            {
                throw new ArgumentNullException(nameof(extensionParameters));
            }

            using var scope = _machineExtensionClientDiagnostics.CreateScope("MachineExtensionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _machineExtensionRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionName, extensionParameters, cancellationToken);
                var operation = new ConnectedVMwarevSphereArmOperation<MachineExtension>(new MachineExtensionOperationSource(Client), _machineExtensionClientDiagnostics, Pipeline, _machineExtensionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionName, extensionParameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{name}/extensions/{extensionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}
        /// OperationId: MachineExtensions_Get
        /// <summary> The operation to get the extension. </summary>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> is null. </exception>
        public async virtual Task<Response<MachineExtension>> GetAsync(string extensionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(extensionName, nameof(extensionName));

            using var scope = _machineExtensionClientDiagnostics.CreateScope("MachineExtensionCollection.Get");
            scope.Start();
            try
            {
                var response = await _machineExtensionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _machineExtensionClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new MachineExtension(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{name}/extensions/{extensionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}
        /// OperationId: MachineExtensions_Get
        /// <summary> The operation to get the extension. </summary>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> is null. </exception>
        public virtual Response<MachineExtension> Get(string extensionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(extensionName, nameof(extensionName));

            using var scope = _machineExtensionClientDiagnostics.CreateScope("MachineExtensionCollection.Get");
            scope.Start();
            try
            {
                var response = _machineExtensionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionName, cancellationToken);
                if (response.Value == null)
                    throw _machineExtensionClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineExtension(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{name}/extensions
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}
        /// OperationId: MachineExtensions_List
        /// <summary> The operation to get all extensions of a non-Azure machine. </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MachineExtension" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MachineExtension> GetAllAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<MachineExtension>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _machineExtensionClientDiagnostics.CreateScope("MachineExtensionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _machineExtensionRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new MachineExtension(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<MachineExtension>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _machineExtensionClientDiagnostics.CreateScope("MachineExtensionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _machineExtensionRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new MachineExtension(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{name}/extensions
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}
        /// OperationId: MachineExtensions_List
        /// <summary> The operation to get all extensions of a non-Azure machine. </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MachineExtension" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MachineExtension> GetAll(string expand = null, CancellationToken cancellationToken = default)
        {
            Page<MachineExtension> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _machineExtensionClientDiagnostics.CreateScope("MachineExtensionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _machineExtensionRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new MachineExtension(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<MachineExtension> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _machineExtensionClientDiagnostics.CreateScope("MachineExtensionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _machineExtensionRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new MachineExtension(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{name}/extensions/{extensionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}
        /// OperationId: MachineExtensions_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string extensionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(extensionName, nameof(extensionName));

            using var scope = _machineExtensionClientDiagnostics.CreateScope("MachineExtensionCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(extensionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{name}/extensions/{extensionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}
        /// OperationId: MachineExtensions_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> is null. </exception>
        public virtual Response<bool> Exists(string extensionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(extensionName, nameof(extensionName));

            using var scope = _machineExtensionClientDiagnostics.CreateScope("MachineExtensionCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(extensionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{name}/extensions/{extensionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}
        /// OperationId: MachineExtensions_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> is null. </exception>
        public async virtual Task<Response<MachineExtension>> GetIfExistsAsync(string extensionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(extensionName, nameof(extensionName));

            using var scope = _machineExtensionClientDiagnostics.CreateScope("MachineExtensionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _machineExtensionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<MachineExtension>(null, response.GetRawResponse());
                return Response.FromValue(new MachineExtension(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{name}/extensions/{extensionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}
        /// OperationId: MachineExtensions_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> is null. </exception>
        public virtual Response<MachineExtension> GetIfExists(string extensionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(extensionName, nameof(extensionName));

            using var scope = _machineExtensionClientDiagnostics.CreateScope("MachineExtensionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _machineExtensionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<MachineExtension>(null, response.GetRawResponse());
                return Response.FromValue(new MachineExtension(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MachineExtension> IEnumerable<MachineExtension>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MachineExtension> IAsyncEnumerable<MachineExtension>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
