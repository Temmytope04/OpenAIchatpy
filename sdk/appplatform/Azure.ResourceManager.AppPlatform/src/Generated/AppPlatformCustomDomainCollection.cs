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

namespace Azure.ResourceManager.AppPlatform
{
    /// <summary>
    /// A class representing a collection of <see cref="AppPlatformCustomDomainResource" /> and their operations.
    /// Each <see cref="AppPlatformCustomDomainResource" /> in the collection will belong to the same instance of <see cref="AppPlatformAppResource" />.
    /// To get an <see cref="AppPlatformCustomDomainCollection" /> instance call the GetAppPlatformCustomDomains method from an instance of <see cref="AppPlatformAppResource" />.
    /// </summary>
    public partial class AppPlatformCustomDomainCollection : ArmCollection, IEnumerable<AppPlatformCustomDomainResource>, IAsyncEnumerable<AppPlatformCustomDomainResource>
    {
        private readonly ClientDiagnostics _appPlatformCustomDomainCustomDomainsClientDiagnostics;
        private readonly CustomDomainsRestOperations _appPlatformCustomDomainCustomDomainsRestClient;

        /// <summary> Initializes a new instance of the <see cref="AppPlatformCustomDomainCollection"/> class for mocking. </summary>
        protected AppPlatformCustomDomainCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AppPlatformCustomDomainCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AppPlatformCustomDomainCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _appPlatformCustomDomainCustomDomainsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppPlatform", AppPlatformCustomDomainResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AppPlatformCustomDomainResource.ResourceType, out string appPlatformCustomDomainCustomDomainsApiVersion);
            _appPlatformCustomDomainCustomDomainsRestClient = new CustomDomainsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, appPlatformCustomDomainCustomDomainsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AppPlatformAppResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AppPlatformAppResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update custom domain of one lifecycle application.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/domains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomDomains_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="domainName"> The name of the custom domain resource. </param>
        /// <param name="data"> Parameters for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AppPlatformCustomDomainResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string domainName, AppPlatformCustomDomainData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appPlatformCustomDomainCustomDomainsClientDiagnostics.CreateScope("AppPlatformCustomDomainCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _appPlatformCustomDomainCustomDomainsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppPlatformArmOperation<AppPlatformCustomDomainResource>(new AppPlatformCustomDomainOperationSource(Client), _appPlatformCustomDomainCustomDomainsClientDiagnostics, Pipeline, _appPlatformCustomDomainCustomDomainsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update custom domain of one lifecycle application.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/domains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomDomains_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="domainName"> The name of the custom domain resource. </param>
        /// <param name="data"> Parameters for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AppPlatformCustomDomainResource> CreateOrUpdate(WaitUntil waitUntil, string domainName, AppPlatformCustomDomainData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appPlatformCustomDomainCustomDomainsClientDiagnostics.CreateScope("AppPlatformCustomDomainCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _appPlatformCustomDomainCustomDomainsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainName, data, cancellationToken);
                var operation = new AppPlatformArmOperation<AppPlatformCustomDomainResource>(new AppPlatformCustomDomainOperationSource(Client), _appPlatformCustomDomainCustomDomainsClientDiagnostics, Pipeline, _appPlatformCustomDomainCustomDomainsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get the custom domain of one lifecycle application.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/domains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomDomains_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="domainName"> The name of the custom domain resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public virtual async Task<Response<AppPlatformCustomDomainResource>> GetAsync(string domainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));

            using var scope = _appPlatformCustomDomainCustomDomainsClientDiagnostics.CreateScope("AppPlatformCustomDomainCollection.Get");
            scope.Start();
            try
            {
                var response = await _appPlatformCustomDomainCustomDomainsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppPlatformCustomDomainResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the custom domain of one lifecycle application.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/domains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomDomains_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="domainName"> The name of the custom domain resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public virtual Response<AppPlatformCustomDomainResource> Get(string domainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));

            using var scope = _appPlatformCustomDomainCustomDomainsClientDiagnostics.CreateScope("AppPlatformCustomDomainCollection.Get");
            scope.Start();
            try
            {
                var response = _appPlatformCustomDomainCustomDomainsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppPlatformCustomDomainResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List the custom domains of one lifecycle application.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/domains</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomDomains_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AppPlatformCustomDomainResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AppPlatformCustomDomainResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appPlatformCustomDomainCustomDomainsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appPlatformCustomDomainCustomDomainsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AppPlatformCustomDomainResource(Client, AppPlatformCustomDomainData.DeserializeAppPlatformCustomDomainData(e)), _appPlatformCustomDomainCustomDomainsClientDiagnostics, Pipeline, "AppPlatformCustomDomainCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List the custom domains of one lifecycle application.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/domains</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomDomains_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AppPlatformCustomDomainResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AppPlatformCustomDomainResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appPlatformCustomDomainCustomDomainsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appPlatformCustomDomainCustomDomainsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AppPlatformCustomDomainResource(Client, AppPlatformCustomDomainData.DeserializeAppPlatformCustomDomainData(e)), _appPlatformCustomDomainCustomDomainsClientDiagnostics, Pipeline, "AppPlatformCustomDomainCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/domains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomDomains_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="domainName"> The name of the custom domain resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string domainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));

            using var scope = _appPlatformCustomDomainCustomDomainsClientDiagnostics.CreateScope("AppPlatformCustomDomainCollection.Exists");
            scope.Start();
            try
            {
                var response = await _appPlatformCustomDomainCustomDomainsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/domains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomDomains_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="domainName"> The name of the custom domain resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public virtual Response<bool> Exists(string domainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));

            using var scope = _appPlatformCustomDomainCustomDomainsClientDiagnostics.CreateScope("AppPlatformCustomDomainCollection.Exists");
            scope.Start();
            try
            {
                var response = _appPlatformCustomDomainCustomDomainsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AppPlatformCustomDomainResource> IEnumerable<AppPlatformCustomDomainResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AppPlatformCustomDomainResource> IAsyncEnumerable<AppPlatformCustomDomainResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
