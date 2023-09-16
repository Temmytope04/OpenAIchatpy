// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.Verticals.AgriFood.Farming;
using NUnit.Framework;

namespace Azure.Verticals.AgriFood.Farming.Samples
{
    internal class Samples_Seasons
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetSeason()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Seasons client = new FarmBeatsClient(credential).GetSeasonsClient(apiVersion: "2022-11-01-preview");

            Response response = client.GetSeason("<seasonId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetSeason_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Seasons client = new FarmBeatsClient(credential).GetSeasonsClient(apiVersion: "2022-11-01-preview");

            Response response = client.GetSeason("<seasonId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("startDateTime").ToString());
            Console.WriteLine(result.GetProperty("endDateTime").ToString());
            Console.WriteLine(result.GetProperty("year").ToString());
            Console.WriteLine(result.GetProperty("geographicIdentifier").ToString());
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
        public async Task Example_GetSeason_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Seasons client = new FarmBeatsClient(credential).GetSeasonsClient(apiVersion: "2022-11-01-preview");

            Response response = await client.GetSeasonAsync("<seasonId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetSeason_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Seasons client = new FarmBeatsClient(credential).GetSeasonsClient(apiVersion: "2022-11-01-preview");

            Response response = await client.GetSeasonAsync("<seasonId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("startDateTime").ToString());
            Console.WriteLine(result.GetProperty("endDateTime").ToString());
            Console.WriteLine(result.GetProperty("year").ToString());
            Console.WriteLine(result.GetProperty("geographicIdentifier").ToString());
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
        public void Example_CreateOrUpdate()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Seasons client = new FarmBeatsClient(credential).GetSeasonsClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new object());
            Response response = client.CreateOrUpdate("<seasonId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateOrUpdate_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Seasons client = new FarmBeatsClient(credential).GetSeasonsClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new
            {
                startDateTime = "2022-05-10T18:57:31.2311892Z",
                endDateTime = "2022-05-10T18:57:31.2311892Z",
                year = 1234,
                geographicIdentifier = "<geographicIdentifier>",
                status = "<status>",
                source = "<source>",
                name = "<name>",
                description = "<description>",
                properties = new
                {
                    key = new object(),
                },
            });
            Response response = client.CreateOrUpdate("<seasonId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("startDateTime").ToString());
            Console.WriteLine(result.GetProperty("endDateTime").ToString());
            Console.WriteLine(result.GetProperty("year").ToString());
            Console.WriteLine(result.GetProperty("geographicIdentifier").ToString());
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
        public async Task Example_CreateOrUpdate_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Seasons client = new FarmBeatsClient(credential).GetSeasonsClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new object());
            Response response = await client.CreateOrUpdateAsync("<seasonId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateOrUpdate_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Seasons client = new FarmBeatsClient(credential).GetSeasonsClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new
            {
                startDateTime = "2022-05-10T18:57:31.2311892Z",
                endDateTime = "2022-05-10T18:57:31.2311892Z",
                year = 1234,
                geographicIdentifier = "<geographicIdentifier>",
                status = "<status>",
                source = "<source>",
                name = "<name>",
                description = "<description>",
                properties = new
                {
                    key = new object(),
                },
            });
            Response response = await client.CreateOrUpdateAsync("<seasonId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("startDateTime").ToString());
            Console.WriteLine(result.GetProperty("endDateTime").ToString());
            Console.WriteLine(result.GetProperty("year").ToString());
            Console.WriteLine(result.GetProperty("geographicIdentifier").ToString());
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
        public void Example_Delete()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Seasons client = new FarmBeatsClient(credential).GetSeasonsClient(apiVersion: "2022-11-01-preview");

            Response response = client.Delete("<seasonId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Delete_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Seasons client = new FarmBeatsClient(credential).GetSeasonsClient(apiVersion: "2022-11-01-preview");

            Response response = client.Delete("<seasonId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Delete_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Seasons client = new FarmBeatsClient(credential).GetSeasonsClient(apiVersion: "2022-11-01-preview");

            Response response = await client.DeleteAsync("<seasonId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Delete_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Seasons client = new FarmBeatsClient(credential).GetSeasonsClient(apiVersion: "2022-11-01-preview");

            Response response = await client.DeleteAsync("<seasonId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetSeasons()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Seasons client = new FarmBeatsClient(credential).GetSeasonsClient(apiVersion: "2022-11-01-preview");

            foreach (BinaryData item in client.GetSeasons(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetSeasons_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Seasons client = new FarmBeatsClient(credential).GetSeasonsClient(apiVersion: "2022-11-01-preview");

            foreach (BinaryData item in client.GetSeasons(DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), new List<int>()
{
1234
}, new List<string>()
{
"<seasonIds>"
}, new List<string>()
{
"<names>"
}, new List<string>()
{
"<propertyFilters>"
}, new List<string>()
{
"<statuses>"
}, DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), 1234, "<skipToken>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].GetProperty("startDateTime").ToString());
                Console.WriteLine(result[0].GetProperty("endDateTime").ToString());
                Console.WriteLine(result[0].GetProperty("year").ToString());
                Console.WriteLine(result[0].GetProperty("geographicIdentifier").ToString());
                Console.WriteLine(result[0].GetProperty("id").ToString());
                Console.WriteLine(result[0].GetProperty("eTag").ToString());
                Console.WriteLine(result[0].GetProperty("status").ToString());
                Console.WriteLine(result[0].GetProperty("createdDateTime").ToString());
                Console.WriteLine(result[0].GetProperty("modifiedDateTime").ToString());
                Console.WriteLine(result[0].GetProperty("source").ToString());
                Console.WriteLine(result[0].GetProperty("name").ToString());
                Console.WriteLine(result[0].GetProperty("description").ToString());
                Console.WriteLine(result[0].GetProperty("createdBy").ToString());
                Console.WriteLine(result[0].GetProperty("modifiedBy").ToString());
                Console.WriteLine(result[0].GetProperty("properties").GetProperty("<key>").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetSeasons_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Seasons client = new FarmBeatsClient(credential).GetSeasonsClient(apiVersion: "2022-11-01-preview");

            await foreach (BinaryData item in client.GetSeasonsAsync(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetSeasons_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Seasons client = new FarmBeatsClient(credential).GetSeasonsClient(apiVersion: "2022-11-01-preview");

            await foreach (BinaryData item in client.GetSeasonsAsync(DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), new List<int>()
{
1234
}, new List<string>()
{
"<seasonIds>"
}, new List<string>()
{
"<names>"
}, new List<string>()
{
"<propertyFilters>"
}, new List<string>()
{
"<statuses>"
}, DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), 1234, "<skipToken>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].GetProperty("startDateTime").ToString());
                Console.WriteLine(result[0].GetProperty("endDateTime").ToString());
                Console.WriteLine(result[0].GetProperty("year").ToString());
                Console.WriteLine(result[0].GetProperty("geographicIdentifier").ToString());
                Console.WriteLine(result[0].GetProperty("id").ToString());
                Console.WriteLine(result[0].GetProperty("eTag").ToString());
                Console.WriteLine(result[0].GetProperty("status").ToString());
                Console.WriteLine(result[0].GetProperty("createdDateTime").ToString());
                Console.WriteLine(result[0].GetProperty("modifiedDateTime").ToString());
                Console.WriteLine(result[0].GetProperty("source").ToString());
                Console.WriteLine(result[0].GetProperty("name").ToString());
                Console.WriteLine(result[0].GetProperty("description").ToString());
                Console.WriteLine(result[0].GetProperty("createdBy").ToString());
                Console.WriteLine(result[0].GetProperty("modifiedBy").ToString());
                Console.WriteLine(result[0].GetProperty("properties").GetProperty("<key>").ToString());
            }
        }
    }
}
