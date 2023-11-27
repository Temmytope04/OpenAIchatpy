// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Security.KeyVault.Administration.Models
{
    /// <summary> The update settings request object. </summary>
    internal partial class UpdateSettingRequest
    {
        /// <summary> Initializes a new instance of <see cref="UpdateSettingRequest"/>. </summary>
        /// <param name="value"> The value of the pool setting. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public UpdateSettingRequest(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value;
        }

        /// <summary> The value of the pool setting. </summary>
        public string Value { get; }
    }
}
