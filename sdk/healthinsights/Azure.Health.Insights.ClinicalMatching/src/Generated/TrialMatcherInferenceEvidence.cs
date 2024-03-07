// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Health.Insights.ClinicalMatching
{
    /// <summary> A piece of evidence corresponding to a Trial Matcher inference. </summary>
    public partial class TrialMatcherInferenceEvidence
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

        /// <summary> Initializes a new instance of <see cref="TrialMatcherInferenceEvidence"/>. </summary>
        internal TrialMatcherInferenceEvidence()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TrialMatcherInferenceEvidence"/>. </summary>
        /// <param name="eligibilityCriteriaEvidence"> A piece of evidence from the eligibility criteria text of a clinical trial. </param>
        /// <param name="patientDataEvidence"> A piece of evidence from a clinical note (text document). </param>
        /// <param name="patientInfoEvidence">
        /// A piece of clinical information, expressed as a code in a clinical coding
        /// system.
        /// </param>
        /// <param name="importance"> A value indicating how important this piece of evidence is for the inference. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TrialMatcherInferenceEvidence(string eligibilityCriteriaEvidence, ClinicalNoteEvidence patientDataEvidence, ClinicalCodedElement patientInfoEvidence, float? importance, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            EligibilityCriteriaEvidence = eligibilityCriteriaEvidence;
            PatientDataEvidence = patientDataEvidence;
            PatientInfoEvidence = patientInfoEvidence;
            Importance = importance;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A piece of evidence from the eligibility criteria text of a clinical trial. </summary>
        public string EligibilityCriteriaEvidence { get; }
        /// <summary> A piece of evidence from a clinical note (text document). </summary>
        public ClinicalNoteEvidence PatientDataEvidence { get; }
        /// <summary>
        /// A piece of clinical information, expressed as a code in a clinical coding
        /// system.
        /// </summary>
        public ClinicalCodedElement PatientInfoEvidence { get; }
        /// <summary> A value indicating how important this piece of evidence is for the inference. </summary>
        public float? Importance { get; }
    }
}
