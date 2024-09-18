// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.SecurityInsights
{
    public partial class TriggeredAnalyticsRuleRunResource : IJsonModel<TriggeredAnalyticsRuleRunData>
    {
        void IJsonModel<TriggeredAnalyticsRuleRunData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<TriggeredAnalyticsRuleRunData>)Data).Write(writer, options);

        TriggeredAnalyticsRuleRunData IJsonModel<TriggeredAnalyticsRuleRunData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<TriggeredAnalyticsRuleRunData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<TriggeredAnalyticsRuleRunData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        TriggeredAnalyticsRuleRunData IPersistableModel<TriggeredAnalyticsRuleRunData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<TriggeredAnalyticsRuleRunData>(data, options);

        string IPersistableModel<TriggeredAnalyticsRuleRunData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<TriggeredAnalyticsRuleRunData>)Data).GetFormatFromOptions(options);
    }
}
