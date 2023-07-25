// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ResourceHealth.Models
{
    /// <summary> Properties of the service impacting event. </summary>
    public partial class ServiceImpactingEventIncidentProperties
    {
        /// <summary> Initializes a new instance of ServiceImpactingEventIncidentProperties. </summary>
        internal ServiceImpactingEventIncidentProperties()
        {
        }

        /// <summary> Initializes a new instance of ServiceImpactingEventIncidentProperties. </summary>
        /// <param name="title"> Title of the incident. </param>
        /// <param name="service"> Service impacted by the event. </param>
        /// <param name="region"> Region impacted by the event. </param>
        /// <param name="incidentType"> Type of Event. </param>
        internal ServiceImpactingEventIncidentProperties(string title, string service, string region, string incidentType)
        {
            Title = title;
            Service = service;
            Region = region;
            IncidentType = incidentType;
        }

        /// <summary> Title of the incident. </summary>
        public string Title { get; }
        /// <summary> Service impacted by the event. </summary>
        public string Service { get; }
        /// <summary> Region impacted by the event. </summary>
        public string Region { get; }
        /// <summary> Type of Event. </summary>
        public string IncidentType { get; }
    }
}
