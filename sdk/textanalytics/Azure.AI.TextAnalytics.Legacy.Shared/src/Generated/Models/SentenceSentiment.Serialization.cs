// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.AI.TextAnalytics.Legacy.Models;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Legacy
{
    internal partial class SentenceSentiment
    {
        internal static SentenceSentiment DeserializeSentenceSentiment(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string text = default;
            SentenceSentimentValue sentiment = default;
            SentimentConfidenceScorePerLabel confidenceScores = default;
            int offset = default;
            int length = default;
            Optional<IReadOnlyList<SentenceTarget>> targets = default;
            Optional<IReadOnlyList<SentenceAssessment>> assessments = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("text"u8))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sentiment"u8))
                {
                    sentiment = property.Value.GetString().ToSentenceSentimentValue();
                    continue;
                }
                if (property.NameEquals("confidenceScores"u8))
                {
                    confidenceScores = SentimentConfidenceScorePerLabel.DeserializeSentimentConfidenceScorePerLabel(property.Value);
                    continue;
                }
                if (property.NameEquals("offset"u8))
                {
                    offset = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("length"u8))
                {
                    length = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("targets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SentenceTarget> array = new List<SentenceTarget>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SentenceTarget.DeserializeSentenceTarget(item));
                    }
                    targets = array;
                    continue;
                }
                if (property.NameEquals("assessments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SentenceAssessment> array = new List<SentenceAssessment>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SentenceAssessment.DeserializeSentenceAssessment(item));
                    }
                    assessments = array;
                    continue;
                }
            }
            return new SentenceSentiment(text, sentiment, confidenceScores, offset, length, Optional.ToList(targets), Optional.ToList(assessments));
        }
    }
}
