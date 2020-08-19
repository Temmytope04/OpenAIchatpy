// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Management.Storage.Models
{
    /// <summary> An error response from the Storage service. </summary>
    internal partial class CloudErrorBodyAutoGenerated
    {
        /// <summary> Initializes a new instance of CloudErrorBodyAutoGenerated. </summary>
        internal CloudErrorBodyAutoGenerated()
        {
            Details = new ChangeTrackingList<CloudErrorBodyAutoGenerated>();
        }

        /// <summary> Initializes a new instance of CloudErrorBodyAutoGenerated. </summary>
        /// <param name="code"> An identifier for the error. Codes are invariant and are intended to be consumed programmatically. </param>
        /// <param name="message"> A message describing the error, intended to be suitable for display in a user interface. </param>
        /// <param name="target"> The target of the particular error. For example, the name of the property in error. </param>
        /// <param name="details"> A list of additional details about the error. </param>
        internal CloudErrorBodyAutoGenerated(string code, string message, string target, IReadOnlyList<CloudErrorBodyAutoGenerated> details)
        {
            Code = code;
            Message = message;
            Target = target;
            Details = details;
        }

        /// <summary> An identifier for the error. Codes are invariant and are intended to be consumed programmatically. </summary>
        public string Code { get; }
        /// <summary> A message describing the error, intended to be suitable for display in a user interface. </summary>
        public string Message { get; }
        /// <summary> The target of the particular error. For example, the name of the property in error. </summary>
        public string Target { get; }
        /// <summary> A list of additional details about the error. </summary>
        public IReadOnlyList<CloudErrorBodyAutoGenerated> Details { get; }
    }
}
