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
    using System.Linq;

    /// <summary>
    /// An object detected inside an image.
    /// </summary>
    public partial class ObjectHierarchy
    {
        /// <summary>
        /// Initializes a new instance of the ObjectHierarchy class.
        /// </summary>
        public ObjectHierarchy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ObjectHierarchy class.
        /// </summary>
        /// <param name="objectProperty">Label for the object.</param>
        /// <param name="confidence">Confidence score of having observed the
        /// object in the image, as a value ranging from 0 to 1.</param>
        /// <param name="parent">The parent object, from a taxonomy
        /// perspective.
        /// The parent object is a more generic form of this object.  For
        /// example, a 'bulldog' would have a parent of 'dog'.</param>
        public ObjectHierarchy(string objectProperty = default(string), double confidence = default(double), ObjectHierarchy parent = default(ObjectHierarchy))
        {
            ObjectProperty = objectProperty;
            Confidence = confidence;
            Parent = parent;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets label for the object.
        /// </summary>
        [JsonProperty(PropertyName = "object")]
        public string ObjectProperty { get; set; }

        /// <summary>
        /// Gets or sets confidence score of having observed the object in the
        /// image, as a value ranging from 0 to 1.
        /// </summary>
        [JsonProperty(PropertyName = "confidence")]
        public double Confidence { get; set; }

        /// <summary>
        /// Gets or sets the parent object, from a taxonomy perspective.
        /// The parent object is a more generic form of this object.  For
        /// example, a 'bulldog' would have a parent of 'dog'.
        /// </summary>
        [JsonProperty(PropertyName = "parent")]
        public ObjectHierarchy Parent { get; set; }

    }
}
