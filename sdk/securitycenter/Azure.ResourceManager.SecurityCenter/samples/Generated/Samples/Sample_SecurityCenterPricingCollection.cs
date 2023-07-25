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
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.SecurityCenter;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter.Samples
{
    public partial class Sample_SecurityCenterPricingCollection
    {
        // Get pricings on subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetPricingsOnSubscription()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/stable/2022-03-01/examples/Pricings/ListPricings_example.json
            // this example is just showing the usage of "Pricings_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "20ff7fc3-e762-44dd-bd96-b71116dcdc23";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this SecurityCenterPricingResource
            SecurityCenterPricingCollection collection = subscriptionResource.GetSecurityCenterPricings();

            // invoke the operation and iterate over the result
            await foreach (SecurityCenterPricingResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SecurityCenterPricingData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get pricings on subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetPricingsOnSubscription()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/stable/2022-03-01/examples/Pricings/GetPricingByName_example.json
            // this example is just showing the usage of "Pricings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "20ff7fc3-e762-44dd-bd96-b71116dcdc23";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this SecurityCenterPricingResource
            SecurityCenterPricingCollection collection = subscriptionResource.GetSecurityCenterPricings();

            // invoke the operation
            string pricingName = "VirtualMachines";
            SecurityCenterPricingResource result = await collection.GetAsync(pricingName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SecurityCenterPricingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get pricings on subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetPricingsOnSubscription()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/stable/2022-03-01/examples/Pricings/GetPricingByName_example.json
            // this example is just showing the usage of "Pricings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "20ff7fc3-e762-44dd-bd96-b71116dcdc23";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this SecurityCenterPricingResource
            SecurityCenterPricingCollection collection = subscriptionResource.GetSecurityCenterPricings();

            // invoke the operation
            string pricingName = "VirtualMachines";
            bool result = await collection.ExistsAsync(pricingName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Update pricing on subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_UpdatePricingOnSubscription()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/stable/2022-03-01/examples/Pricings/PutPricingByName_example.json
            // this example is just showing the usage of "Pricings_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "20ff7fc3-e762-44dd-bd96-b71116dcdc23";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this SecurityCenterPricingResource
            SecurityCenterPricingCollection collection = subscriptionResource.GetSecurityCenterPricings();

            // invoke the operation
            string pricingName = "VirtualMachines";
            SecurityCenterPricingData data = new SecurityCenterPricingData()
            {
                PricingTier = SecurityCenterPricingTier.Standard,
                SubPlan = "P2",
            };
            ArmOperation<SecurityCenterPricingResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, pricingName, data);
            SecurityCenterPricingResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SecurityCenterPricingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
