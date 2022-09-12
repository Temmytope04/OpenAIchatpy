// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.Core.GeoJson;

namespace Azure.Maps.Route.Models
{
    /// <summary> A set of attributes describing a maneuver, e.g. &apos;Turn right&apos;, &apos;Keep left&apos;, &apos;Take the ferry&apos;, &apos;Take the motorway&apos;, &apos;Arrive&apos;. </summary>
    public partial class RouteInstruction
    {
        /// <summary> Initializes a new instance of RouteInstruction. </summary>
        /// <param name="routeOffsetInMeters"> Distance from the start of the route to the point of the instruction. </param>
        /// <param name="travelTimeInSeconds"> Estimated travel time up to the point corresponding to routeOffsetInMeters. </param>
        /// <param name="point"> A location represented as a latitude and longitude. </param>
        /// <param name="pointIndex"> The index of the point in the list of polyline &quot;points&quot; corresponding to the point of the instruction. </param>
        /// <param name="instructionType"> Type of the instruction, e.g., turn or change of road form. </param>
        /// <param name="roadNumbers"> The road number(s) of the next significant road segment(s) after the maneuver, or of the road(s) to be followed. Example: [&quot;E34&quot;, &quot;N205&quot;]. </param>
        /// <param name="exitNumber"> The number(s) of a highway exit taken by the current maneuver. If an exit has multiple exit numbers, they will be separated by &quot;,&quot; and possibly aggregated by &quot;-&quot;, e.g., &quot;10, 13-15&quot;. </param>
        /// <param name="street"> Street name of the next significant road segment after the maneuver, or of the street that should be followed. </param>
        /// <param name="signpostText"> The text on a signpost which is most relevant to the maneuver, or to the direction that should be followed. </param>
        /// <param name="countryCode"> 3-character [ISO 3166-1](https://www.iso.org/iso-3166-country-codes.html) alpha-3 country code. E.g. USA. </param>
        /// <param name="stateCode"> A subdivision (e.g., state) of the country, represented by the second part of an [ISO 3166-2](https://www.iso.org/standard/63546.html) code. This is only available for some countries like the US, Canada, and Mexico. </param>
        /// <param name="junctionType"> The type of the junction where the maneuver takes place. For larger roundabouts, two separate instructions are generated for entering and leaving the roundabout. </param>
        /// <param name="turnAngleInDegrees">
        /// Indicates the direction of an instruction. If junctionType indicates a turn instruction:
        ///
        ///   * 180 = U-turn
        ///   * [-179, -1] = Left turn
        ///   * 0 = Straight on (a &apos;0 degree&apos; turn)
        ///   * [1, 179] = Right turn
        ///
        /// If junctionType indicates a bifurcation instruction:
        ///
        ///   * &lt;0 - keep left
        ///   * \&gt;0 - keep right
        /// </param>
        /// <param name="roundaboutExitNumber"> This indicates which exit to take at a roundabout. </param>
        /// <param name="possibleCombineWithNext"> It is possible to optionally combine the instruction with the next one. This can be used to build messages like &quot;Turn left and then turn right&quot;. </param>
        /// <param name="drivingSide"> Indicates left-hand vs. right-hand side driving at the point of the maneuver. </param>
        /// <param name="maneuver"> A code identifying the maneuver. </param>
        /// <param name="message"> A human-readable message for the maneuver. </param>
        /// <param name="combinedMessage">
        /// A human-readable message for the maneuver combined with the message from the next instruction. Sometimes it is possible to combine two successive instructions into a single instruction making it easier to follow. When this is the case the possibleCombineWithNext flag will be true. For example:
        ///
        /// ```
        /// 10. Turn left onto Einsteinweg/A10/E22 towards Ring Amsterdam
        /// 11. Follow Einsteinweg/A10/E22 towards Ring Amsterdam
        /// ```
        ///
        /// The possibleCombineWithNext flag on instruction 10 is true. This indicates to the clients of coded guidance that it can be combined with instruction 11. The instructions will be combined automatically for clients requesting human-readable guidance. The combinedMessage field contains the combined message:
        ///
        /// ```
        /// Turn left onto Einsteinweg/A10/E22 towards Ring Amsterdam
        /// then follow Einsteinweg/A10/E22 towards Ring Amsterdam.
        /// ```
        /// </param>
        internal RouteInstruction(int? routeOffsetInMeters, int? travelTimeInSeconds, LatLongPair point, int? pointIndex, GuidanceInstructionType? instructionType, IReadOnlyList<string> roadNumbers, string exitNumber, string street, string signpostText, string countryCode, string stateCode, JunctionType? junctionType, int? turnAngleInDegrees, string roundaboutExitNumber, bool? possibleCombineWithNext, DrivingSide? drivingSide, GuidanceManeuver? maneuver, string message, string combinedMessage)
        {
            RouteOffsetInMeters = routeOffsetInMeters;
            TravelTimeInSeconds = travelTimeInSeconds;
            _Point = point;
            Point = new GeoPosition(point.Longitude, point.Latitude);
            PointIndex = pointIndex;
            InstructionType = instructionType;
            RoadNumbers = roadNumbers;
            ExitNumber = exitNumber;
            Street = street;
            SignpostText = signpostText;
            CountryCode = countryCode;
            StateCode = stateCode;
            JunctionType = junctionType;
            TurnAngleInDegrees = turnAngleInDegrees;
            RoundaboutExitNumber = roundaboutExitNumber;
            PossibleCombineWithNext = possibleCombineWithNext;
            DrivingSide = drivingSide;
            Maneuver = maneuver;
            Message = message;
            CombinedMessage = combinedMessage;
        }

        /// <summary> A location represented as a latitude and longitude. </summary>
        [CodeGenMember("Point")]
        internal LatLongPair _Point { get; }

        /// <summary> A location represented as a latitude and longitude. </summary>
        public GeoPosition Point { get; }
    }
}
