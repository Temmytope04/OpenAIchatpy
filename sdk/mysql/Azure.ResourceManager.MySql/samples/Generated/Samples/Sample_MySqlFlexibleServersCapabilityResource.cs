// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.MySql.FlexibleServers.Samples
{
    public partial class Sample_MySqlFlexibleServersCapabilityResource
    {
        // CapabilityResult
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_CapabilityResult()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/ServiceOperations/preview/2023-12-01-preview/examples/CapabilitySetByLocation.json
            // this example is just showing the usage of "LocationBasedCapabilitySet_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlFlexibleServersCapabilityResource created on azure
            // for more information of creating MySqlFlexibleServersCapabilityResource, please refer to the document of MySqlFlexibleServersCapabilityResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            AzureLocation locationName = new AzureLocation("WestUS");
            string capabilitySetName = "default";
            ResourceIdentifier mySqlFlexibleServersCapabilityResourceId = MySqlFlexibleServersCapabilityResource.CreateResourceIdentifier(subscriptionId, locationName, capabilitySetName);
            MySqlFlexibleServersCapabilityResource mySqlFlexibleServersCapability = client.GetMySqlFlexibleServersCapabilityResource(mySqlFlexibleServersCapabilityResourceId);

            // invoke the operation
            MySqlFlexibleServersCapabilityResource result = await mySqlFlexibleServersCapability.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MySqlFlexibleServersCapabilityData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
