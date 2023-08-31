// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="ManagedInstancePrivateLinkResource" /> and their operations.
    /// Each <see cref="ManagedInstancePrivateLinkResource" /> in the collection will belong to the same instance of <see cref="ManagedInstanceResource" />.
    /// To get a <see cref="ManagedInstancePrivateLinkCollection" /> instance call the GetManagedInstancePrivateLinks method from an instance of <see cref="ManagedInstanceResource" />.
    /// </summary>
    public partial class ManagedInstancePrivateLinkCollection : ArmCollection, IEnumerable<ManagedInstancePrivateLinkResource>, IAsyncEnumerable<ManagedInstancePrivateLinkResource>
    {
        private readonly ClientDiagnostics _managedInstancePrivateLinkManagedInstancePrivateLinkResourcesClientDiagnostics;
        private readonly ManagedInstancePrivateLinkResourcesRestOperations _managedInstancePrivateLinkManagedInstancePrivateLinkResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagedInstancePrivateLinkCollection"/> class for mocking. </summary>
        protected ManagedInstancePrivateLinkCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedInstancePrivateLinkCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ManagedInstancePrivateLinkCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedInstancePrivateLinkManagedInstancePrivateLinkResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ManagedInstancePrivateLinkResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ManagedInstancePrivateLinkResource.ResourceType, out string managedInstancePrivateLinkManagedInstancePrivateLinkResourcesApiVersion);
            _managedInstancePrivateLinkManagedInstancePrivateLinkResourcesRestClient = new ManagedInstancePrivateLinkResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managedInstancePrivateLinkManagedInstancePrivateLinkResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ManagedInstanceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ManagedInstanceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a private link resource for SQL server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/privateLinkResources/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedInstancePrivateLinkResources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupName"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> is null. </exception>
        public virtual async Task<Response<ManagedInstancePrivateLinkResource>> GetAsync(string groupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));

            using var scope = _managedInstancePrivateLinkManagedInstancePrivateLinkResourcesClientDiagnostics.CreateScope("ManagedInstancePrivateLinkCollection.Get");
            scope.Start();
            try
            {
                var response = await _managedInstancePrivateLinkManagedInstancePrivateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstancePrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a private link resource for SQL server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/privateLinkResources/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedInstancePrivateLinkResources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupName"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> is null. </exception>
        public virtual Response<ManagedInstancePrivateLinkResource> Get(string groupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));

            using var scope = _managedInstancePrivateLinkManagedInstancePrivateLinkResourcesClientDiagnostics.CreateScope("ManagedInstancePrivateLinkCollection.Get");
            scope.Start();
            try
            {
                var response = _managedInstancePrivateLinkManagedInstancePrivateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstancePrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the private link resources for SQL server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/privateLinkResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedInstancePrivateLinkResources_ListByManagedInstance</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedInstancePrivateLinkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedInstancePrivateLinkResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _managedInstancePrivateLinkManagedInstancePrivateLinkResourcesRestClient.CreateListByManagedInstanceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _managedInstancePrivateLinkManagedInstancePrivateLinkResourcesRestClient.CreateListByManagedInstanceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new ManagedInstancePrivateLinkResource(Client, ManagedInstancePrivateLinkData.DeserializeManagedInstancePrivateLinkData(e)), _managedInstancePrivateLinkManagedInstancePrivateLinkResourcesClientDiagnostics, Pipeline, "ManagedInstancePrivateLinkCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the private link resources for SQL server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/privateLinkResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedInstancePrivateLinkResources_ListByManagedInstance</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedInstancePrivateLinkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedInstancePrivateLinkResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _managedInstancePrivateLinkManagedInstancePrivateLinkResourcesRestClient.CreateListByManagedInstanceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _managedInstancePrivateLinkManagedInstancePrivateLinkResourcesRestClient.CreateListByManagedInstanceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new ManagedInstancePrivateLinkResource(Client, ManagedInstancePrivateLinkData.DeserializeManagedInstancePrivateLinkData(e)), _managedInstancePrivateLinkManagedInstancePrivateLinkResourcesClientDiagnostics, Pipeline, "ManagedInstancePrivateLinkCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/privateLinkResources/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedInstancePrivateLinkResources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupName"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string groupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));

            using var scope = _managedInstancePrivateLinkManagedInstancePrivateLinkResourcesClientDiagnostics.CreateScope("ManagedInstancePrivateLinkCollection.Exists");
            scope.Start();
            try
            {
                var response = await _managedInstancePrivateLinkManagedInstancePrivateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/privateLinkResources/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedInstancePrivateLinkResources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupName"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> is null. </exception>
        public virtual Response<bool> Exists(string groupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));

            using var scope = _managedInstancePrivateLinkManagedInstancePrivateLinkResourcesClientDiagnostics.CreateScope("ManagedInstancePrivateLinkCollection.Exists");
            scope.Start();
            try
            {
                var response = _managedInstancePrivateLinkManagedInstancePrivateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ManagedInstancePrivateLinkResource> IEnumerable<ManagedInstancePrivateLinkResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ManagedInstancePrivateLinkResource> IAsyncEnumerable<ManagedInstancePrivateLinkResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
