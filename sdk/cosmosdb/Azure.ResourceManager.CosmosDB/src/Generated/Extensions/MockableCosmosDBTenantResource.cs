// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.CosmosDB.Mocking
{
    /// <summary> A class to add extension methods to TenantResource. </summary>
    public partial class MockableCosmosDBTenantResource : ArmResource
    {
        private ClientDiagnostics _cosmosDBAccountDatabaseAccountsClientDiagnostics;
        private DatabaseAccountsRestOperations _cosmosDBAccountDatabaseAccountsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableCosmosDBTenantResource"/> class for mocking. </summary>
        protected MockableCosmosDBTenantResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableCosmosDBTenantResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableCosmosDBTenantResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics CosmosDBAccountDatabaseAccountsClientDiagnostics => _cosmosDBAccountDatabaseAccountsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.CosmosDB", CosmosDBAccountResource.ResourceType.Namespace, Diagnostics);
        private DatabaseAccountsRestOperations CosmosDBAccountDatabaseAccountsRestClient => _cosmosDBAccountDatabaseAccountsRestClient ??= new DatabaseAccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(CosmosDBAccountResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Checks that the Azure Cosmos DB account name already exists. A valid account name may contain only lowercase letters, numbers, and the '-' character, and must be between 3 and 50 characters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.DocumentDB/databaseAccountNames/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseAccounts_CheckNameExists</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> Cosmos DB database account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual async Task<Response<bool>> CheckNameExistsDatabaseAccountAsync(string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = CosmosDBAccountDatabaseAccountsClientDiagnostics.CreateScope("MockableCosmosDBTenantResource.CheckNameExistsDatabaseAccount");
            scope.Start();
            try
            {
                var response = await CosmosDBAccountDatabaseAccountsRestClient.CheckNameExistsAsync(accountName, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks that the Azure Cosmos DB account name already exists. A valid account name may contain only lowercase letters, numbers, and the '-' character, and must be between 3 and 50 characters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.DocumentDB/databaseAccountNames/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseAccounts_CheckNameExists</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> Cosmos DB database account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual Response<bool> CheckNameExistsDatabaseAccount(string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = CosmosDBAccountDatabaseAccountsClientDiagnostics.CreateScope("MockableCosmosDBTenantResource.CheckNameExistsDatabaseAccount");
            scope.Start();
            try
            {
                var response = CosmosDBAccountDatabaseAccountsRestClient.CheckNameExists(accountName, cancellationToken);
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
