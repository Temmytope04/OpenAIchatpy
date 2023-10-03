// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.AI.TextAnalytics.Legacy.Models;

namespace Azure.AI.TextAnalytics.Legacy
{
    internal partial class SentenceTarget
    {
        internal static SentenceTarget DeserializeSentenceTarget(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TokenSentimentValue sentiment = default;
            TargetConfidenceScoreLabel confidenceScores = default;
            int offset = default;
            int length = default;
            string text = default;
            IReadOnlyList<TargetRelation> relations = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sentiment"u8))
                {
                    sentiment = property.Value.GetString().ToTokenSentimentValue();
                    continue;
                }
                if (property.NameEquals("confidenceScores"u8))
                {
                    confidenceScores = TargetConfidenceScoreLabel.DeserializeTargetConfidenceScoreLabel(property.Value);
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
                if (property.NameEquals("text"u8))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("relations"u8))
                {
                    List<TargetRelation> array = new List<TargetRelation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TargetRelation.DeserializeTargetRelation(item));
                    }
                    relations = array;
                    continue;
                }
            }
            return new SentenceTarget(sentiment, confidenceScores, offset, length, text, relations);
        }
    }
}
