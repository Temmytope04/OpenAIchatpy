// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Linked service for Twilio. </summary>
    public partial class TwilioLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of <see cref="TwilioLinkedService"/>. </summary>
        /// <param name="userName"> The Account SID of Twilio service. </param>
        /// <param name="password">
        /// The auth token of Twilio service.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="userName"/> or <paramref name="password"/> is null. </exception>
        public TwilioLinkedService(object userName, SecretBase password)
        {
            Argument.AssertNotNull(userName, nameof(userName));
            Argument.AssertNotNull(password, nameof(password));

            UserName = userName;
            Password = password;
            Type = "Twilio";
        }

        /// <summary> Initializes a new instance of <see cref="TwilioLinkedService"/>. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="userName"> The Account SID of Twilio service. </param>
        /// <param name="password">
        /// The auth token of Twilio service.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </param>
        internal TwilioLinkedService(string type, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, object userName, SecretBase password) : base(type, connectVia, description, parameters, annotations, additionalProperties)
        {
            UserName = userName;
            Password = password;
            Type = type ?? "Twilio";
        }

        /// <summary> Initializes a new instance of <see cref="TwilioLinkedService"/> for deserialization. </summary>
        internal TwilioLinkedService()
        {
        }

        /// <summary> The Account SID of Twilio service. </summary>
        public object UserName { get; set; }
        /// <summary>
        /// The auth token of Twilio service.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </summary>
        public SecretBase Password { get; set; }
    }
}
