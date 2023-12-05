// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> This is the disk image base class. </summary>
    public partial class SharedGalleryDiskImage
    {
        /// <summary> Initializes a new instance of <see cref="SharedGalleryDiskImage"/>. </summary>
        internal SharedGalleryDiskImage()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SharedGalleryDiskImage"/>. </summary>
        /// <param name="diskSizeGB"> This property indicates the size of the VHD to be created. </param>
        /// <param name="hostCaching"> The host caching of the disk. Valid values are 'None', 'ReadOnly', and 'ReadWrite'. </param>
        internal SharedGalleryDiskImage(int? diskSizeGB, SharedGalleryHostCaching? hostCaching)
        {
            DiskSizeGB = diskSizeGB;
            HostCaching = hostCaching;
        }

        /// <summary> This property indicates the size of the VHD to be created. </summary>
        public int? DiskSizeGB { get; }
        /// <summary> The host caching of the disk. Valid values are 'None', 'ReadOnly', and 'ReadWrite'. </summary>
        public SharedGalleryHostCaching? HostCaching { get; }
    }
}
