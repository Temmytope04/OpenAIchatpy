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

namespace Azure.ResourceManager.Logic
{
    /// <summary>
    /// A Class representing a LogicWorkflowRunOperation along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="LogicWorkflowRunOperationResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetLogicWorkflowRunOperationResource method.
    /// Otherwise you can get one from its parent resource <see cref="LogicWorkflowRunResource" /> using the GetLogicWorkflowRunOperation method.
    /// </summary>
    public partial class LogicWorkflowRunOperationResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="LogicWorkflowRunOperationResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string workflowName, string runName, string operationId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}/operations/{operationId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _logicWorkflowRunOperationWorkflowRunOperationsClientDiagnostics;
        private readonly WorkflowRunRestOperations _logicWorkflowRunOperationWorkflowRunOperationsRestClient;
        private readonly LogicWorkflowRunData _data;

        /// <summary> Initializes a new instance of the <see cref="LogicWorkflowRunOperationResource"/> class for mocking. </summary>
        protected LogicWorkflowRunOperationResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "LogicWorkflowRunOperationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal LogicWorkflowRunOperationResource(ArmClient client, LogicWorkflowRunData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="LogicWorkflowRunOperationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal LogicWorkflowRunOperationResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _logicWorkflowRunOperationWorkflowRunOperationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Logic", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string logicWorkflowRunOperationWorkflowRunOperationsApiVersion);
            _logicWorkflowRunOperationWorkflowRunOperationsRestClient = new WorkflowRunRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, logicWorkflowRunOperationWorkflowRunOperationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Logic/workflows/runs/operations";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual LogicWorkflowRunData Data
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
        /// Gets an operation for a run.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}/operations/{operationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRunOperations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<LogicWorkflowRunOperationResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _logicWorkflowRunOperationWorkflowRunOperationsClientDiagnostics.CreateScope("LogicWorkflowRunOperationResource.Get");
            scope.Start();
            try
            {
                var response = await _logicWorkflowRunOperationWorkflowRunOperationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LogicWorkflowRunOperationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an operation for a run.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}/operations/{operationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowRunOperations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<LogicWorkflowRunOperationResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _logicWorkflowRunOperationWorkflowRunOperationsClientDiagnostics.CreateScope("LogicWorkflowRunOperationResource.Get");
            scope.Start();
            try
            {
                var response = _logicWorkflowRunOperationWorkflowRunOperationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LogicWorkflowRunOperationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
