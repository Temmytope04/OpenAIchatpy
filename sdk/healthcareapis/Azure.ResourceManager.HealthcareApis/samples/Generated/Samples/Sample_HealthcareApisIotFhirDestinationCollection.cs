// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.HealthcareApis;
using Azure.ResourceManager.HealthcareApis.Models;

namespace Azure.ResourceManager.HealthcareApis.Samples
{
    public partial class Sample_HealthcareApisIotFhirDestinationCollection
    {
        // List IoT Connectors
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListIoTConnectors()
        {
            // Generated from example definition: specification/healthcareapis/resource-manager/Microsoft.HealthcareApis/stable/2022-06-01/examples/iotconnectors/iotconnector_fhirdestination_List.json
            // this example is just showing the usage of "FhirDestinations_ListByIotConnector" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HealthcareApisIotConnectorResource created on azure
            // for more information of creating HealthcareApisIotConnectorResource, please refer to the document of HealthcareApisIotConnectorResource
            string subscriptionId = "subid";
            string resourceGroupName = "testRG";
            string workspaceName = "workspace1";
            string iotConnectorName = "blue";
            ResourceIdentifier healthcareApisIotConnectorResourceId = HealthcareApisIotConnectorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, iotConnectorName);
            HealthcareApisIotConnectorResource healthcareApisIotConnector = client.GetHealthcareApisIotConnectorResource(healthcareApisIotConnectorResourceId);

            // get the collection of this HealthcareApisIotFhirDestinationResource
            HealthcareApisIotFhirDestinationCollection collection = healthcareApisIotConnector.GetHealthcareApisIotFhirDestinations();

            // invoke the operation and iterate over the result
            await foreach (HealthcareApisIotFhirDestinationResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                HealthcareApisIotFhirDestinationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get an IoT Connector destination
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAnIoTConnectorDestination()
        {
            // Generated from example definition: specification/healthcareapis/resource-manager/Microsoft.HealthcareApis/stable/2022-06-01/examples/iotconnectors/iotconnector_fhirdestination_Get.json
            // this example is just showing the usage of "IotConnectorFhirDestination_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HealthcareApisIotConnectorResource created on azure
            // for more information of creating HealthcareApisIotConnectorResource, please refer to the document of HealthcareApisIotConnectorResource
            string subscriptionId = "subid";
            string resourceGroupName = "testRG";
            string workspaceName = "workspace1";
            string iotConnectorName = "blue";
            ResourceIdentifier healthcareApisIotConnectorResourceId = HealthcareApisIotConnectorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, iotConnectorName);
            HealthcareApisIotConnectorResource healthcareApisIotConnector = client.GetHealthcareApisIotConnectorResource(healthcareApisIotConnectorResourceId);

            // get the collection of this HealthcareApisIotFhirDestinationResource
            HealthcareApisIotFhirDestinationCollection collection = healthcareApisIotConnector.GetHealthcareApisIotFhirDestinations();

            // invoke the operation
            string fhirDestinationName = "dest1";
            HealthcareApisIotFhirDestinationResource result = await collection.GetAsync(fhirDestinationName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HealthcareApisIotFhirDestinationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get an IoT Connector destination
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetAnIoTConnectorDestination()
        {
            // Generated from example definition: specification/healthcareapis/resource-manager/Microsoft.HealthcareApis/stable/2022-06-01/examples/iotconnectors/iotconnector_fhirdestination_Get.json
            // this example is just showing the usage of "IotConnectorFhirDestination_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HealthcareApisIotConnectorResource created on azure
            // for more information of creating HealthcareApisIotConnectorResource, please refer to the document of HealthcareApisIotConnectorResource
            string subscriptionId = "subid";
            string resourceGroupName = "testRG";
            string workspaceName = "workspace1";
            string iotConnectorName = "blue";
            ResourceIdentifier healthcareApisIotConnectorResourceId = HealthcareApisIotConnectorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, iotConnectorName);
            HealthcareApisIotConnectorResource healthcareApisIotConnector = client.GetHealthcareApisIotConnectorResource(healthcareApisIotConnectorResourceId);

            // get the collection of this HealthcareApisIotFhirDestinationResource
            HealthcareApisIotFhirDestinationCollection collection = healthcareApisIotConnector.GetHealthcareApisIotFhirDestinations();

            // invoke the operation
            string fhirDestinationName = "dest1";
            bool result = await collection.ExistsAsync(fhirDestinationName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Create or update an Iot Connector FHIR destination
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateAnIotConnectorFHIRDestination()
        {
            // Generated from example definition: specification/healthcareapis/resource-manager/Microsoft.HealthcareApis/stable/2022-06-01/examples/iotconnectors/iotconnector_fhirdestination_Create.json
            // this example is just showing the usage of "IotConnectorFhirDestination_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HealthcareApisIotConnectorResource created on azure
            // for more information of creating HealthcareApisIotConnectorResource, please refer to the document of HealthcareApisIotConnectorResource
            string subscriptionId = "subid";
            string resourceGroupName = "testRG";
            string workspaceName = "workspace1";
            string iotConnectorName = "blue";
            ResourceIdentifier healthcareApisIotConnectorResourceId = HealthcareApisIotConnectorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, iotConnectorName);
            HealthcareApisIotConnectorResource healthcareApisIotConnector = client.GetHealthcareApisIotConnectorResource(healthcareApisIotConnectorResourceId);

            // get the collection of this HealthcareApisIotFhirDestinationResource
            HealthcareApisIotFhirDestinationCollection collection = healthcareApisIotConnector.GetHealthcareApisIotFhirDestinations();

            // invoke the operation
            string fhirDestinationName = "dest1";
            HealthcareApisIotFhirDestinationData data = new HealthcareApisIotFhirDestinationData(HealthcareApisIotIdentityResolutionType.Create, new ResourceIdentifier("subscriptions/11111111-2222-3333-4444-555566667777/resourceGroups/myrg/providers/Microsoft.HealthcareApis/workspaces/myworkspace/fhirservices/myfhirservice"), new HealthcareApisIotMappingProperties()
            {
                Content = BinaryData.FromObjectAsJson(new Dictionary<string, object>()
                {
                    ["template"] = new object[] { new Dictionary<string, object>()
{
["template"] = new Dictionary<string, object>()
{
["codes"] = new object[] { new Dictionary<string, object>()
{
["code"] = "8867-4",
["display"] = "Heart rate",
["system"] = "http://loinc.org"} },
["periodInterval"] = "60",
["typeName"] = "heartrate",
["value"] = new Dictionary<string, object>()
{
["defaultPeriod"] = "5000",
["unit"] = "count/min",
["valueName"] = "hr",
["valueType"] = "SampledData"}},
["templateType"] = "CodeValueFhir"} },
                    ["templateType"] = "CollectionFhirTemplate"
                }),
            })
            {
                Location = new AzureLocation("westus"),
            };
            ArmOperation<HealthcareApisIotFhirDestinationResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, fhirDestinationName, data);
            HealthcareApisIotFhirDestinationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HealthcareApisIotFhirDestinationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
