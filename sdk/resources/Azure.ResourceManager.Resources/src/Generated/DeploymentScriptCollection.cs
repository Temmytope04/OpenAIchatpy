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
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class representing collection of DeploymentScript and their operations over its parent. </summary>
    public partial class DeploymentScriptCollection : ArmCollection, IEnumerable<DeploymentScript>, IAsyncEnumerable<DeploymentScript>
    {
        private readonly ClientDiagnostics _deploymentScriptClientDiagnostics;
        private readonly DeploymentScriptsRestOperations _deploymentScriptRestClient;

        /// <summary> Initializes a new instance of the <see cref="DeploymentScriptCollection"/> class for mocking. </summary>
        protected DeploymentScriptCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DeploymentScriptCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DeploymentScriptCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _deploymentScriptClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", DeploymentScript.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(DeploymentScript.ResourceType, out string deploymentScriptApiVersion);
            _deploymentScriptRestClient = new DeploymentScriptsRestOperations(_deploymentScriptClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, deploymentScriptApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// <summary> Creates a deployment script. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="deploymentScript"> Deployment script supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scriptName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptName"/> or <paramref name="deploymentScript"/> is null. </exception>
        public async virtual Task<ArmOperation<DeploymentScript>> CreateOrUpdateAsync(bool waitForCompletion, string scriptName, DeploymentScriptData deploymentScript, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scriptName, nameof(scriptName));
            if (deploymentScript == null)
            {
                throw new ArgumentNullException(nameof(deploymentScript));
            }

            using var scope = _deploymentScriptClientDiagnostics.CreateScope("DeploymentScriptCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _deploymentScriptRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, scriptName, deploymentScript, cancellationToken).ConfigureAwait(false);
                var operation = new ResourcesArmOperation<DeploymentScript>(new DeploymentScriptOperationSource(Client), _deploymentScriptClientDiagnostics, Pipeline, _deploymentScriptRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, scriptName, deploymentScript).Request, response, OperationFinalStateVia.Location);
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

        /// <summary> Creates a deployment script. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="deploymentScript"> Deployment script supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scriptName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptName"/> or <paramref name="deploymentScript"/> is null. </exception>
        public virtual ArmOperation<DeploymentScript> CreateOrUpdate(bool waitForCompletion, string scriptName, DeploymentScriptData deploymentScript, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scriptName, nameof(scriptName));
            if (deploymentScript == null)
            {
                throw new ArgumentNullException(nameof(deploymentScript));
            }

            using var scope = _deploymentScriptClientDiagnostics.CreateScope("DeploymentScriptCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _deploymentScriptRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, scriptName, deploymentScript, cancellationToken);
                var operation = new ResourcesArmOperation<DeploymentScript>(new DeploymentScriptOperationSource(Client), _deploymentScriptClientDiagnostics, Pipeline, _deploymentScriptRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, scriptName, deploymentScript).Request, response, OperationFinalStateVia.Location);
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

        /// <summary> Gets a deployment script with a given name. </summary>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scriptName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptName"/> is null. </exception>
        public async virtual Task<Response<DeploymentScript>> GetAsync(string scriptName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scriptName, nameof(scriptName));

            using var scope = _deploymentScriptClientDiagnostics.CreateScope("DeploymentScriptCollection.Get");
            scope.Start();
            try
            {
                var response = await _deploymentScriptRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, scriptName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _deploymentScriptClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DeploymentScript(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a deployment script with a given name. </summary>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scriptName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptName"/> is null. </exception>
        public virtual Response<DeploymentScript> Get(string scriptName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scriptName, nameof(scriptName));

            using var scope = _deploymentScriptClientDiagnostics.CreateScope("DeploymentScriptCollection.Get");
            scope.Start();
            try
            {
                var response = _deploymentScriptRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, scriptName, cancellationToken);
                if (response.Value == null)
                    throw _deploymentScriptClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeploymentScript(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists deployments scripts. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeploymentScript" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DeploymentScript> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DeploymentScript>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _deploymentScriptClientDiagnostics.CreateScope("DeploymentScriptCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _deploymentScriptRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DeploymentScript(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DeploymentScript>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _deploymentScriptClientDiagnostics.CreateScope("DeploymentScriptCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _deploymentScriptRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DeploymentScript(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists deployments scripts. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeploymentScript" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DeploymentScript> GetAll(CancellationToken cancellationToken = default)
        {
            Page<DeploymentScript> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _deploymentScriptClientDiagnostics.CreateScope("DeploymentScriptCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _deploymentScriptRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DeploymentScript(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DeploymentScript> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _deploymentScriptClientDiagnostics.CreateScope("DeploymentScriptCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _deploymentScriptRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DeploymentScript(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scriptName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string scriptName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scriptName, nameof(scriptName));

            using var scope = _deploymentScriptClientDiagnostics.CreateScope("DeploymentScriptCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(scriptName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scriptName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptName"/> is null. </exception>
        public virtual Response<bool> Exists(string scriptName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scriptName, nameof(scriptName));

            using var scope = _deploymentScriptClientDiagnostics.CreateScope("DeploymentScriptCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(scriptName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scriptName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptName"/> is null. </exception>
        public async virtual Task<Response<DeploymentScript>> GetIfExistsAsync(string scriptName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scriptName, nameof(scriptName));

            using var scope = _deploymentScriptClientDiagnostics.CreateScope("DeploymentScriptCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _deploymentScriptRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, scriptName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<DeploymentScript>(null, response.GetRawResponse());
                return Response.FromValue(new DeploymentScript(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scriptName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptName"/> is null. </exception>
        public virtual Response<DeploymentScript> GetIfExists(string scriptName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scriptName, nameof(scriptName));

            using var scope = _deploymentScriptClientDiagnostics.CreateScope("DeploymentScriptCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _deploymentScriptRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, scriptName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<DeploymentScript>(null, response.GetRawResponse());
                return Response.FromValue(new DeploymentScript(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DeploymentScript> IEnumerable<DeploymentScript>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DeploymentScript> IAsyncEnumerable<DeploymentScript>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
