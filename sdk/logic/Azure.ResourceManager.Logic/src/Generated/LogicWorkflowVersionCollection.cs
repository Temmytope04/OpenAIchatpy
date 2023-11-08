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

namespace Azure.ResourceManager.Logic
{
    /// <summary>
    /// A class representing a collection of <see cref="LogicWorkflowVersionResource" /> and their operations.
    /// Each <see cref="LogicWorkflowVersionResource" /> in the collection will belong to the same instance of <see cref="LogicWorkflowResource" />.
    /// To get a <see cref="LogicWorkflowVersionCollection" /> instance call the GetLogicWorkflowVersions method from an instance of <see cref="LogicWorkflowResource" />.
    /// </summary>
    public partial class LogicWorkflowVersionCollection : ArmCollection, IEnumerable<LogicWorkflowVersionResource>, IAsyncEnumerable<LogicWorkflowVersionResource>
    {
        private readonly ClientDiagnostics _logicWorkflowVersionWorkflowVersionsClientDiagnostics;
        private readonly WorkflowVersionsRestOperations _logicWorkflowVersionWorkflowVersionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="LogicWorkflowVersionCollection"/> class for mocking. </summary>
        protected LogicWorkflowVersionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="LogicWorkflowVersionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal LogicWorkflowVersionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _logicWorkflowVersionWorkflowVersionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Logic", LogicWorkflowVersionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(LogicWorkflowVersionResource.ResourceType, out string logicWorkflowVersionWorkflowVersionsApiVersion);
            _logicWorkflowVersionWorkflowVersionsRestClient = new WorkflowVersionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, logicWorkflowVersionWorkflowVersionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != LogicWorkflowResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, LogicWorkflowResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a workflow version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/versions/{versionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionId"> The workflow versionId. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionId"/> is null. </exception>
        public virtual async Task<Response<LogicWorkflowVersionResource>> GetAsync(string versionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionId, nameof(versionId));

            using var scope = _logicWorkflowVersionWorkflowVersionsClientDiagnostics.CreateScope("LogicWorkflowVersionCollection.Get");
            scope.Start();
            try
            {
                var response = await _logicWorkflowVersionWorkflowVersionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, versionId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LogicWorkflowVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a workflow version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/versions/{versionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionId"> The workflow versionId. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionId"/> is null. </exception>
        public virtual Response<LogicWorkflowVersionResource> Get(string versionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionId, nameof(versionId));

            using var scope = _logicWorkflowVersionWorkflowVersionsClientDiagnostics.CreateScope("LogicWorkflowVersionCollection.Get");
            scope.Start();
            try
            {
                var response = _logicWorkflowVersionWorkflowVersionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, versionId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LogicWorkflowVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of workflow versions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/versions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowVersions_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The number of items to be included in the result. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LogicWorkflowVersionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<LogicWorkflowVersionResource> GetAllAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _logicWorkflowVersionWorkflowVersionsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _logicWorkflowVersionWorkflowVersionsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new LogicWorkflowVersionResource(Client, LogicWorkflowVersionData.DeserializeLogicWorkflowVersionData(e)), _logicWorkflowVersionWorkflowVersionsClientDiagnostics, Pipeline, "LogicWorkflowVersionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of workflow versions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/versions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowVersions_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The number of items to be included in the result. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LogicWorkflowVersionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<LogicWorkflowVersionResource> GetAll(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _logicWorkflowVersionWorkflowVersionsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _logicWorkflowVersionWorkflowVersionsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new LogicWorkflowVersionResource(Client, LogicWorkflowVersionData.DeserializeLogicWorkflowVersionData(e)), _logicWorkflowVersionWorkflowVersionsClientDiagnostics, Pipeline, "LogicWorkflowVersionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/versions/{versionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionId"> The workflow versionId. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string versionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionId, nameof(versionId));

            using var scope = _logicWorkflowVersionWorkflowVersionsClientDiagnostics.CreateScope("LogicWorkflowVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _logicWorkflowVersionWorkflowVersionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, versionId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/versions/{versionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionId"> The workflow versionId. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionId"/> is null. </exception>
        public virtual Response<bool> Exists(string versionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionId, nameof(versionId));

            using var scope = _logicWorkflowVersionWorkflowVersionsClientDiagnostics.CreateScope("LogicWorkflowVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = _logicWorkflowVersionWorkflowVersionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, versionId, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/versions/{versionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionId"> The workflow versionId. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionId"/> is null. </exception>
        public virtual async Task<NullableResponse<LogicWorkflowVersionResource>> GetIfExistsAsync(string versionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionId, nameof(versionId));

            using var scope = _logicWorkflowVersionWorkflowVersionsClientDiagnostics.CreateScope("LogicWorkflowVersionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _logicWorkflowVersionWorkflowVersionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, versionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<LogicWorkflowVersionResource>(response.GetRawResponse());
                return Response.FromValue(new LogicWorkflowVersionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/versions/{versionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionId"> The workflow versionId. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionId"/> is null. </exception>
        public virtual NullableResponse<LogicWorkflowVersionResource> GetIfExists(string versionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionId, nameof(versionId));

            using var scope = _logicWorkflowVersionWorkflowVersionsClientDiagnostics.CreateScope("LogicWorkflowVersionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _logicWorkflowVersionWorkflowVersionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, versionId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<LogicWorkflowVersionResource>(response.GetRawResponse());
                return Response.FromValue(new LogicWorkflowVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<LogicWorkflowVersionResource> IEnumerable<LogicWorkflowVersionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<LogicWorkflowVersionResource> IAsyncEnumerable<LogicWorkflowVersionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
