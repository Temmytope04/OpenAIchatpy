// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> The script action profile. </summary>
    public partial class ScriptActionProfile
    {
        /// <summary> Initializes a new instance of <see cref="ScriptActionProfile"/>. </summary>
        /// <param name="scriptActionProfileType"> Type of the script action. Supported type is bash scripts. </param>
        /// <param name="name"> Script name. </param>
        /// <param name="uriString"> Url of the script file. </param>
        /// <param name="services"> List of services to apply the script action. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptActionProfileType"/>, <paramref name="name"/>, <paramref name="uriString"/> or <paramref name="services"/> is null. </exception>
        public ScriptActionProfile(string scriptActionProfileType, string name, string uriString, IEnumerable<string> services)
        {
            Argument.AssertNotNull(scriptActionProfileType, nameof(scriptActionProfileType));
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(uriString, nameof(uriString));
            Argument.AssertNotNull(services, nameof(services));

            ScriptActionProfileType = scriptActionProfileType;
            Name = name;
            UriString = uriString;
            Services = services.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ScriptActionProfile"/>. </summary>
        /// <param name="scriptActionProfileType"> Type of the script action. Supported type is bash scripts. </param>
        /// <param name="name"> Script name. </param>
        /// <param name="uriString"> Url of the script file. </param>
        /// <param name="parameters"> Additional parameters for the script action. It should be space-separated list of arguments required for script execution. </param>
        /// <param name="services"> List of services to apply the script action. </param>
        /// <param name="timeoutInMinutes"> Timeout duration for the script action in minutes. </param>
        /// <param name="shouldPersist"> Specify if the script should persist on the cluster. </param>
        internal ScriptActionProfile(string scriptActionProfileType, string name, string uriString, string parameters, IList<string> services, int? timeoutInMinutes, bool? shouldPersist)
        {
            ScriptActionProfileType = scriptActionProfileType;
            Name = name;
            UriString = uriString;
            Parameters = parameters;
            Services = services;
            TimeoutInMinutes = timeoutInMinutes;
            ShouldPersist = shouldPersist;
        }

        /// <summary> Type of the script action. Supported type is bash scripts. </summary>
        public string ScriptActionProfileType { get; set; }
        /// <summary> Script name. </summary>
        public string Name { get; set; }
        /// <summary> Url of the script file. </summary>
        public string UriString { get; set; }
        /// <summary> Additional parameters for the script action. It should be space-separated list of arguments required for script execution. </summary>
        public string Parameters { get; set; }
        /// <summary> List of services to apply the script action. </summary>
        public IList<string> Services { get; }
        /// <summary> Timeout duration for the script action in minutes. </summary>
        public int? TimeoutInMinutes { get; set; }
        /// <summary> Specify if the script should persist on the cluster. </summary>
        public bool? ShouldPersist { get; set; }
    }
}
