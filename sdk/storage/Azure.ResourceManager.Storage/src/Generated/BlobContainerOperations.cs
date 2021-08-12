// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.Storage.Models;

namespace Azure.ResourceManager.Storage
{
    /// <summary> A class representing the operations that can be performed over a specific BlobContainer. </summary>
    public partial class BlobContainerOperations : ResourceOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private BlobContainersRestOperations _restClient { get; }

        /// <summary> Initializes a new instance of the <see cref="BlobContainerOperations"/> class for mocking. </summary>
        protected BlobContainerOperations()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BlobContainerOperations"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        protected internal BlobContainerOperations(ResourceOperations options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new BlobContainersRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Storage/storageAccounts/blobServices/default/containers";
        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <summary> Gets properties of a specified container. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<BlobContainer>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobContainerOperations.Get");
            scope.Start();
            try
            {
                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new BlobContainer(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets properties of a specified container. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<BlobContainer> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobContainerOperations.Get");
            scope.Start();
            try
            {
                var response = _restClient.Get(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BlobContainer(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<Location>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<Location> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType, cancellationToken);
        }

        /// <summary> Deletes specified container under its account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> DeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobContainerOperations.Delete");
            scope.Start();
            try
            {
                var operation = await StartDeleteAsync(cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes specified container under its account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobContainerOperations.Delete");
            scope.Start();
            try
            {
                var operation = StartDelete(cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes specified container under its account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<BlobContainerDeleteOperation> StartDeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobContainerOperations.StartDelete");
            scope.Start();
            try
            {
                var response = await _restClient.DeleteAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return new BlobContainerDeleteOperation(response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes specified container under its account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual BlobContainerDeleteOperation StartDelete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobContainerOperations.StartDelete");
            scope.Start();
            try
            {
                var response = _restClient.Delete(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return new BlobContainerDeleteOperation(response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Updates container properties as specified in request body. Properties not mentioned in the request will be unchanged. Update fails if the specified container doesn&apos;t already exist. </summary>
        /// <param name="blobContainer"> Properties to update for the blob container. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="blobContainer"/> is null. </exception>
        public virtual async Task<Response<BlobContainer>> UpdateAsync(BlobContainerData blobContainer, CancellationToken cancellationToken = default)
        {
            if (blobContainer == null)
            {
                throw new ArgumentNullException(nameof(blobContainer));
            }

            using var scope = _clientDiagnostics.CreateScope("BlobContainerOperations.Update");
            scope.Start();
            try
            {
                var response = await _restClient.UpdateAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, blobContainer, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new BlobContainer(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates container properties as specified in request body. Properties not mentioned in the request will be unchanged. Update fails if the specified container doesn&apos;t already exist. </summary>
        /// <param name="blobContainer"> Properties to update for the blob container. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="blobContainer"/> is null. </exception>
        public virtual Response<BlobContainer> Update(BlobContainerData blobContainer, CancellationToken cancellationToken = default)
        {
            if (blobContainer == null)
            {
                throw new ArgumentNullException(nameof(blobContainer));
            }

            using var scope = _clientDiagnostics.CreateScope("BlobContainerOperations.Update");
            scope.Start();
            try
            {
                var response = _restClient.Update(Id.ResourceGroupName, Id.Parent.Name, Id.Name, blobContainer, cancellationToken);
                return Response.FromValue(new BlobContainer(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Sets legal hold tags. Setting the same tag results in an idempotent operation. SetLegalHold follows an append pattern and does not clear out the existing tags that are not specified in the request. </summary>
        /// <param name="legalHold"> The LegalHold property that will be set to a blob container. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="legalHold"/> is null. </exception>
        public virtual async Task<Response<LegalHold>> SetLegalHoldAsync(LegalHold legalHold, CancellationToken cancellationToken = default)
        {
            if (legalHold == null)
            {
                throw new ArgumentNullException(nameof(legalHold));
            }

            using var scope = _clientDiagnostics.CreateScope("BlobContainerOperations.SetLegalHold");
            scope.Start();
            try
            {
                var response = await _restClient.SetLegalHoldAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, legalHold, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Sets legal hold tags. Setting the same tag results in an idempotent operation. SetLegalHold follows an append pattern and does not clear out the existing tags that are not specified in the request. </summary>
        /// <param name="legalHold"> The LegalHold property that will be set to a blob container. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="legalHold"/> is null. </exception>
        public virtual Response<LegalHold> SetLegalHold(LegalHold legalHold, CancellationToken cancellationToken = default)
        {
            if (legalHold == null)
            {
                throw new ArgumentNullException(nameof(legalHold));
            }

            using var scope = _clientDiagnostics.CreateScope("BlobContainerOperations.SetLegalHold");
            scope.Start();
            try
            {
                var response = _restClient.SetLegalHold(Id.ResourceGroupName, Id.Parent.Name, Id.Name, legalHold, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Clears legal hold tags. Clearing the same or non-existent tag results in an idempotent operation. ClearLegalHold clears out only the specified tags in the request. </summary>
        /// <param name="legalHold"> The LegalHold property that will be clear from a blob container. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="legalHold"/> is null. </exception>
        public virtual async Task<Response<LegalHold>> ClearLegalHoldAsync(LegalHold legalHold, CancellationToken cancellationToken = default)
        {
            if (legalHold == null)
            {
                throw new ArgumentNullException(nameof(legalHold));
            }

            using var scope = _clientDiagnostics.CreateScope("BlobContainerOperations.ClearLegalHold");
            scope.Start();
            try
            {
                var response = await _restClient.ClearLegalHoldAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, legalHold, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Clears legal hold tags. Clearing the same or non-existent tag results in an idempotent operation. ClearLegalHold clears out only the specified tags in the request. </summary>
        /// <param name="legalHold"> The LegalHold property that will be clear from a blob container. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="legalHold"/> is null. </exception>
        public virtual Response<LegalHold> ClearLegalHold(LegalHold legalHold, CancellationToken cancellationToken = default)
        {
            if (legalHold == null)
            {
                throw new ArgumentNullException(nameof(legalHold));
            }

            using var scope = _clientDiagnostics.CreateScope("BlobContainerOperations.ClearLegalHold");
            scope.Start();
            try
            {
                var response = _restClient.ClearLegalHold(Id.ResourceGroupName, Id.Parent.Name, Id.Name, legalHold, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates an unlocked immutability policy. ETag in If-Match is honored if given but not required for this operation. </summary>
        /// <param name="ifMatch"> The entity state (ETag) version of the immutability policy to update. A value of &quot;*&quot; can be used to apply the operation only if the immutability policy already exists. If omitted, this operation will always be applied. </param>
        /// <param name="parameters"> The ImmutabilityPolicy Properties that will be created or updated to a blob container. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ImmutabilityPolicy>> CreateOrUpdateImmutabilityPolicyAsync(string ifMatch = null, ImmutabilityPolicy parameters = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobContainerOperations.CreateOrUpdateImmutabilityPolicy");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateImmutabilityPolicyAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, parameters, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates an unlocked immutability policy. ETag in If-Match is honored if given but not required for this operation. </summary>
        /// <param name="ifMatch"> The entity state (ETag) version of the immutability policy to update. A value of &quot;*&quot; can be used to apply the operation only if the immutability policy already exists. If omitted, this operation will always be applied. </param>
        /// <param name="parameters"> The ImmutabilityPolicy Properties that will be created or updated to a blob container. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ImmutabilityPolicy> CreateOrUpdateImmutabilityPolicy(string ifMatch = null, ImmutabilityPolicy parameters = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobContainerOperations.CreateOrUpdateImmutabilityPolicy");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdateImmutabilityPolicy(Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, parameters, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the existing immutability policy along with the corresponding ETag in response headers and body. </summary>
        /// <param name="ifMatch"> The entity state (ETag) version of the immutability policy to update. A value of &quot;*&quot; can be used to apply the operation only if the immutability policy already exists. If omitted, this operation will always be applied. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ImmutabilityPolicy>> GetImmutabilityPolicyAsync(string ifMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobContainerOperations.GetImmutabilityPolicy");
            scope.Start();
            try
            {
                var response = await _restClient.GetImmutabilityPolicyAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the existing immutability policy along with the corresponding ETag in response headers and body. </summary>
        /// <param name="ifMatch"> The entity state (ETag) version of the immutability policy to update. A value of &quot;*&quot; can be used to apply the operation only if the immutability policy already exists. If omitted, this operation will always be applied. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ImmutabilityPolicy> GetImmutabilityPolicy(string ifMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobContainerOperations.GetImmutabilityPolicy");
            scope.Start();
            try
            {
                var response = _restClient.GetImmutabilityPolicy(Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Aborts an unlocked immutability policy. The response of delete has immutabilityPeriodSinceCreationInDays set to 0. ETag in If-Match is required for this operation. Deleting a locked immutability policy is not allowed, the only way is to delete the container after deleting all expired blobs inside the policy locked container. </summary>
        /// <param name="ifMatch"> The entity state (ETag) version of the immutability policy to update. A value of &quot;*&quot; can be used to apply the operation only if the immutability policy already exists. If omitted, this operation will always be applied. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ifMatch"/> is null. </exception>
        public virtual async Task<Response<ImmutabilityPolicy>> DeleteImmutabilityPolicyAsync(string ifMatch, CancellationToken cancellationToken = default)
        {
            if (ifMatch == null)
            {
                throw new ArgumentNullException(nameof(ifMatch));
            }

            using var scope = _clientDiagnostics.CreateScope("BlobContainerOperations.DeleteImmutabilityPolicy");
            scope.Start();
            try
            {
                var response = await _restClient.DeleteImmutabilityPolicyAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Aborts an unlocked immutability policy. The response of delete has immutabilityPeriodSinceCreationInDays set to 0. ETag in If-Match is required for this operation. Deleting a locked immutability policy is not allowed, the only way is to delete the container after deleting all expired blobs inside the policy locked container. </summary>
        /// <param name="ifMatch"> The entity state (ETag) version of the immutability policy to update. A value of &quot;*&quot; can be used to apply the operation only if the immutability policy already exists. If omitted, this operation will always be applied. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ifMatch"/> is null. </exception>
        public virtual Response<ImmutabilityPolicy> DeleteImmutabilityPolicy(string ifMatch, CancellationToken cancellationToken = default)
        {
            if (ifMatch == null)
            {
                throw new ArgumentNullException(nameof(ifMatch));
            }

            using var scope = _clientDiagnostics.CreateScope("BlobContainerOperations.DeleteImmutabilityPolicy");
            scope.Start();
            try
            {
                var response = _restClient.DeleteImmutabilityPolicy(Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Sets the ImmutabilityPolicy to Locked state. The only action allowed on a Locked policy is ExtendImmutabilityPolicy action. ETag in If-Match is required for this operation. </summary>
        /// <param name="ifMatch"> The entity state (ETag) version of the immutability policy to update. A value of &quot;*&quot; can be used to apply the operation only if the immutability policy already exists. If omitted, this operation will always be applied. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ifMatch"/> is null. </exception>
        public virtual async Task<Response<ImmutabilityPolicy>> LockImmutabilityPolicyAsync(string ifMatch, CancellationToken cancellationToken = default)
        {
            if (ifMatch == null)
            {
                throw new ArgumentNullException(nameof(ifMatch));
            }

            using var scope = _clientDiagnostics.CreateScope("BlobContainerOperations.LockImmutabilityPolicy");
            scope.Start();
            try
            {
                var response = await _restClient.LockImmutabilityPolicyAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Sets the ImmutabilityPolicy to Locked state. The only action allowed on a Locked policy is ExtendImmutabilityPolicy action. ETag in If-Match is required for this operation. </summary>
        /// <param name="ifMatch"> The entity state (ETag) version of the immutability policy to update. A value of &quot;*&quot; can be used to apply the operation only if the immutability policy already exists. If omitted, this operation will always be applied. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ifMatch"/> is null. </exception>
        public virtual Response<ImmutabilityPolicy> LockImmutabilityPolicy(string ifMatch, CancellationToken cancellationToken = default)
        {
            if (ifMatch == null)
            {
                throw new ArgumentNullException(nameof(ifMatch));
            }

            using var scope = _clientDiagnostics.CreateScope("BlobContainerOperations.LockImmutabilityPolicy");
            scope.Start();
            try
            {
                var response = _restClient.LockImmutabilityPolicy(Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Extends the immutabilityPeriodSinceCreationInDays of a locked immutabilityPolicy. The only action allowed on a Locked policy will be this action. ETag in If-Match is required for this operation. </summary>
        /// <param name="ifMatch"> The entity state (ETag) version of the immutability policy to update. A value of &quot;*&quot; can be used to apply the operation only if the immutability policy already exists. If omitted, this operation will always be applied. </param>
        /// <param name="parameters"> The ImmutabilityPolicy Properties that will be extended for a blob container. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ifMatch"/> is null. </exception>
        public virtual async Task<Response<ImmutabilityPolicy>> ExtendImmutabilityPolicyAsync(string ifMatch, ImmutabilityPolicy parameters = null, CancellationToken cancellationToken = default)
        {
            if (ifMatch == null)
            {
                throw new ArgumentNullException(nameof(ifMatch));
            }

            using var scope = _clientDiagnostics.CreateScope("BlobContainerOperations.ExtendImmutabilityPolicy");
            scope.Start();
            try
            {
                var response = await _restClient.ExtendImmutabilityPolicyAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, parameters, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Extends the immutabilityPeriodSinceCreationInDays of a locked immutabilityPolicy. The only action allowed on a Locked policy will be this action. ETag in If-Match is required for this operation. </summary>
        /// <param name="ifMatch"> The entity state (ETag) version of the immutability policy to update. A value of &quot;*&quot; can be used to apply the operation only if the immutability policy already exists. If omitted, this operation will always be applied. </param>
        /// <param name="parameters"> The ImmutabilityPolicy Properties that will be extended for a blob container. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ifMatch"/> is null. </exception>
        public virtual Response<ImmutabilityPolicy> ExtendImmutabilityPolicy(string ifMatch, ImmutabilityPolicy parameters = null, CancellationToken cancellationToken = default)
        {
            if (ifMatch == null)
            {
                throw new ArgumentNullException(nameof(ifMatch));
            }

            using var scope = _clientDiagnostics.CreateScope("BlobContainerOperations.ExtendImmutabilityPolicy");
            scope.Start();
            try
            {
                var response = _restClient.ExtendImmutabilityPolicy(Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, parameters, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The Lease Container operation establishes and manages a lock on a container for delete operations. The lock duration can be 15 to 60 seconds, or can be infinite. </summary>
        /// <param name="parameters"> Lease Container request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<LeaseContainerResponse>> LeaseAsync(LeaseContainerRequest parameters = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobContainerOperations.Lease");
            scope.Start();
            try
            {
                var response = await _restClient.LeaseAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, parameters, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The Lease Container operation establishes and manages a lock on a container for delete operations. The lock duration can be 15 to 60 seconds, or can be infinite. </summary>
        /// <param name="parameters"> Lease Container request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<LeaseContainerResponse> Lease(LeaseContainerRequest parameters = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobContainerOperations.Lease");
            scope.Start();
            try
            {
                var response = _restClient.Lease(Id.ResourceGroupName, Id.Parent.Name, Id.Name, parameters, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation migrates a blob container from container level WORM to object level immutability enabled container. Prerequisites require a container level immutability policy either in locked or unlocked state, Account level versioning must be enabled and there should be no Legal hold on the container. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> ObjectLevelWormAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobContainerOperations.ObjectLevelWorm");
            scope.Start();
            try
            {
                var operation = await StartObjectLevelWormAsync(cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation migrates a blob container from container level WORM to object level immutability enabled container. Prerequisites require a container level immutability policy either in locked or unlocked state, Account level versioning must be enabled and there should be no Legal hold on the container. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response ObjectLevelWorm(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobContainerOperations.ObjectLevelWorm");
            scope.Start();
            try
            {
                var operation = StartObjectLevelWorm(cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation migrates a blob container from container level WORM to object level immutability enabled container. Prerequisites require a container level immutability policy either in locked or unlocked state, Account level versioning must be enabled and there should be no Legal hold on the container. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<BlobContainerObjectLevelWormOperation> StartObjectLevelWormAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobContainerOperations.StartObjectLevelWorm");
            scope.Start();
            try
            {
                var response = await _restClient.ObjectLevelWormAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return new BlobContainerObjectLevelWormOperation(_clientDiagnostics, Pipeline, _restClient.CreateObjectLevelWormRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation migrates a blob container from container level WORM to object level immutability enabled container. Prerequisites require a container level immutability policy either in locked or unlocked state, Account level versioning must be enabled and there should be no Legal hold on the container. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual BlobContainerObjectLevelWormOperation StartObjectLevelWorm(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobContainerOperations.StartObjectLevelWorm");
            scope.Start();
            try
            {
                var response = _restClient.ObjectLevelWorm(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return new BlobContainerObjectLevelWormOperation(_clientDiagnostics, Pipeline, _restClient.CreateObjectLevelWormRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
