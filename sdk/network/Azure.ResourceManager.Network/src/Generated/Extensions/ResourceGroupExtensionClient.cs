// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> An internal class to add extension methods to. </summary>
    internal partial class ResourceGroupExtensionClient : ArmResource
    {
        private ClientDiagnostics _availableResourceGroupDelegationsClientDiagnostics;
        private AvailableResourceGroupDelegationsRestOperations _availableResourceGroupDelegationsRestClient;
        private ClientDiagnostics _availableServiceAliasesClientDiagnostics;
        private AvailableServiceAliasesRestOperations _availableServiceAliasesRestClient;
        private ClientDiagnostics _availablePrivateEndpointTypesClientDiagnostics;
        private AvailablePrivateEndpointTypesRestOperations _availablePrivateEndpointTypesRestClient;
        private ClientDiagnostics _privateLinkServicesClientDiagnostics;
        private PrivateLinkServicesRestOperations _privateLinkServicesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupExtensionClient"/> class for mocking. </summary>
        protected ResourceGroupExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupExtensionClient"/> class. </summary>
        /// <param name="armClient"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceGroupExtensionClient(ArmClient armClient, ResourceIdentifier id) : base(armClient, id)
        {
        }

        private ClientDiagnostics AvailableResourceGroupDelegationsClientDiagnostics => _availableResourceGroupDelegationsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Network", ProviderConstants.DefaultProviderNamespace, DiagnosticOptions);
        private AvailableResourceGroupDelegationsRestOperations AvailableResourceGroupDelegationsRestClient => _availableResourceGroupDelegationsRestClient ??= new AvailableResourceGroupDelegationsRestOperations(AvailableResourceGroupDelegationsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri);
        private ClientDiagnostics AvailableServiceAliasesClientDiagnostics => _availableServiceAliasesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Network", ProviderConstants.DefaultProviderNamespace, DiagnosticOptions);
        private AvailableServiceAliasesRestOperations AvailableServiceAliasesRestClient => _availableServiceAliasesRestClient ??= new AvailableServiceAliasesRestOperations(AvailableServiceAliasesClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri);
        private ClientDiagnostics AvailablePrivateEndpointTypesClientDiagnostics => _availablePrivateEndpointTypesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Network", ProviderConstants.DefaultProviderNamespace, DiagnosticOptions);
        private AvailablePrivateEndpointTypesRestOperations AvailablePrivateEndpointTypesRestClient => _availablePrivateEndpointTypesRestClient ??= new AvailablePrivateEndpointTypesRestOperations(AvailablePrivateEndpointTypesClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri);
        private ClientDiagnostics PrivateLinkServicesClientDiagnostics => _privateLinkServicesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Network", ProviderConstants.DefaultProviderNamespace, DiagnosticOptions);
        private PrivateLinkServicesRestOperations PrivateLinkServicesRestClient => _privateLinkServicesRestClient ??= new PrivateLinkServicesRestOperations(PrivateLinkServicesClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            ArmClient.TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets all of the available subnet delegations for this resource group in this region. </summary>
        /// <param name="location"> The location of the domain name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        /// <returns> An async collection of <see cref="AvailableDelegation" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AvailableDelegation> GetAvailableResourceGroupDelegationsAsync(string location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));

            async Task<Page<AvailableDelegation>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = AvailableResourceGroupDelegationsClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetAvailableResourceGroupDelegations");
                scope.Start();
                try
                {
                    var response = await AvailableResourceGroupDelegationsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, location, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AvailableDelegation>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = AvailableResourceGroupDelegationsClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetAvailableResourceGroupDelegations");
                scope.Start();
                try
                {
                    var response = await AvailableResourceGroupDelegationsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, location, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all of the available subnet delegations for this resource group in this region. </summary>
        /// <param name="location"> The location of the domain name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        /// <returns> A collection of <see cref="AvailableDelegation" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AvailableDelegation> GetAvailableResourceGroupDelegations(string location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));

            Page<AvailableDelegation> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = AvailableResourceGroupDelegationsClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetAvailableResourceGroupDelegations");
                scope.Start();
                try
                {
                    var response = AvailableResourceGroupDelegationsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, location, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AvailableDelegation> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = AvailableResourceGroupDelegationsClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetAvailableResourceGroupDelegations");
                scope.Start();
                try
                {
                    var response = AvailableResourceGroupDelegationsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, location, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all available service aliases for this resource group in this region. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        /// <returns> An async collection of <see cref="AvailableServiceAlias" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AvailableServiceAlias> GetAvailableServiceAliasesAsync(string location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));

            async Task<Page<AvailableServiceAlias>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = AvailableServiceAliasesClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetAvailableServiceAliases");
                scope.Start();
                try
                {
                    var response = await AvailableServiceAliasesRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, location, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AvailableServiceAlias>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = AvailableServiceAliasesClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetAvailableServiceAliases");
                scope.Start();
                try
                {
                    var response = await AvailableServiceAliasesRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, location, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all available service aliases for this resource group in this region. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        /// <returns> A collection of <see cref="AvailableServiceAlias" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AvailableServiceAlias> GetAvailableServiceAliases(string location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));

            Page<AvailableServiceAlias> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = AvailableServiceAliasesClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetAvailableServiceAliases");
                scope.Start();
                try
                {
                    var response = AvailableServiceAliasesRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, location, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AvailableServiceAlias> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = AvailableServiceAliasesClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetAvailableServiceAliases");
                scope.Start();
                try
                {
                    var response = AvailableServiceAliasesRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, location, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Returns all of the resource types that can be linked to a Private Endpoint in this subscription in this region. </summary>
        /// <param name="location"> The location of the domain name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        /// <returns> An async collection of <see cref="AvailablePrivateEndpointType" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AvailablePrivateEndpointType> GetAvailablePrivateEndpointTypesAsync(string location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));

            async Task<Page<AvailablePrivateEndpointType>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = AvailablePrivateEndpointTypesClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetAvailablePrivateEndpointTypes");
                scope.Start();
                try
                {
                    var response = await AvailablePrivateEndpointTypesRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, location, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AvailablePrivateEndpointType>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = AvailablePrivateEndpointTypesClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetAvailablePrivateEndpointTypes");
                scope.Start();
                try
                {
                    var response = await AvailablePrivateEndpointTypesRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, location, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Returns all of the resource types that can be linked to a Private Endpoint in this subscription in this region. </summary>
        /// <param name="location"> The location of the domain name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        /// <returns> A collection of <see cref="AvailablePrivateEndpointType" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AvailablePrivateEndpointType> GetAvailablePrivateEndpointTypes(string location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));

            Page<AvailablePrivateEndpointType> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = AvailablePrivateEndpointTypesClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetAvailablePrivateEndpointTypes");
                scope.Start();
                try
                {
                    var response = AvailablePrivateEndpointTypesRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, location, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AvailablePrivateEndpointType> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = AvailablePrivateEndpointTypesClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetAvailablePrivateEndpointTypes");
                scope.Start();
                try
                {
                    var response = AvailablePrivateEndpointTypesRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, location, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Checks whether the subscription is visible to private link service in the specified resource group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="location"> The location of the domain name. </param>
        /// <param name="parameters"> The request body of CheckPrivateLinkService API call. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<CheckPrivateLinkServiceVisibilityByResourceGroupPrivateLinkServiceOperation> CheckPrivateLinkServiceVisibilityByResourceGroupPrivateLinkServiceAsync(bool waitForCompletion, string location, CheckPrivateLinkServiceVisibilityRequest parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = PrivateLinkServicesClientDiagnostics.CreateScope("ResourceGroupExtensionClient.CheckPrivateLinkServiceVisibilityByResourceGroupPrivateLinkService");
            scope.Start();
            try
            {
                var response = await PrivateLinkServicesRestClient.CheckPrivateLinkServiceVisibilityByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, location, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new CheckPrivateLinkServiceVisibilityByResourceGroupPrivateLinkServiceOperation(PrivateLinkServicesClientDiagnostics, Pipeline, PrivateLinkServicesRestClient.CreateCheckPrivateLinkServiceVisibilityByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, location, parameters).Request, response);
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

        /// <summary> Checks whether the subscription is visible to private link service in the specified resource group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="location"> The location of the domain name. </param>
        /// <param name="parameters"> The request body of CheckPrivateLinkService API call. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="parameters"/> is null. </exception>
        public virtual CheckPrivateLinkServiceVisibilityByResourceGroupPrivateLinkServiceOperation CheckPrivateLinkServiceVisibilityByResourceGroupPrivateLinkService(bool waitForCompletion, string location, CheckPrivateLinkServiceVisibilityRequest parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = PrivateLinkServicesClientDiagnostics.CreateScope("ResourceGroupExtensionClient.CheckPrivateLinkServiceVisibilityByResourceGroupPrivateLinkService");
            scope.Start();
            try
            {
                var response = PrivateLinkServicesRestClient.CheckPrivateLinkServiceVisibilityByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, location, parameters, cancellationToken);
                var operation = new CheckPrivateLinkServiceVisibilityByResourceGroupPrivateLinkServiceOperation(PrivateLinkServicesClientDiagnostics, Pipeline, PrivateLinkServicesRestClient.CreateCheckPrivateLinkServiceVisibilityByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, location, parameters).Request, response);
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

        /// <summary> Returns all of the private link service ids that can be linked to a Private Endpoint with auto approved in this subscription in this region. </summary>
        /// <param name="location"> The location of the domain name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        /// <returns> An async collection of <see cref="AutoApprovedPrivateLinkService" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AutoApprovedPrivateLinkService> GetAutoApprovedPrivateLinkServicesPrivateLinkServicesAsync(string location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));

            async Task<Page<AutoApprovedPrivateLinkService>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = PrivateLinkServicesClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetAutoApprovedPrivateLinkServicesPrivateLinkServices");
                scope.Start();
                try
                {
                    var response = await PrivateLinkServicesRestClient.ListAutoApprovedPrivateLinkServicesByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, location, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AutoApprovedPrivateLinkService>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = PrivateLinkServicesClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetAutoApprovedPrivateLinkServicesPrivateLinkServices");
                scope.Start();
                try
                {
                    var response = await PrivateLinkServicesRestClient.ListAutoApprovedPrivateLinkServicesByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, location, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Returns all of the private link service ids that can be linked to a Private Endpoint with auto approved in this subscription in this region. </summary>
        /// <param name="location"> The location of the domain name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        /// <returns> A collection of <see cref="AutoApprovedPrivateLinkService" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AutoApprovedPrivateLinkService> GetAutoApprovedPrivateLinkServicesPrivateLinkServices(string location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));

            Page<AutoApprovedPrivateLinkService> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = PrivateLinkServicesClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetAutoApprovedPrivateLinkServicesPrivateLinkServices");
                scope.Start();
                try
                {
                    var response = PrivateLinkServicesRestClient.ListAutoApprovedPrivateLinkServicesByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, location, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AutoApprovedPrivateLinkService> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = PrivateLinkServicesClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetAutoApprovedPrivateLinkServicesPrivateLinkServices");
                scope.Start();
                try
                {
                    var response = PrivateLinkServicesRestClient.ListAutoApprovedPrivateLinkServicesByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, location, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
