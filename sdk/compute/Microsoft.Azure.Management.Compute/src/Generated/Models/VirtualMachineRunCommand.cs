// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes a Virtual Machine run command.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VirtualMachineRunCommand : Resource
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineRunCommand class.
        /// </summary>
        public VirtualMachineRunCommand()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineRunCommand class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="source">The source of the run command script.</param>
        /// <param name="parameters">The parameters used by the script.</param>
        /// <param name="protectedParameters">The parameters used by the
        /// script.</param>
        /// <param name="asyncExecution">Optional. If set to true, provisioning
        /// will complete as soon as the script starts and will not wait for
        /// script to complete.</param>
        /// <param name="runAsUser">Specifies the user account on the VM when
        /// executing the run command.</param>
        /// <param name="runAsPassword">Specifies the user account password on
        /// the VM when executing the run command.</param>
        /// <param name="timeoutInSeconds">The timeout in seconds to execute
        /// the run command.</param>
        /// <param name="outputBlobUri">Specifies the Azure storage blob where
        /// script output stream will be uploaded. Use a SAS URI with read,
        /// append, create, write access OR use managed identity to provide the
        /// VM access to the blob. Refer outputBlobManagedIdentity parameter.
        /// </param>
        /// <param name="errorBlobUri">Specifies the Azure storage blob where
        /// script error stream will be uploaded. Use a SAS URI with read,
        /// append, create, write access OR use managed identity to provide the
        /// VM access to the blob. Refer errorBlobManagedIdentity
        /// parameter.</param>
        /// <param name="outputBlobManagedIdentity">User-assigned managed
        /// identity that has access to outputBlobUri storage blob. Use an
        /// empty object in case of system-assigned identity. Make sure managed
        /// identity has been given access to blob's container with 'Storage
        /// Blob Data Contributor' role assignment. In case of user-assigned
        /// identity, make sure you add it under VM's identity. For more info
        /// on managed identity and Run Command, refer
        /// https://aka.ms/ManagedIdentity and https://aka.ms/RunCommandManaged
        /// </param>
        /// <param name="errorBlobManagedIdentity">User-assigned managed
        /// identity that has access to errorBlobUri storage blob. Use an empty
        /// object in case of system-assigned identity. Make sure managed
        /// identity has been given access to blob's container with 'Storage
        /// Blob Data Contributor' role assignment. In case of user-assigned
        /// identity, make sure you add it under VM's identity. For more info
        /// on managed identity and Run Command, refer
        /// https://aka.ms/ManagedIdentity and https://aka.ms/RunCommandManaged
        /// </param>
        /// <param name="provisioningState">The provisioning state, which only
        /// appears in the response. If treatFailureAsDeploymentFailure set to
        /// true, any failure in the script will fail the deployment and
        /// ProvisioningState will be marked as Failed. If
        /// treatFailureAsDeploymentFailure set to false, ProvisioningState
        /// would only reflect whether the run command was run or not by the
        /// extensions platform, it would not indicate whether script failed in
        /// case of script failures. See instance view of run command in case
        /// of script failures to see executionMessage, output, error:
        /// https://aka.ms/runcommandmanaged#get-execution-status-and-results
        /// </param>
        /// <param name="instanceView">The virtual machine run command instance
        /// view.</param>
        /// <param name="treatFailureAsDeploymentFailure">Optional. If set to
        /// true, any failure in the script will fail the deployment and
        /// ProvisioningState will be marked as Failed. If set to false,
        /// ProvisioningState would only reflect whether the run command was
        /// run or not by the extensions platform, it would not indicate
        /// whether script failed in case of script failures. See instance view
        /// of run command in case of script failures to see executionMessage,
        /// output, error:
        /// https://aka.ms/runcommandmanaged#get-execution-status-and-results
        /// </param>
        public VirtualMachineRunCommand(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), VirtualMachineRunCommandScriptSource source = default(VirtualMachineRunCommandScriptSource), IList<RunCommandInputParameter> parameters = default(IList<RunCommandInputParameter>), IList<RunCommandInputParameter> protectedParameters = default(IList<RunCommandInputParameter>), bool? asyncExecution = default(bool?), string runAsUser = default(string), string runAsPassword = default(string), int? timeoutInSeconds = default(int?), string outputBlobUri = default(string), string errorBlobUri = default(string), RunCommandManagedIdentity outputBlobManagedIdentity = default(RunCommandManagedIdentity), RunCommandManagedIdentity errorBlobManagedIdentity = default(RunCommandManagedIdentity), string provisioningState = default(string), VirtualMachineRunCommandInstanceView instanceView = default(VirtualMachineRunCommandInstanceView), bool? treatFailureAsDeploymentFailure = default(bool?))
            : base(location, id, name, type, tags)
        {
            Source = source;
            Parameters = parameters;
            ProtectedParameters = protectedParameters;
            AsyncExecution = asyncExecution;
            RunAsUser = runAsUser;
            RunAsPassword = runAsPassword;
            TimeoutInSeconds = timeoutInSeconds;
            OutputBlobUri = outputBlobUri;
            ErrorBlobUri = errorBlobUri;
            OutputBlobManagedIdentity = outputBlobManagedIdentity;
            ErrorBlobManagedIdentity = errorBlobManagedIdentity;
            ProvisioningState = provisioningState;
            InstanceView = instanceView;
            TreatFailureAsDeploymentFailure = treatFailureAsDeploymentFailure;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the source of the run command script.
        /// </summary>
        [JsonProperty(PropertyName = "properties.source")]
        public VirtualMachineRunCommandScriptSource Source { get; set; }

        /// <summary>
        /// Gets or sets the parameters used by the script.
        /// </summary>
        [JsonProperty(PropertyName = "properties.parameters")]
        public IList<RunCommandInputParameter> Parameters { get; set; }

        /// <summary>
        /// Gets or sets the parameters used by the script.
        /// </summary>
        [JsonProperty(PropertyName = "properties.protectedParameters")]
        public IList<RunCommandInputParameter> ProtectedParameters { get; set; }

        /// <summary>
        /// Gets or sets optional. If set to true, provisioning will complete
        /// as soon as the script starts and will not wait for script to
        /// complete.
        /// </summary>
        [JsonProperty(PropertyName = "properties.asyncExecution")]
        public bool? AsyncExecution { get; set; }

        /// <summary>
        /// Gets or sets specifies the user account on the VM when executing
        /// the run command.
        /// </summary>
        [JsonProperty(PropertyName = "properties.runAsUser")]
        public string RunAsUser { get; set; }

        /// <summary>
        /// Gets or sets specifies the user account password on the VM when
        /// executing the run command.
        /// </summary>
        [JsonProperty(PropertyName = "properties.runAsPassword")]
        public string RunAsPassword { get; set; }

        /// <summary>
        /// Gets or sets the timeout in seconds to execute the run command.
        /// </summary>
        [JsonProperty(PropertyName = "properties.timeoutInSeconds")]
        public int? TimeoutInSeconds { get; set; }

        /// <summary>
        /// Gets or sets specifies the Azure storage blob where script output
        /// stream will be uploaded. Use a SAS URI with read, append, create,
        /// write access OR use managed identity to provide the VM access to
        /// the blob. Refer outputBlobManagedIdentity parameter.
        /// </summary>
        [JsonProperty(PropertyName = "properties.outputBlobUri")]
        public string OutputBlobUri { get; set; }

        /// <summary>
        /// Gets or sets specifies the Azure storage blob where script error
        /// stream will be uploaded. Use a SAS URI with read, append, create,
        /// write access OR use managed identity to provide the VM access to
        /// the blob. Refer errorBlobManagedIdentity parameter.
        /// </summary>
        [JsonProperty(PropertyName = "properties.errorBlobUri")]
        public string ErrorBlobUri { get; set; }

        /// <summary>
        /// Gets or sets user-assigned managed identity that has access to
        /// outputBlobUri storage blob. Use an empty object in case of
        /// system-assigned identity. Make sure managed identity has been given
        /// access to blob's container with 'Storage Blob Data Contributor'
        /// role assignment. In case of user-assigned identity, make sure you
        /// add it under VM's identity. For more info on managed identity and
        /// Run Command, refer https://aka.ms/ManagedIdentity and
        /// https://aka.ms/RunCommandManaged
        /// </summary>
        [JsonProperty(PropertyName = "properties.outputBlobManagedIdentity")]
        public RunCommandManagedIdentity OutputBlobManagedIdentity { get; set; }

        /// <summary>
        /// Gets or sets user-assigned managed identity that has access to
        /// errorBlobUri storage blob. Use an empty object in case of
        /// system-assigned identity. Make sure managed identity has been given
        /// access to blob's container with 'Storage Blob Data Contributor'
        /// role assignment. In case of user-assigned identity, make sure you
        /// add it under VM's identity. For more info on managed identity and
        /// Run Command, refer https://aka.ms/ManagedIdentity and
        /// https://aka.ms/RunCommandManaged
        /// </summary>
        [JsonProperty(PropertyName = "properties.errorBlobManagedIdentity")]
        public RunCommandManagedIdentity ErrorBlobManagedIdentity { get; set; }

        /// <summary>
        /// Gets the provisioning state, which only appears in the response. If
        /// treatFailureAsDeploymentFailure set to true, any failure in the
        /// script will fail the deployment and ProvisioningState will be
        /// marked as Failed. If treatFailureAsDeploymentFailure set to false,
        /// ProvisioningState would only reflect whether the run command was
        /// run or not by the extensions platform, it would not indicate
        /// whether script failed in case of script failures. See instance view
        /// of run command in case of script failures to see executionMessage,
        /// output, error:
        /// https://aka.ms/runcommandmanaged#get-execution-status-and-results
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the virtual machine run command instance view.
        /// </summary>
        [JsonProperty(PropertyName = "properties.instanceView")]
        public VirtualMachineRunCommandInstanceView InstanceView { get; private set; }

        /// <summary>
        /// Gets or sets optional. If set to true, any failure in the script
        /// will fail the deployment and ProvisioningState will be marked as
        /// Failed. If set to false, ProvisioningState would only reflect
        /// whether the run command was run or not by the extensions platform,
        /// it would not indicate whether script failed in case of script
        /// failures. See instance view of run command in case of script
        /// failures to see executionMessage, output, error:
        /// https://aka.ms/runcommandmanaged#get-execution-status-and-results
        /// </summary>
        [JsonProperty(PropertyName = "properties.treatFailureAsDeploymentFailure")]
        public bool? TreatFailureAsDeploymentFailure { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Parameters != null)
            {
                foreach (var element in Parameters)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (ProtectedParameters != null)
            {
                foreach (var element1 in ProtectedParameters)
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
