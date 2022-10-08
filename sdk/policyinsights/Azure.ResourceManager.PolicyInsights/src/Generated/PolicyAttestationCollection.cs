// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.PolicyInsights.Models;

namespace Azure.ResourceManager.PolicyInsights
{
    /// <summary>
    /// A class representing a collection of <see cref="PolicyAttestationResource" /> and their operations.
    /// Each <see cref="PolicyAttestationResource" /> in the collection will belong to the same instance of <see cref="ArmResource" />.
    /// To get a <see cref="PolicyAttestationCollection" /> instance call the GetPolicyAttestations method from an instance of <see cref="ArmResource" />.
    /// </summary>
    public partial class PolicyAttestationCollection : ArmCollection, IEnumerable<PolicyAttestationResource>, IAsyncEnumerable<PolicyAttestationResource>
    {
        private readonly ClientDiagnostics _policyAttestationAttestationsClientDiagnostics;
        private readonly AttestationsRestOperations _policyAttestationAttestationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="PolicyAttestationCollection"/> class for mocking. </summary>
        protected PolicyAttestationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PolicyAttestationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PolicyAttestationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _policyAttestationAttestationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.PolicyInsights", PolicyAttestationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PolicyAttestationResource.ResourceType, out string policyAttestationAttestationsApiVersion);
            _policyAttestationAttestationsRestClient = new AttestationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, policyAttestationAttestationsApiVersion);
        }

        /// <summary>
        /// Creates or updates an attestation at resource scope.
        /// Request Path: /{resourceId}/providers/Microsoft.PolicyInsights/attestations/{attestationName}
        /// Operation Id: Attestations_CreateOrUpdateAtResource
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="attestationName"> The name of the attestation. </param>
        /// <param name="data"> The attestation parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="attestationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="attestationName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PolicyAttestationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string attestationName, PolicyAttestationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(attestationName, nameof(attestationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _policyAttestationAttestationsClientDiagnostics.CreateScope("PolicyAttestationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _policyAttestationAttestationsRestClient.CreateOrUpdateAtResourceAsync(Id, attestationName, data, cancellationToken).ConfigureAwait(false);
                var operation = new PolicyInsightsArmOperation<PolicyAttestationResource>(new PolicyAttestationOperationSource(Client), _policyAttestationAttestationsClientDiagnostics, Pipeline, _policyAttestationAttestationsRestClient.CreateCreateOrUpdateAtResourceRequest(Id, attestationName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates an attestation at resource scope.
        /// Request Path: /{resourceId}/providers/Microsoft.PolicyInsights/attestations/{attestationName}
        /// Operation Id: Attestations_CreateOrUpdateAtResource
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="attestationName"> The name of the attestation. </param>
        /// <param name="data"> The attestation parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="attestationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="attestationName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PolicyAttestationResource> CreateOrUpdate(WaitUntil waitUntil, string attestationName, PolicyAttestationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(attestationName, nameof(attestationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _policyAttestationAttestationsClientDiagnostics.CreateScope("PolicyAttestationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _policyAttestationAttestationsRestClient.CreateOrUpdateAtResource(Id, attestationName, data, cancellationToken);
                var operation = new PolicyInsightsArmOperation<PolicyAttestationResource>(new PolicyAttestationOperationSource(Client), _policyAttestationAttestationsClientDiagnostics, Pipeline, _policyAttestationAttestationsRestClient.CreateCreateOrUpdateAtResourceRequest(Id, attestationName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets an existing attestation at resource scope.
        /// Request Path: /{resourceId}/providers/Microsoft.PolicyInsights/attestations/{attestationName}
        /// Operation Id: Attestations_GetAtResource
        /// </summary>
        /// <param name="attestationName"> The name of the attestation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="attestationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="attestationName"/> is null. </exception>
        public virtual async Task<Response<PolicyAttestationResource>> GetAsync(string attestationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(attestationName, nameof(attestationName));

            using var scope = _policyAttestationAttestationsClientDiagnostics.CreateScope("PolicyAttestationCollection.Get");
            scope.Start();
            try
            {
                var response = await _policyAttestationAttestationsRestClient.GetAtResourceAsync(Id, attestationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PolicyAttestationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an existing attestation at resource scope.
        /// Request Path: /{resourceId}/providers/Microsoft.PolicyInsights/attestations/{attestationName}
        /// Operation Id: Attestations_GetAtResource
        /// </summary>
        /// <param name="attestationName"> The name of the attestation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="attestationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="attestationName"/> is null. </exception>
        public virtual Response<PolicyAttestationResource> Get(string attestationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(attestationName, nameof(attestationName));

            using var scope = _policyAttestationAttestationsClientDiagnostics.CreateScope("PolicyAttestationCollection.Get");
            scope.Start();
            try
            {
                var response = _policyAttestationAttestationsRestClient.GetAtResource(Id, attestationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PolicyAttestationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all attestations for a resource.
        /// Request Path: /{resourceId}/providers/Microsoft.PolicyInsights/attestations
        /// Operation Id: Attestations_ListForResource
        /// </summary>
        /// <param name="policyQuerySettings"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PolicyAttestationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PolicyAttestationResource> GetAllAsync(PolicyQuerySettings policyQuerySettings = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<PolicyAttestationResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _policyAttestationAttestationsClientDiagnostics.CreateScope("PolicyAttestationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _policyAttestationAttestationsRestClient.ListForResourceAsync(Id, policyQuerySettings, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PolicyAttestationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<PolicyAttestationResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _policyAttestationAttestationsClientDiagnostics.CreateScope("PolicyAttestationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _policyAttestationAttestationsRestClient.ListForResourceNextPageAsync(nextLink, Id, policyQuerySettings, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PolicyAttestationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets all attestations for a resource.
        /// Request Path: /{resourceId}/providers/Microsoft.PolicyInsights/attestations
        /// Operation Id: Attestations_ListForResource
        /// </summary>
        /// <param name="policyQuerySettings"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PolicyAttestationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PolicyAttestationResource> GetAll(PolicyQuerySettings policyQuerySettings = null, CancellationToken cancellationToken = default)
        {
            Page<PolicyAttestationResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _policyAttestationAttestationsClientDiagnostics.CreateScope("PolicyAttestationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _policyAttestationAttestationsRestClient.ListForResource(Id, policyQuerySettings, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PolicyAttestationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<PolicyAttestationResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _policyAttestationAttestationsClientDiagnostics.CreateScope("PolicyAttestationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _policyAttestationAttestationsRestClient.ListForResourceNextPage(nextLink, Id, policyQuerySettings, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PolicyAttestationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /{resourceId}/providers/Microsoft.PolicyInsights/attestations/{attestationName}
        /// Operation Id: Attestations_GetAtResource
        /// </summary>
        /// <param name="attestationName"> The name of the attestation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="attestationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="attestationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string attestationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(attestationName, nameof(attestationName));

            using var scope = _policyAttestationAttestationsClientDiagnostics.CreateScope("PolicyAttestationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _policyAttestationAttestationsRestClient.GetAtResourceAsync(Id, attestationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /{resourceId}/providers/Microsoft.PolicyInsights/attestations/{attestationName}
        /// Operation Id: Attestations_GetAtResource
        /// </summary>
        /// <param name="attestationName"> The name of the attestation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="attestationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="attestationName"/> is null. </exception>
        public virtual Response<bool> Exists(string attestationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(attestationName, nameof(attestationName));

            using var scope = _policyAttestationAttestationsClientDiagnostics.CreateScope("PolicyAttestationCollection.Exists");
            scope.Start();
            try
            {
                var response = _policyAttestationAttestationsRestClient.GetAtResource(Id, attestationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PolicyAttestationResource> IEnumerable<PolicyAttestationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PolicyAttestationResource> IAsyncEnumerable<PolicyAttestationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
