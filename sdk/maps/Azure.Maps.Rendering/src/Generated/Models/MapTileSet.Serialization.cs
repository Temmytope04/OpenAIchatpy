// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Rendering
{
    public partial class MapTileSet : IUtf8JsonSerializable, IJsonModel<MapTileSet>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MapTileSet>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<MapTileSet>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TileJsonVersion))
            {
                writer.WritePropertyName("tilejson"u8);
                writer.WriteStringValue(TileJsonVersion);
            }
            if (Optional.IsDefined(TileSetName))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(TileSetName);
            }
            if (Optional.IsDefined(TileSetDescription))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(TileSetDescription);
            }
            if (Optional.IsDefined(TileSetVersion))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(TileSetVersion);
            }
            if (Optional.IsDefined(CopyrightAttribution))
            {
                writer.WritePropertyName("attribution"u8);
                writer.WriteStringValue(CopyrightAttribution);
            }
            if (Optional.IsDefined(Template))
            {
                writer.WritePropertyName("template"u8);
                writer.WriteStringValue(Template);
            }
            if (Optional.IsDefined(MapTileLegend))
            {
                writer.WritePropertyName("legend"u8);
                writer.WriteStringValue(MapTileLegend);
            }
            if (Optional.IsDefined(SchemeInternal))
            {
                writer.WritePropertyName("scheme"u8);
                writer.WriteStringValue(SchemeInternal);
            }
            if (Optional.IsCollectionDefined(TileEndpoints))
            {
                writer.WritePropertyName("tiles"u8);
                writer.WriteStartArray();
                foreach (var item in TileEndpoints)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Grids))
            {
                writer.WritePropertyName("grids"u8);
                writer.WriteStartArray();
                foreach (var item in Grids)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(GeoJsonDataFiles))
            {
                writer.WritePropertyName("data"u8);
                writer.WriteStartArray();
                foreach (var item in GeoJsonDataFiles)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(MinZoomLevel))
            {
                writer.WritePropertyName("minzoom"u8);
                writer.WriteNumberValue(MinZoomLevel.Value);
            }
            if (Optional.IsDefined(MaxZoomLevel))
            {
                writer.WritePropertyName("maxzoom"u8);
                writer.WriteNumberValue(MaxZoomLevel.Value);
            }
            if (Optional.IsCollectionDefined(BoundsInternal))
            {
                writer.WritePropertyName("bounds"u8);
                writer.WriteStartArray();
                foreach (var item in BoundsInternal)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(CenterInternal))
            {
                writer.WritePropertyName("center"u8);
                writer.WriteStartArray();
                foreach (var item in CenterInternal)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        MapTileSet IJsonModel<MapTileSet>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MapTileSet)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMapTileSet(document.RootElement, options);
        }

        internal static MapTileSet DeserializeMapTileSet(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> tilejson = default;
            Optional<string> name = default;
            Optional<string> description = default;
            Optional<string> version = default;
            Optional<string> attribution = default;
            Optional<string> template = default;
            Optional<string> legend = default;
            Optional<string> scheme = default;
            Optional<IReadOnlyList<string>> tiles = default;
            Optional<IReadOnlyList<string>> grids = default;
            Optional<IReadOnlyList<string>> data = default;
            Optional<int> minzoom = default;
            Optional<int> maxzoom = default;
            Optional<IReadOnlyList<float>> bounds = default;
            Optional<IReadOnlyList<float>> center = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tilejson"u8))
                {
                    tilejson = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("attribution"u8))
                {
                    attribution = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("template"u8))
                {
                    template = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("legend"u8))
                {
                    legend = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scheme"u8))
                {
                    scheme = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    tiles = array;
                    continue;
                }
                if (property.NameEquals("grids"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    grids = array;
                    continue;
                }
                if (property.NameEquals("data"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    data = array;
                    continue;
                }
                if (property.NameEquals("minzoom"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minzoom = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxzoom"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxzoom = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("bounds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<float> array = new List<float>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetSingle());
                    }
                    bounds = array;
                    continue;
                }
                if (property.NameEquals("center"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<float> array = new List<float>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetSingle());
                    }
                    center = array;
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MapTileSet(tilejson.Value, name.Value, description.Value, version.Value, attribution.Value, template.Value, legend.Value, scheme.Value, Optional.ToList(tiles), Optional.ToList(grids), Optional.ToList(data), Optional.ToNullable(minzoom), Optional.ToNullable(maxzoom), Optional.ToList(bounds), Optional.ToList(center), serializedAdditionalRawData);
        }

        BinaryData IModel<MapTileSet>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MapTileSet)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MapTileSet IModel<MapTileSet>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MapTileSet)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMapTileSet(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<MapTileSet>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
