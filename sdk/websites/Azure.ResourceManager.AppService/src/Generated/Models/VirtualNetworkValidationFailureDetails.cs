// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> A class that describes the reason for a validation failure. </summary>
    public partial class VirtualNetworkValidationFailureDetails : ResourceData
    {
        /// <summary> Initializes a new instance of VirtualNetworkValidationFailureDetails. </summary>
        public VirtualNetworkValidationFailureDetails()
        {
            FailedTests = new ChangeTrackingList<VirtualNetworkValidationTestFailure>();
            Warnings = new ChangeTrackingList<VirtualNetworkValidationTestFailure>();
        }

        /// <summary> Initializes a new instance of VirtualNetworkValidationFailureDetails. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="message"> Text describing the validation outcome. </param>
        /// <param name="isFailed"> A flag describing whether or not validation failed. </param>
        /// <param name="failedTests"> A list of tests that failed in the validation. </param>
        /// <param name="warnings"> A list of warnings generated during validation. </param>
        /// <param name="kind"> Kind of resource. </param>
        internal VirtualNetworkValidationFailureDetails(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string message, bool? isFailed, IList<VirtualNetworkValidationTestFailure> failedTests, IList<VirtualNetworkValidationTestFailure> warnings, string kind) : base(id, name, resourceType, systemData)
        {
            Message = message;
            IsFailed = isFailed;
            FailedTests = failedTests;
            Warnings = warnings;
            Kind = kind;
        }

        /// <summary> Text describing the validation outcome. </summary>
        public string Message { get; set; }
        /// <summary> A flag describing whether or not validation failed. </summary>
        public bool? IsFailed { get; set; }
        /// <summary> A list of tests that failed in the validation. </summary>
        public IList<VirtualNetworkValidationTestFailure> FailedTests { get; }
        /// <summary> A list of warnings generated during validation. </summary>
        public IList<VirtualNetworkValidationTestFailure> Warnings { get; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
