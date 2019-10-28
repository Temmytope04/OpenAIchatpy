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
    /// Snapshot resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Snapshot : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Snapshot class.
        /// </summary>
        public Snapshot()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Snapshot class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="creationData">Disk source information. CreationData
        /// information cannot be changed after the disk has been
        /// created.</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="managedBy">Unused. Always Null.</param>
        /// <param name="timeCreated">The time when the disk was
        /// created.</param>
        /// <param name="osType">The Operating System type. Possible values
        /// include: 'Windows', 'Linux'</param>
        /// <param name="hyperVGeneration">The hypervisor generation of the
        /// Virtual Machine. Applicable to OS disks only. Possible values
        /// include: 'V1', 'V2'</param>
        /// <param name="diskSizeGB">If creationData.createOption is Empty,
        /// this field is mandatory and it indicates the size of the disk to
        /// create. If this field is present for updates or creation with other
        /// options, it indicates a resize. Resizes are only allowed if the
        /// disk is not attached to a running VM, and can only increase the
        /// disk's size.</param>
        /// <param name="diskSizeBytes">The size of the disk in bytes. This
        /// field is read only.</param>
        /// <param name="uniqueId">Unique Guid identifying the
        /// resource.</param>
        /// <param name="encryptionSettingsCollection">Encryption settings
        /// collection used be Azure Disk Encryption, can contain multiple
        /// encryption settings per disk or snapshot.</param>
        /// <param name="provisioningState">The disk provisioning
        /// state.</param>
        /// <param name="incremental">Whether a snapshot is incremental.
        /// Incremental snapshots on the same disk occupy less space than full
        /// snapshots and can be diffed.</param>
        /// <param name="encryption">Encryption property can be used to encrypt
        /// data at rest with customer managed keys or platform managed
        /// keys.</param>
        public Snapshot(string location, CreationData creationData, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string managedBy = default(string), SnapshotSku sku = default(SnapshotSku), System.DateTime? timeCreated = default(System.DateTime?), OperatingSystemTypes? osType = default(OperatingSystemTypes?), string hyperVGeneration = default(string), int? diskSizeGB = default(int?), long? diskSizeBytes = default(long?), string uniqueId = default(string), EncryptionSettingsCollection encryptionSettingsCollection = default(EncryptionSettingsCollection), string provisioningState = default(string), bool? incremental = default(bool?), Encryption encryption = default(Encryption))
            : base(location, id, name, type, tags)
        {
            ManagedBy = managedBy;
            Sku = sku;
            TimeCreated = timeCreated;
            OsType = osType;
            HyperVGeneration = hyperVGeneration;
            CreationData = creationData;
            DiskSizeGB = diskSizeGB;
            DiskSizeBytes = diskSizeBytes;
            UniqueId = uniqueId;
            EncryptionSettingsCollection = encryptionSettingsCollection;
            ProvisioningState = provisioningState;
            Incremental = incremental;
            Encryption = encryption;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets unused. Always Null.
        /// </summary>
        [JsonProperty(PropertyName = "managedBy")]
        public string ManagedBy { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public SnapshotSku Sku { get; set; }

        /// <summary>
        /// Gets the time when the disk was created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.timeCreated")]
        public System.DateTime? TimeCreated { get; private set; }

        /// <summary>
        /// Gets or sets the Operating System type. Possible values include:
        /// 'Windows', 'Linux'
        /// </summary>
        [JsonProperty(PropertyName = "properties.osType")]
        public OperatingSystemTypes? OsType { get; set; }

        /// <summary>
        /// Gets or sets the hypervisor generation of the Virtual Machine.
        /// Applicable to OS disks only. Possible values include: 'V1', 'V2'
        /// </summary>
        [JsonProperty(PropertyName = "properties.hyperVGeneration")]
        public string HyperVGeneration { get; set; }

        /// <summary>
        /// Gets or sets disk source information. CreationData information
        /// cannot be changed after the disk has been created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.creationData")]
        public CreationData CreationData { get; set; }

        /// <summary>
        /// Gets or sets if creationData.createOption is Empty, this field is
        /// mandatory and it indicates the size of the disk to create. If this
        /// field is present for updates or creation with other options, it
        /// indicates a resize. Resizes are only allowed if the disk is not
        /// attached to a running VM, and can only increase the disk's size.
        /// </summary>
        [JsonProperty(PropertyName = "properties.diskSizeGB")]
        public int? DiskSizeGB { get; set; }

        /// <summary>
        /// Gets the size of the disk in bytes. This field is read only.
        /// </summary>
        [JsonProperty(PropertyName = "properties.diskSizeBytes")]
        public long? DiskSizeBytes { get; private set; }

        /// <summary>
        /// Gets unique Guid identifying the resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.uniqueId")]
        public string UniqueId { get; private set; }

        /// <summary>
        /// Gets or sets encryption settings collection used be Azure Disk
        /// Encryption, can contain multiple encryption settings per disk or
        /// snapshot.
        /// </summary>
        [JsonProperty(PropertyName = "properties.encryptionSettingsCollection")]
        public EncryptionSettingsCollection EncryptionSettingsCollection { get; set; }

        /// <summary>
        /// Gets the disk provisioning state.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets whether a snapshot is incremental. Incremental
        /// snapshots on the same disk occupy less space than full snapshots
        /// and can be diffed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.incremental")]
        public bool? Incremental { get; set; }

        /// <summary>
        /// Gets or sets encryption property can be used to encrypt data at
        /// rest with customer managed keys or platform managed keys.
        /// </summary>
        [JsonProperty(PropertyName = "properties.encryption")]
        public Encryption Encryption { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (CreationData == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CreationData");
            }
            if (CreationData != null)
            {
                CreationData.Validate();
            }
            if (EncryptionSettingsCollection != null)
            {
                EncryptionSettingsCollection.Validate();
            }
            if (Encryption != null)
            {
                Encryption.Validate();
            }
        }
    }
}
