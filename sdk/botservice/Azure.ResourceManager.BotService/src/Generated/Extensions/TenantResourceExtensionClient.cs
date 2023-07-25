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
using Azure.ResourceManager.BotService.Models;

namespace Azure.ResourceManager.BotService
{
    /// <summary> A class to add extension methods to TenantResource. </summary>
    internal partial class TenantResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _botClientDiagnostics;
        private BotsRestOperations _botRestClient;

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

        private ClientDiagnostics BotClientDiagnostics => _botClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.BotService", BotResource.ResourceType.Namespace, Diagnostics);
        private BotsRestOperations BotRestClient => _botRestClient ??= new BotsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(BotResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Check whether a bot name is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.BotService/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Bots_GetCheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The request body parameters to provide for the check name availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<BotServiceNameAvailabilityResult>> CheckBotServiceNameAvailabilityAsync(BotServiceNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = BotClientDiagnostics.CreateScope("TenantResourceExtensionClient.CheckBotServiceNameAvailability");
            scope.Start();
            try
            {
                var response = await BotRestClient.GetCheckNameAvailabilityAsync(content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check whether a bot name is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.BotService/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Bots_GetCheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The request body parameters to provide for the check name availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<BotServiceNameAvailabilityResult> CheckBotServiceNameAvailability(BotServiceNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = BotClientDiagnostics.CreateScope("TenantResourceExtensionClient.CheckBotServiceNameAvailability");
            scope.Start();
            try
            {
                var response = BotRestClient.GetCheckNameAvailability(content, cancellationToken);
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
