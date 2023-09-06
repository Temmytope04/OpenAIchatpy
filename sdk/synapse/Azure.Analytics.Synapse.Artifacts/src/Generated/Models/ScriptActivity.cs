// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Script activity type. </summary>
    public partial class ScriptActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of <see cref="ScriptActivity"/>. </summary>
        /// <param name="name"> Activity name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public ScriptActivity(string name) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Scripts = new ChangeTrackingList<ScriptActivityScriptBlock>();
            Type = "Script";
        }

        /// <summary> Initializes a new instance of <see cref="ScriptActivity"/>. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="type"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="state"> Activity state. This is an optional property and if not provided, the state will be Active by default. </param>
        /// <param name="onInactiveMarkAs"> Status result of the activity when the state is set to Inactive. This is an optional property and if not provided when the activity is inactive, the status will be Succeeded by default. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="scripts"> Array of script blocks. Type: array. </param>
        /// <param name="logSettings"> Log settings of script activity. </param>
        internal ScriptActivity(string name, string type, string description, ActivityState? state, ActivityOnInactiveMarkAs? onInactiveMarkAs, IList<ActivityDependency> dependsOn, IList<UserProperty> userProperties, IDictionary<string, object> additionalProperties, LinkedServiceReference linkedServiceName, ActivityPolicy policy, IList<ScriptActivityScriptBlock> scripts, ScriptActivityTypePropertiesLogSettings logSettings) : base(name, type, description, state, onInactiveMarkAs, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            Scripts = scripts;
            LogSettings = logSettings;
            Type = type ?? "Script";
        }

        /// <summary> Initializes a new instance of <see cref="ScriptActivity"/> for deserialization. </summary>
        internal ScriptActivity()
        {
        }

        /// <summary> Array of script blocks. Type: array. </summary>
        public IList<ScriptActivityScriptBlock> Scripts { get; }
        /// <summary> Log settings of script activity. </summary>
        public ScriptActivityTypePropertiesLogSettings LogSettings { get; set; }
    }
}
