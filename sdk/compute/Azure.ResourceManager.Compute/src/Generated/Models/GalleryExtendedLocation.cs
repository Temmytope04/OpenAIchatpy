// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The name of the extended location. </summary>
    public partial class GalleryExtendedLocation
    {
        /// <summary> Initializes a new instance of GalleryExtendedLocation. </summary>
        public GalleryExtendedLocation()
        {
        }

        /// <summary> Initializes a new instance of GalleryExtendedLocation. </summary>
        /// <param name="name"></param>
        /// <param name="extendedLocationType"> It is type of the extended location. </param>
        internal GalleryExtendedLocation(string name, GalleryExtendedLocationType? extendedLocationType)
        {
            Name = name;
            ExtendedLocationType = extendedLocationType;
        }

        /// <summary> Gets or sets the name. </summary>
        public string Name { get; set; }
        /// <summary> It is type of the extended location. </summary>
        public GalleryExtendedLocationType? ExtendedLocationType { get; set; }
    }
}
