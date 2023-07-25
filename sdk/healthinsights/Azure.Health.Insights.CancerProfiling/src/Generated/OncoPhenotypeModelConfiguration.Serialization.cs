// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Health.Insights.CancerProfiling
{
    public partial class OncoPhenotypeModelConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Verbose))
            {
                writer.WritePropertyName("verbose"u8);
                writer.WriteBooleanValue(Verbose.Value);
            }
            if (Optional.IsDefined(IncludeEvidence))
            {
                writer.WritePropertyName("includeEvidence"u8);
                writer.WriteBooleanValue(IncludeEvidence.Value);
            }
            if (Optional.IsCollectionDefined(InferenceTypes))
            {
                writer.WritePropertyName("inferenceTypes"u8);
                writer.WriteStartArray();
                foreach (var item in InferenceTypes)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(CheckForCancerCase))
            {
                writer.WritePropertyName("checkForCancerCase"u8);
                writer.WriteBooleanValue(CheckForCancerCase.Value);
            }
            writer.WriteEndObject();
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
