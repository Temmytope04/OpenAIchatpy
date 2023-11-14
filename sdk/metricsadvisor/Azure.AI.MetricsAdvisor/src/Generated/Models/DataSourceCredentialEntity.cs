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
    /// <summary>
    /// The DataSourceCredential.
    /// Please note <see cref="DataSourceCredentialEntity"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="SqlConnectionStringCredentialEntity"/>, <see cref="DataLakeSharedKeyCredentialEntity"/>, <see cref="ServicePrincipalCredentialEntity"/> and <see cref="ServicePrincipalInKeyVaultCredentialEntity"/>.
    /// </summary>
    public abstract partial class DataSourceCredentialEntity
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DataSourceCredentialEntity"/>. </summary>
        /// <param name="credentialKind"> Type of data source credential. </param>
        /// <param name="id"> Unique id of data source credential. </param>
        /// <param name="name"> Name of data source credential. </param>
        /// <param name="description"> Description of data source credential. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataSourceCredentialEntity(DataSourceCredentialKind credentialKind, string id, string name, string description, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CredentialKind = credentialKind;
            Id = id;
            Name = name;
            Description = description;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataSourceCredentialEntity"/> for deserialization. </summary>
        internal DataSourceCredentialEntity()
        {
        }
    }
}
