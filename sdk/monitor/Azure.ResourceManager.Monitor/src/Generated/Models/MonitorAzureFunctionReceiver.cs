// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> An azure function receiver. </summary>
    public partial class MonitorAzureFunctionReceiver
    {
        /// <summary> Initializes a new instance of MonitorAzureFunctionReceiver. </summary>
        /// <param name="name"> The name of the azure function receiver. Names must be unique across all receivers within an action group. </param>
        /// <param name="functionAppResourceId"> The azure resource id of the function app. </param>
        /// <param name="functionName"> The function name in the function app. </param>
        /// <param name="httpTriggerUri"> The http trigger url where http request sent to. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="functionAppResourceId"/>, <paramref name="functionName"/> or <paramref name="httpTriggerUri"/> is null. </exception>
        public MonitorAzureFunctionReceiver(string name, ResourceIdentifier functionAppResourceId, string functionName, Uri httpTriggerUri)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (functionAppResourceId == null)
            {
                throw new ArgumentNullException(nameof(functionAppResourceId));
            }
            if (functionName == null)
            {
                throw new ArgumentNullException(nameof(functionName));
            }
            if (httpTriggerUri == null)
            {
                throw new ArgumentNullException(nameof(httpTriggerUri));
            }

            Name = name;
            FunctionAppResourceId = functionAppResourceId;
            FunctionName = functionName;
            HttpTriggerUri = httpTriggerUri;
        }

        /// <summary> Initializes a new instance of MonitorAzureFunctionReceiver. </summary>
        /// <param name="name"> The name of the azure function receiver. Names must be unique across all receivers within an action group. </param>
        /// <param name="functionAppResourceId"> The azure resource id of the function app. </param>
        /// <param name="functionName"> The function name in the function app. </param>
        /// <param name="httpTriggerUri"> The http trigger url where http request sent to. </param>
        /// <param name="useCommonAlertSchema"> Indicates whether to use common alert schema. </param>
        internal MonitorAzureFunctionReceiver(string name, ResourceIdentifier functionAppResourceId, string functionName, Uri httpTriggerUri, bool? useCommonAlertSchema)
        {
            Name = name;
            FunctionAppResourceId = functionAppResourceId;
            FunctionName = functionName;
            HttpTriggerUri = httpTriggerUri;
            UseCommonAlertSchema = useCommonAlertSchema;
        }

        /// <summary> The name of the azure function receiver. Names must be unique across all receivers within an action group. </summary>
        public string Name { get; set; }
        /// <summary> The azure resource id of the function app. </summary>
        public ResourceIdentifier FunctionAppResourceId { get; set; }
        /// <summary> The function name in the function app. </summary>
        public string FunctionName { get; set; }
        /// <summary> The http trigger url where http request sent to. </summary>
        public Uri HttpTriggerUri { get; set; }
        /// <summary> Indicates whether to use common alert schema. </summary>
        public bool? UseCommonAlertSchema { get; set; }
    }
}
