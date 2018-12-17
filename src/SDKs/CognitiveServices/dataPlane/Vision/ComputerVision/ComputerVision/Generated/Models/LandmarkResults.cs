// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Result of domain-specific classifications for the domain of landmarks.
    /// </summary>
    public partial class LandmarkResults
    {
        /// <summary>
        /// Initializes a new instance of the LandmarkResults class.
        /// </summary>
        public LandmarkResults()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LandmarkResults class.
        /// </summary>
        /// <param name="landmarks">List of landmarks recognized in the
        /// image.</param>
        /// <param name="requestId">Id of the REST API request.</param>
        public LandmarkResults(IList<LandmarksModel> landmarks = default(IList<LandmarksModel>), string requestId = default(string), ImageMetadata metadata = default(ImageMetadata))
        {
            Landmarks = landmarks;
            RequestId = requestId;
            Metadata = metadata;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of landmarks recognized in the image.
        /// </summary>
        [JsonProperty(PropertyName = "landmarks")]
        public IList<LandmarksModel> Landmarks { get; set; }

        /// <summary>
        /// Gets or sets id of the REST API request.
        /// </summary>
        [JsonProperty(PropertyName = "requestId")]
        public string RequestId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public ImageMetadata Metadata { get; set; }

    }
}
