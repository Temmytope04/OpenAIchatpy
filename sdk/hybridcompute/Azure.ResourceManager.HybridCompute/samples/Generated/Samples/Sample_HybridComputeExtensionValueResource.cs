// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.HybridCompute.Samples
{
    public partial class Sample_HybridComputeExtensionValueResource
    {
        // GET an extensions metadata
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GETAnExtensionsMetadata()
        {
            // Generated from example definition: specification/hybridcompute/resource-manager/Microsoft.HybridCompute/preview/2023-10-03-preview/examples/extension/ExtensionMetadata_Get.json
            // this example is just showing the usage of "ExtensionMetadata_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HybridComputeExtensionValueResource created on azure
            // for more information of creating HybridComputeExtensionValueResource, please refer to the document of HybridComputeExtensionValueResource
            string subscriptionId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx";
            AzureLocation location = new AzureLocation("EastUS");
            string publisher = "microsoft.azure.monitor";
            string extensionType = "azuremonitorlinuxagent";
            string version = "1.9.1";
            ResourceIdentifier hybridComputeExtensionValueResourceId = HybridComputeExtensionValueResource.CreateResourceIdentifier(subscriptionId, location, publisher, extensionType, version);
            HybridComputeExtensionValueResource hybridComputeExtensionValue = client.GetHybridComputeExtensionValueResource(hybridComputeExtensionValueResourceId);

            // invoke the operation
            HybridComputeExtensionValueResource result = await hybridComputeExtensionValue.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HybridComputeExtensionValueData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
