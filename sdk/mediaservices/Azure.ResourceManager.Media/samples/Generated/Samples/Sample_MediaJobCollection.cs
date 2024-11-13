// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Media.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Media.Samples
{
    public partial class Sample_MediaJobCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateAJob()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Encoding/stable/2022-07-01/examples/jobs-create.json
            // this example is just showing the usage of "Jobs_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaTransformResource created on azure
            // for more information of creating MediaTransformResource, please refer to the document of MediaTransformResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosoresources";
            string accountName = "contosomedia";
            string transformName = "exampleTransform";
            ResourceIdentifier mediaTransformResourceId = MediaTransformResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, transformName);
            MediaTransformResource mediaTransform = client.GetMediaTransformResource(mediaTransformResourceId);

            // get the collection of this MediaJobResource
            MediaJobCollection collection = mediaTransform.GetMediaJobs();

            // invoke the operation
            string jobName = "job1";
            MediaJobData data = new MediaJobData
            {
                Input = new MediaJobInputAsset("job1-InputAsset"),
                Outputs = { new MediaJobOutputAsset("job1-OutputAsset") },
                CorrelationData =
{
["Key 2"] = "Value 2",
["key1"] = "value1"
},
            };
            ArmOperation<MediaJobResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, jobName, data);
            MediaJobResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MediaJobData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAJobByName()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Encoding/stable/2022-07-01/examples/jobs-get-by-name.json
            // this example is just showing the usage of "Jobs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaTransformResource created on azure
            // for more information of creating MediaTransformResource, please refer to the document of MediaTransformResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosoresources";
            string accountName = "contosomedia";
            string transformName = "exampleTransform";
            ResourceIdentifier mediaTransformResourceId = MediaTransformResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, transformName);
            MediaTransformResource mediaTransform = client.GetMediaTransformResource(mediaTransformResourceId);

            // get the collection of this MediaJobResource
            MediaJobCollection collection = mediaTransform.GetMediaJobs();

            // invoke the operation
            string jobName = "job1";
            MediaJobResource result = await collection.GetAsync(jobName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MediaJobData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListsJobsForTheTransformFilterByCreated()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Encoding/stable/2022-07-01/examples/jobs-list-all-filter-by-created.json
            // this example is just showing the usage of "Jobs_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaTransformResource created on azure
            // for more information of creating MediaTransformResource, please refer to the document of MediaTransformResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosoresources";
            string accountName = "contosomedia";
            string transformName = "exampleTransform";
            ResourceIdentifier mediaTransformResourceId = MediaTransformResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, transformName);
            MediaTransformResource mediaTransform = client.GetMediaTransformResource(mediaTransformResourceId);

            // get the collection of this MediaJobResource
            MediaJobCollection collection = mediaTransform.GetMediaJobs();

            // invoke the operation and iterate over the result
            string filter = "properties/created ge 2021-06-01T00:00:10.0000000Z and properties/created le 2021-06-01T00:00:20.0000000Z";
            string orderby = "properties/created";
            await foreach (MediaJobResource item in collection.GetAllAsync(filter: filter, orderby: orderby))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MediaJobData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListsJobsForTheTransformFilterByLastmodified()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Encoding/stable/2022-07-01/examples/jobs-list-all-filter-by-lastmodified.json
            // this example is just showing the usage of "Jobs_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaTransformResource created on azure
            // for more information of creating MediaTransformResource, please refer to the document of MediaTransformResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosoresources";
            string accountName = "contosomedia";
            string transformName = "exampleTransform";
            ResourceIdentifier mediaTransformResourceId = MediaTransformResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, transformName);
            MediaTransformResource mediaTransform = client.GetMediaTransformResource(mediaTransformResourceId);

            // get the collection of this MediaJobResource
            MediaJobCollection collection = mediaTransform.GetMediaJobs();

            // invoke the operation and iterate over the result
            string filter = "properties/lastmodified ge 2021-06-01T00:00:10.0000000Z and properties/lastmodified le 2021-06-01T00:00:20.0000000Z";
            string orderby = "properties/lastmodified desc";
            await foreach (MediaJobResource item in collection.GetAllAsync(filter: filter, orderby: orderby))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MediaJobData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListsJobsForTheTransformFilterByNameAndState()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Encoding/stable/2022-07-01/examples/jobs-list-all-filter-by-name-and-state.json
            // this example is just showing the usage of "Jobs_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaTransformResource created on azure
            // for more information of creating MediaTransformResource, please refer to the document of MediaTransformResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosoresources";
            string accountName = "contosomedia";
            string transformName = "exampleTransform";
            ResourceIdentifier mediaTransformResourceId = MediaTransformResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, transformName);
            MediaTransformResource mediaTransform = client.GetMediaTransformResource(mediaTransformResourceId);

            // get the collection of this MediaJobResource
            MediaJobCollection collection = mediaTransform.GetMediaJobs();

            // invoke the operation and iterate over the result
            string filter = "name eq 'job3' and properties/state eq Microsoft.Media.JobState'finished'";
            await foreach (MediaJobResource item in collection.GetAllAsync(filter: filter))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MediaJobData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListsJobsForTheTransformFilterByName()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Encoding/stable/2022-07-01/examples/jobs-list-all-filter-by-name.json
            // this example is just showing the usage of "Jobs_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaTransformResource created on azure
            // for more information of creating MediaTransformResource, please refer to the document of MediaTransformResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosoresources";
            string accountName = "contosomedia";
            string transformName = "exampleTransform";
            ResourceIdentifier mediaTransformResourceId = MediaTransformResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, transformName);
            MediaTransformResource mediaTransform = client.GetMediaTransformResource(mediaTransformResourceId);

            // get the collection of this MediaJobResource
            MediaJobCollection collection = mediaTransform.GetMediaJobs();

            // invoke the operation and iterate over the result
            string filter = "name eq 'job1' or name eq 'job2'";
            string orderby = "name";
            await foreach (MediaJobResource item in collection.GetAllAsync(filter: filter, orderby: orderby))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MediaJobData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListsJobsForTheTransformFilterByStateEqual()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Encoding/stable/2022-07-01/examples/jobs-list-all-filter-by-state-eq.json
            // this example is just showing the usage of "Jobs_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaTransformResource created on azure
            // for more information of creating MediaTransformResource, please refer to the document of MediaTransformResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosoresources";
            string accountName = "contosomedia";
            string transformName = "exampleTransform";
            ResourceIdentifier mediaTransformResourceId = MediaTransformResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, transformName);
            MediaTransformResource mediaTransform = client.GetMediaTransformResource(mediaTransformResourceId);

            // get the collection of this MediaJobResource
            MediaJobCollection collection = mediaTransform.GetMediaJobs();

            // invoke the operation and iterate over the result
            string filter = "properties/state eq Microsoft.Media.JobState'Processing'";
            await foreach (MediaJobResource item in collection.GetAllAsync(filter: filter))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MediaJobData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListsJobsForTheTransformFilterByStateNotEqual()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Encoding/stable/2022-07-01/examples/jobs-list-all-filter-by-state-ne.json
            // this example is just showing the usage of "Jobs_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaTransformResource created on azure
            // for more information of creating MediaTransformResource, please refer to the document of MediaTransformResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosoresources";
            string accountName = "contosomedia";
            string transformName = "exampleTransform";
            ResourceIdentifier mediaTransformResourceId = MediaTransformResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, transformName);
            MediaTransformResource mediaTransform = client.GetMediaTransformResource(mediaTransformResourceId);

            // get the collection of this MediaJobResource
            MediaJobCollection collection = mediaTransform.GetMediaJobs();

            // invoke the operation and iterate over the result
            string filter = "properties/state ne Microsoft.Media.JobState'processing'";
            await foreach (MediaJobResource item in collection.GetAllAsync(filter: filter))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MediaJobData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListsAllOfTheJobsForTheTransform()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Encoding/stable/2022-07-01/examples/jobs-list-all.json
            // this example is just showing the usage of "Jobs_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaTransformResource created on azure
            // for more information of creating MediaTransformResource, please refer to the document of MediaTransformResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosoresources";
            string accountName = "contosomedia";
            string transformName = "exampleTransform";
            ResourceIdentifier mediaTransformResourceId = MediaTransformResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, transformName);
            MediaTransformResource mediaTransform = client.GetMediaTransformResource(mediaTransformResourceId);

            // get the collection of this MediaJobResource
            MediaJobCollection collection = mediaTransform.GetMediaJobs();

            // invoke the operation and iterate over the result
            await foreach (MediaJobResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MediaJobData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetAJobByName()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Encoding/stable/2022-07-01/examples/jobs-get-by-name.json
            // this example is just showing the usage of "Jobs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaTransformResource created on azure
            // for more information of creating MediaTransformResource, please refer to the document of MediaTransformResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosoresources";
            string accountName = "contosomedia";
            string transformName = "exampleTransform";
            ResourceIdentifier mediaTransformResourceId = MediaTransformResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, transformName);
            MediaTransformResource mediaTransform = client.GetMediaTransformResource(mediaTransformResourceId);

            // get the collection of this MediaJobResource
            MediaJobCollection collection = mediaTransform.GetMediaJobs();

            // invoke the operation
            string jobName = "job1";
            bool result = await collection.ExistsAsync(jobName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetAJobByName()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Encoding/stable/2022-07-01/examples/jobs-get-by-name.json
            // this example is just showing the usage of "Jobs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaTransformResource created on azure
            // for more information of creating MediaTransformResource, please refer to the document of MediaTransformResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosoresources";
            string accountName = "contosomedia";
            string transformName = "exampleTransform";
            ResourceIdentifier mediaTransformResourceId = MediaTransformResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, transformName);
            MediaTransformResource mediaTransform = client.GetMediaTransformResource(mediaTransformResourceId);

            // get the collection of this MediaJobResource
            MediaJobCollection collection = mediaTransform.GetMediaJobs();

            // invoke the operation
            string jobName = "job1";
            NullableResponse<MediaJobResource> response = await collection.GetIfExistsAsync(jobName);
            MediaJobResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MediaJobData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
