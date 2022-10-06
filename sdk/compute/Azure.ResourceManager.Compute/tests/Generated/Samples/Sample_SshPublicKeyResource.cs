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
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Compute
{
    public partial class Sample_SshPublicKeyResource
    {
        // SshPublicKeys_ListBySubscription_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetSshPublicKeys_SshPublicKeysListBySubscriptionMaximumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2022-03-01/examples/sshPublicKeyExamples/SshPublicKeys_ListBySubscription_MaximumSet_Gen.json
            // this example is just showing the usage of "SshPublicKeys_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "{subscription-id}";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (SshPublicKeyResource item in subscriptionResource.GetSshPublicKeysAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SshPublicKeyData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // SshPublicKeys_ListBySubscription_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetSshPublicKeys_SshPublicKeysListBySubscriptionMinimumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2022-03-01/examples/sshPublicKeyExamples/SshPublicKeys_ListBySubscription_MinimumSet_Gen.json
            // this example is just showing the usage of "SshPublicKeys_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "{subscription-id}";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (SshPublicKeyResource item in subscriptionResource.GetSshPublicKeysAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SshPublicKeyData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // SshPublicKeys_Update_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_SshPublicKeysUpdateMaximumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2022-03-01/examples/sshPublicKeyExamples/SshPublicKeys_Update_MaximumSet_Gen.json
            // this example is just showing the usage of "SshPublicKeys_Update" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SshPublicKeyResource created on azure
            // for more information of creating SshPublicKeyResource, please refer to the document of SshPublicKeyResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string sshPublicKeyName = "aaaaaaaaaaaa";
            ResourceIdentifier sshPublicKeyResourceId = SshPublicKeyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sshPublicKeyName);
            SshPublicKeyResource sshPublicKey = client.GetSshPublicKeyResource(sshPublicKeyResourceId);

            // invoke the operation
            SshPublicKeyPatch patch = new SshPublicKeyPatch()
            {
                PublicKey = "{ssh-rsa public key}",
                Tags =
{
["key2854"] = "a",
},
            };
            SshPublicKeyResource result = await sshPublicKey.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SshPublicKeyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // SshPublicKeys_Update_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_SshPublicKeysUpdateMinimumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2022-03-01/examples/sshPublicKeyExamples/SshPublicKeys_Update_MinimumSet_Gen.json
            // this example is just showing the usage of "SshPublicKeys_Update" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SshPublicKeyResource created on azure
            // for more information of creating SshPublicKeyResource, please refer to the document of SshPublicKeyResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string sshPublicKeyName = "aaaaaaaaaaa";
            ResourceIdentifier sshPublicKeyResourceId = SshPublicKeyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sshPublicKeyName);
            SshPublicKeyResource sshPublicKey = client.GetSshPublicKeyResource(sshPublicKeyResourceId);

            // invoke the operation
            SshPublicKeyPatch patch = new SshPublicKeyPatch();
            SshPublicKeyResource result = await sshPublicKey.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SshPublicKeyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // SshPublicKeys_Delete_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_SshPublicKeysDeleteMaximumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2022-03-01/examples/sshPublicKeyExamples/SshPublicKeys_Delete_MaximumSet_Gen.json
            // this example is just showing the usage of "SshPublicKeys_Delete" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SshPublicKeyResource created on azure
            // for more information of creating SshPublicKeyResource, please refer to the document of SshPublicKeyResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string sshPublicKeyName = "aaaaaaaaaa";
            ResourceIdentifier sshPublicKeyResourceId = SshPublicKeyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sshPublicKeyName);
            SshPublicKeyResource sshPublicKey = client.GetSshPublicKeyResource(sshPublicKeyResourceId);

            // invoke the operation
            await sshPublicKey.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // SshPublicKeys_Delete_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_SshPublicKeysDeleteMinimumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2022-03-01/examples/sshPublicKeyExamples/SshPublicKeys_Delete_MinimumSet_Gen.json
            // this example is just showing the usage of "SshPublicKeys_Delete" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SshPublicKeyResource created on azure
            // for more information of creating SshPublicKeyResource, please refer to the document of SshPublicKeyResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string sshPublicKeyName = "aaaaaaaaaaaaaaaaaaa";
            ResourceIdentifier sshPublicKeyResourceId = SshPublicKeyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sshPublicKeyName);
            SshPublicKeyResource sshPublicKey = client.GetSshPublicKeyResource(sshPublicKeyResourceId);

            // invoke the operation
            await sshPublicKey.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get an ssh public key.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAnSshPublicKey()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2022-03-01/examples/sshPublicKeyExamples/SshPublicKey_Get.json
            // this example is just showing the usage of "SshPublicKeys_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SshPublicKeyResource created on azure
            // for more information of creating SshPublicKeyResource, please refer to the document of SshPublicKeyResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "myResourceGroup";
            string sshPublicKeyName = "mySshPublicKeyName";
            ResourceIdentifier sshPublicKeyResourceId = SshPublicKeyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sshPublicKeyName);
            SshPublicKeyResource sshPublicKey = client.GetSshPublicKeyResource(sshPublicKeyResourceId);

            // invoke the operation
            SshPublicKeyResource result = await sshPublicKey.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SshPublicKeyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Generate an SSH key pair.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GenerateKeyPair_GenerateAnSSHKeyPair()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2022-03-01/examples/sshPublicKeyExamples/SshPublicKeys_GenerateKeyPair.json
            // this example is just showing the usage of "SshPublicKeys_GenerateKeyPair" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SshPublicKeyResource created on azure
            // for more information of creating SshPublicKeyResource, please refer to the document of SshPublicKeyResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string sshPublicKeyName = "mySshPublicKeyName";
            ResourceIdentifier sshPublicKeyResourceId = SshPublicKeyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sshPublicKeyName);
            SshPublicKeyResource sshPublicKey = client.GetSshPublicKeyResource(sshPublicKeyResourceId);

            // invoke the operation
            SshPublicKeyGenerateKeyPairResult result = await sshPublicKey.GenerateKeyPairAsync();

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
