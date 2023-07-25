// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Health.Insights.ClinicalMatching
{
    public partial class TrialMatcherResults
    {
        internal static TrialMatcherResults DeserializeTrialMatcherResults(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<TrialMatcherPatientResult> patients = default;
            string modelVersion = default;
            Optional<DateTimeOffset> knowledgeGraphLastUpdateDate = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("patients"u8))
                {
                    List<TrialMatcherPatientResult> array = new List<TrialMatcherPatientResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TrialMatcherPatientResult.DeserializeTrialMatcherPatientResult(item));
                    }
                    patients = array;
                    continue;
                }
                if (property.NameEquals("modelVersion"u8))
                {
                    modelVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("knowledgeGraphLastUpdateDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    knowledgeGraphLastUpdateDate = property.Value.GetDateTimeOffset("D");
                    continue;
                }
            }
            return new TrialMatcherResults(patients, modelVersion, Optional.ToNullable(knowledgeGraphLastUpdateDate));
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static TrialMatcherResults FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeTrialMatcherResults(document.RootElement);
        }
    }
}
