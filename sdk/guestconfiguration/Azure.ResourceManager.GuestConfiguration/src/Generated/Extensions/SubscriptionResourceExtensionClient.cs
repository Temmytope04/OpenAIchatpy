// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.GuestConfiguration
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _guestConfigurationAssignmentClientDiagnostics;
        private GuestConfigurationAssignmentsRestOperations _guestConfigurationAssignmentRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics GuestConfigurationAssignmentClientDiagnostics => _guestConfigurationAssignmentClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.GuestConfiguration", GuestConfigurationAssignmentResource.ResourceType.Namespace, Diagnostics);
        private GuestConfigurationAssignmentsRestOperations GuestConfigurationAssignmentRestClient => _guestConfigurationAssignmentRestClient ??= new GuestConfigurationAssignmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(GuestConfigurationAssignmentResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// List all guest configuration assignments for a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments
        /// Operation Id: GuestConfigurationAssignments_SubscriptionList
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GuestConfigurationAssignmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GuestConfigurationAssignmentResource> GetGuestConfigurationAssignmentsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<GuestConfigurationAssignmentResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = GuestConfigurationAssignmentClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetGuestConfigurationAssignments");
                scope.Start();
                try
                {
                    var response = await GuestConfigurationAssignmentRestClient.SubscriptionListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new GuestConfigurationAssignmentResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// List all guest configuration assignments for a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments
        /// Operation Id: GuestConfigurationAssignments_SubscriptionList
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GuestConfigurationAssignmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GuestConfigurationAssignmentResource> GetGuestConfigurationAssignments(CancellationToken cancellationToken = default)
        {
            Page<GuestConfigurationAssignmentResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = GuestConfigurationAssignmentClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetGuestConfigurationAssignments");
                scope.Start();
                try
                {
                    var response = GuestConfigurationAssignmentRestClient.SubscriptionList(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new GuestConfigurationAssignmentResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }
    }
}
