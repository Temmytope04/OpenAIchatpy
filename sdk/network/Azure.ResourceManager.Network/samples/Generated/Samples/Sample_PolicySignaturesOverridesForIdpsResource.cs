// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_PolicySignaturesOverridesForIdpsResource
    {
        // patch signature overrides
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_PatchSignatureOverrides()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-01-01/examples/FirewallPolicySignatureOverridesPatch.json
            // this example is just showing the usage of "FirewallPolicyIdpsSignaturesOverrides_Patch" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PolicySignaturesOverridesForIdpsResource created on azure
            // for more information of creating PolicySignaturesOverridesForIdpsResource, please refer to the document of PolicySignaturesOverridesForIdpsResource
            string subscriptionId = "e747cc13-97d4-4a79-b463-42d7f4e558f2";
            string resourceGroupName = "rg1";
            string firewallPolicyName = "firewallPolicy";
            ResourceIdentifier policySignaturesOverridesForIdpsResourceId = PolicySignaturesOverridesForIdpsResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, firewallPolicyName);
            PolicySignaturesOverridesForIdpsResource policySignaturesOverridesForIdps = client.GetPolicySignaturesOverridesForIdpsResource(policySignaturesOverridesForIdpsResourceId);

            // invoke the operation
            PolicySignaturesOverridesForIdpsData data = new PolicySignaturesOverridesForIdpsData()
            {
                Name = "default",
                Id = new ResourceIdentifier("/subscriptions/e747cc13-97d4-4a79-b463-42d7f4e558f2/resourceGroups/rg1/providers/Microsoft.Network/firewallPolicies/firewallPolicy/signatureOverrides/default"),
                ResourceType = new ResourceType("Microsoft.Network/firewallPolicies/signatureOverrides"),
                Signatures =
{
["2000105"] = "Off",
["2000106"] = "Deny",
},
            };
            PolicySignaturesOverridesForIdpsResource result = await policySignaturesOverridesForIdps.UpdateAsync(data);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PolicySignaturesOverridesForIdpsData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // put signature overrides
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_PutSignatureOverrides()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-01-01/examples/FirewallPolicySignatureOverridesPut.json
            // this example is just showing the usage of "FirewallPolicyIdpsSignaturesOverrides_Put" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PolicySignaturesOverridesForIdpsResource created on azure
            // for more information of creating PolicySignaturesOverridesForIdpsResource, please refer to the document of PolicySignaturesOverridesForIdpsResource
            string subscriptionId = "e747cc13-97d4-4a79-b463-42d7f4e558f2";
            string resourceGroupName = "rg1";
            string firewallPolicyName = "firewallPolicy";
            ResourceIdentifier policySignaturesOverridesForIdpsResourceId = PolicySignaturesOverridesForIdpsResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, firewallPolicyName);
            PolicySignaturesOverridesForIdpsResource policySignaturesOverridesForIdps = client.GetPolicySignaturesOverridesForIdpsResource(policySignaturesOverridesForIdpsResourceId);

            // invoke the operation
            PolicySignaturesOverridesForIdpsData data = new PolicySignaturesOverridesForIdpsData()
            {
                Name = "default",
                Id = new ResourceIdentifier("/subscriptions/e747cc13-97d4-4a79-b463-42d7f4e558f2/resourceGroups/rg1/providers/Microsoft.Network/firewallPolicies/firewallPolicy/signatureOverrides/default"),
                ResourceType = new ResourceType("Microsoft.Network/firewallPolicies/signatureOverrides"),
                Signatures =
{
["2000105"] = "Off",
["2000106"] = "Deny",
},
            };
            ArmOperation<PolicySignaturesOverridesForIdpsResource> lro = await policySignaturesOverridesForIdps.CreateOrUpdateAsync(WaitUntil.Completed, data);
            PolicySignaturesOverridesForIdpsResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PolicySignaturesOverridesForIdpsData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // get signature overrides
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetSignatureOverrides()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-01-01/examples/FirewallPolicySignatureOverridesGet.json
            // this example is just showing the usage of "FirewallPolicyIdpsSignaturesOverrides_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PolicySignaturesOverridesForIdpsResource created on azure
            // for more information of creating PolicySignaturesOverridesForIdpsResource, please refer to the document of PolicySignaturesOverridesForIdpsResource
            string subscriptionId = "e747cc13-97d4-4a79-b463-42d7f4e558f2";
            string resourceGroupName = "rg1";
            string firewallPolicyName = "firewallPolicy";
            ResourceIdentifier policySignaturesOverridesForIdpsResourceId = PolicySignaturesOverridesForIdpsResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, firewallPolicyName);
            PolicySignaturesOverridesForIdpsResource policySignaturesOverridesForIdps = client.GetPolicySignaturesOverridesForIdpsResource(policySignaturesOverridesForIdpsResourceId);

            // invoke the operation
            PolicySignaturesOverridesForIdpsResource result = await policySignaturesOverridesForIdps.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PolicySignaturesOverridesForIdpsData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
