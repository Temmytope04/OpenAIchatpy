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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Reservations
{
    /// <summary>
    /// A Class representing a ReservationQuota along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="ReservationQuotaResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetReservationQuotaResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource" /> using the GetReservationQuota method.
    /// </summary>
    public partial class ReservationQuotaResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ReservationQuotaResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string providerId, AzureLocation location, string resourceName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Capacity/resourceProviders/{providerId}/locations/{location}/serviceLimits/{resourceName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _reservationQuotaQuotaClientDiagnostics;
        private readonly QuotaRestOperations _reservationQuotaQuotaRestClient;
        private readonly ReservationQuotaData _data;

        /// <summary> Initializes a new instance of the <see cref="ReservationQuotaResource"/> class for mocking. </summary>
        protected ReservationQuotaResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ReservationQuotaResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ReservationQuotaResource(ArmClient client, ReservationQuotaData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ReservationQuotaResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ReservationQuotaResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _reservationQuotaQuotaClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Reservations", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string reservationQuotaQuotaApiVersion);
            _reservationQuotaQuotaRestClient = new QuotaRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, reservationQuotaQuotaApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Capacity/resourceProviders/locations/serviceLimits";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ReservationQuotaData Data
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
        /// Get the current quota (service limit) and usage of a resource. You can use the response from the GET operation to submit quota update request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Capacity/resourceProviders/{providerId}/locations/{location}/serviceLimits/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quota_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ReservationQuotaResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _reservationQuotaQuotaClientDiagnostics.CreateScope("ReservationQuotaResource.Get");
            scope.Start();
            try
            {
                var response = await _reservationQuotaQuotaRestClient.GetAsync(Id.SubscriptionId, Id.Parent.Parent.Name, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ReservationQuotaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the current quota (service limit) and usage of a resource. You can use the response from the GET operation to submit quota update request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Capacity/resourceProviders/{providerId}/locations/{location}/serviceLimits/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quota_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ReservationQuotaResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _reservationQuotaQuotaClientDiagnostics.CreateScope("ReservationQuotaResource.Get");
            scope.Start();
            try
            {
                var response = _reservationQuotaQuotaRestClient.Get(Id.SubscriptionId, Id.Parent.Parent.Name, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ReservationQuotaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update the quota (service limits) of this resource to the requested value.
        ///   • To get the quota information for specific resource, send a GET request.
        ///   • To increase the quota, update the limit field from the GET response to a new value.
        ///   • To update the quota value, submit the JSON response to the quota request API to update the quota.
        ///   • To update the quota. use the PATCH operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Capacity/resourceProviders/{providerId}/locations/{location}/serviceLimits/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quota_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Payload for the quota request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ReservationQuotaResource>> UpdateAsync(WaitUntil waitUntil, ReservationQuotaData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _reservationQuotaQuotaClientDiagnostics.CreateScope("ReservationQuotaResource.Update");
            scope.Start();
            try
            {
                var response = await _reservationQuotaQuotaRestClient.UpdateAsync(Id.SubscriptionId, Id.Parent.Parent.Name, new AzureLocation(Id.Parent.Name), Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new ReservationsArmOperation<ReservationQuotaResource>(new ReservationQuotaOperationSource(Client), _reservationQuotaQuotaClientDiagnostics, Pipeline, _reservationQuotaQuotaRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.Parent.Parent.Name, new AzureLocation(Id.Parent.Name), Id.Name, data).Request, response, OperationFinalStateVia.OriginalUri);
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
        /// Update the quota (service limits) of this resource to the requested value.
        ///   • To get the quota information for specific resource, send a GET request.
        ///   • To increase the quota, update the limit field from the GET response to a new value.
        ///   • To update the quota value, submit the JSON response to the quota request API to update the quota.
        ///   • To update the quota. use the PATCH operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Capacity/resourceProviders/{providerId}/locations/{location}/serviceLimits/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quota_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Payload for the quota request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ReservationQuotaResource> Update(WaitUntil waitUntil, ReservationQuotaData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _reservationQuotaQuotaClientDiagnostics.CreateScope("ReservationQuotaResource.Update");
            scope.Start();
            try
            {
                var response = _reservationQuotaQuotaRestClient.Update(Id.SubscriptionId, Id.Parent.Parent.Name, new AzureLocation(Id.Parent.Name), Id.Name, data, cancellationToken);
                var operation = new ReservationsArmOperation<ReservationQuotaResource>(new ReservationQuotaOperationSource(Client), _reservationQuotaQuotaClientDiagnostics, Pipeline, _reservationQuotaQuotaRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.Parent.Parent.Name, new AzureLocation(Id.Parent.Name), Id.Name, data).Request, response, OperationFinalStateVia.OriginalUri);
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
