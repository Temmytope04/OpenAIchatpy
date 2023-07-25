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
    public partial class Sample_AutomationRunbookResource
    {
        // Get runbook draft content
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetContentRunbookDraft_GetRunbookDraftContent()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/stable/2018-06-30/examples/getRunbookDraftContent.json
            // this example is just showing the usage of "RunbookDraft_GetContent" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationRunbookResource created on azure
            // for more information of creating AutomationRunbookResource, please refer to the document of AutomationRunbookResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string automationAccountName = "ContoseAutomationAccount";
            string runbookName = "Get-AzureVMTutorial";
            ResourceIdentifier automationRunbookResourceId = AutomationRunbookResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName, runbookName);
            AutomationRunbookResource automationRunbook = client.GetAutomationRunbookResource(automationRunbookResourceId);

            // invoke the operation
            string result = await automationRunbook.GetContentRunbookDraftAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get runbook draft
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetRunbookDraft_GetRunbookDraft()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/stable/2018-06-30/examples/getRunbookDraft.json
            // this example is just showing the usage of "RunbookDraft_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationRunbookResource created on azure
            // for more information of creating AutomationRunbookResource, please refer to the document of AutomationRunbookResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string automationAccountName = "ContoseAutomationAccount";
            string runbookName = "Get-AzureVMTutorial";
            ResourceIdentifier automationRunbookResourceId = AutomationRunbookResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName, runbookName);
            AutomationRunbookResource automationRunbook = client.GetAutomationRunbookResource(automationRunbookResourceId);

            // invoke the operation
            AutomationRunbookDraft result = await automationRunbook.GetRunbookDraftAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // Undo draft edit to last known published state
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task UndoEditRunbookDraft_UndoDraftEditToLastKnownPublishedState()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/stable/2018-06-30/examples/undoDraftEditToLastKnownPublishedState.json
            // this example is just showing the usage of "RunbookDraft_UndoEdit" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationRunbookResource created on azure
            // for more information of creating AutomationRunbookResource, please refer to the document of AutomationRunbookResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string automationAccountName = "ContoseAutomationAccount";
            string runbookName = "Get-AzureVMTutorial";
            ResourceIdentifier automationRunbookResourceId = AutomationRunbookResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName, runbookName);
            AutomationRunbookResource automationRunbook = client.GetAutomationRunbookResource(automationRunbookResourceId);

            // invoke the operation
            RunbookDraftUndoEditResult result = await automationRunbook.UndoEditRunbookDraftAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // Publish runbook draft
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Publish_PublishRunbookDraft()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/stable/2018-06-30/examples/publishRunbook.json
            // this example is just showing the usage of "Runbook_Publish" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationRunbookResource created on azure
            // for more information of creating AutomationRunbookResource, please refer to the document of AutomationRunbookResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string automationAccountName = "ContoseAutomationAccount";
            string runbookName = "Get-AzureVMTutorial";
            ResourceIdentifier automationRunbookResourceId = AutomationRunbookResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName, runbookName);
            AutomationRunbookResource automationRunbook = client.GetAutomationRunbookResource(automationRunbookResourceId);

            // invoke the operation
            await automationRunbook.PublishAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get runbook content
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetContent_GetRunbookContent()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/stable/2018-06-30/examples/getRunbookContent.json
            // this example is just showing the usage of "Runbook_GetContent" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationRunbookResource created on azure
            // for more information of creating AutomationRunbookResource, please refer to the document of AutomationRunbookResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string automationAccountName = "ContoseAutomationAccount";
            string runbookName = "Get-AzureVMTutorial";
            ResourceIdentifier automationRunbookResourceId = AutomationRunbookResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName, runbookName);
            AutomationRunbookResource automationRunbook = client.GetAutomationRunbookResource(automationRunbookResourceId);

            // invoke the operation
            string result = await automationRunbook.GetContentAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get runbook
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetRunbook()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/stable/2018-06-30/examples/getRunbook.json
            // this example is just showing the usage of "Runbook_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationRunbookResource created on azure
            // for more information of creating AutomationRunbookResource, please refer to the document of AutomationRunbookResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string automationAccountName = "ContoseAutomationAccount";
            string runbookName = "Get-AzureVMTutorial";
            ResourceIdentifier automationRunbookResourceId = AutomationRunbookResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName, runbookName);
            AutomationRunbookResource automationRunbook = client.GetAutomationRunbookResource(automationRunbookResourceId);

            // invoke the operation
            AutomationRunbookResource result = await automationRunbook.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AutomationRunbookData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update runbook
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateRunbook()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/stable/2018-06-30/examples/updateRunbook.json
            // this example is just showing the usage of "Runbook_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationRunbookResource created on azure
            // for more information of creating AutomationRunbookResource, please refer to the document of AutomationRunbookResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string automationAccountName = "ContoseAutomationAccount";
            string runbookName = "Get-AzureVMTutorial";
            ResourceIdentifier automationRunbookResourceId = AutomationRunbookResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName, runbookName);
            AutomationRunbookResource automationRunbook = client.GetAutomationRunbookResource(automationRunbookResourceId);

            // invoke the operation
            AutomationRunbookPatch patch = new AutomationRunbookPatch()
            {
                Description = "Updated Description of the Runbook",
                IsLogVerboseEnabled = false,
                IsLogProgressEnabled = true,
                LogActivityTrace = 1,
            };
            AutomationRunbookResource result = await automationRunbook.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AutomationRunbookData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete a runbook
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteARunbook()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/stable/2018-06-30/examples/deleteRunbook.json
            // this example is just showing the usage of "Runbook_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationRunbookResource created on azure
            // for more information of creating AutomationRunbookResource, please refer to the document of AutomationRunbookResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string automationAccountName = "ContoseAutomationAccount";
            string runbookName = "Get-AzureVMTutorial";
            ResourceIdentifier automationRunbookResourceId = AutomationRunbookResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName, runbookName);
            AutomationRunbookResource automationRunbook = client.GetAutomationRunbookResource(automationRunbookResourceId);

            // invoke the operation
            await automationRunbook.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get test job stream
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetTestJobStream_GetTestJobStream()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/stable/2018-06-30/examples/getTestJobStream.json
            // this example is just showing the usage of "TestJobStreams_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationRunbookResource created on azure
            // for more information of creating AutomationRunbookResource, please refer to the document of AutomationRunbookResource
            string subscriptionId = "51766542-3ed7-4a72-a187-0c8ab644ddab";
            string resourceGroupName = "mygroup";
            string automationAccountName = "ContoseAutomationAccount";
            string runbookName = "Get-AzureVMTutorial";
            ResourceIdentifier automationRunbookResourceId = AutomationRunbookResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName, runbookName);
            AutomationRunbookResource automationRunbook = client.GetAutomationRunbookResource(automationRunbookResourceId);

            // invoke the operation
            string jobStreamId = "851b2101-686f-40e2-8a4b-5b8df08afbd1_00636535684910693884_00000000000000000001";
            AutomationJobStream result = await automationRunbook.GetTestJobStreamAsync(jobStreamId);

            Console.WriteLine($"Succeeded: {result}");
        }

        // List job streams by job name
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetTestJobStreams_ListJobStreamsByJobName()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/stable/2018-06-30/examples/listTestJobStreamsByJob.json
            // this example is just showing the usage of "TestJobStreams_ListByTestJob" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationRunbookResource created on azure
            // for more information of creating AutomationRunbookResource, please refer to the document of AutomationRunbookResource
            string subscriptionId = "51766542-3ed7-4a72-a187-0c8ab644ddab";
            string resourceGroupName = "mygroup";
            string automationAccountName = "ContoseAutomationAccount";
            string runbookName = "Get-AzureVMTutorial";
            ResourceIdentifier automationRunbookResourceId = AutomationRunbookResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName, runbookName);
            AutomationRunbookResource automationRunbook = client.GetAutomationRunbookResource(automationRunbookResourceId);

            // invoke the operation and iterate over the result
            await foreach (AutomationJobStream item in automationRunbook.GetTestJobStreamsAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Create test job
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateTestJob_CreateTestJob()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/stable/2018-06-30/examples/createTestJob.json
            // this example is just showing the usage of "TestJob_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationRunbookResource created on azure
            // for more information of creating AutomationRunbookResource, please refer to the document of AutomationRunbookResource
            string subscriptionId = "51766542-3ed7-4a72-a187-0c8ab644ddab";
            string resourceGroupName = "mygroup";
            string automationAccountName = "ContoseAutomationAccount";
            string runbookName = "Get-AzureVMTutorial";
            ResourceIdentifier automationRunbookResourceId = AutomationRunbookResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName, runbookName);
            AutomationRunbookResource automationRunbook = client.GetAutomationRunbookResource(automationRunbookResourceId);

            // invoke the operation
            RunbookTestJobCreateContent content = new RunbookTestJobCreateContent()
            {
                Parameters =
{
["key01"] = "value01",
["key02"] = "value02",
},
                RunOn = "",
            };
            RunbookTestJob result = await automationRunbook.CreateTestJobAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get test job
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetTestJob_GetTestJob()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/stable/2018-06-30/examples/getTestJob.json
            // this example is just showing the usage of "TestJob_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationRunbookResource created on azure
            // for more information of creating AutomationRunbookResource, please refer to the document of AutomationRunbookResource
            string subscriptionId = "51766542-3ed7-4a72-a187-0c8ab644ddab";
            string resourceGroupName = "mygroup";
            string automationAccountName = "ContoseAutomationAccount";
            string runbookName = "Get-AzureVMTutorial";
            ResourceIdentifier automationRunbookResourceId = AutomationRunbookResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName, runbookName);
            AutomationRunbookResource automationRunbook = client.GetAutomationRunbookResource(automationRunbookResourceId);

            // invoke the operation
            RunbookTestJob result = await automationRunbook.GetTestJobAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // Resume test job
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task ResumeTestJob_ResumeTestJob()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/stable/2018-06-30/examples/resumeTestJob.json
            // this example is just showing the usage of "TestJob_Resume" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationRunbookResource created on azure
            // for more information of creating AutomationRunbookResource, please refer to the document of AutomationRunbookResource
            string subscriptionId = "51766542-3ed7-4a72-a187-0c8ab644ddab";
            string resourceGroupName = "mygroup";
            string automationAccountName = "ContoseAutomationAccount";
            string runbookName = "Get-AzureVMTutorial";
            ResourceIdentifier automationRunbookResourceId = AutomationRunbookResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName, runbookName);
            AutomationRunbookResource automationRunbook = client.GetAutomationRunbookResource(automationRunbookResourceId);

            // invoke the operation
            await automationRunbook.ResumeTestJobAsync();

            Console.WriteLine($"Succeeded");
        }

        // Stop test job
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task StopTestJob_StopTestJob()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/stable/2018-06-30/examples/stopTestJob.json
            // this example is just showing the usage of "TestJob_Stop" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationRunbookResource created on azure
            // for more information of creating AutomationRunbookResource, please refer to the document of AutomationRunbookResource
            string subscriptionId = "51766542-3ed7-4a72-a187-0c8ab644ddab";
            string resourceGroupName = "mygroup";
            string automationAccountName = "ContoseAutomationAccount";
            string runbookName = "Get-AzureVMTutorial";
            ResourceIdentifier automationRunbookResourceId = AutomationRunbookResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName, runbookName);
            AutomationRunbookResource automationRunbook = client.GetAutomationRunbookResource(automationRunbookResourceId);

            // invoke the operation
            await automationRunbook.StopTestJobAsync();

            Console.WriteLine($"Succeeded");
        }

        // Suspend test job
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task SuspendTestJob_SuspendTestJob()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/stable/2018-06-30/examples/suspendTestJob.json
            // this example is just showing the usage of "TestJob_Suspend" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationRunbookResource created on azure
            // for more information of creating AutomationRunbookResource, please refer to the document of AutomationRunbookResource
            string subscriptionId = "51766542-3ed7-4a72-a187-0c8ab644ddab";
            string resourceGroupName = "mygroup";
            string automationAccountName = "ContoseAutomationAccount";
            string runbookName = "Get-AzureVMTutorial";
            ResourceIdentifier automationRunbookResourceId = AutomationRunbookResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName, runbookName);
            AutomationRunbookResource automationRunbook = client.GetAutomationRunbookResource(automationRunbookResourceId);

            // invoke the operation
            await automationRunbook.SuspendTestJobAsync();

            Console.WriteLine($"Succeeded");
        }
    }
}
