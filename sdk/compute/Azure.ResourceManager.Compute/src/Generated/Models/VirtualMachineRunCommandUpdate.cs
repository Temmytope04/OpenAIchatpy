// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes a Virtual Machine run command. </summary>
    public partial class VirtualMachineRunCommandUpdate : UpdateResource
    {
        /// <summary> Initializes a new instance of VirtualMachineRunCommandUpdate. </summary>
        public VirtualMachineRunCommandUpdate()
        {
            Parameters = new ChangeTrackingList<RunCommandInputParameter>();
            ProtectedParameters = new ChangeTrackingList<RunCommandInputParameter>();
        }

        /// <summary> The source of the run command script. </summary>
        public VirtualMachineRunCommandScriptSource Source { get; set; }
        /// <summary> The parameters used by the script. </summary>
        public IList<RunCommandInputParameter> Parameters { get; }
        /// <summary> The parameters used by the script. </summary>
        public IList<RunCommandInputParameter> ProtectedParameters { get; }
        /// <summary> Optional. If set to true, provisioning will complete as soon as the script starts and will not wait for script to complete. </summary>
        public bool? AsyncExecution { get; set; }
        /// <summary> Specifies the user account on the VM when executing the run command. </summary>
        public string RunAsUser { get; set; }
        /// <summary> Specifies the user account password on the VM when executing the run command. </summary>
        public string RunAsPassword { get; set; }
        /// <summary> The timeout in seconds to execute the run command. </summary>
        public int? TimeoutInSeconds { get; set; }
        /// <summary> Specifies the Azure storage blob where script output stream will be uploaded. </summary>
        public string OutputBlobUri { get; set; }
        /// <summary> Specifies the Azure storage blob where script error stream will be uploaded. </summary>
        public string ErrorBlobUri { get; set; }
        /// <summary> The provisioning state, which only appears in the response. </summary>
        public string ProvisioningState { get; }
        /// <summary> The virtual machine run command instance view. </summary>
        public VirtualMachineRunCommandInstanceView InstanceView { get; }
    }
}
