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
using Azure.ResourceManager.ApiManagement.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="ApiManagementProductPolicyResource"/> and their operations.
    /// Each <see cref="ApiManagementProductPolicyResource"/> in the collection will belong to the same instance of <see cref="ApiManagementProductResource"/>.
    /// To get an <see cref="ApiManagementProductPolicyCollection"/> instance call the GetApiManagementProductPolicies method from an instance of <see cref="ApiManagementProductResource"/>.
    /// </summary>
    public partial class ApiManagementProductPolicyCollection : ArmCollection, IEnumerable<ApiManagementProductPolicyResource>, IAsyncEnumerable<ApiManagementProductPolicyResource>
    {
        private readonly ClientDiagnostics _apiManagementProductPolicyProductPolicyClientDiagnostics;
        private readonly ProductPolicyRestOperations _apiManagementProductPolicyProductPolicyRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApiManagementProductPolicyCollection"/> class for mocking. </summary>
        protected ApiManagementProductPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApiManagementProductPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ApiManagementProductPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiManagementProductPolicyProductPolicyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ApiManagementProductPolicyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ApiManagementProductPolicyResource.ResourceType, out string apiManagementProductPolicyProductPolicyApiVersion);
            _apiManagementProductPolicyProductPolicyRestClient = new ProductPolicyRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiManagementProductPolicyProductPolicyApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ApiManagementProductResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ApiManagementProductResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates policy configuration for the Product.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/products/{productId}/policies/{policyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProductPolicy_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementProductPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="policyId"> The identifier of the Policy. </param>
        /// <param name="data"> The policy contents to apply. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ApiManagementProductPolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, PolicyName policyId, PolicyContractData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _apiManagementProductPolicyProductPolicyClientDiagnostics.CreateScope("ApiManagementProductPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _apiManagementProductPolicyProductPolicyRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyId, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<ApiManagementProductPolicyResource>(Response.FromValue(new ApiManagementProductPolicyResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates policy configuration for the Product.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/products/{productId}/policies/{policyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProductPolicy_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementProductPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="policyId"> The identifier of the Policy. </param>
        /// <param name="data"> The policy contents to apply. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ApiManagementProductPolicyResource> CreateOrUpdate(WaitUntil waitUntil, PolicyName policyId, PolicyContractData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _apiManagementProductPolicyProductPolicyClientDiagnostics.CreateScope("ApiManagementProductPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _apiManagementProductPolicyProductPolicyRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyId, data, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation<ApiManagementProductPolicyResource>(Response.FromValue(new ApiManagementProductPolicyResource(Client, response), response.GetRawResponse()));
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
        /// Get the policy configuration at the Product level.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/products/{productId}/policies/{policyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProductPolicy_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementProductPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyId"> The identifier of the Policy. </param>
        /// <param name="format"> Policy Export Format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ApiManagementProductPolicyResource>> GetAsync(PolicyName policyId, PolicyExportFormat? format = null, CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementProductPolicyProductPolicyClientDiagnostics.CreateScope("ApiManagementProductPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _apiManagementProductPolicyProductPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyId, format, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementProductPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the policy configuration at the Product level.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/products/{productId}/policies/{policyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProductPolicy_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementProductPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyId"> The identifier of the Policy. </param>
        /// <param name="format"> Policy Export Format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ApiManagementProductPolicyResource> Get(PolicyName policyId, PolicyExportFormat? format = null, CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementProductPolicyProductPolicyClientDiagnostics.CreateScope("ApiManagementProductPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _apiManagementProductPolicyProductPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyId, format, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementProductPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the policy configuration at the Product level.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/products/{productId}/policies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProductPolicy_ListByProduct</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementProductPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApiManagementProductPolicyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApiManagementProductPolicyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiManagementProductPolicyProductPolicyRestClient.CreateListByProductRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new ApiManagementProductPolicyResource(Client, PolicyContractData.DeserializePolicyContractData(e)), _apiManagementProductPolicyProductPolicyClientDiagnostics, Pipeline, "ApiManagementProductPolicyCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Get the policy configuration at the Product level.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/products/{productId}/policies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProductPolicy_ListByProduct</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementProductPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApiManagementProductPolicyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApiManagementProductPolicyResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiManagementProductPolicyProductPolicyRestClient.CreateListByProductRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new ApiManagementProductPolicyResource(Client, PolicyContractData.DeserializePolicyContractData(e)), _apiManagementProductPolicyProductPolicyClientDiagnostics, Pipeline, "ApiManagementProductPolicyCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/products/{productId}/policies/{policyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProductPolicy_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementProductPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyId"> The identifier of the Policy. </param>
        /// <param name="format"> Policy Export Format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(PolicyName policyId, PolicyExportFormat? format = null, CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementProductPolicyProductPolicyClientDiagnostics.CreateScope("ApiManagementProductPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _apiManagementProductPolicyProductPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyId, format, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/products/{productId}/policies/{policyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProductPolicy_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementProductPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyId"> The identifier of the Policy. </param>
        /// <param name="format"> Policy Export Format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(PolicyName policyId, PolicyExportFormat? format = null, CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementProductPolicyProductPolicyClientDiagnostics.CreateScope("ApiManagementProductPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = _apiManagementProductPolicyProductPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyId, format, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/products/{productId}/policies/{policyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProductPolicy_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementProductPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyId"> The identifier of the Policy. </param>
        /// <param name="format"> Policy Export Format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<NullableResponse<ApiManagementProductPolicyResource>> GetIfExistsAsync(PolicyName policyId, PolicyExportFormat? format = null, CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementProductPolicyProductPolicyClientDiagnostics.CreateScope("ApiManagementProductPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _apiManagementProductPolicyProductPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyId, format, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ApiManagementProductPolicyResource>(response.GetRawResponse());
                return Response.FromValue(new ApiManagementProductPolicyResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/products/{productId}/policies/{policyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProductPolicy_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementProductPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyId"> The identifier of the Policy. </param>
        /// <param name="format"> Policy Export Format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual NullableResponse<ApiManagementProductPolicyResource> GetIfExists(PolicyName policyId, PolicyExportFormat? format = null, CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementProductPolicyProductPolicyClientDiagnostics.CreateScope("ApiManagementProductPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _apiManagementProductPolicyProductPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyId, format, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ApiManagementProductPolicyResource>(response.GetRawResponse());
                return Response.FromValue(new ApiManagementProductPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ApiManagementProductPolicyResource> IEnumerable<ApiManagementProductPolicyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ApiManagementProductPolicyResource> IAsyncEnumerable<ApiManagementProductPolicyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
