// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Workloads.Models;

namespace Azure.ResourceManager.Workloads.Samples
{
    public partial class Sample_SapDatabaseInstanceResource
    {
        // SAPDatabaseInstances_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_SAPDatabaseInstancesGet()
        {
            // Generated from example definition: specification/workloads/resource-manager/Microsoft.Workloads/stable/2023-04-01/examples/sapvirtualinstances/SAPDatabaseInstances_Get.json
            // this example is just showing the usage of "SAPDatabaseInstances_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SapDatabaseInstanceResource created on azure
            // for more information of creating SapDatabaseInstanceResource, please refer to the document of SapDatabaseInstanceResource
            string subscriptionId = "6d875e77-e412-4d7d-9af4-8895278b4443";
            string resourceGroupName = "test-rg";
            string sapVirtualInstanceName = "X00";
            string databaseInstanceName = "databaseServer";
            ResourceIdentifier sapDatabaseInstanceResourceId = SapDatabaseInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sapVirtualInstanceName, databaseInstanceName);
            SapDatabaseInstanceResource sapDatabaseInstance = client.GetSapDatabaseInstanceResource(sapDatabaseInstanceResourceId);

            // invoke the operation
            SapDatabaseInstanceResource result = await sapDatabaseInstance.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SapDatabaseInstanceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // SAPDatabaseInstances_Update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_SAPDatabaseInstancesUpdate()
        {
            // Generated from example definition: specification/workloads/resource-manager/Microsoft.Workloads/stable/2023-04-01/examples/sapvirtualinstances/SAPDatabaseInstances_Update.json
            // this example is just showing the usage of "SAPDatabaseInstances_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SapDatabaseInstanceResource created on azure
            // for more information of creating SapDatabaseInstanceResource, please refer to the document of SapDatabaseInstanceResource
            string subscriptionId = "6d875e77-e412-4d7d-9af4-8895278b4443";
            string resourceGroupName = "test-rg";
            string sapVirtualInstanceName = "X00";
            string databaseInstanceName = "databaseServer";
            ResourceIdentifier sapDatabaseInstanceResourceId = SapDatabaseInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sapVirtualInstanceName, databaseInstanceName);
            SapDatabaseInstanceResource sapDatabaseInstance = client.GetSapDatabaseInstanceResource(sapDatabaseInstanceResourceId);

            // invoke the operation
            SapDatabaseInstancePatch patch = new SapDatabaseInstancePatch()
            {
                Tags =
{
["key1"] = "value1",
},
            };
            ArmOperation<SapDatabaseInstanceResource> lro = await sapDatabaseInstance.UpdateAsync(WaitUntil.Completed, patch);
            SapDatabaseInstanceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SapDatabaseInstanceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // SAPDatabaseInstances_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_SAPDatabaseInstancesDelete()
        {
            // Generated from example definition: specification/workloads/resource-manager/Microsoft.Workloads/stable/2023-04-01/examples/sapvirtualinstances/SAPDatabaseInstances_Delete.json
            // this example is just showing the usage of "SAPDatabaseInstances_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SapDatabaseInstanceResource created on azure
            // for more information of creating SapDatabaseInstanceResource, please refer to the document of SapDatabaseInstanceResource
            string subscriptionId = "6d875e77-e412-4d7d-9af4-8895278b4443";
            string resourceGroupName = "test-rg";
            string sapVirtualInstanceName = "X00";
            string databaseInstanceName = "databaseServer";
            ResourceIdentifier sapDatabaseInstanceResourceId = SapDatabaseInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sapVirtualInstanceName, databaseInstanceName);
            SapDatabaseInstanceResource sapDatabaseInstance = client.GetSapDatabaseInstanceResource(sapDatabaseInstanceResourceId);

            // invoke the operation
            ArmOperation<OperationStatusResult> lro = await sapDatabaseInstance.DeleteAsync(WaitUntil.Completed);
            OperationStatusResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Start the database instance of the SAP system.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task StartInstance_StartTheDatabaseInstanceOfTheSAPSystem()
        {
            // Generated from example definition: specification/workloads/resource-manager/Microsoft.Workloads/stable/2023-04-01/examples/sapvirtualinstances/SAPDatabaseInstances_StartInstance.json
            // this example is just showing the usage of "SAPDatabaseInstances_StartInstance" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SapDatabaseInstanceResource created on azure
            // for more information of creating SapDatabaseInstanceResource, please refer to the document of SapDatabaseInstanceResource
            string subscriptionId = "8e17e36c-42e9-4cd5-a078-7b44883414e0";
            string resourceGroupName = "test-rg";
            string sapVirtualInstanceName = "X00";
            string databaseInstanceName = "db0";
            ResourceIdentifier sapDatabaseInstanceResourceId = SapDatabaseInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sapVirtualInstanceName, databaseInstanceName);
            SapDatabaseInstanceResource sapDatabaseInstance = client.GetSapDatabaseInstanceResource(sapDatabaseInstanceResourceId);

            // invoke the operation
            ArmOperation<OperationStatusResult> lro = await sapDatabaseInstance.StartInstanceAsync(WaitUntil.Completed);
            OperationStatusResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Stop the database instance of the SAP system.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task StopInstance_StopTheDatabaseInstanceOfTheSAPSystem()
        {
            // Generated from example definition: specification/workloads/resource-manager/Microsoft.Workloads/stable/2023-04-01/examples/sapvirtualinstances/SAPDatabaseInstances_StopInstance.json
            // this example is just showing the usage of "SAPDatabaseInstances_StopInstance" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SapDatabaseInstanceResource created on azure
            // for more information of creating SapDatabaseInstanceResource, please refer to the document of SapDatabaseInstanceResource
            string subscriptionId = "8e17e36c-42e9-4cd5-a078-7b44883414e0";
            string resourceGroupName = "test-rg";
            string sapVirtualInstanceName = "X00";
            string databaseInstanceName = "db0";
            ResourceIdentifier sapDatabaseInstanceResourceId = SapDatabaseInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sapVirtualInstanceName, databaseInstanceName);
            SapDatabaseInstanceResource sapDatabaseInstance = client.GetSapDatabaseInstanceResource(sapDatabaseInstanceResourceId);

            // invoke the operation
            SapStopContent content = new SapStopContent()
            {
                SoftStopTimeoutSeconds = 0,
            };
            ArmOperation<OperationStatusResult> lro = await sapDatabaseInstance.StopInstanceAsync(WaitUntil.Completed, content: content);
            OperationStatusResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
