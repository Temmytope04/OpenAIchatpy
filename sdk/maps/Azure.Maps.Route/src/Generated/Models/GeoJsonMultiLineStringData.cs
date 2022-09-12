// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Maps.Route.Models
{
    /// <summary> The GeoJsonMultiLineStringData. </summary>
    internal partial class GeoJsonMultiLineStringData
    {
        /// <summary> Initializes a new instance of GeoJsonMultiLineStringData. </summary>
        /// <param name="coordinates"> Coordinates for the `GeoJson MultiLineString` geometry. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="coordinates"/> is null. </exception>
        public GeoJsonMultiLineStringData(IEnumerable<IList<IList<double>>> coordinates)
        {
            if (coordinates == null)
            {
                throw new ArgumentNullException(nameof(coordinates));
            }

            Coordinates = coordinates.ToList();
        }

        /// <summary> Coordinates for the `GeoJson MultiLineString` geometry. </summary>
        public IList<IList<IList<double>>> Coordinates { get; }
    }
}
