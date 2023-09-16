// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.Template;
using NUnit.Framework;

namespace Azure.Template.Samples
{
    public class Samples_TemplateClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetSecret()
        {
            TokenCredential credential = new DefaultAzureCredential();
            TemplateClient client = new TemplateClient("<VaultBaseUrl>", credential);

            Response response = client.GetSecret("<secretName>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetSecret_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            TemplateClient client = new TemplateClient("<VaultBaseUrl>", credential);

            Response response = client.GetSecret("<secretName>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("contentType").ToString());
            Console.WriteLine(result.GetProperty("tags").GetProperty("<key>").ToString());
            Console.WriteLine(result.GetProperty("kid").ToString());
            Console.WriteLine(result.GetProperty("managed").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetSecret_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            TemplateClient client = new TemplateClient("<VaultBaseUrl>", credential);

            Response response = await client.GetSecretAsync("<secretName>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetSecret_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            TemplateClient client = new TemplateClient("<VaultBaseUrl>", credential);

            Response response = await client.GetSecretAsync("<secretName>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("contentType").ToString());
            Console.WriteLine(result.GetProperty("tags").GetProperty("<key>").ToString());
            Console.WriteLine(result.GetProperty("kid").ToString());
            Console.WriteLine(result.GetProperty("managed").ToString());
        }
    }
}
