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
    internal class Samples_Insights
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetCascadeDeleteJobDetails_ShortVersion()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Insights client = new FarmBeatsClient(credential).GetInsightsClient(apiVersion: "2022-11-01-preview");

            Response response = client.GetCascadeDeleteJobDetails("<jobId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("resourceId").ToString());
            Console.WriteLine(result.GetProperty("resourceType").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetCascadeDeleteJobDetails_ShortVersion_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Insights client = new FarmBeatsClient(credential).GetInsightsClient(apiVersion: "2022-11-01-preview");

            Response response = await client.GetCascadeDeleteJobDetailsAsync("<jobId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("resourceId").ToString());
            Console.WriteLine(result.GetProperty("resourceType").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetCascadeDeleteJobDetails_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Insights client = new FarmBeatsClient(credential).GetInsightsClient(apiVersion: "2022-11-01-preview");

            Response response = client.GetCascadeDeleteJobDetails("<jobId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("resourceId").ToString());
            Console.WriteLine(result.GetProperty("resourceType").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("durationInSeconds").ToString());
            Console.WriteLine(result.GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errorCode").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastActionDateTime").ToString());
            Console.WriteLine(result.GetProperty("startTime").ToString());
            Console.WriteLine(result.GetProperty("endTime").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetCascadeDeleteJobDetails_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Insights client = new FarmBeatsClient(credential).GetInsightsClient(apiVersion: "2022-11-01-preview");

            Response response = await client.GetCascadeDeleteJobDetailsAsync("<jobId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("resourceId").ToString());
            Console.WriteLine(result.GetProperty("resourceType").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("durationInSeconds").ToString());
            Console.WriteLine(result.GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errorCode").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastActionDateTime").ToString());
            Console.WriteLine(result.GetProperty("startTime").ToString());
            Console.WriteLine(result.GetProperty("endTime").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateOrUpdate_ShortVersion()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Insights client = new FarmBeatsClient(credential).GetInsightsClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new object());
            Response response = client.CreateOrUpdate("<partyId>", "<modelId>", "<resourceType>", "<resourceId>", "<insightId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateOrUpdate_ShortVersion_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Insights client = new FarmBeatsClient(credential).GetInsightsClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new object());
            Response response = await client.CreateOrUpdateAsync("<partyId>", "<modelId>", "<resourceType>", "<resourceId>", "<insightId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateOrUpdate_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Insights client = new FarmBeatsClient(credential).GetInsightsClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new
            {
                modelVersion = "<modelVersion>",
                insightStartDateTime = "2022-05-10T18:57:31.2311892Z",
                insightEndDateTime = "2022-05-10T18:57:31.2311892Z",
                measurements = new
                {
                    key = new
                    {
                        unit = "<unit>",
                        value = 123.45,
                    },
                },
                status = "<status>",
                name = "<name>",
                description = "<description>",
                properties = new
                {
                    key = new object(),
                },
            });
            Response response = client.CreateOrUpdate("<partyId>", "<modelId>", "<resourceType>", "<resourceId>", "<insightId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("modelId").ToString());
            Console.WriteLine(result.GetProperty("resourceType").ToString());
            Console.WriteLine(result.GetProperty("resourceId").ToString());
            Console.WriteLine(result.GetProperty("modelVersion").ToString());
            Console.WriteLine(result.GetProperty("attachmentsLink").ToString());
            Console.WriteLine(result.GetProperty("insightStartDateTime").ToString());
            Console.WriteLine(result.GetProperty("insightEndDateTime").ToString());
            Console.WriteLine(result.GetProperty("measurements").GetProperty("<key>").GetProperty("unit").ToString());
            Console.WriteLine(result.GetProperty("measurements").GetProperty("<key>").GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
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
            Insights client = new FarmBeatsClient(credential).GetInsightsClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new
            {
                modelVersion = "<modelVersion>",
                insightStartDateTime = "2022-05-10T18:57:31.2311892Z",
                insightEndDateTime = "2022-05-10T18:57:31.2311892Z",
                measurements = new
                {
                    key = new
                    {
                        unit = "<unit>",
                        value = 123.45,
                    },
                },
                status = "<status>",
                name = "<name>",
                description = "<description>",
                properties = new
                {
                    key = new object(),
                },
            });
            Response response = await client.CreateOrUpdateAsync("<partyId>", "<modelId>", "<resourceType>", "<resourceId>", "<insightId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("modelId").ToString());
            Console.WriteLine(result.GetProperty("resourceType").ToString());
            Console.WriteLine(result.GetProperty("resourceId").ToString());
            Console.WriteLine(result.GetProperty("modelVersion").ToString());
            Console.WriteLine(result.GetProperty("attachmentsLink").ToString());
            Console.WriteLine(result.GetProperty("insightStartDateTime").ToString());
            Console.WriteLine(result.GetProperty("insightEndDateTime").ToString());
            Console.WriteLine(result.GetProperty("measurements").GetProperty("<key>").GetProperty("unit").ToString());
            Console.WriteLine(result.GetProperty("measurements").GetProperty("<key>").GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetInsight_ShortVersion()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Insights client = new FarmBeatsClient(credential).GetInsightsClient(apiVersion: "2022-11-01-preview");

            Response response = client.GetInsight("<partyId>", "<modelId>", "<resourceType>", "<resourceId>", "<insightId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetInsight_ShortVersion_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Insights client = new FarmBeatsClient(credential).GetInsightsClient(apiVersion: "2022-11-01-preview");

            Response response = await client.GetInsightAsync("<partyId>", "<modelId>", "<resourceType>", "<resourceId>", "<insightId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetInsight_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Insights client = new FarmBeatsClient(credential).GetInsightsClient(apiVersion: "2022-11-01-preview");

            Response response = client.GetInsight("<partyId>", "<modelId>", "<resourceType>", "<resourceId>", "<insightId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("modelId").ToString());
            Console.WriteLine(result.GetProperty("resourceType").ToString());
            Console.WriteLine(result.GetProperty("resourceId").ToString());
            Console.WriteLine(result.GetProperty("modelVersion").ToString());
            Console.WriteLine(result.GetProperty("attachmentsLink").ToString());
            Console.WriteLine(result.GetProperty("insightStartDateTime").ToString());
            Console.WriteLine(result.GetProperty("insightEndDateTime").ToString());
            Console.WriteLine(result.GetProperty("measurements").GetProperty("<key>").GetProperty("unit").ToString());
            Console.WriteLine(result.GetProperty("measurements").GetProperty("<key>").GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetInsight_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Insights client = new FarmBeatsClient(credential).GetInsightsClient(apiVersion: "2022-11-01-preview");

            Response response = await client.GetInsightAsync("<partyId>", "<modelId>", "<resourceType>", "<resourceId>", "<insightId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("modelId").ToString());
            Console.WriteLine(result.GetProperty("resourceType").ToString());
            Console.WriteLine(result.GetProperty("resourceId").ToString());
            Console.WriteLine(result.GetProperty("modelVersion").ToString());
            Console.WriteLine(result.GetProperty("attachmentsLink").ToString());
            Console.WriteLine(result.GetProperty("insightStartDateTime").ToString());
            Console.WriteLine(result.GetProperty("insightEndDateTime").ToString());
            Console.WriteLine(result.GetProperty("measurements").GetProperty("<key>").GetProperty("unit").ToString());
            Console.WriteLine(result.GetProperty("measurements").GetProperty("<key>").GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
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
            Insights client = new FarmBeatsClient(credential).GetInsightsClient(apiVersion: "2022-11-01-preview");

            Response response = client.Delete("<partyId>", "<modelId>", "<resourceType>", "<resourceId>", "<insightId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Delete_ShortVersion_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Insights client = new FarmBeatsClient(credential).GetInsightsClient(apiVersion: "2022-11-01-preview");

            Response response = await client.DeleteAsync("<partyId>", "<modelId>", "<resourceType>", "<resourceId>", "<insightId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Delete_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Insights client = new FarmBeatsClient(credential).GetInsightsClient(apiVersion: "2022-11-01-preview");

            Response response = client.Delete("<partyId>", "<modelId>", "<resourceType>", "<resourceId>", "<insightId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Delete_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Insights client = new FarmBeatsClient(credential).GetInsightsClient(apiVersion: "2022-11-01-preview");

            Response response = await client.DeleteAsync("<partyId>", "<modelId>", "<resourceType>", "<resourceId>", "<insightId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetInsightsByPartyIdModelIdAndResource_ShortVersion()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Insights client = new FarmBeatsClient(credential).GetInsightsClient(apiVersion: "2022-11-01-preview");

            foreach (BinaryData item in client.GetInsightsByPartyIdModelIdAndResource("<partyId>", "<modelId>", "<resourceType>", "<resourceId>", null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetInsightsByPartyIdModelIdAndResource_ShortVersion_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Insights client = new FarmBeatsClient(credential).GetInsightsClient(apiVersion: "2022-11-01-preview");

            await foreach (BinaryData item in client.GetInsightsByPartyIdModelIdAndResourceAsync("<partyId>", "<modelId>", "<resourceType>", "<resourceId>", null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetInsightsByPartyIdModelIdAndResource_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Insights client = new FarmBeatsClient(credential).GetInsightsClient(apiVersion: "2022-11-01-preview");

            foreach (BinaryData item in client.GetInsightsByPartyIdModelIdAndResource("<partyId>", "<modelId>", "<resourceType>", "<resourceId>", DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), new List<string>()
{
"<measurementFilters>"
}, new List<string>()
{
"<ids>"
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
                Console.WriteLine(result[0].GetProperty("partyId").ToString());
                Console.WriteLine(result[0].GetProperty("modelId").ToString());
                Console.WriteLine(result[0].GetProperty("resourceType").ToString());
                Console.WriteLine(result[0].GetProperty("resourceId").ToString());
                Console.WriteLine(result[0].GetProperty("modelVersion").ToString());
                Console.WriteLine(result[0].GetProperty("attachmentsLink").ToString());
                Console.WriteLine(result[0].GetProperty("insightStartDateTime").ToString());
                Console.WriteLine(result[0].GetProperty("insightEndDateTime").ToString());
                Console.WriteLine(result[0].GetProperty("measurements").GetProperty("<key>").GetProperty("unit").ToString());
                Console.WriteLine(result[0].GetProperty("measurements").GetProperty("<key>").GetProperty("value").ToString());
                Console.WriteLine(result[0].GetProperty("id").ToString());
                Console.WriteLine(result[0].GetProperty("status").ToString());
                Console.WriteLine(result[0].GetProperty("createdDateTime").ToString());
                Console.WriteLine(result[0].GetProperty("modifiedDateTime").ToString());
                Console.WriteLine(result[0].GetProperty("eTag").ToString());
                Console.WriteLine(result[0].GetProperty("name").ToString());
                Console.WriteLine(result[0].GetProperty("description").ToString());
                Console.WriteLine(result[0].GetProperty("createdBy").ToString());
                Console.WriteLine(result[0].GetProperty("modifiedBy").ToString());
                Console.WriteLine(result[0].GetProperty("properties").GetProperty("<key>").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetInsightsByPartyIdModelIdAndResource_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Insights client = new FarmBeatsClient(credential).GetInsightsClient(apiVersion: "2022-11-01-preview");

            await foreach (BinaryData item in client.GetInsightsByPartyIdModelIdAndResourceAsync("<partyId>", "<modelId>", "<resourceType>", "<resourceId>", DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), new List<string>()
{
"<measurementFilters>"
}, new List<string>()
{
"<ids>"
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
                Console.WriteLine(result[0].GetProperty("partyId").ToString());
                Console.WriteLine(result[0].GetProperty("modelId").ToString());
                Console.WriteLine(result[0].GetProperty("resourceType").ToString());
                Console.WriteLine(result[0].GetProperty("resourceId").ToString());
                Console.WriteLine(result[0].GetProperty("modelVersion").ToString());
                Console.WriteLine(result[0].GetProperty("attachmentsLink").ToString());
                Console.WriteLine(result[0].GetProperty("insightStartDateTime").ToString());
                Console.WriteLine(result[0].GetProperty("insightEndDateTime").ToString());
                Console.WriteLine(result[0].GetProperty("measurements").GetProperty("<key>").GetProperty("unit").ToString());
                Console.WriteLine(result[0].GetProperty("measurements").GetProperty("<key>").GetProperty("value").ToString());
                Console.WriteLine(result[0].GetProperty("id").ToString());
                Console.WriteLine(result[0].GetProperty("status").ToString());
                Console.WriteLine(result[0].GetProperty("createdDateTime").ToString());
                Console.WriteLine(result[0].GetProperty("modifiedDateTime").ToString());
                Console.WriteLine(result[0].GetProperty("eTag").ToString());
                Console.WriteLine(result[0].GetProperty("name").ToString());
                Console.WriteLine(result[0].GetProperty("description").ToString());
                Console.WriteLine(result[0].GetProperty("createdBy").ToString());
                Console.WriteLine(result[0].GetProperty("modifiedBy").ToString());
                Console.WriteLine(result[0].GetProperty("properties").GetProperty("<key>").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateCascadeDeleteJob_ShortVersion()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Insights client = new FarmBeatsClient(credential).GetInsightsClient(apiVersion: "2022-11-01-preview");

            Operation<BinaryData> operation = client.CreateCascadeDeleteJob(WaitUntil.Completed, "<jobId>", "<partyId>", "<modelId>", "<resourceType>", "<resourceId>", "<insightId>", null);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("resourceId").ToString());
            Console.WriteLine(result.GetProperty("resourceType").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateCascadeDeleteJob_ShortVersion_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Insights client = new FarmBeatsClient(credential).GetInsightsClient(apiVersion: "2022-11-01-preview");

            Operation<BinaryData> operation = await client.CreateCascadeDeleteJobAsync(WaitUntil.Completed, "<jobId>", "<partyId>", "<modelId>", "<resourceType>", "<resourceId>", "<insightId>", null);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("resourceId").ToString());
            Console.WriteLine(result.GetProperty("resourceType").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateCascadeDeleteJob_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Insights client = new FarmBeatsClient(credential).GetInsightsClient(apiVersion: "2022-11-01-preview");

            Operation<BinaryData> operation = client.CreateCascadeDeleteJob(WaitUntil.Completed, "<jobId>", "<partyId>", "<modelId>", "<resourceType>", "<resourceId>", "<insightId>", null);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("resourceId").ToString());
            Console.WriteLine(result.GetProperty("resourceType").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("durationInSeconds").ToString());
            Console.WriteLine(result.GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errorCode").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastActionDateTime").ToString());
            Console.WriteLine(result.GetProperty("startTime").ToString());
            Console.WriteLine(result.GetProperty("endTime").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateCascadeDeleteJob_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Insights client = new FarmBeatsClient(credential).GetInsightsClient(apiVersion: "2022-11-01-preview");

            Operation<BinaryData> operation = await client.CreateCascadeDeleteJobAsync(WaitUntil.Completed, "<jobId>", "<partyId>", "<modelId>", "<resourceType>", "<resourceId>", "<insightId>", null);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("resourceId").ToString());
            Console.WriteLine(result.GetProperty("resourceType").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("durationInSeconds").ToString());
            Console.WriteLine(result.GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errorCode").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastActionDateTime").ToString());
            Console.WriteLine(result.GetProperty("startTime").ToString());
            Console.WriteLine(result.GetProperty("endTime").ToString());
        }
    }
}
