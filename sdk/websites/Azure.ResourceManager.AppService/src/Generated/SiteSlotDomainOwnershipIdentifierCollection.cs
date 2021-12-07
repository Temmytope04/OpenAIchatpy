// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of Identifier and their operations over its parent. </summary>
    public partial class SiteSlotDomainOwnershipIdentifierCollection : ArmCollection, IEnumerable<SiteSlotDomainOwnershipIdentifier>, IAsyncEnumerable<SiteSlotDomainOwnershipIdentifier>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly WebAppsRestOperations _webAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotDomainOwnershipIdentifierCollection"/> class for mocking. </summary>
        protected SiteSlotDomainOwnershipIdentifierCollection()
        {
        }

        /// <summary> Initializes a new instance of SiteSlotDomainOwnershipIdentifierCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SiteSlotDomainOwnershipIdentifierCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _webAppsRestClient = new WebAppsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => SiteSlot.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/domainOwnershipIdentifiers/{domainOwnershipIdentifierName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_CreateOrUpdateDomainOwnershipIdentifierSlot
        /// <summary> Description for Creates a domain ownership identifier for web app, or updates an existing ownership identifier. </summary>
        /// <param name="domainOwnershipIdentifierName"> Name of domain ownership identifier. </param>
        /// <param name="domainOwnershipIdentifier"> A JSON representation of the domain ownership properties. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="domainOwnershipIdentifierName"/> or <paramref name="domainOwnershipIdentifier"/> is null. </exception>
        public virtual WebAppCreateOrUpdateDomainOwnershipIdentifierSlotOperation CreateOrUpdate(string domainOwnershipIdentifierName, IdentifierData domainOwnershipIdentifier, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (domainOwnershipIdentifierName == null)
            {
                throw new ArgumentNullException(nameof(domainOwnershipIdentifierName));
            }
            if (domainOwnershipIdentifier == null)
            {
                throw new ArgumentNullException(nameof(domainOwnershipIdentifier));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotDomainOwnershipIdentifierCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.CreateOrUpdateDomainOwnershipIdentifierSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainOwnershipIdentifierName, domainOwnershipIdentifier, cancellationToken);
                var operation = new WebAppCreateOrUpdateDomainOwnershipIdentifierSlotOperation(Parent, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/domainOwnershipIdentifiers/{domainOwnershipIdentifierName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_CreateOrUpdateDomainOwnershipIdentifierSlot
        /// <summary> Description for Creates a domain ownership identifier for web app, or updates an existing ownership identifier. </summary>
        /// <param name="domainOwnershipIdentifierName"> Name of domain ownership identifier. </param>
        /// <param name="domainOwnershipIdentifier"> A JSON representation of the domain ownership properties. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="domainOwnershipIdentifierName"/> or <paramref name="domainOwnershipIdentifier"/> is null. </exception>
        public async virtual Task<WebAppCreateOrUpdateDomainOwnershipIdentifierSlotOperation> CreateOrUpdateAsync(string domainOwnershipIdentifierName, IdentifierData domainOwnershipIdentifier, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (domainOwnershipIdentifierName == null)
            {
                throw new ArgumentNullException(nameof(domainOwnershipIdentifierName));
            }
            if (domainOwnershipIdentifier == null)
            {
                throw new ArgumentNullException(nameof(domainOwnershipIdentifier));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotDomainOwnershipIdentifierCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.CreateOrUpdateDomainOwnershipIdentifierSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainOwnershipIdentifierName, domainOwnershipIdentifier, cancellationToken).ConfigureAwait(false);
                var operation = new WebAppCreateOrUpdateDomainOwnershipIdentifierSlotOperation(Parent, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/domainOwnershipIdentifiers/{domainOwnershipIdentifierName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_GetDomainOwnershipIdentifierSlot
        /// <summary> Description for Get domain ownership identifier for web app. </summary>
        /// <param name="domainOwnershipIdentifierName"> Name of domain ownership identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="domainOwnershipIdentifierName"/> is null. </exception>
        public virtual Response<SiteSlotDomainOwnershipIdentifier> Get(string domainOwnershipIdentifierName, CancellationToken cancellationToken = default)
        {
            if (domainOwnershipIdentifierName == null)
            {
                throw new ArgumentNullException(nameof(domainOwnershipIdentifierName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotDomainOwnershipIdentifierCollection.Get");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetDomainOwnershipIdentifierSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainOwnershipIdentifierName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotDomainOwnershipIdentifier(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/domainOwnershipIdentifiers/{domainOwnershipIdentifierName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_GetDomainOwnershipIdentifierSlot
        /// <summary> Description for Get domain ownership identifier for web app. </summary>
        /// <param name="domainOwnershipIdentifierName"> Name of domain ownership identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="domainOwnershipIdentifierName"/> is null. </exception>
        public async virtual Task<Response<SiteSlotDomainOwnershipIdentifier>> GetAsync(string domainOwnershipIdentifierName, CancellationToken cancellationToken = default)
        {
            if (domainOwnershipIdentifierName == null)
            {
                throw new ArgumentNullException(nameof(domainOwnershipIdentifierName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotDomainOwnershipIdentifierCollection.Get");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetDomainOwnershipIdentifierSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainOwnershipIdentifierName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteSlotDomainOwnershipIdentifier(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="domainOwnershipIdentifierName"> Name of domain ownership identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="domainOwnershipIdentifierName"/> is null. </exception>
        public virtual Response<SiteSlotDomainOwnershipIdentifier> GetIfExists(string domainOwnershipIdentifierName, CancellationToken cancellationToken = default)
        {
            if (domainOwnershipIdentifierName == null)
            {
                throw new ArgumentNullException(nameof(domainOwnershipIdentifierName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotDomainOwnershipIdentifierCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetDomainOwnershipIdentifierSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainOwnershipIdentifierName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<SiteSlotDomainOwnershipIdentifier>(null, response.GetRawResponse())
                    : Response.FromValue(new SiteSlotDomainOwnershipIdentifier(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="domainOwnershipIdentifierName"> Name of domain ownership identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="domainOwnershipIdentifierName"/> is null. </exception>
        public async virtual Task<Response<SiteSlotDomainOwnershipIdentifier>> GetIfExistsAsync(string domainOwnershipIdentifierName, CancellationToken cancellationToken = default)
        {
            if (domainOwnershipIdentifierName == null)
            {
                throw new ArgumentNullException(nameof(domainOwnershipIdentifierName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotDomainOwnershipIdentifierCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetDomainOwnershipIdentifierSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainOwnershipIdentifierName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<SiteSlotDomainOwnershipIdentifier>(null, response.GetRawResponse())
                    : Response.FromValue(new SiteSlotDomainOwnershipIdentifier(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="domainOwnershipIdentifierName"> Name of domain ownership identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="domainOwnershipIdentifierName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string domainOwnershipIdentifierName, CancellationToken cancellationToken = default)
        {
            if (domainOwnershipIdentifierName == null)
            {
                throw new ArgumentNullException(nameof(domainOwnershipIdentifierName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotDomainOwnershipIdentifierCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(domainOwnershipIdentifierName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="domainOwnershipIdentifierName"> Name of domain ownership identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="domainOwnershipIdentifierName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string domainOwnershipIdentifierName, CancellationToken cancellationToken = default)
        {
            if (domainOwnershipIdentifierName == null)
            {
                throw new ArgumentNullException(nameof(domainOwnershipIdentifierName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotDomainOwnershipIdentifierCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(domainOwnershipIdentifierName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/domainOwnershipIdentifiers
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_ListDomainOwnershipIdentifiersSlot
        /// <summary> Description for Lists ownership identifiers for domain associated with web app. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteSlotDomainOwnershipIdentifier" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteSlotDomainOwnershipIdentifier> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteSlotDomainOwnershipIdentifier> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteSlotDomainOwnershipIdentifierCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webAppsRestClient.ListDomainOwnershipIdentifiersSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotDomainOwnershipIdentifier(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteSlotDomainOwnershipIdentifier> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteSlotDomainOwnershipIdentifierCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webAppsRestClient.ListDomainOwnershipIdentifiersSlotNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotDomainOwnershipIdentifier(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/domainOwnershipIdentifiers
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_ListDomainOwnershipIdentifiersSlot
        /// <summary> Description for Lists ownership identifiers for domain associated with web app. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteSlotDomainOwnershipIdentifier" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteSlotDomainOwnershipIdentifier> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteSlotDomainOwnershipIdentifier>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteSlotDomainOwnershipIdentifierCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webAppsRestClient.ListDomainOwnershipIdentifiersSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotDomainOwnershipIdentifier(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteSlotDomainOwnershipIdentifier>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteSlotDomainOwnershipIdentifierCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webAppsRestClient.ListDomainOwnershipIdentifiersSlotNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotDomainOwnershipIdentifier(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<SiteSlotDomainOwnershipIdentifier> IEnumerable<SiteSlotDomainOwnershipIdentifier>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteSlotDomainOwnershipIdentifier> IAsyncEnumerable<SiteSlotDomainOwnershipIdentifier>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, SiteSlotDomainOwnershipIdentifier, IdentifierData> Construct() { }
    }
}
