// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.NotificationHubs.Models;

namespace Azure.ResourceManager.NotificationHubs.Samples
{
    public partial class Sample_NotificationHubNamespaceAuthorizationRuleCollection
    {
        // NameSpaceAuthorizationRuleCreate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_NameSpaceAuthorizationRuleCreate()
        {
            // Generated from example definition: specification/notificationhubs/resource-manager/Microsoft.NotificationHubs/stable/2017-04-01/examples/Namespaces/NHNameSpaceAuthorizationRuleCreate.json
            // this example is just showing the usage of "Namespaces_CreateOrUpdateAuthorizationRule" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NotificationHubNamespaceResource created on azure
            // for more information of creating NotificationHubNamespaceResource, please refer to the document of NotificationHubNamespaceResource
            string subscriptionId = "29cfa613-cbbc-4512-b1d6-1b3a92c7fa40";
            string resourceGroupName = "5ktrial";
            string namespaceName = "nh-sdk-ns";
            ResourceIdentifier notificationHubNamespaceResourceId = NotificationHubNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            NotificationHubNamespaceResource notificationHubNamespace = client.GetNotificationHubNamespaceResource(notificationHubNamespaceResourceId);

            // get the collection of this NotificationHubNamespaceAuthorizationRuleResource
            NotificationHubNamespaceAuthorizationRuleCollection collection = notificationHubNamespace.GetNotificationHubNamespaceAuthorizationRules();

            // invoke the operation
            string authorizationRuleName = "sdk-AuthRules-1788";
            SharedAccessAuthorizationRuleCreateOrUpdateContent content = new SharedAccessAuthorizationRuleCreateOrUpdateContent(new SharedAccessAuthorizationRuleProperties()
            {
                Rights =
{
AuthorizationRuleAccessRight.Listen,AuthorizationRuleAccessRight.Send
},
            });
            ArmOperation<NotificationHubNamespaceAuthorizationRuleResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, authorizationRuleName, content);
            NotificationHubNamespaceAuthorizationRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NotificationHubAuthorizationRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // NameSpaceAuthorizationRuleGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_NameSpaceAuthorizationRuleGet()
        {
            // Generated from example definition: specification/notificationhubs/resource-manager/Microsoft.NotificationHubs/stable/2017-04-01/examples/Namespaces/NHNameSpaceAuthorizationRuleGet.json
            // this example is just showing the usage of "Namespaces_GetAuthorizationRule" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NotificationHubNamespaceResource created on azure
            // for more information of creating NotificationHubNamespaceResource, please refer to the document of NotificationHubNamespaceResource
            string subscriptionId = "29cfa613-cbbc-4512-b1d6-1b3a92c7fa40";
            string resourceGroupName = "5ktrial";
            string namespaceName = "nh-sdk-ns";
            ResourceIdentifier notificationHubNamespaceResourceId = NotificationHubNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            NotificationHubNamespaceResource notificationHubNamespace = client.GetNotificationHubNamespaceResource(notificationHubNamespaceResourceId);

            // get the collection of this NotificationHubNamespaceAuthorizationRuleResource
            NotificationHubNamespaceAuthorizationRuleCollection collection = notificationHubNamespace.GetNotificationHubNamespaceAuthorizationRules();

            // invoke the operation
            string authorizationRuleName = "RootManageSharedAccessKey";
            NotificationHubNamespaceAuthorizationRuleResource result = await collection.GetAsync(authorizationRuleName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NotificationHubAuthorizationRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // NameSpaceAuthorizationRuleGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_NameSpaceAuthorizationRuleGet()
        {
            // Generated from example definition: specification/notificationhubs/resource-manager/Microsoft.NotificationHubs/stable/2017-04-01/examples/Namespaces/NHNameSpaceAuthorizationRuleGet.json
            // this example is just showing the usage of "Namespaces_GetAuthorizationRule" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NotificationHubNamespaceResource created on azure
            // for more information of creating NotificationHubNamespaceResource, please refer to the document of NotificationHubNamespaceResource
            string subscriptionId = "29cfa613-cbbc-4512-b1d6-1b3a92c7fa40";
            string resourceGroupName = "5ktrial";
            string namespaceName = "nh-sdk-ns";
            ResourceIdentifier notificationHubNamespaceResourceId = NotificationHubNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            NotificationHubNamespaceResource notificationHubNamespace = client.GetNotificationHubNamespaceResource(notificationHubNamespaceResourceId);

            // get the collection of this NotificationHubNamespaceAuthorizationRuleResource
            NotificationHubNamespaceAuthorizationRuleCollection collection = notificationHubNamespace.GetNotificationHubNamespaceAuthorizationRules();

            // invoke the operation
            string authorizationRuleName = "RootManageSharedAccessKey";
            bool result = await collection.ExistsAsync(authorizationRuleName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // NameSpaceAuthorizationRuleGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_NameSpaceAuthorizationRuleGet()
        {
            // Generated from example definition: specification/notificationhubs/resource-manager/Microsoft.NotificationHubs/stable/2017-04-01/examples/Namespaces/NHNameSpaceAuthorizationRuleGet.json
            // this example is just showing the usage of "Namespaces_GetAuthorizationRule" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NotificationHubNamespaceResource created on azure
            // for more information of creating NotificationHubNamespaceResource, please refer to the document of NotificationHubNamespaceResource
            string subscriptionId = "29cfa613-cbbc-4512-b1d6-1b3a92c7fa40";
            string resourceGroupName = "5ktrial";
            string namespaceName = "nh-sdk-ns";
            ResourceIdentifier notificationHubNamespaceResourceId = NotificationHubNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            NotificationHubNamespaceResource notificationHubNamespace = client.GetNotificationHubNamespaceResource(notificationHubNamespaceResourceId);

            // get the collection of this NotificationHubNamespaceAuthorizationRuleResource
            NotificationHubNamespaceAuthorizationRuleCollection collection = notificationHubNamespace.GetNotificationHubNamespaceAuthorizationRules();

            // invoke the operation
            string authorizationRuleName = "RootManageSharedAccessKey";
            NullableResponse<NotificationHubNamespaceAuthorizationRuleResource> response = await collection.GetIfExistsAsync(authorizationRuleName);
            NotificationHubNamespaceAuthorizationRuleResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NotificationHubAuthorizationRuleData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // NameSpaceAuthorizationRuleListAll
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_NameSpaceAuthorizationRuleListAll()
        {
            // Generated from example definition: specification/notificationhubs/resource-manager/Microsoft.NotificationHubs/stable/2017-04-01/examples/Namespaces/NHNameSpaceAuthorizationRuleListAll.json
            // this example is just showing the usage of "Namespaces_ListAuthorizationRules" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NotificationHubNamespaceResource created on azure
            // for more information of creating NotificationHubNamespaceResource, please refer to the document of NotificationHubNamespaceResource
            string subscriptionId = "29cfa613-cbbc-4512-b1d6-1b3a92c7fa40";
            string resourceGroupName = "5ktrial";
            string namespaceName = "nh-sdk-ns";
            ResourceIdentifier notificationHubNamespaceResourceId = NotificationHubNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            NotificationHubNamespaceResource notificationHubNamespace = client.GetNotificationHubNamespaceResource(notificationHubNamespaceResourceId);

            // get the collection of this NotificationHubNamespaceAuthorizationRuleResource
            NotificationHubNamespaceAuthorizationRuleCollection collection = notificationHubNamespace.GetNotificationHubNamespaceAuthorizationRules();

            // invoke the operation and iterate over the result
            await foreach (NotificationHubNamespaceAuthorizationRuleResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NotificationHubAuthorizationRuleData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
