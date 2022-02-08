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
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of StaticSiteARMResource and their operations over its parent. </summary>
    public partial class StaticSiteARMResourceCollection : ArmCollection, IEnumerable<StaticSiteARMResource>, IAsyncEnumerable<StaticSiteARMResource>
    {
        private readonly ClientDiagnostics _staticSiteARMResourceStaticSitesClientDiagnostics;
        private readonly StaticSitesRestOperations _staticSiteARMResourceStaticSitesRestClient;

        /// <summary> Initializes a new instance of the <see cref="StaticSiteARMResourceCollection"/> class for mocking. </summary>
        protected StaticSiteARMResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StaticSiteARMResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal StaticSiteARMResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _staticSiteARMResourceStaticSitesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", StaticSiteARMResource.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(StaticSiteARMResource.ResourceType, out string staticSiteARMResourceStaticSitesApiVersion);
            _staticSiteARMResourceStaticSitesRestClient = new StaticSitesRestOperations(_staticSiteARMResourceStaticSitesClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, staticSiteARMResourceStaticSitesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: StaticSites_CreateOrUpdateStaticSite
        /// <summary> Description for Creates a new static site in an existing resource group, or updates an existing static site. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="name"> Name of the static site to create or update. </param>
        /// <param name="staticSiteEnvelope"> A JSON representation of the staticsite properties. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="staticSiteEnvelope"/> is null. </exception>
        public async virtual Task<StaticSiteARMResourceCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string name, StaticSiteARMResourceData staticSiteEnvelope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            if (staticSiteEnvelope == null)
            {
                throw new ArgumentNullException(nameof(staticSiteEnvelope));
            }

            using var scope = _staticSiteARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteARMResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _staticSiteARMResourceStaticSitesRestClient.CreateOrUpdateStaticSiteAsync(Id.SubscriptionId, Id.ResourceGroupName, name, staticSiteEnvelope, cancellationToken).ConfigureAwait(false);
                var operation = new StaticSiteARMResourceCreateOrUpdateOperation(Client, _staticSiteARMResourceStaticSitesClientDiagnostics, Pipeline, _staticSiteARMResourceStaticSitesRestClient.CreateCreateOrUpdateStaticSiteRequest(Id.SubscriptionId, Id.ResourceGroupName, name, staticSiteEnvelope).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: StaticSites_CreateOrUpdateStaticSite
        /// <summary> Description for Creates a new static site in an existing resource group, or updates an existing static site. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="name"> Name of the static site to create or update. </param>
        /// <param name="staticSiteEnvelope"> A JSON representation of the staticsite properties. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="staticSiteEnvelope"/> is null. </exception>
        public virtual StaticSiteARMResourceCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string name, StaticSiteARMResourceData staticSiteEnvelope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            if (staticSiteEnvelope == null)
            {
                throw new ArgumentNullException(nameof(staticSiteEnvelope));
            }

            using var scope = _staticSiteARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteARMResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _staticSiteARMResourceStaticSitesRestClient.CreateOrUpdateStaticSite(Id.SubscriptionId, Id.ResourceGroupName, name, staticSiteEnvelope, cancellationToken);
                var operation = new StaticSiteARMResourceCreateOrUpdateOperation(Client, _staticSiteARMResourceStaticSitesClientDiagnostics, Pipeline, _staticSiteARMResourceStaticSitesRestClient.CreateCreateOrUpdateStaticSiteRequest(Id.SubscriptionId, Id.ResourceGroupName, name, staticSiteEnvelope).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: StaticSites_GetStaticSite
        /// <summary> Description for Gets the details of a static site. </summary>
        /// <param name="name"> Name of the static site. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public async virtual Task<Response<StaticSiteARMResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _staticSiteARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteARMResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _staticSiteARMResourceStaticSitesRestClient.GetStaticSiteAsync(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _staticSiteARMResourceStaticSitesClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new StaticSiteARMResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: StaticSites_GetStaticSite
        /// <summary> Description for Gets the details of a static site. </summary>
        /// <param name="name"> Name of the static site. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<StaticSiteARMResource> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _staticSiteARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteARMResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _staticSiteARMResourceStaticSitesRestClient.GetStaticSite(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken);
                if (response.Value == null)
                    throw _staticSiteARMResourceStaticSitesClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StaticSiteARMResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: StaticSites_GetStaticSitesByResourceGroup
        /// <summary> Description for Gets all static sites in the specified resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StaticSiteARMResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StaticSiteARMResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<StaticSiteARMResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _staticSiteARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteARMResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _staticSiteARMResourceStaticSitesRestClient.GetStaticSitesByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new StaticSiteARMResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<StaticSiteARMResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _staticSiteARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteARMResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _staticSiteARMResourceStaticSitesRestClient.GetStaticSitesByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new StaticSiteARMResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: StaticSites_GetStaticSitesByResourceGroup
        /// <summary> Description for Gets all static sites in the specified resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StaticSiteARMResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StaticSiteARMResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<StaticSiteARMResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _staticSiteARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteARMResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _staticSiteARMResourceStaticSitesRestClient.GetStaticSitesByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new StaticSiteARMResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<StaticSiteARMResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _staticSiteARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteARMResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _staticSiteARMResourceStaticSitesRestClient.GetStaticSitesByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new StaticSiteARMResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: StaticSites_GetStaticSite
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="name"> Name of the static site. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _staticSiteARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteARMResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(name, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: StaticSites_GetStaticSite
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="name"> Name of the static site. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _staticSiteARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteARMResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(name, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: StaticSites_GetStaticSite
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> Name of the static site. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public async virtual Task<Response<StaticSiteARMResource>> GetIfExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _staticSiteARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteARMResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _staticSiteARMResourceStaticSitesRestClient.GetStaticSiteAsync(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<StaticSiteARMResource>(null, response.GetRawResponse());
                return Response.FromValue(new StaticSiteARMResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: StaticSites_GetStaticSite
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> Name of the static site. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<StaticSiteARMResource> GetIfExists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _staticSiteARMResourceStaticSitesClientDiagnostics.CreateScope("StaticSiteARMResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _staticSiteARMResourceStaticSitesRestClient.GetStaticSite(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<StaticSiteARMResource>(null, response.GetRawResponse());
                return Response.FromValue(new StaticSiteARMResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<StaticSiteARMResource> IEnumerable<StaticSiteARMResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<StaticSiteARMResource> IAsyncEnumerable<StaticSiteARMResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
