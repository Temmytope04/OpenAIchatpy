// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Core.Resources;

namespace Azure.ResourceManager.NewResources
{
    /// <summary> A class representing collection of PolicyAssignment and their operations over a scope. </summary>
    public partial class PolicyAssignmentContainer : ContainerBase
    {
        /// <summary> Initializes a new instance of the <see cref="PolicyAssignmentContainer"/> class for mocking. </summary>
        protected PolicyAssignmentContainer()
        {
        }

        /// <summary> Initializes a new instance of PolicyAssignmentContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        /// <param name="scope"> Typed scope Identifier for the container. </param>
        internal PolicyAssignmentContainer(OperationsBase parent, ResourceIdentifier scope) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            // TODO: Validate scope
            _scope = scope;
        }

        private readonly ResourceIdentifier _scope;

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private PolicyAssignmentsRestOperations _restClient => new PolicyAssignmentsRestOperations(_clientDiagnostics, Pipeline);

        /// <summary> Typed Resource Identifier for the container. </summary>
        public new ResourceIdentifier Id => base.Id as ResourceIdentifier;

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceIdentifier.RootResourceIdentifier.ResourceType;

        // Container level operations.

        /// <summary> The operation to create or update a PolicyAssignment. Please note some properties can be set only during creation. </summary>
        /// <param name="policyAssignmentName"> The name of the policy assignment. </param>
        /// <param name="parameters"> Parameters for the policy assignment. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public Response<PolicyAssignment> CreateOrUpdate(string policyAssignmentName, PolicyAssignmentData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (policyAssignmentName == null)
                {
                    throw new ArgumentNullException(nameof(policyAssignmentName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                return StartCreateOrUpdate(policyAssignmentName, parameters, cancellationToken: cancellationToken).WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a PolicyAssignment. Please note some properties can be set only during creation. </summary>
        /// <param name="policyAssignmentName"> The name of the policy assignment. </param>
        /// <param name="parameters"> Parameters for the policy assignment. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<Response<PolicyAssignment>> CreateOrUpdateAsync(string policyAssignmentName, PolicyAssignmentData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (policyAssignmentName == null)
                {
                    throw new ArgumentNullException(nameof(policyAssignmentName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var operation = await StartCreateOrUpdateAsync(policyAssignmentName, parameters, cancellationToken: cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a PolicyAssignment. Please note some properties can be set only during creation. </summary>
        /// <param name="policyAssignmentName"> The name of the policy assignment. </param>
        /// <param name="parameters"> Parameters for the policy assignment. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public PolicyAssignmentsCreateOperation StartCreateOrUpdate(string policyAssignmentName, PolicyAssignmentData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (policyAssignmentName == null)
                {
                    throw new ArgumentNullException(nameof(policyAssignmentName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var originalResponse = _restClient.Create(_scope, policyAssignmentName, parameters, cancellationToken: cancellationToken);
                return new PolicyAssignmentsCreateOperation(Parent, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a PolicyAssignment. Please note some properties can be set only during creation. </summary>
        /// <param name="policyAssignmentName"> The name of the policy assignment. </param>
        /// <param name="parameters"> Parameters for the policy assignment. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<PolicyAssignmentsCreateOperation> StartCreateOrUpdateAsync(string policyAssignmentName, PolicyAssignmentData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (policyAssignmentName == null)
                {
                    throw new ArgumentNullException(nameof(policyAssignmentName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var originalResponse = await _restClient.CreateAsync(_scope, policyAssignmentName, parameters, cancellationToken: cancellationToken).ConfigureAwait(false);
                return new PolicyAssignmentsCreateOperation(Parent, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a PolicyAssignment by ID. Please note some properties can be set only during creation. </summary>
        /// <param name="policyAssignmentId"> The ID of the policy assignment. </param>
        /// <param name="parameters"> Parameters for the policy assignment. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public Response<PolicyAssignment> CreateById(string policyAssignmentId, PolicyAssignmentData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentContainer.CreateById");
            scope.Start();
            try
            {
                if (policyAssignmentId == null)
                {
                    throw new ArgumentNullException(nameof(policyAssignmentId));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                return StartCreateById(policyAssignmentId, parameters, cancellationToken: cancellationToken).WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a PolicyAssignment by ID. Please note some properties can be set only during creation. </summary>
        /// <param name="policyAssignmentId"> The ID of the policy assignment. </param>
        /// <param name="parameters"> Parameters for the policy assignment. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<Response<PolicyAssignment>> CreateByIdAsync(string policyAssignmentId, PolicyAssignmentData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentContainer.CreateById");
            scope.Start();
            try
            {
                if (policyAssignmentId == null)
                {
                    throw new ArgumentNullException(nameof(policyAssignmentId));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var operation = await StartCreateByIdAsync(policyAssignmentId, parameters, cancellationToken: cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a PolicyAssignment by ID. Please note some properties can be set only during creation. </summary>
        /// <param name="policyAssignmentId"> The ID of the policy assignment. </param>
        /// <param name="parameters"> Parameters for the policy assignment. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public PolicyAssignmentsCreateByIdOperation StartCreateById(string policyAssignmentId, PolicyAssignmentData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentContainer.StartCreateById");
            scope.Start();
            try
            {
                if (policyAssignmentId == null)
                {
                    throw new ArgumentNullException(nameof(policyAssignmentId));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var originalResponse = _restClient.CreateById(policyAssignmentId, parameters, cancellationToken: cancellationToken);
                return new PolicyAssignmentsCreateByIdOperation(Parent, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a PolicyAssignment by ID. Please note some properties can be set only during creation. </summary>
        /// <param name="policyAssignmentId"> The ID of the policy assignment. </param>
        /// <param name="parameters"> Parameters for the policy assignment. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<PolicyAssignmentsCreateByIdOperation> StartCreateByIdAsync(string policyAssignmentId, PolicyAssignmentData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentContainer.StartCreateById");
            scope.Start();
            try
            {
                if (policyAssignmentId == null)
                {
                    throw new ArgumentNullException(nameof(policyAssignmentId));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var originalResponse = await _restClient.CreateByIdAsync(policyAssignmentId, parameters, cancellationToken: cancellationToken).ConfigureAwait(false);
                return new PolicyAssignmentsCreateByIdOperation(Parent, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        /// <param name="policyAssignmentName"> The name of the policy assignment to get. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public Response<PolicyAssignment> Get(string policyAssignmentName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentContainer.Get");
            scope.Start();
            try
            {
                if (policyAssignmentName == null)
                {
                    throw new ArgumentNullException(nameof(policyAssignmentName));
                }

                var response = _restClient.Get(_scope, policyAssignmentName, cancellationToken: cancellationToken);
                return Response.FromValue(new PolicyAssignment(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        /// <param name="policyAssignmentName"> The name of the policy assignment to get. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<Response<PolicyAssignment>> GetAsync(string policyAssignmentName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentContainer.Get");
            scope.Start();
            try
            {
                if (policyAssignmentName == null)
                {
                    throw new ArgumentNullException(nameof(policyAssignmentName));
                }

                var response = await _restClient.GetAsync(_scope, policyAssignmentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new PolicyAssignment(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        /// <param name="policyAssignmentId"> The ID of the policy assignment to get. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public Response<PolicyAssignment> GetById(string policyAssignmentId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentContainer.GetById");
            scope.Start();
            try
            {
                if (policyAssignmentId == null)
                {
                    throw new ArgumentNullException(nameof(policyAssignmentId));
                }

                var response = _restClient.GetById(policyAssignmentId, cancellationToken: cancellationToken);
                return Response.FromValue(new PolicyAssignment(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation retrieves the policy assignment with the given ID. Policy assignment IDs have this format: &apos;{scope}/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}&apos;. Valid scopes are: management group (format: &apos;/providers/Microsoft.Management/managementGroups/{managementGroup}&apos;), subscription (format: &apos;/subscriptions/{subscriptionId}&apos;), resource group (format: &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}&apos;, or resource (format: &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/[{parentResourcePath}/]{resourceType}/{resourceName}&apos;. </summary>
        /// <param name="policyAssignmentId"> The ID of the policy assignment to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<PolicyAssignment>> GetByIdAsync(string policyAssignmentId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentOperations.GetById");
            scope.Start();
            try
            {
                if (policyAssignmentId == null)
                {
                    throw new ArgumentNullException(nameof(policyAssignmentId));
                }

                var response = await _restClient.GetByIdAsync(policyAssignmentId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new PolicyAssignment(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation retrieves the list of all policy assignments associated with the given subscription that match the optional given $filter. Valid values for $filter are: &apos;atScope()&apos; or &apos;policyDefinitionId eq &apos;{value}&apos;&apos;. If $filter is not provided, the unfiltered list includes all policy assignments associated with the subscription, including those that apply directly or from management groups that contain the given subscription, as well as any applied to objects contained within the subscription. If $filter=atScope() is provided, the returned list includes all policy assignments that apply to the subscription, which is everything in the unfiltered list except those applied to objects contained within the subscription. If $filter=policyDefinitionId eq &apos;{value}&apos; is provided, the returned list includes all policy assignments of the policy definition whose id is {value}. </summary>
        /// <param name="filter"> The filter to apply on the operation. Valid values for $filter are: &apos;atScope()&apos; or &apos;policyDefinitionId eq &apos;{value}&apos;&apos;. If $filter is not provided, no filtering is performed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PolicyAssignment" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<PolicyAssignment> List(string filter = null, CancellationToken cancellationToken = default)
        {
            Page<PolicyAssignment> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentTenantContainer.List");
                scope.Start();
                try
                {
                    Response<PolicyAssignmentListResult> response;
                    var scopeParts = _scope.ToString().Split('/');

                    if (_scope.GetType() == typeof(SubscriptionResourceIdentifier))
                    {
                        var s = _scope as SubscriptionResourceIdentifier;
                        response = _restClient.List(s.SubscriptionId, filter, cancellationToken);
                    }
                    else if (_scope.GetType() == typeof(TenantResourceIdentifier) && _scope.ToString().StartsWith("/providers/Microsoft.Management/managementGroups/"))
                    {
                        response = _restClient.ListForManagementGroup(_scope.Name, filter, cancellationToken);
                    }
                    else if (_scope.GetType() == typeof(ResourceGroupResourceIdentifier) && scopeParts[scopeParts.Length - 2].Equals("resourceGroups"))
                    {
                        var s = _scope as ResourceGroupResourceIdentifier;
                        response = _restClient.ListForResourceGroup(s.SubscriptionId, s.ResourceGroupName, filter, cancellationToken);
                    }
                    else
                    {
                        var s = _scope as ResourceGroupResourceIdentifier;
                        var parts = s.ToString().Substring(s.ToString().IndexOf("providers/")).ToString().Split('/');
                        var resourceProviderNamespace = parts[1];
                        var resourceType = parts[parts.Length - 2];
                        var startIndex = s.ToString().IndexOf($"providers/{resourceProviderNamespace}") + $"providers/{resourceProviderNamespace}/".Length;
                        var endIndex = s.ToString().IndexOf($"/{resourceType}");
                        var parentResourcePath = startIndex >= endIndex ? "" : s.ToString().Substring(startIndex, endIndex - startIndex);
                        response = _restClient.ListForResource(s.SubscriptionId, s.ResourceGroupName, resourceProviderNamespace, parentResourcePath, resourceType, s.Name, filter, cancellationToken);
                    }

                    return Page.FromValues(response.Value.Value.Select(value => new PolicyAssignment(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<PolicyAssignment> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentTenantContainer.List");
                scope.Start();
                try
                {
                    var response = _restClient.ListNextPage(nextLink, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PolicyAssignment(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> This operation retrieves the list of all policy assignments associated with the given subscription that match the optional given $filter. Valid values for $filter are: &apos;atScope()&apos; or &apos;policyDefinitionId eq &apos;{value}&apos;&apos;. If $filter is not provided, the unfiltered list includes all policy assignments associated with the subscription, including those that apply directly or from management groups that contain the given subscription, as well as any applied to objects contained within the subscription. If $filter=atScope() is provided, the returned list includes all policy assignments that apply to the subscription, which is everything in the unfiltered list except those applied to objects contained within the subscription. If $filter=policyDefinitionId eq &apos;{value}&apos; is provided, the returned list includes all policy assignments of the policy definition whose id is {value}. </summary>
        /// <param name="filter"> The filter to apply on the operation. Valid values for $filter are: &apos;atScope()&apos; or &apos;policyDefinitionId eq &apos;{value}&apos;&apos;. If $filter is not provided, no filtering is performed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PolicyAssignment" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<PolicyAssignment> ListAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<PolicyAssignment>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentTenantContainer.List");
                scope.Start();
                try
                {
                    Response<PolicyAssignmentListResult> response;
                    var scopeParts = _scope.ToString().Split('/');

                    if (_scope.GetType() == typeof(SubscriptionResourceIdentifier))
                    {
                        var s = _scope as SubscriptionResourceIdentifier;
                        response = await _restClient.ListAsync(s.SubscriptionId, filter, cancellationToken).ConfigureAwait(false);
                    }
                    else if (_scope.GetType() == typeof(TenantResourceIdentifier) && _scope.ToString().StartsWith("/providers/Microsoft.Management/managementGroups/"))
                    {
                        response = await _restClient.ListForManagementGroupAsync(_scope.Name, filter, cancellationToken).ConfigureAwait(false);
                    }
                    else if (_scope.GetType() == typeof(ResourceGroupResourceIdentifier) && scopeParts[scopeParts.Length - 2].Equals("resourceGroups"))
                    {
                        var s = _scope as ResourceGroupResourceIdentifier;
                        response = await _restClient.ListForResourceGroupAsync(s.SubscriptionId, s.ResourceGroupName, filter, cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        var s = _scope as ResourceGroupResourceIdentifier;
                        var parts = s.ToString().Substring(s.ToString().IndexOf("providers/")).ToString().Split('/');
                        var resourceProviderNamespace = parts[1];
                        var resourceType = parts[parts.Length - 2];
                        var startIndex = s.ToString().IndexOf($"providers/{resourceProviderNamespace}") + $"providers/{resourceProviderNamespace}/".Length;
                        var endIndex = s.ToString().IndexOf($"/{resourceType}");
                        var parentResourcePath = startIndex >= endIndex ? "" : s.ToString().Substring(startIndex, endIndex - startIndex);
                        response = await _restClient.ListForResourceAsync(s.SubscriptionId, s.ResourceGroupName, resourceProviderNamespace, parentResourcePath, resourceType, s.Name, filter, cancellationToken).ConfigureAwait(false);
                    }

                    return Page.FromValues(response.Value.Value.Select(value => new PolicyAssignment(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<PolicyAssignment>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentTenantContainer.List");
                scope.Start();
                try
                {
                    var response = await _restClient.ListNextPageAsync(nextLink, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PolicyAssignment(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        // /// <summary> Filters the list of PolicyAssignment for this resource group represented as generic resources. </summary>
        // /// <param name="nameFilter"> The filter used in this operation. </param>
        // /// <param name="top"> The number of results to return. </param>
        // /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        // /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        // public Pageable<Core.GenericResource> ListAsGenericResource(string nameFilter, int? top = null, CancellationToken cancellationToken = default)
        // {
        //     using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentContainer.ListAsGenericResource");
        //     scope.Start();
        //     try
        //     {
        //         var filters = new ResourceFilterCollection(PolicyAssignment.ResourceType);
        //         filters.SubstringFilter = nameFilter;
        //         return ResourceListOperations.ListAtContext(Parent as ResourceGroupOperations, filters, top, cancellationToken);
        //     }
        //     catch (Exception e)
        //     {
        //         scope.Failed(e);
        //         throw;
        //     }
        // }

        // /// <summary> Filters the list of PolicyAssignment for this resource group represented as generic resources. </summary>
        // /// <param name="nameFilter"> The filter used in this operation. </param>
        // /// <param name="top"> The number of results to return. </param>
        // /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        // /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        // public AsyncPageable<Core.GenericResource> ListAsGenericResourceAsync(string nameFilter, int? top = null, CancellationToken cancellationToken = default)
        // {
        //     using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentContainer.ListAsGenericResource");
        //     scope.Start();
        //     try
        //     {
        //         var filters = new ResourceFilterCollection(PolicyAssignment.ResourceType);
        //         filters.SubstringFilter = nameFilter;
        //         return ResourceListOperations.ListAtContextAsync(Parent as ResourceGroupOperations, filters, top, cancellationToken);
        //     }
        //     catch (Exception e)
        //     {
        //         scope.Failed(e);
        //         throw;
        //     }
        // }

        // Builders.
        // public ArmBuilder<ResourceGroupResourceIdentifier, PolicyAssignment, PolicyAssignmentData> Construct() { }
    }
}
