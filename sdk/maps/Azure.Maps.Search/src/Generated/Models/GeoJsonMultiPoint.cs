// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Maps.Search.Models
{
    /// <summary> A valid `GeoJSON MultiPoint` geometry type. Please refer to [RFC 7946](https://tools.ietf.org/html/rfc7946#section-3.1.3) for details. </summary>
    internal partial class GeoJsonMultiPoint : GeoJsonGeometry
    {
        /// <summary> Initializes a new instance of <see cref="GeoJsonMultiPoint"/>. </summary>
        /// <param name="coordinates"> Coordinates for the `GeoJson MultiPoint` geometry. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="coordinates"/> is null. </exception>
        public GeoJsonMultiPoint(IEnumerable<IList<double>> coordinates)
        {
            Argument.AssertNotNull(coordinates, nameof(coordinates));

            Coordinates = coordinates.ToList();
            Type = GeoJsonObjectType.GeoJsonMultiPoint;
        }

        /// <summary> Initializes a new instance of <see cref="GeoJsonMultiPoint"/>. </summary>
        /// <param name="type"> Specifies the `GeoJSON` type. Must be one of the nine valid GeoJSON object types - Point, MultiPoint, LineString, MultiLineString, Polygon, MultiPolygon, GeometryCollection, Feature and FeatureCollection. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="coordinates"> Coordinates for the `GeoJson MultiPoint` geometry. </param>
        internal GeoJsonMultiPoint(GeoJsonObjectType type, IDictionary<string, BinaryData> serializedAdditionalRawData, IList<IList<double>> coordinates) : base(type, serializedAdditionalRawData)
        {
            Coordinates = coordinates;
            Type = type;
        }

        /// <summary> Initializes a new instance of <see cref="GeoJsonMultiPoint"/> for deserialization. </summary>
        internal GeoJsonMultiPoint()
        {
        }

        /// <summary> Coordinates for the `GeoJson MultiPoint` geometry. </summary>
        public IList<IList<double>> Coordinates { get; }
    }
}
