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

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="SiteSlotFunctionResource" /> and their operations.
    /// Each <see cref="SiteSlotFunctionResource" /> in the collection will belong to the same instance of <see cref="WebSiteSlotResource" />.
    /// To get a <see cref="SiteSlotFunctionCollection" /> instance call the GetSiteSlotFunctions method from an instance of <see cref="WebSiteSlotResource" />.
    /// </summary>
    public partial class SiteSlotFunctionCollection : ArmCollection, IEnumerable<SiteSlotFunctionResource>, IAsyncEnumerable<SiteSlotFunctionResource>
    {
        private readonly ClientDiagnostics _siteSlotFunctionWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteSlotFunctionWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotFunctionCollection"/> class for mocking. </summary>
        protected SiteSlotFunctionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotFunctionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteSlotFunctionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSlotFunctionWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteSlotFunctionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteSlotFunctionResource.ResourceType, out string siteSlotFunctionWebAppsApiVersion);
            _siteSlotFunctionWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteSlotFunctionWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WebSiteSlotResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WebSiteSlotResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Create function for web site, or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/functions/{functionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_CreateInstanceFunctionSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="functionName"> Function name. </param>
        /// <param name="data"> Function details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SiteSlotFunctionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string functionName, FunctionEnvelopeData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionName, nameof(functionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _siteSlotFunctionWebAppsClientDiagnostics.CreateScope("SiteSlotFunctionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _siteSlotFunctionWebAppsRestClient.CreateInstanceFunctionSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, functionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<SiteSlotFunctionResource>(new SiteSlotFunctionOperationSource(Client), _siteSlotFunctionWebAppsClientDiagnostics, Pipeline, _siteSlotFunctionWebAppsRestClient.CreateCreateInstanceFunctionSlotRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, functionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Create function for web site, or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/functions/{functionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_CreateInstanceFunctionSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="functionName"> Function name. </param>
        /// <param name="data"> Function details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SiteSlotFunctionResource> CreateOrUpdate(WaitUntil waitUntil, string functionName, FunctionEnvelopeData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionName, nameof(functionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _siteSlotFunctionWebAppsClientDiagnostics.CreateScope("SiteSlotFunctionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _siteSlotFunctionWebAppsRestClient.CreateInstanceFunctionSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, functionName, data, cancellationToken);
                var operation = new AppServiceArmOperation<SiteSlotFunctionResource>(new SiteSlotFunctionOperationSource(Client), _siteSlotFunctionWebAppsClientDiagnostics, Pipeline, _siteSlotFunctionWebAppsRestClient.CreateCreateInstanceFunctionSlotRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, functionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Get function information by its ID for web site, or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/functions/{functionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetInstanceFunctionSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="functionName"> Function name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionName"/> is null. </exception>
        public virtual async Task<Response<SiteSlotFunctionResource>> GetAsync(string functionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionName, nameof(functionName));

            using var scope = _siteSlotFunctionWebAppsClientDiagnostics.CreateScope("SiteSlotFunctionCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteSlotFunctionWebAppsRestClient.GetInstanceFunctionSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, functionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotFunctionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get function information by its ID for web site, or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/functions/{functionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetInstanceFunctionSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="functionName"> Function name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionName"/> is null. </exception>
        public virtual Response<SiteSlotFunctionResource> Get(string functionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionName, nameof(functionName));

            using var scope = _siteSlotFunctionWebAppsClientDiagnostics.CreateScope("SiteSlotFunctionCollection.Get");
            scope.Start();
            try
            {
                var response = _siteSlotFunctionWebAppsRestClient.GetInstanceFunctionSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, functionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotFunctionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for List the functions for a web site, or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/functions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_ListInstanceFunctionsSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteSlotFunctionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteSlotFunctionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteSlotFunctionWebAppsRestClient.CreateListInstanceFunctionsSlotRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteSlotFunctionWebAppsRestClient.CreateListInstanceFunctionsSlotNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new SiteSlotFunctionResource(Client, FunctionEnvelopeData.DeserializeFunctionEnvelopeData(e)), _siteSlotFunctionWebAppsClientDiagnostics, Pipeline, "SiteSlotFunctionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for List the functions for a web site, or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/functions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_ListInstanceFunctionsSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteSlotFunctionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteSlotFunctionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteSlotFunctionWebAppsRestClient.CreateListInstanceFunctionsSlotRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteSlotFunctionWebAppsRestClient.CreateListInstanceFunctionsSlotNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new SiteSlotFunctionResource(Client, FunctionEnvelopeData.DeserializeFunctionEnvelopeData(e)), _siteSlotFunctionWebAppsClientDiagnostics, Pipeline, "SiteSlotFunctionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/functions/{functionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetInstanceFunctionSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="functionName"> Function name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string functionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionName, nameof(functionName));

            using var scope = _siteSlotFunctionWebAppsClientDiagnostics.CreateScope("SiteSlotFunctionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _siteSlotFunctionWebAppsRestClient.GetInstanceFunctionSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, functionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/functions/{functionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetInstanceFunctionSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="functionName"> Function name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionName"/> is null. </exception>
        public virtual Response<bool> Exists(string functionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionName, nameof(functionName));

            using var scope = _siteSlotFunctionWebAppsClientDiagnostics.CreateScope("SiteSlotFunctionCollection.Exists");
            scope.Start();
            try
            {
                var response = _siteSlotFunctionWebAppsRestClient.GetInstanceFunctionSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, functionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteSlotFunctionResource> IEnumerable<SiteSlotFunctionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteSlotFunctionResource> IAsyncEnumerable<SiteSlotFunctionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
