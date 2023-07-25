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
    public partial class Sample_DscCompilationJobResource
    {
        // Create or update a DSC Compilation job
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateOrUpdateADSCCompilationJob()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/preview/2020-01-13-preview/examples/createCompilationJob.json
            // this example is just showing the usage of "DscCompilationJob_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DscCompilationJobResource created on azure
            // for more information of creating DscCompilationJobResource, please refer to the document of DscCompilationJobResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string automationAccountName = "myAutomationAccount33";
            string compilationJobName = "TestCompilationJob";
            ResourceIdentifier dscCompilationJobResourceId = DscCompilationJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName, compilationJobName);
            DscCompilationJobResource dscCompilationJob = client.GetDscCompilationJobResource(dscCompilationJobResourceId);

            // invoke the operation
            DscCompilationJobCreateOrUpdateContent content = new DscCompilationJobCreateOrUpdateContent(new DscConfigurationAssociationProperty()
            {
                ConfigurationName = "SetupServer",
            });
            ArmOperation<DscCompilationJobResource> lro = await dscCompilationJob.UpdateAsync(WaitUntil.Completed, content);
            DscCompilationJobResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DscCompilationJobData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a DSC Compilation job
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetADSCCompilationJob()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/preview/2020-01-13-preview/examples/getCompilationJob.json
            // this example is just showing the usage of "DscCompilationJob_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DscCompilationJobResource created on azure
            // for more information of creating DscCompilationJobResource, please refer to the document of DscCompilationJobResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string automationAccountName = "myAutomationAccount33";
            string compilationJobName = "TestCompilationJob";
            ResourceIdentifier dscCompilationJobResourceId = DscCompilationJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName, compilationJobName);
            DscCompilationJobResource dscCompilationJob = client.GetDscCompilationJobResource(dscCompilationJobResourceId);

            // invoke the operation
            DscCompilationJobResource result = await dscCompilationJob.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DscCompilationJobData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
