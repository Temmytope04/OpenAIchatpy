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
using Azure.ResourceManager.Automation.Models;

namespace Azure.ResourceManager.Automation
{
    /// <summary>
    /// A class representing a collection of <see cref="AutomationAccountModuleResource" /> and their operations.
    /// Each <see cref="AutomationAccountModuleResource" /> in the collection will belong to the same instance of <see cref="AutomationAccountResource" />.
    /// To get an <see cref="AutomationAccountModuleCollection" /> instance call the GetAutomationAccountModules method from an instance of <see cref="AutomationAccountResource" />.
    /// </summary>
    public partial class AutomationAccountModuleCollection : ArmCollection, IEnumerable<AutomationAccountModuleResource>, IAsyncEnumerable<AutomationAccountModuleResource>
    {
        private readonly ClientDiagnostics _automationAccountModuleModuleClientDiagnostics;
        private readonly ModuleRestOperations _automationAccountModuleModuleRestClient;

        /// <summary> Initializes a new instance of the <see cref="AutomationAccountModuleCollection"/> class for mocking. </summary>
        protected AutomationAccountModuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AutomationAccountModuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AutomationAccountModuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _automationAccountModuleModuleClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Automation", AutomationAccountModuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AutomationAccountModuleResource.ResourceType, out string automationAccountModuleModuleApiVersion);
            _automationAccountModuleModuleRestClient = new ModuleRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, automationAccountModuleModuleApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AutomationAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AutomationAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or Update the module identified by module name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/modules/{moduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Module_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="moduleName"> The name of module. </param>
        /// <param name="content"> The create or update parameters for module. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="moduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="moduleName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<AutomationAccountModuleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string moduleName, AutomationAccountModuleCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(moduleName, nameof(moduleName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _automationAccountModuleModuleClientDiagnostics.CreateScope("AutomationAccountModuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _automationAccountModuleModuleRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, moduleName, content, cancellationToken).ConfigureAwait(false);
                var operation = new AutomationArmOperation<AutomationAccountModuleResource>(Response.FromValue(new AutomationAccountModuleResource(Client, response), response.GetRawResponse()));
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
        /// Create or Update the module identified by module name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/modules/{moduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Module_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="moduleName"> The name of module. </param>
        /// <param name="content"> The create or update parameters for module. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="moduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="moduleName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<AutomationAccountModuleResource> CreateOrUpdate(WaitUntil waitUntil, string moduleName, AutomationAccountModuleCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(moduleName, nameof(moduleName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _automationAccountModuleModuleClientDiagnostics.CreateScope("AutomationAccountModuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _automationAccountModuleModuleRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, moduleName, content, cancellationToken);
                var operation = new AutomationArmOperation<AutomationAccountModuleResource>(Response.FromValue(new AutomationAccountModuleResource(Client, response), response.GetRawResponse()));
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
        /// Retrieve the module identified by module name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/modules/{moduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Module_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="moduleName"> The module name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="moduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="moduleName"/> is null. </exception>
        public virtual async Task<Response<AutomationAccountModuleResource>> GetAsync(string moduleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(moduleName, nameof(moduleName));

            using var scope = _automationAccountModuleModuleClientDiagnostics.CreateScope("AutomationAccountModuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _automationAccountModuleModuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, moduleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomationAccountModuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve the module identified by module name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/modules/{moduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Module_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="moduleName"> The module name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="moduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="moduleName"/> is null. </exception>
        public virtual Response<AutomationAccountModuleResource> Get(string moduleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(moduleName, nameof(moduleName));

            using var scope = _automationAccountModuleModuleClientDiagnostics.CreateScope("AutomationAccountModuleCollection.Get");
            scope.Start();
            try
            {
                var response = _automationAccountModuleModuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, moduleName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomationAccountModuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve a list of modules.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/modules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Module_ListByAutomationAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AutomationAccountModuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AutomationAccountModuleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _automationAccountModuleModuleRestClient.CreateListByAutomationAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _automationAccountModuleModuleRestClient.CreateListByAutomationAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new AutomationAccountModuleResource(Client, AutomationModuleData.DeserializeAutomationModuleData(e)), _automationAccountModuleModuleClientDiagnostics, Pipeline, "AutomationAccountModuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Retrieve a list of modules.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/modules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Module_ListByAutomationAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AutomationAccountModuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AutomationAccountModuleResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _automationAccountModuleModuleRestClient.CreateListByAutomationAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _automationAccountModuleModuleRestClient.CreateListByAutomationAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new AutomationAccountModuleResource(Client, AutomationModuleData.DeserializeAutomationModuleData(e)), _automationAccountModuleModuleClientDiagnostics, Pipeline, "AutomationAccountModuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/modules/{moduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Module_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="moduleName"> The module name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="moduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="moduleName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string moduleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(moduleName, nameof(moduleName));

            using var scope = _automationAccountModuleModuleClientDiagnostics.CreateScope("AutomationAccountModuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _automationAccountModuleModuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, moduleName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/modules/{moduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Module_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="moduleName"> The module name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="moduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="moduleName"/> is null. </exception>
        public virtual Response<bool> Exists(string moduleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(moduleName, nameof(moduleName));

            using var scope = _automationAccountModuleModuleClientDiagnostics.CreateScope("AutomationAccountModuleCollection.Exists");
            scope.Start();
            try
            {
                var response = _automationAccountModuleModuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, moduleName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AutomationAccountModuleResource> IEnumerable<AutomationAccountModuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AutomationAccountModuleResource> IAsyncEnumerable<AutomationAccountModuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
