// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class Ingress : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(External))
            {
                writer.WritePropertyName("external");
                writer.WriteBooleanValue(External.Value);
            }
            if (Optional.IsDefined(TargetPort))
            {
                writer.WritePropertyName("targetPort");
                writer.WriteNumberValue(TargetPort.Value);
            }
            if (Optional.IsDefined(Transport))
            {
                writer.WritePropertyName("transport");
                writer.WriteStringValue(Transport.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Traffic))
            {
                writer.WritePropertyName("traffic");
                writer.WriteStartArray();
                foreach (var item in Traffic)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AllowInsecure))
            {
                writer.WritePropertyName("allowInsecure");
                writer.WriteBooleanValue(AllowInsecure.Value);
            }
            writer.WriteEndObject();
        }

        internal static Ingress DeserializeIngress(JsonElement element)
        {
            Optional<string> fqdn = default;
            Optional<bool> external = default;
            Optional<int> targetPort = default;
            Optional<IngressTransportMethod> transport = default;
            Optional<IList<TrafficWeight>> traffic = default;
            Optional<bool> allowInsecure = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fqdn"))
                {
                    fqdn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("external"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    external = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("targetPort"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    targetPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("transport"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    transport = new IngressTransportMethod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("traffic"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<TrafficWeight> array = new List<TrafficWeight>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TrafficWeight.DeserializeTrafficWeight(item));
                    }
                    traffic = array;
                    continue;
                }
                if (property.NameEquals("allowInsecure"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    allowInsecure = property.Value.GetBoolean();
                    continue;
                }
            }
            return new Ingress(fqdn.Value, Optional.ToNullable(external), Optional.ToNullable(targetPort), Optional.ToNullable(transport), Optional.ToList(traffic), Optional.ToNullable(allowInsecure));
        }
    }
}
