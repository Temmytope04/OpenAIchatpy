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

namespace Azure.ResourceManager.NewRelicObservability
{
    /// <summary>
    /// A class representing a collection of <see cref="NewRelicObservabilityTagRuleResource"/> and their operations.
    /// Each <see cref="NewRelicObservabilityTagRuleResource"/> in the collection will belong to the same instance of <see cref="NewRelicMonitorResource"/>.
    /// To get a <see cref="NewRelicObservabilityTagRuleCollection"/> instance call the GetNewRelicObservabilityTagRules method from an instance of <see cref="NewRelicMonitorResource"/>.
    /// </summary>
    public partial class NewRelicObservabilityTagRuleCollection : ArmCollection, IEnumerable<NewRelicObservabilityTagRuleResource>, IAsyncEnumerable<NewRelicObservabilityTagRuleResource>
    {
        private readonly ClientDiagnostics _newRelicObservabilityTagRuleTagRulesClientDiagnostics;
        private readonly TagRulesRestOperations _newRelicObservabilityTagRuleTagRulesRestClient;

        /// <summary> Initializes a new instance of the <see cref="NewRelicObservabilityTagRuleCollection"/> class for mocking. </summary>
        protected NewRelicObservabilityTagRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NewRelicObservabilityTagRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NewRelicObservabilityTagRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _newRelicObservabilityTagRuleTagRulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.NewRelicObservability", NewRelicObservabilityTagRuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NewRelicObservabilityTagRuleResource.ResourceType, out string newRelicObservabilityTagRuleTagRulesApiVersion);
            _newRelicObservabilityTagRuleTagRulesRestClient = new TagRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, newRelicObservabilityTagRuleTagRulesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NewRelicMonitorResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NewRelicMonitorResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a TagRule
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/NewRelic.Observability/monitors/{monitorName}/tagRules/{ruleSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TagRules_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NewRelicObservabilityTagRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ruleSetName"> Name of the TagRule. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleSetName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NewRelicObservabilityTagRuleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string ruleSetName, NewRelicObservabilityTagRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleSetName, nameof(ruleSetName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _newRelicObservabilityTagRuleTagRulesClientDiagnostics.CreateScope("NewRelicObservabilityTagRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _newRelicObservabilityTagRuleTagRulesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NewRelicObservabilityArmOperation<NewRelicObservabilityTagRuleResource>(new NewRelicObservabilityTagRuleOperationSource(Client), _newRelicObservabilityTagRuleTagRulesClientDiagnostics, Pipeline, _newRelicObservabilityTagRuleTagRulesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a TagRule
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/NewRelic.Observability/monitors/{monitorName}/tagRules/{ruleSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TagRules_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NewRelicObservabilityTagRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ruleSetName"> Name of the TagRule. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleSetName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NewRelicObservabilityTagRuleResource> CreateOrUpdate(WaitUntil waitUntil, string ruleSetName, NewRelicObservabilityTagRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleSetName, nameof(ruleSetName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _newRelicObservabilityTagRuleTagRulesClientDiagnostics.CreateScope("NewRelicObservabilityTagRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _newRelicObservabilityTagRuleTagRulesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName, data, cancellationToken);
                var operation = new NewRelicObservabilityArmOperation<NewRelicObservabilityTagRuleResource>(new NewRelicObservabilityTagRuleOperationSource(Client), _newRelicObservabilityTagRuleTagRulesClientDiagnostics, Pipeline, _newRelicObservabilityTagRuleTagRulesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get a TagRule
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/NewRelic.Observability/monitors/{monitorName}/tagRules/{ruleSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TagRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NewRelicObservabilityTagRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleSetName"> Name of the TagRule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleSetName"/> is null. </exception>
        public virtual async Task<Response<NewRelicObservabilityTagRuleResource>> GetAsync(string ruleSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleSetName, nameof(ruleSetName));

            using var scope = _newRelicObservabilityTagRuleTagRulesClientDiagnostics.CreateScope("NewRelicObservabilityTagRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _newRelicObservabilityTagRuleTagRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NewRelicObservabilityTagRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a TagRule
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/NewRelic.Observability/monitors/{monitorName}/tagRules/{ruleSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TagRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NewRelicObservabilityTagRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleSetName"> Name of the TagRule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleSetName"/> is null. </exception>
        public virtual Response<NewRelicObservabilityTagRuleResource> Get(string ruleSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleSetName, nameof(ruleSetName));

            using var scope = _newRelicObservabilityTagRuleTagRulesClientDiagnostics.CreateScope("NewRelicObservabilityTagRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _newRelicObservabilityTagRuleTagRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NewRelicObservabilityTagRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List TagRule resources by NewRelicMonitorResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/NewRelic.Observability/monitors/{monitorName}/tagRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TagRules_ListByNewRelicMonitorResource</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NewRelicObservabilityTagRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NewRelicObservabilityTagRuleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NewRelicObservabilityTagRuleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _newRelicObservabilityTagRuleTagRulesRestClient.CreateListByNewRelicMonitorResourceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _newRelicObservabilityTagRuleTagRulesRestClient.CreateListByNewRelicMonitorResourceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NewRelicObservabilityTagRuleResource(Client, NewRelicObservabilityTagRuleData.DeserializeNewRelicObservabilityTagRuleData(e)), _newRelicObservabilityTagRuleTagRulesClientDiagnostics, Pipeline, "NewRelicObservabilityTagRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List TagRule resources by NewRelicMonitorResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/NewRelic.Observability/monitors/{monitorName}/tagRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TagRules_ListByNewRelicMonitorResource</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NewRelicObservabilityTagRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NewRelicObservabilityTagRuleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NewRelicObservabilityTagRuleResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _newRelicObservabilityTagRuleTagRulesRestClient.CreateListByNewRelicMonitorResourceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _newRelicObservabilityTagRuleTagRulesRestClient.CreateListByNewRelicMonitorResourceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NewRelicObservabilityTagRuleResource(Client, NewRelicObservabilityTagRuleData.DeserializeNewRelicObservabilityTagRuleData(e)), _newRelicObservabilityTagRuleTagRulesClientDiagnostics, Pipeline, "NewRelicObservabilityTagRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/NewRelic.Observability/monitors/{monitorName}/tagRules/{ruleSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TagRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NewRelicObservabilityTagRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleSetName"> Name of the TagRule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleSetName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string ruleSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleSetName, nameof(ruleSetName));

            using var scope = _newRelicObservabilityTagRuleTagRulesClientDiagnostics.CreateScope("NewRelicObservabilityTagRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _newRelicObservabilityTagRuleTagRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/NewRelic.Observability/monitors/{monitorName}/tagRules/{ruleSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TagRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NewRelicObservabilityTagRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleSetName"> Name of the TagRule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleSetName"/> is null. </exception>
        public virtual Response<bool> Exists(string ruleSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleSetName, nameof(ruleSetName));

            using var scope = _newRelicObservabilityTagRuleTagRulesClientDiagnostics.CreateScope("NewRelicObservabilityTagRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = _newRelicObservabilityTagRuleTagRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/NewRelic.Observability/monitors/{monitorName}/tagRules/{ruleSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TagRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NewRelicObservabilityTagRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleSetName"> Name of the TagRule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleSetName"/> is null. </exception>
        public virtual async Task<NullableResponse<NewRelicObservabilityTagRuleResource>> GetIfExistsAsync(string ruleSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleSetName, nameof(ruleSetName));

            using var scope = _newRelicObservabilityTagRuleTagRulesClientDiagnostics.CreateScope("NewRelicObservabilityTagRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _newRelicObservabilityTagRuleTagRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<NewRelicObservabilityTagRuleResource>(response.GetRawResponse());
                return Response.FromValue(new NewRelicObservabilityTagRuleResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/NewRelic.Observability/monitors/{monitorName}/tagRules/{ruleSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TagRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NewRelicObservabilityTagRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleSetName"> Name of the TagRule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleSetName"/> is null. </exception>
        public virtual NullableResponse<NewRelicObservabilityTagRuleResource> GetIfExists(string ruleSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleSetName, nameof(ruleSetName));

            using var scope = _newRelicObservabilityTagRuleTagRulesClientDiagnostics.CreateScope("NewRelicObservabilityTagRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _newRelicObservabilityTagRuleTagRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<NewRelicObservabilityTagRuleResource>(response.GetRawResponse());
                return Response.FromValue(new NewRelicObservabilityTagRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NewRelicObservabilityTagRuleResource> IEnumerable<NewRelicObservabilityTagRuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NewRelicObservabilityTagRuleResource> IAsyncEnumerable<NewRelicObservabilityTagRuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
