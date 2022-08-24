// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The parameters supplied to the create hybrid runbook worker group operation. </summary>
    public partial class HybridRunbookWorkerGroupCreateOrUpdateParameters
    {
        /// <summary> Initializes a new instance of HybridRunbookWorkerGroupCreateOrUpdateParameters. </summary>
        public HybridRunbookWorkerGroupCreateOrUpdateParameters()
        {
        }

        /// <summary> Gets or sets the name of the resource. </summary>
        public string Name { get; set; }
        /// <summary> Sets the credential of a worker group. </summary>
        internal RunAsCredentialAssociationProperty Credential { get; set; }
        /// <summary> Gets or sets the name of the credential. </summary>
        public string CredentialName
        {
            get => Credential is null ? default : Credential.Name;
            set
            {
                if (Credential is null)
                    Credential = new RunAsCredentialAssociationProperty();
                Credential.Name = value;
            }
        }
    }
}
