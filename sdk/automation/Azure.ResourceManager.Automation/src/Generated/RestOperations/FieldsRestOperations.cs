// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Automation.Models;

namespace Azure.ResourceManager.Automation
{
    internal partial class FieldsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of FieldsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public FieldsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2020-01-13-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListByTypeRequest(string subscriptionId, string resourceGroupName, string automationAccountName, string moduleName, string typeName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Automation/automationAccounts/", false);
            uri.AppendPath(automationAccountName, true);
            uri.AppendPath("/modules/", false);
            uri.AppendPath(moduleName, true);
            uri.AppendPath("/types/", false);
            uri.AppendPath(typeName, true);
            uri.AppendPath("/fields", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Retrieve a list of fields of a given type identified by module name. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of an Azure Resource group. </param>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="moduleName"> The name of module. </param>
        /// <param name="typeName"> The name of type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/>, <paramref name="moduleName"/> or <paramref name="typeName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/>, <paramref name="moduleName"/> or <paramref name="typeName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AutomationModuleFieldListResult>> ListByTypeAsync(string subscriptionId, string resourceGroupName, string automationAccountName, string moduleName, string typeName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (automationAccountName == null)
            {
                throw new ArgumentNullException(nameof(automationAccountName));
            }
            if (automationAccountName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(automationAccountName));
            }
            if (moduleName == null)
            {
                throw new ArgumentNullException(nameof(moduleName));
            }
            if (moduleName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(moduleName));
            }
            if (typeName == null)
            {
                throw new ArgumentNullException(nameof(typeName));
            }
            if (typeName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(typeName));
            }

            using var message = CreateListByTypeRequest(subscriptionId, resourceGroupName, automationAccountName, moduleName, typeName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AutomationModuleFieldListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AutomationModuleFieldListResult.DeserializeAutomationModuleFieldListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Retrieve a list of fields of a given type identified by module name. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of an Azure Resource group. </param>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="moduleName"> The name of module. </param>
        /// <param name="typeName"> The name of type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/>, <paramref name="moduleName"/> or <paramref name="typeName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/>, <paramref name="moduleName"/> or <paramref name="typeName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AutomationModuleFieldListResult> ListByType(string subscriptionId, string resourceGroupName, string automationAccountName, string moduleName, string typeName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (automationAccountName == null)
            {
                throw new ArgumentNullException(nameof(automationAccountName));
            }
            if (automationAccountName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(automationAccountName));
            }
            if (moduleName == null)
            {
                throw new ArgumentNullException(nameof(moduleName));
            }
            if (moduleName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(moduleName));
            }
            if (typeName == null)
            {
                throw new ArgumentNullException(nameof(typeName));
            }
            if (typeName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(typeName));
            }

            using var message = CreateListByTypeRequest(subscriptionId, resourceGroupName, automationAccountName, moduleName, typeName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AutomationModuleFieldListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AutomationModuleFieldListResult.DeserializeAutomationModuleFieldListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
