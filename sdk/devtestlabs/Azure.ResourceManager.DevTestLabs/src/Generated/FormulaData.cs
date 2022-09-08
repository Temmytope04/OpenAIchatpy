// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DevTestLabs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DevTestLabs
{
    /// <summary> A class representing the Formula data model. </summary>
    public partial class FormulaData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of FormulaData. </summary>
        /// <param name="location"> The location. </param>
        public FormulaData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of FormulaData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="description"> The description of the formula. </param>
        /// <param name="author"> The author of the formula. </param>
        /// <param name="osType"> The OS type of the formula. </param>
        /// <param name="createdOn"> The creation date of the formula. </param>
        /// <param name="formulaContent"> The content of the formula. </param>
        /// <param name="vm"> Information about a VM from which a formula is to be created. </param>
        /// <param name="provisioningState"> The provisioning status of the resource. </param>
        /// <param name="uniqueIdentifier"> The unique immutable identifier of a resource (Guid). </param>
        internal FormulaData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string description, string author, string osType, DateTimeOffset? createdOn, LabVirtualMachineCreationParameter formulaContent, FormulaPropertiesFromVm vm, string provisioningState, string uniqueIdentifier) : base(id, name, resourceType, systemData, tags, location)
        {
            Description = description;
            Author = author;
            OSType = osType;
            CreatedOn = createdOn;
            FormulaContent = formulaContent;
            Vm = vm;
            ProvisioningState = provisioningState;
            UniqueIdentifier = uniqueIdentifier;
        }

        /// <summary> The description of the formula. </summary>
        public string Description { get; set; }
        /// <summary> The author of the formula. </summary>
        public string Author { get; }
        /// <summary> The OS type of the formula. </summary>
        public string OSType { get; set; }
        /// <summary> The creation date of the formula. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The content of the formula. </summary>
        public LabVirtualMachineCreationParameter FormulaContent { get; set; }
        /// <summary> Information about a VM from which a formula is to be created. </summary>
        internal FormulaPropertiesFromVm Vm { get; set; }
        /// <summary> The identifier of the VM from which a formula is to be created. </summary>
        public string LabVmId
        {
            get => Vm is null ? default : Vm.LabVmId;
            set
            {
                if (Vm is null)
                    Vm = new FormulaPropertiesFromVm();
                Vm.LabVmId = value;
            }
        }

        /// <summary> The provisioning status of the resource. </summary>
        public string ProvisioningState { get; }
        /// <summary> The unique immutable identifier of a resource (Guid). </summary>
        public string UniqueIdentifier { get; }
    }
}
