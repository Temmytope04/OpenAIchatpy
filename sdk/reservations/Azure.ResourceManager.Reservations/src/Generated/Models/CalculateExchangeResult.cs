// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> CalculateExchange operation result. </summary>
    public partial class CalculateExchangeResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CalculateExchangeResult"/>. </summary>
        internal CalculateExchangeResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CalculateExchangeResult"/>. </summary>
        /// <param name="id"> It should match what is used to GET the operation result. </param>
        /// <param name="name"> It must match the last segment of the id field, and will typically be a GUID / system generated value. </param>
        /// <param name="status"> Status of the operation. </param>
        /// <param name="properties"> CalculateExchange response properties. </param>
        /// <param name="error"> Required if status == failed or status == canceled. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CalculateExchangeResult(ResourceIdentifier id, string name, CalculateExchangeOperationResultStatus? status, CalculateExchangeResultProperties properties, OperationResultError error, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            Name = name;
            Status = status;
            Properties = properties;
            Error = error;
            _rawData = rawData;
        }

        /// <summary> It should match what is used to GET the operation result. </summary>
        public ResourceIdentifier Id { get; }
        /// <summary> It must match the last segment of the id field, and will typically be a GUID / system generated value. </summary>
        public string Name { get; }
        /// <summary> Status of the operation. </summary>
        public CalculateExchangeOperationResultStatus? Status { get; }
        /// <summary> CalculateExchange response properties. </summary>
        public CalculateExchangeResultProperties Properties { get; }
        /// <summary> Required if status == failed or status == canceled. </summary>
        public OperationResultError Error { get; }
    }
}
