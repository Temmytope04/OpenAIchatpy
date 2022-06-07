// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Validation result for configuration service settings. </summary>
    public partial class ConfigurationServiceSettingsValidateResult
    {
        /// <summary> Initializes a new instance of ConfigurationServiceSettingsValidateResult. </summary>
        internal ConfigurationServiceSettingsValidateResult()
        {
        }

        /// <summary> Initializes a new instance of ConfigurationServiceSettingsValidateResult. </summary>
        /// <param name="gitPropertyValidationResult"> Validation result for configuration service settings. </param>
        internal ConfigurationServiceSettingsValidateResult(ConfigurationServiceGitPropertyValidateResult gitPropertyValidationResult)
        {
            GitPropertyValidationResult = gitPropertyValidationResult;
        }

        /// <summary> Validation result for configuration service settings. </summary>
        public ConfigurationServiceGitPropertyValidateResult GitPropertyValidationResult { get; }
    }
}
