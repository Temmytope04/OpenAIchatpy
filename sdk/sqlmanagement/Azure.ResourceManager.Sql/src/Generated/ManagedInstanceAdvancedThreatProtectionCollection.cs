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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="ManagedInstanceAdvancedThreatProtectionResource" /> and their operations.
    /// Each <see cref="ManagedInstanceAdvancedThreatProtectionResource" /> in the collection will belong to the same instance of <see cref="ManagedInstanceResource" />.
    /// To get a <see cref="ManagedInstanceAdvancedThreatProtectionCollection" /> instance call the GetManagedInstanceAdvancedThreatProtections method from an instance of <see cref="ManagedInstanceResource" />.
    /// </summary>
    public partial class ManagedInstanceAdvancedThreatProtectionCollection : ArmCollection, IEnumerable<ManagedInstanceAdvancedThreatProtectionResource>, IAsyncEnumerable<ManagedInstanceAdvancedThreatProtectionResource>
    {
        private readonly ClientDiagnostics _managedInstanceAdvancedThreatProtectionManagedInstanceAdvancedThreatProtectionSettingsClientDiagnostics;
        private readonly ManagedInstanceAdvancedThreatProtectionSettingsRestOperations _managedInstanceAdvancedThreatProtectionManagedInstanceAdvancedThreatProtectionSettingsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceAdvancedThreatProtectionCollection"/> class for mocking. </summary>
        protected ManagedInstanceAdvancedThreatProtectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceAdvancedThreatProtectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ManagedInstanceAdvancedThreatProtectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedInstanceAdvancedThreatProtectionManagedInstanceAdvancedThreatProtectionSettingsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ManagedInstanceAdvancedThreatProtectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ManagedInstanceAdvancedThreatProtectionResource.ResourceType, out string managedInstanceAdvancedThreatProtectionManagedInstanceAdvancedThreatProtectionSettingsApiVersion);
            _managedInstanceAdvancedThreatProtectionManagedInstanceAdvancedThreatProtectionSettingsRestClient = new ManagedInstanceAdvancedThreatProtectionSettingsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managedInstanceAdvancedThreatProtectionManagedInstanceAdvancedThreatProtectionSettingsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ManagedInstanceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ManagedInstanceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates Advanced Threat Protection settings.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/advancedThreatProtectionSettings/{advancedThreatProtectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedInstanceAdvancedThreatProtectionSettings_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="advancedThreatProtectionName"> The name of the Advanced Threat Protection state. </param>
        /// <param name="data"> The managed instance Advanced Threat Protection state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ManagedInstanceAdvancedThreatProtectionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, AdvancedThreatProtectionName advancedThreatProtectionName, ManagedInstanceAdvancedThreatProtectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managedInstanceAdvancedThreatProtectionManagedInstanceAdvancedThreatProtectionSettingsClientDiagnostics.CreateScope("ManagedInstanceAdvancedThreatProtectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _managedInstanceAdvancedThreatProtectionManagedInstanceAdvancedThreatProtectionSettingsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, advancedThreatProtectionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<ManagedInstanceAdvancedThreatProtectionResource>(new ManagedInstanceAdvancedThreatProtectionOperationSource(Client), _managedInstanceAdvancedThreatProtectionManagedInstanceAdvancedThreatProtectionSettingsClientDiagnostics, Pipeline, _managedInstanceAdvancedThreatProtectionManagedInstanceAdvancedThreatProtectionSettingsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, advancedThreatProtectionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates Advanced Threat Protection settings.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/advancedThreatProtectionSettings/{advancedThreatProtectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedInstanceAdvancedThreatProtectionSettings_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="advancedThreatProtectionName"> The name of the Advanced Threat Protection state. </param>
        /// <param name="data"> The managed instance Advanced Threat Protection state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ManagedInstanceAdvancedThreatProtectionResource> CreateOrUpdate(WaitUntil waitUntil, AdvancedThreatProtectionName advancedThreatProtectionName, ManagedInstanceAdvancedThreatProtectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managedInstanceAdvancedThreatProtectionManagedInstanceAdvancedThreatProtectionSettingsClientDiagnostics.CreateScope("ManagedInstanceAdvancedThreatProtectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _managedInstanceAdvancedThreatProtectionManagedInstanceAdvancedThreatProtectionSettingsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, advancedThreatProtectionName, data, cancellationToken);
                var operation = new SqlArmOperation<ManagedInstanceAdvancedThreatProtectionResource>(new ManagedInstanceAdvancedThreatProtectionOperationSource(Client), _managedInstanceAdvancedThreatProtectionManagedInstanceAdvancedThreatProtectionSettingsClientDiagnostics, Pipeline, _managedInstanceAdvancedThreatProtectionManagedInstanceAdvancedThreatProtectionSettingsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, advancedThreatProtectionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get a managed instance's Advanced Threat Protection state.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/advancedThreatProtectionSettings/{advancedThreatProtectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedInstanceAdvancedThreatProtectionSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="advancedThreatProtectionName"> The name of the Advanced Threat Protection state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ManagedInstanceAdvancedThreatProtectionResource>> GetAsync(AdvancedThreatProtectionName advancedThreatProtectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceAdvancedThreatProtectionManagedInstanceAdvancedThreatProtectionSettingsClientDiagnostics.CreateScope("ManagedInstanceAdvancedThreatProtectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _managedInstanceAdvancedThreatProtectionManagedInstanceAdvancedThreatProtectionSettingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, advancedThreatProtectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceAdvancedThreatProtectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a managed instance's Advanced Threat Protection state.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/advancedThreatProtectionSettings/{advancedThreatProtectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedInstanceAdvancedThreatProtectionSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="advancedThreatProtectionName"> The name of the Advanced Threat Protection state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedInstanceAdvancedThreatProtectionResource> Get(AdvancedThreatProtectionName advancedThreatProtectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceAdvancedThreatProtectionManagedInstanceAdvancedThreatProtectionSettingsClientDiagnostics.CreateScope("ManagedInstanceAdvancedThreatProtectionCollection.Get");
            scope.Start();
            try
            {
                var response = _managedInstanceAdvancedThreatProtectionManagedInstanceAdvancedThreatProtectionSettingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, advancedThreatProtectionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceAdvancedThreatProtectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the managed instance's Advanced Threat Protection settings.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/advancedThreatProtectionSettings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedInstanceAdvancedThreatProtectionSettings_ListByInstance</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedInstanceAdvancedThreatProtectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedInstanceAdvancedThreatProtectionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _managedInstanceAdvancedThreatProtectionManagedInstanceAdvancedThreatProtectionSettingsRestClient.CreateListByInstanceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _managedInstanceAdvancedThreatProtectionManagedInstanceAdvancedThreatProtectionSettingsRestClient.CreateListByInstanceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new ManagedInstanceAdvancedThreatProtectionResource(Client, ManagedInstanceAdvancedThreatProtectionData.DeserializeManagedInstanceAdvancedThreatProtectionData(e)), _managedInstanceAdvancedThreatProtectionManagedInstanceAdvancedThreatProtectionSettingsClientDiagnostics, Pipeline, "ManagedInstanceAdvancedThreatProtectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get the managed instance's Advanced Threat Protection settings.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/advancedThreatProtectionSettings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedInstanceAdvancedThreatProtectionSettings_ListByInstance</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedInstanceAdvancedThreatProtectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedInstanceAdvancedThreatProtectionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _managedInstanceAdvancedThreatProtectionManagedInstanceAdvancedThreatProtectionSettingsRestClient.CreateListByInstanceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _managedInstanceAdvancedThreatProtectionManagedInstanceAdvancedThreatProtectionSettingsRestClient.CreateListByInstanceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new ManagedInstanceAdvancedThreatProtectionResource(Client, ManagedInstanceAdvancedThreatProtectionData.DeserializeManagedInstanceAdvancedThreatProtectionData(e)), _managedInstanceAdvancedThreatProtectionManagedInstanceAdvancedThreatProtectionSettingsClientDiagnostics, Pipeline, "ManagedInstanceAdvancedThreatProtectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/advancedThreatProtectionSettings/{advancedThreatProtectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedInstanceAdvancedThreatProtectionSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="advancedThreatProtectionName"> The name of the Advanced Threat Protection state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(AdvancedThreatProtectionName advancedThreatProtectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceAdvancedThreatProtectionManagedInstanceAdvancedThreatProtectionSettingsClientDiagnostics.CreateScope("ManagedInstanceAdvancedThreatProtectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _managedInstanceAdvancedThreatProtectionManagedInstanceAdvancedThreatProtectionSettingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, advancedThreatProtectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/advancedThreatProtectionSettings/{advancedThreatProtectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedInstanceAdvancedThreatProtectionSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="advancedThreatProtectionName"> The name of the Advanced Threat Protection state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(AdvancedThreatProtectionName advancedThreatProtectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceAdvancedThreatProtectionManagedInstanceAdvancedThreatProtectionSettingsClientDiagnostics.CreateScope("ManagedInstanceAdvancedThreatProtectionCollection.Exists");
            scope.Start();
            try
            {
                var response = _managedInstanceAdvancedThreatProtectionManagedInstanceAdvancedThreatProtectionSettingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, advancedThreatProtectionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ManagedInstanceAdvancedThreatProtectionResource> IEnumerable<ManagedInstanceAdvancedThreatProtectionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ManagedInstanceAdvancedThreatProtectionResource> IAsyncEnumerable<ManagedInstanceAdvancedThreatProtectionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
