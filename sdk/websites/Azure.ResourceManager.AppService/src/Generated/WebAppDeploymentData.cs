// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing the WebAppDeployment data model.
    /// User credentials used for publishing activity.
    /// </summary>
    public partial class WebAppDeploymentData : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="WebAppDeploymentData"/>. </summary>
        public WebAppDeploymentData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="WebAppDeploymentData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="status"> Deployment status. </param>
        /// <param name="message"> Details about deployment status. </param>
        /// <param name="author"> Who authored the deployment. </param>
        /// <param name="deployer"> Who performed the deployment. </param>
        /// <param name="authorEmail"> Author email. </param>
        /// <param name="startOn"> Start time. </param>
        /// <param name="endOn"> End time. </param>
        /// <param name="isActive"> True if deployment is currently active, false if completed and null if not started. </param>
        /// <param name="details"> Details on deployment. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal WebAppDeploymentData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, int? status, string message, string author, string deployer, string authorEmail, DateTimeOffset? startOn, DateTimeOffset? endOn, bool? isActive, string details, string kind, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Status = status;
            Message = message;
            Author = author;
            Deployer = deployer;
            AuthorEmail = authorEmail;
            StartOn = startOn;
            EndOn = endOn;
            IsActive = isActive;
            Details = details;
            Kind = kind;
            _rawData = rawData;
        }

        /// <summary> Deployment status. </summary>
        public int? Status { get; set; }
        /// <summary> Details about deployment status. </summary>
        public string Message { get; set; }
        /// <summary> Who authored the deployment. </summary>
        public string Author { get; set; }
        /// <summary> Who performed the deployment. </summary>
        public string Deployer { get; set; }
        /// <summary> Author email. </summary>
        public string AuthorEmail { get; set; }
        /// <summary> Start time. </summary>
        public DateTimeOffset? StartOn { get; set; }
        /// <summary> End time. </summary>
        public DateTimeOffset? EndOn { get; set; }
        /// <summary> True if deployment is currently active, false if completed and null if not started. </summary>
        public bool? IsActive { get; set; }
        /// <summary> Details on deployment. </summary>
        public string Details { get; set; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
