// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.AppService;
    using Microsoft.Azure.Management.AppService.Fluent;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Information needed for cloning operation.
    /// </summary>
    public partial class CloningInfo
    {
        /// <summary>
        /// Initializes a new instance of the CloningInfo class.
        /// </summary>
        public CloningInfo()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CloningInfo class.
        /// </summary>
        /// <param name="sourceWebAppId">ARM resource ID of the source app. App
        /// resource ID is of the form
        /// /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}
        /// for production slots and
        /// /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slotName}
        /// for other slots.</param>
        /// <param name="correlationId">Correlation ID of cloning operation.
        /// This ID ties multiple cloning operations
        /// together to use the same snapshot.</param>
        /// <param name="overwrite">&lt;code&gt;true&lt;/code&gt; to overwrite
        /// destination app; otherwise, &lt;code&gt;false&lt;/code&gt;.</param>
        /// <param name="cloneCustomHostNames">&lt;code&gt;true&lt;/code&gt; to
        /// clone custom hostnames from source app; otherwise,
        /// &lt;code&gt;false&lt;/code&gt;.</param>
        /// <param name="cloneSourceControl">&lt;code&gt;true&lt;/code&gt; to
        /// clone source control from source app; otherwise,
        /// &lt;code&gt;false&lt;/code&gt;.</param>
        /// <param name="hostingEnvironment">App Service Environment.</param>
        /// <param name="appSettingsOverrides">Application setting overrides
        /// for cloned app. If specified, these settings override the settings
        /// cloned
        /// from source app. Otherwise, application settings from source app
        /// are retained.</param>
        /// <param name="configureLoadBalancing">&lt;code&gt;true&lt;/code&gt;
        /// to configure load balancing for source and destination app.</param>
        /// <param name="trafficManagerProfileId">ARM resource ID of the
        /// Traffic Manager profile to use, if it exists. Traffic Manager
        /// resource ID is of the form
        /// /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficManagerProfiles/{profileName}.</param>
        /// <param name="trafficManagerProfileName">Name of Traffic Manager
        /// profile to create. This is only needed if Traffic Manager profile
        /// does not already exist.</param>
        /// <param name="ignoreQuotas">&lt;code&gt;true&lt;/code&gt; if quotas
        /// should be ignored; otherwise,
        /// &lt;code&gt;false&lt;/code&gt;.</param>
        public CloningInfo(string sourceWebAppId, string correlationId = default(string), bool? overwrite = default(bool?), bool? cloneCustomHostNames = default(bool?), bool? cloneSourceControl = default(bool?), string hostingEnvironment = default(string), IDictionary<string, string> appSettingsOverrides = default(IDictionary<string, string>), bool? configureLoadBalancing = default(bool?), string trafficManagerProfileId = default(string), string trafficManagerProfileName = default(string), bool? ignoreQuotas = default(bool?))
        {
            CorrelationId = correlationId;
            Overwrite = overwrite;
            CloneCustomHostNames = cloneCustomHostNames;
            CloneSourceControl = cloneSourceControl;
            SourceWebAppId = sourceWebAppId;
            HostingEnvironment = hostingEnvironment;
            AppSettingsOverrides = appSettingsOverrides;
            ConfigureLoadBalancing = configureLoadBalancing;
            TrafficManagerProfileId = trafficManagerProfileId;
            TrafficManagerProfileName = trafficManagerProfileName;
            IgnoreQuotas = ignoreQuotas;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets correlation ID of cloning operation. This ID ties
        /// multiple cloning operations
        /// together to use the same snapshot.
        /// </summary>
        [JsonProperty(PropertyName = "correlationId")]
        public string CorrelationId { get; set; }

        /// <summary>
        /// Gets or sets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; to
        /// overwrite destination app; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "overwrite")]
        public bool? Overwrite { get; set; }

        /// <summary>
        /// Gets or sets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; to clone
        /// custom hostnames from source app; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "cloneCustomHostNames")]
        public bool? CloneCustomHostNames { get; set; }

        /// <summary>
        /// Gets or sets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; to clone
        /// source control from source app; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "cloneSourceControl")]
        public bool? CloneSourceControl { get; set; }

        /// <summary>
        /// Gets or sets ARM resource ID of the source app. App resource ID is
        /// of the form
        /// /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}
        /// for production slots and
        /// /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slotName}
        /// for other slots.
        /// </summary>
        [JsonProperty(PropertyName = "sourceWebAppId")]
        public string SourceWebAppId { get; set; }

        /// <summary>
        /// Gets or sets app Service Environment.
        /// </summary>
        [JsonProperty(PropertyName = "hostingEnvironment")]
        public string HostingEnvironment { get; set; }

        /// <summary>
        /// Gets or sets application setting overrides for cloned app. If
        /// specified, these settings override the settings cloned
        /// from source app. Otherwise, application settings from source app
        /// are retained.
        /// </summary>
        [JsonProperty(PropertyName = "appSettingsOverrides")]
        public IDictionary<string, string> AppSettingsOverrides { get; set; }

        /// <summary>
        /// Gets or sets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; to
        /// configure load balancing for source and destination app.
        /// </summary>
        [JsonProperty(PropertyName = "configureLoadBalancing")]
        public bool? ConfigureLoadBalancing { get; set; }

        /// <summary>
        /// Gets or sets ARM resource ID of the Traffic Manager profile to use,
        /// if it exists. Traffic Manager resource ID is of the form
        /// /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficManagerProfiles/{profileName}.
        /// </summary>
        [JsonProperty(PropertyName = "trafficManagerProfileId")]
        public string TrafficManagerProfileId { get; set; }

        /// <summary>
        /// Gets or sets name of Traffic Manager profile to create. This is
        /// only needed if Traffic Manager profile does not already exist.
        /// </summary>
        [JsonProperty(PropertyName = "trafficManagerProfileName")]
        public string TrafficManagerProfileName { get; set; }

        /// <summary>
        /// Gets or sets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; if
        /// quotas should be ignored; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "ignoreQuotas")]
        public bool? IgnoreQuotas { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SourceWebAppId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SourceWebAppId");
            }
        }
    }
}
