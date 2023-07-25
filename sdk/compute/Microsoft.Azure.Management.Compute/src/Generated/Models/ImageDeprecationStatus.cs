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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes image deprecation status properties on the image.
    /// </summary>
    public partial class ImageDeprecationStatus
    {
        /// <summary>
        /// Initializes a new instance of the ImageDeprecationStatus class.
        /// </summary>
        public ImageDeprecationStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImageDeprecationStatus class.
        /// </summary>
        /// <param name="imageState">Describes the state of the image. Possible
        /// values include: 'Active', 'ScheduledForDeprecation',
        /// 'Deprecated'</param>
        /// <param name="scheduledDeprecationTime">The time, in future, at
        /// which this image will be marked as deprecated. This scheduled time
        /// is chosen by the Publisher.</param>
        public ImageDeprecationStatus(string imageState = default(string), System.DateTime? scheduledDeprecationTime = default(System.DateTime?), AlternativeOption alternativeOption = default(AlternativeOption))
        {
            ImageState = imageState;
            ScheduledDeprecationTime = scheduledDeprecationTime;
            AlternativeOption = alternativeOption;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets describes the state of the image. Possible values
        /// include: 'Active', 'ScheduledForDeprecation', 'Deprecated'
        /// </summary>
        [JsonProperty(PropertyName = "imageState")]
        public string ImageState { get; set; }

        /// <summary>
        /// Gets or sets the time, in future, at which this image will be
        /// marked as deprecated. This scheduled time is chosen by the
        /// Publisher.
        /// </summary>
        [JsonProperty(PropertyName = "scheduledDeprecationTime")]
        public System.DateTime? ScheduledDeprecationTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "alternativeOption")]
        public AlternativeOption AlternativeOption { get; set; }

    }
}
