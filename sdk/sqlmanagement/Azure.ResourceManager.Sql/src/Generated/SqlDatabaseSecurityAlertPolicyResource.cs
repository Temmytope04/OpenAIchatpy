// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A Class representing a SqlDatabaseSecurityAlertPolicy along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SqlDatabaseSecurityAlertPolicyResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSqlDatabaseSecurityAlertPolicyResource method.
    /// Otherwise you can get one from its parent resource <see cref="SqlDatabaseResource"/> using the GetSqlDatabaseSecurityAlertPolicy method.
    /// </summary>
    public partial class SqlDatabaseSecurityAlertPolicyResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SqlDatabaseSecurityAlertPolicyResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="serverName"> The serverName. </param>
        /// <param name="databaseName"> The databaseName. </param>
        /// <param name="securityAlertPolicyName"> The securityAlertPolicyName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serverName, string databaseName, SqlSecurityAlertPolicyName securityAlertPolicyName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/securityAlertPolicies/{securityAlertPolicyName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _sqlDatabaseSecurityAlertPolicyDatabaseSecurityAlertPoliciesClientDiagnostics;
        private readonly DatabaseSecurityAlertPoliciesRestOperations _sqlDatabaseSecurityAlertPolicyDatabaseSecurityAlertPoliciesRestClient;
        private readonly SqlDatabaseSecurityAlertPolicyData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/servers/databases/securityAlertPolicies";

        /// <summary> Initializes a new instance of the <see cref="SqlDatabaseSecurityAlertPolicyResource"/> class for mocking. </summary>
        protected SqlDatabaseSecurityAlertPolicyResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SqlDatabaseSecurityAlertPolicyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SqlDatabaseSecurityAlertPolicyResource(ArmClient client, SqlDatabaseSecurityAlertPolicyData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SqlDatabaseSecurityAlertPolicyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SqlDatabaseSecurityAlertPolicyResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlDatabaseSecurityAlertPolicyDatabaseSecurityAlertPoliciesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string sqlDatabaseSecurityAlertPolicyDatabaseSecurityAlertPoliciesApiVersion);
            _sqlDatabaseSecurityAlertPolicyDatabaseSecurityAlertPoliciesRestClient = new DatabaseSecurityAlertPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlDatabaseSecurityAlertPolicyDatabaseSecurityAlertPoliciesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SqlDatabaseSecurityAlertPolicyData Data
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
        /// Gets a database's security alert policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/securityAlertPolicies/{securityAlertPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseSecurityAlertPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlDatabaseSecurityAlertPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SqlDatabaseSecurityAlertPolicyResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _sqlDatabaseSecurityAlertPolicyDatabaseSecurityAlertPoliciesClientDiagnostics.CreateScope("SqlDatabaseSecurityAlertPolicyResource.Get");
            scope.Start();
            try
            {
                var response = await _sqlDatabaseSecurityAlertPolicyDatabaseSecurityAlertPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlDatabaseSecurityAlertPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a database's security alert policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/securityAlertPolicies/{securityAlertPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseSecurityAlertPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlDatabaseSecurityAlertPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SqlDatabaseSecurityAlertPolicyResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _sqlDatabaseSecurityAlertPolicyDatabaseSecurityAlertPoliciesClientDiagnostics.CreateScope("SqlDatabaseSecurityAlertPolicyResource.Get");
            scope.Start();
            try
            {
                var response = _sqlDatabaseSecurityAlertPolicyDatabaseSecurityAlertPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlDatabaseSecurityAlertPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a database's security alert policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/securityAlertPolicies/{securityAlertPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseSecurityAlertPolicies_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlDatabaseSecurityAlertPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The database security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SqlDatabaseSecurityAlertPolicyResource>> UpdateAsync(WaitUntil waitUntil, SqlDatabaseSecurityAlertPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlDatabaseSecurityAlertPolicyDatabaseSecurityAlertPoliciesClientDiagnostics.CreateScope("SqlDatabaseSecurityAlertPolicyResource.Update");
            scope.Start();
            try
            {
                var response = await _sqlDatabaseSecurityAlertPolicyDatabaseSecurityAlertPoliciesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<SqlDatabaseSecurityAlertPolicyResource>(Response.FromValue(new SqlDatabaseSecurityAlertPolicyResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates a database's security alert policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/securityAlertPolicies/{securityAlertPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseSecurityAlertPolicies_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlDatabaseSecurityAlertPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The database security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SqlDatabaseSecurityAlertPolicyResource> Update(WaitUntil waitUntil, SqlDatabaseSecurityAlertPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlDatabaseSecurityAlertPolicyDatabaseSecurityAlertPoliciesClientDiagnostics.CreateScope("SqlDatabaseSecurityAlertPolicyResource.Update");
            scope.Start();
            try
            {
                var response = _sqlDatabaseSecurityAlertPolicyDatabaseSecurityAlertPoliciesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new SqlArmOperation<SqlDatabaseSecurityAlertPolicyResource>(Response.FromValue(new SqlDatabaseSecurityAlertPolicyResource(Client, response), response.GetRawResponse()));
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
    }
}
