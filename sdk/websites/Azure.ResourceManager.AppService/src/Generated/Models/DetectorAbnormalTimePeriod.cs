// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Class representing Abnormal Time Period detected. </summary>
    public partial class DetectorAbnormalTimePeriod
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DetectorAbnormalTimePeriod"/>. </summary>
        public DetectorAbnormalTimePeriod()
        {
            MetaData = new ChangeTrackingList<IList<AppServiceNameValuePair>>();
            Solutions = new ChangeTrackingList<DiagnosticSolution>();
        }

        /// <summary> Initializes a new instance of <see cref="DetectorAbnormalTimePeriod"/>. </summary>
        /// <param name="startOn"> Start time of the correlated event. </param>
        /// <param name="endOn"> End time of the correlated event. </param>
        /// <param name="message"> Message describing the event. </param>
        /// <param name="source"> Represents the name of the Detector. </param>
        /// <param name="priority"> Represents the rank of the Detector. </param>
        /// <param name="metaData"> Downtime metadata. </param>
        /// <param name="issueType"> Represents the type of the Detector. </param>
        /// <param name="solutions"> List of proposed solutions. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DetectorAbnormalTimePeriod(DateTimeOffset? startOn, DateTimeOffset? endOn, string message, string source, double? priority, IList<IList<AppServiceNameValuePair>> metaData, DetectorIssueType? issueType, IList<DiagnosticSolution> solutions, Dictionary<string, BinaryData> rawData)
        {
            StartOn = startOn;
            EndOn = endOn;
            Message = message;
            Source = source;
            Priority = priority;
            MetaData = metaData;
            IssueType = issueType;
            Solutions = solutions;
            _rawData = rawData;
        }

        /// <summary> Start time of the correlated event. </summary>
        public DateTimeOffset? StartOn { get; set; }
        /// <summary> End time of the correlated event. </summary>
        public DateTimeOffset? EndOn { get; set; }
        /// <summary> Message describing the event. </summary>
        public string Message { get; set; }
        /// <summary> Represents the name of the Detector. </summary>
        public string Source { get; set; }
        /// <summary> Represents the rank of the Detector. </summary>
        public double? Priority { get; set; }
        /// <summary> Downtime metadata. </summary>
        public IList<IList<AppServiceNameValuePair>> MetaData { get; }
        /// <summary> Represents the type of the Detector. </summary>
        public DetectorIssueType? IssueType { get; set; }
        /// <summary> List of proposed solutions. </summary>
        public IList<DiagnosticSolution> Solutions { get; }
    }
}
