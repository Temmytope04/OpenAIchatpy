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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Communication
{
    /// <summary>
    /// A class representing a collection of <see cref="CommunicationDomainResource" /> and their operations.
    /// Each <see cref="CommunicationDomainResource" /> in the collection will belong to the same instance of <see cref="EmailServiceResource" />.
    /// To get a <see cref="CommunicationDomainResourceCollection" /> instance call the GetCommunicationDomainResources method from an instance of <see cref="EmailServiceResource" />.
    /// </summary>
    public partial class CommunicationDomainResourceCollection : ArmCollection, IEnumerable<CommunicationDomainResource>, IAsyncEnumerable<CommunicationDomainResource>
    {
        private readonly ClientDiagnostics _communicationDomainResourceDomainsClientDiagnostics;
        private readonly DomainsRestOperations _communicationDomainResourceDomainsRestClient;

        /// <summary> Initializes a new instance of the <see cref="CommunicationDomainResourceCollection"/> class for mocking. </summary>
        protected CommunicationDomainResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CommunicationDomainResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CommunicationDomainResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _communicationDomainResourceDomainsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Communication", CommunicationDomainResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CommunicationDomainResource.ResourceType, out string communicationDomainResourceDomainsApiVersion);
            _communicationDomainResourceDomainsRestClient = new DomainsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, communicationDomainResourceDomainsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != EmailServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, EmailServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Add a new Domains resource under the parent EmailService resource or update an existing Domains resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/emailServices/{emailServiceName}/domains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Domains_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="domainName"> The name of the Domains resource. </param>
        /// <param name="data"> Parameters for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<CommunicationDomainResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string domainName, CommunicationDomainResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _communicationDomainResourceDomainsClientDiagnostics.CreateScope("CommunicationDomainResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _communicationDomainResourceDomainsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainName, data, cancellationToken).ConfigureAwait(false);
                var operation = new CommunicationArmOperation<CommunicationDomainResource>(new CommunicationDomainResourceOperationSource(Client), _communicationDomainResourceDomainsClientDiagnostics, Pipeline, _communicationDomainResourceDomainsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Add a new Domains resource under the parent EmailService resource or update an existing Domains resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/emailServices/{emailServiceName}/domains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Domains_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="domainName"> The name of the Domains resource. </param>
        /// <param name="data"> Parameters for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<CommunicationDomainResource> CreateOrUpdate(WaitUntil waitUntil, string domainName, CommunicationDomainResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _communicationDomainResourceDomainsClientDiagnostics.CreateScope("CommunicationDomainResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _communicationDomainResourceDomainsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainName, data, cancellationToken);
                var operation = new CommunicationArmOperation<CommunicationDomainResource>(new CommunicationDomainResourceOperationSource(Client), _communicationDomainResourceDomainsClientDiagnostics, Pipeline, _communicationDomainResourceDomainsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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

        /// <summary>
        /// Get the Domains resource and its properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/emailServices/{emailServiceName}/domains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Domains_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="domainName"> The name of the Domains resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public virtual async Task<Response<CommunicationDomainResource>> GetAsync(string domainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));

            using var scope = _communicationDomainResourceDomainsClientDiagnostics.CreateScope("CommunicationDomainResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _communicationDomainResourceDomainsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CommunicationDomainResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the Domains resource and its properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/emailServices/{emailServiceName}/domains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Domains_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="domainName"> The name of the Domains resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public virtual Response<CommunicationDomainResource> Get(string domainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));

            using var scope = _communicationDomainResourceDomainsClientDiagnostics.CreateScope("CommunicationDomainResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _communicationDomainResourceDomainsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CommunicationDomainResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Handles requests to list all Domains resources under the parent EmailServices resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/emailServices/{emailServiceName}/domains</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Domains_ListByEmailServiceResource</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CommunicationDomainResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CommunicationDomainResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _communicationDomainResourceDomainsRestClient.CreateListByEmailServiceResourceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _communicationDomainResourceDomainsRestClient.CreateListByEmailServiceResourceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new CommunicationDomainResource(Client, CommunicationDomainResourceData.DeserializeCommunicationDomainResourceData(e)), _communicationDomainResourceDomainsClientDiagnostics, Pipeline, "CommunicationDomainResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Handles requests to list all Domains resources under the parent EmailServices resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/emailServices/{emailServiceName}/domains</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Domains_ListByEmailServiceResource</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CommunicationDomainResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CommunicationDomainResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _communicationDomainResourceDomainsRestClient.CreateListByEmailServiceResourceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _communicationDomainResourceDomainsRestClient.CreateListByEmailServiceResourceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new CommunicationDomainResource(Client, CommunicationDomainResourceData.DeserializeCommunicationDomainResourceData(e)), _communicationDomainResourceDomainsClientDiagnostics, Pipeline, "CommunicationDomainResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/emailServices/{emailServiceName}/domains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Domains_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="domainName"> The name of the Domains resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string domainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));

            using var scope = _communicationDomainResourceDomainsClientDiagnostics.CreateScope("CommunicationDomainResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _communicationDomainResourceDomainsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/emailServices/{emailServiceName}/domains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Domains_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="domainName"> The name of the Domains resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public virtual Response<bool> Exists(string domainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));

            using var scope = _communicationDomainResourceDomainsClientDiagnostics.CreateScope("CommunicationDomainResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _communicationDomainResourceDomainsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CommunicationDomainResource> IEnumerable<CommunicationDomainResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CommunicationDomainResource> IAsyncEnumerable<CommunicationDomainResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
