// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.SignalR.Models;

namespace Azure.ResourceManager.SignalR.Samples
{
    public partial class Sample_SubscriptionResourceExtensions
    {
        // Usages_List
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetUsages_UsagesList()
        {
            // Generated from example definition: specification/signalr/resource-manager/Microsoft.SignalRService/stable/2022-02-01/examples/Usages_List.json
            // this example is just showing the usage of "Usages_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            AzureLocation location = new AzureLocation("eastus");
            await foreach (SignalRUsage item in subscriptionResource.GetUsagesAsync(location))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
