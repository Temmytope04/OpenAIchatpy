﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Globalization;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// </summary>
    public class FormField
    {
        internal FormField(string name, int pageNumber, KeyValuePair_internal field, IReadOnlyList<ReadResult_internal> readResults)
        {
            Confidence = field.Confidence;
            Name = name;

            IReadOnlyList<FormContent> labelFormContent = default;
            if (field.Key.Elements != null)
            {
                labelFormContent = ConvertTextReferences(field.Key.Elements, readResults);
            }
            LabelText = new FieldText(field.Key.Text, pageNumber, new BoundingBox(field.Key.BoundingBox), labelFormContent);

            IReadOnlyList<FormContent> valueFormContent = default;
            if (field.Value.Elements != null)
            {
                valueFormContent = ConvertTextReferences(field.Value.Elements, readResults);
            }
            ValueText = new FieldText(field.Value.Text, pageNumber, new BoundingBox(field.Value.BoundingBox), valueFormContent);

            Value = new FieldValue(new FieldValue_internal(FieldValueType.StringType, field.Value.Text, null, null, null, null, null, null, null, field.Value.Text, null, null, null, pageNumber), readResults);
        }

        internal FormField(string name, FieldValue_internal fieldValue, IReadOnlyList<ReadResult_internal> readResults)
        {
            Confidence = fieldValue.Confidence ?? 1.0f;
            Name = name;
            LabelText = null;

            IReadOnlyList<FormContent> formContent = default;
            if (fieldValue.Elements != null)
            {
                formContent = ConvertTextReferences(fieldValue.Elements, readResults);
            }

            // TODO: FormEnum<T> ?
            BoundingBox boundingBox = fieldValue.BoundingBox == null ? default : new BoundingBox(fieldValue.BoundingBox);

            ValueText = new FieldText(fieldValue.Text, fieldValue.Page ?? 0, boundingBox, formContent);
            Value = new FieldValue(fieldValue, readResults);
        }

        /// <summary>
        /// Canonical name; uniquely identifies a field within the form.
        /// </summary>
        public string Name { get; internal set; }

        /// <summary>
        /// Text from the form that labels the form field.
        /// </summary>
        public FieldText LabelText { get; internal set; }

        /// <summary>
        /// </summary>
        public FieldText ValueText { get; internal set; }

        /// <summary>
        /// </summary>
        public FieldValue Value { get; internal set; }

        /// <summary>
        /// </summary>
        public float Confidence { get; }

        internal static IReadOnlyList<FormContent> ConvertTextReferences(IReadOnlyList<string> references, IReadOnlyList<ReadResult_internal> readResults)
        {
            List<FormContent> formContent = new List<FormContent>();
            foreach (var reference in references)
            {
                formContent.Add(ResolveTextReference(readResults, reference));
            }
            return formContent;
        }

        private static FormContent ResolveTextReference(IReadOnlyList<ReadResult_internal> readResults, string reference)
        {
            // TODO: Add additional validations here.
            // https://github.com/Azure/azure-sdk-for-net/issues/10363

            // Example: the following should result in PageIndex = 3, LineIndex = 7, WordIndex = 12
            // "#/readResults/3/lines/7/words/12"
            string[] segments = reference.Split('/');

            // Line Reference
            if (segments.Length == 5)
            {
                var pageIndex = int.Parse(segments[2], CultureInfo.InvariantCulture);
                var lineIndex = int.Parse(segments[4], CultureInfo.InvariantCulture);

                return new FormLine(readResults[pageIndex].Lines[lineIndex], pageIndex + 1);
            }
            else if (segments.Length == 7)
            {
                var pageIndex = int.Parse(segments[2], CultureInfo.InvariantCulture);
                var lineIndex = int.Parse(segments[4], CultureInfo.InvariantCulture);
                var wordIndex = int.Parse(segments[6], CultureInfo.InvariantCulture);

                return new FormWord(readResults[pageIndex].Lines[lineIndex].Words[wordIndex], pageIndex + 1);
            }
            else
            {
                throw new InvalidOperationException($"Failed to parse element reference: {reference}");
            }
        }
    }
}
