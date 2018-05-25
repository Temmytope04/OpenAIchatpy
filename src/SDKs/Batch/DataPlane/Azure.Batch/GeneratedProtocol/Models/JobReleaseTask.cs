// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A Job Release task to run on job completion on any compute node where
    /// the job has run.
    /// </summary>
    /// <remarks>
    /// The Job Release task runs when the job ends, because of one of the
    /// following: The user calls the Terminate Job API, or the Delete Job API
    /// while the job is still active, the job's maximum wall clock time
    /// constraint is reached, and the job is still active, or the job's Job
    /// Manager task completed, and the job is configured to terminate when the
    /// Job Manager completes. The Job Release task runs on each compute node
    /// where tasks of the job have run and the Job Preparation task ran and
    /// completed. If you reimage a compute node after it has run the Job
    /// Preparation task, and the job ends without any further tasks of the job
    /// running on that compute node (and hence the Job Preparation task does
    /// not re-run), then the Job Release task does not run on that node. If a
    /// compute node reboots while the Job Release task is still running, the
    /// Job Release task runs again when the compute node starts up. The job is
    /// not marked as complete until all Job Release tasks have completed. The
    /// Job Release task runs in the background. It does not occupy a
    /// scheduling slot; that is, it does not count towards the maxTasksPerNode
    /// limit specified on the pool.
    /// </remarks>
    public partial class JobReleaseTask
    {
        /// <summary>
        /// Initializes a new instance of the JobReleaseTask class.
        /// </summary>
        public JobReleaseTask()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobReleaseTask class.
        /// </summary>
        /// <param name="commandLine">The command line of the Job Release
        /// task.</param>
        /// <param name="id">A string that uniquely identifies the Job Release
        /// task within the job.</param>
        /// <param name="containerSettings">The settings for the container
        /// under which the Job Release task runs.</param>
        /// <param name="resourceFiles">A list of files that the Batch service
        /// will download to the compute node before running the command
        /// line.</param>
        /// <param name="environmentSettings">A list of environment variable
        /// settings for the Job Release task.</param>
        /// <param name="maxWallClockTime">The maximum elapsed time that the
        /// Job Release task may run on a given compute node, measured from the
        /// time the task starts. If the task does not complete within the time
        /// limit, the Batch service terminates it. The default value is 15
        /// minutes. You may not specify a timeout longer than 15 minutes. If
        /// you do, the Batch service rejects it with an error; if you are
        /// calling the REST API directly, the HTTP status code is 400 (Bad
        /// Request).</param>
        /// <param name="retentionTime">The minimum time to retain the task
        /// directory for the Job Release task on the compute node. After this
        /// time, the Batch service may delete the task directory and all its
        /// contents.</param>
        /// <param name="userIdentity">The user identity under which the Job
        /// Release task runs.</param>
        public JobReleaseTask(string commandLine, string id = default(string), TaskContainerSettings containerSettings = default(TaskContainerSettings), IList<ResourceFile> resourceFiles = default(IList<ResourceFile>), IList<EnvironmentSetting> environmentSettings = default(IList<EnvironmentSetting>), System.TimeSpan? maxWallClockTime = default(System.TimeSpan?), System.TimeSpan? retentionTime = default(System.TimeSpan?), UserIdentity userIdentity = default(UserIdentity))
        {
            Id = id;
            CommandLine = commandLine;
            ContainerSettings = containerSettings;
            ResourceFiles = resourceFiles;
            EnvironmentSettings = environmentSettings;
            MaxWallClockTime = maxWallClockTime;
            RetentionTime = retentionTime;
            UserIdentity = userIdentity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a string that uniquely identifies the Job Release task
        /// within the job.
        /// </summary>
        /// <remarks>
        /// The ID can contain any combination of alphanumeric characters
        /// including hyphens and underscores and cannot contain more than 64
        /// characters. If you do not specify this property, the Batch service
        /// assigns a default value of 'jobrelease'. No other task in the job
        /// can have the same ID as the Job Release task. If you try to submit
        /// a task with the same id, the Batch service rejects the request with
        /// error code TaskIdSameAsJobReleaseTask; if you are calling the REST
        /// API directly, the HTTP status code is 409 (Conflict).
        /// </remarks>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the command line of the Job Release task.
        /// </summary>
        /// <remarks>
        /// The command line does not run under a shell, and therefore cannot
        /// take advantage of shell features such as environment variable
        /// expansion. If you want to take advantage of such features, you
        /// should invoke the shell in the command line, for example using "cmd
        /// /c MyCommand" in Windows or "/bin/sh -c MyCommand" in Linux. If the
        /// command line refers to file paths, it should use a relative path
        /// (relative to the task working directory), or use the Batch provided
        /// environment variable
        /// (https://docs.microsoft.com/en-us/azure/batch/batch-compute-node-environment-variables).
        /// </remarks>
        [JsonProperty(PropertyName = "commandLine")]
        public string CommandLine { get; set; }

        /// <summary>
        /// Gets or sets the settings for the container under which the Job
        /// Release task runs.
        /// </summary>
        /// <remarks>
        /// When this is specified, all directories recursively below the
        /// AZ_BATCH_NODE_ROOT_DIR (the root of Azure Batch directories on the
        /// node) are mapped into the container, all task environment variables
        /// are mapped into the container, and the task command line is
        /// executed in the container.
        /// </remarks>
        [JsonProperty(PropertyName = "containerSettings")]
        public TaskContainerSettings ContainerSettings { get; set; }

        /// <summary>
        /// Gets or sets a list of files that the Batch service will download
        /// to the compute node before running the command line.
        /// </summary>
        /// <remarks>
        /// Files listed under this element are located in the task's working
        /// directory.
        /// </remarks>
        [JsonProperty(PropertyName = "resourceFiles")]
        public IList<ResourceFile> ResourceFiles { get; set; }

        /// <summary>
        /// Gets or sets a list of environment variable settings for the Job
        /// Release task.
        /// </summary>
        [JsonProperty(PropertyName = "environmentSettings")]
        public IList<EnvironmentSetting> EnvironmentSettings { get; set; }

        /// <summary>
        /// Gets or sets the maximum elapsed time that the Job Release task may
        /// run on a given compute node, measured from the time the task
        /// starts. If the task does not complete within the time limit, the
        /// Batch service terminates it. The default value is 15 minutes. You
        /// may not specify a timeout longer than 15 minutes. If you do, the
        /// Batch service rejects it with an error; if you are calling the REST
        /// API directly, the HTTP status code is 400 (Bad Request).
        /// </summary>
        [JsonProperty(PropertyName = "maxWallClockTime")]
        public System.TimeSpan? MaxWallClockTime { get; set; }

        /// <summary>
        /// Gets or sets the minimum time to retain the task directory for the
        /// Job Release task on the compute node. After this time, the Batch
        /// service may delete the task directory and all its contents.
        /// </summary>
        /// <remarks>
        /// The default is infinite, i.e. the task directory will be retained
        /// until the compute node is removed or reimaged.
        /// </remarks>
        [JsonProperty(PropertyName = "retentionTime")]
        public System.TimeSpan? RetentionTime { get; set; }

        /// <summary>
        /// Gets or sets the user identity under which the Job Release task
        /// runs.
        /// </summary>
        /// <remarks>
        /// If omitted, the task runs as a non-administrative user unique to
        /// the task.
        /// </remarks>
        [JsonProperty(PropertyName = "userIdentity")]
        public UserIdentity UserIdentity { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (CommandLine == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CommandLine");
            }
            if (ContainerSettings != null)
            {
                ContainerSettings.Validate();
            }
            if (ResourceFiles != null)
            {
                foreach (var element in ResourceFiles)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (EnvironmentSettings != null)
            {
                foreach (var element1 in EnvironmentSettings)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}
