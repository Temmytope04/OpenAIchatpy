// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing the SecurityCompliance data model.
    /// Compliance of a scope
    /// </summary>
    public partial class SecurityComplianceData : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SecurityComplianceData"/>. </summary>
        public SecurityComplianceData()
        {
            AssessmentResult = new ChangeTrackingList<ComplianceSegment>();
        }

        /// <summary> Initializes a new instance of <see cref="SecurityComplianceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="assessedOn"> The timestamp when the Compliance calculation was conducted. </param>
        /// <param name="resourceCount"> The resource count of the given subscription for which the Compliance calculation was conducted (needed for Management Group Compliance calculation). </param>
        /// <param name="assessmentResult"> An array of segment, which is the actually the compliance assessment. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityComplianceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DateTimeOffset? assessedOn, int? resourceCount, IReadOnlyList<ComplianceSegment> assessmentResult, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            AssessedOn = assessedOn;
            ResourceCount = resourceCount;
            AssessmentResult = assessmentResult;
            _rawData = rawData;
        }

        /// <summary> The timestamp when the Compliance calculation was conducted. </summary>
        public DateTimeOffset? AssessedOn { get; }
        /// <summary> The resource count of the given subscription for which the Compliance calculation was conducted (needed for Management Group Compliance calculation). </summary>
        public int? ResourceCount { get; }
        /// <summary> An array of segment, which is the actually the compliance assessment. </summary>
        public IReadOnlyList<ComplianceSegment> AssessmentResult { get; }
    }
}
