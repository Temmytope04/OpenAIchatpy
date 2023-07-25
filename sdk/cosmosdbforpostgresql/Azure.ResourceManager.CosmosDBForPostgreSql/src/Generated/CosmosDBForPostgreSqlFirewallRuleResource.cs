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

namespace Azure.ResourceManager.CosmosDBForPostgreSql
{
    /// <summary>
    /// A Class representing a CosmosDBForPostgreSqlFirewallRule along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="CosmosDBForPostgreSqlFirewallRuleResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetCosmosDBForPostgreSqlFirewallRuleResource method.
    /// Otherwise you can get one from its parent resource <see cref="CosmosDBForPostgreSqlClusterResource" /> using the GetCosmosDBForPostgreSqlFirewallRule method.
    /// </summary>
    public partial class CosmosDBForPostgreSqlFirewallRuleResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="CosmosDBForPostgreSqlFirewallRuleResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string clusterName, string firewallRuleName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/firewallRules/{firewallRuleName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _cosmosDBForPostgreSqlFirewallRuleFirewallRulesClientDiagnostics;
        private readonly FirewallRulesRestOperations _cosmosDBForPostgreSqlFirewallRuleFirewallRulesRestClient;
        private readonly CosmosDBForPostgreSqlFirewallRuleData _data;

        /// <summary> Initializes a new instance of the <see cref="CosmosDBForPostgreSqlFirewallRuleResource"/> class for mocking. </summary>
        protected CosmosDBForPostgreSqlFirewallRuleResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "CosmosDBForPostgreSqlFirewallRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal CosmosDBForPostgreSqlFirewallRuleResource(ArmClient client, CosmosDBForPostgreSqlFirewallRuleData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="CosmosDBForPostgreSqlFirewallRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal CosmosDBForPostgreSqlFirewallRuleResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cosmosDBForPostgreSqlFirewallRuleFirewallRulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDBForPostgreSql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string cosmosDBForPostgreSqlFirewallRuleFirewallRulesApiVersion);
            _cosmosDBForPostgreSqlFirewallRuleFirewallRulesRestClient = new FirewallRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cosmosDBForPostgreSqlFirewallRuleFirewallRulesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DBforPostgreSQL/serverGroupsv2/firewallRules";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual CosmosDBForPostgreSqlFirewallRuleData Data
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
        /// Gets information about a cluster firewall rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/firewallRules/{firewallRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CosmosDBForPostgreSqlFirewallRuleResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _cosmosDBForPostgreSqlFirewallRuleFirewallRulesClientDiagnostics.CreateScope("CosmosDBForPostgreSqlFirewallRuleResource.Get");
            scope.Start();
            try
            {
                var response = await _cosmosDBForPostgreSqlFirewallRuleFirewallRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBForPostgreSqlFirewallRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about a cluster firewall rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/firewallRules/{firewallRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CosmosDBForPostgreSqlFirewallRuleResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _cosmosDBForPostgreSqlFirewallRuleFirewallRulesClientDiagnostics.CreateScope("CosmosDBForPostgreSqlFirewallRuleResource.Get");
            scope.Start();
            try
            {
                var response = _cosmosDBForPostgreSqlFirewallRuleFirewallRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBForPostgreSqlFirewallRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a cluster firewall rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/firewallRules/{firewallRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallRules_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _cosmosDBForPostgreSqlFirewallRuleFirewallRulesClientDiagnostics.CreateScope("CosmosDBForPostgreSqlFirewallRuleResource.Delete");
            scope.Start();
            try
            {
                var response = await _cosmosDBForPostgreSqlFirewallRuleFirewallRulesRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBForPostgreSqlArmOperation(_cosmosDBForPostgreSqlFirewallRuleFirewallRulesClientDiagnostics, Pipeline, _cosmosDBForPostgreSqlFirewallRuleFirewallRulesRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Deletes a cluster firewall rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/firewallRules/{firewallRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallRules_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _cosmosDBForPostgreSqlFirewallRuleFirewallRulesClientDiagnostics.CreateScope("CosmosDBForPostgreSqlFirewallRuleResource.Delete");
            scope.Start();
            try
            {
                var response = _cosmosDBForPostgreSqlFirewallRuleFirewallRulesRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new CosmosDBForPostgreSqlArmOperation(_cosmosDBForPostgreSqlFirewallRuleFirewallRulesClientDiagnostics, Pipeline, _cosmosDBForPostgreSqlFirewallRuleFirewallRulesRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Creates a new cluster firewall rule or updates an existing cluster firewall rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/firewallRules/{firewallRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallRules_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The required parameters for creating or updating a firewall rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<CosmosDBForPostgreSqlFirewallRuleResource>> UpdateAsync(WaitUntil waitUntil, CosmosDBForPostgreSqlFirewallRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _cosmosDBForPostgreSqlFirewallRuleFirewallRulesClientDiagnostics.CreateScope("CosmosDBForPostgreSqlFirewallRuleResource.Update");
            scope.Start();
            try
            {
                var response = await _cosmosDBForPostgreSqlFirewallRuleFirewallRulesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBForPostgreSqlArmOperation<CosmosDBForPostgreSqlFirewallRuleResource>(new CosmosDBForPostgreSqlFirewallRuleOperationSource(Client), _cosmosDBForPostgreSqlFirewallRuleFirewallRulesClientDiagnostics, Pipeline, _cosmosDBForPostgreSqlFirewallRuleFirewallRulesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates a new cluster firewall rule or updates an existing cluster firewall rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/firewallRules/{firewallRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallRules_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The required parameters for creating or updating a firewall rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<CosmosDBForPostgreSqlFirewallRuleResource> Update(WaitUntil waitUntil, CosmosDBForPostgreSqlFirewallRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _cosmosDBForPostgreSqlFirewallRuleFirewallRulesClientDiagnostics.CreateScope("CosmosDBForPostgreSqlFirewallRuleResource.Update");
            scope.Start();
            try
            {
                var response = _cosmosDBForPostgreSqlFirewallRuleFirewallRulesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new CosmosDBForPostgreSqlArmOperation<CosmosDBForPostgreSqlFirewallRuleResource>(new CosmosDBForPostgreSqlFirewallRuleOperationSource(Client), _cosmosDBForPostgreSqlFirewallRuleFirewallRulesClientDiagnostics, Pipeline, _cosmosDBForPostgreSqlFirewallRuleFirewallRulesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
