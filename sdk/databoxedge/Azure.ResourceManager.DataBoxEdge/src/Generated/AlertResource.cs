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

namespace Azure.ResourceManager.DataBoxEdge
{
    /// <summary>
    /// A Class representing an Alert along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct an <see cref="AlertResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetAlertResource method.
    /// Otherwise you can get one from its parent resource <see cref="DataBoxEdgeDeviceResource" /> using the GetAlert method.
    /// </summary>
    public partial class AlertResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="AlertResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string deviceName, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/alerts/{name}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _alertClientDiagnostics;
        private readonly AlertsRestOperations _alertRestClient;
        private readonly AlertData _data;

        /// <summary> Initializes a new instance of the <see cref="AlertResource"/> class for mocking. </summary>
        protected AlertResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "AlertResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal AlertResource(ArmClient client, AlertData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="AlertResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AlertResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _alertClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataBoxEdge", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string alertApiVersion);
            _alertRestClient = new AlertsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, alertApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DataBoxEdge/dataBoxEdgeDevices/alerts";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AlertData Data
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
        /// Gets an alert by name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/alerts/{name}
        /// Operation Id: Alerts_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AlertResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _alertClientDiagnostics.CreateScope("AlertResource.Get");
            scope.Start();
            try
            {
                var response = await _alertRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AlertResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an alert by name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/alerts/{name}
        /// Operation Id: Alerts_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AlertResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _alertClientDiagnostics.CreateScope("AlertResource.Get");
            scope.Start();
            try
            {
                var response = _alertRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AlertResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
