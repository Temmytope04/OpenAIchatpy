// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.CustomVision.Training.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Entry associating a region to an image.
    /// </summary>
    public partial class ImageRegionCreateEntry
    {
        /// <summary>
        /// Initializes a new instance of the ImageRegionCreateEntry class.
        /// </summary>
        public ImageRegionCreateEntry()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImageRegionCreateEntry class.
        /// </summary>
        /// <param name="imageId">Id of the image.</param>
        /// <param name="tagId">Id of the tag associated with this
        /// region.</param>
        public ImageRegionCreateEntry(System.Guid imageId = default(System.Guid), System.Guid tagId = default(System.Guid), double left = default(double), double top = default(double), double width = default(double), double height = default(double))
        {
            ImageId = imageId;
            TagId = tagId;
            Left = left;
            Top = top;
            Width = width;
            Height = height;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets id of the image.
        /// </summary>
        [JsonProperty(PropertyName = "imageId")]
        public System.Guid ImageId { get; set; }

        /// <summary>
        /// Gets or sets id of the tag associated with this region.
        /// </summary>
        [JsonProperty(PropertyName = "tagId")]
        public System.Guid TagId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "left")]
        public double Left { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "top")]
        public double Top { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "width")]
        public double Width { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "height")]
        public double Height { get; set; }

    }
}
