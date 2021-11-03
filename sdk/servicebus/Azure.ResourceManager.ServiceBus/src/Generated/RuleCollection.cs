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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.ServiceBus.Models;

namespace Azure.ResourceManager.ServiceBus
{
    /// <summary> A class representing collection of Rule and their operations over a ServiceBusSubscription. </summary>
    public partial class RuleCollection : ArmCollection, IEnumerable<Rule>, IAsyncEnumerable<Rule>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly RulesRestOperations _restClient;

        /// <summary> Initializes a new instance of the <see cref="RuleCollection"/> class for mocking. </summary>
        protected RuleCollection()
        {
        }

        /// <summary> Initializes a new instance of RuleCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal RuleCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new RulesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        IEnumerator<Rule> IEnumerable<Rule>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<Rule> IAsyncEnumerable<Rule>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ServiceBusSubscription.ResourceType;

        // Collection level operations.

        /// <summary> Creates a new rule and updates an existing rule. </summary>
        /// <param name="ruleName"> The rule name. </param>
        /// <param name="parameters"> Parameters supplied to create a rule. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual RuleCreateOrUpdateOperation CreateOrUpdate(string ruleName, RuleData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (ruleName == null)
            {
                throw new ArgumentNullException(nameof(ruleName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("RuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, ruleName, parameters, cancellationToken);
                var operation = new RuleCreateOrUpdateOperation(Parent, response);
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

        /// <summary> Creates a new rule and updates an existing rule. </summary>
        /// <param name="ruleName"> The rule name. </param>
        /// <param name="parameters"> Parameters supplied to create a rule. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<RuleCreateOrUpdateOperation> CreateOrUpdateAsync(string ruleName, RuleData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (ruleName == null)
            {
                throw new ArgumentNullException(nameof(ruleName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("RuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, ruleName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new RuleCreateOrUpdateOperation(Parent, response);
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

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="ruleName"> The rule name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<Rule> Get(string ruleName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RuleCollection.Get");
            scope.Start();
            try
            {
                if (ruleName == null)
                {
                    throw new ArgumentNullException(nameof(ruleName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, ruleName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Rule(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="ruleName"> The rule name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<Rule>> GetAsync(string ruleName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RuleCollection.Get");
            scope.Start();
            try
            {
                if (ruleName == null)
                {
                    throw new ArgumentNullException(nameof(ruleName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, ruleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new Rule(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ruleName"> The rule name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<Rule> GetIfExists(string ruleName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RuleCollection.GetIfExists");
            scope.Start();
            try
            {
                if (ruleName == null)
                {
                    throw new ArgumentNullException(nameof(ruleName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, ruleName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<Rule>(null, response.GetRawResponse())
                    : Response.FromValue(new Rule(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ruleName"> The rule name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<Rule>> GetIfExistsAsync(string ruleName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RuleCollection.GetIfExists");
            scope.Start();
            try
            {
                if (ruleName == null)
                {
                    throw new ArgumentNullException(nameof(ruleName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, ruleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<Rule>(null, response.GetRawResponse())
                    : Response.FromValue(new Rule(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ruleName"> The rule name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string ruleName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RuleCollection.CheckIfExists");
            scope.Start();
            try
            {
                if (ruleName == null)
                {
                    throw new ArgumentNullException(nameof(ruleName));
                }

                var response = GetIfExists(ruleName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ruleName"> The rule name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string ruleName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RuleCollection.CheckIfExists");
            scope.Start();
            try
            {
                if (ruleName == null)
                {
                    throw new ArgumentNullException(nameof(ruleName));
                }

                var response = await GetIfExistsAsync(ruleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List all the rules within given topic-subscription. </summary>
        /// <param name="skip"> Skip is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skip parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="top"> May be used to limit the number of results to the most recent N usageDetails. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Rule" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Rule> GetAll(int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            Page<Rule> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllBySubscriptions(Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, skip, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Rule(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Rule> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllBySubscriptionsNextPage(nextLink, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, skip, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Rule(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> List all the rules within given topic-subscription. </summary>
        /// <param name="skip"> Skip is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skip parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="top"> May be used to limit the number of results to the most recent N usageDetails. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Rule" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Rule> GetAllAsync(int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<Rule>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllBySubscriptionsAsync(Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, skip, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Rule(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Rule>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllBySubscriptionsNextPageAsync(nextLink, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, skip, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Rule(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, Rule, RuleData> Construct() { }
    }
}
