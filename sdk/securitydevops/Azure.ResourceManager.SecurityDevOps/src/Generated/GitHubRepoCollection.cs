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

namespace Azure.ResourceManager.SecurityDevOps
{
    /// <summary>
    /// A class representing a collection of <see cref="GitHubRepoResource" /> and their operations.
    /// Each <see cref="GitHubRepoResource" /> in the collection will belong to the same instance of <see cref="GitHubOwnerResource" />.
    /// To get a <see cref="GitHubRepoCollection" /> instance call the GetGitHubRepos method from an instance of <see cref="GitHubOwnerResource" />.
    /// </summary>
    public partial class GitHubRepoCollection : ArmCollection, IEnumerable<GitHubRepoResource>, IAsyncEnumerable<GitHubRepoResource>
    {
        private readonly ClientDiagnostics _gitHubRepoClientDiagnostics;
        private readonly GitHubRepoRestOperations _gitHubRepoRestClient;

        /// <summary> Initializes a new instance of the <see cref="GitHubRepoCollection"/> class for mocking. </summary>
        protected GitHubRepoCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="GitHubRepoCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal GitHubRepoCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _gitHubRepoClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityDevOps", GitHubRepoResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(GitHubRepoResource.ResourceType, out string gitHubRepoApiVersion);
            _gitHubRepoRestClient = new GitHubRepoRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, gitHubRepoApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != GitHubOwnerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, GitHubOwnerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a monitored GitHub repository.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/gitHubConnectors/{gitHubConnectorName}/owners/{gitHubOwnerName}/repos/{gitHubRepoName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubRepo_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="gitHubRepoName"> Name of the GitHub Repo. </param>
        /// <param name="data"> Github repo. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gitHubRepoName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gitHubRepoName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<GitHubRepoResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string gitHubRepoName, GitHubRepoData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gitHubRepoName, nameof(gitHubRepoName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _gitHubRepoClientDiagnostics.CreateScope("GitHubRepoCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _gitHubRepoRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, gitHubRepoName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityDevOpsArmOperation<GitHubRepoResource>(new GitHubRepoOperationSource(Client), _gitHubRepoClientDiagnostics, Pipeline, _gitHubRepoRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, gitHubRepoName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create or update a monitored GitHub repository.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/gitHubConnectors/{gitHubConnectorName}/owners/{gitHubOwnerName}/repos/{gitHubRepoName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubRepo_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="gitHubRepoName"> Name of the GitHub Repo. </param>
        /// <param name="data"> Github repo. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gitHubRepoName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gitHubRepoName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<GitHubRepoResource> CreateOrUpdate(WaitUntil waitUntil, string gitHubRepoName, GitHubRepoData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gitHubRepoName, nameof(gitHubRepoName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _gitHubRepoClientDiagnostics.CreateScope("GitHubRepoCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _gitHubRepoRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, gitHubRepoName, data, cancellationToken);
                var operation = new SecurityDevOpsArmOperation<GitHubRepoResource>(new GitHubRepoOperationSource(Client), _gitHubRepoClientDiagnostics, Pipeline, _gitHubRepoRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, gitHubRepoName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Returns a monitored GitHub repository.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/gitHubConnectors/{gitHubConnectorName}/owners/{gitHubOwnerName}/repos/{gitHubRepoName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubRepo_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="gitHubRepoName"> Name of the GitHub Repo. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gitHubRepoName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gitHubRepoName"/> is null. </exception>
        public virtual async Task<Response<GitHubRepoResource>> GetAsync(string gitHubRepoName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gitHubRepoName, nameof(gitHubRepoName));

            using var scope = _gitHubRepoClientDiagnostics.CreateScope("GitHubRepoCollection.Get");
            scope.Start();
            try
            {
                var response = await _gitHubRepoRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, gitHubRepoName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GitHubRepoResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a monitored GitHub repository.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/gitHubConnectors/{gitHubConnectorName}/owners/{gitHubOwnerName}/repos/{gitHubRepoName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubRepo_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="gitHubRepoName"> Name of the GitHub Repo. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gitHubRepoName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gitHubRepoName"/> is null. </exception>
        public virtual Response<GitHubRepoResource> Get(string gitHubRepoName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gitHubRepoName, nameof(gitHubRepoName));

            using var scope = _gitHubRepoClientDiagnostics.CreateScope("GitHubRepoCollection.Get");
            scope.Start();
            try
            {
                var response = _gitHubRepoRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, gitHubRepoName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GitHubRepoResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a list of monitored GitHub repositories.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/gitHubConnectors/{gitHubConnectorName}/owners/{gitHubOwnerName}/repos</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubRepo_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GitHubRepoResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GitHubRepoResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _gitHubRepoRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _gitHubRepoRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new GitHubRepoResource(Client, GitHubRepoData.DeserializeGitHubRepoData(e)), _gitHubRepoClientDiagnostics, Pipeline, "GitHubRepoCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns a list of monitored GitHub repositories.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/gitHubConnectors/{gitHubConnectorName}/owners/{gitHubOwnerName}/repos</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubRepo_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GitHubRepoResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GitHubRepoResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _gitHubRepoRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _gitHubRepoRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new GitHubRepoResource(Client, GitHubRepoData.DeserializeGitHubRepoData(e)), _gitHubRepoClientDiagnostics, Pipeline, "GitHubRepoCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/gitHubConnectors/{gitHubConnectorName}/owners/{gitHubOwnerName}/repos/{gitHubRepoName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubRepo_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="gitHubRepoName"> Name of the GitHub Repo. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gitHubRepoName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gitHubRepoName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string gitHubRepoName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gitHubRepoName, nameof(gitHubRepoName));

            using var scope = _gitHubRepoClientDiagnostics.CreateScope("GitHubRepoCollection.Exists");
            scope.Start();
            try
            {
                var response = await _gitHubRepoRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, gitHubRepoName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/gitHubConnectors/{gitHubConnectorName}/owners/{gitHubOwnerName}/repos/{gitHubRepoName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubRepo_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="gitHubRepoName"> Name of the GitHub Repo. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gitHubRepoName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gitHubRepoName"/> is null. </exception>
        public virtual Response<bool> Exists(string gitHubRepoName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gitHubRepoName, nameof(gitHubRepoName));

            using var scope = _gitHubRepoClientDiagnostics.CreateScope("GitHubRepoCollection.Exists");
            scope.Start();
            try
            {
                var response = _gitHubRepoRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, gitHubRepoName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<GitHubRepoResource> IEnumerable<GitHubRepoResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<GitHubRepoResource> IAsyncEnumerable<GitHubRepoResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
