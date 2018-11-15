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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The source image used for creating the disk.
    /// </summary>
    public partial class ImageDiskReference
    {
        /// <summary>
        /// Initializes a new instance of the ImageDiskReference class.
        /// </summary>
        public ImageDiskReference()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImageDiskReference class.
        /// </summary>
        /// <param name="id">A relative uri containing either a Platform Image
        /// Repository or user image reference.</param>
        /// <param name="lun">If the disk is created from an image's data disk,
        /// this is an index that indicates which of the data disks in the
        /// image to use. For OS disks, this field is null.</param>
        public ImageDiskReference(string id, int? lun = default(int?))
        {
            Id = id;
            Lun = lun;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a relative uri containing either a Platform Image
        /// Repository or user image reference.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets if the disk is created from an image's data disk, this
        /// is an index that indicates which of the data disks in the image to
        /// use. For OS disks, this field is null.
        /// </summary>
        [JsonProperty(PropertyName = "lun")]
        public int? Lun { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
        }
    }
}
