// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ProviderHub.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Inner error containing list of errors.
    /// </summary>
    public partial class InnerError
    {
        /// <summary>
        /// Initializes a new instance of the InnerError class.
        /// </summary>
        public InnerError()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InnerError class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="code">Specific error code than was provided by the
        /// containing error.</param>
        /// <param name="innerErrorProperty">Object containing more specific
        /// information than the current object about the error.</param>
        public InnerError(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string code = default(string), object innerErrorProperty = default(object))
        {
            AdditionalProperties = additionalProperties;
            Code = code;
            InnerErrorProperty = innerErrorProperty;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unmatched properties from the message are deserialized
        /// this collection
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Gets specific error code than was provided by the containing error.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; private set; }

        /// <summary>
        /// Gets object containing more specific information than the current
        /// object about the error.
        /// </summary>
        [JsonProperty(PropertyName = "innerError")]
        public object InnerErrorProperty { get; private set; }

    }
}
