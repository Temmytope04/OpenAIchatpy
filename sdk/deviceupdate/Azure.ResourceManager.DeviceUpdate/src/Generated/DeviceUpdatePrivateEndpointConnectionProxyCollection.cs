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

namespace Azure.ResourceManager.DeviceUpdate
{
    /// <summary>
    /// A class representing a collection of <see cref="DeviceUpdatePrivateEndpointConnectionProxyResource"/> and their operations.
    /// Each <see cref="DeviceUpdatePrivateEndpointConnectionProxyResource"/> in the collection will belong to the same instance of <see cref="DeviceUpdateAccountResource"/>.
    /// To get a <see cref="DeviceUpdatePrivateEndpointConnectionProxyCollection"/> instance call the GetDeviceUpdatePrivateEndpointConnectionProxies method from an instance of <see cref="DeviceUpdateAccountResource"/>.
    /// </summary>
    public partial class DeviceUpdatePrivateEndpointConnectionProxyCollection : ArmCollection, IEnumerable<DeviceUpdatePrivateEndpointConnectionProxyResource>, IAsyncEnumerable<DeviceUpdatePrivateEndpointConnectionProxyResource>
    {
        private readonly ClientDiagnostics _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesClientDiagnostics;
        private readonly PrivateEndpointConnectionProxiesRestOperations _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesRestClient;

        /// <summary> Initializes a new instance of the <see cref="DeviceUpdatePrivateEndpointConnectionProxyCollection"/> class for mocking. </summary>
        protected DeviceUpdatePrivateEndpointConnectionProxyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DeviceUpdatePrivateEndpointConnectionProxyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DeviceUpdatePrivateEndpointConnectionProxyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DeviceUpdate", DeviceUpdatePrivateEndpointConnectionProxyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DeviceUpdatePrivateEndpointConnectionProxyResource.ResourceType, out string deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesApiVersion);
            _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesRestClient = new PrivateEndpointConnectionProxiesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DeviceUpdateAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DeviceUpdateAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// (INTERNAL - DO NOT USE) Creates or updates the specified private endpoint connection proxy resource associated with the device update account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateEndpointConnectionProxies/{privateEndpointConnectionProxyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnectionProxies_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceUpdatePrivateEndpointConnectionProxyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="privateEndpointConnectionProxyId"> The ID of the private endpoint connection proxy object. </param>
        /// <param name="data"> The parameters for creating a private endpoint connection proxy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionProxyId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionProxyId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DeviceUpdatePrivateEndpointConnectionProxyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string privateEndpointConnectionProxyId, DeviceUpdatePrivateEndpointConnectionProxyData data, CancellationToken cancellationToken = default)
        {
            if (privateEndpointConnectionProxyId == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionProxyId));
            }
            if (privateEndpointConnectionProxyId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(privateEndpointConnectionProxyId));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesClientDiagnostics.CreateScope("DeviceUpdatePrivateEndpointConnectionProxyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionProxyId, data, cancellationToken).ConfigureAwait(false);
                var operation = new DeviceUpdateArmOperation<DeviceUpdatePrivateEndpointConnectionProxyResource>(new DeviceUpdatePrivateEndpointConnectionProxyOperationSource(Client), _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesClientDiagnostics, Pipeline, _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionProxyId, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// (INTERNAL - DO NOT USE) Creates or updates the specified private endpoint connection proxy resource associated with the device update account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateEndpointConnectionProxies/{privateEndpointConnectionProxyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnectionProxies_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceUpdatePrivateEndpointConnectionProxyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="privateEndpointConnectionProxyId"> The ID of the private endpoint connection proxy object. </param>
        /// <param name="data"> The parameters for creating a private endpoint connection proxy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionProxyId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionProxyId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DeviceUpdatePrivateEndpointConnectionProxyResource> CreateOrUpdate(WaitUntil waitUntil, string privateEndpointConnectionProxyId, DeviceUpdatePrivateEndpointConnectionProxyData data, CancellationToken cancellationToken = default)
        {
            if (privateEndpointConnectionProxyId == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionProxyId));
            }
            if (privateEndpointConnectionProxyId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(privateEndpointConnectionProxyId));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesClientDiagnostics.CreateScope("DeviceUpdatePrivateEndpointConnectionProxyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionProxyId, data, cancellationToken);
                var operation = new DeviceUpdateArmOperation<DeviceUpdatePrivateEndpointConnectionProxyResource>(new DeviceUpdatePrivateEndpointConnectionProxyOperationSource(Client), _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesClientDiagnostics, Pipeline, _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionProxyId, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// (INTERNAL - DO NOT USE) Get the specified private endpoint connection proxy associated with the device update account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateEndpointConnectionProxies/{privateEndpointConnectionProxyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnectionProxies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceUpdatePrivateEndpointConnectionProxyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointConnectionProxyId"> The ID of the private endpoint connection proxy object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionProxyId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionProxyId"/> is null. </exception>
        public virtual async Task<Response<DeviceUpdatePrivateEndpointConnectionProxyResource>> GetAsync(string privateEndpointConnectionProxyId, CancellationToken cancellationToken = default)
        {
            if (privateEndpointConnectionProxyId == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionProxyId));
            }
            if (privateEndpointConnectionProxyId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(privateEndpointConnectionProxyId));
            }

            using var scope = _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesClientDiagnostics.CreateScope("DeviceUpdatePrivateEndpointConnectionProxyCollection.Get");
            scope.Start();
            try
            {
                var response = await _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionProxyId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeviceUpdatePrivateEndpointConnectionProxyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// (INTERNAL - DO NOT USE) Get the specified private endpoint connection proxy associated with the device update account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateEndpointConnectionProxies/{privateEndpointConnectionProxyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnectionProxies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceUpdatePrivateEndpointConnectionProxyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointConnectionProxyId"> The ID of the private endpoint connection proxy object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionProxyId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionProxyId"/> is null. </exception>
        public virtual Response<DeviceUpdatePrivateEndpointConnectionProxyResource> Get(string privateEndpointConnectionProxyId, CancellationToken cancellationToken = default)
        {
            if (privateEndpointConnectionProxyId == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionProxyId));
            }
            if (privateEndpointConnectionProxyId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(privateEndpointConnectionProxyId));
            }

