// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Deployment What-if properties. </summary>
    public partial class ArmDeploymentWhatIfProperties : ArmDeploymentProperties
    {
        /// <summary> Initializes a new instance of <see cref="ArmDeploymentWhatIfProperties"/>. </summary>
        /// <param name="mode"> The mode that is used to deploy resources. This value can be either Incremental or Complete. In Incremental mode, resources are deployed without deleting existing resources that are not included in the template. In Complete mode, resources are deployed and existing resources in the resource group that are not included in the template are deleted. Be careful when using Complete mode as you may unintentionally delete resources. </param>
        public ArmDeploymentWhatIfProperties(ArmDeploymentMode mode) : base(mode)
        {
        }

        /// <summary> Initializes a new instance of <see cref="ArmDeploymentWhatIfProperties"/>. </summary>
        /// <param name="template"> The template content. You use this element when you want to pass the template syntax directly in the request rather than link to an existing template. It can be a JObject or well-formed JSON string. Use either the templateLink property or the template property, but not both. </param>
        /// <param name="templateLink"> The URI of the template. Use either the templateLink property or the template property, but not both. </param>
        /// <param name="parameters"> Name and value pairs that define the deployment parameters for the template. You use this element when you want to provide the parameter values directly in the request rather than link to an existing parameter file. Use either the parametersLink property or the parameters property, but not both. It can be a JObject or a well formed JSON string. </param>
        /// <param name="parametersLink"> The URI of parameters file. You use this element to link to an existing parameters file. Use either the parametersLink property or the parameters property, but not both. </param>
        /// <param name="mode"> The mode that is used to deploy resources. This value can be either Incremental or Complete. In Incremental mode, resources are deployed without deleting existing resources that are not included in the template. In Complete mode, resources are deployed and existing resources in the resource group that are not included in the template are deleted. Be careful when using Complete mode as you may unintentionally delete resources. </param>
        /// <param name="debugSetting"> The debug setting of the deployment. </param>
        /// <param name="errorDeployment"> The deployment on error behavior. </param>
        /// <param name="expressionEvaluation"> Specifies whether template expressions are evaluated within the scope of the parent template or nested template. Only applicable to nested templates. If not specified, default value is outer. </param>
        /// <param name="whatIfSettings"> Optional What-If operation settings. </param>
        internal ArmDeploymentWhatIfProperties(BinaryData template, ArmDeploymentTemplateLink templateLink, BinaryData parameters, ArmDeploymentParametersLink parametersLink, ArmDeploymentMode mode, DebugSetting debugSetting, ErrorDeployment errorDeployment, ExpressionEvaluationOptions expressionEvaluation, ArmDeploymentWhatIfSettings whatIfSettings) : base(template, templateLink, parameters, parametersLink, mode, debugSetting, errorDeployment, expressionEvaluation)
        {
            WhatIfSettings = whatIfSettings;
        }

        /// <summary> Optional What-If operation settings. </summary>
        internal ArmDeploymentWhatIfSettings WhatIfSettings { get; set; }
        /// <summary> The format of the What-If results. </summary>
        public WhatIfResultFormat? WhatIfResultFormat
        {
            get => WhatIfSettings is null ? default : WhatIfSettings.ResultFormat;
            set
            {
                if (WhatIfSettings is null)
                    WhatIfSettings = new ArmDeploymentWhatIfSettings();
                WhatIfSettings.ResultFormat = value;
            }
        }
    }
}
