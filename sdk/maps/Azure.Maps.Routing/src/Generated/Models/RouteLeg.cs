// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Maps.Routing.Models
{
    /// <summary> A description of a part of a route, comprised of a list of points. Each additional waypoint provided in the request will result in an additional leg in the returned route. </summary>
    public partial class RouteLeg
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RouteLeg"/>. </summary>
        /// <param name="summary"> Summary object for route section. </param>
        /// <param name="points"> Points array. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RouteLeg(RouteLegSummary summary, IReadOnlyList<LatLongPair> points, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Summary = summary;
            _Points = points;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Summary object for route section. </summary>
        public RouteLegSummary Summary { get; }
    }
}
