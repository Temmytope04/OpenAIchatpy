// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningWorkspaceConnectionUsernamePassword. </summary>
    public partial class MachineLearningWorkspaceConnectionUsernamePassword
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MachineLearningWorkspaceConnectionUsernamePassword"/>. </summary>
        public MachineLearningWorkspaceConnectionUsernamePassword()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningWorkspaceConnectionUsernamePassword"/>. </summary>
        /// <param name="password"></param>
        /// <param name="username"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningWorkspaceConnectionUsernamePassword(string password, string username, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Password = password;
            Username = username;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the password. </summary>
        public string Password { get; set; }
        /// <summary> Gets or sets the username. </summary>
        public string Username { get; set; }
    }
}
