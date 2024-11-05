// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.OperationalInsights.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.OperationalInsights.Samples
{
    public partial class Sample_OperationalInsightsClusterResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ClustersGet()
        {
            // Generated from example definition: specification/operationalinsights/resource-manager/Microsoft.OperationalInsights/stable/2021-06-01/examples/ClustersGet.json
            // this example is just showing the usage of "Clusters_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OperationalInsightsClusterResource created on azure
            // for more information of creating OperationalInsightsClusterResource, please refer to the document of OperationalInsightsClusterResource
            string subscriptionId = "00000000-0000-0000-0000-00000000000";
            string resourceGroupName = "oiautorest6685";
            string clusterName = "oiautorest6685";
            ResourceIdentifier operationalInsightsClusterResourceId = OperationalInsightsClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            OperationalInsightsClusterResource operationalInsightsCluster = client.GetOperationalInsightsClusterResource(operationalInsightsClusterResourceId);

            // invoke the operation
            OperationalInsightsClusterResource result = await operationalInsightsCluster.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            OperationalInsightsClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_ClustersDelete()
        {
            // Generated from example definition: specification/operationalinsights/resource-manager/Microsoft.OperationalInsights/stable/2021-06-01/examples/ClustersDelete.json
            // this example is just showing the usage of "Clusters_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OperationalInsightsClusterResource created on azure
            // for more information of creating OperationalInsightsClusterResource, please refer to the document of OperationalInsightsClusterResource
            string subscriptionId = "00000000-0000-0000-0000-00000000000";
            string resourceGroupName = "oiautorest6685";
            string clusterName = "oiautorest6685";
            ResourceIdentifier operationalInsightsClusterResourceId = OperationalInsightsClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            OperationalInsightsClusterResource operationalInsightsCluster = client.GetOperationalInsightsClusterResource(operationalInsightsClusterResourceId);

            // invoke the operation
            await operationalInsightsCluster.DeleteAsync(WaitUntil.Completed).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_ClustersPatch()
        {
            // Generated from example definition: specification/operationalinsights/resource-manager/Microsoft.OperationalInsights/stable/2021-06-01/examples/ClustersUpdate.json
            // this example is just showing the usage of "Clusters_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OperationalInsightsClusterResource created on azure
            // for more information of creating OperationalInsightsClusterResource, please refer to the document of OperationalInsightsClusterResource
            string subscriptionId = "00000000-0000-0000-0000-00000000000";
            string resourceGroupName = "oiautorest6685";
            string clusterName = "oiautorest6685";
            ResourceIdentifier operationalInsightsClusterResourceId = OperationalInsightsClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            OperationalInsightsClusterResource operationalInsightsCluster = client.GetOperationalInsightsClusterResource(operationalInsightsClusterResourceId);

            // invoke the operation
            OperationalInsightsClusterPatch patch = new OperationalInsightsClusterPatch
            {
                Identity = new ManagedServiceIdentity(default)
                {
                    UserAssignedIdentities =
{
[new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-00000000000/resourcegroups/oiautorest6685/providers/Microsoft.ManagedIdentity/userAssignedIdentities/myidentity")] = null
},
                },
                Sku = new OperationalInsightsClusterSku
                {
                    Capacity = OperationalInsightsClusterCapacity.TenHundred,
                    Name = OperationalInsightsClusterSkuName.CapacityReservation,
                },
                Tags =
{
["tag1"] = "val1"
},
                KeyVaultProperties = new OperationalInsightsKeyVaultProperties
                {
                    KeyVaultUri = new Uri("https://aztest2170.vault.azure.net"),
                    KeyName = "aztest2170cert",
                    KeyVersion = "654ft6c4e63845cbb50fd6fg51540429",
                    KeyRsaSize = 1024,
                },
            };
            ArmOperation<OperationalInsightsClusterResource> lro = await operationalInsightsCluster.UpdateAsync(WaitUntil.Completed, patch);
            OperationalInsightsClusterResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            OperationalInsightsClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
