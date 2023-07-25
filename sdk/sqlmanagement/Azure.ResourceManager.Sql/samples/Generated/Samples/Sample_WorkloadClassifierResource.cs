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

namespace Azure.ResourceManager.Sql.Samples
{
    public partial class Sample_WorkloadClassifierResource
    {
        // Gets a workload classifier for a data warehouse
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetsAWorkloadClassifierForADataWarehouse()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/GetWorkloadClassifier.json
            // this example is just showing the usage of "WorkloadClassifiers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadClassifierResource created on azure
            // for more information of creating WorkloadClassifierResource, please refer to the document of WorkloadClassifierResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default-SQL-SouthEastAsia";
            string serverName = "testsvr";
            string databaseName = "testdb";
            string workloadGroupName = "wlm_workloadgroup";
            string workloadClassifierName = "wlm_classifier";
            ResourceIdentifier workloadClassifierResourceId = WorkloadClassifierResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName, workloadGroupName, workloadClassifierName);
            WorkloadClassifierResource workloadClassifier = client.GetWorkloadClassifierResource(workloadClassifierResourceId);

            // invoke the operation
            WorkloadClassifierResource result = await workloadClassifier.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WorkloadClassifierData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create a workload group with all properties specified.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateAWorkloadGroupWithAllPropertiesSpecified()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/CreateOrUpdateWorkloadClassifierMax.json
            // this example is just showing the usage of "WorkloadClassifiers_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadClassifierResource created on azure
            // for more information of creating WorkloadClassifierResource, please refer to the document of WorkloadClassifierResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default-SQL-SouthEastAsia";
            string serverName = "testsvr";
            string databaseName = "testdb";
            string workloadGroupName = "wlm_workloadgroup";
            string workloadClassifierName = "wlm_workloadclassifier";
            ResourceIdentifier workloadClassifierResourceId = WorkloadClassifierResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName, workloadGroupName, workloadClassifierName);
            WorkloadClassifierResource workloadClassifier = client.GetWorkloadClassifierResource(workloadClassifierResourceId);

            // invoke the operation
            WorkloadClassifierData data = new WorkloadClassifierData()
            {
                MemberName = "dbo",
                Label = "test_label",
                Context = "test_context",
                StartTime = "12:00",
                EndTime = "14:00",
                Importance = "high",
            };
            ArmOperation<WorkloadClassifierResource> lro = await workloadClassifier.UpdateAsync(WaitUntil.Completed, data);
            WorkloadClassifierResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WorkloadClassifierData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create a workload group with the required properties specified.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateAWorkloadGroupWithTheRequiredPropertiesSpecified()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/CreateOrUpdateWorkloadClassifierMin.json
            // this example is just showing the usage of "WorkloadClassifiers_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadClassifierResource created on azure
            // for more information of creating WorkloadClassifierResource, please refer to the document of WorkloadClassifierResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default-SQL-SouthEastAsia";
            string serverName = "testsvr";
            string databaseName = "testdb";
            string workloadGroupName = "wlm_workloadgroup";
            string workloadClassifierName = "wlm_workloadclassifier";
            ResourceIdentifier workloadClassifierResourceId = WorkloadClassifierResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName, workloadGroupName, workloadClassifierName);
            WorkloadClassifierResource workloadClassifier = client.GetWorkloadClassifierResource(workloadClassifierResourceId);

            // invoke the operation
            WorkloadClassifierData data = new WorkloadClassifierData()
            {
                MemberName = "dbo",
            };
            ArmOperation<WorkloadClassifierResource> lro = await workloadClassifier.UpdateAsync(WaitUntil.Completed, data);
            WorkloadClassifierResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WorkloadClassifierData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete a workload classifier
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteAWorkloadClassifier()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/DeleteWorkloadClassifier.json
            // this example is just showing the usage of "WorkloadClassifiers_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadClassifierResource created on azure
            // for more information of creating WorkloadClassifierResource, please refer to the document of WorkloadClassifierResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default-SQL-SouthEastAsia";
            string serverName = "testsvr";
            string databaseName = "testdb";
            string workloadGroupName = "wlm_workloadgroup";
            string workloadClassifierName = "wlm_workloadclassifier";
            ResourceIdentifier workloadClassifierResourceId = WorkloadClassifierResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName, workloadGroupName, workloadClassifierName);
            WorkloadClassifierResource workloadClassifier = client.GetWorkloadClassifierResource(workloadClassifierResourceId);

            // invoke the operation
            await workloadClassifier.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
