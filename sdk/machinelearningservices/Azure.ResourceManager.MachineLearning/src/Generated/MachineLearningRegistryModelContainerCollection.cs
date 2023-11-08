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
using Azure.ResourceManager.MachineLearning.Models;

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary>
    /// A class representing a collection of <see cref="MachineLearningRegistryModelContainerResource" /> and their operations.
    /// Each <see cref="MachineLearningRegistryModelContainerResource" /> in the collection will belong to the same instance of <see cref="MachineLearningRegistryResource" />.
    /// To get a <see cref="MachineLearningRegistryModelContainerCollection" /> instance call the GetMachineLearningRegistryModelContainers method from an instance of <see cref="MachineLearningRegistryResource" />.
    /// </summary>
    public partial class MachineLearningRegistryModelContainerCollection : ArmCollection, IEnumerable<MachineLearningRegistryModelContainerResource>, IAsyncEnumerable<MachineLearningRegistryModelContainerResource>
    {
        private readonly ClientDiagnostics _machineLearningRegistryModelContainerRegistryModelContainersClientDiagnostics;
        private readonly RegistryModelContainersRestOperations _machineLearningRegistryModelContainerRegistryModelContainersRestClient;

        /// <summary> Initializes a new instance of the <see cref="MachineLearningRegistryModelContainerCollection"/> class for mocking. </summary>
        protected MachineLearningRegistryModelContainerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MachineLearningRegistryModelContainerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MachineLearningRegistryModelContainerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _machineLearningRegistryModelContainerRegistryModelContainersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MachineLearning", MachineLearningRegistryModelContainerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MachineLearningRegistryModelContainerResource.ResourceType, out string machineLearningRegistryModelContainerRegistryModelContainersApiVersion);
            _machineLearningRegistryModelContainerRegistryModelContainersRestClient = new RegistryModelContainersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, machineLearningRegistryModelContainerRegistryModelContainersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MachineLearningRegistryResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MachineLearningRegistryResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update model container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/models/{modelName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryModelContainers_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="modelName"> Container name. </param>
        /// <param name="data"> Container entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="modelName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="modelName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MachineLearningRegistryModelContainerResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string modelName, MachineLearningModelContainerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(modelName, nameof(modelName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _machineLearningRegistryModelContainerRegistryModelContainersClientDiagnostics.CreateScope("MachineLearningRegistryModelContainerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _machineLearningRegistryModelContainerRegistryModelContainersRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, modelName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MachineLearningArmOperation<MachineLearningRegistryModelContainerResource>(new MachineLearningRegistryModelContainerOperationSource(Client), _machineLearningRegistryModelContainerRegistryModelContainersClientDiagnostics, Pipeline, _machineLearningRegistryModelContainerRegistryModelContainersRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, modelName, data).Request, response, OperationFinalStateVia.OriginalUri);
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
        /// Create or update model container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/models/{modelName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryModelContainers_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="modelName"> Container name. </param>
        /// <param name="data"> Container entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="modelName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="modelName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MachineLearningRegistryModelContainerResource> CreateOrUpdate(WaitUntil waitUntil, string modelName, MachineLearningModelContainerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(modelName, nameof(modelName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _machineLearningRegistryModelContainerRegistryModelContainersClientDiagnostics.CreateScope("MachineLearningRegistryModelContainerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _machineLearningRegistryModelContainerRegistryModelContainersRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, modelName, data, cancellationToken);
                var operation = new MachineLearningArmOperation<MachineLearningRegistryModelContainerResource>(new MachineLearningRegistryModelContainerOperationSource(Client), _machineLearningRegistryModelContainerRegistryModelContainersClientDiagnostics, Pipeline, _machineLearningRegistryModelContainerRegistryModelContainersRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, modelName, data).Request, response, OperationFinalStateVia.OriginalUri);
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
        /// Get container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/models/{modelName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryModelContainers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="modelName"> Container name. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="modelName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="modelName"/> is null. </exception>
        public virtual async Task<Response<MachineLearningRegistryModelContainerResource>> GetAsync(string modelName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(modelName, nameof(modelName));

            using var scope = _machineLearningRegistryModelContainerRegistryModelContainersClientDiagnostics.CreateScope("MachineLearningRegistryModelContainerCollection.Get");
            scope.Start();
            try
            {
                var response = await _machineLearningRegistryModelContainerRegistryModelContainersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, modelName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningRegistryModelContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/models/{modelName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryModelContainers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="modelName"> Container name. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="modelName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="modelName"/> is null. </exception>
        public virtual Response<MachineLearningRegistryModelContainerResource> Get(string modelName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(modelName, nameof(modelName));

            using var scope = _machineLearningRegistryModelContainerRegistryModelContainersClientDiagnostics.CreateScope("MachineLearningRegistryModelContainerCollection.Get");
            scope.Start();
            try
            {
                var response = _machineLearningRegistryModelContainerRegistryModelContainersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, modelName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningRegistryModelContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List model containers.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/models</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryModelContainers_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="listViewType"> View type for including/excluding (for example) archived entities. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MachineLearningRegistryModelContainerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MachineLearningRegistryModelContainerResource> GetAllAsync(string skip = null, MachineLearningListViewType? listViewType = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _machineLearningRegistryModelContainerRegistryModelContainersRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, listViewType);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _machineLearningRegistryModelContainerRegistryModelContainersRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, listViewType);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new MachineLearningRegistryModelContainerResource(Client, MachineLearningModelContainerData.DeserializeMachineLearningModelContainerData(e)), _machineLearningRegistryModelContainerRegistryModelContainersClientDiagnostics, Pipeline, "MachineLearningRegistryModelContainerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List model containers.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/models</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryModelContainers_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="listViewType"> View type for including/excluding (for example) archived entities. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MachineLearningRegistryModelContainerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MachineLearningRegistryModelContainerResource> GetAll(string skip = null, MachineLearningListViewType? listViewType = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _machineLearningRegistryModelContainerRegistryModelContainersRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, listViewType);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _machineLearningRegistryModelContainerRegistryModelContainersRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, listViewType);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new MachineLearningRegistryModelContainerResource(Client, MachineLearningModelContainerData.DeserializeMachineLearningModelContainerData(e)), _machineLearningRegistryModelContainerRegistryModelContainersClientDiagnostics, Pipeline, "MachineLearningRegistryModelContainerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/models/{modelName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryModelContainers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="modelName"> Container name. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="modelName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="modelName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string modelName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(modelName, nameof(modelName));

            using var scope = _machineLearningRegistryModelContainerRegistryModelContainersClientDiagnostics.CreateScope("MachineLearningRegistryModelContainerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _machineLearningRegistryModelContainerRegistryModelContainersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, modelName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/models/{modelName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryModelContainers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="modelName"> Container name. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="modelName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="modelName"/> is null. </exception>
        public virtual Response<bool> Exists(string modelName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(modelName, nameof(modelName));

            using var scope = _machineLearningRegistryModelContainerRegistryModelContainersClientDiagnostics.CreateScope("MachineLearningRegistryModelContainerCollection.Exists");
            scope.Start();
            try
            {
                var response = _machineLearningRegistryModelContainerRegistryModelContainersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, modelName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/models/{modelName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryModelContainers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="modelName"> Container name. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="modelName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="modelName"/> is null. </exception>
        public virtual async Task<NullableResponse<MachineLearningRegistryModelContainerResource>> GetIfExistsAsync(string modelName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(modelName, nameof(modelName));

            using var scope = _machineLearningRegistryModelContainerRegistryModelContainersClientDiagnostics.CreateScope("MachineLearningRegistryModelContainerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _machineLearningRegistryModelContainerRegistryModelContainersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, modelName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MachineLearningRegistryModelContainerResource>(response.GetRawResponse());
                return Response.FromValue(new MachineLearningRegistryModelContainerResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/models/{modelName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryModelContainers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="modelName"> Container name. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="modelName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="modelName"/> is null. </exception>
        public virtual NullableResponse<MachineLearningRegistryModelContainerResource> GetIfExists(string modelName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(modelName, nameof(modelName));

            using var scope = _machineLearningRegistryModelContainerRegistryModelContainersClientDiagnostics.CreateScope("MachineLearningRegistryModelContainerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _machineLearningRegistryModelContainerRegistryModelContainersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, modelName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MachineLearningRegistryModelContainerResource>(response.GetRawResponse());
                return Response.FromValue(new MachineLearningRegistryModelContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MachineLearningRegistryModelContainerResource> IEnumerable<MachineLearningRegistryModelContainerResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MachineLearningRegistryModelContainerResource> IAsyncEnumerable<MachineLearningRegistryModelContainerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
