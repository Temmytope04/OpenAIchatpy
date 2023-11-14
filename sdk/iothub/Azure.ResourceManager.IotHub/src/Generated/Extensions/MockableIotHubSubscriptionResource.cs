// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.IotHub;
using Azure.ResourceManager.IotHub.Models;

namespace Azure.ResourceManager.IotHub.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableIotHubSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _iotHubDescriptionIotHubResourceClientDiagnostics;
        private IotHubResourceRestOperations _iotHubDescriptionIotHubResourceRestClient;
        private ClientDiagnostics _resourceProviderCommonClientDiagnostics;
        private ResourceProviderCommonRestOperations _resourceProviderCommonRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableIotHubSubscriptionResource"/> class for mocking. </summary>
        protected MockableIotHubSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableIotHubSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableIotHubSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics IotHubDescriptionIotHubResourceClientDiagnostics => _iotHubDescriptionIotHubResourceClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.IotHub", IotHubDescriptionResource.ResourceType.Namespace, Diagnostics);
        private IotHubResourceRestOperations IotHubDescriptionIotHubResourceRestClient => _iotHubDescriptionIotHubResourceRestClient ??= new IotHubResourceRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(IotHubDescriptionResource.ResourceType));
        private ClientDiagnostics ResourceProviderCommonClientDiagnostics => _resourceProviderCommonClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.IotHub", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private ResourceProviderCommonRestOperations ResourceProviderCommonRestClient => _resourceProviderCommonRestClient ??= new ResourceProviderCommonRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Get all the IoT hubs in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Devices/IotHubs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotHubResource_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="IotHubDescriptionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<IotHubDescriptionResource> GetIotHubDescriptionsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => IotHubDescriptionIotHubResourceRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => IotHubDescriptionIotHubResourceRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new IotHubDescriptionResource(Client, IotHubDescriptionData.DeserializeIotHubDescriptionData(e)), IotHubDescriptionIotHubResourceClientDiagnostics, Pipeline, "MockableIotHubSubscriptionResource.GetIotHubDescriptions", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get all the IoT hubs in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Devices/IotHubs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotHubResource_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="IotHubDescriptionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<IotHubDescriptionResource> GetIotHubDescriptions(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => IotHubDescriptionIotHubResourceRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => IotHubDescriptionIotHubResourceRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new IotHubDescriptionResource(Client, IotHubDescriptionData.DeserializeIotHubDescriptionData(e)), IotHubDescriptionIotHubResourceClientDiagnostics, Pipeline, "MockableIotHubSubscriptionResource.GetIotHubDescriptions", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Check if an IoT hub name is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Devices/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotHubResource_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Set the name parameter in the OperationInputs structure to the name of the IoT hub to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<IotHubNameAvailabilityResponse>> CheckIotHubNameAvailabilityAsync(IotHubNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = IotHubDescriptionIotHubResourceClientDiagnostics.CreateScope("MockableIotHubSubscriptionResource.CheckIotHubNameAvailability");
            scope.Start();
            try
            {
                var response = await IotHubDescriptionIotHubResourceRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check if an IoT hub name is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Devices/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotHubResource_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Set the name parameter in the OperationInputs structure to the name of the IoT hub to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<IotHubNameAvailabilityResponse> CheckIotHubNameAvailability(IotHubNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = IotHubDescriptionIotHubResourceClientDiagnostics.CreateScope("MockableIotHubSubscriptionResource.CheckIotHubNameAvailability");
            scope.Start();
            try
            {
                var response = IotHubDescriptionIotHubResourceRestClient.CheckNameAvailability(Id.SubscriptionId, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the number of free and paid iot hubs in the subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Devices/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceProviderCommon_GetSubscriptionQuota</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="IotHubUserSubscriptionQuota" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<IotHubUserSubscriptionQuota> GetIotHubUserSubscriptionQuotaAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ResourceProviderCommonRestClient.CreateGetSubscriptionQuotaRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, IotHubUserSubscriptionQuota.DeserializeIotHubUserSubscriptionQuota, ResourceProviderCommonClientDiagnostics, Pipeline, "MockableIotHubSubscriptionResource.GetIotHubUserSubscriptionQuota", "value", null, cancellationToken);
        }

        /// <summary>
        /// Get the number of free and paid iot hubs in the subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Devices/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceProviderCommon_GetSubscriptionQuota</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="IotHubUserSubscriptionQuota" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<IotHubUserSubscriptionQuota> GetIotHubUserSubscriptionQuota(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ResourceProviderCommonRestClient.CreateGetSubscriptionQuotaRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, IotHubUserSubscriptionQuota.DeserializeIotHubUserSubscriptionQuota, ResourceProviderCommonClientDiagnostics, Pipeline, "MockableIotHubSubscriptionResource.GetIotHubUserSubscriptionQuota", "value", null, cancellationToken);
        }
    }
}
