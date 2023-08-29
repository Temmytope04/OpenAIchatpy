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

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A class representing a collection of <see cref="SynapseAttachedDatabaseConfigurationResource" /> and their operations.
    /// Each <see cref="SynapseAttachedDatabaseConfigurationResource" /> in the collection will belong to the same instance of <see cref="SynapseKustoPoolResource" />.
    /// To get a <see cref="SynapseAttachedDatabaseConfigurationCollection" /> instance call the GetSynapseAttachedDatabaseConfigurations method from an instance of <see cref="SynapseKustoPoolResource" />.
    /// </summary>
    public partial class SynapseAttachedDatabaseConfigurationCollection : ArmCollection, IEnumerable<SynapseAttachedDatabaseConfigurationResource>, IAsyncEnumerable<SynapseAttachedDatabaseConfigurationResource>
    {
        private readonly ClientDiagnostics _synapseAttachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsClientDiagnostics;
        private readonly KustoPoolAttachedDatabaseConfigurationsRestOperations _synapseAttachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SynapseAttachedDatabaseConfigurationCollection"/> class for mocking. </summary>
        protected SynapseAttachedDatabaseConfigurationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SynapseAttachedDatabaseConfigurationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SynapseAttachedDatabaseConfigurationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _synapseAttachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", SynapseAttachedDatabaseConfigurationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SynapseAttachedDatabaseConfigurationResource.ResourceType, out string synapseAttachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsApiVersion);
            _synapseAttachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsRestClient = new KustoPoolAttachedDatabaseConfigurationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, synapseAttachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SynapseKustoPoolResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SynapseKustoPoolResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an attached database configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/kustoPools/{kustoPoolName}/attachedDatabaseConfigurations/{attachedDatabaseConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KustoPoolAttachedDatabaseConfigurations_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="attachedDatabaseConfigurationName"> The name of the attached database configuration. </param>
        /// <param name="data"> The database parameters supplied to the CreateOrUpdate operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="attachedDatabaseConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="attachedDatabaseConfigurationName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SynapseAttachedDatabaseConfigurationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string attachedDatabaseConfigurationName, SynapseAttachedDatabaseConfigurationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(attachedDatabaseConfigurationName, nameof(attachedDatabaseConfigurationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _synapseAttachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsClientDiagnostics.CreateScope("SynapseAttachedDatabaseConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _synapseAttachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, attachedDatabaseConfigurationName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SynapseArmOperation<SynapseAttachedDatabaseConfigurationResource>(new SynapseAttachedDatabaseConfigurationOperationSource(Client), _synapseAttachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsClientDiagnostics, Pipeline, _synapseAttachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, attachedDatabaseConfigurationName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates an attached database configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/kustoPools/{kustoPoolName}/attachedDatabaseConfigurations/{attachedDatabaseConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KustoPoolAttachedDatabaseConfigurations_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="attachedDatabaseConfigurationName"> The name of the attached database configuration. </param>
        /// <param name="data"> The database parameters supplied to the CreateOrUpdate operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="attachedDatabaseConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="attachedDatabaseConfigurationName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SynapseAttachedDatabaseConfigurationResource> CreateOrUpdate(WaitUntil waitUntil, string attachedDatabaseConfigurationName, SynapseAttachedDatabaseConfigurationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(attachedDatabaseConfigurationName, nameof(attachedDatabaseConfigurationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _synapseAttachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsClientDiagnostics.CreateScope("SynapseAttachedDatabaseConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _synapseAttachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, attachedDatabaseConfigurationName, data, cancellationToken);
                var operation = new SynapseArmOperation<SynapseAttachedDatabaseConfigurationResource>(new SynapseAttachedDatabaseConfigurationOperationSource(Client), _synapseAttachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsClientDiagnostics, Pipeline, _synapseAttachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, attachedDatabaseConfigurationName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Returns an attached database configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/kustoPools/{kustoPoolName}/attachedDatabaseConfigurations/{attachedDatabaseConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KustoPoolAttachedDatabaseConfigurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="attachedDatabaseConfigurationName"> The name of the attached database configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="attachedDatabaseConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="attachedDatabaseConfigurationName"/> is null. </exception>
        public virtual async Task<Response<SynapseAttachedDatabaseConfigurationResource>> GetAsync(string attachedDatabaseConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(attachedDatabaseConfigurationName, nameof(attachedDatabaseConfigurationName));

            using var scope = _synapseAttachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsClientDiagnostics.CreateScope("SynapseAttachedDatabaseConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = await _synapseAttachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, attachedDatabaseConfigurationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseAttachedDatabaseConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns an attached database configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/kustoPools/{kustoPoolName}/attachedDatabaseConfigurations/{attachedDatabaseConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KustoPoolAttachedDatabaseConfigurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="attachedDatabaseConfigurationName"> The name of the attached database configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="attachedDatabaseConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="attachedDatabaseConfigurationName"/> is null. </exception>
        public virtual Response<SynapseAttachedDatabaseConfigurationResource> Get(string attachedDatabaseConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(attachedDatabaseConfigurationName, nameof(attachedDatabaseConfigurationName));

            using var scope = _synapseAttachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsClientDiagnostics.CreateScope("SynapseAttachedDatabaseConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = _synapseAttachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, attachedDatabaseConfigurationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseAttachedDatabaseConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns the list of attached database configurations of the given Kusto Pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/kustoPools/{kustoPoolName}/attachedDatabaseConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KustoPoolAttachedDatabaseConfigurations_ListByKustoPool</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SynapseAttachedDatabaseConfigurationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SynapseAttachedDatabaseConfigurationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _synapseAttachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsRestClient.CreateListByKustoPoolRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, null, (e, o) => new SynapseAttachedDatabaseConfigurationResource(Client, SynapseAttachedDatabaseConfigurationData.DeserializeSynapseAttachedDatabaseConfigurationData(e)), _synapseAttachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsClientDiagnostics, Pipeline, "SynapseAttachedDatabaseConfigurationCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Returns the list of attached database configurations of the given Kusto Pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/kustoPools/{kustoPoolName}/attachedDatabaseConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KustoPoolAttachedDatabaseConfigurations_ListByKustoPool</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SynapseAttachedDatabaseConfigurationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SynapseAttachedDatabaseConfigurationResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _synapseAttachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsRestClient.CreateListByKustoPoolRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, null, (e, o) => new SynapseAttachedDatabaseConfigurationResource(Client, SynapseAttachedDatabaseConfigurationData.DeserializeSynapseAttachedDatabaseConfigurationData(e)), _synapseAttachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsClientDiagnostics, Pipeline, "SynapseAttachedDatabaseConfigurationCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/kustoPools/{kustoPoolName}/attachedDatabaseConfigurations/{attachedDatabaseConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KustoPoolAttachedDatabaseConfigurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="attachedDatabaseConfigurationName"> The name of the attached database configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="attachedDatabaseConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="attachedDatabaseConfigurationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string attachedDatabaseConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(attachedDatabaseConfigurationName, nameof(attachedDatabaseConfigurationName));

            using var scope = _synapseAttachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsClientDiagnostics.CreateScope("SynapseAttachedDatabaseConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _synapseAttachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, attachedDatabaseConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/kustoPools/{kustoPoolName}/attachedDatabaseConfigurations/{attachedDatabaseConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KustoPoolAttachedDatabaseConfigurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="attachedDatabaseConfigurationName"> The name of the attached database configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="attachedDatabaseConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="attachedDatabaseConfigurationName"/> is null. </exception>
        public virtual Response<bool> Exists(string attachedDatabaseConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(attachedDatabaseConfigurationName, nameof(attachedDatabaseConfigurationName));

            using var scope = _synapseAttachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsClientDiagnostics.CreateScope("SynapseAttachedDatabaseConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = _synapseAttachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, attachedDatabaseConfigurationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SynapseAttachedDatabaseConfigurationResource> IEnumerable<SynapseAttachedDatabaseConfigurationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SynapseAttachedDatabaseConfigurationResource> IAsyncEnumerable<SynapseAttachedDatabaseConfigurationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
