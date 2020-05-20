﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Linq;

namespace Azure.Core.Spatial
{
    /// <summary>
    ///
    /// </summary>
    public sealed class GeoMultiPolygon : Geometry
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="polygons"></param>
        public GeoMultiPolygon(IEnumerable<GeoPolygon> polygons): this(polygons, null)
        {
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="polygons"></param>
        /// <param name="properties"></param>
        public GeoMultiPolygon(IEnumerable<GeoPolygon> polygons, GeometryProperties? properties): base(properties)
        {
            Polygons = polygons.ToArray();
        }

        /// <summary>
        ///
        /// </summary>
        public IReadOnlyList<GeoPolygon> Polygons { get; }
    }
}