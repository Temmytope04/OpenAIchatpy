// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Settings for copy activity log. </summary>
    public partial class CopyActivityLogSettings
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CopyActivityLogSettings"/>. </summary>
        public CopyActivityLogSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CopyActivityLogSettings"/>. </summary>
        /// <param name="logLevel"> Gets or sets the log level, support: Info, Warning. Type: string (or Expression with resultType string). </param>
        /// <param name="enableReliableLogging"> Specifies whether to enable reliable logging. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CopyActivityLogSettings(object logLevel, object enableReliableLogging, Dictionary<string, BinaryData> rawData)
        {
            LogLevel = logLevel;
            EnableReliableLogging = enableReliableLogging;
            _rawData = rawData;
        }

        /// <summary> Gets or sets the log level, support: Info, Warning. Type: string (or Expression with resultType string). </summary>
        public object LogLevel { get; set; }
        /// <summary> Specifies whether to enable reliable logging. Type: boolean (or Expression with resultType boolean). </summary>
        public object EnableReliableLogging { get; set; }
    }
}
