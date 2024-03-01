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
using Azure.ResourceManager.Compute;

namespace Azure.ResourceManager.Compute.Samples
{
    public partial class Sample_SharedGalleryImageCollection
    {
        // List shared gallery images.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListSharedGalleryImages()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/GalleryRP/stable/2023-07-03/examples/sharedGalleryExamples/SharedGalleryImages_List.json
            // this example is just showing the usage of "SharedGalleryImages_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SharedGalleryResource created on azure
            // for more information of creating SharedGalleryResource, please refer to the document of SharedGalleryResource
            string subscriptionId = "{subscription-id}";
            AzureLocation location = new AzureLocation("myLocation");
            string galleryUniqueName = "galleryUniqueName";
            ResourceIdentifier sharedGalleryResourceId = SharedGalleryResource.CreateResourceIdentifier(subscriptionId, location, galleryUniqueName);
            SharedGalleryResource sharedGallery = client.GetSharedGalleryResource(sharedGalleryResourceId);

            // get the collection of this SharedGalleryImageResource
            SharedGalleryImageCollection collection = sharedGallery.GetSharedGalleryImages();

            // invoke the operation and iterate over the result
            await foreach (SharedGalleryImageResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SharedGalleryImageData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get a shared gallery image.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetASharedGalleryImage()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/GalleryRP/stable/2023-07-03/examples/sharedGalleryExamples/SharedGalleryImage_Get.json
            // this example is just showing the usage of "SharedGalleryImages_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SharedGalleryResource created on azure
            // for more information of creating SharedGalleryResource, please refer to the document of SharedGalleryResource
            string subscriptionId = "{subscription-id}";
            AzureLocation location = new AzureLocation("myLocation");
            string galleryUniqueName = "galleryUniqueName";
            ResourceIdentifier sharedGalleryResourceId = SharedGalleryResource.CreateResourceIdentifier(subscriptionId, location, galleryUniqueName);
            SharedGalleryResource sharedGallery = client.GetSharedGalleryResource(sharedGalleryResourceId);

            // get the collection of this SharedGalleryImageResource
            SharedGalleryImageCollection collection = sharedGallery.GetSharedGalleryImages();

            // invoke the operation
            string galleryImageName = "myGalleryImageName";
            SharedGalleryImageResource result = await collection.GetAsync(galleryImageName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SharedGalleryImageData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a shared gallery image.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetASharedGalleryImage()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/GalleryRP/stable/2023-07-03/examples/sharedGalleryExamples/SharedGalleryImage_Get.json
            // this example is just showing the usage of "SharedGalleryImages_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SharedGalleryResource created on azure
            // for more information of creating SharedGalleryResource, please refer to the document of SharedGalleryResource
            string subscriptionId = "{subscription-id}";
            AzureLocation location = new AzureLocation("myLocation");
            string galleryUniqueName = "galleryUniqueName";
            ResourceIdentifier sharedGalleryResourceId = SharedGalleryResource.CreateResourceIdentifier(subscriptionId, location, galleryUniqueName);
            SharedGalleryResource sharedGallery = client.GetSharedGalleryResource(sharedGalleryResourceId);

            // get the collection of this SharedGalleryImageResource
            SharedGalleryImageCollection collection = sharedGallery.GetSharedGalleryImages();

            // invoke the operation
            string galleryImageName = "myGalleryImageName";
            bool result = await collection.ExistsAsync(galleryImageName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get a shared gallery image.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetASharedGalleryImage()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/GalleryRP/stable/2023-07-03/examples/sharedGalleryExamples/SharedGalleryImage_Get.json
            // this example is just showing the usage of "SharedGalleryImages_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SharedGalleryResource created on azure
            // for more information of creating SharedGalleryResource, please refer to the document of SharedGalleryResource
            string subscriptionId = "{subscription-id}";
            AzureLocation location = new AzureLocation("myLocation");
            string galleryUniqueName = "galleryUniqueName";
            ResourceIdentifier sharedGalleryResourceId = SharedGalleryResource.CreateResourceIdentifier(subscriptionId, location, galleryUniqueName);
            SharedGalleryResource sharedGallery = client.GetSharedGalleryResource(sharedGalleryResourceId);

            // get the collection of this SharedGalleryImageResource
            SharedGalleryImageCollection collection = sharedGallery.GetSharedGalleryImages();

            // invoke the operation
            string galleryImageName = "myGalleryImageName";
            NullableResponse<SharedGalleryImageResource> response = await collection.GetIfExistsAsync(galleryImageName);
            SharedGalleryImageResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SharedGalleryImageData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
