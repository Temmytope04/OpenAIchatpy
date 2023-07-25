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
using Azure.ResourceManager.Grafana;

namespace Azure.ResourceManager.Grafana.Samples
{
    public partial class Sample_GrafanaPrivateEndpointConnectionResource
    {
        // PrivateEndpointConnections_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_PrivateEndpointConnectionsGet()
        {
            // Generated from example definition: specification/dashboard/resource-manager/Microsoft.Dashboard/stable/2022-08-01/examples/PrivateEndpointConnections_Get.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GrafanaPrivateEndpointConnectionResource created on azure
            // for more information of creating GrafanaPrivateEndpointConnectionResource, please refer to the document of GrafanaPrivateEndpointConnectionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string workspaceName = "myWorkspace";
            string privateEndpointConnectionName = "myConnection";
            ResourceIdentifier grafanaPrivateEndpointConnectionResourceId = GrafanaPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, privateEndpointConnectionName);
            GrafanaPrivateEndpointConnectionResource grafanaPrivateEndpointConnection = client.GetGrafanaPrivateEndpointConnectionResource(grafanaPrivateEndpointConnectionResourceId);

            // invoke the operation
            GrafanaPrivateEndpointConnectionResource result = await grafanaPrivateEndpointConnection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GrafanaPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PrivateEndpointConnections_Approve
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_PrivateEndpointConnectionsApprove()
        {
            // Generated from example definition: specification/dashboard/resource-manager/Microsoft.Dashboard/stable/2022-08-01/examples/PrivateEndpointConnections_Approve.json
            // this example is just showing the usage of "PrivateEndpointConnections_Approve" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GrafanaPrivateEndpointConnectionResource created on azure
            // for more information of creating GrafanaPrivateEndpointConnectionResource, please refer to the document of GrafanaPrivateEndpointConnectionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string workspaceName = "myWorkspace";
            string privateEndpointConnectionName = "myConnection";
            ResourceIdentifier grafanaPrivateEndpointConnectionResourceId = GrafanaPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, privateEndpointConnectionName);
            GrafanaPrivateEndpointConnectionResource grafanaPrivateEndpointConnection = client.GetGrafanaPrivateEndpointConnectionResource(grafanaPrivateEndpointConnectionResourceId);

            // invoke the operation
            GrafanaPrivateEndpointConnectionData data = new GrafanaPrivateEndpointConnectionData();
            ArmOperation<GrafanaPrivateEndpointConnectionResource> lro = await grafanaPrivateEndpointConnection.UpdateAsync(WaitUntil.Completed, data);
            GrafanaPrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GrafanaPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PrivateEndpointConnections_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_PrivateEndpointConnectionsDelete()
        {
            // Generated from example definition: specification/dashboard/resource-manager/Microsoft.Dashboard/stable/2022-08-01/examples/PrivateEndpointConnections_Delete.json
            // this example is just showing the usage of "PrivateEndpointConnections_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GrafanaPrivateEndpointConnectionResource created on azure
            // for more information of creating GrafanaPrivateEndpointConnectionResource, please refer to the document of GrafanaPrivateEndpointConnectionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string workspaceName = "myWorkspace";
            string privateEndpointConnectionName = "myConnection";
            ResourceIdentifier grafanaPrivateEndpointConnectionResourceId = GrafanaPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, privateEndpointConnectionName);
            GrafanaPrivateEndpointConnectionResource grafanaPrivateEndpointConnection = client.GetGrafanaPrivateEndpointConnectionResource(grafanaPrivateEndpointConnectionResourceId);

            // invoke the operation
            await grafanaPrivateEndpointConnection.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
