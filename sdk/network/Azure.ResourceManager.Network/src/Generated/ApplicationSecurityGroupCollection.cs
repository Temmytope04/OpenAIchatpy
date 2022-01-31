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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of ApplicationSecurityGroup and their operations over its parent. </summary>
    public partial class ApplicationSecurityGroupCollection : ArmCollection, IEnumerable<ApplicationSecurityGroup>, IAsyncEnumerable<ApplicationSecurityGroup>
    {
        private readonly ClientDiagnostics _applicationSecurityGroupClientDiagnostics;
        private readonly ApplicationSecurityGroupsRestOperations _applicationSecurityGroupRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApplicationSecurityGroupCollection"/> class for mocking. </summary>
        protected ApplicationSecurityGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApplicationSecurityGroupCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ApplicationSecurityGroupCollection(ArmResource parent) : base(parent)
        {
            _applicationSecurityGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ApplicationSecurityGroup.ResourceType.Namespace, DiagnosticOptions);
            ArmClient.TryGetApiVersion(ApplicationSecurityGroup.ResourceType, out string applicationSecurityGroupApiVersion);
            _applicationSecurityGroupRestClient = new ApplicationSecurityGroupsRestOperations(_applicationSecurityGroupClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, applicationSecurityGroupApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Creates or updates an application security group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="applicationSecurityGroupName"> The name of the application security group. </param>
        /// <param name="parameters"> Parameters supplied to the create or update ApplicationSecurityGroup operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationSecurityGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationSecurityGroupName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ApplicationSecurityGroupCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string applicationSecurityGroupName, ApplicationSecurityGroupData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationSecurityGroupName, nameof(applicationSecurityGroupName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _applicationSecurityGroupClientDiagnostics.CreateScope("ApplicationSecurityGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _applicationSecurityGroupRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, applicationSecurityGroupName, parameters, cancellationToken);
                var operation = new ApplicationSecurityGroupCreateOrUpdateOperation(ArmClient, _applicationSecurityGroupClientDiagnostics, Pipeline, _applicationSecurityGroupRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, applicationSecurityGroupName, parameters).Request, response);
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

        /// <summary> Creates or updates an application security group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="applicationSecurityGroupName"> The name of the application security group. </param>
        /// <param name="parameters"> Parameters supplied to the create or update ApplicationSecurityGroup operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationSecurityGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationSecurityGroupName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ApplicationSecurityGroupCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string applicationSecurityGroupName, ApplicationSecurityGroupData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationSecurityGroupName, nameof(applicationSecurityGroupName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _applicationSecurityGroupClientDiagnostics.CreateScope("ApplicationSecurityGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _applicationSecurityGroupRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, applicationSecurityGroupName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ApplicationSecurityGroupCreateOrUpdateOperation(ArmClient, _applicationSecurityGroupClientDiagnostics, Pipeline, _applicationSecurityGroupRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, applicationSecurityGroupName, parameters).Request, response);
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

        /// <summary> Gets information about the specified application security group. </summary>
        /// <param name="applicationSecurityGroupName"> The name of the application security group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationSecurityGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationSecurityGroupName"/> is null. </exception>
        public virtual Response<ApplicationSecurityGroup> Get(string applicationSecurityGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationSecurityGroupName, nameof(applicationSecurityGroupName));

            using var scope = _applicationSecurityGroupClientDiagnostics.CreateScope("ApplicationSecurityGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _applicationSecurityGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, applicationSecurityGroupName, cancellationToken);
                if (response.Value == null)
                    throw _applicationSecurityGroupClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApplicationSecurityGroup(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets information about the specified application security group. </summary>
        /// <param name="applicationSecurityGroupName"> The name of the application security group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationSecurityGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationSecurityGroupName"/> is null. </exception>
        public async virtual Task<Response<ApplicationSecurityGroup>> GetAsync(string applicationSecurityGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationSecurityGroupName, nameof(applicationSecurityGroupName));

            using var scope = _applicationSecurityGroupClientDiagnostics.CreateScope("ApplicationSecurityGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _applicationSecurityGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, applicationSecurityGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _applicationSecurityGroupClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ApplicationSecurityGroup(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="applicationSecurityGroupName"> The name of the application security group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationSecurityGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationSecurityGroupName"/> is null. </exception>
        public virtual Response<ApplicationSecurityGroup> GetIfExists(string applicationSecurityGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationSecurityGroupName, nameof(applicationSecurityGroupName));

            using var scope = _applicationSecurityGroupClientDiagnostics.CreateScope("ApplicationSecurityGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _applicationSecurityGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, applicationSecurityGroupName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ApplicationSecurityGroup>(null, response.GetRawResponse());
                return Response.FromValue(new ApplicationSecurityGroup(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="applicationSecurityGroupName"> The name of the application security group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationSecurityGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationSecurityGroupName"/> is null. </exception>
        public async virtual Task<Response<ApplicationSecurityGroup>> GetIfExistsAsync(string applicationSecurityGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationSecurityGroupName, nameof(applicationSecurityGroupName));

            using var scope = _applicationSecurityGroupClientDiagnostics.CreateScope("ApplicationSecurityGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _applicationSecurityGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, applicationSecurityGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ApplicationSecurityGroup>(null, response.GetRawResponse());
                return Response.FromValue(new ApplicationSecurityGroup(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="applicationSecurityGroupName"> The name of the application security group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationSecurityGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationSecurityGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string applicationSecurityGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationSecurityGroupName, nameof(applicationSecurityGroupName));

            using var scope = _applicationSecurityGroupClientDiagnostics.CreateScope("ApplicationSecurityGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(applicationSecurityGroupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="applicationSecurityGroupName"> The name of the application security group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationSecurityGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationSecurityGroupName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string applicationSecurityGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationSecurityGroupName, nameof(applicationSecurityGroupName));

            using var scope = _applicationSecurityGroupClientDiagnostics.CreateScope("ApplicationSecurityGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(applicationSecurityGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all the application security groups in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApplicationSecurityGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApplicationSecurityGroup> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ApplicationSecurityGroup> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _applicationSecurityGroupClientDiagnostics.CreateScope("ApplicationSecurityGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _applicationSecurityGroupRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ApplicationSecurityGroup(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ApplicationSecurityGroup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _applicationSecurityGroupClientDiagnostics.CreateScope("ApplicationSecurityGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _applicationSecurityGroupRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ApplicationSecurityGroup(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all the application security groups in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApplicationSecurityGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApplicationSecurityGroup> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ApplicationSecurityGroup>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _applicationSecurityGroupClientDiagnostics.CreateScope("ApplicationSecurityGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _applicationSecurityGroupRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ApplicationSecurityGroup(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ApplicationSecurityGroup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _applicationSecurityGroupClientDiagnostics.CreateScope("ApplicationSecurityGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _applicationSecurityGroupRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ApplicationSecurityGroup(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<ApplicationSecurityGroup> IEnumerable<ApplicationSecurityGroup>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ApplicationSecurityGroup> IAsyncEnumerable<ApplicationSecurityGroup>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
