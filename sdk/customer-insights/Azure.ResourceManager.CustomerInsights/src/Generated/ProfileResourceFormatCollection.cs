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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.CustomerInsights
{
    /// <summary>
    /// A class representing a collection of <see cref="ProfileResourceFormatResource" /> and their operations.
    /// Each <see cref="ProfileResourceFormatResource" /> in the collection will belong to the same instance of <see cref="HubResource" />.
    /// To get a <see cref="ProfileResourceFormatCollection" /> instance call the GetProfileResourceFormats method from an instance of <see cref="HubResource" />.
    /// </summary>
    public partial class ProfileResourceFormatCollection : ArmCollection, IEnumerable<ProfileResourceFormatResource>, IAsyncEnumerable<ProfileResourceFormatResource>
    {
        private readonly ClientDiagnostics _profileResourceFormatProfilesClientDiagnostics;
        private readonly ProfilesRestOperations _profileResourceFormatProfilesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ProfileResourceFormatCollection"/> class for mocking. </summary>
        protected ProfileResourceFormatCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ProfileResourceFormatCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ProfileResourceFormatCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _profileResourceFormatProfilesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CustomerInsights", ProfileResourceFormatResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ProfileResourceFormatResource.ResourceType, out string profileResourceFormatProfilesApiVersion);
            _profileResourceFormatProfilesRestClient = new ProfilesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, profileResourceFormatProfilesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != HubResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, HubResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a profile within a Hub, or updates an existing profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/profiles/{profileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="profileName"> The name of the profile. </param>
        /// <param name="data"> Parameters supplied to the create/delete Profile type operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="profileName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ProfileResourceFormatResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string profileName, ProfileResourceFormatData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _profileResourceFormatProfilesClientDiagnostics.CreateScope("ProfileResourceFormatCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _profileResourceFormatProfilesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, profileName, data, cancellationToken).ConfigureAwait(false);
                var operation = new CustomerInsightsArmOperation<ProfileResourceFormatResource>(new ProfileResourceFormatOperationSource(Client), _profileResourceFormatProfilesClientDiagnostics, Pipeline, _profileResourceFormatProfilesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, profileName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates a profile within a Hub, or updates an existing profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/profiles/{profileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="profileName"> The name of the profile. </param>
        /// <param name="data"> Parameters supplied to the create/delete Profile type operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="profileName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ProfileResourceFormatResource> CreateOrUpdate(WaitUntil waitUntil, string profileName, ProfileResourceFormatData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _profileResourceFormatProfilesClientDiagnostics.CreateScope("ProfileResourceFormatCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _profileResourceFormatProfilesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, profileName, data, cancellationToken);
                var operation = new CustomerInsightsArmOperation<ProfileResourceFormatResource>(new ProfileResourceFormatOperationSource(Client), _profileResourceFormatProfilesClientDiagnostics, Pipeline, _profileResourceFormatProfilesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, profileName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets information about the specified profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/profiles/{profileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="profileName"> The name of the profile. </param>
        /// <param name="localeCode"> Locale of profile to retrieve, default is en-us. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="profileName"/> is null. </exception>
        public virtual async Task<Response<ProfileResourceFormatResource>> GetAsync(string profileName, string localeCode = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));

            using var scope = _profileResourceFormatProfilesClientDiagnostics.CreateScope("ProfileResourceFormatCollection.Get");
            scope.Start();
            try
            {
                var response = await _profileResourceFormatProfilesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, profileName, localeCode, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ProfileResourceFormatResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/profiles/{profileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="profileName"> The name of the profile. </param>
        /// <param name="localeCode"> Locale of profile to retrieve, default is en-us. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="profileName"/> is null. </exception>
        public virtual Response<ProfileResourceFormatResource> Get(string profileName, string localeCode = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));

            using var scope = _profileResourceFormatProfilesClientDiagnostics.CreateScope("ProfileResourceFormatCollection.Get");
            scope.Start();
            try
            {
                var response = _profileResourceFormatProfilesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, profileName, localeCode, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ProfileResourceFormatResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all profile in the hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/profiles</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_ListByHub</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="localeCode"> Locale of profile to retrieve, default is en-us. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ProfileResourceFormatResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ProfileResourceFormatResource> GetAllAsync(string localeCode = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _profileResourceFormatProfilesRestClient.CreateListByHubRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, localeCode);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _profileResourceFormatProfilesRestClient.CreateListByHubNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, localeCode);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ProfileResourceFormatResource(Client, ProfileResourceFormatData.DeserializeProfileResourceFormatData(e)), _profileResourceFormatProfilesClientDiagnostics, Pipeline, "ProfileResourceFormatCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all profile in the hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/profiles</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_ListByHub</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="localeCode"> Locale of profile to retrieve, default is en-us. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ProfileResourceFormatResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ProfileResourceFormatResource> GetAll(string localeCode = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _profileResourceFormatProfilesRestClient.CreateListByHubRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, localeCode);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _profileResourceFormatProfilesRestClient.CreateListByHubNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, localeCode);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ProfileResourceFormatResource(Client, ProfileResourceFormatData.DeserializeProfileResourceFormatData(e)), _profileResourceFormatProfilesClientDiagnostics, Pipeline, "ProfileResourceFormatCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/profiles/{profileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="profileName"> The name of the profile. </param>
        /// <param name="localeCode"> Locale of profile to retrieve, default is en-us. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="profileName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string profileName, string localeCode = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));

            using var scope = _profileResourceFormatProfilesClientDiagnostics.CreateScope("ProfileResourceFormatCollection.Exists");
            scope.Start();
            try
            {
                var response = await _profileResourceFormatProfilesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, profileName, localeCode, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/profiles/{profileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="profileName"> The name of the profile. </param>
        /// <param name="localeCode"> Locale of profile to retrieve, default is en-us. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="profileName"/> is null. </exception>
        public virtual Response<bool> Exists(string profileName, string localeCode = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));

            using var scope = _profileResourceFormatProfilesClientDiagnostics.CreateScope("ProfileResourceFormatCollection.Exists");
            scope.Start();
            try
            {
                var response = _profileResourceFormatProfilesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, profileName, localeCode, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ProfileResourceFormatResource> IEnumerable<ProfileResourceFormatResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ProfileResourceFormatResource> IAsyncEnumerable<ProfileResourceFormatResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
