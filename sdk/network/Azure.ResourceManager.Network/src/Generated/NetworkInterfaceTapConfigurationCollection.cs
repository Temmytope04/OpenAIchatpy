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
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="NetworkInterfaceTapConfigurationResource"/> and their operations.
    /// Each <see cref="NetworkInterfaceTapConfigurationResource"/> in the collection will belong to the same instance of <see cref="NetworkInterfaceResource"/>.
    /// To get a <see cref="NetworkInterfaceTapConfigurationCollection"/> instance call the GetNetworkInterfaceTapConfigurations method from an instance of <see cref="NetworkInterfaceResource"/>.
    /// </summary>
    public partial class NetworkInterfaceTapConfigurationCollection : ArmCollection, IEnumerable<NetworkInterfaceTapConfigurationResource>, IAsyncEnumerable<NetworkInterfaceTapConfigurationResource>
    {
        private readonly ClientDiagnostics _networkInterfaceTapConfigurationClientDiagnostics;
        private readonly NetworkInterfaceTapConfigurationsRestOperations _networkInterfaceTapConfigurationRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkInterfaceTapConfigurationCollection"/> class for mocking. </summary>
        protected NetworkInterfaceTapConfigurationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkInterfaceTapConfigurationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkInterfaceTapConfigurationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkInterfaceTapConfigurationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", NetworkInterfaceTapConfigurationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkInterfaceTapConfigurationResource.ResourceType, out string networkInterfaceTapConfigurationApiVersion);
            _networkInterfaceTapConfigurationRestClient = new NetworkInterfaceTapConfigurationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkInterfaceTapConfigurationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NetworkInterfaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NetworkInterfaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a Tap configuration in the specified NetworkInterface.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}/tapConfigurations/{tapConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkInterfaceTapConfigurations_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkInterfaceTapConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="tapConfigurationName"> The name of the tap configuration. </param>
        /// <param name="data"> Parameters supplied to the create or update tap configuration operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tapConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tapConfigurationName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetworkInterfaceTapConfigurationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string tapConfigurationName, NetworkInterfaceTapConfigurationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tapConfigurationName, nameof(tapConfigurationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkInterfaceTapConfigurationClientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkInterfaceTapConfigurationRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tapConfigurationName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<NetworkInterfaceTapConfigurationResource>(new NetworkInterfaceTapConfigurationOperationSource(Client), _networkInterfaceTapConfigurationClientDiagnostics, Pipeline, _networkInterfaceTapConfigurationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tapConfigurationName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a Tap configuration in the specified NetworkInterface.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}/tapConfigurations/{tapConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkInterfaceTapConfigurations_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkInterfaceTapConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="tapConfigurationName"> The name of the tap configuration. </param>
        /// <param name="data"> Parameters supplied to the create or update tap configuration operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tapConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tapConfigurationName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetworkInterfaceTapConfigurationResource> CreateOrUpdate(WaitUntil waitUntil, string tapConfigurationName, NetworkInterfaceTapConfigurationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tapConfigurationName, nameof(tapConfigurationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkInterfaceTapConfigurationClientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkInterfaceTapConfigurationRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tapConfigurationName, data, cancellationToken);
                var operation = new NetworkArmOperation<NetworkInterfaceTapConfigurationResource>(new NetworkInterfaceTapConfigurationOperationSource(Client), _networkInterfaceTapConfigurationClientDiagnostics, Pipeline, _networkInterfaceTapConfigurationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tapConfigurationName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get the specified tap configuration on a network interface.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}/tapConfigurations/{tapConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkInterfaceTapConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkInterfaceTapConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tapConfigurationName"> The name of the tap configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tapConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tapConfigurationName"/> is null. </exception>
        public virtual async Task<Response<NetworkInterfaceTapConfigurationResource>> GetAsync(string tapConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tapConfigurationName, nameof(tapConfigurationName));

            using var scope = _networkInterfaceTapConfigurationClientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkInterfaceTapConfigurationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tapConfigurationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkInterfaceTapConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the specified tap configuration on a network interface.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}/tapConfigurations/{tapConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkInterfaceTapConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkInterfaceTapConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tapConfigurationName"> The name of the tap configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tapConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tapConfigurationName"/> is null. </exception>
        public virtual Response<NetworkInterfaceTapConfigurationResource> Get(string tapConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tapConfigurationName, nameof(tapConfigurationName));

            using var scope = _networkInterfaceTapConfigurationClientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = _networkInterfaceTapConfigurationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tapConfigurationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkInterfaceTapConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get all Tap configurations in a network interface.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}/tapConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkInterfaceTapConfigurations_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkInterfaceTapConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkInterfaceTapConfigurationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkInterfaceTapConfigurationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkInterfaceTapConfigurationRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkInterfaceTapConfigurationRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetworkInterfaceTapConfigurationResource(Client, NetworkInterfaceTapConfigurationData.DeserializeNetworkInterfaceTapConfigurationData(e)), _networkInterfaceTapConfigurationClientDiagnostics, Pipeline, "NetworkInterfaceTapConfigurationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get all Tap configurations in a network interface.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}/tapConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkInterfaceTapConfigurations_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkInterfaceTapConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkInterfaceTapConfigurationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkInterfaceTapConfigurationResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkInterfaceTapConfigurationRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkInterfaceTapConfigurationRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetworkInterfaceTapConfigurationResource(Client, NetworkInterfaceTapConfigurationData.DeserializeNetworkInterfaceTapConfigurationData(e)), _networkInterfaceTapConfigurationClientDiagnostics, Pipeline, "NetworkInterfaceTapConfigurationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}/tapConfigurations/{tapConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkInterfaceTapConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkInterfaceTapConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tapConfigurationName"> The name of the tap configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tapConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tapConfigurationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string tapConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tapConfigurationName, nameof(tapConfigurationName));

            using var scope = _networkInterfaceTapConfigurationClientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkInterfaceTapConfigurationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tapConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}/tapConfigurations/{tapConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkInterfaceTapConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkInterfaceTapConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tapConfigurationName"> The name of the tap configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tapConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tapConfigurationName"/> is null. </exception>
        public virtual Response<bool> Exists(string tapConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tapConfigurationName, nameof(tapConfigurationName));

            using var scope = _networkInterfaceTapConfigurationClientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkInterfaceTapConfigurationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tapConfigurationName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}/tapConfigurations/{tapConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkInterfaceTapConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkInterfaceTapConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tapConfigurationName"> The name of the tap configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tapConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tapConfigurationName"/> is null. </exception>
        public virtual async Task<NullableResponse<NetworkInterfaceTapConfigurationResource>> GetIfExistsAsync(string tapConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tapConfigurationName, nameof(tapConfigurationName));

            using var scope = _networkInterfaceTapConfigurationClientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _networkInterfaceTapConfigurationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tapConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<NetworkInterfaceTapConfigurationResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkInterfaceTapConfigurationResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}/tapConfigurations/{tapConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkInterfaceTapConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkInterfaceTapConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tapConfigurationName"> The name of the tap configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tapConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tapConfigurationName"/> is null. </exception>
        public virtual NullableResponse<NetworkInterfaceTapConfigurationResource> GetIfExists(string tapConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tapConfigurationName, nameof(tapConfigurationName));

            using var scope = _networkInterfaceTapConfigurationClientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _networkInterfaceTapConfigurationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tapConfigurationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<NetworkInterfaceTapConfigurationResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkInterfaceTapConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkInterfaceTapConfigurationResource> IEnumerable<NetworkInterfaceTapConfigurationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkInterfaceTapConfigurationResource> IAsyncEnumerable<NetworkInterfaceTapConfigurationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
