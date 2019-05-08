// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Search.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A skill that analyzes image files. It extracts a rich set of visual
    /// features based on the image content.
    /// <see
    /// href="https://docs.microsoft.com/azure/search/cognitive-search-skill-image-analysis"
    /// />
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Skills.Vision.ImageAnalysisSkill")]
    public partial class ImageAnalysisSkill : Skill
    {
        /// <summary>
        /// Initializes a new instance of the ImageAnalysisSkill class.
        /// </summary>
        public ImageAnalysisSkill()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImageAnalysisSkill class.
        /// </summary>
        /// <param name="inputs">Inputs of the skills could be a column in the
        /// source data set, or the output of an upstream skill.</param>
        /// <param name="outputs">The output of a skill is either a field in an
        /// Azure Search index, or a value that can be consumed as an input by
        /// another skill.</param>
        /// <param name="description">The description of the skill which
        /// describes the inputs, outputs, and usage of the skill.</param>
        /// <param name="context">Represents the level at which operations take
        /// place, such as the document root or document content (for example,
        /// /document or /document/content). The default is /document.</param>
        /// <param name="defaultLanguageCode">A value indicating which language
        /// code to use. Default is en. Possible values include: 'en',
        /// 'zh'</param>
        /// <param name="visualFeatures">A list of visual features.</param>
        /// <param name="details">A string indicating which domain-specific
        /// details to return.</param>
        public ImageAnalysisSkill(IList<InputFieldMappingEntry> inputs, IList<OutputFieldMappingEntry> outputs, string description = default(string), string context = default(string), ImageAnalysisSkillLanguage? defaultLanguageCode = default(ImageAnalysisSkillLanguage?), IList<VisualFeature> visualFeatures = default(IList<VisualFeature>), IList<ImageDetail> details = default(IList<ImageDetail>))
            : base(inputs, outputs, description, context)
        {
            DefaultLanguageCode = defaultLanguageCode;
            VisualFeatures = visualFeatures;
            Details = details;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a value indicating which language code to use. Default
        /// is en. Possible values include: 'en', 'zh'
        /// </summary>
        [JsonProperty(PropertyName = "defaultLanguageCode")]
        public ImageAnalysisSkillLanguage? DefaultLanguageCode { get; set; }

        /// <summary>
        /// Gets or sets a list of visual features.
        /// </summary>
        [JsonProperty(PropertyName = "visualFeatures")]
        public IList<VisualFeature> VisualFeatures { get; set; }

        /// <summary>
        /// Gets or sets a string indicating which domain-specific details to
        /// return.
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public IList<ImageDetail> Details { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
