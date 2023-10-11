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

namespace Azure.ResourceManager.RecoveryServicesDataReplication
{
    /// <summary>
    /// A Class representing a DataReplicationEvent along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="DataReplicationEventResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetDataReplicationEventResource method.
    /// Otherwise you can get one from its parent resource <see cref="DataReplicationVaultResource" /> using the GetDataReplicationEvent method.
    /// </summary>
    public partial class DataReplicationEventResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DataReplicationEventResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string vaultName, string eventName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/events/{eventName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _dataReplicationEventEventClientDiagnostics;
        private readonly EventRestOperations _dataReplicationEventEventRestClient;
        private readonly DataReplicationEventData _data;

        /// <summary> Initializes a new instance of the <see cref="DataReplicationEventResource"/> class for mocking. </summary>
        protected DataReplicationEventResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DataReplicationEventResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DataReplicationEventResource(ArmClient client, DataReplicationEventData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DataReplicationEventResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DataReplicationEventResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataReplicationEventEventClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesDataReplication", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string dataReplicationEventEventApiVersion);
            _dataReplicationEventEventRestClient = new EventRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataReplicationEventEventApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DataReplication/replicationVaults/events";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DataReplicationEventData Data
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
        /// Gets the details of the event.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/events/{eventName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Event_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DataReplicationEventResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _dataReplicationEventEventClientDiagnostics.CreateScope("DataReplicationEventResource.Get");
            scope.Start();
            try
            {
                var response = await _dataReplicationEventEventRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataReplicationEventResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the event.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/events/{eventName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Event_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DataReplicationEventResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _dataReplicationEventEventClientDiagnostics.CreateScope("DataReplicationEventResource.Get");
            scope.Start();
            try
            {
                var response = _dataReplicationEventEventRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataReplicationEventResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
