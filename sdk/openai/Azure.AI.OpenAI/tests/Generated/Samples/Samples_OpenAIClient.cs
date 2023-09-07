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

namespace Azure.AI.OpenAI.Samples
{
    public class Samples_OpenAIClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetCompletions_Convenience_Async()
        {
            var client = new OpenAIClient("<openAIApiKey>");

            var completionsOptions = new CompletionsOptions(new string[]
            {
    "<null>"
            })
            {
                MaxTokens = 1234,
                Temperature = 3.14f,
                NucleusSamplingFactor = 3.14f,
                User = "<User>",
                ChoicesPerPrompt = 1234,
                LogProbabilityCount = 1234,
                Echo = true,
                StopSequences =
{
        "<null>"
    },
                PresencePenalty = 3.14f,
                FrequencyPenalty = 3.14f,
                GenerationSampleCount = 1234,
            };
            var result = await client.GetCompletionsAsync("<deploymentId>", completionsOptions);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetEmbeddings_Convenience_Async()
        {
            var client = new OpenAIClient("<openAIApiKey>");

            var embeddingsOptions = new EmbeddingsOptions(new string[]
            {
    "<null>"
            })
            {
                User = "<User>",
            };
            var result = await client.GetEmbeddingsAsync("<deploymentId>", embeddingsOptions);
        }
    }
}
