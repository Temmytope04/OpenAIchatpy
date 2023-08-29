// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> Groups the settings used for interpreting the blob data if the blob is delimited text formatted. </summary>
    internal partial class DelimitedTextConfigurationInternal
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DelimitedTextConfigurationInternal"/>. </summary>
        public DelimitedTextConfigurationInternal()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DelimitedTextConfigurationInternal"/>. </summary>
        /// <param name="columnSeparator"> The string used to separate columns. </param>
        /// <param name="fieldQuote"> The string used to quote a specific field. </param>
        /// <param name="recordSeparator"> The string used to separate records. </param>
        /// <param name="escapeChar"> The string used as an escape character. </param>
        /// <param name="headersPresent"> Represents whether the data has headers. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DelimitedTextConfigurationInternal(string columnSeparator, string fieldQuote, string recordSeparator, string escapeChar, bool? headersPresent, Dictionary<string, BinaryData> rawData)
        {
            ColumnSeparator = columnSeparator;
            FieldQuote = fieldQuote;
            RecordSeparator = recordSeparator;
            EscapeChar = escapeChar;
            HeadersPresent = headersPresent;
            _rawData = rawData;
        }

        /// <summary> The string used to separate columns. </summary>
        public string ColumnSeparator { get; set; }
        /// <summary> The string used to quote a specific field. </summary>
        public string FieldQuote { get; set; }
        /// <summary> The string used to separate records. </summary>
        public string RecordSeparator { get; set; }
        /// <summary> The string used as an escape character. </summary>
        public string EscapeChar { get; set; }
        /// <summary> Represents whether the data has headers. </summary>
        public bool? HeadersPresent { get; set; }
    }
}
