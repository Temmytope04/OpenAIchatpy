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
using Azure.Verticals.AgriFood.Farming;
using NUnit.Framework;

namespace Azure.Verticals.AgriFood.Farming.Samples
{
    public partial class Samples_CropProducts
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetCropProduct_ShortVersion()
        {
            TokenCredential credential = new DefaultAzureCredential();
            CropProducts client = new FarmBeatsClient(credential).GetCropProductsClient(apiVersion: "2022-11-01-preview");

            Response response = client.GetCropProduct("<cropProductId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetCropProduct_ShortVersion_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            CropProducts client = new FarmBeatsClient(credential).GetCropProductsClient(apiVersion: "2022-11-01-preview");

            Response response = await client.GetCropProductAsync("<cropProductId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetCropProduct_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            CropProducts client = new FarmBeatsClient(credential).GetCropProductsClient(apiVersion: "2022-11-01-preview");

            Response response = client.GetCropProduct("<cropProductId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("cropIds")[0].ToString());
            Console.WriteLine(result.GetProperty("brand").ToString());
            Console.WriteLine(result.GetProperty("product").ToString());
            Console.WriteLine(result.GetProperty("trait").ToString());
            Console.WriteLine(result.GetProperty("relativeMaturity").GetProperty("unit").ToString());
            Console.WriteLine(result.GetProperty("relativeMaturity").GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("treatments")[0].ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("source").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetCropProduct_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            CropProducts client = new FarmBeatsClient(credential).GetCropProductsClient(apiVersion: "2022-11-01-preview");

            Response response = await client.GetCropProductAsync("<cropProductId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("cropIds")[0].ToString());
            Console.WriteLine(result.GetProperty("brand").ToString());
            Console.WriteLine(result.GetProperty("product").ToString());
            Console.WriteLine(result.GetProperty("trait").ToString());
            Console.WriteLine(result.GetProperty("relativeMaturity").GetProperty("unit").ToString());
            Console.WriteLine(result.GetProperty("relativeMaturity").GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("treatments")[0].ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("source").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateOrUpdate_ShortVersion()
        {
            TokenCredential credential = new DefaultAzureCredential();
            CropProducts client = new FarmBeatsClient(credential).GetCropProductsClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new object());
            Response response = client.CreateOrUpdate("<cropProductId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateOrUpdate_ShortVersion_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            CropProducts client = new FarmBeatsClient(credential).GetCropProductsClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new object());
            Response response = await client.CreateOrUpdateAsync("<cropProductId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateOrUpdate_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            CropProducts client = new FarmBeatsClient(credential).GetCropProductsClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new
            {
                cropIds = new object[]
            {
"<cropIds>"
            },
                brand = "<brand>",
                product = "<product>",
                trait = "<trait>",
                relativeMaturity = new
                {
                    unit = "<unit>",
                    value = 123.45,
                },
                treatments = new object[]
            {
"<treatments>"
            },
                status = "<status>",
                source = "<source>",
                name = "<name>",
                description = "<description>",
                properties = new
                {
                    key = new object(),
                },
            });
            Response response = client.CreateOrUpdate("<cropProductId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("cropIds")[0].ToString());
            Console.WriteLine(result.GetProperty("brand").ToString());
            Console.WriteLine(result.GetProperty("product").ToString());
            Console.WriteLine(result.GetProperty("trait").ToString());
            Console.WriteLine(result.GetProperty("relativeMaturity").GetProperty("unit").ToString());
            Console.WriteLine(result.GetProperty("relativeMaturity").GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("treatments")[0].ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("source").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateOrUpdate_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            CropProducts client = new FarmBeatsClient(credential).GetCropProductsClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new
            {
                cropIds = new object[]
            {
"<cropIds>"
            },
                brand = "<brand>",
                product = "<product>",
                trait = "<trait>",
                relativeMaturity = new
                {
                    unit = "<unit>",
                    value = 123.45,
                },
                treatments = new object[]
            {
"<treatments>"
            },
                status = "<status>",
                source = "<source>",
                name = "<name>",
                description = "<description>",
                properties = new
                {
                    key = new object(),
                },
            });
            Response response = await client.CreateOrUpdateAsync("<cropProductId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("cropIds")[0].ToString());
            Console.WriteLine(result.GetProperty("brand").ToString());
            Console.WriteLine(result.GetProperty("product").ToString());
            Console.WriteLine(result.GetProperty("trait").ToString());
            Console.WriteLine(result.GetProperty("relativeMaturity").GetProperty("unit").ToString());
            Console.WriteLine(result.GetProperty("relativeMaturity").GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("treatments")[0].ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("source").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Delete_ShortVersion()
        {
            TokenCredential credential = new DefaultAzureCredential();
            CropProducts client = new FarmBeatsClient(credential).GetCropProductsClient(apiVersion: "2022-11-01-preview");

            Response response = client.Delete("<cropProductId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Delete_ShortVersion_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            CropProducts client = new FarmBeatsClient(credential).GetCropProductsClient(apiVersion: "2022-11-01-preview");

            Response response = await client.DeleteAsync("<cropProductId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Delete_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            CropProducts client = new FarmBeatsClient(credential).GetCropProductsClient(apiVersion: "2022-11-01-preview");

            Response response = client.Delete("<cropProductId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Delete_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            CropProducts client = new FarmBeatsClient(credential).GetCropProductsClient(apiVersion: "2022-11-01-preview");

            Response response = await client.DeleteAsync("<cropProductId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetCropProducts_ShortVersion()
        {
            TokenCredential credential = new DefaultAzureCredential();
            CropProducts client = new FarmBeatsClient(credential).GetCropProductsClient(apiVersion: "2022-11-01-preview");

            foreach (BinaryData item in client.GetCropProducts(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetCropProducts_ShortVersion_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            CropProducts client = new FarmBeatsClient(credential).GetCropProductsClient(apiVersion: "2022-11-01-preview");

            await foreach (BinaryData item in client.GetCropProductsAsync(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetCropProducts_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            CropProducts client = new FarmBeatsClient(credential).GetCropProductsClient(apiVersion: "2022-11-01-preview");

            foreach (BinaryData item in client.GetCropProducts(new string[] { "<cropIds>" }, new string[] { "<brands>" }, new string[] { "<products>" }, new string[] { "<traits>" }, new string[] { "<ids>" }, new string[] { "<names>" }, new string[] { "<propertyFilters>" }, new string[] { "<statuses>" }, DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), 1234, "<skipToken>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("cropIds")[0].ToString());
                Console.WriteLine(result.GetProperty("brand").ToString());
                Console.WriteLine(result.GetProperty("product").ToString());
                Console.WriteLine(result.GetProperty("trait").ToString());
                Console.WriteLine(result.GetProperty("relativeMaturity").GetProperty("unit").ToString());
                Console.WriteLine(result.GetProperty("relativeMaturity").GetProperty("value").ToString());
                Console.WriteLine(result.GetProperty("treatments")[0].ToString());
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("eTag").ToString());
                Console.WriteLine(result.GetProperty("status").ToString());
                Console.WriteLine(result.GetProperty("createdDateTime").ToString());
                Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
                Console.WriteLine(result.GetProperty("source").ToString());
                Console.WriteLine(result.GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("description").ToString());
                Console.WriteLine(result.GetProperty("createdBy").ToString());
                Console.WriteLine(result.GetProperty("modifiedBy").ToString());
                Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetCropProducts_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            CropProducts client = new FarmBeatsClient(credential).GetCropProductsClient(apiVersion: "2022-11-01-preview");

            await foreach (BinaryData item in client.GetCropProductsAsync(new string[] { "<cropIds>" }, new string[] { "<brands>" }, new string[] { "<products>" }, new string[] { "<traits>" }, new string[] { "<ids>" }, new string[] { "<names>" }, new string[] { "<propertyFilters>" }, new string[] { "<statuses>" }, DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), 1234, "<skipToken>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("cropIds")[0].ToString());
                Console.WriteLine(result.GetProperty("brand").ToString());
                Console.WriteLine(result.GetProperty("product").ToString());
                Console.WriteLine(result.GetProperty("trait").ToString());
                Console.WriteLine(result.GetProperty("relativeMaturity").GetProperty("unit").ToString());
                Console.WriteLine(result.GetProperty("relativeMaturity").GetProperty("value").ToString());
                Console.WriteLine(result.GetProperty("treatments")[0].ToString());
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("eTag").ToString());
                Console.WriteLine(result.GetProperty("status").ToString());
                Console.WriteLine(result.GetProperty("createdDateTime").ToString());
                Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
                Console.WriteLine(result.GetProperty("source").ToString());
                Console.WriteLine(result.GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("description").ToString());
                Console.WriteLine(result.GetProperty("createdBy").ToString());
                Console.WriteLine(result.GetProperty("modifiedBy").ToString());
                Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
            }
        }
    }
}
