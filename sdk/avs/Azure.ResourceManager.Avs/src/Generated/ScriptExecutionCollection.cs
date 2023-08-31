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

namespace Azure.ResourceManager.Avs
{
    /// <summary>
    /// A class representing a collection of <see cref="ScriptExecutionResource" /> and their operations.
    /// Each <see cref="ScriptExecutionResource" /> in the collection will belong to the same instance of <see cref="AvsPrivateCloudResource" />.
    /// To get a <see cref="ScriptExecutionCollection" /> instance call the GetScriptExecutions method from an instance of <see cref="AvsPrivateCloudResource" />.
    /// </summary>
    public partial class ScriptExecutionCollection : ArmCollection, IEnumerable<ScriptExecutionResource>, IAsyncEnumerable<ScriptExecutionResource>
    {
        private readonly ClientDiagnostics _scriptExecutionClientDiagnostics;
        private readonly ScriptExecutionsRestOperations _scriptExecutionRestClient;

        /// <summary> Initializes a new instance of the <see cref="ScriptExecutionCollection"/> class for mocking. </summary>
        protected ScriptExecutionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ScriptExecutionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ScriptExecutionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _scriptExecutionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Avs", ScriptExecutionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ScriptExecutionResource.ResourceType, out string scriptExecutionApiVersion);
            _scriptExecutionRestClient = new ScriptExecutionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, scriptExecutionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AvsPrivateCloudResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AvsPrivateCloudResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a script execution in a private cloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/scriptExecutions/{scriptExecutionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScriptExecutions_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="scriptExecutionName"> Name of the user-invoked script execution resource. </param>
        /// <param name="data"> A script running in the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scriptExecutionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptExecutionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ScriptExecutionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string scriptExecutionName, ScriptExecutionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scriptExecutionName, nameof(scriptExecutionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _scriptExecutionClientDiagnostics.CreateScope("ScriptExecutionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _scriptExecutionRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scriptExecutionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AvsArmOperation<ScriptExecutionResource>(new ScriptExecutionOperationSource(Client), _scriptExecutionClientDiagnostics, Pipeline, _scriptExecutionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scriptExecutionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update a script execution in a private cloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/scriptExecutions/{scriptExecutionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScriptExecutions_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="scriptExecutionName"> Name of the user-invoked script execution resource. </param>
        /// <param name="data"> A script running in the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scriptExecutionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptExecutionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ScriptExecutionResource> CreateOrUpdate(WaitUntil waitUntil, string scriptExecutionName, ScriptExecutionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scriptExecutionName, nameof(scriptExecutionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _scriptExecutionClientDiagnostics.CreateScope("ScriptExecutionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _scriptExecutionRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scriptExecutionName, data, cancellationToken);
                var operation = new AvsArmOperation<ScriptExecutionResource>(new ScriptExecutionOperationSource(Client), _scriptExecutionClientDiagnostics, Pipeline, _scriptExecutionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scriptExecutionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get an script execution by name in a private cloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/scriptExecutions/{scriptExecutionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScriptExecutions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scriptExecutionName"> Name of the user-invoked script execution resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scriptExecutionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptExecutionName"/> is null. </exception>
        public virtual async Task<Response<ScriptExecutionResource>> GetAsync(string scriptExecutionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scriptExecutionName, nameof(scriptExecutionName));

            using var scope = _scriptExecutionClientDiagnostics.CreateScope("ScriptExecutionCollection.Get");
            scope.Start();
            try
            {
                var response = await _scriptExecutionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scriptExecutionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScriptExecutionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an script execution by name in a private cloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/scriptExecutions/{scriptExecutionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScriptExecutions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scriptExecutionName"> Name of the user-invoked script execution resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scriptExecutionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptExecutionName"/> is null. </exception>
        public virtual Response<ScriptExecutionResource> Get(string scriptExecutionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scriptExecutionName, nameof(scriptExecutionName));

            using var scope = _scriptExecutionClientDiagnostics.CreateScope("ScriptExecutionCollection.Get");
            scope.Start();
            try
            {
                var response = _scriptExecutionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scriptExecutionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScriptExecutionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List script executions in a private cloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/scriptExecutions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScriptExecutions_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ScriptExecutionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ScriptExecutionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _scriptExecutionRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _scriptExecutionRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new ScriptExecutionResource(Client, ScriptExecutionData.DeserializeScriptExecutionData(e)), _scriptExecutionClientDiagnostics, Pipeline, "ScriptExecutionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List script executions in a private cloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/scriptExecutions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScriptExecutions_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ScriptExecutionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ScriptExecutionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _scriptExecutionRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _scriptExecutionRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new ScriptExecutionResource(Client, ScriptExecutionData.DeserializeScriptExecutionData(e)), _scriptExecutionClientDiagnostics, Pipeline, "ScriptExecutionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/scriptExecutions/{scriptExecutionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScriptExecutions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scriptExecutionName"> Name of the user-invoked script execution resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scriptExecutionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptExecutionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string scriptExecutionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scriptExecutionName, nameof(scriptExecutionName));

            using var scope = _scriptExecutionClientDiagnostics.CreateScope("ScriptExecutionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _scriptExecutionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scriptExecutionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/scriptExecutions/{scriptExecutionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScriptExecutions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scriptExecutionName"> Name of the user-invoked script execution resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scriptExecutionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptExecutionName"/> is null. </exception>
        public virtual Response<bool> Exists(string scriptExecutionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scriptExecutionName, nameof(scriptExecutionName));

            using var scope = _scriptExecutionClientDiagnostics.CreateScope("ScriptExecutionCollection.Exists");
            scope.Start();
            try
            {
                var response = _scriptExecutionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scriptExecutionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ScriptExecutionResource> IEnumerable<ScriptExecutionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ScriptExecutionResource> IAsyncEnumerable<ScriptExecutionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
