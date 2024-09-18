// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Maps.Search.Models
{
    internal partial class GeoJsonMultiPolygonData
    {
        internal static GeoJsonMultiPolygonData DeserializeGeoJsonMultiPolygonData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<IList<IList<IList<double>>>> coordinates = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("coordinates"u8))
                {
                    List<IList<IList<IList<double>>>> array = new List<IList<IList<IList<double>>>>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            List<IList<IList<double>>> array0 = new List<IList<IList<double>>>();
                            foreach (var item0 in item.EnumerateArray())
                            {
                                if (item0.ValueKind == JsonValueKind.Null)
                                {
                                    array0.Add(null);
                                }
                                else
                                {
                                    List<IList<double>> array1 = new List<IList<double>>();
                                    foreach (var item1 in item0.EnumerateArray())
                                    {
                                        if (item1.ValueKind == JsonValueKind.Null)
                                        {
                                            array1.Add(null);
                                        }
                                        else
                                        {
                                            List<double> array2 = new List<double>();
                                            foreach (var item2 in item1.EnumerateArray())
                                            {
                                                array2.Add(item2.GetDouble());
                                            }
                                            array1.Add(array2);
                                        }
                                    }
                                    array0.Add(array1);
                                }
                            }
                            array.Add(array0);
                        }
                    }
                    coordinates = array;
                    continue;
                }
            }
            return new GeoJsonMultiPolygonData(coordinates);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static GeoJsonMultiPolygonData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeGeoJsonMultiPolygonData(document.RootElement);
        }
    }
}
