// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> Recognized field value. </summary>
    internal partial class FieldValue_internal
    {
        /// <summary> Initializes a new instance of FieldValue_internal. </summary>
        /// <param name="type"> Type of field value. </param>
        internal FieldValue_internal(FieldValueType type)
        {
            Type = type;
            ValueArray = new ChangeTrackingList<FieldValue_internal>();
            ValueObject = new ChangeTrackingDictionary<string, FieldValue_internal>();
            BoundingBox = new ChangeTrackingList<float>();
            Elements = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of FieldValue_internal. </summary>
        /// <param name="type"> Type of field value. </param>
        /// <param name="valueString"> String value. </param>
        /// <param name="valueDate"> Date value. </param>
        /// <param name="valueTime"> Time value. </param>
        /// <param name="valuePhoneNumber"> Phone number value. </param>
        /// <param name="valueNumber"> Floating point value. </param>
        /// <param name="valueInteger"> Integer value. </param>
        /// <param name="valueArray"> Array of field values. </param>
        /// <param name="valueObject"> Dictionary of named field values. </param>
        /// <param name="valueSelectionMark"> Selection mark value. </param>
        /// <param name="valueGender"> Gender value: M, F, or X. </param>
        /// <param name="valueCountry"> 3-letter country code (ISO 3166-1 alpha-3). </param>
        /// <param name="text"> Text content of the extracted field. </param>
        /// <param name="boundingBox"> Bounding box of the field value, if appropriate. </param>
        /// <param name="confidence"> Confidence score. </param>
        /// <param name="elements"> When includeTextDetails is set to true, a list of references to the text elements constituting this field. </param>
        /// <param name="page"> The 1-based page number in the input document. </param>
        internal FieldValue_internal(FieldValueType type, string valueString, DateTimeOffset? valueDate, TimeSpan? valueTime, string valuePhoneNumber, float? valueNumber, long? valueInteger, IReadOnlyList<FieldValue_internal> valueArray, IReadOnlyDictionary<string, FieldValue_internal> valueObject, SelectionMarkState? valueSelectionMark, FieldValueGender? valueGender, string valueCountry, string text, IReadOnlyList<float> boundingBox, float? confidence, IReadOnlyList<string> elements, int? page)
        {
            Type = type;
            ValueString = valueString;
            ValueDate = valueDate;
            ValueTime = valueTime;
            ValuePhoneNumber = valuePhoneNumber;
            ValueNumber = valueNumber;
            ValueInteger = valueInteger;
            ValueArray = valueArray;
            ValueObject = valueObject;
            ValueSelectionMark = valueSelectionMark;
            ValueGender = valueGender;
            ValueCountry = valueCountry;
            Text = text;
            BoundingBox = boundingBox;
            Confidence = confidence;
            Elements = elements;
            Page = page;
        }

        /// <summary> Type of field value. </summary>
        public FieldValueType Type { get; }
        /// <summary> String value. </summary>
        public string ValueString { get; }
        /// <summary> Date value. </summary>
        public DateTimeOffset? ValueDate { get; }
        /// <summary> Time value. </summary>
        public TimeSpan? ValueTime { get; }
        /// <summary> Phone number value. </summary>
        public string ValuePhoneNumber { get; }
        /// <summary> Floating point value. </summary>
        public float? ValueNumber { get; }
        /// <summary> Array of field values. </summary>
        public IReadOnlyList<FieldValue_internal> ValueArray { get; }
        /// <summary> Dictionary of named field values. </summary>
        public IReadOnlyDictionary<string, FieldValue_internal> ValueObject { get; }
        /// <summary> Gender value: M, F, or X. </summary>
        public FieldValueGender? ValueGender { get; }
        /// <summary> 3-letter country code (ISO 3166-1 alpha-3). </summary>
        public string ValueCountry { get; }
        /// <summary> Text content of the extracted field. </summary>
        public string Text { get; }
        /// <summary> Bounding box of the field value, if appropriate. </summary>
        public IReadOnlyList<float> BoundingBox { get; }
        /// <summary> Confidence score. </summary>
        public float? Confidence { get; }
        /// <summary> When includeTextDetails is set to true, a list of references to the text elements constituting this field. </summary>
        public IReadOnlyList<string> Elements { get; }
        /// <summary> The 1-based page number in the input document. </summary>
        public int? Page { get; }
    }
}
