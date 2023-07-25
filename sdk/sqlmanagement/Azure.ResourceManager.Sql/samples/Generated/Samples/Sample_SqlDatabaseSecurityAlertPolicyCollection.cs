// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Sql;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql.Samples
{
    public partial class Sample_SqlDatabaseSecurityAlertPolicyCollection
    {
        // Get a database's threat detection policy
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetADatabaseSThreatDetectionPolicy()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/DatabaseSecurityAlertGet.json
            // this example is just showing the usage of "DatabaseSecurityAlertPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlDatabaseResource created on azure
            // for more information of creating SqlDatabaseResource, please refer to the document of SqlDatabaseResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "securityalert-6852";
            string serverName = "securityalert-2080";
            string databaseName = "testdb";
            ResourceIdentifier sqlDatabaseResourceId = SqlDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            SqlDatabaseResource sqlDatabase = client.GetSqlDatabaseResource(sqlDatabaseResourceId);

            // get the collection of this SqlDatabaseSecurityAlertPolicyResource
            SqlDatabaseSecurityAlertPolicyCollection collection = sqlDatabase.GetSqlDatabaseSecurityAlertPolicies();

            // invoke the operation
            SqlSecurityAlertPolicyName securityAlertPolicyName = SqlSecurityAlertPolicyName.Default;
            SqlDatabaseSecurityAlertPolicyResource result = await collection.GetAsync(securityAlertPolicyName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlDatabaseSecurityAlertPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a database's threat detection policy
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetADatabaseSThreatDetectionPolicy()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/DatabaseSecurityAlertGet.json
            // this example is just showing the usage of "DatabaseSecurityAlertPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlDatabaseResource created on azure
            // for more information of creating SqlDatabaseResource, please refer to the document of SqlDatabaseResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "securityalert-6852";
            string serverName = "securityalert-2080";
            string databaseName = "testdb";
            ResourceIdentifier sqlDatabaseResourceId = SqlDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            SqlDatabaseResource sqlDatabase = client.GetSqlDatabaseResource(sqlDatabaseResourceId);

            // get the collection of this SqlDatabaseSecurityAlertPolicyResource
            SqlDatabaseSecurityAlertPolicyCollection collection = sqlDatabase.GetSqlDatabaseSecurityAlertPolicies();

            // invoke the operation
            SqlSecurityAlertPolicyName securityAlertPolicyName = SqlSecurityAlertPolicyName.Default;
            bool result = await collection.ExistsAsync(securityAlertPolicyName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Update a database's threat detection policy with all parameters
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_UpdateADatabaseSThreatDetectionPolicyWithAllParameters()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/DatabaseSecurityAlertCreateMax.json
            // this example is just showing the usage of "DatabaseSecurityAlertPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlDatabaseResource created on azure
            // for more information of creating SqlDatabaseResource, please refer to the document of SqlDatabaseResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "securityalert-4799";
            string serverName = "securityalert-6440";
            string databaseName = "testdb";
            ResourceIdentifier sqlDatabaseResourceId = SqlDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            SqlDatabaseResource sqlDatabase = client.GetSqlDatabaseResource(sqlDatabaseResourceId);

            // get the collection of this SqlDatabaseSecurityAlertPolicyResource
            SqlDatabaseSecurityAlertPolicyCollection collection = sqlDatabase.GetSqlDatabaseSecurityAlertPolicies();

            // invoke the operation
            SqlSecurityAlertPolicyName securityAlertPolicyName = SqlSecurityAlertPolicyName.Default;
            SqlDatabaseSecurityAlertPolicyData data = new SqlDatabaseSecurityAlertPolicyData()
            {
                State = SecurityAlertsPolicyState.Enabled,
                DisabledAlerts =
{
"Sql_Injection","Usage_Anomaly"
},
                EmailAddresses =
{
"test@microsoft.com","user@microsoft.com"
},
                SendToEmailAccountAdmins = true,
                StorageEndpoint = "https://mystorage.blob.core.windows.net",
                StorageAccountAccessKey = "sdlfkjabc+sdlfkjsdlkfsjdfLDKFTERLKFDFKLjsdfksjdflsdkfD2342309432849328476458/3RSD==",
                RetentionDays = 6,
            };
            ArmOperation<SqlDatabaseSecurityAlertPolicyResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, securityAlertPolicyName, data);
            SqlDatabaseSecurityAlertPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlDatabaseSecurityAlertPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update a database's threat detection policy with minimal parameters
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_UpdateADatabaseSThreatDetectionPolicyWithMinimalParameters()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/DatabaseSecurityAlertCreateMin.json
            // this example is just showing the usage of "DatabaseSecurityAlertPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlDatabaseResource created on azure
            // for more information of creating SqlDatabaseResource, please refer to the document of SqlDatabaseResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "securityalert-4799";
            string serverName = "securityalert-6440";
            string databaseName = "testdb";
            ResourceIdentifier sqlDatabaseResourceId = SqlDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            SqlDatabaseResource sqlDatabase = client.GetSqlDatabaseResource(sqlDatabaseResourceId);

            // get the collection of this SqlDatabaseSecurityAlertPolicyResource
            SqlDatabaseSecurityAlertPolicyCollection collection = sqlDatabase.GetSqlDatabaseSecurityAlertPolicies();

            // invoke the operation
            SqlSecurityAlertPolicyName securityAlertPolicyName = SqlSecurityAlertPolicyName.Default;
            SqlDatabaseSecurityAlertPolicyData data = new SqlDatabaseSecurityAlertPolicyData()
            {
                State = SecurityAlertsPolicyState.Enabled,
            };
            ArmOperation<SqlDatabaseSecurityAlertPolicyResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, securityAlertPolicyName, data);
            SqlDatabaseSecurityAlertPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlDatabaseSecurityAlertPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get the database's threat detection policies
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetTheDatabaseSThreatDetectionPolicies()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/DatabaseSecurityAlertListByDatabase.json
            // this example is just showing the usage of "DatabaseSecurityAlertPolicies_ListByDatabase" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlDatabaseResource created on azure
            // for more information of creating SqlDatabaseResource, please refer to the document of SqlDatabaseResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "securityalert-6852";
            string serverName = "securityalert-2080";
            string databaseName = "testdb";
            ResourceIdentifier sqlDatabaseResourceId = SqlDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            SqlDatabaseResource sqlDatabase = client.GetSqlDatabaseResource(sqlDatabaseResourceId);

            // get the collection of this SqlDatabaseSecurityAlertPolicyResource
            SqlDatabaseSecurityAlertPolicyCollection collection = sqlDatabase.GetSqlDatabaseSecurityAlertPolicies();

            // invoke the operation and iterate over the result
            await foreach (SqlDatabaseSecurityAlertPolicyResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SqlDatabaseSecurityAlertPolicyData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
