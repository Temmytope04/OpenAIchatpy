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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Communication
{
    /// <summary>
    /// A class representing a collection of <see cref="EmailServiceResource"/> and their operations.
    /// Each <see cref="EmailServiceResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get an <see cref="EmailServiceResourceCollection"/> instance call the GetEmailServiceResources method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class EmailServiceResourceCollection : ArmCollection, IEnumerable<EmailServiceResource>, IAsyncEnumerable<EmailServiceResource>
    {
        private readonly ClientDiagnostics _emailServiceResourceEmailServicesClientDiagnostics;
        private readonly EmailServicesRestOperations _emailServiceResourceEmailServicesRestClient;

        /// <summary> Initializes a new instance of the <see cref="EmailServiceResourceCollection"/> class for mocking. </summary>
        protected EmailServiceResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="EmailServiceResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal EmailServiceResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _emailServiceResourceEmailServicesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Communication", EmailServiceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(EmailServiceResource.ResourceType, out string emailServiceResourceEmailServicesApiVersion);
            _emailServiceResourceEmailServicesRestClient = new EmailServicesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, emailServiceResourceEmailServicesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a new EmailService or update an existing EmailService.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/emailServices/{emailServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EmailServices_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EmailServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="emailServiceName"> The name of the EmailService resource. </param>
        /// <param name="data"> Parameters for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="emailServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="emailServiceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<EmailServiceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string emailServiceName, EmailServiceResourceData data, CancellationToken cancellationToken = default)
        {
            if (emailServiceName == null)
            {
                throw new ArgumentNullException(nameof(emailServiceName));
            }
            if (emailServiceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(emailServiceName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _emailServiceResourceEmailServicesClientDiagnostics.CreateScope("EmailServiceResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _emailServiceResourceEmailServicesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, emailServiceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new CommunicationArmOperation<EmailServiceResource>(new EmailServiceResourceOperationSource(Client), _emailServiceResourceEmailServicesClientDiagnostics, Pipeline, _emailServiceResourceEmailServicesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, emailServiceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a new EmailService or update an existing EmailService.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/emailServices/{emailServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EmailServices_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EmailServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="emailServiceName"> The name of the EmailService resource. </param>
        /// <param name="data"> Parameters for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="emailServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="emailServiceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<EmailServiceResource> CreateOrUpdate(WaitUntil waitUntil, string emailServiceName, EmailServiceResourceData data, CancellationToken cancellationToken = default)
        {
            if (emailServiceName == null)
            {
                throw new ArgumentNullException(nameof(emailServiceName));
            }
            if (emailServiceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(emailServiceName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _emailServiceResourceEmailServicesClientDiagnostics.CreateScope("EmailServiceResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _emailServiceResourceEmailServicesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, emailServiceName, data, cancellationToken);
                var operation = new CommunicationArmOperation<EmailServiceResource>(new EmailServiceResourceOperationSource(Client), _emailServiceResourceEmailServicesClientDiagnostics, Pipeline, _emailServiceResourceEmailServicesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, emailServiceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get the EmailService and its properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/emailServices/{emailServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EmailServices_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EmailServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="emailServiceName"> The name of the EmailService resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="emailServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="emailServiceName"/> is null. </exception>
        public virtual async Task<Response<EmailServiceResource>> GetAsync(string emailServiceName, CancellationToken cancellationToken = default)
        {
            if (emailServiceName == null)
            {
                throw new ArgumentNullException(nameof(emailServiceName));
            }
            if (emailServiceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(emailServiceName));
            }

            using var scope = _emailServiceResourceEmailServicesClientDiagnostics.CreateScope("EmailServiceResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _emailServiceResourceEmailServicesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, emailServiceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EmailServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the EmailService and its properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/emailServices/{emailServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EmailServices_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EmailServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="emailServiceName"> The name of the EmailService resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="emailServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="emailServiceName"/> is null. </exception>
        public virtual Response<EmailServiceResource> Get(string emailServiceName, CancellationToken cancellationToken = default)
        {
            if (emailServiceName == null)
            {
                throw new ArgumentNullException(nameof(emailServiceName));
            }
            if (emailServiceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(emailServiceName));
            }

            using var scope = _emailServiceResourceEmailServicesClientDiagnostics.CreateScope("EmailServiceResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _emailServiceResourceEmailServicesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, emailServiceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EmailServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Handles requests to list all resources in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/emailServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EmailServices_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EmailServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EmailServiceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EmailServiceResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _emailServiceResourceEmailServicesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _emailServiceResourceEmailServicesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new EmailServiceResource(Client, EmailServiceResourceData.DeserializeEmailServiceResourceData(e)), _emailServiceResourceEmailServicesClientDiagnostics, Pipeline, "EmailServiceResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Handles requests to list all resources in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/emailServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EmailServices_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EmailServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EmailServiceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EmailServiceResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _emailServiceResourceEmailServicesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _emailServiceResourceEmailServicesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new EmailServiceResource(Client, EmailServiceResourceData.DeserializeEmailServiceResourceData(e)), _emailServiceResourceEmailServicesClientDiagnostics, Pipeline, "EmailServiceResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/emailServices/{emailServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EmailServices_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EmailServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="emailServiceName"> The name of the EmailService resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="emailServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="emailServiceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string emailServiceName, CancellationToken cancellationToken = default)
        {
            if (emailServiceName == null)
            {
                throw new ArgumentNullException(nameof(emailServiceName));
            }
            if (emailServiceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(emailServiceName));
            }

            using var scope = _emailServiceResourceEmailServicesClientDiagnostics.CreateScope("EmailServiceResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _emailServiceResourceEmailServicesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, emailServiceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/emailServices/{emailServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EmailServices_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EmailServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="emailServiceName"> The name of the EmailService resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="emailServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="emailServiceName"/> is null. </exception>
        public virtual Response<bool> Exists(string emailServiceName, CancellationToken cancellationToken = default)
        {
            if (emailServiceName == null)
            {
                throw new ArgumentNullException(nameof(emailServiceName));
            }
            if (emailServiceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(emailServiceName));
            }

            using var scope = _emailServiceResourceEmailServicesClientDiagnostics.CreateScope("EmailServiceResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _emailServiceResourceEmailServicesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, emailServiceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/emailServices/{emailServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EmailServices_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EmailServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="emailServiceName"> The name of the EmailService resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="emailServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="emailServiceName"/> is null. </exception>
        public virtual async Task<NullableResponse<EmailServiceResource>> GetIfExistsAsync(string emailServiceName, CancellationToken cancellationToken = default)
        {
            if (emailServiceName == null)
            {
                throw new ArgumentNullException(nameof(emailServiceName));
            }
            if (emailServiceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(emailServiceName));
            }

            using var scope = _emailServiceResourceEmailServicesClientDiagnostics.CreateScope("EmailServiceResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _emailServiceResourceEmailServicesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, emailServiceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<EmailServiceResource>(response.GetRawResponse());
                return Response.FromValue(new EmailServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Communication/emailServices/{emailServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EmailServices_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EmailServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="emailServiceName"> The name of the EmailService resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="emailServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="emailServiceName"/> is null. </exception>
        public virtual NullableResponse<EmailServiceResource> GetIfExists(string emailServiceName, CancellationToken cancellationToken = default)
        {
            if (emailServiceName == null)
            {
                throw new ArgumentNullException(nameof(emailServiceName));
            }
            if (emailServiceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(emailServiceName));
            }

            using var scope = _emailServiceResourceEmailServicesClientDiagnostics.CreateScope("EmailServiceResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _emailServiceResourceEmailServicesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, emailServiceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<EmailServiceResource>(response.GetRawResponse());
                return Response.FromValue(new EmailServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<EmailServiceResource> IEnumerable<EmailServiceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<EmailServiceResource> IAsyncEnumerable<EmailServiceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
