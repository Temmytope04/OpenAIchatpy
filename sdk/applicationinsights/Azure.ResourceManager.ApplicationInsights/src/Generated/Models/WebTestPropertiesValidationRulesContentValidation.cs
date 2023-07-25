// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> The collection of content validation properties. </summary>
    public partial class WebTestPropertiesValidationRulesContentValidation
    {
        /// <summary> Initializes a new instance of WebTestPropertiesValidationRulesContentValidation. </summary>
        public WebTestPropertiesValidationRulesContentValidation()
        {
        }

        /// <summary> Initializes a new instance of WebTestPropertiesValidationRulesContentValidation. </summary>
        /// <param name="contentMatch"> Content to look for in the return of the WebTest.  Must not be null or empty. </param>
        /// <param name="ignoreCase"> When set, this value makes the ContentMatch validation case insensitive. </param>
        /// <param name="passIfTextFound"> When true, validation will pass if there is a match for the ContentMatch string.  If false, validation will fail if there is a match. </param>
        internal WebTestPropertiesValidationRulesContentValidation(string contentMatch, bool? ignoreCase, bool? passIfTextFound)
        {
            ContentMatch = contentMatch;
            IgnoreCase = ignoreCase;
            PassIfTextFound = passIfTextFound;
        }

        /// <summary> Content to look for in the return of the WebTest.  Must not be null or empty. </summary>
        public string ContentMatch { get; set; }
        /// <summary> When set, this value makes the ContentMatch validation case insensitive. </summary>
        public bool? IgnoreCase { get; set; }
        /// <summary> When true, validation will pass if there is a match for the ContentMatch string.  If false, validation will fail if there is a match. </summary>
        public bool? PassIfTextFound { get; set; }
    }
}
