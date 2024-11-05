// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Nginx.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Nginx.Samples
{
    public partial class Sample_NginxConfigurationResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ConfigurationsGet()
        {
            // Generated from example definition: specification/nginx/resource-manager/NGINX.NGINXPLUS/preview/2024-06-01-preview/examples/Configurations_Get.json
            // this example is just showing the usage of "Configurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NginxConfigurationResource created on azure
            // for more information of creating NginxConfigurationResource, please refer to the document of NginxConfigurationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string deploymentName = "myDeployment";
            string configurationName = "default";
            ResourceIdentifier nginxConfigurationResourceId = NginxConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, deploymentName, configurationName);
            NginxConfigurationResource nginxConfiguration = client.GetNginxConfigurationResource(nginxConfigurationResourceId);

            // invoke the operation
            NginxConfigurationResource result = await nginxConfiguration.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NginxConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_ConfigurationsDelete()
        {
            // Generated from example definition: specification/nginx/resource-manager/NGINX.NGINXPLUS/preview/2024-06-01-preview/examples/Configurations_Delete.json
            // this example is just showing the usage of "Configurations_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NginxConfigurationResource created on azure
            // for more information of creating NginxConfigurationResource, please refer to the document of NginxConfigurationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string deploymentName = "myDeployment";
            string configurationName = "default";
            ResourceIdentifier nginxConfigurationResourceId = NginxConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, deploymentName, configurationName);
            NginxConfigurationResource nginxConfiguration = client.GetNginxConfigurationResource(nginxConfigurationResourceId);

            // invoke the operation
            await nginxConfiguration.DeleteAsync(WaitUntil.Completed).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_ConfigurationsCreateOrUpdate()
        {
            // Generated from example definition: specification/nginx/resource-manager/NGINX.NGINXPLUS/preview/2024-06-01-preview/examples/Configurations_CreateOrUpdate.json
            // this example is just showing the usage of "Configurations_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NginxConfigurationResource created on azure
            // for more information of creating NginxConfigurationResource, please refer to the document of NginxConfigurationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string deploymentName = "myDeployment";
            string configurationName = "default";
            ResourceIdentifier nginxConfigurationResourceId = NginxConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, deploymentName, configurationName);
            NginxConfigurationResource nginxConfiguration = client.GetNginxConfigurationResource(nginxConfigurationResourceId);

            // invoke the operation
            NginxConfigurationData data = new NginxConfigurationData();
            ArmOperation<NginxConfigurationResource> lro = await nginxConfiguration.UpdateAsync(WaitUntil.Completed, data);
            NginxConfigurationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NginxConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Analysis_ConfigurationsAnalysis()
        {
            // Generated from example definition: specification/nginx/resource-manager/NGINX.NGINXPLUS/preview/2024-06-01-preview/examples/Configurations_Analysis.json
            // this example is just showing the usage of "Configurations_Analysis" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NginxConfigurationResource created on azure
            // for more information of creating NginxConfigurationResource, please refer to the document of NginxConfigurationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string deploymentName = "myDeployment";
            string configurationName = "default";
            ResourceIdentifier nginxConfigurationResourceId = NginxConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, deploymentName, configurationName);
            NginxConfigurationResource nginxConfiguration = client.GetNginxConfigurationResource(nginxConfigurationResourceId);

            // invoke the operation
            NginxAnalysisResult result = await nginxConfiguration.AnalysisAsync();

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
