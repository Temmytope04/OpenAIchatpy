// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class AutoscaleConfigurationUpdateParameter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Autoscale))
            {
                writer.WritePropertyName("autoscale");
                writer.WriteObjectValue(Autoscale);
            }
            writer.WriteEndObject();
        }
    }
}
