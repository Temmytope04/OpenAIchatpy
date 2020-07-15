// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ExpressRoutePortsLocationBandwidths : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(OfferName))
            {
                writer.WritePropertyName("offerName");
                writer.WriteStringValue(OfferName);
            }
            if (Optional.IsDefined(ValueInGbps))
            {
                writer.WritePropertyName("valueInGbps");
                writer.WriteNumberValue(ValueInGbps.Value);
            }
            writer.WriteEndObject();
        }

        internal static ExpressRoutePortsLocationBandwidths DeserializeExpressRoutePortsLocationBandwidths(JsonElement element)
        {
            Optional<string> offerName = default;
            Optional<int> valueInGbps = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("offerName"))
                {
                    offerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("valueInGbps"))
                {
                    valueInGbps = property.Value.GetInt32();
                    continue;
                }
            }
            return new ExpressRoutePortsLocationBandwidths(offerName.Value, Optional.ToNullable(valueInGbps));
        }
    }
}
