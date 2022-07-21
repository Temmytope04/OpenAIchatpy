// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Workloads
{
    /// <summary>
    /// A Class representing a SapProviderInstance along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SapProviderInstanceResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSapProviderInstanceResource method.
    /// Otherwise you can get one from its parent resource <see cref="SapMonitorResource" /> using the GetSapProviderInstance method.
    /// </summary>
    public partial class SapProviderInstanceResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SapProviderInstanceResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string monitorName, string providerInstanceName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/monitors/{monitorName}/providerInstances/{providerInstanceName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _sapProviderInstanceProviderInstancesClientDiagnostics;
        private readonly ProviderInstancesRestOperations _sapProviderInstanceProviderInstancesRestClient;
        private readonly SapProviderInstanceData _data;

        /// <summary> Initializes a new instance of the <see cref="SapProviderInstanceResource"/> class for mocking. </summary>
        protected SapProviderInstanceResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SapProviderInstanceResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SapProviderInstanceResource(ArmClient client, SapProviderInstanceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SapProviderInstanceResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SapProviderInstanceResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sapProviderInstanceProviderInstancesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Workloads", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string sapProviderInstanceProviderInstancesApiVersion);
            _sapProviderInstanceProviderInstancesRestClient = new ProviderInstancesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sapProviderInstanceProviderInstancesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Workloads/monitors/providerInstances";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SapProviderInstanceData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets properties of a provider instance for the specified subscription, resource group, SAP monitor name, and resource name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/monitors/{monitorName}/providerInstances/{providerInstanceName}
        /// Operation Id: ProviderInstances_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SapProviderInstanceResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _sapProviderInstanceProviderInstancesClientDiagnostics.CreateScope("SapProviderInstanceResource.Get");
            scope.Start();
            try
            {
                var response = await _sapProviderInstanceProviderInstancesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SapProviderInstanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets properties of a provider instance for the specified subscription, resource group, SAP monitor name, and resource name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/monitors/{monitorName}/providerInstances/{providerInstanceName}
        /// Operation Id: ProviderInstances_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SapProviderInstanceResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _sapProviderInstanceProviderInstancesClientDiagnostics.CreateScope("SapProviderInstanceResource.Get");
            scope.Start();
            try
            {
                var response = _sapProviderInstanceProviderInstancesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SapProviderInstanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a provider instance for the specified subscription, resource group, SAP monitor name, and resource name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/monitors/{monitorName}/providerInstances/{providerInstanceName}
        /// Operation Id: ProviderInstances_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation<OperationStatusResult>> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _sapProviderInstanceProviderInstancesClientDiagnostics.CreateScope("SapProviderInstanceResource.Delete");
            scope.Start();
            try
            {
                var response = await _sapProviderInstanceProviderInstancesRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new WorkloadsArmOperation<OperationStatusResult>(new OperationStatusResultOperationSource(), _sapProviderInstanceProviderInstancesClientDiagnostics, Pipeline, _sapProviderInstanceProviderInstancesRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Deletes a provider instance for the specified subscription, resource group, SAP monitor name, and resource name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/monitors/{monitorName}/providerInstances/{providerInstanceName}
        /// Operation Id: ProviderInstances_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<OperationStatusResult> Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _sapProviderInstanceProviderInstancesClientDiagnostics.CreateScope("SapProviderInstanceResource.Delete");
            scope.Start();
            try
            {
                var response = _sapProviderInstanceProviderInstancesRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new WorkloadsArmOperation<OperationStatusResult>(new OperationStatusResultOperationSource(), _sapProviderInstanceProviderInstancesClientDiagnostics, Pipeline, _sapProviderInstanceProviderInstancesRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Creates a provider instance for the specified subscription, resource group, SAP monitor name, and resource name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/monitors/{monitorName}/providerInstances/{providerInstanceName}
        /// Operation Id: ProviderInstances_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Request body representing a provider instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SapProviderInstanceResource>> UpdateAsync(WaitUntil waitUntil, SapProviderInstanceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sapProviderInstanceProviderInstancesClientDiagnostics.CreateScope("SapProviderInstanceResource.Update");
            scope.Start();
            try
            {
                var response = await _sapProviderInstanceProviderInstancesRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new WorkloadsArmOperation<SapProviderInstanceResource>(new SapProviderInstanceOperationSource(Client), _sapProviderInstanceProviderInstancesClientDiagnostics, Pipeline, _sapProviderInstanceProviderInstancesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates a provider instance for the specified subscription, resource group, SAP monitor name, and resource name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/monitors/{monitorName}/providerInstances/{providerInstanceName}
        /// Operation Id: ProviderInstances_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Request body representing a provider instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SapProviderInstanceResource> Update(WaitUntil waitUntil, SapProviderInstanceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sapProviderInstanceProviderInstancesClientDiagnostics.CreateScope("SapProviderInstanceResource.Update");
            scope.Start();
            try
            {
                var response = _sapProviderInstanceProviderInstancesRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new WorkloadsArmOperation<SapProviderInstanceResource>(new SapProviderInstanceOperationSource(Client), _sapProviderInstanceProviderInstancesClientDiagnostics, Pipeline, _sapProviderInstanceProviderInstancesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
    }
}
