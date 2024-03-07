// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Health.Insights.ClinicalMatching
{
    /// <summary> Demographic criteria for a clinical trial. </summary>
    public partial class ClinicalTrialDemographics
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

        /// <summary> Initializes a new instance of <see cref="ClinicalTrialDemographics"/>. </summary>
        public ClinicalTrialDemographics()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ClinicalTrialDemographics"/>. </summary>
        /// <param name="acceptedSex"> Indication of the sex of people who may participate in the clinical trial. </param>
        /// <param name="acceptedAgeRange"> A definition of the range of ages accepted by a clinical trial. Contains a minimum age and/or a maximum age. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ClinicalTrialDemographics(ClinicalTrialAcceptedSex? acceptedSex, AcceptedAgeRange acceptedAgeRange, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AcceptedSex = acceptedSex;
            AcceptedAgeRange = acceptedAgeRange;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Indication of the sex of people who may participate in the clinical trial. </summary>
        public ClinicalTrialAcceptedSex? AcceptedSex { get; set; }
        /// <summary> A definition of the range of ages accepted by a clinical trial. Contains a minimum age and/or a maximum age. </summary>
        public AcceptedAgeRange AcceptedAgeRange { get; set; }
    }
}
