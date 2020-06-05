// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Peering.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The error detail that describes why an operation has failed.
    /// </summary>
    public partial class ErrorDetail
    {
        /// <summary>
        /// Initializes a new instance of the ErrorDetail class.
        /// </summary>
        public ErrorDetail()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ErrorDetail class.
        /// </summary>
        /// <param name="code">The error code.</param>
        /// <param name="message">The error message.</param>
        public ErrorDetail(string code = default(string), string message = default(string))
        {
            Code = code;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the error code.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; private set; }

        /// <summary>
        /// Gets the error message.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; private set; }

    }
}
