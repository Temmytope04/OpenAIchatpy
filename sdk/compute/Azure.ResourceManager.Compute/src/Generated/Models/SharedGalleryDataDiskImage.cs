// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> This is the data disk image. </summary>
    public partial class SharedGalleryDataDiskImage : SharedGalleryDiskImage
    {
        /// <summary> Initializes a new instance of SharedGalleryDataDiskImage. </summary>
        /// <param name="lun"> This property specifies the logical unit number of the data disk. This value is used to identify data disks within the Virtual Machine and therefore must be unique for each data disk attached to the Virtual Machine. </param>
        internal SharedGalleryDataDiskImage(int lun)
        {
            Lun = lun;
        }

        /// <summary> Initializes a new instance of SharedGalleryDataDiskImage. </summary>
        /// <param name="diskSizeGB"> This property indicates the size of the VHD to be created. </param>
        /// <param name="hostCaching"> The host caching of the disk. Valid values are &apos;None&apos;, &apos;ReadOnly&apos;, and &apos;ReadWrite&apos;. </param>
        /// <param name="lun"> This property specifies the logical unit number of the data disk. This value is used to identify data disks within the Virtual Machine and therefore must be unique for each data disk attached to the Virtual Machine. </param>
        internal SharedGalleryDataDiskImage(int? diskSizeGB, SharedGalleryHostCaching? hostCaching, int lun) : base(diskSizeGB, hostCaching)
        {
            Lun = lun;
        }

        /// <summary> This property specifies the logical unit number of the data disk. This value is used to identify data disks within the Virtual Machine and therefore must be unique for each data disk attached to the Virtual Machine. </summary>
        public int Lun { get; }
    }
}
