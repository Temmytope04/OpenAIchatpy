// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.TrafficManager.Models;

namespace Azure.ResourceManager.TrafficManager
{
    /// <summary>
    /// A Class representing a HeatMapModel along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="HeatMapModelResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetHeatMapModelResource method.
    /// Otherwise you can get one from its parent resource <see cref="ProfileResource" /> using the GetHeatMapModel method.
    /// </summary>
    public partial class HeatMapModelResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="HeatMapModelResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string profileName, HeatMapType heatMapType)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficmanagerprofiles/{profileName}/heatMaps/{heatMapType}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _heatMapModelHeatMapClientDiagnostics;
        private readonly HeatMapRestOperations _heatMapModelHeatMapRestClient;
        private readonly HeatMapModelData _data;

        /// <summary> Initializes a new instance of the <see cref="HeatMapModelResource"/> class for mocking. </summary>
        protected HeatMapModelResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "HeatMapModelResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal HeatMapModelResource(ArmClient client, HeatMapModelData data) : this(client, new ResourceIdentifier(data.Id))
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="HeatMapModelResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal HeatMapModelResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _heatMapModelHeatMapClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.TrafficManager", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string heatMapModelHeatMapApiVersion);
            _heatMapModelHeatMapRestClient = new HeatMapRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, heatMapModelHeatMapApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/trafficmanagerprofiles/heatMaps";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual HeatMapModelData Data
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
        /// Gets latest heatmap for Traffic Manager profile.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficmanagerprofiles/{profileName}/heatMaps/{heatMapType}
        /// Operation Id: HeatMap_Get
        /// </summary>
        /// <param name="topLeft"> The top left latitude,longitude pair of the rectangular viewport to query for. </param>
        /// <param name="botRight"> The bottom right latitude,longitude pair of the rectangular viewport to query for. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<HeatMapModelResource>> GetAsync(IEnumerable<double> topLeft = null, IEnumerable<double> botRight = null, CancellationToken cancellationToken = default)
        {
            using var scope = _heatMapModelHeatMapClientDiagnostics.CreateScope("HeatMapModelResource.Get");
            scope.Start();
            try
            {
                var response = await _heatMapModelHeatMapRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, topLeft, botRight, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HeatMapModelResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets latest heatmap for Traffic Manager profile.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficmanagerprofiles/{profileName}/heatMaps/{heatMapType}
        /// Operation Id: HeatMap_Get
        /// </summary>
        /// <param name="topLeft"> The top left latitude,longitude pair of the rectangular viewport to query for. </param>
        /// <param name="botRight"> The bottom right latitude,longitude pair of the rectangular viewport to query for. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<HeatMapModelResource> Get(IEnumerable<double> topLeft = null, IEnumerable<double> botRight = null, CancellationToken cancellationToken = default)
        {
            using var scope = _heatMapModelHeatMapClientDiagnostics.CreateScope("HeatMapModelResource.Get");
            scope.Start();
            try
            {
                var response = _heatMapModelHeatMapRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, topLeft, botRight, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HeatMapModelResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
