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

namespace Azure.Communication.JobRouter.Samples
{
    public class Samples_JobRouterClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_UpsertJob()
        {
            var credential = new DefaultAzureCredential();
            var client = new JobRouterClient("<https://my-service.azure.com>", credential);

            var data = new { };

            Response response = client.UpsertJob("<id>", RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_UpsertJob_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var client = new JobRouterClient("<https://my-service.azure.com>", credential);

            var data = new
            {
                channelReference = "<channelReference>",
                channelId = "<channelId>",
                classificationPolicyId = "<classificationPolicyId>",
                queueId = "<queueId>",
                priority = 1234,
                dispositionCode = "<dispositionCode>",
                requestedWorkerSelectors = new[] {
        new {
            key = "<key>",
            labelOperator = "equal",
            value = new {},
            expiresAfterSeconds = 123.45d,
            expedite = true,
        }
    },
                labels = new
                {
                    key = new { },
                },
                tags = new
                {
                    key = new { },
                },
                notes = new
                {
                    key = "<String>",
                },
                matchingMode = new
                {
                    modeType = "queueAndMatchMode",
                    queueAndMatchMode = new { },
                    scheduleAndSuspendMode = new
                    {
                        scheduleAt = "2022-05-10T18:57:31.2311892Z",
                    },
                    suspendMode = new { },
                },
            };

            Response response = client.UpsertJob("<id>", RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("channelReference").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("enqueuedAt").ToString());
            Console.WriteLine(result.GetProperty("channelId").ToString());
            Console.WriteLine(result.GetProperty("classificationPolicyId").ToString());
            Console.WriteLine(result.GetProperty("queueId").ToString());
            Console.WriteLine(result.GetProperty("priority").ToString());
            Console.WriteLine(result.GetProperty("dispositionCode").ToString());
            Console.WriteLine(result.GetProperty("requestedWorkerSelectors")[0].GetProperty("key").ToString());
            Console.WriteLine(result.GetProperty("requestedWorkerSelectors")[0].GetProperty("labelOperator").ToString());
            Console.WriteLine(result.GetProperty("requestedWorkerSelectors")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("requestedWorkerSelectors")[0].GetProperty("expiresAfterSeconds").ToString());
            Console.WriteLine(result.GetProperty("requestedWorkerSelectors")[0].GetProperty("expedite").ToString());
            Console.WriteLine(result.GetProperty("requestedWorkerSelectors")[0].GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("requestedWorkerSelectors")[0].GetProperty("expiresAt").ToString());
            Console.WriteLine(result.GetProperty("attachedWorkerSelectors")[0].GetProperty("key").ToString());
            Console.WriteLine(result.GetProperty("attachedWorkerSelectors")[0].GetProperty("labelOperator").ToString());
            Console.WriteLine(result.GetProperty("attachedWorkerSelectors")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("attachedWorkerSelectors")[0].GetProperty("expiresAfterSeconds").ToString());
            Console.WriteLine(result.GetProperty("attachedWorkerSelectors")[0].GetProperty("expedite").ToString());
            Console.WriteLine(result.GetProperty("attachedWorkerSelectors")[0].GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("attachedWorkerSelectors")[0].GetProperty("expiresAt").ToString());
            Console.WriteLine(result.GetProperty("labels").GetProperty("<test>").ToString());
            Console.WriteLine(result.GetProperty("assignments").GetProperty("<test>").GetProperty("assignmentId").ToString());
            Console.WriteLine(result.GetProperty("assignments").GetProperty("<test>").GetProperty("workerId").ToString());
            Console.WriteLine(result.GetProperty("assignments").GetProperty("<test>").GetProperty("assignedAt").ToString());
            Console.WriteLine(result.GetProperty("assignments").GetProperty("<test>").GetProperty("completedAt").ToString());
            Console.WriteLine(result.GetProperty("assignments").GetProperty("<test>").GetProperty("closedAt").ToString());
            Console.WriteLine(result.GetProperty("tags").GetProperty("<test>").ToString());
            Console.WriteLine(result.GetProperty("notes").GetProperty("<test>").ToString());
            Console.WriteLine(result.GetProperty("scheduledAt").ToString());
            Console.WriteLine(result.GetProperty("matchingMode").GetProperty("modeType").ToString());
            Console.WriteLine(result.GetProperty("matchingMode").GetProperty("queueAndMatchMode").ToString());
            Console.WriteLine(result.GetProperty("matchingMode").GetProperty("scheduleAndSuspendMode").GetProperty("scheduleAt").ToString());
            Console.WriteLine(result.GetProperty("matchingMode").GetProperty("suspendMode").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_UpsertJob_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new JobRouterClient("<https://my-service.azure.com>", credential);

            var data = new { };

            Response response = await client.UpsertJobAsync("<id>", RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_UpsertJob_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new JobRouterClient("<https://my-service.azure.com>", credential);

            var data = new
            {
                channelReference = "<channelReference>",
                channelId = "<channelId>",
                classificationPolicyId = "<classificationPolicyId>",
                queueId = "<queueId>",
                priority = 1234,
                dispositionCode = "<dispositionCode>",
                requestedWorkerSelectors = new[] {
        new {
            key = "<key>",
            labelOperator = "equal",
            value = new {},
            expiresAfterSeconds = 123.45d,
            expedite = true,
        }
    },
                labels = new
                {
                    key = new { },
                },
                tags = new
                {
                    key = new { },
                },
                notes = new
                {
                    key = "<String>",
                },
                matchingMode = new
                {
                    modeType = "queueAndMatchMode",
                    queueAndMatchMode = new { },
                    scheduleAndSuspendMode = new
                    {
                        scheduleAt = "2022-05-10T18:57:31.2311892Z",
                    },
                    suspendMode = new { },
                },
            };

            Response response = await client.UpsertJobAsync("<id>", RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("channelReference").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("enqueuedAt").ToString());
            Console.WriteLine(result.GetProperty("channelId").ToString());
            Console.WriteLine(result.GetProperty("classificationPolicyId").ToString());
            Console.WriteLine(result.GetProperty("queueId").ToString());
            Console.WriteLine(result.GetProperty("priority").ToString());
            Console.WriteLine(result.GetProperty("dispositionCode").ToString());
            Console.WriteLine(result.GetProperty("requestedWorkerSelectors")[0].GetProperty("key").ToString());
            Console.WriteLine(result.GetProperty("requestedWorkerSelectors")[0].GetProperty("labelOperator").ToString());
            Console.WriteLine(result.GetProperty("requestedWorkerSelectors")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("requestedWorkerSelectors")[0].GetProperty("expiresAfterSeconds").ToString());
            Console.WriteLine(result.GetProperty("requestedWorkerSelectors")[0].GetProperty("expedite").ToString());
            Console.WriteLine(result.GetProperty("requestedWorkerSelectors")[0].GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("requestedWorkerSelectors")[0].GetProperty("expiresAt").ToString());
            Console.WriteLine(result.GetProperty("attachedWorkerSelectors")[0].GetProperty("key").ToString());
            Console.WriteLine(result.GetProperty("attachedWorkerSelectors")[0].GetProperty("labelOperator").ToString());
            Console.WriteLine(result.GetProperty("attachedWorkerSelectors")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("attachedWorkerSelectors")[0].GetProperty("expiresAfterSeconds").ToString());
            Console.WriteLine(result.GetProperty("attachedWorkerSelectors")[0].GetProperty("expedite").ToString());
            Console.WriteLine(result.GetProperty("attachedWorkerSelectors")[0].GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("attachedWorkerSelectors")[0].GetProperty("expiresAt").ToString());
            Console.WriteLine(result.GetProperty("labels").GetProperty("<test>").ToString());
            Console.WriteLine(result.GetProperty("assignments").GetProperty("<test>").GetProperty("assignmentId").ToString());
            Console.WriteLine(result.GetProperty("assignments").GetProperty("<test>").GetProperty("workerId").ToString());
            Console.WriteLine(result.GetProperty("assignments").GetProperty("<test>").GetProperty("assignedAt").ToString());
            Console.WriteLine(result.GetProperty("assignments").GetProperty("<test>").GetProperty("completedAt").ToString());
            Console.WriteLine(result.GetProperty("assignments").GetProperty("<test>").GetProperty("closedAt").ToString());
            Console.WriteLine(result.GetProperty("tags").GetProperty("<test>").ToString());
            Console.WriteLine(result.GetProperty("notes").GetProperty("<test>").ToString());
            Console.WriteLine(result.GetProperty("scheduledAt").ToString());
            Console.WriteLine(result.GetProperty("matchingMode").GetProperty("modeType").ToString());
            Console.WriteLine(result.GetProperty("matchingMode").GetProperty("queueAndMatchMode").ToString());
            Console.WriteLine(result.GetProperty("matchingMode").GetProperty("scheduleAndSuspendMode").GetProperty("scheduleAt").ToString());
            Console.WriteLine(result.GetProperty("matchingMode").GetProperty("suspendMode").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetJob()
        {
            var credential = new DefaultAzureCredential();
            var client = new JobRouterClient("<https://my-service.azure.com>", credential);

            Response response = client.GetJob("<id>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetJob_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var client = new JobRouterClient("<https://my-service.azure.com>", credential);

            Response response = client.GetJob("<id>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("channelReference").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("enqueuedAt").ToString());
            Console.WriteLine(result.GetProperty("channelId").ToString());
            Console.WriteLine(result.GetProperty("classificationPolicyId").ToString());
            Console.WriteLine(result.GetProperty("queueId").ToString());
            Console.WriteLine(result.GetProperty("priority").ToString());
            Console.WriteLine(result.GetProperty("dispositionCode").ToString());
            Console.WriteLine(result.GetProperty("requestedWorkerSelectors")[0].GetProperty("key").ToString());
            Console.WriteLine(result.GetProperty("requestedWorkerSelectors")[0].GetProperty("labelOperator").ToString());
            Console.WriteLine(result.GetProperty("requestedWorkerSelectors")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("requestedWorkerSelectors")[0].GetProperty("expiresAfterSeconds").ToString());
            Console.WriteLine(result.GetProperty("requestedWorkerSelectors")[0].GetProperty("expedite").ToString());
            Console.WriteLine(result.GetProperty("requestedWorkerSelectors")[0].GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("requestedWorkerSelectors")[0].GetProperty("expiresAt").ToString());
            Console.WriteLine(result.GetProperty("attachedWorkerSelectors")[0].GetProperty("key").ToString());
            Console.WriteLine(result.GetProperty("attachedWorkerSelectors")[0].GetProperty("labelOperator").ToString());
            Console.WriteLine(result.GetProperty("attachedWorkerSelectors")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("attachedWorkerSelectors")[0].GetProperty("expiresAfterSeconds").ToString());
            Console.WriteLine(result.GetProperty("attachedWorkerSelectors")[0].GetProperty("expedite").ToString());
            Console.WriteLine(result.GetProperty("attachedWorkerSelectors")[0].GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("attachedWorkerSelectors")[0].GetProperty("expiresAt").ToString());
            Console.WriteLine(result.GetProperty("labels").GetProperty("<test>").ToString());
            Console.WriteLine(result.GetProperty("assignments").GetProperty("<test>").GetProperty("assignmentId").ToString());
            Console.WriteLine(result.GetProperty("assignments").GetProperty("<test>").GetProperty("workerId").ToString());
            Console.WriteLine(result.GetProperty("assignments").GetProperty("<test>").GetProperty("assignedAt").ToString());
            Console.WriteLine(result.GetProperty("assignments").GetProperty("<test>").GetProperty("completedAt").ToString());
            Console.WriteLine(result.GetProperty("assignments").GetProperty("<test>").GetProperty("closedAt").ToString());
            Console.WriteLine(result.GetProperty("tags").GetProperty("<test>").ToString());
            Console.WriteLine(result.GetProperty("notes").GetProperty("<test>").ToString());
            Console.WriteLine(result.GetProperty("scheduledAt").ToString());
            Console.WriteLine(result.GetProperty("matchingMode").GetProperty("modeType").ToString());
            Console.WriteLine(result.GetProperty("matchingMode").GetProperty("queueAndMatchMode").ToString());
            Console.WriteLine(result.GetProperty("matchingMode").GetProperty("scheduleAndSuspendMode").GetProperty("scheduleAt").ToString());
            Console.WriteLine(result.GetProperty("matchingMode").GetProperty("suspendMode").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetJob_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new JobRouterClient("<https://my-service.azure.com>", credential);

            Response response = await client.GetJobAsync("<id>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetJob_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new JobRouterClient("<https://my-service.azure.com>", credential);

            Response response = await client.GetJobAsync("<id>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("channelReference").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("enqueuedAt").ToString());
            Console.WriteLine(result.GetProperty("channelId").ToString());
            Console.WriteLine(result.GetProperty("classificationPolicyId").ToString());
            Console.WriteLine(result.GetProperty("queueId").ToString());
            Console.WriteLine(result.GetProperty("priority").ToString());
            Console.WriteLine(result.GetProperty("dispositionCode").ToString());
            Console.WriteLine(result.GetProperty("requestedWorkerSelectors")[0].GetProperty("key").ToString());
            Console.WriteLine(result.GetProperty("requestedWorkerSelectors")[0].GetProperty("labelOperator").ToString());
            Console.WriteLine(result.GetProperty("requestedWorkerSelectors")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("requestedWorkerSelectors")[0].GetProperty("expiresAfterSeconds").ToString());
            Console.WriteLine(result.GetProperty("requestedWorkerSelectors")[0].GetProperty("expedite").ToString());
            Console.WriteLine(result.GetProperty("requestedWorkerSelectors")[0].GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("requestedWorkerSelectors")[0].GetProperty("expiresAt").ToString());
            Console.WriteLine(result.GetProperty("attachedWorkerSelectors")[0].GetProperty("key").ToString());
            Console.WriteLine(result.GetProperty("attachedWorkerSelectors")[0].GetProperty("labelOperator").ToString());
            Console.WriteLine(result.GetProperty("attachedWorkerSelectors")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("attachedWorkerSelectors")[0].GetProperty("expiresAfterSeconds").ToString());
            Console.WriteLine(result.GetProperty("attachedWorkerSelectors")[0].GetProperty("expedite").ToString());
            Console.WriteLine(result.GetProperty("attachedWorkerSelectors")[0].GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("attachedWorkerSelectors")[0].GetProperty("expiresAt").ToString());
            Console.WriteLine(result.GetProperty("labels").GetProperty("<test>").ToString());
            Console.WriteLine(result.GetProperty("assignments").GetProperty("<test>").GetProperty("assignmentId").ToString());
            Console.WriteLine(result.GetProperty("assignments").GetProperty("<test>").GetProperty("workerId").ToString());
            Console.WriteLine(result.GetProperty("assignments").GetProperty("<test>").GetProperty("assignedAt").ToString());
            Console.WriteLine(result.GetProperty("assignments").GetProperty("<test>").GetProperty("completedAt").ToString());
            Console.WriteLine(result.GetProperty("assignments").GetProperty("<test>").GetProperty("closedAt").ToString());
            Console.WriteLine(result.GetProperty("tags").GetProperty("<test>").ToString());
            Console.WriteLine(result.GetProperty("notes").GetProperty("<test>").ToString());
            Console.WriteLine(result.GetProperty("scheduledAt").ToString());
            Console.WriteLine(result.GetProperty("matchingMode").GetProperty("modeType").ToString());
            Console.WriteLine(result.GetProperty("matchingMode").GetProperty("queueAndMatchMode").ToString());
            Console.WriteLine(result.GetProperty("matchingMode").GetProperty("scheduleAndSuspendMode").GetProperty("scheduleAt").ToString());
            Console.WriteLine(result.GetProperty("matchingMode").GetProperty("suspendMode").ToString());
        }
    }
}
