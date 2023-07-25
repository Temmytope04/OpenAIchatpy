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
using Azure.ResourceManager.IotHub;
using Azure.ResourceManager.IotHub.Models;

namespace Azure.ResourceManager.IotHub.Samples
{
    public partial class Sample_IotHubCertificateDescriptionCollection
    {
        // Certificates_ListByIotHub
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_CertificatesListByIotHub()
        {
            // Generated from example definition: specification/iothub/resource-manager/Microsoft.Devices/stable/2021-07-02/examples/iothub_listcertificates.json
            // this example is just showing the usage of "Certificates_ListByIotHub" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotHubDescriptionResource created on azure
            // for more information of creating IotHubDescriptionResource, please refer to the document of IotHubDescriptionResource
            string subscriptionId = "91d12660-3dec-467a-be2a-213b5544ddc0";
            string resourceGroupName = "myResourceGroup";
            string resourceName = "testhub";
            ResourceIdentifier iotHubDescriptionResourceId = IotHubDescriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            IotHubDescriptionResource iotHubDescription = client.GetIotHubDescriptionResource(iotHubDescriptionResourceId);

            // get the collection of this IotHubCertificateDescriptionResource
            IotHubCertificateDescriptionCollection collection = iotHubDescription.GetIotHubCertificateDescriptions();

            // invoke the operation and iterate over the result
            await foreach (IotHubCertificateDescriptionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                IotHubCertificateDescriptionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Certificates_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_CertificatesGet()
        {
            // Generated from example definition: specification/iothub/resource-manager/Microsoft.Devices/stable/2021-07-02/examples/iothub_getcertificate.json
            // this example is just showing the usage of "Certificates_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotHubDescriptionResource created on azure
            // for more information of creating IotHubDescriptionResource, please refer to the document of IotHubDescriptionResource
            string subscriptionId = "91d12660-3dec-467a-be2a-213b5544ddc0";
            string resourceGroupName = "myResourceGroup";
            string resourceName = "testhub";
            ResourceIdentifier iotHubDescriptionResourceId = IotHubDescriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            IotHubDescriptionResource iotHubDescription = client.GetIotHubDescriptionResource(iotHubDescriptionResourceId);

            // get the collection of this IotHubCertificateDescriptionResource
            IotHubCertificateDescriptionCollection collection = iotHubDescription.GetIotHubCertificateDescriptions();

            // invoke the operation
            string certificateName = "cert";
            IotHubCertificateDescriptionResource result = await collection.GetAsync(certificateName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IotHubCertificateDescriptionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Certificates_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_CertificatesGet()
        {
            // Generated from example definition: specification/iothub/resource-manager/Microsoft.Devices/stable/2021-07-02/examples/iothub_getcertificate.json
            // this example is just showing the usage of "Certificates_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotHubDescriptionResource created on azure
            // for more information of creating IotHubDescriptionResource, please refer to the document of IotHubDescriptionResource
            string subscriptionId = "91d12660-3dec-467a-be2a-213b5544ddc0";
            string resourceGroupName = "myResourceGroup";
            string resourceName = "testhub";
            ResourceIdentifier iotHubDescriptionResourceId = IotHubDescriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            IotHubDescriptionResource iotHubDescription = client.GetIotHubDescriptionResource(iotHubDescriptionResourceId);

            // get the collection of this IotHubCertificateDescriptionResource
            IotHubCertificateDescriptionCollection collection = iotHubDescription.GetIotHubCertificateDescriptions();

            // invoke the operation
            string certificateName = "cert";
            bool result = await collection.ExistsAsync(certificateName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Certificates_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CertificatesCreateOrUpdate()
        {
            // Generated from example definition: specification/iothub/resource-manager/Microsoft.Devices/stable/2021-07-02/examples/iothub_certificatescreateorupdate.json
            // this example is just showing the usage of "Certificates_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotHubDescriptionResource created on azure
            // for more information of creating IotHubDescriptionResource, please refer to the document of IotHubDescriptionResource
            string subscriptionId = "91d12660-3dec-467a-be2a-213b5544ddc0";
            string resourceGroupName = "myResourceGroup";
            string resourceName = "iothub";
            ResourceIdentifier iotHubDescriptionResourceId = IotHubDescriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            IotHubDescriptionResource iotHubDescription = client.GetIotHubDescriptionResource(iotHubDescriptionResourceId);

            // get the collection of this IotHubCertificateDescriptionResource
            IotHubCertificateDescriptionCollection collection = iotHubDescription.GetIotHubCertificateDescriptions();

            // invoke the operation
            string certificateName = "cert";
            IotHubCertificateDescriptionData data = new IotHubCertificateDescriptionData()
            {
                Properties = new IotHubCertificateProperties()
                {
                    Certificate = BinaryData.FromString("############################################"),
                },
            };
            ArmOperation<IotHubCertificateDescriptionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, certificateName, data);
            IotHubCertificateDescriptionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IotHubCertificateDescriptionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
