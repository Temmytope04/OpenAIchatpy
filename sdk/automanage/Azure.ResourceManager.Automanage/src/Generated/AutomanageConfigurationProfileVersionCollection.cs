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

namespace Azure.ResourceManager.Automanage
{
    /// <summary>
    /// A class representing a collection of <see cref="AutomanageConfigurationProfileVersionResource" /> and their operations.
    /// Each <see cref="AutomanageConfigurationProfileVersionResource" /> in the collection will belong to the same instance of <see cref="AutomanageConfigurationProfileResource" />.
    /// To get an <see cref="AutomanageConfigurationProfileVersionCollection" /> instance call the GetAutomanageConfigurationProfileVersions method from an instance of <see cref="AutomanageConfigurationProfileResource" />.
    /// </summary>
    public partial class AutomanageConfigurationProfileVersionCollection : ArmCollection, IEnumerable<AutomanageConfigurationProfileVersionResource>, IAsyncEnumerable<AutomanageConfigurationProfileVersionResource>
    {
        private readonly ClientDiagnostics _automanageConfigurationProfileVersionConfigurationProfilesVersionsClientDiagnostics;
        private readonly ConfigurationProfilesVersionsRestOperations _automanageConfigurationProfileVersionConfigurationProfilesVersionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="AutomanageConfigurationProfileVersionCollection"/> class for mocking. </summary>
        protected AutomanageConfigurationProfileVersionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AutomanageConfigurationProfileVersionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AutomanageConfigurationProfileVersionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _automanageConfigurationProfileVersionConfigurationProfilesVersionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Automanage", AutomanageConfigurationProfileVersionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AutomanageConfigurationProfileVersionResource.ResourceType, out string automanageConfigurationProfileVersionConfigurationProfilesVersionsApiVersion);
            _automanageConfigurationProfileVersionConfigurationProfilesVersionsRestClient = new ConfigurationProfilesVersionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, automanageConfigurationProfileVersionConfigurationProfilesVersionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AutomanageConfigurationProfileResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AutomanageConfigurationProfileResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a configuration profile version
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automanage/configurationProfiles/{configurationProfileName}/versions/{versionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfilesVersions_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="versionName"> The configuration profile version name. </param>
        /// <param name="data"> Parameters supplied to create or update configuration profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AutomanageConfigurationProfileVersionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string versionName, AutomanageConfigurationProfileData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionName, nameof(versionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _automanageConfigurationProfileVersionConfigurationProfilesVersionsClientDiagnostics.CreateScope("AutomanageConfigurationProfileVersionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _automanageConfigurationProfileVersionConfigurationProfilesVersionsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, versionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AutomanageArmOperation<AutomanageConfigurationProfileVersionResource>(Response.FromValue(new AutomanageConfigurationProfileVersionResource(Client, response), response.GetRawResponse()));
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
        /// Creates a configuration profile version
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automanage/configurationProfiles/{configurationProfileName}/versions/{versionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfilesVersions_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="versionName"> The configuration profile version name. </param>
        /// <param name="data"> Parameters supplied to create or update configuration profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AutomanageConfigurationProfileVersionResource> CreateOrUpdate(WaitUntil waitUntil, string versionName, AutomanageConfigurationProfileData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionName, nameof(versionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _automanageConfigurationProfileVersionConfigurationProfilesVersionsClientDiagnostics.CreateScope("AutomanageConfigurationProfileVersionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _automanageConfigurationProfileVersionConfigurationProfilesVersionsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, versionName, data, cancellationToken);
                var operation = new AutomanageArmOperation<AutomanageConfigurationProfileVersionResource>(Response.FromValue(new AutomanageConfigurationProfileVersionResource(Client, response), response.GetRawResponse()));
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
        /// Get information about a configuration profile version
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automanage/configurationProfiles/{configurationProfileName}/versions/{versionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfilesVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionName"> The configuration profile version name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionName"/> is null. </exception>
        public virtual async Task<Response<AutomanageConfigurationProfileVersionResource>> GetAsync(string versionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionName, nameof(versionName));

            using var scope = _automanageConfigurationProfileVersionConfigurationProfilesVersionsClientDiagnostics.CreateScope("AutomanageConfigurationProfileVersionCollection.Get");
            scope.Start();
            try
            {
                var response = await _automanageConfigurationProfileVersionConfigurationProfilesVersionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, versionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomanageConfigurationProfileVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get information about a configuration profile version
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automanage/configurationProfiles/{configurationProfileName}/versions/{versionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfilesVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionName"> The configuration profile version name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionName"/> is null. </exception>
        public virtual Response<AutomanageConfigurationProfileVersionResource> Get(string versionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionName, nameof(versionName));

            using var scope = _automanageConfigurationProfileVersionConfigurationProfilesVersionsClientDiagnostics.CreateScope("AutomanageConfigurationProfileVersionCollection.Get");
            scope.Start();
            try
            {
                var response = _automanageConfigurationProfileVersionConfigurationProfilesVersionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, versionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomanageConfigurationProfileVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve a list of configuration profile version for a configuration profile
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automanage/configurationProfiles/{configurationProfileName}/versions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfilesVersions_ListChildResources</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AutomanageConfigurationProfileVersionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AutomanageConfigurationProfileVersionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _automanageConfigurationProfileVersionConfigurationProfilesVersionsRestClient.CreateListChildResourcesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, (e, o) => new AutomanageConfigurationProfileVersionResource(Client, AutomanageConfigurationProfileData.DeserializeAutomanageConfigurationProfileData(e)), _automanageConfigurationProfileVersionConfigurationProfilesVersionsClientDiagnostics, Pipeline, "AutomanageConfigurationProfileVersionCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Retrieve a list of configuration profile version for a configuration profile
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automanage/configurationProfiles/{configurationProfileName}/versions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfilesVersions_ListChildResources</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AutomanageConfigurationProfileVersionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AutomanageConfigurationProfileVersionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _automanageConfigurationProfileVersionConfigurationProfilesVersionsRestClient.CreateListChildResourcesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, (e, o) => new AutomanageConfigurationProfileVersionResource(Client, AutomanageConfigurationProfileData.DeserializeAutomanageConfigurationProfileData(e)), _automanageConfigurationProfileVersionConfigurationProfilesVersionsClientDiagnostics, Pipeline, "AutomanageConfigurationProfileVersionCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automanage/configurationProfiles/{configurationProfileName}/versions/{versionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfilesVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionName"> The configuration profile version name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string versionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionName, nameof(versionName));

            using var scope = _automanageConfigurationProfileVersionConfigurationProfilesVersionsClientDiagnostics.CreateScope("AutomanageConfigurationProfileVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _automanageConfigurationProfileVersionConfigurationProfilesVersionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, versionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automanage/configurationProfiles/{configurationProfileName}/versions/{versionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfilesVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionName"> The configuration profile version name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionName"/> is null. </exception>
        public virtual Response<bool> Exists(string versionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionName, nameof(versionName));

            using var scope = _automanageConfigurationProfileVersionConfigurationProfilesVersionsClientDiagnostics.CreateScope("AutomanageConfigurationProfileVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = _automanageConfigurationProfileVersionConfigurationProfilesVersionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, versionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AutomanageConfigurationProfileVersionResource> IEnumerable<AutomanageConfigurationProfileVersionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AutomanageConfigurationProfileVersionResource> IAsyncEnumerable<AutomanageConfigurationProfileVersionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
