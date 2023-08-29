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

namespace Azure.ResourceManager.StreamAnalytics
{
    /// <summary>
    /// A class representing a collection of <see cref="StreamingJobFunctionResource" /> and their operations.
    /// Each <see cref="StreamingJobFunctionResource" /> in the collection will belong to the same instance of <see cref="StreamingJobResource" />.
    /// To get a <see cref="StreamingJobFunctionCollection" /> instance call the GetStreamingJobFunctions method from an instance of <see cref="StreamingJobResource" />.
    /// </summary>
    public partial class StreamingJobFunctionCollection : ArmCollection, IEnumerable<StreamingJobFunctionResource>, IAsyncEnumerable<StreamingJobFunctionResource>
    {
        private readonly ClientDiagnostics _streamingJobFunctionFunctionsClientDiagnostics;
        private readonly FunctionsRestOperations _streamingJobFunctionFunctionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="StreamingJobFunctionCollection"/> class for mocking. </summary>
        protected StreamingJobFunctionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StreamingJobFunctionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal StreamingJobFunctionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _streamingJobFunctionFunctionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.StreamAnalytics", StreamingJobFunctionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(StreamingJobFunctionResource.ResourceType, out string streamingJobFunctionFunctionsApiVersion);
            _streamingJobFunctionFunctionsRestClient = new FunctionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, streamingJobFunctionFunctionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != StreamingJobResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, StreamingJobResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a function or replaces an already existing function under an existing streaming job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/functions/{functionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Functions_CreateOrReplace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="functionName"> The name of the function. </param>
        /// <param name="data"> The definition of the function that will be used to create a new function or replace the existing one under the streaming job. </param>
        /// <param name="ifMatch"> The ETag of the function. Omit this value to always overwrite the current function. Specify the last-seen ETag value to prevent accidentally overwriting concurrent changes. </param>
        /// <param name="ifNoneMatch"> Set to '*' to allow a new function to be created, but to prevent updating an existing function. Other values will result in a 412 Pre-condition Failed response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<StreamingJobFunctionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string functionName, StreamingJobFunctionData data, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionName, nameof(functionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _streamingJobFunctionFunctionsClientDiagnostics.CreateScope("StreamingJobFunctionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _streamingJobFunctionFunctionsRestClient.CreateOrReplaceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, functionName, data, ifMatch, ifNoneMatch, cancellationToken).ConfigureAwait(false);
                var operation = new StreamAnalyticsArmOperation<StreamingJobFunctionResource>(Response.FromValue(new StreamingJobFunctionResource(Client, response), response.GetRawResponse()));
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
        /// Creates a function or replaces an already existing function under an existing streaming job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/functions/{functionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Functions_CreateOrReplace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="functionName"> The name of the function. </param>
        /// <param name="data"> The definition of the function that will be used to create a new function or replace the existing one under the streaming job. </param>
        /// <param name="ifMatch"> The ETag of the function. Omit this value to always overwrite the current function. Specify the last-seen ETag value to prevent accidentally overwriting concurrent changes. </param>
        /// <param name="ifNoneMatch"> Set to '*' to allow a new function to be created, but to prevent updating an existing function. Other values will result in a 412 Pre-condition Failed response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<StreamingJobFunctionResource> CreateOrUpdate(WaitUntil waitUntil, string functionName, StreamingJobFunctionData data, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionName, nameof(functionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _streamingJobFunctionFunctionsClientDiagnostics.CreateScope("StreamingJobFunctionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _streamingJobFunctionFunctionsRestClient.CreateOrReplace(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, functionName, data, ifMatch, ifNoneMatch, cancellationToken);
                var operation = new StreamAnalyticsArmOperation<StreamingJobFunctionResource>(Response.FromValue(new StreamingJobFunctionResource(Client, response), response.GetRawResponse()));
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
        /// Gets details about the specified function.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/functions/{functionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Functions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="functionName"> The name of the function. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionName"/> is null. </exception>
        public virtual async Task<Response<StreamingJobFunctionResource>> GetAsync(string functionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionName, nameof(functionName));

            using var scope = _streamingJobFunctionFunctionsClientDiagnostics.CreateScope("StreamingJobFunctionCollection.Get");
            scope.Start();
            try
            {
                var response = await _streamingJobFunctionFunctionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, functionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StreamingJobFunctionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets details about the specified function.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/functions/{functionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Functions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="functionName"> The name of the function. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionName"/> is null. </exception>
        public virtual Response<StreamingJobFunctionResource> Get(string functionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionName, nameof(functionName));

            using var scope = _streamingJobFunctionFunctionsClientDiagnostics.CreateScope("StreamingJobFunctionCollection.Get");
            scope.Start();
            try
            {
                var response = _streamingJobFunctionFunctionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, functionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StreamingJobFunctionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all of the functions under the specified streaming job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/functions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Functions_ListByStreamingJob</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="select"> The $select OData query parameter. This is a comma-separated list of structural properties to include in the response, or "*" to include all properties. By default, all properties are returned except diagnostics. Currently only accepts '*' as a valid value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StreamingJobFunctionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StreamingJobFunctionResource> GetAllAsync(string select = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _streamingJobFunctionFunctionsRestClient.CreateListByStreamingJobRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, select);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _streamingJobFunctionFunctionsRestClient.CreateListByStreamingJobNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, select);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new StreamingJobFunctionResource(Client, StreamingJobFunctionData.DeserializeStreamingJobFunctionData(e)), _streamingJobFunctionFunctionsClientDiagnostics, Pipeline, "StreamingJobFunctionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all of the functions under the specified streaming job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/functions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Functions_ListByStreamingJob</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="select"> The $select OData query parameter. This is a comma-separated list of structural properties to include in the response, or "*" to include all properties. By default, all properties are returned except diagnostics. Currently only accepts '*' as a valid value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StreamingJobFunctionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StreamingJobFunctionResource> GetAll(string select = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _streamingJobFunctionFunctionsRestClient.CreateListByStreamingJobRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, select);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _streamingJobFunctionFunctionsRestClient.CreateListByStreamingJobNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, select);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new StreamingJobFunctionResource(Client, StreamingJobFunctionData.DeserializeStreamingJobFunctionData(e)), _streamingJobFunctionFunctionsClientDiagnostics, Pipeline, "StreamingJobFunctionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/functions/{functionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Functions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="functionName"> The name of the function. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string functionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionName, nameof(functionName));

            using var scope = _streamingJobFunctionFunctionsClientDiagnostics.CreateScope("StreamingJobFunctionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _streamingJobFunctionFunctionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, functionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/functions/{functionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Functions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="functionName"> The name of the function. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionName"/> is null. </exception>
        public virtual Response<bool> Exists(string functionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionName, nameof(functionName));

            using var scope = _streamingJobFunctionFunctionsClientDiagnostics.CreateScope("StreamingJobFunctionCollection.Exists");
            scope.Start();
            try
            {
                var response = _streamingJobFunctionFunctionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, functionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<StreamingJobFunctionResource> IEnumerable<StreamingJobFunctionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<StreamingJobFunctionResource> IAsyncEnumerable<StreamingJobFunctionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
