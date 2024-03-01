// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Maps.Search.Models
{
    /// <summary> A valid `GeoJSON Polygon` geometry type. Please refer to [RFC 7946](https://tools.ietf.org/html/rfc7946#section-3.1.6) for details. </summary>
    internal partial class GeoJsonPolygon : GeoJsonGeometry
    {
        /// <summary> Initializes a new instance of <see cref="GeoJsonPolygon"/>. </summary>
        /// <param name="coordinates"> Coordinates for the `GeoJson Polygon` geometry type. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="coordinates"/> is null. </exception>
        public GeoJsonPolygon(IEnumerable<IList<IList<double>>> coordinates)
        {
            if (coordinates == null)
            {
                throw new ArgumentNullException(nameof(coordinates));
            }

            Coordinates = coordinates.ToList();
            Type = GeoJsonObjectType.GeoJsonPolygon;
        }

        /// <summary> Initializes a new instance of <see cref="GeoJsonPolygon"/>. </summary>
        /// <param name="type"> Specifies the `GeoJSON` type. Must be one of the nine valid GeoJSON object types - Point, MultiPoint, LineString, MultiLineString, Polygon, MultiPolygon, GeometryCollection, Feature and FeatureCollection. </param>
        /// <param name="coordinates"> Coordinates for the `GeoJson Polygon` geometry type. </param>
        internal GeoJsonPolygon(GeoJsonObjectType type, IList<IList<IList<double>>> coordinates) : base(type)
        {
            Coordinates = coordinates;
            Type = type;
        }

        /// <summary> Coordinates for the `GeoJson Polygon` geometry type. </summary>
        public IList<IList<IList<double>>> Coordinates { get; }
    }
}
