// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Azure Blob datastore configuration. </summary>
    public partial class MachineLearningAzureBlobDatastore : MachineLearningDatastoreProperties
    {
        /// <summary> Initializes a new instance of MachineLearningAzureBlobDatastore. </summary>
        /// <param name="credentials">
        /// [Required] Account credentials.
        /// Please note <see cref="MachineLearningDatastoreCredentials"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningAccountKeyDatastoreCredentials"/>, <see cref="MachineLearningCertificateDatastoreCredentials"/>, <see cref="KerberosKeytabCredentials"/>, <see cref="KerberosPasswordCredentials"/>, <see cref="MachineLearningNoneDatastoreCredentials"/>, <see cref="MachineLearningSasDatastoreCredentials"/> and <see cref="MachineLearningServicePrincipalDatastoreCredentials"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credentials"/> is null. </exception>
        public MachineLearningAzureBlobDatastore(MachineLearningDatastoreCredentials credentials) : base(credentials)
        {
            Argument.AssertNotNull(credentials, nameof(credentials));

            DatastoreType = DatastoreType.AzureBlob;
        }

        /// <summary> Initializes a new instance of MachineLearningAzureBlobDatastore. </summary>
        /// <param name="description"> The asset description text. </param>
        /// <param name="properties"> The asset property dictionary. </param>
        /// <param name="tags"> Tag dictionary. Tags can be added, removed, and updated. </param>
        /// <param name="credentials">
        /// [Required] Account credentials.
        /// Please note <see cref="MachineLearningDatastoreCredentials"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningAccountKeyDatastoreCredentials"/>, <see cref="MachineLearningCertificateDatastoreCredentials"/>, <see cref="KerberosKeytabCredentials"/>, <see cref="KerberosPasswordCredentials"/>, <see cref="MachineLearningNoneDatastoreCredentials"/>, <see cref="MachineLearningSasDatastoreCredentials"/> and <see cref="MachineLearningServicePrincipalDatastoreCredentials"/>.
        /// </param>
        /// <param name="datastoreType"> [Required] Storage type backing the datastore. </param>
        /// <param name="intellectualProperty"> Intellectual Property details. </param>
        /// <param name="isDefault"> Readonly property to indicate if datastore is the workspace default datastore. </param>
        /// <param name="accountName"> Storage account name. </param>
        /// <param name="containerName"> Storage account container name. </param>
        /// <param name="endpoint"> Azure cloud endpoint for the storage account. </param>
        /// <param name="protocol"> Protocol used to communicate with the storage account. </param>
        /// <param name="serviceDataAccessAuthIdentity"> Indicates which identity to use to authenticate service data access to customer's storage. </param>
        /// <param name="resourceGroup"> Azure Resource Group name. </param>
        /// <param name="subscriptionId"> Azure Subscription Id. </param>
        internal MachineLearningAzureBlobDatastore(string description, IDictionary<string, string> properties, IDictionary<string, string> tags, MachineLearningDatastoreCredentials credentials, DatastoreType datastoreType, IntellectualProperty intellectualProperty, bool? isDefault, string accountName, string containerName, string endpoint, string protocol, MachineLearningServiceDataAccessAuthIdentity? serviceDataAccessAuthIdentity, string resourceGroup, string subscriptionId) : base(description, properties, tags, credentials, datastoreType, intellectualProperty, isDefault)
        {
            AccountName = accountName;
            ContainerName = containerName;
            Endpoint = endpoint;
            Protocol = protocol;
            ServiceDataAccessAuthIdentity = serviceDataAccessAuthIdentity;
            ResourceGroup = resourceGroup;
            SubscriptionId = subscriptionId;
            DatastoreType = datastoreType;
        }

        /// <summary> Storage account name. </summary>
        public string AccountName { get; set; }
        /// <summary> Storage account container name. </summary>
        public string ContainerName { get; set; }
        /// <summary> Azure cloud endpoint for the storage account. </summary>
        public string Endpoint { get; set; }
        /// <summary> Protocol used to communicate with the storage account. </summary>
        public string Protocol { get; set; }
        /// <summary> Indicates which identity to use to authenticate service data access to customer's storage. </summary>
        public MachineLearningServiceDataAccessAuthIdentity? ServiceDataAccessAuthIdentity { get; set; }
        /// <summary> Azure Resource Group name. </summary>
        public string ResourceGroup { get; set; }
        /// <summary> Azure Subscription Id. </summary>
        public string SubscriptionId { get; set; }
    }
}
