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

namespace Azure.ResourceManager.Logic
{
    /// <summary>
    /// A class representing a collection of <see cref="IntegrationAccountBatchConfigurationResource" /> and their operations.
    /// Each <see cref="IntegrationAccountBatchConfigurationResource" /> in the collection will belong to the same instance of <see cref="IntegrationAccountResource" />.
    /// To get an <see cref="IntegrationAccountBatchConfigurationCollection" /> instance call the GetIntegrationAccountBatchConfigurations method from an instance of <see cref="IntegrationAccountResource" />.
    /// </summary>
    public partial class IntegrationAccountBatchConfigurationCollection : ArmCollection, IEnumerable<IntegrationAccountBatchConfigurationResource>, IAsyncEnumerable<IntegrationAccountBatchConfigurationResource>
    {
        private readonly ClientDiagnostics _integrationAccountBatchConfigurationClientDiagnostics;
        private readonly IntegrationAccountBatchConfigurationsRestOperations _integrationAccountBatchConfigurationRestClient;

        /// <summary> Initializes a new instance of the <see cref="IntegrationAccountBatchConfigurationCollection"/> class for mocking. </summary>
        protected IntegrationAccountBatchConfigurationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="IntegrationAccountBatchConfigurationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal IntegrationAccountBatchConfigurationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _integrationAccountBatchConfigurationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Logic", IntegrationAccountBatchConfigurationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(IntegrationAccountBatchConfigurationResource.ResourceType, out string integrationAccountBatchConfigurationApiVersion);
            _integrationAccountBatchConfigurationRestClient = new IntegrationAccountBatchConfigurationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, integrationAccountBatchConfigurationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != IntegrationAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, IntegrationAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a batch configuration for an integration account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/integrationAccounts/{integrationAccountName}/batchConfigurations/{batchConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationAccountBatchConfigurations_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="batchConfigurationName"> The batch configuration name. </param>
        /// <param name="data"> The batch configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="batchConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="batchConfigurationName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<IntegrationAccountBatchConfigurationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string batchConfigurationName, IntegrationAccountBatchConfigurationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(batchConfigurationName, nameof(batchConfigurationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _integrationAccountBatchConfigurationClientDiagnostics.CreateScope("IntegrationAccountBatchConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _integrationAccountBatchConfigurationRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, batchConfigurationName, data, cancellationToken).ConfigureAwait(false);
                var operation = new LogicArmOperation<IntegrationAccountBatchConfigurationResource>(Response.FromValue(new IntegrationAccountBatchConfigurationResource(Client, response), response.GetRawResponse()));
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
        /// Create or update a batch configuration for an integration account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/integrationAccounts/{integrationAccountName}/batchConfigurations/{batchConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationAccountBatchConfigurations_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="batchConfigurationName"> The batch configuration name. </param>
        /// <param name="data"> The batch configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="batchConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="batchConfigurationName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<IntegrationAccountBatchConfigurationResource> CreateOrUpdate(WaitUntil waitUntil, string batchConfigurationName, IntegrationAccountBatchConfigurationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(batchConfigurationName, nameof(batchConfigurationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _integrationAccountBatchConfigurationClientDiagnostics.CreateScope("IntegrationAccountBatchConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _integrationAccountBatchConfigurationRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, batchConfigurationName, data, cancellationToken);
                var operation = new LogicArmOperation<IntegrationAccountBatchConfigurationResource>(Response.FromValue(new IntegrationAccountBatchConfigurationResource(Client, response), response.GetRawResponse()));
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
        /// Get a batch configuration for an integration account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/integrationAccounts/{integrationAccountName}/batchConfigurations/{batchConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationAccountBatchConfigurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="batchConfigurationName"> The batch configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="batchConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="batchConfigurationName"/> is null. </exception>
        public virtual async Task<Response<IntegrationAccountBatchConfigurationResource>> GetAsync(string batchConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(batchConfigurationName, nameof(batchConfigurationName));

            using var scope = _integrationAccountBatchConfigurationClientDiagnostics.CreateScope("IntegrationAccountBatchConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = await _integrationAccountBatchConfigurationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, batchConfigurationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IntegrationAccountBatchConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a batch configuration for an integration account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/integrationAccounts/{integrationAccountName}/batchConfigurations/{batchConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationAccountBatchConfigurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="batchConfigurationName"> The batch configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="batchConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="batchConfigurationName"/> is null. </exception>
        public virtual Response<IntegrationAccountBatchConfigurationResource> Get(string batchConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(batchConfigurationName, nameof(batchConfigurationName));

            using var scope = _integrationAccountBatchConfigurationClientDiagnostics.CreateScope("IntegrationAccountBatchConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = _integrationAccountBatchConfigurationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, batchConfigurationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IntegrationAccountBatchConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List the batch configurations for an integration account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/integrationAccounts/{integrationAccountName}/batchConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationAccountBatchConfigurations_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="IntegrationAccountBatchConfigurationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<IntegrationAccountBatchConfigurationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _integrationAccountBatchConfigurationRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new IntegrationAccountBatchConfigurationResource(Client, IntegrationAccountBatchConfigurationData.DeserializeIntegrationAccountBatchConfigurationData(e)), _integrationAccountBatchConfigurationClientDiagnostics, Pipeline, "IntegrationAccountBatchConfigurationCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// List the batch configurations for an integration account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/integrationAccounts/{integrationAccountName}/batchConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationAccountBatchConfigurations_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="IntegrationAccountBatchConfigurationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<IntegrationAccountBatchConfigurationResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _integrationAccountBatchConfigurationRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, null, e => new IntegrationAccountBatchConfigurationResource(Client, IntegrationAccountBatchConfigurationData.DeserializeIntegrationAccountBatchConfigurationData(e)), _integrationAccountBatchConfigurationClientDiagnostics, Pipeline, "IntegrationAccountBatchConfigurationCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/integrationAccounts/{integrationAccountName}/batchConfigurations/{batchConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationAccountBatchConfigurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="batchConfigurationName"> The batch configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="batchConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="batchConfigurationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string batchConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(batchConfigurationName, nameof(batchConfigurationName));

            using var scope = _integrationAccountBatchConfigurationClientDiagnostics.CreateScope("IntegrationAccountBatchConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _integrationAccountBatchConfigurationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, batchConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/integrationAccounts/{integrationAccountName}/batchConfigurations/{batchConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationAccountBatchConfigurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="batchConfigurationName"> The batch configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="batchConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="batchConfigurationName"/> is null. </exception>
        public virtual Response<bool> Exists(string batchConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(batchConfigurationName, nameof(batchConfigurationName));

            using var scope = _integrationAccountBatchConfigurationClientDiagnostics.CreateScope("IntegrationAccountBatchConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = _integrationAccountBatchConfigurationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, batchConfigurationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<IntegrationAccountBatchConfigurationResource> IEnumerable<IntegrationAccountBatchConfigurationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<IntegrationAccountBatchConfigurationResource> IAsyncEnumerable<IntegrationAccountBatchConfigurationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
