// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> HDInsight Spark activity. </summary>
    public partial class HDInsightSparkActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of HDInsightSparkActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="rootPath"> The root path in &apos;sparkJobLinkedService&apos; for all the job’s files. Type: string (or Expression with resultType string). </param>
        /// <param name="entryFilePath"> The relative path to the root folder of the code/package to be executed. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="rootPath"/>, or <paramref name="entryFilePath"/> is null. </exception>
        public HDInsightSparkActivity(string name, object rootPath, object entryFilePath) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (rootPath == null)
            {
                throw new ArgumentNullException(nameof(rootPath));
            }
            if (entryFilePath == null)
            {
                throw new ArgumentNullException(nameof(entryFilePath));
            }

            RootPath = rootPath;
            EntryFilePath = entryFilePath;
            Arguments = new ChangeTrackingList<object>();
            SparkConfig = new ChangeTrackingDictionary<string, object>();
            Type = "HDInsightSpark";
        }

        /// <summary> Initializes a new instance of HDInsightSparkActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="type"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> . </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="rootPath"> The root path in &apos;sparkJobLinkedService&apos; for all the job’s files. Type: string (or Expression with resultType string). </param>
        /// <param name="entryFilePath"> The relative path to the root folder of the code/package to be executed. Type: string (or Expression with resultType string). </param>
        /// <param name="arguments"> The user-specified arguments to HDInsightSparkActivity. </param>
        /// <param name="getDebugInfo"> Debug info option. </param>
        /// <param name="sparkJobLinkedService"> The storage linked service for uploading the entry file and dependencies, and for receiving logs. </param>
        /// <param name="className"> The application&apos;s Java/Spark main class. </param>
        /// <param name="proxyUser"> The user to impersonate that will execute the job. Type: string (or Expression with resultType string). </param>
        /// <param name="sparkConfig"> Spark configuration property. </param>
        internal HDInsightSparkActivity(string name, string type, string description, IList<ActivityDependency> dependsOn, IList<UserProperty> userProperties, IDictionary<string, object> additionalProperties, LinkedServiceReference linkedServiceName, ActivityPolicy policy, object rootPath, object entryFilePath, IList<object> arguments, HDInsightActivityDebugInfoOption? getDebugInfo, LinkedServiceReference sparkJobLinkedService, string className, object proxyUser, IDictionary<string, object> sparkConfig) : base(name, type, description, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            RootPath = rootPath;
            EntryFilePath = entryFilePath;
            Arguments = arguments;
            GetDebugInfo = getDebugInfo;
            SparkJobLinkedService = sparkJobLinkedService;
            ClassName = className;
            ProxyUser = proxyUser;
            SparkConfig = sparkConfig;
            Type = type ?? "HDInsightSpark";
        }

        /// <summary> The root path in &apos;sparkJobLinkedService&apos; for all the job’s files. Type: string (or Expression with resultType string). </summary>
        public object RootPath { get; set; }
        /// <summary> The relative path to the root folder of the code/package to be executed. Type: string (or Expression with resultType string). </summary>
        public object EntryFilePath { get; set; }
        /// <summary> The user-specified arguments to HDInsightSparkActivity. </summary>
        public IList<object> Arguments { get; }
        /// <summary> Debug info option. </summary>
        public HDInsightActivityDebugInfoOption? GetDebugInfo { get; set; }
        /// <summary> The storage linked service for uploading the entry file and dependencies, and for receiving logs. </summary>
        public LinkedServiceReference SparkJobLinkedService { get; set; }
        /// <summary> The application&apos;s Java/Spark main class. </summary>
        public string ClassName { get; set; }
        /// <summary> The user to impersonate that will execute the job. Type: string (or Expression with resultType string). </summary>
        public object ProxyUser { get; set; }
        /// <summary> Spark configuration property. </summary>
        public IDictionary<string, object> SparkConfig { get; }
    }
}
