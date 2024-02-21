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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A Class representing a SqlServerAzureADOnlyAuthentication along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SqlServerAzureADOnlyAuthenticationResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSqlServerAzureADOnlyAuthenticationResource method.
    /// Otherwise you can get one from its parent resource <see cref="SqlServerResource"/> using the GetSqlServerAzureADOnlyAuthentication method.
    /// </summary>
    public partial class SqlServerAzureADOnlyAuthenticationResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SqlServerAzureADOnlyAuthenticationResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="serverName"> The serverName. </param>
        /// <param name="authenticationName"> The authenticationName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serverName, AuthenticationName authenticationName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/azureADOnlyAuthentications/{authenticationName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsClientDiagnostics;
        private readonly ServerAzureADOnlyAuthenticationsRestOperations _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsRestClient;
        private readonly SqlServerAzureADOnlyAuthenticationData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/servers/azureADOnlyAuthentications";

        /// <summary> Initializes a new instance of the <see cref="SqlServerAzureADOnlyAuthenticationResource"/> class for mocking. </summary>
        protected SqlServerAzureADOnlyAuthenticationResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SqlServerAzureADOnlyAuthenticationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SqlServerAzureADOnlyAuthenticationResource(ArmClient client, SqlServerAzureADOnlyAuthenticationData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SqlServerAzureADOnlyAuthenticationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SqlServerAzureADOnlyAuthenticationResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsApiVersion);
            _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsRestClient = new ServerAzureADOnlyAuthenticationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SqlServerAzureADOnlyAuthenticationData Data
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
        /// Gets a specific Azure Active Directory only authentication property.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/azureADOnlyAuthentications/{authenticationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAzureADOnlyAuthentications_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerAzureADOnlyAuthenticationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SqlServerAzureADOnlyAuthenticationResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsClientDiagnostics.CreateScope("SqlServerAzureADOnlyAuthenticationResource.Get");
            scope.Start();
            try
            {
                var response = await _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerAzureADOnlyAuthenticationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a specific Azure Active Directory only authentication property.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/azureADOnlyAuthentications/{authenticationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAzureADOnlyAuthentications_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerAzureADOnlyAuthenticationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SqlServerAzureADOnlyAuthenticationResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsClientDiagnostics.CreateScope("SqlServerAzureADOnlyAuthenticationResource.Get");
            scope.Start();
            try
            {
                var response = _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerAzureADOnlyAuthenticationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes an existing server Active Directory only authentication property.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/azureADOnlyAuthentications/{authenticationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAzureADOnlyAuthentications_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerAzureADOnlyAuthenticationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsClientDiagnostics.CreateScope("SqlServerAzureADOnlyAuthenticationResource.Delete");
            scope.Start();
            try
            {
                var response = await _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation(_sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsClientDiagnostics, Pipeline, _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes an existing server Active Directory only authentication property.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/azureADOnlyAuthentications/{authenticationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAzureADOnlyAuthentications_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerAzureADOnlyAuthenticationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsClientDiagnostics.CreateScope("SqlServerAzureADOnlyAuthenticationResource.Delete");
            scope.Start();
            try
            {
                var response = _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new SqlArmOperation(_sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsClientDiagnostics, Pipeline, _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Sets Server Active Directory only authentication property or updates an existing server Active Directory only authentication property.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/azureADOnlyAuthentications/{authenticationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAzureADOnlyAuthentications_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerAzureADOnlyAuthenticationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The required parameters for creating or updating an Active Directory only authentication property. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SqlServerAzureADOnlyAuthenticationResource>> UpdateAsync(WaitUntil waitUntil, SqlServerAzureADOnlyAuthenticationData data, CancellationToken cancellationToken = default)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsClientDiagnostics.CreateScope("SqlServerAzureADOnlyAuthenticationResource.Update");
            scope.Start();
            try
            {
                var response = await _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<SqlServerAzureADOnlyAuthenticationResource>(new SqlServerAzureADOnlyAuthenticationOperationSource(Client), _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsClientDiagnostics, Pipeline, _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Sets Server Active Directory only authentication property or updates an existing server Active Directory only authentication property.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/azureADOnlyAuthentications/{authenticationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAzureADOnlyAuthentications_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerAzureADOnlyAuthenticationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The required parameters for creating or updating an Active Directory only authentication property. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SqlServerAzureADOnlyAuthenticationResource> Update(WaitUntil waitUntil, SqlServerAzureADOnlyAuthenticationData data, CancellationToken cancellationToken = default)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsClientDiagnostics.CreateScope("SqlServerAzureADOnlyAuthenticationResource.Update");
            scope.Start();
            try
            {
                var response = _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new SqlArmOperation<SqlServerAzureADOnlyAuthenticationResource>(new SqlServerAzureADOnlyAuthenticationOperationSource(Client), _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsClientDiagnostics, Pipeline, _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
