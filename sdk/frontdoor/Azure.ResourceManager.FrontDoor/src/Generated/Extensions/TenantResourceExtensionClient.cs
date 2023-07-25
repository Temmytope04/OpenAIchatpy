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
using Azure.ResourceManager.FrontDoor.Models;

namespace Azure.ResourceManager.FrontDoor
{
    /// <summary> A class to add extension methods to TenantResource. </summary>
    internal partial class TenantResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _frontDoorNameAvailabilityClientDiagnostics;
        private FrontDoorNameAvailabilityRestOperations _frontDoorNameAvailabilityRestClient;

        /// <summary> Initializes a new instance of the <see cref="TenantResourceExtensionClient"/> class for mocking. </summary>
        protected TenantResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TenantResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal TenantResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics FrontDoorNameAvailabilityClientDiagnostics => _frontDoorNameAvailabilityClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.FrontDoor", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private FrontDoorNameAvailabilityRestOperations FrontDoorNameAvailabilityRestClient => _frontDoorNameAvailabilityRestClient ??= new FrontDoorNameAvailabilityRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Check the availability of a Front Door resource name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Network/checkFrontDoorNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorNameAvailability_Check</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<FrontDoorNameAvailabilityResult>> CheckFrontDoorNameAvailabilityAsync(FrontDoorNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = FrontDoorNameAvailabilityClientDiagnostics.CreateScope("TenantResourceExtensionClient.CheckFrontDoorNameAvailability");
            scope.Start();
            try
            {
                var response = await FrontDoorNameAvailabilityRestClient.CheckAsync(content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check the availability of a Front Door resource name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Network/checkFrontDoorNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorNameAvailability_Check</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<FrontDoorNameAvailabilityResult> CheckFrontDoorNameAvailability(FrontDoorNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = FrontDoorNameAvailabilityClientDiagnostics.CreateScope("TenantResourceExtensionClient.CheckFrontDoorNameAvailability");
            scope.Start();
            try
            {
                var response = FrontDoorNameAvailabilityRestClient.Check(content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
