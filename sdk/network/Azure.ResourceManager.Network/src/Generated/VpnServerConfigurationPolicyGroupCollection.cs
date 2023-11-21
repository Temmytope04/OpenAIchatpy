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

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="VpnServerConfigurationPolicyGroupResource"/> and their operations.
    /// Each <see cref="VpnServerConfigurationPolicyGroupResource"/> in the collection will belong to the same instance of <see cref="VpnServerConfigurationResource"/>.
    /// To get a <see cref="VpnServerConfigurationPolicyGroupCollection"/> instance call the GetVpnServerConfigurationPolicyGroups method from an instance of <see cref="VpnServerConfigurationResource"/>.
    /// </summary>
    public partial class VpnServerConfigurationPolicyGroupCollection : ArmCollection, IEnumerable<VpnServerConfigurationPolicyGroupResource>, IAsyncEnumerable<VpnServerConfigurationPolicyGroupResource>
    {
        private readonly ClientDiagnostics _vpnServerConfigurationPolicyGroupConfigurationPolicyGroupsClientDiagnostics;
        private readonly ConfigurationPolicyGroupsRestOperations _vpnServerConfigurationPolicyGroupConfigurationPolicyGroupsRestClient;

        /// <summary> Initializes a new instance of the <see cref="VpnServerConfigurationPolicyGroupCollection"/> class for mocking. </summary>
        protected VpnServerConfigurationPolicyGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VpnServerConfigurationPolicyGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VpnServerConfigurationPolicyGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _vpnServerConfigurationPolicyGroupConfigurationPolicyGroupsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", VpnServerConfigurationPolicyGroupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(VpnServerConfigurationPolicyGroupResource.ResourceType, out string vpnServerConfigurationPolicyGroupConfigurationPolicyGroupsApiVersion);
            _vpnServerConfigurationPolicyGroupConfigurationPolicyGroupsRestClient = new ConfigurationPolicyGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, vpnServerConfigurationPolicyGroupConfigurationPolicyGroupsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != VpnServerConfigurationResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, VpnServerConfigurationResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a ConfigurationPolicyGroup if it doesn't exist else updates the existing one.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnServerConfigurations/{vpnServerConfigurationName}/configurationPolicyGroups/{configurationPolicyGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationPolicyGroups_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="configurationPolicyGroupName"> The name of the ConfigurationPolicyGroup. </param>
        /// <param name="data"> Parameters supplied to create or update a VpnServerConfiguration PolicyGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationPolicyGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationPolicyGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<VpnServerConfigurationPolicyGroupResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string configurationPolicyGroupName, VpnServerConfigurationPolicyGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationPolicyGroupName, nameof(configurationPolicyGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _vpnServerConfigurationPolicyGroupConfigurationPolicyGroupsClientDiagnostics.CreateScope("VpnServerConfigurationPolicyGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _vpnServerConfigurationPolicyGroupConfigurationPolicyGroupsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationPolicyGroupName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<VpnServerConfigurationPolicyGroupResource>(new VpnServerConfigurationPolicyGroupOperationSource(Client), _vpnServerConfigurationPolicyGroupConfigurationPolicyGroupsClientDiagnostics, Pipeline, _vpnServerConfigurationPolicyGroupConfigurationPolicyGroupsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationPolicyGroupName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates a ConfigurationPolicyGroup if it doesn't exist else updates the existing one.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnServerConfigurations/{vpnServerConfigurationName}/configurationPolicyGroups/{configurationPolicyGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationPolicyGroups_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="configurationPolicyGroupName"> The name of the ConfigurationPolicyGroup. </param>
        /// <param name="data"> Parameters supplied to create or update a VpnServerConfiguration PolicyGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationPolicyGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationPolicyGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<VpnServerConfigurationPolicyGroupResource> CreateOrUpdate(WaitUntil waitUntil, string configurationPolicyGroupName, VpnServerConfigurationPolicyGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationPolicyGroupName, nameof(configurationPolicyGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _vpnServerConfigurationPolicyGroupConfigurationPolicyGroupsClientDiagnostics.CreateScope("VpnServerConfigurationPolicyGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _vpnServerConfigurationPolicyGroupConfigurationPolicyGroupsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationPolicyGroupName, data, cancellationToken);
                var operation = new NetworkArmOperation<VpnServerConfigurationPolicyGroupResource>(new VpnServerConfigurationPolicyGroupOperationSource(Client), _vpnServerConfigurationPolicyGroupConfigurationPolicyGroupsClientDiagnostics, Pipeline, _vpnServerConfigurationPolicyGroupConfigurationPolicyGroupsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationPolicyGroupName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Retrieves the details of a ConfigurationPolicyGroup.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnServerConfigurations/{vpnServerConfigurationName}/configurationPolicyGroups/{configurationPolicyGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationPolicyGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationPolicyGroupName"> The name of the ConfigurationPolicyGroup being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationPolicyGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationPolicyGroupName"/> is null. </exception>
        public virtual async Task<Response<VpnServerConfigurationPolicyGroupResource>> GetAsync(string configurationPolicyGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationPolicyGroupName, nameof(configurationPolicyGroupName));

            using var scope = _vpnServerConfigurationPolicyGroupConfigurationPolicyGroupsClientDiagnostics.CreateScope("VpnServerConfigurationPolicyGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _vpnServerConfigurationPolicyGroupConfigurationPolicyGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationPolicyGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VpnServerConfigurationPolicyGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the details of a ConfigurationPolicyGroup.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnServerConfigurations/{vpnServerConfigurationName}/configurationPolicyGroups/{configurationPolicyGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationPolicyGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationPolicyGroupName"> The name of the ConfigurationPolicyGroup being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationPolicyGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationPolicyGroupName"/> is null. </exception>
        public virtual Response<VpnServerConfigurationPolicyGroupResource> Get(string configurationPolicyGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationPolicyGroupName, nameof(configurationPolicyGroupName));

            using var scope = _vpnServerConfigurationPolicyGroupConfigurationPolicyGroupsClientDiagnostics.CreateScope("VpnServerConfigurationPolicyGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _vpnServerConfigurationPolicyGroupConfigurationPolicyGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationPolicyGroupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VpnServerConfigurationPolicyGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the configurationPolicyGroups in a resource group for a vpnServerConfiguration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnServerConfigurations/{vpnServerConfigurationName}/configurationPolicyGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>configurationPolicyGroups_ListByVpnServerConfiguration</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VpnServerConfigurationPolicyGroupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VpnServerConfigurationPolicyGroupResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _vpnServerConfigurationPolicyGroupConfigurationPolicyGroupsRestClient.CreateListByVpnServerConfigurationRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _vpnServerConfigurationPolicyGroupConfigurationPolicyGroupsRestClient.CreateListByVpnServerConfigurationNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new VpnServerConfigurationPolicyGroupResource(Client, VpnServerConfigurationPolicyGroupData.DeserializeVpnServerConfigurationPolicyGroupData(e)), _vpnServerConfigurationPolicyGroupConfigurationPolicyGroupsClientDiagnostics, Pipeline, "VpnServerConfigurationPolicyGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the configurationPolicyGroups in a resource group for a vpnServerConfiguration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnServerConfigurations/{vpnServerConfigurationName}/configurationPolicyGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>configurationPolicyGroups_ListByVpnServerConfiguration</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VpnServerConfigurationPolicyGroupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VpnServerConfigurationPolicyGroupResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _vpnServerConfigurationPolicyGroupConfigurationPolicyGroupsRestClient.CreateListByVpnServerConfigurationRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _vpnServerConfigurationPolicyGroupConfigurationPolicyGroupsRestClient.CreateListByVpnServerConfigurationNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new VpnServerConfigurationPolicyGroupResource(Client, VpnServerConfigurationPolicyGroupData.DeserializeVpnServerConfigurationPolicyGroupData(e)), _vpnServerConfigurationPolicyGroupConfigurationPolicyGroupsClientDiagnostics, Pipeline, "VpnServerConfigurationPolicyGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnServerConfigurations/{vpnServerConfigurationName}/configurationPolicyGroups/{configurationPolicyGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationPolicyGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationPolicyGroupName"> The name of the ConfigurationPolicyGroup being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationPolicyGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationPolicyGroupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string configurationPolicyGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationPolicyGroupName, nameof(configurationPolicyGroupName));

            using var scope = _vpnServerConfigurationPolicyGroupConfigurationPolicyGroupsClientDiagnostics.CreateScope("VpnServerConfigurationPolicyGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _vpnServerConfigurationPolicyGroupConfigurationPolicyGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationPolicyGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnServerConfigurations/{vpnServerConfigurationName}/configurationPolicyGroups/{configurationPolicyGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationPolicyGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationPolicyGroupName"> The name of the ConfigurationPolicyGroup being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationPolicyGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationPolicyGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string configurationPolicyGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationPolicyGroupName, nameof(configurationPolicyGroupName));

            using var scope = _vpnServerConfigurationPolicyGroupConfigurationPolicyGroupsClientDiagnostics.CreateScope("VpnServerConfigurationPolicyGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = _vpnServerConfigurationPolicyGroupConfigurationPolicyGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationPolicyGroupName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnServerConfigurations/{vpnServerConfigurationName}/configurationPolicyGroups/{configurationPolicyGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationPolicyGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationPolicyGroupName"> The name of the ConfigurationPolicyGroup being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationPolicyGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationPolicyGroupName"/> is null. </exception>
        public virtual async Task<NullableResponse<VpnServerConfigurationPolicyGroupResource>> GetIfExistsAsync(string configurationPolicyGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationPolicyGroupName, nameof(configurationPolicyGroupName));

            using var scope = _vpnServerConfigurationPolicyGroupConfigurationPolicyGroupsClientDiagnostics.CreateScope("VpnServerConfigurationPolicyGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _vpnServerConfigurationPolicyGroupConfigurationPolicyGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationPolicyGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<VpnServerConfigurationPolicyGroupResource>(response.GetRawResponse());
                return Response.FromValue(new VpnServerConfigurationPolicyGroupResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnServerConfigurations/{vpnServerConfigurationName}/configurationPolicyGroups/{configurationPolicyGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationPolicyGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationPolicyGroupName"> The name of the ConfigurationPolicyGroup being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationPolicyGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationPolicyGroupName"/> is null. </exception>
        public virtual NullableResponse<VpnServerConfigurationPolicyGroupResource> GetIfExists(string configurationPolicyGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationPolicyGroupName, nameof(configurationPolicyGroupName));

            using var scope = _vpnServerConfigurationPolicyGroupConfigurationPolicyGroupsClientDiagnostics.CreateScope("VpnServerConfigurationPolicyGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _vpnServerConfigurationPolicyGroupConfigurationPolicyGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationPolicyGroupName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<VpnServerConfigurationPolicyGroupResource>(response.GetRawResponse());
                return Response.FromValue(new VpnServerConfigurationPolicyGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VpnServerConfigurationPolicyGroupResource> IEnumerable<VpnServerConfigurationPolicyGroupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VpnServerConfigurationPolicyGroupResource> IAsyncEnumerable<VpnServerConfigurationPolicyGroupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
