// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The AzureSQLConnectionStringCredentialPatch. </summary>
    internal partial class AzureSQLConnectionStringCredentialPatch : DataSourceCredentialPatch
    {
        /// <summary> Initializes a new instance of AzureSQLConnectionStringCredentialPatch. </summary>
        public AzureSQLConnectionStringCredentialPatch()
        {
            DataSourceCredentialType = DataSourceCredentialType.AzureSQLConnectionString;
        }

        public AzureSQLConnectionStringParamPatch Parameters { get; set; }
    }
}
