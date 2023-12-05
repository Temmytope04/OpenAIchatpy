// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Properties of flink job. </summary>
    public partial class FlinkJobProperties : ClusterJobProperties
    {
        /// <summary> Initializes a new instance of <see cref="FlinkJobProperties"/>. </summary>
        /// <param name="jobName"> Name of job. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public FlinkJobProperties(string jobName)
        {
            Argument.AssertNotNull(jobName, nameof(jobName));

            JobName = jobName;
            FlinkConfiguration = new ChangeTrackingDictionary<string, string>();
            JobType = ClusterJobType.FlinkJob;
        }

        /// <summary> Initializes a new instance of <see cref="FlinkJobProperties"/>. </summary>
        /// <param name="jobType"> Type of cluster job. </param>
        /// <param name="jobName"> Name of job. </param>
        /// <param name="jobJarDirectory"> A string property that specifies the directory where the job JAR is located. </param>
        /// <param name="jarName"> A string property that represents the name of the job JAR. </param>
        /// <param name="entryClass"> A string property that specifies the entry class for the Flink job. </param>
        /// <param name="args"> A string property representing additional JVM arguments for the Flink job. It should be space separated value. </param>
        /// <param name="savePointName"> A string property that represents the name of the savepoint for the Flink job. </param>
        /// <param name="action"> A string property that indicates the action to be performed on the Flink job. It can have one of the following enum values =&gt; NEW, UPDATE, STATELESS_UPDATE, STOP, START, CANCEL, SAVEPOINT, LIST_SAVEPOINT, or DELETE. </param>
        /// <param name="flinkConfiguration"> Additional properties used to configure Flink jobs. It allows users to set properties such as parallelism and jobSavePointDirectory. It accepts additional key-value pairs as properties, where the keys are strings and the values are strings as well. </param>
        /// <param name="jobId"> Unique id for identifying a job. </param>
        /// <param name="status"> Status of job. </param>
        /// <param name="jobOutput"> Output of job. </param>
        /// <param name="actionResult"> Action result of job. </param>
        /// <param name="lastSavePoint"> The last savepoint. </param>
        internal FlinkJobProperties(ClusterJobType jobType, string jobName, string jobJarDirectory, string jarName, string entryClass, string args, string savePointName, FlinkJobAction? action, IDictionary<string, string> flinkConfiguration, string jobId, string status, string jobOutput, string actionResult, string lastSavePoint) : base(jobType)
        {
            JobName = jobName;
            JobJarDirectory = jobJarDirectory;
            JarName = jarName;
            EntryClass = entryClass;
            Args = args;
            SavePointName = savePointName;
            Action = action;
            FlinkConfiguration = flinkConfiguration;
            JobId = jobId;
            Status = status;
            JobOutput = jobOutput;
            ActionResult = actionResult;
            LastSavePoint = lastSavePoint;
            JobType = jobType;
        }

        /// <summary> Name of job. </summary>
        public string JobName { get; set; }
        /// <summary> A string property that specifies the directory where the job JAR is located. </summary>
        public string JobJarDirectory { get; set; }
        /// <summary> A string property that represents the name of the job JAR. </summary>
        public string JarName { get; set; }
        /// <summary> A string property that specifies the entry class for the Flink job. </summary>
        public string EntryClass { get; set; }
        /// <summary> A string property representing additional JVM arguments for the Flink job. It should be space separated value. </summary>
        public string Args { get; set; }
        /// <summary> A string property that represents the name of the savepoint for the Flink job. </summary>
        public string SavePointName { get; set; }
        /// <summary> A string property that indicates the action to be performed on the Flink job. It can have one of the following enum values =&gt; NEW, UPDATE, STATELESS_UPDATE, STOP, START, CANCEL, SAVEPOINT, LIST_SAVEPOINT, or DELETE. </summary>
        public FlinkJobAction? Action { get; set; }
        /// <summary> Additional properties used to configure Flink jobs. It allows users to set properties such as parallelism and jobSavePointDirectory. It accepts additional key-value pairs as properties, where the keys are strings and the values are strings as well. </summary>
        public IDictionary<string, string> FlinkConfiguration { get; }
        /// <summary> Unique id for identifying a job. </summary>
        public string JobId { get; }
        /// <summary> Status of job. </summary>
        public string Status { get; }
        /// <summary> Output of job. </summary>
        public string JobOutput { get; }
        /// <summary> Action result of job. </summary>
        public string ActionResult { get; }
        /// <summary> The last savepoint. </summary>
        public string LastSavePoint { get; }
    }
}
