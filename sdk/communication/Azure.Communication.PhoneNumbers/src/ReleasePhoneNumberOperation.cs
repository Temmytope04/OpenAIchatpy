﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Communication.PhoneNumbers
{
    [CodeGenModel("InternalPhoneNumbersReleasePhoneNumberOperation")]
    public partial class ReleasePhoneNumberOperation
    {
        internal ReleasePhoneNumberOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new ArmOperationHelpers<Response>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "ReleasePhoneNumberOperation");

            if (response.Headers.TryGetValue<string>("operation-id", out var id))
            {
                Id = id;
            }
        }

        /// <inheritdoc />
        public override string Id { get; }
    }
}
