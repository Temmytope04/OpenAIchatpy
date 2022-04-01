// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A Class representing a BasicPublishingCredentialsPolicyFtp along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="BasicPublishingCredentialsPolicyFtpResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetBasicPublishingCredentialsPolicyFtpResource method.
    /// Otherwise you can get one from its parent resource <see cref="WebSiteResource" /> using the GetBasicPublishingCredentialsPolicyFtp method.
    /// </summary>
    public partial class BasicPublishingCredentialsPolicyFtpResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="BasicPublishingCredentialsPolicyFtpResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/basicPublishingCredentialsPolicies/ftp";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _basicPublishingCredentialsPolicyFtpWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _basicPublishingCredentialsPolicyFtpWebAppsRestClient;
        private readonly CsmPublishingCredentialsPoliciesEntityData _data;

        /// <summary> Initializes a new instance of the <see cref="BasicPublishingCredentialsPolicyFtpResource"/> class for mocking. </summary>
        protected BasicPublishingCredentialsPolicyFtpResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "BasicPublishingCredentialsPolicyFtpResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal BasicPublishingCredentialsPolicyFtpResource(ArmClient client, CsmPublishingCredentialsPoliciesEntityData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="BasicPublishingCredentialsPolicyFtpResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal BasicPublishingCredentialsPolicyFtpResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _basicPublishingCredentialsPolicyFtpWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string basicPublishingCredentialsPolicyFtpWebAppsApiVersion);
            _basicPublishingCredentialsPolicyFtpWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, basicPublishingCredentialsPolicyFtpWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/basicPublishingCredentialsPolicies";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual CsmPublishingCredentialsPoliciesEntityData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Returns whether FTP is allowed on the site or not.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/basicPublishingCredentialsPolicies/ftp
        /// Operation Id: WebApps_GetFtpAllowed
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<BasicPublishingCredentialsPolicyFtpResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _basicPublishingCredentialsPolicyFtpWebAppsClientDiagnostics.CreateScope("BasicPublishingCredentialsPolicyFtpResource.Get");
            scope.Start();
            try
            {
                var response = await _basicPublishingCredentialsPolicyFtpWebAppsRestClient.GetFtpAllowedAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BasicPublishingCredentialsPolicyFtpResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Returns whether FTP is allowed on the site or not.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/basicPublishingCredentialsPolicies/ftp
        /// Operation Id: WebApps_GetFtpAllowed
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<BasicPublishingCredentialsPolicyFtpResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _basicPublishingCredentialsPolicyFtpWebAppsClientDiagnostics.CreateScope("BasicPublishingCredentialsPolicyFtpResource.Get");
            scope.Start();
            try
            {
                var response = _basicPublishingCredentialsPolicyFtpWebAppsRestClient.GetFtpAllowed(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BasicPublishingCredentialsPolicyFtpResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Updates whether FTP is allowed on the site or not.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/basicPublishingCredentialsPolicies/ftp
        /// Operation Id: WebApps_UpdateFtpAllowed
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The CsmPublishingCredentialsPoliciesEntity to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<BasicPublishingCredentialsPolicyFtpResource>> CreateOrUpdateAsync(WaitUntil waitUntil, CsmPublishingCredentialsPoliciesEntityData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _basicPublishingCredentialsPolicyFtpWebAppsClientDiagnostics.CreateScope("BasicPublishingCredentialsPolicyFtpResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _basicPublishingCredentialsPolicyFtpWebAppsRestClient.UpdateFtpAllowedAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<BasicPublishingCredentialsPolicyFtpResource>(Response.FromValue(new BasicPublishingCredentialsPolicyFtpResource(Client, response), response.GetRawResponse()));
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
        /// Description for Updates whether FTP is allowed on the site or not.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/basicPublishingCredentialsPolicies/ftp
        /// Operation Id: WebApps_UpdateFtpAllowed
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The CsmPublishingCredentialsPoliciesEntity to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<BasicPublishingCredentialsPolicyFtpResource> CreateOrUpdate(WaitUntil waitUntil, CsmPublishingCredentialsPoliciesEntityData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _basicPublishingCredentialsPolicyFtpWebAppsClientDiagnostics.CreateScope("BasicPublishingCredentialsPolicyFtpResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _basicPublishingCredentialsPolicyFtpWebAppsRestClient.UpdateFtpAllowed(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, cancellationToken);
                var operation = new AppServiceArmOperation<BasicPublishingCredentialsPolicyFtpResource>(Response.FromValue(new BasicPublishingCredentialsPolicyFtpResource(Client, response), response.GetRawResponse()));
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
    }
}
