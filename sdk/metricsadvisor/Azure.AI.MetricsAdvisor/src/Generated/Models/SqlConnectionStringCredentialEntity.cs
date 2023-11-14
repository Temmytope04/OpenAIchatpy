// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.AI.MetricsAdvisor.Models;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Administration
{
    /// <summary> The AzureSQLConnectionStringCredential. </summary>
    public partial class SqlConnectionStringCredentialEntity : DataSourceCredentialEntity
    {
        /// <summary> Initializes a new instance of <see cref="SqlConnectionStringCredentialEntity"/>. </summary>
        /// <param name="credentialKind"> Type of data source credential. </param>
        /// <param name="id"> Unique id of data source credential. </param>
        /// <param name="name"> Name of data source credential. </param>
        /// <param name="description"> Description of data source credential. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="parameters"></param>
        internal SqlConnectionStringCredentialEntity(DataSourceCredentialKind credentialKind, string id, string name, string description, IDictionary<string, BinaryData> serializedAdditionalRawData, AzureSQLConnectionStringParam parameters) : base(credentialKind, id, name, description, serializedAdditionalRawData)
        {
            Parameters = parameters;
            CredentialKind = credentialKind;
        }

        /// <summary> Initializes a new instance of <see cref="SqlConnectionStringCredentialEntity"/> for deserialization. </summary>
        internal SqlConnectionStringCredentialEntity()
        {
        }
    }
}
