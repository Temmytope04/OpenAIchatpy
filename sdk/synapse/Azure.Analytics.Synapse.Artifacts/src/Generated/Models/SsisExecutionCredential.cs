// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> SSIS package execution credential. </summary>
    public partial class SsisExecutionCredential
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SsisExecutionCredential"/>. </summary>
        /// <param name="domain"> Domain for windows authentication. </param>
        /// <param name="userName"> UseName for windows authentication. </param>
        /// <param name="password"> Password for windows authentication. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="domain"/>, <paramref name="userName"/> or <paramref name="password"/> is null. </exception>
        public SsisExecutionCredential(object domain, object userName, SecureString password)
        {
            Argument.AssertNotNull(domain, nameof(domain));
            Argument.AssertNotNull(userName, nameof(userName));
            Argument.AssertNotNull(password, nameof(password));

            Domain = domain;
            UserName = userName;
            Password = password;
        }

        /// <summary> Initializes a new instance of <see cref="SsisExecutionCredential"/>. </summary>
        /// <param name="domain"> Domain for windows authentication. </param>
        /// <param name="userName"> UseName for windows authentication. </param>
        /// <param name="password"> Password for windows authentication. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SsisExecutionCredential(object domain, object userName, SecureString password, Dictionary<string, BinaryData> rawData)
        {
            Domain = domain;
            UserName = userName;
            Password = password;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="SsisExecutionCredential"/> for deserialization. </summary>
        internal SsisExecutionCredential()
        {
        }

        /// <summary> Domain for windows authentication. </summary>
        public object Domain { get; set; }
        /// <summary> UseName for windows authentication. </summary>
        public object UserName { get; set; }
        /// <summary> Password for windows authentication. </summary>
        public SecureString Password { get; set; }
    }
}
