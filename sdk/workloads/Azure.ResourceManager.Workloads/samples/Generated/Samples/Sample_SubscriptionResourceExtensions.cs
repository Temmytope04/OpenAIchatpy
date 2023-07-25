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
using Azure.ResourceManager.Workloads;
using Azure.ResourceManager.Workloads.Models;

namespace Azure.ResourceManager.Workloads.Samples
{
    public partial class Sample_SubscriptionResourceExtensions
    {
        // SAPSizingRecommendations_S4HANA_Distributed
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task SapSizingRecommendations_SAPSizingRecommendationsS4HANADistributed()
        {
            // Generated from example definition: specification/workloads/resource-manager/Microsoft.Workloads/stable/2023-04-01/examples/sapvirtualinstances/SAPSizingRecommendations_S4HANA_Distributed.json
            // this example is just showing the usage of "SAPSizingRecommendations" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "8e17e36c-42e9-4cd5-a078-7b44883414e0";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            AzureLocation location = new AzureLocation("centralus");
            SapSizingRecommendationResult result = await subscriptionResource.SapSizingRecommendationsAsync(location);

            Console.WriteLine($"Succeeded: {result}");
        }

        // SAPSizingRecommendations_S4HANA_DistributedHA_AvSet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task SapSizingRecommendations_SAPSizingRecommendationsS4HANADistributedHAAvSet()
        {
            // Generated from example definition: specification/workloads/resource-manager/Microsoft.Workloads/stable/2023-04-01/examples/sapvirtualinstances/SAPSizingRecommendations_S4HANA_HA_AvSet.json
            // this example is just showing the usage of "SAPSizingRecommendations" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "8e17e36c-42e9-4cd5-a078-7b44883414e0";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            AzureLocation location = new AzureLocation("centralus");
            SapSizingRecommendationResult result = await subscriptionResource.SapSizingRecommendationsAsync(location);

            Console.WriteLine($"Succeeded: {result}");
        }

        // SAPSizingRecommendations_S4HANA_DistributedHA_AvZone
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task SapSizingRecommendations_SAPSizingRecommendationsS4HANADistributedHAAvZone()
        {
            // Generated from example definition: specification/workloads/resource-manager/Microsoft.Workloads/stable/2023-04-01/examples/sapvirtualinstances/SAPSizingRecommendations_S4HANA_HA_AvZone.json
            // this example is just showing the usage of "SAPSizingRecommendations" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "8e17e36c-42e9-4cd5-a078-7b44883414e0";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            AzureLocation location = new AzureLocation("centralus");
            SapSizingRecommendationResult result = await subscriptionResource.SapSizingRecommendationsAsync(location);

            Console.WriteLine($"Succeeded: {result}");
        }

        // SAPSizingRecommendations_S4HANA_SingleServer
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task SapSizingRecommendations_SAPSizingRecommendationsS4HANASingleServer()
        {
            // Generated from example definition: specification/workloads/resource-manager/Microsoft.Workloads/stable/2023-04-01/examples/sapvirtualinstances/SAPSizingRecommendations_S4HANA_SingleServer.json
            // this example is just showing the usage of "SAPSizingRecommendations" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "8e17e36c-42e9-4cd5-a078-7b44883414e0";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            AzureLocation location = new AzureLocation("centralus");
            SapSizingRecommendationResult result = await subscriptionResource.SapSizingRecommendationsAsync(location);

            Console.WriteLine($"Succeeded: {result}");
        }

        // SAPSupportedSkus_Distributed
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task SapSupportedSku_SAPSupportedSkusDistributed()
        {
            // Generated from example definition: specification/workloads/resource-manager/Microsoft.Workloads/stable/2023-04-01/examples/sapvirtualinstances/SAPSupportedSkus_Distributed.json
            // this example is just showing the usage of "SAPSupportedSku" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "8e17e36c-42e9-4cd5-a078-7b44883414e0";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            AzureLocation location = new AzureLocation("centralus");
            SapSupportedResourceSkusResult result = await subscriptionResource.SapSupportedSkuAsync(location);

            Console.WriteLine($"Succeeded: {result}");
        }

        // SAPSupportedSkus_DistributedHA_AvSet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task SapSupportedSku_SAPSupportedSkusDistributedHAAvSet()
        {
            // Generated from example definition: specification/workloads/resource-manager/Microsoft.Workloads/stable/2023-04-01/examples/sapvirtualinstances/SAPSupportedSkus_DistributedHA_AvSet.json
            // this example is just showing the usage of "SAPSupportedSku" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "8e17e36c-42e9-4cd5-a078-7b44883414e0";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            AzureLocation location = new AzureLocation("centralus");
            SapSupportedResourceSkusResult result = await subscriptionResource.SapSupportedSkuAsync(location);

            Console.WriteLine($"Succeeded: {result}");
        }

