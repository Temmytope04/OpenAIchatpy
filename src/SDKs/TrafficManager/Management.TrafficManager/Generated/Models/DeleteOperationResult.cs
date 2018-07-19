// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.TrafficManager.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The result of the request or operation.
    /// </summary>
    public partial class DeleteOperationResult
    {
        /// <summary>
        /// Initializes a new instance of the DeleteOperationResult class.
        /// </summary>
        public DeleteOperationResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeleteOperationResult class.
        /// </summary>
        /// <param name="operationResult">The result of the operation or
        /// request.</param>
        public DeleteOperationResult(bool? operationResult = default(bool?))
        {
            OperationResult = operationResult;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the result of the operation or request.
        /// </summary>
        [JsonProperty(PropertyName = "boolean")]
        public bool? OperationResult { get; private set; }

    }
}
