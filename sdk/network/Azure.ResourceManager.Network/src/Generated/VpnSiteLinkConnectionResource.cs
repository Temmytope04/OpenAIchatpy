// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A Class representing a VpnSiteLinkConnection along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="VpnSiteLinkConnectionResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetVpnSiteLinkConnectionResource method.
    /// Otherwise you can get one from its parent resource <see cref="VpnConnectionResource"/> using the GetVpnSiteLinkConnection method.
    /// </summary>
    public partial class VpnSiteLinkConnectionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="VpnSiteLinkConnectionResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="gatewayName"> The gatewayName. </param>
        /// <param name="connectionName"> The connectionName. </param>
        /// <param name="linkConnectionName"> The linkConnectionName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string gatewayName, string connectionName, string linkConnectionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/vpnConnections/{connectionName}/vpnLinkConnections/{linkConnectionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _vpnSiteLinkConnectionClientDiagnostics;
        private readonly VpnSiteLinkConnectionsRestOperations _vpnSiteLinkConnectionRestClient;
        private readonly ClientDiagnostics _vpnSiteLinkConnectionVpnLinkConnectionsClientDiagnostics;
        private readonly VpnLinkConnectionsRestOperations _vpnSiteLinkConnectionVpnLinkConnectionsRestClient;
        private readonly VpnSiteLinkConnectionData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/vpnGateways/vpnConnections/vpnLinkConnections";

        /// <summary> Initializes a new instance of the <see cref="VpnSiteLinkConnectionResource"/> class for mocking. </summary>
        protected VpnSiteLinkConnectionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VpnSiteLinkConnectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal VpnSiteLinkConnectionResource(ArmClient client, VpnSiteLinkConnectionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="VpnSiteLinkConnectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal VpnSiteLinkConnectionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _vpnSiteLinkConnectionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string vpnSiteLinkConnectionApiVersion);
            _vpnSiteLinkConnectionRestClient = new VpnSiteLinkConnectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, vpnSiteLinkConnectionApiVersion);
            _vpnSiteLinkConnectionVpnLinkConnectionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string vpnSiteLinkConnectionVpnLinkConnectionsApiVersion);
            _vpnSiteLinkConnectionVpnLinkConnectionsRestClient = new VpnLinkConnectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, vpnSiteLinkConnectionVpnLinkConnectionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual VpnSiteLinkConnectionData Data
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
        /// Retrieves the details of a vpn site link connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/vpnConnections/{connectionName}/vpnLinkConnections/{linkConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VpnSiteLinkConnections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VpnSiteLinkConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<VpnSiteLinkConnectionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _vpnSiteLinkConnectionClientDiagnostics.CreateScope("VpnSiteLinkConnectionResource.Get");
            scope.Start();
            try
            {
                var response = await _vpnSiteLinkConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VpnSiteLinkConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the details of a vpn site link connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/vpnConnections/{connectionName}/vpnLinkConnections/{linkConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VpnSiteLinkConnections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VpnSiteLinkConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VpnSiteLinkConnectionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _vpnSiteLinkConnectionClientDiagnostics.CreateScope("VpnSiteLinkConnectionResource.Get");
            scope.Start();
            try
            {
                var response = _vpnSiteLinkConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VpnSiteLinkConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Resets the VpnLink connection specified.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/vpnConnections/{connectionName}/vpnLinkConnections/{linkConnectionName}/resetconnection</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VpnLinkConnections_ResetConnection</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VpnSiteLinkConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> ResetConnectionVpnLinkConnectionAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _vpnSiteLinkConnectionVpnLinkConnectionsClientDiagnostics.CreateScope("VpnSiteLinkConnectionResource.ResetConnectionVpnLinkConnection");
            scope.Start();
            try
            {
                var response = await _vpnSiteLinkConnectionVpnLinkConnectionsRestClient.ResetConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation(_vpnSiteLinkConnectionVpnLinkConnectionsClientDiagnostics, Pipeline, _vpnSiteLinkConnectionVpnLinkConnectionsRestClient.CreateResetConnectionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Resets the VpnLink connection specified.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/vpnConnections/{connectionName}/vpnLinkConnections/{linkConnectionName}/resetconnection</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VpnLinkConnections_ResetConnection</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VpnSiteLinkConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation ResetConnectionVpnLinkConnection(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _vpnSiteLinkConnectionVpnLinkConnectionsClientDiagnostics.CreateScope("VpnSiteLinkConnectionResource.ResetConnectionVpnLinkConnection");
            scope.Start();
            try
            {
                var response = _vpnSiteLinkConnectionVpnLinkConnectionsRestClient.ResetConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new NetworkArmOperation(_vpnSiteLinkConnectionVpnLinkConnectionsClientDiagnostics, Pipeline, _vpnSiteLinkConnectionVpnLinkConnectionsRestClient.CreateResetConnectionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Lists IKE Security Associations for Vpn Site Link Connection in the specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/vpnConnections/{connectionName}/vpnLinkConnections/{linkConnectionName}/getikesas</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VpnLinkConnections_GetIkeSas</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VpnSiteLinkConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation<string>> GetIkeSasVpnLinkConnectionAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _vpnSiteLinkConnectionVpnLinkConnectionsClientDiagnostics.CreateScope("VpnSiteLinkConnectionResource.GetIkeSasVpnLinkConnection");
            scope.Start();
            try
            {
                var response = await _vpnSiteLinkConnectionVpnLinkConnectionsRestClient.GetIkeSasAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<string>(new StringOperationSource(), _vpnSiteLinkConnectionVpnLinkConnectionsClientDiagnostics, Pipeline, _vpnSiteLinkConnectionVpnLinkConnectionsRestClient.CreateGetIkeSasRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Lists IKE Security Associations for Vpn Site Link Connection in the specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/vpnConnections/{connectionName}/vpnLinkConnections/{linkConnectionName}/getikesas</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VpnLinkConnections_GetIkeSas</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VpnSiteLinkConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<string> GetIkeSasVpnLinkConnection(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _vpnSiteLinkConnectionVpnLinkConnectionsClientDiagnostics.CreateScope("VpnSiteLinkConnectionResource.GetIkeSasVpnLinkConnection");
            scope.Start();
            try
            {
                var response = _vpnSiteLinkConnectionVpnLinkConnectionsRestClient.GetIkeSas(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new NetworkArmOperation<string>(new StringOperationSource(), _vpnSiteLinkConnectionVpnLinkConnectionsClientDiagnostics, Pipeline, _vpnSiteLinkConnectionVpnLinkConnectionsRestClient.CreateGetIkeSasRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
