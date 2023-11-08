// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Maps.Search.Models
{
    /// <summary> This object is returned from a successful Search Polygon call. </summary>
    public partial class PolygonResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PolygonResult"/>. </summary>
        internal PolygonResult()
        {
            Polygons = new ChangeTrackingList<PolygonObject>();
        }

        /// <summary> Initializes a new instance of <see cref="PolygonResult"/>. </summary>
        /// <param name="polygons"> Results array. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PolygonResult(IReadOnlyList<PolygonObject> polygons, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Polygons = polygons;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Results array. </summary>
        public IReadOnlyList<PolygonObject> Polygons { get; }
    }
}