            using var scope = _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesClientDiagnostics.CreateScope("DeviceUpdatePrivateEndpointConnectionProxyCollection.Get");
            scope.Start();
            try
            {
                var response = _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionProxyId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeviceUpdatePrivateEndpointConnectionProxyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// (INTERNAL - DO NOT USE) List all private endpoint connection proxies in a device update account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateEndpointConnectionProxies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnectionProxies_ListByAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceUpdatePrivateEndpointConnectionProxyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeviceUpdatePrivateEndpointConnectionProxyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DeviceUpdatePrivateEndpointConnectionProxyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesRestClient.CreateListByAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new DeviceUpdatePrivateEndpointConnectionProxyResource(Client, DeviceUpdatePrivateEndpointConnectionProxyData.DeserializeDeviceUpdatePrivateEndpointConnectionProxyData(e)), _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesClientDiagnostics, Pipeline, "DeviceUpdatePrivateEndpointConnectionProxyCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// (INTERNAL - DO NOT USE) List all private endpoint connection proxies in a device update account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateEndpointConnectionProxies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnectionProxies_ListByAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceUpdatePrivateEndpointConnectionProxyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeviceUpdatePrivateEndpointConnectionProxyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DeviceUpdatePrivateEndpointConnectionProxyResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesRestClient.CreateListByAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new DeviceUpdatePrivateEndpointConnectionProxyResource(Client, DeviceUpdatePrivateEndpointConnectionProxyData.DeserializeDeviceUpdatePrivateEndpointConnectionProxyData(e)), _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesClientDiagnostics, Pipeline, "DeviceUpdatePrivateEndpointConnectionProxyCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateEndpointConnectionProxies/{privateEndpointConnectionProxyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnectionProxies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceUpdatePrivateEndpointConnectionProxyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointConnectionProxyId"> The ID of the private endpoint connection proxy object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionProxyId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionProxyId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string privateEndpointConnectionProxyId, CancellationToken cancellationToken = default)
        {
            if (privateEndpointConnectionProxyId == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionProxyId));
            }
            if (privateEndpointConnectionProxyId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(privateEndpointConnectionProxyId));
            }

            using var scope = _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesClientDiagnostics.CreateScope("DeviceUpdatePrivateEndpointConnectionProxyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionProxyId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateEndpointConnectionProxies/{privateEndpointConnectionProxyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnectionProxies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceUpdatePrivateEndpointConnectionProxyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointConnectionProxyId"> The ID of the private endpoint connection proxy object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionProxyId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionProxyId"/> is null. </exception>
        public virtual Response<bool> Exists(string privateEndpointConnectionProxyId, CancellationToken cancellationToken = default)
        {
            if (privateEndpointConnectionProxyId == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionProxyId));
            }
            if (privateEndpointConnectionProxyId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(privateEndpointConnectionProxyId));
            }

            using var scope = _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesClientDiagnostics.CreateScope("DeviceUpdatePrivateEndpointConnectionProxyCollection.Exists");
            scope.Start();
            try
            {
                var response = _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionProxyId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateEndpointConnectionProxies/{privateEndpointConnectionProxyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnectionProxies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceUpdatePrivateEndpointConnectionProxyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointConnectionProxyId"> The ID of the private endpoint connection proxy object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionProxyId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionProxyId"/> is null. </exception>
        public virtual async Task<NullableResponse<DeviceUpdatePrivateEndpointConnectionProxyResource>> GetIfExistsAsync(string privateEndpointConnectionProxyId, CancellationToken cancellationToken = default)
        {
            if (privateEndpointConnectionProxyId == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionProxyId));
            }
            if (privateEndpointConnectionProxyId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(privateEndpointConnectionProxyId));
            }

            using var scope = _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesClientDiagnostics.CreateScope("DeviceUpdatePrivateEndpointConnectionProxyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionProxyId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DeviceUpdatePrivateEndpointConnectionProxyResource>(response.GetRawResponse());
                return Response.FromValue(new DeviceUpdatePrivateEndpointConnectionProxyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateEndpointConnectionProxies/{privateEndpointConnectionProxyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnectionProxies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceUpdatePrivateEndpointConnectionProxyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointConnectionProxyId"> The ID of the private endpoint connection proxy object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionProxyId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionProxyId"/> is null. </exception>
        public virtual NullableResponse<DeviceUpdatePrivateEndpointConnectionProxyResource> GetIfExists(string privateEndpointConnectionProxyId, CancellationToken cancellationToken = default)
        {
            if (privateEndpointConnectionProxyId == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionProxyId));
            }
            if (privateEndpointConnectionProxyId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(privateEndpointConnectionProxyId));
            }

            using var scope = _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesClientDiagnostics.CreateScope("DeviceUpdatePrivateEndpointConnectionProxyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionProxyId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DeviceUpdatePrivateEndpointConnectionProxyResource>(response.GetRawResponse());
                return Response.FromValue(new DeviceUpdatePrivateEndpointConnectionProxyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DeviceUpdatePrivateEndpointConnectionProxyResource> IEnumerable<DeviceUpdatePrivateEndpointConnectionProxyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DeviceUpdatePrivateEndpointConnectionProxyResource> IAsyncEnumerable<DeviceUpdatePrivateEndpointConnectionProxyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
