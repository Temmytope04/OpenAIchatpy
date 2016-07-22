// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The Data Lake Analytics job error details.
    /// </summary>
    public partial class JobInnerError
    {
        /// <summary>
        /// Initializes a new instance of the JobInnerError class.
        /// </summary>
        public JobInnerError() { }

        /// <summary>
        /// Initializes a new instance of the JobInnerError class.
        /// </summary>
        /// <param name="diagnosticCode">the diagnostic error code.</param>
        /// <param name="severity">the severity level of the failure. Possible values include: 'Warning', 'Error', 'Info'</param>
        /// <param name="details">the details of the error message.</param>
        /// <param name="component">the component that failed.</param>
        /// <param name="errorId">the specific identifier for the type of error encountered in the job.</param>
        /// <param name="helpLink">the link to MSDN or Azure help for this type of error, if any.</param>
        /// <param name="internalDiagnostics">the internal diagnostic stack trace if the user requesting the job error details has sufficient permissions it will be retrieved, otherwise it will be empty.</param>
        /// <param name="message">the user friendly error message for the failure.</param>
        /// <param name="resolution">the recommended resolution for the failure, if any.</param>
        /// <param name="source">the ultimate source of the failure (usually either SYSTEM or USER).</param>
        /// <param name="description">the error message description</param>
        public JobInnerError(int? diagnosticCode = default(int?), SeverityTypes? severity = default(SeverityTypes?), string details = default(string), string component = default(string), string errorId = default(string), string helpLink = default(string), string internalDiagnostics = default(string), string message = default(string), string resolution = default(string), string source = default(string), string description = default(string))
        {
            DiagnosticCode = diagnosticCode;
            Severity = severity;
            Details = details;
            Component = component;
            ErrorId = errorId;
            HelpLink = helpLink;
            InternalDiagnostics = internalDiagnostics;
            Message = message;
            Resolution = resolution;
            Source = source;
            Description = description;
        }

        /// <summary>
        /// Gets the diagnostic error code.
        /// </summary>
        [JsonProperty(PropertyName = "diagnosticCode")]
        public int? DiagnosticCode { get; private set; }

        /// <summary>
        /// Gets the severity level of the failure. Possible values include:
        /// 'Warning', 'Error', 'Info'
        /// </summary>
        [JsonProperty(PropertyName = "severity")]
        public SeverityTypes? Severity { get; private set; }

        /// <summary>
        /// Gets the details of the error message.
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public string Details { get; private set; }

        /// <summary>
        /// Gets the component that failed.
        /// </summary>
        [JsonProperty(PropertyName = "component")]
        public string Component { get; private set; }

        /// <summary>
        /// Gets the specific identifier for the type of error encountered in
        /// the job.
        /// </summary>
        [JsonProperty(PropertyName = "errorId")]
        public string ErrorId { get; private set; }

        /// <summary>
        /// Gets the link to MSDN or Azure help for this type of error, if any.
        /// </summary>
        [JsonProperty(PropertyName = "helpLink")]
        public string HelpLink { get; private set; }

        /// <summary>
        /// Gets the internal diagnostic stack trace if the user requesting
        /// the job error details has sufficient permissions it will be
        /// retrieved, otherwise it will be empty.
        /// </summary>
        [JsonProperty(PropertyName = "internalDiagnostics")]
        public string InternalDiagnostics { get; private set; }

        /// <summary>
        /// Gets the user friendly error message for the failure.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; private set; }

        /// <summary>
        /// Gets the recommended resolution for the failure, if any.
        /// </summary>
        [JsonProperty(PropertyName = "resolution")]
        public string Resolution { get; private set; }

        /// <summary>
        /// Gets the ultimate source of the failure (usually either SYSTEM or
        /// USER).
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public string Source { get; private set; }

        /// <summary>
        /// Gets the error message description
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; private set; }

    }
}
