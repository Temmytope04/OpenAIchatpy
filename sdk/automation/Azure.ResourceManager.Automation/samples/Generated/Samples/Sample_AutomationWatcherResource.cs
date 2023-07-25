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
using Azure.ResourceManager.Automation;
using Azure.ResourceManager.Automation.Models;

namespace Azure.ResourceManager.Automation.Samples
{
    public partial class Sample_AutomationWatcherResource
    {
        // Get watcher
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetWatcher()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/preview/2020-01-13-preview/examples/getWatcher.json
            // this example is just showing the usage of "Watcher_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationWatcherResource created on azure
            // for more information of creating AutomationWatcherResource, please refer to the document of AutomationWatcherResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string automationAccountName = "MyTestAutomationAccount";
            string watcherName = "MyTestWatcher";
            ResourceIdentifier automationWatcherResourceId = AutomationWatcherResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName, watcherName);
            AutomationWatcherResource automationWatcher = client.GetAutomationWatcherResource(automationWatcherResourceId);

            // invoke the operation
            AutomationWatcherResource result = await automationWatcher.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AutomationWatcherData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update watcher
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateWatcher()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/preview/2020-01-13-preview/examples/updateWatcher.json
            // this example is just showing the usage of "Watcher_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationWatcherResource created on azure
            // for more information of creating AutomationWatcherResource, please refer to the document of AutomationWatcherResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string automationAccountName = "MyTestAutomationAccount";
            string watcherName = "MyTestWatcher";
            ResourceIdentifier automationWatcherResourceId = AutomationWatcherResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName, watcherName);
            AutomationWatcherResource automationWatcher = client.GetAutomationWatcherResource(automationWatcherResourceId);

            // invoke the operation
            AutomationWatcherPatch patch = new AutomationWatcherPatch()
            {
                Name = "MyTestWatcher",
                ExecutionFrequencyInSeconds = 600,
            };
            AutomationWatcherResource result = await automationWatcher.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AutomationWatcherData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete watcher
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteWatcher()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/preview/2020-01-13-preview/examples/deleteWatcher.json
            // this example is just showing the usage of "Watcher_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationWatcherResource created on azure
            // for more information of creating AutomationWatcherResource, please refer to the document of AutomationWatcherResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string automationAccountName = "MyTestAutomationAccount";
            string watcherName = "MyTestWatcher";
            ResourceIdentifier automationWatcherResourceId = AutomationWatcherResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName, watcherName);
            AutomationWatcherResource automationWatcher = client.GetAutomationWatcherResource(automationWatcherResourceId);

            // invoke the operation
            await automationWatcher.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Start Watcher
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Start_StartWatcher()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/preview/2020-01-13-preview/examples/startWatcher.json
            // this example is just showing the usage of "Watcher_Start" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationWatcherResource created on azure
            // for more information of creating AutomationWatcherResource, please refer to the document of AutomationWatcherResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string automationAccountName = "MyTestAutomationAccount";
            string watcherName = "MyTestWatcher";
            ResourceIdentifier automationWatcherResourceId = AutomationWatcherResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName, watcherName);
            AutomationWatcherResource automationWatcher = client.GetAutomationWatcherResource(automationWatcherResourceId);

            // invoke the operation
            await automationWatcher.StartAsync();

            Console.WriteLine($"Succeeded");
        }

        // Start Watcher
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Stop_StartWatcher()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/preview/2020-01-13-preview/examples/stopWatcher.json
            // this example is just showing the usage of "Watcher_Stop" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationWatcherResource created on azure
            // for more information of creating AutomationWatcherResource, please refer to the document of AutomationWatcherResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string automationAccountName = "MyTestAutomationAccount";
            string watcherName = "MyTestWatcher";
            ResourceIdentifier automationWatcherResourceId = AutomationWatcherResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName, watcherName);
            AutomationWatcherResource automationWatcher = client.GetAutomationWatcherResource(automationWatcherResourceId);

            // invoke the operation
            await automationWatcher.StopAsync();

            Console.WriteLine($"Succeeded");
        }
    }
}
