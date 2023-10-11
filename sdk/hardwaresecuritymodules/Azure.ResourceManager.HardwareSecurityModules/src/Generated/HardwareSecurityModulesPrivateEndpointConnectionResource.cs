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

namespace Azure.ResourceManager.HardwareSecurityModules
{
    /// <summary>
    /// A Class representing a HardwareSecurityModulesPrivateEndpointConnection along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="HardwareSecurityModulesPrivateEndpointConnectionResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetHardwareSecurityModulesPrivateEndpointConnectionResource method.
    /// Otherwise you can get one from its parent resource <see cref="CloudHsmClusterResource" /> using the GetHardwareSecurityModulesPrivateEndpointConnection method.
    /// </summary>
    public partial class HardwareSecurityModulesPrivateEndpointConnectionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="HardwareSecurityModulesPrivateEndpointConnectionResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, string peConnectionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}/privateEndpointConnections/{peConnectionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _hardwareSecurityModulesPrivateEndpointConnectionCloudHsmClusterPrivateEndpointConnectionsClientDiagnostics;
        private readonly CloudHsmClusterPrivateEndpointConnectionsRestOperations _hardwareSecurityModulesPrivateEndpointConnectionCloudHsmClusterPrivateEndpointConnectionsRestClient;
        private readonly HardwareSecurityModulesPrivateEndpointConnectionData _data;

        /// <summary> Initializes a new instance of the <see cref="HardwareSecurityModulesPrivateEndpointConnectionResource"/> class for mocking. </summary>
        protected HardwareSecurityModulesPrivateEndpointConnectionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "HardwareSecurityModulesPrivateEndpointConnectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal HardwareSecurityModulesPrivateEndpointConnectionResource(ArmClient client, HardwareSecurityModulesPrivateEndpointConnectionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="HardwareSecurityModulesPrivateEndpointConnectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal HardwareSecurityModulesPrivateEndpointConnectionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _hardwareSecurityModulesPrivateEndpointConnectionCloudHsmClusterPrivateEndpointConnectionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HardwareSecurityModules", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string hardwareSecurityModulesPrivateEndpointConnectionCloudHsmClusterPrivateEndpointConnectionsApiVersion);
            _hardwareSecurityModulesPrivateEndpointConnectionCloudHsmClusterPrivateEndpointConnectionsRestClient = new CloudHsmClusterPrivateEndpointConnectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, hardwareSecurityModulesPrivateEndpointConnectionCloudHsmClusterPrivateEndpointConnectionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.HardwareSecurityModules/cloudHsmClusters/privateEndpointConnections";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual HardwareSecurityModulesPrivateEndpointConnectionData Data
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
        /// Gets the private endpoint connection for the Cloud Hsm Cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}/privateEndpointConnections/{peConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudHsmClusterPrivateEndpointConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<HardwareSecurityModulesPrivateEndpointConnectionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _hardwareSecurityModulesPrivateEndpointConnectionCloudHsmClusterPrivateEndpointConnectionsClientDiagnostics.CreateScope("HardwareSecurityModulesPrivateEndpointConnectionResource.Get");
            scope.Start();
            try
            {
                var response = await _hardwareSecurityModulesPrivateEndpointConnectionCloudHsmClusterPrivateEndpointConnectionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HardwareSecurityModulesPrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the private endpoint connection for the Cloud Hsm Cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}/privateEndpointConnections/{peConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudHsmClusterPrivateEndpointConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<HardwareSecurityModulesPrivateEndpointConnectionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _hardwareSecurityModulesPrivateEndpointConnectionCloudHsmClusterPrivateEndpointConnectionsClientDiagnostics.CreateScope("HardwareSecurityModulesPrivateEndpointConnectionResource.Get");
            scope.Start();
            try
            {
                var response = _hardwareSecurityModulesPrivateEndpointConnectionCloudHsmClusterPrivateEndpointConnectionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HardwareSecurityModulesPrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the private endpoint connection for the Cloud Hsm Cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}/privateEndpointConnections/{peConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudHsmClusterPrivateEndpointConnections_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _hardwareSecurityModulesPrivateEndpointConnectionCloudHsmClusterPrivateEndpointConnectionsClientDiagnostics.CreateScope("HardwareSecurityModulesPrivateEndpointConnectionResource.Delete");
            scope.Start();
            try
            {
                var response = await _hardwareSecurityModulesPrivateEndpointConnectionCloudHsmClusterPrivateEndpointConnectionsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new HardwareSecurityModulesArmOperation(_hardwareSecurityModulesPrivateEndpointConnectionCloudHsmClusterPrivateEndpointConnectionsClientDiagnostics, Pipeline, _hardwareSecurityModulesPrivateEndpointConnectionCloudHsmClusterPrivateEndpointConnectionsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the private endpoint connection for the Cloud Hsm Cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}/privateEndpointConnections/{peConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudHsmClusterPrivateEndpointConnections_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _hardwareSecurityModulesPrivateEndpointConnectionCloudHsmClusterPrivateEndpointConnectionsClientDiagnostics.CreateScope("HardwareSecurityModulesPrivateEndpointConnectionResource.Delete");
            scope.Start();
            try
            {
                var response = _hardwareSecurityModulesPrivateEndpointConnectionCloudHsmClusterPrivateEndpointConnectionsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new HardwareSecurityModulesArmOperation(_hardwareSecurityModulesPrivateEndpointConnectionCloudHsmClusterPrivateEndpointConnectionsClientDiagnostics, Pipeline, _hardwareSecurityModulesPrivateEndpointConnectionCloudHsmClusterPrivateEndpointConnectionsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates the private endpoint connection for the Cloud Hsm Cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}/privateEndpointConnections/{peConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudHsmClusterPrivateEndpointConnections_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters of the PrivateEndpointConnection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<HardwareSecurityModulesPrivateEndpointConnectionResource>> UpdateAsync(WaitUntil waitUntil, HardwareSecurityModulesPrivateEndpointConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hardwareSecurityModulesPrivateEndpointConnectionCloudHsmClusterPrivateEndpointConnectionsClientDiagnostics.CreateScope("HardwareSecurityModulesPrivateEndpointConnectionResource.Update");
            scope.Start();
            try
            {
                var response = await _hardwareSecurityModulesPrivateEndpointConnectionCloudHsmClusterPrivateEndpointConnectionsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new HardwareSecurityModulesArmOperation<HardwareSecurityModulesPrivateEndpointConnectionResource>(Response.FromValue(new HardwareSecurityModulesPrivateEndpointConnectionResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates the private endpoint connection for the Cloud Hsm Cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}/privateEndpointConnections/{peConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudHsmClusterPrivateEndpointConnections_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters of the PrivateEndpointConnection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<HardwareSecurityModulesPrivateEndpointConnectionResource> Update(WaitUntil waitUntil, HardwareSecurityModulesPrivateEndpointConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hardwareSecurityModulesPrivateEndpointConnectionCloudHsmClusterPrivateEndpointConnectionsClientDiagnostics.CreateScope("HardwareSecurityModulesPrivateEndpointConnectionResource.Update");
            scope.Start();
            try
            {
                var response = _hardwareSecurityModulesPrivateEndpointConnectionCloudHsmClusterPrivateEndpointConnectionsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new HardwareSecurityModulesArmOperation<HardwareSecurityModulesPrivateEndpointConnectionResource>(Response.FromValue(new HardwareSecurityModulesPrivateEndpointConnectionResource(Client, response), response.GetRawResponse()));
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
