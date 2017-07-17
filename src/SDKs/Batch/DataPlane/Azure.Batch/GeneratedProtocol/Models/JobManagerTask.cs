// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// Specifies details of a Job Manager task.
    /// </summary>
    public partial class JobManagerTask
    {
        /// <summary>
        /// Initializes a new instance of the JobManagerTask class.
        /// </summary>
        public JobManagerTask() { }

        /// <summary>
        /// Initializes a new instance of the JobManagerTask class.
        /// </summary>
        /// <param name="id">A string that uniquely identifies the Job Manager
        /// taskwithin the job.</param>
        /// <param name="commandLine">The command line of the Job Manager
        /// task.</param>
        /// <param name="displayName">The display name of the Job Manager
        /// task.</param>
        /// <param name="resourceFiles">A list of files that the Batch service
        /// will download to the compute node before running the command
        /// line.</param>
        /// <param name="outputFiles">A list of files that the Batch service
        /// will upload from the compute node after running the command
        /// line.</param>
        /// <param name="environmentSettings">A list of environment variable
        /// settings for the Job Manager task.</param>
        /// <param name="constraints">Constraints that apply to the Job Manager
        /// task.</param>
        /// <param name="killJobOnCompletion">Whether completion of the Job
        /// Manager task signifies completion of the entire job.</param>
        /// <param name="userIdentity">The user identity under which the Job
        /// Manager task runs.</param>
        /// <param name="runExclusive">Whether the Job Manager task requires
        /// exclusive use of the compute node where it runs.</param>
        /// <param name="applicationPackageReferences">A list of application
        /// packages that the Batch service will deploy to the compute node
        /// before running the command line.</param>
        /// <param name="authenticationTokenSettings">The settings for an
        /// authentication token that the task can use to perform Batch service
        /// operations.</param>
        /// <param name="allowLowPriorityNode">Whether the Job Manager task may
        /// run on a low-priority compute node.</param>
        public JobManagerTask(string id, string commandLine, string displayName = default(string), System.Collections.Generic.IList<ResourceFile> resourceFiles = default(System.Collections.Generic.IList<ResourceFile>), System.Collections.Generic.IList<OutputFile> outputFiles = default(System.Collections.Generic.IList<OutputFile>), System.Collections.Generic.IList<EnvironmentSetting> environmentSettings = default(System.Collections.Generic.IList<EnvironmentSetting>), TaskConstraints constraints = default(TaskConstraints), bool? killJobOnCompletion = default(bool?), UserIdentity userIdentity = default(UserIdentity), bool? runExclusive = default(bool?), System.Collections.Generic.IList<ApplicationPackageReference> applicationPackageReferences = default(System.Collections.Generic.IList<ApplicationPackageReference>), AuthenticationTokenSettings authenticationTokenSettings = default(AuthenticationTokenSettings), bool? allowLowPriorityNode = default(bool?))
        {
            this.Id = id;
            this.DisplayName = displayName;
            this.CommandLine = commandLine;
            this.ResourceFiles = resourceFiles;
            this.OutputFiles = outputFiles;
            this.EnvironmentSettings = environmentSettings;
            this.Constraints = constraints;
            this.KillJobOnCompletion = killJobOnCompletion;
            this.UserIdentity = userIdentity;
            this.RunExclusive = runExclusive;
            this.ApplicationPackageReferences = applicationPackageReferences;
            this.AuthenticationTokenSettings = authenticationTokenSettings;
            this.AllowLowPriorityNode = allowLowPriorityNode;
        }

        /// <summary>
        /// Gets or sets a string that uniquely identifies the Job Manager
        /// taskwithin the job.
        /// </summary>
        /// <remarks>
        /// The id can contain any combination of alphanumeric characters
        /// including hyphens and underscores and cannot contain more than 64
        /// characters.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the display name of the Job Manager task.
        /// </summary>
        /// <remarks>
        /// It need not be unique and can contain any Unicode characters up to
        /// a maximum length of 1024.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the command line of the Job Manager task.
        /// </summary>
        /// <remarks>
        /// The command line does not run under a shell, and therefore cannot
        /// take advantage of shell features such as environment variable
        /// expansion. If you want to take advantage of such features, you
        /// should invoke the shell in the command line, for example using "cmd
        /// /c MyCommand" in Windows or "/bin/sh -c MyCommand" in Linux.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "commandLine")]
        public string CommandLine { get; set; }

        /// <summary>
        /// Gets or sets a list of files that the Batch service will download
        /// to the compute node before running the command line.
        /// </summary>
        /// <remarks>
        /// Files listed under this element are located in the task's working
        /// directory.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "resourceFiles")]
        public System.Collections.Generic.IList<ResourceFile> ResourceFiles { get; set; }

        /// <summary>
        /// Gets or sets a list of files that the Batch service will upload
        /// from the compute node after running the command line.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "outputFiles")]
        public System.Collections.Generic.IList<OutputFile> OutputFiles { get; set; }

        /// <summary>
        /// Gets or sets a list of environment variable settings for the Job
        /// Manager task.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "environmentSettings")]
        public System.Collections.Generic.IList<EnvironmentSetting> EnvironmentSettings { get; set; }

        /// <summary>
        /// Gets or sets constraints that apply to the Job Manager task.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "constraints")]
        public TaskConstraints Constraints { get; set; }

        /// <summary>
        /// Gets or sets whether completion of the Job Manager task signifies
        /// completion of the entire job.
        /// </summary>
        /// <remarks>
        /// If true, when the Job Manager task completes, the Batch service
        /// marks the job as complete. If any tasks are still running at this
        /// time (other than Job Release), those tasks are terminated. If
        /// false, the completion of the Job Manager task does not affect the
        /// job status. In this case, you should either use the
        /// onAllTasksComplete attribute to terminate the job, or have a client
        /// or user terminate the job explicitly. An example of this is if the
        /// Job Manager creates a set of tasks but then takes no further role
        /// in their execution. The default value is true. If you are using the
        /// onAllTasksComplete and onTaskFailure attributes to control job
        /// lifetime, and using the Job Manager task only to create the tasks
        /// for the job (not to monitor progress), then it is important to set
        /// killJobOnCompletion to false.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "killJobOnCompletion")]
        public bool? KillJobOnCompletion { get; set; }

        /// <summary>
        /// Gets or sets the user identity under which the Job Manager task
        /// runs.
        /// </summary>
        /// <remarks>
        /// If omitted, the task runs as a non-administrative user unique to
        /// the task.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "userIdentity")]
        public UserIdentity UserIdentity { get; set; }

        /// <summary>
        /// Gets or sets whether the Job Manager task requires exclusive use of
        /// the compute node where it runs.
        /// </summary>
        /// <remarks>
        /// If true, no other tasks will run on the same compute node for as
        /// long as the Job Manager is running. If false, other tasks can run
        /// simultaneously with the Job Manager on a compute node. The Job
        /// Manager task counts normally against the node's concurrent task
        /// limit, so this is only relevant if the node allows multiple
        /// concurrent tasks. The default value is true.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "runExclusive")]
        public bool? RunExclusive { get; set; }

        /// <summary>
        /// Gets or sets a list of application packages that the Batch service
        /// will deploy to the compute node before running the command line.
        /// </summary>
        /// <remarks>
        /// Application packages are downloaded and deployed to a shared
        /// directory, not the task directory. Therefore, if a referenced
        /// package is already on the compute node, and is up to date, then it
        /// is not re-downloaded; the existing copy on the compute node is
        /// used. If a referenced application package cannot be installed, for
        /// example because the package has been deleted or because download
        /// failed, the task fails with a scheduling error.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "applicationPackageReferences")]
        public System.Collections.Generic.IList<ApplicationPackageReference> ApplicationPackageReferences { get; set; }

        /// <summary>
        /// Gets or sets the settings for an authentication token that the task
        /// can use to perform Batch service operations.
        /// </summary>
        /// <remarks>
        /// If this property is set, the Batch service provides the task with
        /// an authentication token which can be used to authenticate Batch
        /// service operations without requiring an account access key. The
        /// token is provided via the AZ_BATCH_AUTHENTICATION_TOKEN environment
        /// variable. The operations that the task can carry out using the
        /// token depend on the settings. For example, a task can request job
        /// permissions in order to add other tasks to the job, or check the
        /// status of the job or of other tasks under the job.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "authenticationTokenSettings")]
        public AuthenticationTokenSettings AuthenticationTokenSettings { get; set; }

        /// <summary>
        /// Gets or sets whether the Job Manager task may run on a low-priority
        /// compute node.
        /// </summary>
        /// <remarks>
        /// The default value is false.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "allowLowPriorityNode")]
        public bool? AllowLowPriorityNode { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Id == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Id");
            }
            if (this.CommandLine == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "CommandLine");
            }
            if (this.ResourceFiles != null)
            {
                foreach (var element in this.ResourceFiles)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.OutputFiles != null)
            {
                foreach (var element1 in this.OutputFiles)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (this.EnvironmentSettings != null)
            {
                foreach (var element2 in this.EnvironmentSettings)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
            if (this.ApplicationPackageReferences != null)
            {
                foreach (var element3 in this.ApplicationPackageReferences)
                {
                    if (element3 != null)
                    {
                        element3.Validate();
                    }
                }
            }
        }
    }
}
