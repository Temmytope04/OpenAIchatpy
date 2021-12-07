// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the WebSiteInstanceStatus data model. </summary>
    public partial class WebSiteInstanceStatusData : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of WebSiteInstanceStatusData. </summary>
        public WebSiteInstanceStatusData()
        {
            Containers = new ChangeTrackingDictionary<string, ContainerInfo>();
        }

        /// <summary> Initializes a new instance of WebSiteInstanceStatusData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="state"></param>
        /// <param name="statusUrl"> Link to the GetStatusApi in Kudu. </param>
        /// <param name="detectorUrl"> Link to the Diagnose and Solve Portal. </param>
        /// <param name="consoleUrl"> Link to the console to web app instance. </param>
        /// <param name="healthCheckUrl"> Link to the console to web app instance. </param>
        /// <param name="containers"> Dictionary of &lt;ContainerInfo&gt;. </param>
        internal WebSiteInstanceStatusData(ResourceIdentifier id, string name, ResourceType type, string kind, SiteRuntimeState? state, string statusUrl, string detectorUrl, string consoleUrl, string healthCheckUrl, IDictionary<string, ContainerInfo> containers) : base(id, name, type, kind)
        {
            State = state;
            StatusUrl = statusUrl;
            DetectorUrl = detectorUrl;
            ConsoleUrl = consoleUrl;
            HealthCheckUrl = healthCheckUrl;
            Containers = containers;
        }

        /// <summary> Gets or sets the state. </summary>
        public SiteRuntimeState? State { get; set; }
        /// <summary> Link to the GetStatusApi in Kudu. </summary>
        public string StatusUrl { get; set; }
        /// <summary> Link to the Diagnose and Solve Portal. </summary>
        public string DetectorUrl { get; set; }
        /// <summary> Link to the console to web app instance. </summary>
        public string ConsoleUrl { get; set; }
        /// <summary> Link to the console to web app instance. </summary>
        public string HealthCheckUrl { get; set; }
        /// <summary> Dictionary of &lt;ContainerInfo&gt;. </summary>
        public IDictionary<string, ContainerInfo> Containers { get; }
    }
}
