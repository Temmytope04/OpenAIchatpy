// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Maps.Route.Models
{
    /// <summary> The GeoJsonFeatureCollectionData. </summary>
    internal partial class GeoJsonFeatureCollectionData
    {
        /// <summary> Initializes a new instance of GeoJsonFeatureCollectionData. </summary>
        /// <param name="features"> Contains a list of valid `GeoJSON Feature` objects. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="features"/> is null. </exception>
        public GeoJsonFeatureCollectionData(IEnumerable<GeoJsonFeature> features)
        {
            if (features == null)
            {
                throw new ArgumentNullException(nameof(features));
            }

            Features = features.ToList();
        }

        /// <summary> Contains a list of valid `GeoJSON Feature` objects. </summary>
        public IList<GeoJsonFeature> Features { get; }
    }
}
