// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.DigitalTwins
{
    /// <summary>
    /// A class representing a collection of <see cref="GroupIdInformationResource" /> and their operations.
    /// Each <see cref="GroupIdInformationResource" /> in the collection will belong to the same instance of <see cref="DigitalTwinsDescriptionResource" />.
    /// To get a <see cref="GroupIdInformationCollection" /> instance call the GetGroupIdInformation method from an instance of <see cref="DigitalTwinsDescriptionResource" />.
    /// </summary>
    public partial class GroupIdInformationCollection : ArmCollection, IEnumerable<GroupIdInformationResource>, IAsyncEnumerable<GroupIdInformationResource>
    {
        private readonly ClientDiagnostics _groupIdInformationPrivateLinkResourcesClientDiagnostics;
        private readonly PrivateLinkResourcesRestOperations _groupIdInformationPrivateLinkResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="GroupIdInformationCollection"/> class for mocking. </summary>
        protected GroupIdInformationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="GroupIdInformationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal GroupIdInformationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _groupIdInformationPrivateLinkResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DigitalTwins", GroupIdInformationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(GroupIdInformationResource.ResourceType, out string groupIdInformationPrivateLinkResourcesApiVersion);
            _groupIdInformationPrivateLinkResourcesRestClient = new PrivateLinkResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, groupIdInformationPrivateLinkResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DigitalTwinsDescriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DigitalTwinsDescriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get the specified private link resource for the given Digital Twin.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DigitalTwins/digitalTwinsInstances/{resourceName}/privateLinkResources/{resourceId}
        /// Operation Id: PrivateLinkResources_Get
        /// </summary>
        /// <param name="resourceId"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/> is null. </exception>
        public virtual async Task<Response<GroupIdInformationResource>> GetAsync(string resourceId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceId, nameof(resourceId));

            using var scope = _groupIdInformationPrivateLinkResourcesClientDiagnostics.CreateScope("GroupIdInformationCollection.Get");
            scope.Start();
            try
            {
                var response = await _groupIdInformationPrivateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, resourceId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GroupIdInformationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the specified private link resource for the given Digital Twin.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DigitalTwins/digitalTwinsInstances/{resourceName}/privateLinkResources/{resourceId}
        /// Operation Id: PrivateLinkResources_Get
        /// </summary>
        /// <param name="resourceId"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/> is null. </exception>
        public virtual Response<GroupIdInformationResource> Get(string resourceId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceId, nameof(resourceId));

            using var scope = _groupIdInformationPrivateLinkResourcesClientDiagnostics.CreateScope("GroupIdInformationCollection.Get");
            scope.Start();
            try
            {
                var response = _groupIdInformationPrivateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, resourceId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GroupIdInformationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List private link resources for given Digital Twin.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DigitalTwins/digitalTwinsInstances/{resourceName}/privateLinkResources
        /// Operation Id: PrivateLinkResources_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GroupIdInformationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GroupIdInformationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<GroupIdInformationResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _groupIdInformationPrivateLinkResourcesClientDiagnostics.CreateScope("GroupIdInformationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _groupIdInformationPrivateLinkResourcesRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new GroupIdInformationResource(Client, value)), null, response.GetRawResponse());
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
        /// List private link resources for given Digital Twin.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DigitalTwins/digitalTwinsInstances/{resourceName}/privateLinkResources
        /// Operation Id: PrivateLinkResources_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GroupIdInformationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GroupIdInformationResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<GroupIdInformationResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _groupIdInformationPrivateLinkResourcesClientDiagnostics.CreateScope("GroupIdInformationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _groupIdInformationPrivateLinkResourcesRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new GroupIdInformationResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DigitalTwins/digitalTwinsInstances/{resourceName}/privateLinkResources/{resourceId}
        /// Operation Id: PrivateLinkResources_Get
        /// </summary>
        /// <param name="resourceId"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string resourceId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceId, nameof(resourceId));

            using var scope = _groupIdInformationPrivateLinkResourcesClientDiagnostics.CreateScope("GroupIdInformationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _groupIdInformationPrivateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, resourceId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DigitalTwins/digitalTwinsInstances/{resourceName}/privateLinkResources/{resourceId}
        /// Operation Id: PrivateLinkResources_Get
        /// </summary>
        /// <param name="resourceId"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/> is null. </exception>
        public virtual Response<bool> Exists(string resourceId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceId, nameof(resourceId));

            using var scope = _groupIdInformationPrivateLinkResourcesClientDiagnostics.CreateScope("GroupIdInformationCollection.Exists");
            scope.Start();
            try
            {
                var response = _groupIdInformationPrivateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, resourceId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<GroupIdInformationResource> IEnumerable<GroupIdInformationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<GroupIdInformationResource> IAsyncEnumerable<GroupIdInformationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
