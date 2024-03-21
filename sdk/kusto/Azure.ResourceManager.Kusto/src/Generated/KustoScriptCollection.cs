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
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Kusto
{
    /// <summary>
    /// A class representing a collection of <see cref="KustoScriptResource"/> and their operations.
    /// Each <see cref="KustoScriptResource"/> in the collection will belong to the same instance of <see cref="KustoDatabaseResource"/>.
    /// To get a <see cref="KustoScriptCollection"/> instance call the GetKustoScripts method from an instance of <see cref="KustoDatabaseResource"/>.
    /// </summary>
    public partial class KustoScriptCollection : ArmCollection, IEnumerable<KustoScriptResource>, IAsyncEnumerable<KustoScriptResource>
    {
        private readonly ClientDiagnostics _kustoScriptScriptsClientDiagnostics;
        private readonly ScriptsRestOperations _kustoScriptScriptsRestClient;

        /// <summary> Initializes a new instance of the <see cref="KustoScriptCollection"/> class for mocking. </summary>
        protected KustoScriptCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="KustoScriptCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal KustoScriptCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _kustoScriptScriptsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Kusto", KustoScriptResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(KustoScriptResource.ResourceType, out string kustoScriptScriptsApiVersion);
            _kustoScriptScriptsRestClient = new ScriptsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, kustoScriptScriptsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != KustoDatabaseResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, KustoDatabaseResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a Kusto database script.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/databases/{databaseName}/scripts/{scriptName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Scripts_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KustoScriptResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="scriptName"> The name of the Kusto database script. </param>
        /// <param name="data"> The Kusto Script parameters contains the KQL to run. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scriptName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<KustoScriptResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string scriptName, KustoScriptData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scriptName, nameof(scriptName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _kustoScriptScriptsClientDiagnostics.CreateScope("KustoScriptCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _kustoScriptScriptsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, scriptName, data, cancellationToken).ConfigureAwait(false);
                var operation = new KustoArmOperation<KustoScriptResource>(new KustoScriptOperationSource(Client), _kustoScriptScriptsClientDiagnostics, Pipeline, _kustoScriptScriptsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, scriptName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates a Kusto database script.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/databases/{databaseName}/scripts/{scriptName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Scripts_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KustoScriptResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="scriptName"> The name of the Kusto database script. </param>
        /// <param name="data"> The Kusto Script parameters contains the KQL to run. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scriptName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<KustoScriptResource> CreateOrUpdate(WaitUntil waitUntil, string scriptName, KustoScriptData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scriptName, nameof(scriptName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _kustoScriptScriptsClientDiagnostics.CreateScope("KustoScriptCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _kustoScriptScriptsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, scriptName, data, cancellationToken);
                var operation = new KustoArmOperation<KustoScriptResource>(new KustoScriptOperationSource(Client), _kustoScriptScriptsClientDiagnostics, Pipeline, _kustoScriptScriptsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, scriptName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a Kusto cluster database script.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/databases/{databaseName}/scripts/{scriptName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Scripts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KustoScriptResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scriptName"> The name of the Kusto database script. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scriptName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptName"/> is null. </exception>
        public virtual async Task<Response<KustoScriptResource>> GetAsync(string scriptName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scriptName, nameof(scriptName));

            using var scope = _kustoScriptScriptsClientDiagnostics.CreateScope("KustoScriptCollection.Get");
            scope.Start();
            try
            {
                var response = await _kustoScriptScriptsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, scriptName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new KustoScriptResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a Kusto cluster database script.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/databases/{databaseName}/scripts/{scriptName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Scripts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KustoScriptResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scriptName"> The name of the Kusto database script. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scriptName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptName"/> is null. </exception>
        public virtual Response<KustoScriptResource> Get(string scriptName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scriptName, nameof(scriptName));

            using var scope = _kustoScriptScriptsClientDiagnostics.CreateScope("KustoScriptCollection.Get");
            scope.Start();
            try
            {
                var response = _kustoScriptScriptsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, scriptName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new KustoScriptResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns the list of database scripts for given database.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/databases/{databaseName}/scripts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Scripts_ListByDatabase</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KustoScriptResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="KustoScriptResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<KustoScriptResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _kustoScriptScriptsRestClient.CreateListByDatabaseRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new KustoScriptResource(Client, KustoScriptData.DeserializeKustoScriptData(e)), _kustoScriptScriptsClientDiagnostics, Pipeline, "KustoScriptCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Returns the list of database scripts for given database.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/databases/{databaseName}/scripts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Scripts_ListByDatabase</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KustoScriptResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="KustoScriptResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<KustoScriptResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _kustoScriptScriptsRestClient.CreateListByDatabaseRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new KustoScriptResource(Client, KustoScriptData.DeserializeKustoScriptData(e)), _kustoScriptScriptsClientDiagnostics, Pipeline, "KustoScriptCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/databases/{databaseName}/scripts/{scriptName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Scripts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KustoScriptResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scriptName"> The name of the Kusto database script. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scriptName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string scriptName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scriptName, nameof(scriptName));

            using var scope = _kustoScriptScriptsClientDiagnostics.CreateScope("KustoScriptCollection.Exists");
            scope.Start();
            try
            {
                var response = await _kustoScriptScriptsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, scriptName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/databases/{databaseName}/scripts/{scriptName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Scripts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KustoScriptResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scriptName"> The name of the Kusto database script. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scriptName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptName"/> is null. </exception>
        public virtual Response<bool> Exists(string scriptName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scriptName, nameof(scriptName));

            using var scope = _kustoScriptScriptsClientDiagnostics.CreateScope("KustoScriptCollection.Exists");
            scope.Start();
            try
            {
                var response = _kustoScriptScriptsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, scriptName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/databases/{databaseName}/scripts/{scriptName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Scripts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KustoScriptResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scriptName"> The name of the Kusto database script. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scriptName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptName"/> is null. </exception>
        public virtual async Task<NullableResponse<KustoScriptResource>> GetIfExistsAsync(string scriptName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scriptName, nameof(scriptName));

            using var scope = _kustoScriptScriptsClientDiagnostics.CreateScope("KustoScriptCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _kustoScriptScriptsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, scriptName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<KustoScriptResource>(response.GetRawResponse());
                return Response.FromValue(new KustoScriptResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/databases/{databaseName}/scripts/{scriptName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Scripts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KustoScriptResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scriptName"> The name of the Kusto database script. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scriptName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptName"/> is null. </exception>
        public virtual NullableResponse<KustoScriptResource> GetIfExists(string scriptName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scriptName, nameof(scriptName));

            using var scope = _kustoScriptScriptsClientDiagnostics.CreateScope("KustoScriptCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _kustoScriptScriptsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, scriptName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<KustoScriptResource>(response.GetRawResponse());
                return Response.FromValue(new KustoScriptResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<KustoScriptResource> IEnumerable<KustoScriptResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<KustoScriptResource> IAsyncEnumerable<KustoScriptResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
