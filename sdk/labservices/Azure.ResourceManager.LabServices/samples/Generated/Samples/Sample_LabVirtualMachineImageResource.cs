// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.LabServices;
using Azure.ResourceManager.LabServices.Models;

namespace Azure.ResourceManager.LabServices.Samples
{
    public partial class Sample_LabVirtualMachineImageResource
    {
        // getImage
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetImage()
        {
            // Generated from example definition: specification/labservices/resource-manager/Microsoft.LabServices/stable/2022-08-01/examples/Images/getImage.json
            // this example is just showing the usage of "Images_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LabVirtualMachineImageResource created on azure
            // for more information of creating LabVirtualMachineImageResource, please refer to the document of LabVirtualMachineImageResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string labPlanName = "testlabplan";
            string imageName = "image1";
            ResourceIdentifier labVirtualMachineImageResourceId = LabVirtualMachineImageResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, labPlanName, imageName);
            LabVirtualMachineImageResource labVirtualMachineImage = client.GetLabVirtualMachineImageResource(labVirtualMachineImageResourceId);

            // invoke the operation
            LabVirtualMachineImageResource result = await labVirtualMachineImage.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LabVirtualMachineImageData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // patchImage
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_PatchImage()
        {
            // Generated from example definition: specification/labservices/resource-manager/Microsoft.LabServices/stable/2022-08-01/examples/Images/patchImage.json
            // this example is just showing the usage of "Images_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LabVirtualMachineImageResource created on azure
            // for more information of creating LabVirtualMachineImageResource, please refer to the document of LabVirtualMachineImageResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string labPlanName = "testlabplan";
            string imageName = "image1";
            ResourceIdentifier labVirtualMachineImageResourceId = LabVirtualMachineImageResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, labPlanName, imageName);
            LabVirtualMachineImageResource labVirtualMachineImage = client.GetLabVirtualMachineImageResource(labVirtualMachineImageResourceId);

            // invoke the operation
            LabVirtualMachineImagePatch patch = new LabVirtualMachineImagePatch()
            {
                EnabledState = LabServicesEnableState.Enabled,
            };
            LabVirtualMachineImageResource result = await labVirtualMachineImage.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LabVirtualMachineImageData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
