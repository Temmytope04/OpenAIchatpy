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
    public partial class Sample_SecurityAutomationCollection
    {
        // List all security automations of a specified resource group
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListAllSecurityAutomationsOfASpecifiedResourceGroup()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2019-01-01-preview/examples/Automations/GetAutomationsResourceGroup_example.json
            // this example is just showing the usage of "Automations_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "a5caac9c-5c04-49af-b3d0-e204f40345d5";
            string resourceGroupName = "exampleResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SecurityAutomationResource
            SecurityAutomationCollection collection = resourceGroupResource.GetSecurityAutomations();

            // invoke the operation and iterate over the result
            await foreach (SecurityAutomationResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SecurityAutomationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Retrieve a security automation
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_RetrieveASecurityAutomation()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2019-01-01-preview/examples/Automations/GetAutomationResourceGroup_example.json
            // this example is just showing the usage of "Automations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "a5caac9c-5c04-49af-b3d0-e204f40345d5";
            string resourceGroupName = "exampleResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SecurityAutomationResource
            SecurityAutomationCollection collection = resourceGroupResource.GetSecurityAutomations();

            // invoke the operation
            string automationName = "exampleAutomation";
            SecurityAutomationResource result = await collection.GetAsync(automationName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SecurityAutomationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Retrieve a security automation
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_RetrieveASecurityAutomation()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2019-01-01-preview/examples/Automations/GetAutomationResourceGroup_example.json
            // this example is just showing the usage of "Automations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "a5caac9c-5c04-49af-b3d0-e204f40345d5";
            string resourceGroupName = "exampleResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SecurityAutomationResource
            SecurityAutomationCollection collection = resourceGroupResource.GetSecurityAutomations();

            // invoke the operation
            string automationName = "exampleAutomation";
            bool result = await collection.ExistsAsync(automationName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Create or update a security automation for all assessments (including all severities)
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateASecurityAutomationForAllAssessmentsIncludingAllSeverities()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2019-01-01-preview/examples/Automations/PutAutomationAllAssessments_example.json
            // this example is just showing the usage of "Automations_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "a5caac9c-5c04-49af-b3d0-e204f40345d5";
            string resourceGroupName = "exampleResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SecurityAutomationResource
            SecurityAutomationCollection collection = resourceGroupResource.GetSecurityAutomations();

            // invoke the operation
            string automationName = "exampleAutomation";
            SecurityAutomationData data = new SecurityAutomationData(new AzureLocation("Central US"))
            {
                Description = "An example of a security automation that triggers one LogicApp resource (myTest1) on any security assessment",
                IsEnabled = true,
                Scopes =
{
new SecurityAutomationScope()
{
Description = "A description that helps to identify this scope - for example: security assessments that relate to the resource group myResourceGroup within the subscription a5caac9c-5c04-49af-b3d0-e204f40345d5",
ScopePath = "/subscriptions/a5caac9c-5c04-49af-b3d0-e204f40345d5/resourceGroups/myResourceGroup",
}
},
                Sources =
{
new SecurityAutomationSource()
{
EventSource = SecurityEventSource.Assessments,
}
},
                Actions =
{
new SecurityAutomationActionLogicApp()
{
LogicAppResourceId = new ResourceIdentifier("/subscriptions/e54a4a18-5b94-4f90-9471-bd3decad8a2e/resourceGroups/sample/providers/Microsoft.Logic/workflows/MyTest1"),
Uri = new Uri("https://exampleTriggerUri1.com"),
}
},
                ETag = new ETag("etag value (must be supplied for update)"),
                Tags =
{
},
            };
            ArmOperation<SecurityAutomationResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, automationName, data);
            SecurityAutomationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SecurityAutomationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create or update a security automation for all high severity assessments
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateASecurityAutomationForAllHighSeverityAssessments()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2019-01-01-preview/examples/Automations/PutAutomationHighSeverityAssessments_example.json
            // this example is just showing the usage of "Automations_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "a5caac9c-5c04-49af-b3d0-e204f40345d5";
            string resourceGroupName = "exampleResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SecurityAutomationResource
            SecurityAutomationCollection collection = resourceGroupResource.GetSecurityAutomations();

            // invoke the operation
            string automationName = "exampleAutomation";
            SecurityAutomationData data = new SecurityAutomationData(new AzureLocation("Central US"))
            {
                Description = "An example of a security automation that triggers one LogicApp resource (myTest1) on any high severity security assessment",
                IsEnabled = true,
                Scopes =
{
new SecurityAutomationScope()
{
Description = "A description that helps to identify this scope - for example: security assessments that relate to the resource group myResourceGroup within the subscription a5caac9c-5c04-49af-b3d0-e204f40345d5",
ScopePath = "/subscriptions/a5caac9c-5c04-49af-b3d0-e204f40345d5/resourceGroups/myResourceGroup",
}
},
                Sources =
{
new SecurityAutomationSource()
{
EventSource = SecurityEventSource.Assessments,
RuleSets =
{
new SecurityAutomationRuleSet()
{
Rules =
{
new SecurityAutomationTriggeringRule()
{
PropertyJPath = "properties.metadata.severity",
PropertyType = AutomationTriggeringRulePropertyType.String,
ExpectedValue = "High",
Operator = AutomationTriggeringRuleOperator.EqualsValue,
}
},
}
},
}
},
                Actions =
{
new SecurityAutomationActionLogicApp()
{
LogicAppResourceId = new ResourceIdentifier("/subscriptions/e54a4a18-5b94-4f90-9471-bd3decad8a2e/resourceGroups/sample/providers/Microsoft.Logic/workflows/MyTest1"),
Uri = new Uri("https://exampleTriggerUri1.com"),
}
},
                ETag = new ETag("etag value (must be supplied for update)"),
                Tags =
{
},
            };
            ArmOperation<SecurityAutomationResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, automationName, data);
            SecurityAutomationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SecurityAutomationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Disable or enable a security automation
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_DisableOrEnableASecurityAutomation()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2019-01-01-preview/examples/Automations/PutDisableAutomation_example.json
            // this example is just showing the usage of "Automations_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "a5caac9c-5c04-49af-b3d0-e204f40345d5";
            string resourceGroupName = "exampleResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SecurityAutomationResource
            SecurityAutomationCollection collection = resourceGroupResource.GetSecurityAutomations();

            // invoke the operation
            string automationName = "exampleAutomation";
            SecurityAutomationData data = new SecurityAutomationData(new AzureLocation("Central US"))
            {
                Description = "An example of a security automation that triggers one LogicApp resource (myTest1) on any security assessment of type customAssessment",
                IsEnabled = false,
                Scopes =
{
new SecurityAutomationScope()
{
Description = "A description that helps to identify this scope - for example: security assessments that relate to the resource group myResourceGroup within the subscription a5caac9c-5c04-49af-b3d0-e204f40345d5",
ScopePath = "/subscriptions/a5caac9c-5c04-49af-b3d0-e204f40345d5/resourceGroups/myResourceGroup",
}
},
                Sources =
{
new SecurityAutomationSource()
{
EventSource = SecurityEventSource.Assessments,
RuleSets =
{
new SecurityAutomationRuleSet()
{
Rules =
{
new SecurityAutomationTriggeringRule()
{
PropertyJPath = "$.Entity.AssessmentType",
PropertyType = AutomationTriggeringRulePropertyType.String,
ExpectedValue = "customAssessment",
Operator = AutomationTriggeringRuleOperator.EqualsValue,
}
},
}
},
}
},
                Actions =
{
new SecurityAutomationActionLogicApp()
{
LogicAppResourceId = new ResourceIdentifier("/subscriptions/e54a4a18-5b94-4f90-9471-bd3decad8a2e/resourceGroups/sample/providers/Microsoft.Logic/workflows/MyTest1"),
Uri = new Uri("https://exampleTriggerUri1.com"),
}
},
                ETag = new ETag("etag value (must be supplied for update)"),
                Tags =
{
},
            };
            ArmOperation<SecurityAutomationResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, automationName, data);
            SecurityAutomationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SecurityAutomationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
