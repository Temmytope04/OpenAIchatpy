// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Resume job properties. </summary>
    internal partial class ReplicationResumeJobProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ReplicationResumeJobProperties"/>. </summary>
        public ReplicationResumeJobProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ReplicationResumeJobProperties"/>. </summary>
        /// <param name="comments"> Resume job comments. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ReplicationResumeJobProperties(string comments, Dictionary<string, BinaryData> rawData)
        {
            Comments = comments;
            _rawData = rawData;
        }

        /// <summary> Resume job comments. </summary>
        public string Comments { get; set; }
    }
}
