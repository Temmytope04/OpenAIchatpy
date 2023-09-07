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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="AutoProvisioningSettingResource" /> and their operations.
    /// Each <see cref="AutoProvisioningSettingResource" /> in the collection will belong to the same instance of <see cref="SubscriptionResource" />.
    /// To get an <see cref="AutoProvisioningSettingCollection" /> instance call the GetAutoProvisioningSettings method from an instance of <see cref="SubscriptionResource" />.
    /// </summary>
    public partial class AutoProvisioningSettingCollection : ArmCollection, IEnumerable<AutoProvisioningSettingResource>, IAsyncEnumerable<AutoProvisioningSettingResource>
    {
        private readonly ClientDiagnostics _autoProvisioningSettingClientDiagnostics;
        private readonly AutoProvisioningSettingsRestOperations _autoProvisioningSettingRestClient;

        /// <summary> Initializes a new instance of the <see cref="AutoProvisioningSettingCollection"/> class for mocking. </summary>
        protected AutoProvisioningSettingCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AutoProvisioningSettingCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AutoProvisioningSettingCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _autoProvisioningSettingClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", AutoProvisioningSettingResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AutoProvisioningSettingResource.ResourceType, out string autoProvisioningSettingApiVersion);
            _autoProvisioningSettingRestClient = new AutoProvisioningSettingsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, autoProvisioningSettingApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Details of a specific setting
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/autoProvisioningSettings/{settingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutoProvisioningSettings_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="settingName"> Auto provisioning setting key. </param>
        /// <param name="data"> Auto provisioning setting key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="settingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="settingName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AutoProvisioningSettingResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string settingName, AutoProvisioningSettingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(settingName, nameof(settingName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _autoProvisioningSettingClientDiagnostics.CreateScope("AutoProvisioningSettingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _autoProvisioningSettingRestClient.CreateAsync(Id.SubscriptionId, settingName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityCenterArmOperation<AutoProvisioningSettingResource>(Response.FromValue(new AutoProvisioningSettingResource(Client, response), response.GetRawResponse()));
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
        /// Details of a specific setting
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/autoProvisioningSettings/{settingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutoProvisioningSettings_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="settingName"> Auto provisioning setting key. </param>
        /// <param name="data"> Auto provisioning setting key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="settingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="settingName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AutoProvisioningSettingResource> CreateOrUpdate(WaitUntil waitUntil, string settingName, AutoProvisioningSettingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(settingName, nameof(settingName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _autoProvisioningSettingClientDiagnostics.CreateScope("AutoProvisioningSettingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _autoProvisioningSettingRestClient.Create(Id.SubscriptionId, settingName, data, cancellationToken);
                var operation = new SecurityCenterArmOperation<AutoProvisioningSettingResource>(Response.FromValue(new AutoProvisioningSettingResource(Client, response), response.GetRawResponse()));
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
        /// Details of a specific setting
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/autoProvisioningSettings/{settingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutoProvisioningSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="settingName"> Auto provisioning setting key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="settingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="settingName"/> is null. </exception>
        public virtual async Task<Response<AutoProvisioningSettingResource>> GetAsync(string settingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(settingName, nameof(settingName));

            using var scope = _autoProvisioningSettingClientDiagnostics.CreateScope("AutoProvisioningSettingCollection.Get");
            scope.Start();
            try
            {
                var response = await _autoProvisioningSettingRestClient.GetAsync(Id.SubscriptionId, settingName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutoProvisioningSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Details of a specific setting
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/autoProvisioningSettings/{settingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutoProvisioningSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="settingName"> Auto provisioning setting key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="settingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="settingName"/> is null. </exception>
        public virtual Response<AutoProvisioningSettingResource> Get(string settingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(settingName, nameof(settingName));

            using var scope = _autoProvisioningSettingClientDiagnostics.CreateScope("AutoProvisioningSettingCollection.Get");
            scope.Start();
            try
            {
                var response = _autoProvisioningSettingRestClient.Get(Id.SubscriptionId, settingName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutoProvisioningSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Exposes the auto provisioning settings of the subscriptions
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/autoProvisioningSettings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutoProvisioningSettings_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AutoProvisioningSettingResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AutoProvisioningSettingResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _autoProvisioningSettingRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _autoProvisioningSettingRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AutoProvisioningSettingResource(Client, AutoProvisioningSettingData.DeserializeAutoProvisioningSettingData(e)), _autoProvisioningSettingClientDiagnostics, Pipeline, "AutoProvisioningSettingCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Exposes the auto provisioning settings of the subscriptions
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/autoProvisioningSettings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutoProvisioningSettings_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AutoProvisioningSettingResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AutoProvisioningSettingResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _autoProvisioningSettingRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _autoProvisioningSettingRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AutoProvisioningSettingResource(Client, AutoProvisioningSettingData.DeserializeAutoProvisioningSettingData(e)), _autoProvisioningSettingClientDiagnostics, Pipeline, "AutoProvisioningSettingCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/autoProvisioningSettings/{settingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutoProvisioningSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="settingName"> Auto provisioning setting key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="settingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="settingName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string settingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(settingName, nameof(settingName));

            using var scope = _autoProvisioningSettingClientDiagnostics.CreateScope("AutoProvisioningSettingCollection.Exists");
            scope.Start();
            try
            {
                var response = await _autoProvisioningSettingRestClient.GetAsync(Id.SubscriptionId, settingName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/autoProvisioningSettings/{settingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutoProvisioningSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="settingName"> Auto provisioning setting key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="settingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="settingName"/> is null. </exception>
        public virtual Response<bool> Exists(string settingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(settingName, nameof(settingName));

            using var scope = _autoProvisioningSettingClientDiagnostics.CreateScope("AutoProvisioningSettingCollection.Exists");
            scope.Start();
            try
            {
                var response = _autoProvisioningSettingRestClient.Get(Id.SubscriptionId, settingName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AutoProvisioningSettingResource> IEnumerable<AutoProvisioningSettingResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AutoProvisioningSettingResource> IAsyncEnumerable<AutoProvisioningSettingResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
