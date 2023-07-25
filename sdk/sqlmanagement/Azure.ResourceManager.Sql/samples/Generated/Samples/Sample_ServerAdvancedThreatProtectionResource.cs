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
    public partial class Sample_ServerAdvancedThreatProtectionResource
    {
        // Get a server's Advanced Threat Protection settings
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAServerSAdvancedThreatProtectionSettings()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2021-11-01-preview/examples/ServerAdvancedThreatProtectionSettingsGet.json
            // this example is just showing the usage of "ServerAdvancedThreatProtectionSettings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServerAdvancedThreatProtectionResource created on azure
            // for more information of creating ServerAdvancedThreatProtectionResource, please refer to the document of ServerAdvancedThreatProtectionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "threatprotection-4799";
            string serverName = "threatprotection-6440";
            AdvancedThreatProtectionName advancedThreatProtectionName = AdvancedThreatProtectionName.Default;
            ResourceIdentifier serverAdvancedThreatProtectionResourceId = ServerAdvancedThreatProtectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, advancedThreatProtectionName);
            ServerAdvancedThreatProtectionResource serverAdvancedThreatProtection = client.GetServerAdvancedThreatProtectionResource(serverAdvancedThreatProtectionResourceId);

            // invoke the operation
            ServerAdvancedThreatProtectionResource result = await serverAdvancedThreatProtection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServerAdvancedThreatProtectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update a server's Advanced Threat Protection settings with all parameters.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateAServerSAdvancedThreatProtectionSettingsWithAllParameters()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2021-11-01-preview/examples/ServerAdvancedThreatProtectionSettingsCreateMax.json
            // this example is just showing the usage of "ServerAdvancedThreatProtectionSettings_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServerAdvancedThreatProtectionResource created on azure
            // for more information of creating ServerAdvancedThreatProtectionResource, please refer to the document of ServerAdvancedThreatProtectionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "threatprotection-4799";
            string serverName = "threatprotection-6440";
            AdvancedThreatProtectionName advancedThreatProtectionName = AdvancedThreatProtectionName.Default;
            ResourceIdentifier serverAdvancedThreatProtectionResourceId = ServerAdvancedThreatProtectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, advancedThreatProtectionName);
            ServerAdvancedThreatProtectionResource serverAdvancedThreatProtection = client.GetServerAdvancedThreatProtectionResource(serverAdvancedThreatProtectionResourceId);

            // invoke the operation
            ServerAdvancedThreatProtectionData data = new ServerAdvancedThreatProtectionData()
            {
                State = AdvancedThreatProtectionState.Enabled,
            };
            ArmOperation<ServerAdvancedThreatProtectionResource> lro = await serverAdvancedThreatProtection.UpdateAsync(WaitUntil.Completed, data);
            ServerAdvancedThreatProtectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServerAdvancedThreatProtectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update a server's Advanced Threat Protection settings with minimal parameters.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateAServerSAdvancedThreatProtectionSettingsWithMinimalParameters()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2021-11-01-preview/examples/ServerAdvancedThreatProtectionSettingsCreateMin.json
            // this example is just showing the usage of "ServerAdvancedThreatProtectionSettings_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServerAdvancedThreatProtectionResource created on azure
            // for more information of creating ServerAdvancedThreatProtectionResource, please refer to the document of ServerAdvancedThreatProtectionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "threatprotection-4799";
            string serverName = "threatprotection-6440";
            AdvancedThreatProtectionName advancedThreatProtectionName = AdvancedThreatProtectionName.Default;
            ResourceIdentifier serverAdvancedThreatProtectionResourceId = ServerAdvancedThreatProtectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, advancedThreatProtectionName);
            ServerAdvancedThreatProtectionResource serverAdvancedThreatProtection = client.GetServerAdvancedThreatProtectionResource(serverAdvancedThreatProtectionResourceId);

            // invoke the operation
            ServerAdvancedThreatProtectionData data = new ServerAdvancedThreatProtectionData()
            {
                State = AdvancedThreatProtectionState.Disabled,
            };
            ArmOperation<ServerAdvancedThreatProtectionResource> lro = await serverAdvancedThreatProtection.UpdateAsync(WaitUntil.Completed, data);
            ServerAdvancedThreatProtectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServerAdvancedThreatProtectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
