// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class SpatialAnalysisPersonLineCrossingOperation : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("lines"u8);
            writer.WriteStartArray();
            foreach (var item in Lines)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Debug != null)
            {
                writer.WritePropertyName("debug"u8);
                writer.WriteStringValue(Debug);
            }
            if (CalibrationConfiguration != null)
            {
                writer.WritePropertyName("calibrationConfiguration"u8);
                writer.WriteStringValue(CalibrationConfiguration);
            }
            if (CameraConfiguration != null)
            {
                writer.WritePropertyName("cameraConfiguration"u8);
                writer.WriteStringValue(CameraConfiguration);
            }
            if (CameraCalibratorNodeConfiguration != null)
            {
                writer.WritePropertyName("cameraCalibratorNodeConfiguration"u8);
                writer.WriteStringValue(CameraCalibratorNodeConfiguration);
            }
            if (DetectorNodeConfiguration != null)
            {
                writer.WritePropertyName("detectorNodeConfiguration"u8);
                writer.WriteStringValue(DetectorNodeConfiguration);
            }
            if (TrackerNodeConfiguration != null)
            {
                writer.WritePropertyName("trackerNodeConfiguration"u8);
                writer.WriteStringValue(TrackerNodeConfiguration);
            }
            if (EnableFaceMaskClassifier != null)
            {
                writer.WritePropertyName("enableFaceMaskClassifier"u8);
                writer.WriteStringValue(EnableFaceMaskClassifier);
            }
            writer.WritePropertyName("@type"u8);
            writer.WriteStringValue(Type);
            writer.WriteEndObject();
        }

        internal static SpatialAnalysisPersonLineCrossingOperation DeserializeSpatialAnalysisPersonLineCrossingOperation(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<SpatialAnalysisPersonLineCrossingLineEvents> lines = default;
            string debug = default;
            string calibrationConfiguration = default;
            string cameraConfiguration = default;
            string cameraCalibratorNodeConfiguration = default;
            string detectorNodeConfiguration = default;
            string trackerNodeConfiguration = default;
            string enableFaceMaskClassifier = default;
            string type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lines"u8))
                {
                    List<SpatialAnalysisPersonLineCrossingLineEvents> array = new List<SpatialAnalysisPersonLineCrossingLineEvents>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SpatialAnalysisPersonLineCrossingLineEvents.DeserializeSpatialAnalysisPersonLineCrossingLineEvents(item));
                    }
                    lines = array;
                    continue;
                }
                if (property.NameEquals("debug"u8))
                {
                    debug = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("calibrationConfiguration"u8))
                {
                    calibrationConfiguration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cameraConfiguration"u8))
                {
                    cameraConfiguration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cameraCalibratorNodeConfiguration"u8))
                {
                    cameraCalibratorNodeConfiguration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("detectorNodeConfiguration"u8))
                {
                    detectorNodeConfiguration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("trackerNodeConfiguration"u8))
                {
                    trackerNodeConfiguration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enableFaceMaskClassifier"u8))
                {
                    enableFaceMaskClassifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
            }
            return new SpatialAnalysisPersonLineCrossingOperation(
                type,
                debug,
                calibrationConfiguration,
                cameraConfiguration,
                cameraCalibratorNodeConfiguration,
                detectorNodeConfiguration,
                trackerNodeConfiguration,
                enableFaceMaskClassifier,
                lines);
        }
    }
}
