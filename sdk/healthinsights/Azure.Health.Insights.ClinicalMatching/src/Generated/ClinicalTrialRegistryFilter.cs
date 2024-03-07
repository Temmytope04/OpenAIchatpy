// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Health.Insights.ClinicalMatching
{
    /// <summary> A filter defining a subset of clinical trials from a given clinical trial registry (e.g. clinicaltrials.gov). </summary>
    public partial class ClinicalTrialRegistryFilter
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ClinicalTrialRegistryFilter"/>. </summary>
        public ClinicalTrialRegistryFilter()
        {
            Conditions = new ChangeTrackingList<string>();
            StudyTypes = new ChangeTrackingList<ClinicalTrialStudyType>();
            RecruitmentStatuses = new ChangeTrackingList<ClinicalTrialRecruitmentStatus>();
            Sponsors = new ChangeTrackingList<string>();
            Phases = new ChangeTrackingList<ClinicalTrialPhase>();
            Purposes = new ChangeTrackingList<ClinicalTrialPurpose>();
            Ids = new ChangeTrackingList<string>();
            Sources = new ChangeTrackingList<ClinicalTrialSource>();
            FacilityNames = new ChangeTrackingList<string>();
            FacilityLocations = new ChangeTrackingList<GeographicLocation>();
            FacilityAreas = new ChangeTrackingList<GeographicArea>();
        }

        /// <summary> Initializes a new instance of <see cref="ClinicalTrialRegistryFilter"/>. </summary>
        /// <param name="conditions">
        /// Trials with any of the given medical conditions will be included in the selection (provided that other limitations are satisfied).
        /// Leaving this list empty will not limit the medical conditions.
        /// </param>
        /// <param name="studyTypes">
        /// Trials with any of the given study types will be included in the selection (provided that other limitations are satisfied).
        /// Leaving this list empty will not limit the study types.
        /// </param>
        /// <param name="recruitmentStatuses">
        /// Trials with any of the given recruitment statuses will be included in the selection (provided that other limitations are satisfied).
        /// Leaving this list empty will not limit the recruitment statuses.
        /// </param>
        /// <param name="sponsors">
        /// Trials with any of the given sponsors will be included in the selection (provided that other limitations are satisfied).
        /// Leaving this list empty will not limit the sponsors.
        /// </param>
        /// <param name="phases">
        /// Trials with any of the given phases will be included in the selection (provided that other limitations are satisfied).
        /// Leaving this list empty will not limit the phases.
        /// </param>
        /// <param name="purposes">
        /// Trials with any of the given purposes will be included in the selection (provided that other limitations are satisfied).
        /// Leaving this list empty will not limit the purposes.
        /// </param>
        /// <param name="ids">
        /// Trials with any of the given identifiers will be included in the selection (provided that other limitations are satisfied).
        /// Leaving this list empty will not limit the trial identifiers.
        /// </param>
        /// <param name="sources">
        /// Trials with any of the given sources will be included in the selection (provided that other limitations are satisfied).
        /// Leaving this list empty will not limit the sources.
        /// </param>
        /// <param name="facilityNames">
        /// Trials with any of the given facility names will be included in the selection (provided that other limitations are satisfied).
        /// Leaving this list empty will not limit the trial facility names.
        /// </param>
        /// <param name="facilityLocations">
        /// Trials with any of the given facility locations will be included in the selection (provided that other limitations are satisfied).
        /// Leaving this list empty will not limit the trial facility locations.
        /// </param>
        /// <param name="facilityAreas">
        /// Trials with any of the given facility area boundaries will be included in the selection (provided that other limitations are satisfied).
        /// Leaving this list empty will not limit the trial facility area boundaries.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ClinicalTrialRegistryFilter(IList<string> conditions, IList<ClinicalTrialStudyType> studyTypes, IList<ClinicalTrialRecruitmentStatus> recruitmentStatuses, IList<string> sponsors, IList<ClinicalTrialPhase> phases, IList<ClinicalTrialPurpose> purposes, IList<string> ids, IList<ClinicalTrialSource> sources, IList<string> facilityNames, IList<GeographicLocation> facilityLocations, IList<GeographicArea> facilityAreas, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Conditions = conditions;
            StudyTypes = studyTypes;
            RecruitmentStatuses = recruitmentStatuses;
            Sponsors = sponsors;
            Phases = phases;
            Purposes = purposes;
            Ids = ids;
            Sources = sources;
            FacilityNames = facilityNames;
            FacilityLocations = facilityLocations;
            FacilityAreas = facilityAreas;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Trials with any of the given medical conditions will be included in the selection (provided that other limitations are satisfied).
        /// Leaving this list empty will not limit the medical conditions.
        /// </summary>
        public IList<string> Conditions { get; }
        /// <summary>
        /// Trials with any of the given study types will be included in the selection (provided that other limitations are satisfied).
        /// Leaving this list empty will not limit the study types.
        /// </summary>
        public IList<ClinicalTrialStudyType> StudyTypes { get; }
        /// <summary>
        /// Trials with any of the given recruitment statuses will be included in the selection (provided that other limitations are satisfied).
        /// Leaving this list empty will not limit the recruitment statuses.
        /// </summary>
        public IList<ClinicalTrialRecruitmentStatus> RecruitmentStatuses { get; }
        /// <summary>
        /// Trials with any of the given sponsors will be included in the selection (provided that other limitations are satisfied).
        /// Leaving this list empty will not limit the sponsors.
        /// </summary>
        public IList<string> Sponsors { get; }
        /// <summary>
        /// Trials with any of the given phases will be included in the selection (provided that other limitations are satisfied).
        /// Leaving this list empty will not limit the phases.
        /// </summary>
        public IList<ClinicalTrialPhase> Phases { get; }
        /// <summary>
        /// Trials with any of the given purposes will be included in the selection (provided that other limitations are satisfied).
        /// Leaving this list empty will not limit the purposes.
        /// </summary>
        public IList<ClinicalTrialPurpose> Purposes { get; }
        /// <summary>
        /// Trials with any of the given identifiers will be included in the selection (provided that other limitations are satisfied).
        /// Leaving this list empty will not limit the trial identifiers.
        /// </summary>
        public IList<string> Ids { get; }
        /// <summary>
        /// Trials with any of the given sources will be included in the selection (provided that other limitations are satisfied).
        /// Leaving this list empty will not limit the sources.
        /// </summary>
        public IList<ClinicalTrialSource> Sources { get; }
        /// <summary>
        /// Trials with any of the given facility names will be included in the selection (provided that other limitations are satisfied).
        /// Leaving this list empty will not limit the trial facility names.
        /// </summary>
        public IList<string> FacilityNames { get; }
        /// <summary>
        /// Trials with any of the given facility locations will be included in the selection (provided that other limitations are satisfied).
        /// Leaving this list empty will not limit the trial facility locations.
        /// </summary>
        public IList<GeographicLocation> FacilityLocations { get; }
        /// <summary>
        /// Trials with any of the given facility area boundaries will be included in the selection (provided that other limitations are satisfied).
        /// Leaving this list empty will not limit the trial facility area boundaries.
        /// </summary>
        public IList<GeographicArea> FacilityAreas { get; }
    }
}
