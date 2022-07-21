// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> DatabricksSparkPython activity. </summary>
    public partial class DatabricksSparkPythonActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of DatabricksSparkPythonActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="pythonFile"> The URI of the Python file to be executed. DBFS paths are supported. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="pythonFile"/> is null. </exception>
        public DatabricksSparkPythonActivity(string name, BinaryData pythonFile) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (pythonFile == null)
            {
                throw new ArgumentNullException(nameof(pythonFile));
            }

            PythonFile = pythonFile;
            Parameters = new ChangeTrackingList<BinaryData>();
            Libraries = new ChangeTrackingList<IDictionary<string, BinaryData>>();
            ActivityType = "DatabricksSparkPython";
        }

        /// <summary> Initializes a new instance of DatabricksSparkPythonActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="activityType"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="pythonFile"> The URI of the Python file to be executed. DBFS paths are supported. Type: string (or Expression with resultType string). </param>
        /// <param name="parameters"> Command line parameters that will be passed to the Python file. </param>
        /// <param name="libraries"> A list of libraries to be installed on the cluster that will execute the job. </param>
        internal DatabricksSparkPythonActivity(string name, string activityType, string description, IList<ActivityDependency> dependsOn, IList<UserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties, LinkedServiceReference linkedServiceName, ActivityPolicy policy, BinaryData pythonFile, IList<BinaryData> parameters, IList<IDictionary<string, BinaryData>> libraries) : base(name, activityType, description, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            PythonFile = pythonFile;
            Parameters = parameters;
            Libraries = libraries;
            ActivityType = activityType ?? "DatabricksSparkPython";
        }

        /// <summary> The URI of the Python file to be executed. DBFS paths are supported. Type: string (or Expression with resultType string). </summary>
        public BinaryData PythonFile { get; set; }
        /// <summary> Command line parameters that will be passed to the Python file. </summary>
        public IList<BinaryData> Parameters { get; }
        /// <summary> A list of libraries to be installed on the cluster that will execute the job. </summary>
        public IList<IDictionary<string, BinaryData>> Libraries { get; }
    }
}
