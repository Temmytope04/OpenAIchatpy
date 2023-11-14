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

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary>
    /// A class representing a collection of <see cref="MachineLearningOutboundRuleBasicResource" /> and their operations.
    /// Each <see cref="MachineLearningOutboundRuleBasicResource" /> in the collection will belong to the same instance of <see cref="MachineLearningWorkspaceResource" />.
    /// To get a <see cref="MachineLearningOutboundRuleBasicCollection" /> instance call the GetMachineLearningOutboundRuleBasics method from an instance of <see cref="MachineLearningWorkspaceResource" />.
    /// </summary>
    public partial class MachineLearningOutboundRuleBasicCollection : ArmCollection, IEnumerable<MachineLearningOutboundRuleBasicResource>, IAsyncEnumerable<MachineLearningOutboundRuleBasicResource>
    {
        private readonly ClientDiagnostics _machineLearningOutboundRuleBasicManagedNetworkSettingsRuleClientDiagnostics;
        private readonly ManagedNetworkSettingsRuleRestOperations _machineLearningOutboundRuleBasicManagedNetworkSettingsRuleRestClient;

        /// <summary> Initializes a new instance of the <see cref="MachineLearningOutboundRuleBasicCollection"/> class for mocking. </summary>
        protected MachineLearningOutboundRuleBasicCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MachineLearningOutboundRuleBasicCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MachineLearningOutboundRuleBasicCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _machineLearningOutboundRuleBasicManagedNetworkSettingsRuleClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MachineLearning", MachineLearningOutboundRuleBasicResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MachineLearningOutboundRuleBasicResource.ResourceType, out string machineLearningOutboundRuleBasicManagedNetworkSettingsRuleApiVersion);
            _machineLearningOutboundRuleBasicManagedNetworkSettingsRuleRestClient = new ManagedNetworkSettingsRuleRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, machineLearningOutboundRuleBasicManagedNetworkSettingsRuleApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MachineLearningWorkspaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MachineLearningWorkspaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an outbound rule in the managed network of a machine learning workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/outboundRules/{ruleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedNetworkSettingsRule_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ruleName"> Name of the workspace managed network outbound rule. </param>
        /// <param name="data"> Outbound Rule to be created or updated in the managed network of a machine learning workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MachineLearningOutboundRuleBasicResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string ruleName, MachineLearningOutboundRuleBasicData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _machineLearningOutboundRuleBasicManagedNetworkSettingsRuleClientDiagnostics.CreateScope("MachineLearningOutboundRuleBasicCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _machineLearningOutboundRuleBasicManagedNetworkSettingsRuleRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MachineLearningArmOperation<MachineLearningOutboundRuleBasicResource>(new MachineLearningOutboundRuleBasicOperationSource(Client), _machineLearningOutboundRuleBasicManagedNetworkSettingsRuleClientDiagnostics, Pipeline, _machineLearningOutboundRuleBasicManagedNetworkSettingsRuleRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates an outbound rule in the managed network of a machine learning workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/outboundRules/{ruleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedNetworkSettingsRule_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ruleName"> Name of the workspace managed network outbound rule. </param>
        /// <param name="data"> Outbound Rule to be created or updated in the managed network of a machine learning workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MachineLearningOutboundRuleBasicResource> CreateOrUpdate(WaitUntil waitUntil, string ruleName, MachineLearningOutboundRuleBasicData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _machineLearningOutboundRuleBasicManagedNetworkSettingsRuleClientDiagnostics.CreateScope("MachineLearningOutboundRuleBasicCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _machineLearningOutboundRuleBasicManagedNetworkSettingsRuleRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleName, data, cancellationToken);
                var operation = new MachineLearningArmOperation<MachineLearningOutboundRuleBasicResource>(new MachineLearningOutboundRuleBasicOperationSource(Client), _machineLearningOutboundRuleBasicManagedNetworkSettingsRuleClientDiagnostics, Pipeline, _machineLearningOutboundRuleBasicManagedNetworkSettingsRuleRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets an outbound rule from the managed network of a machine learning workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/outboundRules/{ruleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedNetworkSettingsRule_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleName"> Name of the workspace managed network outbound rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> is null. </exception>
        public virtual async Task<Response<MachineLearningOutboundRuleBasicResource>> GetAsync(string ruleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));

            using var scope = _machineLearningOutboundRuleBasicManagedNetworkSettingsRuleClientDiagnostics.CreateScope("MachineLearningOutboundRuleBasicCollection.Get");
            scope.Start();
            try
            {
                var response = await _machineLearningOutboundRuleBasicManagedNetworkSettingsRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningOutboundRuleBasicResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an outbound rule from the managed network of a machine learning workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/outboundRules/{ruleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedNetworkSettingsRule_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleName"> Name of the workspace managed network outbound rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> is null. </exception>
        public virtual Response<MachineLearningOutboundRuleBasicResource> Get(string ruleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));

            using var scope = _machineLearningOutboundRuleBasicManagedNetworkSettingsRuleClientDiagnostics.CreateScope("MachineLearningOutboundRuleBasicCollection.Get");
            scope.Start();
            try
            {
                var response = _machineLearningOutboundRuleBasicManagedNetworkSettingsRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningOutboundRuleBasicResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the managed network outbound rules for a machine learning workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/outboundRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedNetworkSettingsRule_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MachineLearningOutboundRuleBasicResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MachineLearningOutboundRuleBasicResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _machineLearningOutboundRuleBasicManagedNetworkSettingsRuleRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _machineLearningOutboundRuleBasicManagedNetworkSettingsRuleRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new MachineLearningOutboundRuleBasicResource(Client, MachineLearningOutboundRuleBasicData.DeserializeMachineLearningOutboundRuleBasicData(e)), _machineLearningOutboundRuleBasicManagedNetworkSettingsRuleClientDiagnostics, Pipeline, "MachineLearningOutboundRuleBasicCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the managed network outbound rules for a machine learning workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/outboundRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedNetworkSettingsRule_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MachineLearningOutboundRuleBasicResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MachineLearningOutboundRuleBasicResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _machineLearningOutboundRuleBasicManagedNetworkSettingsRuleRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _machineLearningOutboundRuleBasicManagedNetworkSettingsRuleRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new MachineLearningOutboundRuleBasicResource(Client, MachineLearningOutboundRuleBasicData.DeserializeMachineLearningOutboundRuleBasicData(e)), _machineLearningOutboundRuleBasicManagedNetworkSettingsRuleClientDiagnostics, Pipeline, "MachineLearningOutboundRuleBasicCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/outboundRules/{ruleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedNetworkSettingsRule_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleName"> Name of the workspace managed network outbound rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string ruleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));

            using var scope = _machineLearningOutboundRuleBasicManagedNetworkSettingsRuleClientDiagnostics.CreateScope("MachineLearningOutboundRuleBasicCollection.Exists");
            scope.Start();
            try
            {
                var response = await _machineLearningOutboundRuleBasicManagedNetworkSettingsRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/outboundRules/{ruleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedNetworkSettingsRule_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleName"> Name of the workspace managed network outbound rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> is null. </exception>
        public virtual Response<bool> Exists(string ruleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));

            using var scope = _machineLearningOutboundRuleBasicManagedNetworkSettingsRuleClientDiagnostics.CreateScope("MachineLearningOutboundRuleBasicCollection.Exists");
            scope.Start();
            try
            {
                var response = _machineLearningOutboundRuleBasicManagedNetworkSettingsRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/outboundRules/{ruleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedNetworkSettingsRule_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleName"> Name of the workspace managed network outbound rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> is null. </exception>
        public virtual async Task<NullableResponse<MachineLearningOutboundRuleBasicResource>> GetIfExistsAsync(string ruleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));

            using var scope = _machineLearningOutboundRuleBasicManagedNetworkSettingsRuleClientDiagnostics.CreateScope("MachineLearningOutboundRuleBasicCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _machineLearningOutboundRuleBasicManagedNetworkSettingsRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MachineLearningOutboundRuleBasicResource>(response.GetRawResponse());
                return Response.FromValue(new MachineLearningOutboundRuleBasicResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/outboundRules/{ruleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedNetworkSettingsRule_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleName"> Name of the workspace managed network outbound rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> is null. </exception>
        public virtual NullableResponse<MachineLearningOutboundRuleBasicResource> GetIfExists(string ruleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));

            using var scope = _machineLearningOutboundRuleBasicManagedNetworkSettingsRuleClientDiagnostics.CreateScope("MachineLearningOutboundRuleBasicCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _machineLearningOutboundRuleBasicManagedNetworkSettingsRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MachineLearningOutboundRuleBasicResource>(response.GetRawResponse());
                return Response.FromValue(new MachineLearningOutboundRuleBasicResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MachineLearningOutboundRuleBasicResource> IEnumerable<MachineLearningOutboundRuleBasicResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MachineLearningOutboundRuleBasicResource> IAsyncEnumerable<MachineLearningOutboundRuleBasicResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
