// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
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
    /// A Class representing a StreamingJobTransformation along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="StreamingJobTransformationResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetStreamingJobTransformationResource method.
    /// Otherwise you can get one from its parent resource <see cref="StreamingJobResource" /> using the GetStreamingJobTransformation method.
    /// </summary>
    public partial class StreamingJobTransformationResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="StreamingJobTransformationResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string jobName, string transformationName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/transformations/{transformationName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _streamingJobTransformationTransformationsClientDiagnostics;
        private readonly TransformationsRestOperations _streamingJobTransformationTransformationsRestClient;
        private readonly StreamingJobTransformationData _data;

        /// <summary> Initializes a new instance of the <see cref="StreamingJobTransformationResource"/> class for mocking. </summary>
        protected StreamingJobTransformationResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "StreamingJobTransformationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal StreamingJobTransformationResource(ArmClient client, StreamingJobTransformationData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="StreamingJobTransformationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal StreamingJobTransformationResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _streamingJobTransformationTransformationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.StreamAnalytics", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string streamingJobTransformationTransformationsApiVersion);
            _streamingJobTransformationTransformationsRestClient = new TransformationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, streamingJobTransformationTransformationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.StreamAnalytics/streamingjobs/transformations";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual StreamingJobTransformationData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets details about the specified transformation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/transformations/{transformationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Transformations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<StreamingJobTransformationResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _streamingJobTransformationTransformationsClientDiagnostics.CreateScope("StreamingJobTransformationResource.Get");
            scope.Start();
            try
            {
                var response = await _streamingJobTransformationTransformationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StreamingJobTransformationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets details about the specified transformation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/transformations/{transformationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Transformations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<StreamingJobTransformationResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _streamingJobTransformationTransformationsClientDiagnostics.CreateScope("StreamingJobTransformationResource.Get");
            scope.Start();
            try
            {
                var response = _streamingJobTransformationTransformationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StreamingJobTransformationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates an existing transformation under an existing streaming job. This can be used to partially update (ie. update one or two properties) a transformation without affecting the rest the job or transformation definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/transformations/{transformationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Transformations_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="data"> A Transformation object. The properties specified here will overwrite the corresponding properties in the existing transformation (ie. Those properties will be updated). Any properties that are set to null here will mean that the corresponding property in the existing transformation will remain the same and not change as a result of this PATCH operation. </param>
        /// <param name="ifMatch"> The ETag of the transformation. Omit this value to always overwrite the current transformation. Specify the last-seen ETag value to prevent accidentally overwriting concurrent changes. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<Response<StreamingJobTransformationResource>> UpdateAsync(StreamingJobTransformationData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _streamingJobTransformationTransformationsClientDiagnostics.CreateScope("StreamingJobTransformationResource.Update");
            scope.Start();
            try
            {
                var response = await _streamingJobTransformationTransformationsRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, ifMatch, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new StreamingJobTransformationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates an existing transformation under an existing streaming job. This can be used to partially update (ie. update one or two properties) a transformation without affecting the rest the job or transformation definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/transformations/{transformationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Transformations_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="data"> A Transformation object. The properties specified here will overwrite the corresponding properties in the existing transformation (ie. Those properties will be updated). Any properties that are set to null here will mean that the corresponding property in the existing transformation will remain the same and not change as a result of this PATCH operation. </param>
        /// <param name="ifMatch"> The ETag of the transformation. Omit this value to always overwrite the current transformation. Specify the last-seen ETag value to prevent accidentally overwriting concurrent changes. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual Response<StreamingJobTransformationResource> Update(StreamingJobTransformationData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _streamingJobTransformationTransformationsClientDiagnostics.CreateScope("StreamingJobTransformationResource.Update");
            scope.Start();
            try
            {
                var response = _streamingJobTransformationTransformationsRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, ifMatch, cancellationToken);
                return Response.FromValue(new StreamingJobTransformationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
