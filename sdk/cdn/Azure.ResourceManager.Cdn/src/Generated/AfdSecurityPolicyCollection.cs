// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Cdn
{
    /// <summary> A class representing collection of AfdSecurityPolicy and their operations over its parent. </summary>
    public partial class AfdSecurityPolicyCollection : ArmCollection, IEnumerable<AfdSecurityPolicy>, IAsyncEnumerable<AfdSecurityPolicy>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly AfdSecurityPoliciesRestOperations _afdSecurityPoliciesRestClient;

        /// <summary> Initializes a new instance of the <see cref="AfdSecurityPolicyCollection"/> class for mocking. </summary>
        protected AfdSecurityPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AfdSecurityPolicyCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal AfdSecurityPolicyCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _afdSecurityPoliciesRestClient = new AfdSecurityPoliciesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Profile.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Profile.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Creates a new security policy within the specified profile. </summary>
        /// <param name="securityPolicyName"> Name of the security policy under the profile. </param>
        /// <param name="securityPolicy"> The security policy properties. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="securityPolicyName"/> or <paramref name="securityPolicy"/> is null. </exception>
        public virtual AfdSecurityPolicyCreateOperation CreateOrUpdate(bool waitForCompletion, string securityPolicyName, AfdSecurityPolicyData securityPolicy, CancellationToken cancellationToken = default)
        {
            if (securityPolicyName == null)
            {
                throw new ArgumentNullException(nameof(securityPolicyName));
            }
            if (securityPolicy == null)
            {
                throw new ArgumentNullException(nameof(securityPolicy));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdSecurityPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _afdSecurityPoliciesRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityPolicyName, securityPolicy, cancellationToken);
                var operation = new AfdSecurityPolicyCreateOperation(Parent, _clientDiagnostics, Pipeline, _afdSecurityPoliciesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityPolicyName, securityPolicy).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a new security policy within the specified profile. </summary>
        /// <param name="securityPolicyName"> Name of the security policy under the profile. </param>
        /// <param name="securityPolicy"> The security policy properties. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="securityPolicyName"/> or <paramref name="securityPolicy"/> is null. </exception>
        public async virtual Task<AfdSecurityPolicyCreateOperation> CreateOrUpdateAsync(bool waitForCompletion, string securityPolicyName, AfdSecurityPolicyData securityPolicy, CancellationToken cancellationToken = default)
        {
            if (securityPolicyName == null)
            {
                throw new ArgumentNullException(nameof(securityPolicyName));
            }
            if (securityPolicy == null)
            {
                throw new ArgumentNullException(nameof(securityPolicy));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdSecurityPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _afdSecurityPoliciesRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityPolicyName, securityPolicy, cancellationToken).ConfigureAwait(false);
                var operation = new AfdSecurityPolicyCreateOperation(Parent, _clientDiagnostics, Pipeline, _afdSecurityPoliciesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityPolicyName, securityPolicy).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets an existing security policy within a profile. </summary>
        /// <param name="securityPolicyName"> Name of the security policy under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="securityPolicyName"/> is null. </exception>
        public virtual Response<AfdSecurityPolicy> Get(string securityPolicyName, CancellationToken cancellationToken = default)
        {
            if (securityPolicyName == null)
            {
                throw new ArgumentNullException(nameof(securityPolicyName));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdSecurityPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _afdSecurityPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityPolicyName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AfdSecurityPolicy(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets an existing security policy within a profile. </summary>
        /// <param name="securityPolicyName"> Name of the security policy under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="securityPolicyName"/> is null. </exception>
        public async virtual Task<Response<AfdSecurityPolicy>> GetAsync(string securityPolicyName, CancellationToken cancellationToken = default)
        {
            if (securityPolicyName == null)
            {
                throw new ArgumentNullException(nameof(securityPolicyName));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdSecurityPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _afdSecurityPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityPolicyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new AfdSecurityPolicy(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="securityPolicyName"> Name of the security policy under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="securityPolicyName"/> is null. </exception>
        public virtual Response<AfdSecurityPolicy> GetIfExists(string securityPolicyName, CancellationToken cancellationToken = default)
        {
            if (securityPolicyName == null)
            {
                throw new ArgumentNullException(nameof(securityPolicyName));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdSecurityPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _afdSecurityPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityPolicyName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<AfdSecurityPolicy>(null, response.GetRawResponse());
                return Response.FromValue(new AfdSecurityPolicy(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="securityPolicyName"> Name of the security policy under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="securityPolicyName"/> is null. </exception>
        public async virtual Task<Response<AfdSecurityPolicy>> GetIfExistsAsync(string securityPolicyName, CancellationToken cancellationToken = default)
        {
            if (securityPolicyName == null)
            {
                throw new ArgumentNullException(nameof(securityPolicyName));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdSecurityPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _afdSecurityPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<AfdSecurityPolicy>(null, response.GetRawResponse());
                return Response.FromValue(new AfdSecurityPolicy(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="securityPolicyName"> Name of the security policy under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="securityPolicyName"/> is null. </exception>
        public virtual Response<bool> Exists(string securityPolicyName, CancellationToken cancellationToken = default)
        {
            if (securityPolicyName == null)
            {
                throw new ArgumentNullException(nameof(securityPolicyName));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdSecurityPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(securityPolicyName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="securityPolicyName"> Name of the security policy under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="securityPolicyName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string securityPolicyName, CancellationToken cancellationToken = default)
        {
            if (securityPolicyName == null)
            {
                throw new ArgumentNullException(nameof(securityPolicyName));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdSecurityPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(securityPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists security policies associated with the profile. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AfdSecurityPolicy" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AfdSecurityPolicy> GetAll(CancellationToken cancellationToken = default)
        {
            Page<AfdSecurityPolicy> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AfdSecurityPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _afdSecurityPoliciesRestClient.ListByProfile(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdSecurityPolicy(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AfdSecurityPolicy> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AfdSecurityPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _afdSecurityPoliciesRestClient.ListByProfileNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdSecurityPolicy(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists security policies associated with the profile. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AfdSecurityPolicy" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AfdSecurityPolicy> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AfdSecurityPolicy>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AfdSecurityPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _afdSecurityPoliciesRestClient.ListByProfileAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdSecurityPolicy(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AfdSecurityPolicy>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AfdSecurityPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _afdSecurityPoliciesRestClient.ListByProfileNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdSecurityPolicy(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<AfdSecurityPolicy> IEnumerable<AfdSecurityPolicy>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AfdSecurityPolicy> IAsyncEnumerable<AfdSecurityPolicy>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, AfdSecurityPolicy, AfdSecurityPolicyData> Construct() { }
    }
}
