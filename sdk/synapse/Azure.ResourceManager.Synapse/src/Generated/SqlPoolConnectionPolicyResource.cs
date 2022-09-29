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
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A Class representing a SqlPoolConnectionPolicy along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SqlPoolConnectionPolicyResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSqlPoolConnectionPolicyResource method.
    /// Otherwise you can get one from its parent resource <see cref="SqlPoolResource" /> using the GetSqlPoolConnectionPolicy method.
    /// </summary>
    public partial class SqlPoolConnectionPolicyResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SqlPoolConnectionPolicyResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string workspaceName, string sqlPoolName, ConnectionPolicyName connectionPolicyName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/connectionPolicies/{connectionPolicyName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _sqlPoolConnectionPolicyClientDiagnostics;
        private readonly SqlPoolConnectionPoliciesRestOperations _sqlPoolConnectionPolicyRestClient;
        private readonly SqlPoolConnectionPolicyData _data;

        /// <summary> Initializes a new instance of the <see cref="SqlPoolConnectionPolicyResource"/> class for mocking. </summary>
        protected SqlPoolConnectionPolicyResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SqlPoolConnectionPolicyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SqlPoolConnectionPolicyResource(ArmClient client, SqlPoolConnectionPolicyData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SqlPoolConnectionPolicyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SqlPoolConnectionPolicyResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlPoolConnectionPolicyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string sqlPoolConnectionPolicyApiVersion);
            _sqlPoolConnectionPolicyRestClient = new SqlPoolConnectionPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlPoolConnectionPolicyApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Synapse/workspaces/sqlPools/connectionPolicies";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SqlPoolConnectionPolicyData Data
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
        /// Get a Sql pool&apos;s connection policy, which is used with table auditing.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/connectionPolicies/{connectionPolicyName}
        /// Operation Id: SqlPoolConnectionPolicies_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SqlPoolConnectionPolicyResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _sqlPoolConnectionPolicyClientDiagnostics.CreateScope("SqlPoolConnectionPolicyResource.Get");
            scope.Start();
            try
            {
                var response = await _sqlPoolConnectionPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlPoolConnectionPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Sql pool&apos;s connection policy, which is used with table auditing.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/connectionPolicies/{connectionPolicyName}
        /// Operation Id: SqlPoolConnectionPolicies_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SqlPoolConnectionPolicyResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _sqlPoolConnectionPolicyClientDiagnostics.CreateScope("SqlPoolConnectionPolicyResource.Get");
            scope.Start();
            try
            {
                var response = _sqlPoolConnectionPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlPoolConnectionPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
