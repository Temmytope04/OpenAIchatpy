// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The AzureDevOps scope connector's environment data. </summary>
    public partial class AzureDevOpsScopeEnvironment : SecurityConnectorEnvironment
    {
        /// <summary> Initializes a new instance of <see cref="AzureDevOpsScopeEnvironment"/>. </summary>
        public AzureDevOpsScopeEnvironment()
        {
            EnvironmentType = EnvironmentType.AzureDevOpsScope;
        }

        /// <summary> Initializes a new instance of <see cref="AzureDevOpsScopeEnvironment"/>. </summary>
        /// <param name="environmentType"> The type of the environment data. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AzureDevOpsScopeEnvironment(EnvironmentType environmentType, Dictionary<string, BinaryData> rawData) : base(environmentType, rawData)
        {
            EnvironmentType = environmentType;
        }
    }
}
