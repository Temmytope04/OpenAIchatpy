// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> The SpatialAnalysisPersonDistanceZoneEvents. </summary>
    public partial class SpatialAnalysisPersonDistanceZoneEvents
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SpatialAnalysisPersonDistanceZoneEvents"/>. </summary>
        /// <param name="zone">
        /// The named zone.
        /// Please note <see cref="NamedPolygonBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="NamedPolygonString"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="zone"/> is null. </exception>
        public SpatialAnalysisPersonDistanceZoneEvents(NamedPolygonBase zone)
        {
            Argument.AssertNotNull(zone, nameof(zone));

            Zone = zone;
            Events = new ChangeTrackingList<SpatialAnalysisPersonDistanceEvent>();
        }

        /// <summary> Initializes a new instance of <see cref="SpatialAnalysisPersonDistanceZoneEvents"/>. </summary>
        /// <param name="zone">
        /// The named zone.
        /// Please note <see cref="NamedPolygonBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="NamedPolygonString"/>.
        /// </param>
        /// <param name="events"> The event configuration. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SpatialAnalysisPersonDistanceZoneEvents(NamedPolygonBase zone, IList<SpatialAnalysisPersonDistanceEvent> events, Dictionary<string, BinaryData> rawData)
        {
            Zone = zone;
            Events = events;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="SpatialAnalysisPersonDistanceZoneEvents"/> for deserialization. </summary>
        internal SpatialAnalysisPersonDistanceZoneEvents()
        {
        }

        /// <summary>
        /// The named zone.
        /// Please note <see cref="NamedPolygonBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="NamedPolygonString"/>.
        /// </summary>
        public NamedPolygonBase Zone { get; set; }
        /// <summary> The event configuration. </summary>
        public IList<SpatialAnalysisPersonDistanceEvent> Events { get; }
    }
}
