// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Health.Insights.ClinicalMatching
{
    /// <summary> A patient record, including their clinical information and data. </summary>
    public partial class PatientRecord
    {
        /// <summary> Initializes a new instance of PatientRecord. </summary>
        /// <param name="id"> A given identifier for the patient. Has to be unique across all patients in a single request. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public PatientRecord(string id)
        {
            Argument.AssertNotNull(id, nameof(id));

            Id = id;
            Data = new ChangeTrackingList<PatientDocument>();
        }

        /// <summary> Initializes a new instance of PatientRecord. </summary>
        /// <param name="id"> A given identifier for the patient. Has to be unique across all patients in a single request. </param>
        /// <param name="info"> Patient structured information, including demographics and known structured clinical information. </param>
        /// <param name="data"> Patient unstructured clinical data, given as documents. </param>
        internal PatientRecord(string id, PatientInfo info, IList<PatientDocument> data)
        {
            Id = id;
            Info = info;
            Data = data;
        }

        /// <summary> A given identifier for the patient. Has to be unique across all patients in a single request. </summary>
        public string Id { get; }
        /// <summary> Patient structured information, including demographics and known structured clinical information. </summary>
        public PatientInfo Info { get; set; }
        /// <summary> Patient unstructured clinical data, given as documents. </summary>
        public IList<PatientDocument> Data { get; }
    }
}
