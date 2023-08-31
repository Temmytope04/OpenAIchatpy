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

namespace Azure.ResourceManager.AppPlatform
{
    /// <summary>
    /// A class representing a collection of <see cref="AppPlatformGatewayResource" /> and their operations.
    /// Each <see cref="AppPlatformGatewayResource" /> in the collection will belong to the same instance of <see cref="AppPlatformServiceResource" />.
    /// To get an <see cref="AppPlatformGatewayCollection" /> instance call the GetAppPlatformGateways method from an instance of <see cref="AppPlatformServiceResource" />.
    /// </summary>
    public partial class AppPlatformGatewayCollection : ArmCollection, IEnumerable<AppPlatformGatewayResource>, IAsyncEnumerable<AppPlatformGatewayResource>
    {
        private readonly ClientDiagnostics _appPlatformGatewayGatewaysClientDiagnostics;
        private readonly GatewaysRestOperations _appPlatformGatewayGatewaysRestClient;

        /// <summary> Initializes a new instance of the <see cref="AppPlatformGatewayCollection"/> class for mocking. </summary>
        protected AppPlatformGatewayCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AppPlatformGatewayCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AppPlatformGatewayCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _appPlatformGatewayGatewaysClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppPlatform", AppPlatformGatewayResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AppPlatformGatewayResource.ResourceType, out string appPlatformGatewayGatewaysApiVersion);
            _appPlatformGatewayGatewaysRestClient = new GatewaysRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, appPlatformGatewayGatewaysApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AppPlatformServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AppPlatformServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create the default Spring Cloud Gateway or update the existing Spring Cloud Gateway.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/gateways/{gatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Gateways_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="gatewayName"> The name of Spring Cloud Gateway. </param>
        /// <param name="data"> The gateway for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AppPlatformGatewayResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string gatewayName, AppPlatformGatewayData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appPlatformGatewayGatewaysClientDiagnostics.CreateScope("AppPlatformGatewayCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _appPlatformGatewayGatewaysRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, gatewayName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppPlatformArmOperation<AppPlatformGatewayResource>(new AppPlatformGatewayOperationSource(Client), _appPlatformGatewayGatewaysClientDiagnostics, Pipeline, _appPlatformGatewayGatewaysRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, gatewayName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create the default Spring Cloud Gateway or update the existing Spring Cloud Gateway.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/gateways/{gatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Gateways_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="gatewayName"> The name of Spring Cloud Gateway. </param>
        /// <param name="data"> The gateway for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AppPlatformGatewayResource> CreateOrUpdate(WaitUntil waitUntil, string gatewayName, AppPlatformGatewayData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appPlatformGatewayGatewaysClientDiagnostics.CreateScope("AppPlatformGatewayCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _appPlatformGatewayGatewaysRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, gatewayName, data, cancellationToken);
                var operation = new AppPlatformArmOperation<AppPlatformGatewayResource>(new AppPlatformGatewayOperationSource(Client), _appPlatformGatewayGatewaysClientDiagnostics, Pipeline, _appPlatformGatewayGatewaysRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, gatewayName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get the Spring Cloud Gateway and its properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/gateways/{gatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Gateways_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="gatewayName"> The name of Spring Cloud Gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public virtual async Task<Response<AppPlatformGatewayResource>> GetAsync(string gatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));

            using var scope = _appPlatformGatewayGatewaysClientDiagnostics.CreateScope("AppPlatformGatewayCollection.Get");
            scope.Start();
            try
            {
                var response = await _appPlatformGatewayGatewaysRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, gatewayName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppPlatformGatewayResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the Spring Cloud Gateway and its properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/gateways/{gatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Gateways_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="gatewayName"> The name of Spring Cloud Gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public virtual Response<AppPlatformGatewayResource> Get(string gatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));

            using var scope = _appPlatformGatewayGatewaysClientDiagnostics.CreateScope("AppPlatformGatewayCollection.Get");
            scope.Start();
            try
            {
                var response = _appPlatformGatewayGatewaysRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, gatewayName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppPlatformGatewayResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Handles requests to list all resources in a Service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/gateways</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Gateways_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AppPlatformGatewayResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AppPlatformGatewayResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appPlatformGatewayGatewaysRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appPlatformGatewayGatewaysRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new AppPlatformGatewayResource(Client, AppPlatformGatewayData.DeserializeAppPlatformGatewayData(e)), _appPlatformGatewayGatewaysClientDiagnostics, Pipeline, "AppPlatformGatewayCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Handles requests to list all resources in a Service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/gateways</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Gateways_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AppPlatformGatewayResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AppPlatformGatewayResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appPlatformGatewayGatewaysRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appPlatformGatewayGatewaysRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new AppPlatformGatewayResource(Client, AppPlatformGatewayData.DeserializeAppPlatformGatewayData(e)), _appPlatformGatewayGatewaysClientDiagnostics, Pipeline, "AppPlatformGatewayCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/gateways/{gatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Gateways_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="gatewayName"> The name of Spring Cloud Gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string gatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));

            using var scope = _appPlatformGatewayGatewaysClientDiagnostics.CreateScope("AppPlatformGatewayCollection.Exists");
            scope.Start();
            try
            {
                var response = await _appPlatformGatewayGatewaysRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, gatewayName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/gateways/{gatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Gateways_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="gatewayName"> The name of Spring Cloud Gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public virtual Response<bool> Exists(string gatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));

            using var scope = _appPlatformGatewayGatewaysClientDiagnostics.CreateScope("AppPlatformGatewayCollection.Exists");
            scope.Start();
            try
            {
                var response = _appPlatformGatewayGatewaysRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, gatewayName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AppPlatformGatewayResource> IEnumerable<AppPlatformGatewayResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AppPlatformGatewayResource> IAsyncEnumerable<AppPlatformGatewayResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
