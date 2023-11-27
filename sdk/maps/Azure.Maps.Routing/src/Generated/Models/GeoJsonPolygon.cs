// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Maps.Routing.Models
{
    /// <summary> A valid `GeoJSON Polygon` geometry type. Please refer to [RFC 7946](https://tools.ietf.org/html/rfc7946#section-3.1.6) for details. </summary>
    internal partial class GeoJsonPolygon : GeoJsonGeometry
    {
        /// <summary> Initializes a new instance of <see cref="GeoJsonPolygon"/>. </summary>
        /// <param name="coordinates"> Coordinates for the `GeoJson Polygon` geometry type. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="coordinates"/> is null. </exception>
        public GeoJsonPolygon(IEnumerable<IList<IList<double>>> coordinates)
        {
            Argument.AssertNotNull(coordinates, nameof(coordinates));

            Coordinates = coordinates.ToList();
            Type = GeoJsonObjectType.GeoJsonPolygon;
        }

        /// <summary> Coordinates for the `GeoJson Polygon` geometry type. </summary>
        public IList<IList<IList<double>>> Coordinates { get; }
    }
}
