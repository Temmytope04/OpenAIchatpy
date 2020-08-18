// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class BgpPeerStatusListResult
    {
        internal static BgpPeerStatusListResult DeserializeBgpPeerStatusListResult(JsonElement element)
        {
            Optional<IReadOnlyList<BgpPeerStatus>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<BgpPeerStatus> array = new List<BgpPeerStatus>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BgpPeerStatus.DeserializeBgpPeerStatus(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new BgpPeerStatusListResult(Optional.ToList(value));
        }
    }
}
