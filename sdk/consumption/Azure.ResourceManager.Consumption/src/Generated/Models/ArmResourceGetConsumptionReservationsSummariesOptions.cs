// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Consumption.Models
{
    /// <summary> The ArmResourceGetConsumptionReservationsSummariesOptions. </summary>
    public partial class ArmResourceGetConsumptionReservationsSummariesOptions
    {
        /// <summary> Initializes a new instance of ArmResourceGetConsumptionReservationsSummariesOptions. </summary>
        /// <param name="grain"> Can be daily or monthly. </param>
        public ArmResourceGetConsumptionReservationsSummariesOptions(ReservationSummaryDataGrain grain)
        {
            Grain = grain;
        }

        /// <summary> Can be daily or monthly. </summary>
        public ReservationSummaryDataGrain Grain { get; }
        /// <summary> Start date. Only applicable when querying with billing profile. </summary>
        public string StartDate { get; set; }
        /// <summary> End date. Only applicable when querying with billing profile. </summary>
        public string EndDate { get; set; }
        /// <summary> Required only for daily grain. The properties/UsageDate for start date and end date. The filter supports 'le' and  'ge'. Not applicable when querying with billing profile. </summary>
        public string Filter { get; set; }
        /// <summary> Reservation Id GUID. Only valid if reservationOrderId is also provided. Filter to a specific reservation. </summary>
        public string ReservationId { get; set; }
        /// <summary> Reservation Order Id GUID. Required if reservationId is provided. Filter to a specific reservation order. </summary>
        public string ReservationOrderId { get; set; }
    }
}
