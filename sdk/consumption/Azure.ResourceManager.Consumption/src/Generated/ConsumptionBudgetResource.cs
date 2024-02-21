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

namespace Azure.ResourceManager.Consumption
{
    /// <summary>
    /// A Class representing a ConsumptionBudget along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="ConsumptionBudgetResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetConsumptionBudgetResource method.
    /// Otherwise you can get one from its parent resource <see cref="ArmResource"/> using the GetConsumptionBudget method.
    /// </summary>
    public partial class ConsumptionBudgetResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ConsumptionBudgetResource"/> instance. </summary>
        /// <param name="scope"> The scope. </param>
        /// <param name="budgetName"> The budgetName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string scope, string budgetName)
        {
            var resourceId = $"{scope}/providers/Microsoft.Consumption/budgets/{budgetName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _consumptionBudgetBudgetsClientDiagnostics;
        private readonly BudgetsRestOperations _consumptionBudgetBudgetsRestClient;
        private readonly ConsumptionBudgetData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Consumption/budgets";

        /// <summary> Initializes a new instance of the <see cref="ConsumptionBudgetResource"/> class for mocking. </summary>
        protected ConsumptionBudgetResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ConsumptionBudgetResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ConsumptionBudgetResource(ArmClient client, ConsumptionBudgetData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ConsumptionBudgetResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ConsumptionBudgetResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _consumptionBudgetBudgetsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Consumption", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string consumptionBudgetBudgetsApiVersion);
            _consumptionBudgetBudgetsRestClient = new BudgetsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, consumptionBudgetBudgetsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ConsumptionBudgetData Data
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
        /// Gets the budget for the scope by budget name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Consumption/budgets/{budgetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Budgets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ConsumptionBudgetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ConsumptionBudgetResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _consumptionBudgetBudgetsClientDiagnostics.CreateScope("ConsumptionBudgetResource.Get");
            scope.Start();
            try
            {
                var response = await _consumptionBudgetBudgetsRestClient.GetAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ConsumptionBudgetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the budget for the scope by budget name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Consumption/budgets/{budgetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Budgets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ConsumptionBudgetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ConsumptionBudgetResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _consumptionBudgetBudgetsClientDiagnostics.CreateScope("ConsumptionBudgetResource.Get");
            scope.Start();
            try
            {
                var response = _consumptionBudgetBudgetsRestClient.Get(Id.Parent, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ConsumptionBudgetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to delete a budget.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Consumption/budgets/{budgetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Budgets_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ConsumptionBudgetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _consumptionBudgetBudgetsClientDiagnostics.CreateScope("ConsumptionBudgetResource.Delete");
            scope.Start();
            try
            {
                var response = await _consumptionBudgetBudgetsRestClient.DeleteAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new ConsumptionArmOperation(response);
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
        /// The operation to delete a budget.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Consumption/budgets/{budgetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Budgets_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ConsumptionBudgetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _consumptionBudgetBudgetsClientDiagnostics.CreateScope("ConsumptionBudgetResource.Delete");
            scope.Start();
            try
            {
                var response = _consumptionBudgetBudgetsRestClient.Delete(Id.Parent, Id.Name, cancellationToken);
                var operation = new ConsumptionArmOperation(response);
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
        /// The operation to create or update a budget. You can optionally provide an eTag if desired as a form of concurrency control. To obtain the latest eTag for a given budget, perform a get operation prior to your put operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Consumption/budgets/{budgetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Budgets_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ConsumptionBudgetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters supplied to the Create Budget operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ConsumptionBudgetResource>> UpdateAsync(WaitUntil waitUntil, ConsumptionBudgetData data, CancellationToken cancellationToken = default)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _consumptionBudgetBudgetsClientDiagnostics.CreateScope("ConsumptionBudgetResource.Update");
            scope.Start();
            try
            {
                var response = await _consumptionBudgetBudgetsRestClient.CreateOrUpdateAsync(Id.Parent, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new ConsumptionArmOperation<ConsumptionBudgetResource>(Response.FromValue(new ConsumptionBudgetResource(Client, response), response.GetRawResponse()));
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
        /// The operation to create or update a budget. You can optionally provide an eTag if desired as a form of concurrency control. To obtain the latest eTag for a given budget, perform a get operation prior to your put operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Consumption/budgets/{budgetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Budgets_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ConsumptionBudgetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters supplied to the Create Budget operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ConsumptionBudgetResource> Update(WaitUntil waitUntil, ConsumptionBudgetData data, CancellationToken cancellationToken = default)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _consumptionBudgetBudgetsClientDiagnostics.CreateScope("ConsumptionBudgetResource.Update");
            scope.Start();
            try
            {
                var response = _consumptionBudgetBudgetsRestClient.CreateOrUpdate(Id.Parent, Id.Name, data, cancellationToken);
                var operation = new ConsumptionArmOperation<ConsumptionBudgetResource>(Response.FromValue(new ConsumptionBudgetResource(Client, response), response.GetRawResponse()));
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
