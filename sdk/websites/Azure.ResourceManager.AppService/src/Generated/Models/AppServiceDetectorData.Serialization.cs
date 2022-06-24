// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class AppServiceDetectorData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Metadata))
            {
                writer.WritePropertyName("metadata");
                writer.WriteObjectValue(Metadata);
            }
            if (Optional.IsCollectionDefined(Dataset))
            {
                writer.WritePropertyName("dataset");
                writer.WriteStartArray();
                foreach (var item in Dataset)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status");
                writer.WriteObjectValue(Status);
            }
            if (Optional.IsCollectionDefined(DataProvidersMetadata))
            {
                writer.WritePropertyName("dataProvidersMetadata");
                writer.WriteStartArray();
                foreach (var item in DataProvidersMetadata)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SuggestedUtterances))
            {
                writer.WritePropertyName("suggestedUtterances");
                writer.WriteObjectValue(SuggestedUtterances);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static AppServiceDetectorData DeserializeAppServiceDetectorData(JsonElement element)
        {
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<DetectorInfo> metadata = default;
            Optional<IList<DiagnosticData>> dataset = default;
            Optional<OperationStatusAutoGenerated> status = default;
            Optional<IList<DataProviderMetadata>> dataProvidersMetadata = default;
            Optional<QueryUtterancesResults> suggestedUtterances = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("metadata"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            metadata = DetectorInfo.DeserializeDetectorInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("dataset"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<DiagnosticData> array = new List<DiagnosticData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DiagnosticData.DeserializeDiagnosticData(item));
                            }
                            dataset = array;
                            continue;
                        }
                        if (property0.NameEquals("status"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            status = OperationStatusAutoGenerated.DeserializeOperationStatusAutoGenerated(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("dataProvidersMetadata"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<DataProviderMetadata> array = new List<DataProviderMetadata>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataProviderMetadata.DeserializeDataProviderMetadata(item));
                            }
                            dataProvidersMetadata = array;
                            continue;
                        }
                        if (property0.NameEquals("suggestedUtterances"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            suggestedUtterances = QueryUtterancesResults.DeserializeQueryUtterancesResults(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AppServiceDetectorData(id, name, type, systemData.Value, metadata.Value, Optional.ToList(dataset), status.Value, Optional.ToList(dataProvidersMetadata), suggestedUtterances.Value, kind.Value);
        }
    }
}
