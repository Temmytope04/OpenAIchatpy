// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// Custom action to be executed
    /// when an auto heal rule is triggered.
    /// </summary>
    public partial class AutoHealCustomAction
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AutoHealCustomAction"/>. </summary>
        public AutoHealCustomAction()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AutoHealCustomAction"/>. </summary>
        /// <param name="exe"> Executable to be run. </param>
        /// <param name="parameters"> Parameters for the executable. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AutoHealCustomAction(string exe, string parameters, Dictionary<string, BinaryData> rawData)
        {
            Exe = exe;
            Parameters = parameters;
            _rawData = rawData;
        }

        /// <summary> Executable to be run. </summary>
        public string Exe { get; set; }
        /// <summary> Parameters for the executable. </summary>
        public string Parameters { get; set; }
    }
}