        // SAPSupportedSkus_DistributedHA_AvZone
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task SapSupportedSku_SAPSupportedSkusDistributedHAAvZone()
        {
            // Generated from example definition: specification/workloads/resource-manager/Microsoft.Workloads/stable/2023-04-01/examples/sapvirtualinstances/SAPSupportedSkus_DistributedHA_AvZone.json
            // this example is just showing the usage of "SAPSupportedSku" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "8e17e36c-42e9-4cd5-a078-7b44883414e0";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            AzureLocation location = new AzureLocation("centralus");
            SapSupportedResourceSkusResult result = await subscriptionResource.SapSupportedSkuAsync(location);

            Console.WriteLine($"Succeeded: {result}");
        }

        // SAPSupportedSkus_SingleServer
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task SapSupportedSku_SAPSupportedSkusSingleServer()
        {
            // Generated from example definition: specification/workloads/resource-manager/Microsoft.Workloads/stable/2023-04-01/examples/sapvirtualinstances/SAPSupportedSkus_SingleServer.json
            // this example is just showing the usage of "SAPSupportedSku" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "8e17e36c-42e9-4cd5-a078-7b44883414e0";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            AzureLocation location = new AzureLocation("centralus");
            SapSupportedResourceSkusResult result = await subscriptionResource.SapSupportedSkuAsync(location);

            Console.WriteLine($"Succeeded: {result}");
        }

        // SAPDiskConfigurations_NonProd
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task SapDiskConfigurations_SAPDiskConfigurationsNonProd()
        {
            // Generated from example definition: specification/workloads/resource-manager/Microsoft.Workloads/stable/2023-04-01/examples/sapvirtualinstances/SAPDiskConfigurations_NonProd.json
            // this example is just showing the usage of "SAPDiskConfigurations" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "8e17e36c-42e9-4cd5-a078-7b44883414e0";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            AzureLocation location = new AzureLocation("centralus");
            SapDiskConfigurationsResult result = await subscriptionResource.SapDiskConfigurationsAsync(location);

            Console.WriteLine($"Succeeded: {result}");
        }

        // SAPDiskConfigurations_Prod
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task SapDiskConfigurations_SAPDiskConfigurationsProd()
        {
            // Generated from example definition: specification/workloads/resource-manager/Microsoft.Workloads/stable/2023-04-01/examples/sapvirtualinstances/SAPDiskConfigurations_Prod.json
            // this example is just showing the usage of "SAPDiskConfigurations" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "8e17e36c-42e9-4cd5-a078-7b44883414e0";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            AzureLocation location = new AzureLocation("centralus");
            SapDiskConfigurationsResult result = await subscriptionResource.SapDiskConfigurationsAsync(location);

            Console.WriteLine($"Succeeded: {result}");
        }

        // SAPAvailabilityZoneDetails_eastus
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task SapAvailabilityZoneDetails_SAPAvailabilityZoneDetailsEastus()
        {
            // Generated from example definition: specification/workloads/resource-manager/Microsoft.Workloads/stable/2023-04-01/examples/sapvirtualinstances/SAPAvailabilityZoneDetails_eastus.json
            // this example is just showing the usage of "SAPAvailabilityZoneDetails" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "8e17e36c-42e9-4cd5-a078-7b44883414e0";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            AzureLocation location = new AzureLocation("centralus");
            SapAvailabilityZoneDetailsResult result = await subscriptionResource.SapAvailabilityZoneDetailsAsync(location);

            Console.WriteLine($"Succeeded: {result}");
        }

        // SAPAvailabilityZoneDetails_northeurope
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task SapAvailabilityZoneDetails_SAPAvailabilityZoneDetailsNortheurope()
        {
            // Generated from example definition: specification/workloads/resource-manager/Microsoft.Workloads/stable/2023-04-01/examples/sapvirtualinstances/SAPAvailabilityZoneDetails_northeurope.json
            // this example is just showing the usage of "SAPAvailabilityZoneDetails" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "8e17e36c-42e9-4cd5-a078-7b44883414e0";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            AzureLocation location = new AzureLocation("centralus");
            SapAvailabilityZoneDetailsResult result = await subscriptionResource.SapAvailabilityZoneDetailsAsync(location);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
