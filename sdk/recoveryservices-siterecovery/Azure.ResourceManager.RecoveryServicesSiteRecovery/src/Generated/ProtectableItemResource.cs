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

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    /// <summary>
    /// A Class representing a ProtectableItem along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="ProtectableItemResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetProtectableItemResource method.
    /// Otherwise you can get one from its parent resource <see cref="ProtectionContainerResource" /> using the GetProtectableItem method.
    /// </summary>
    public partial class ProtectableItemResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ProtectableItemResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string resourceName, string fabricName, string protectionContainerName, string protectableItemName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationProtectionContainers/{protectionContainerName}/replicationProtectableItems/{protectableItemName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _protectableItemReplicationProtectableItemsClientDiagnostics;
        private readonly ReplicationProtectableItemsRestOperations _protectableItemReplicationProtectableItemsRestClient;
        private readonly ProtectableItemData _data;

        /// <summary> Initializes a new instance of the <see cref="ProtectableItemResource"/> class for mocking. </summary>
        protected ProtectableItemResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ProtectableItemResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ProtectableItemResource(ArmClient client, ProtectableItemData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ProtectableItemResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ProtectableItemResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _protectableItemReplicationProtectableItemsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesSiteRecovery", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string protectableItemReplicationProtectableItemsApiVersion);
            _protectableItemReplicationProtectableItemsRestClient = new ReplicationProtectableItemsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, protectableItemReplicationProtectableItemsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.RecoveryServices/vaults/replicationFabrics/replicationProtectionContainers/replicationProtectableItems";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ProtectableItemData Data
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
        /// The operation to get the details of a protectable item.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationProtectionContainers/{protectionContainerName}/replicationProtectableItems/{protectableItemName}
        /// Operation Id: ReplicationProtectableItems_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ProtectableItemResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _protectableItemReplicationProtectableItemsClientDiagnostics.CreateScope("ProtectableItemResource.Get");
            scope.Start();
            try
            {
                var response = await _protectableItemReplicationProtectableItemsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ProtectableItemResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to get the details of a protectable item.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationProtectionContainers/{protectionContainerName}/replicationProtectableItems/{protectableItemName}
        /// Operation Id: ReplicationProtectableItems_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ProtectableItemResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _protectableItemReplicationProtectableItemsClientDiagnostics.CreateScope("ProtectableItemResource.Get");
            scope.Start();
            try
            {
                var response = _protectableItemReplicationProtectableItemsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ProtectableItemResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
