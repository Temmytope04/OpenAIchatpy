// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.Messaging.WebPubSub.Samples
{
    public class Samples_WebPubSubServiceClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CloseAllConnections()
        {
            var client = new WebPubSubServiceClient("<https://my-service.azure.com>", "<hub>");

            Response response = client.CloseAllConnections();
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CloseAllConnections_AllParameters()
        {
            var client = new WebPubSubServiceClient("<https://my-service.azure.com>", "<hub>");

            Response response = client.CloseAllConnections(new string[] { "<excluded>" }, "<reason>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CloseAllConnections_Async()
        {
            var client = new WebPubSubServiceClient("<https://my-service.azure.com>", "<hub>");

            Response response = await client.CloseAllConnectionsAsync();
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CloseAllConnections_AllParameters_Async()
        {
            var client = new WebPubSubServiceClient("<https://my-service.azure.com>", "<hub>");

            Response response = await client.CloseAllConnectionsAsync(new string[] { "<excluded>" }, "<reason>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SendToAll()
        {
            var client = new WebPubSubServiceClient("<https://my-service.azure.com>", "<hub>");

            var data = File.OpenRead("<filePath>");

            Response response = client.SendToAll(RequestContent.Create(data), ContentType.ApplicationOctetStream);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SendToAll_AllParameters()
        {
            var client = new WebPubSubServiceClient("<https://my-service.azure.com>", "<hub>");

            var data = File.OpenRead("<filePath>");

            Response response = client.SendToAll(RequestContent.Create(data), ContentType.ApplicationOctetStream, new string[] { "<excluded>" }, "<filter>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SendToAll_Async()
        {
            var client = new WebPubSubServiceClient("<https://my-service.azure.com>", "<hub>");

            var data = File.OpenRead("<filePath>");

            Response response = await client.SendToAllAsync(RequestContent.Create(data), ContentType.ApplicationOctetStream);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SendToAll_AllParameters_Async()
        {
            var client = new WebPubSubServiceClient("<https://my-service.azure.com>", "<hub>");

            var data = File.OpenRead("<filePath>");

            Response response = await client.SendToAllAsync(RequestContent.Create(data), ContentType.ApplicationOctetStream, new string[] { "<excluded>" }, "<filter>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CloseConnection()
        {
            var client = new WebPubSubServiceClient("<https://my-service.azure.com>", "<hub>");

            Response response = client.CloseConnection("<connectionId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CloseConnection_AllParameters()
        {
            var client = new WebPubSubServiceClient("<https://my-service.azure.com>", "<hub>");

            Response response = client.CloseConnection("<connectionId>", "<reason>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CloseConnection_Async()
        {
            var client = new WebPubSubServiceClient("<https://my-service.azure.com>", "<hub>");

            Response response = await client.CloseConnectionAsync("<connectionId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CloseConnection_AllParameters_Async()
        {
            var client = new WebPubSubServiceClient("<https://my-service.azure.com>", "<hub>");

            Response response = await client.CloseConnectionAsync("<connectionId>", "<reason>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SendToConnection()
        {
            var client = new WebPubSubServiceClient("<https://my-service.azure.com>", "<hub>");

            var data = File.OpenRead("<filePath>");

            Response response = client.SendToConnection("<connectionId>", RequestContent.Create(data), ContentType.ApplicationOctetStream);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SendToConnection_AllParameters()
        {
            var client = new WebPubSubServiceClient("<https://my-service.azure.com>", "<hub>");

            var data = File.OpenRead("<filePath>");

            Response response = client.SendToConnection("<connectionId>", RequestContent.Create(data), ContentType.ApplicationOctetStream);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SendToConnection_Async()
        {
            var client = new WebPubSubServiceClient("<https://my-service.azure.com>", "<hub>");

            var data = File.OpenRead("<filePath>");

            Response response = await client.SendToConnectionAsync("<connectionId>", RequestContent.Create(data), ContentType.ApplicationOctetStream);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SendToConnection_AllParameters_Async()
        {
            var client = new WebPubSubServiceClient("<https://my-service.azure.com>", "<hub>");

            var data = File.OpenRead("<filePath>");

            Response response = await client.SendToConnectionAsync("<connectionId>", RequestContent.Create(data), ContentType.ApplicationOctetStream);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_RemoveConnectionFromAllGroups()
        {
            var client = new WebPubSubServiceClient("<https://my-service.azure.com>", "<hub>");

            Response response = client.RemoveConnectionFromAllGroups("<connectionId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_RemoveConnectionFromAllGroups_AllParameters()
        {
            var client = new WebPubSubServiceClient("<https://my-service.azure.com>", "<hub>");

            Response response = client.RemoveConnectionFromAllGroups("<connectionId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_RemoveConnectionFromAllGroups_Async()
        {
            var client = new WebPubSubServiceClient("<https://my-service.azure.com>", "<hub>");

            Response response = await client.RemoveConnectionFromAllGroupsAsync("<connectionId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_RemoveConnectionFromAllGroups_AllParameters_Async()
        {
            var client = new WebPubSubServiceClient("<https://my-service.azure.com>", "<hub>");

            Response response = await client.RemoveConnectionFromAllGroupsAsync("<connectionId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CloseGroupConnections()
        {
            var client = new WebPubSubServiceClient("<https://my-service.azure.com>", "<hub>");

            Response response = client.CloseGroupConnections("<group>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CloseGroupConnections_AllParameters()
        {
            var client = new WebPubSubServiceClient("<https://my-service.azure.com>", "<hub>");

            Response response = client.CloseGroupConnections("<group>", new string[] { "<excluded>" }, "<reason>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CloseGroupConnections_Async()
        {
            var client = new WebPubSubServiceClient("<https://my-service.azure.com>", "<hub>");

            Response response = await client.CloseGroupConnectionsAsync("<group>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CloseGroupConnections_AllParameters_Async()
        {
            var client = new WebPubSubServiceClient("<https://my-service.azure.com>", "<hub>");

            Response response = await client.CloseGroupConnectionsAsync("<group>", new string[] { "<excluded>" }, "<reason>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SendToGroup()
        {
            var client = new WebPubSubServiceClient("<https://my-service.azure.com>", "<hub>");

            var data = File.OpenRead("<filePath>");

            Response response = client.SendToGroup("<group>", RequestContent.Create(data), ContentType.ApplicationOctetStream);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SendToGroup_AllParameters()
        {
            var client = new WebPubSubServiceClient("<https://my-service.azure.com>", "<hub>");

            var data = File.OpenRead("<filePath>");

            Response response = client.SendToGroup("<group>", RequestContent.Create(data), ContentType.ApplicationOctetStream, new string[] { "<excluded>" }, "<filter>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SendToGroup_Async()
        {
            var client = new WebPubSubServiceClient("<https://my-service.azure.com>", "<hub>");

            var data = File.OpenRead("<filePath>");

            Response response = await client.SendToGroupAsync("<group>", RequestContent.Create(data), ContentType.ApplicationOctetStream);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SendToGroup_AllParameters_Async()
        {
            var client = new WebPubSubServiceClient("<https://my-service.azure.com>", "<hub>");

            var data = File.OpenRead("<filePath>");

            Response response = await client.SendToGroupAsync("<group>", RequestContent.Create(data), ContentType.ApplicationOctetStream, new string[] { "<excluded>" }, "<filter>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_RemoveConnectionFromGroup()
        {
            var client = new WebPubSubServiceClient("<https://my-service.azure.com>", "<hub>");

            Response response = client.RemoveConnectionFromGroup("<group>", "<connectionId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_RemoveConnectionFromGroup_AllParameters()
        {
            var client = new WebPubSubServiceClient("<https://my-service.azure.com>", "<hub>");

            Response response = client.RemoveConnectionFromGroup("<group>", "<connectionId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_RemoveConnectionFromGroup_Async()
        {
            var client = new WebPubSubServiceClient("<https://my-service.azure.com>", "<hub>");

            Response response = await client.RemoveConnectionFromGroupAsync("<group>", "<connectionId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_RemoveConnectionFromGroup_AllParameters_Async()
        {
            var client = new WebPubSubServiceClient("<https://my-service.azure.com>", "<hub>");

            Response response = await client.RemoveConnectionFromGroupAsync("<group>", "<connectionId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_AddConnectionToGroup()
        {
            var client = new WebPubSubServiceClient("<https://my-service.azure.com>", "<hub>");

            Response response = client.AddConnectionToGroup("<group>", "<connectionId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_AddConnectionToGroup_AllParameters()
        {
            var client = new WebPubSubServiceClient("<https://my-service.azure.com>", "<hub>");

            Response response = client.AddConnectionToGroup("<group>", "<connectionId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_AddConnectionToGroup_Async()
        {
            var client = new WebPubSubServiceClient("<https://my-service.azure.com>", "<hub>");

            Response response = await client.AddConnectionToGroupAsync("<group>", "<connectionId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_AddConnectionToGroup_AllParameters_Async()
        {
            var client = new WebPubSubServiceClient("<https://my-service.azure.com>", "<hub>");

            Response response = await client.AddConnectionToGroupAsync("<group>", "<connectionId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CloseUserConnections()
        {
            var client = new WebPubSubServiceClient("<https://my-service.azure.com>", "<hub>");

            Response response = client.CloseUserConnections("<userId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CloseUserConnections_AllParameters()
        {
            var client = new WebPubSubServiceClient("<https://my-service.azure.com>", "<hub>");

            Response response = client.CloseUserConnections("<userId>", new string[] { "<excluded>" }, "<reason>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CloseUserConnections_Async()
        {
            var client = new WebPubSubServiceClient("<https://my-service.azure.com>", "<hub>");

            Response response = await client.CloseUserConnectionsAsync("<userId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CloseUserConnections_AllParameters_Async()
        {
            var client = new WebPubSubServiceClient("<https://my-service.azure.com>", "<hub>");

            Response response = await client.CloseUserConnectionsAsync("<userId>", new string[] { "<excluded>" }, "<reason>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SendToUser()
        {
            var client = new WebPubSubServiceClient("<https://my-service.azure.com>", "<hub>");

            var data = File.OpenRead("<filePath>");

            Response response = client.SendToUser("<userId>", RequestContent.Create(data), ContentType.ApplicationOctetStream);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SendToUser_AllParameters()
        {
            var client = new WebPubSubServiceClient("<https://my-service.azure.com>", "<hub>");

            var data = File.OpenRead("<filePath>");

            Response response = client.SendToUser("<userId>", RequestContent.Create(data), ContentType.ApplicationOctetStream, "<filter>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SendToUser_Async()
        {
            var client = new WebPubSubServiceClient("<https://my-service.azure.com>", "<hub>");

            var data = File.OpenRead("<filePath>");

            Response response = await client.SendToUserAsync("<userId>", RequestContent.Create(data), ContentType.ApplicationOctetStream);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SendToUser_AllParameters_Async()
        {
            var client = new WebPubSubServiceClient("<https://my-service.azure.com>", "<hub>");

            var data = File.OpenRead("<filePath>");

            Response response = await client.SendToUserAsync("<userId>", RequestContent.Create(data), ContentType.ApplicationOctetStream, "<filter>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_RemoveUserFromAllGroups()
        {
            var client = new WebPubSubServiceClient("<https://my-service.azure.com>", "<hub>");

            Response response = client.RemoveUserFromAllGroups("<userId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_RemoveUserFromAllGroups_AllParameters()
        {
            var client = new WebPubSubServiceClient("<https://my-service.azure.com>", "<hub>");

            Response response = client.RemoveUserFromAllGroups("<userId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_RemoveUserFromAllGroups_Async()
        {
            var client = new WebPubSubServiceClient("<https://my-service.azure.com>", "<hub>");

            Response response = await client.RemoveUserFromAllGroupsAsync("<userId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_RemoveUserFromAllGroups_AllParameters_Async()
        {
            var client = new WebPubSubServiceClient("<https://my-service.azure.com>", "<hub>");

            Response response = await client.RemoveUserFromAllGroupsAsync("<userId>");
            Console.WriteLine(response.Status);
        }
    }
}
