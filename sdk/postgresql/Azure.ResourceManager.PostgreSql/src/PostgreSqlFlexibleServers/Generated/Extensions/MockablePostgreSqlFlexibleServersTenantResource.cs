// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Mocking
{
    /// <summary> A class to add extension methods to TenantResource. </summary>
    public partial class MockablePostgreSqlFlexibleServersTenantResource : ArmResource
    {
        private ClientDiagnostics _getPrivateDnsZoneSuffixClientDiagnostics;
        private GetPrivateDnsZoneSuffixRestOperations _getPrivateDnsZoneSuffixRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockablePostgreSqlFlexibleServersTenantResource"/> class for mocking. </summary>
        protected MockablePostgreSqlFlexibleServersTenantResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockablePostgreSqlFlexibleServersTenantResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockablePostgreSqlFlexibleServersTenantResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics GetPrivateDnsZoneSuffixClientDiagnostics => _getPrivateDnsZoneSuffixClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.PostgreSql.FlexibleServers", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private GetPrivateDnsZoneSuffixRestOperations GetPrivateDnsZoneSuffixRestClient => _getPrivateDnsZoneSuffixRestClient ??= new GetPrivateDnsZoneSuffixRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Get private DNS zone suffix in the cloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.DBforPostgreSQL/getPrivateDnsZoneSuffix</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetPrivateDnsZoneSuffix_Execute</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<string>> ExecuteGetPrivateDnsZoneSuffixAsync(CancellationToken cancellationToken = default)
        {
            using var scope = GetPrivateDnsZoneSuffixClientDiagnostics.CreateScope("MockablePostgreSqlFlexibleServersTenantResource.ExecuteGetPrivateDnsZoneSuffix");
            scope.Start();
            try
            {
                var response = await GetPrivateDnsZoneSuffixRestClient.ExecuteAsync(cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get private DNS zone suffix in the cloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.DBforPostgreSQL/getPrivateDnsZoneSuffix</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetPrivateDnsZoneSuffix_Execute</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<string> ExecuteGetPrivateDnsZoneSuffix(CancellationToken cancellationToken = default)
        {
            using var scope = GetPrivateDnsZoneSuffixClientDiagnostics.CreateScope("MockablePostgreSqlFlexibleServersTenantResource.ExecuteGetPrivateDnsZoneSuffix");
            scope.Start();
            try
            {
                var response = GetPrivateDnsZoneSuffixRestClient.Execute(cancellationToken);
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
