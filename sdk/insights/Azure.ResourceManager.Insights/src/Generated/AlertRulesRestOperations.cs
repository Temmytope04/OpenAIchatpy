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
using Azure.ResourceManager.Insights.Models;

namespace Azure.ResourceManager.Insights
{
    internal partial class AlertRulesRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of AlertRulesRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The Azure subscription Id. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        public AlertRulesRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            endpoint ??= new Uri("https://management.azure.com");

            this.subscriptionId = subscriptionId;
            this.endpoint = endpoint;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string resourceGroupName, string ruleName, AlertRuleResource parameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourcegroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/microsoft.insights/alertrules/", false);
            uri.AppendPath(ruleName, true);
            uri.AppendQuery("api-version", "2016-03-01", true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(parameters);
            request.Content = content;
            return message;
        }

        /// <summary> Creates or updates a classic metric alert rule. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="parameters"> The parameters of the rule to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="ruleName"/>, or <paramref name="parameters"/> is null. </exception>
        public async Task<Response<AlertRuleResource>> CreateOrUpdateAsync(string resourceGroupName, string ruleName, AlertRuleResource parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (ruleName == null)
            {
                throw new ArgumentNullException(nameof(ruleName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, ruleName, parameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        AlertRuleResource value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AlertRuleResource.DeserializeAlertRuleResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Creates or updates a classic metric alert rule. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="parameters"> The parameters of the rule to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="ruleName"/>, or <paramref name="parameters"/> is null. </exception>
        public Response<AlertRuleResource> CreateOrUpdate(string resourceGroupName, string ruleName, AlertRuleResource parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (ruleName == null)
            {
                throw new ArgumentNullException(nameof(ruleName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, ruleName, parameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        AlertRuleResource value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AlertRuleResource.DeserializeAlertRuleResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string resourceGroupName, string ruleName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourcegroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/microsoft.insights/alertrules/", false);
            uri.AppendPath(ruleName, true);
            uri.AppendQuery("api-version", "2016-03-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Deletes a classic metric alert rule. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="ruleName"/> is null. </exception>
        public async Task<Response> DeleteAsync(string resourceGroupName, string ruleName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (ruleName == null)
            {
                throw new ArgumentNullException(nameof(ruleName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, ruleName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Deletes a classic metric alert rule. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="ruleName"/> is null. </exception>
        public Response Delete(string resourceGroupName, string ruleName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (ruleName == null)
            {
                throw new ArgumentNullException(nameof(ruleName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, ruleName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string resourceGroupName, string ruleName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourcegroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/microsoft.insights/alertrules/", false);
            uri.AppendPath(ruleName, true);
            uri.AppendQuery("api-version", "2016-03-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Gets a classic metric alert rule. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="ruleName"/> is null. </exception>
        public async Task<Response<AlertRuleResource>> GetAsync(string resourceGroupName, string ruleName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (ruleName == null)
            {
                throw new ArgumentNullException(nameof(ruleName));
            }

            using var message = CreateGetRequest(resourceGroupName, ruleName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AlertRuleResource value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AlertRuleResource.DeserializeAlertRuleResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets a classic metric alert rule. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="ruleName"/> is null. </exception>
        public Response<AlertRuleResource> Get(string resourceGroupName, string ruleName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (ruleName == null)
            {
                throw new ArgumentNullException(nameof(ruleName));
            }

            using var message = CreateGetRequest(resourceGroupName, ruleName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AlertRuleResource value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AlertRuleResource.DeserializeAlertRuleResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateRequest(string resourceGroupName, string ruleName, AlertRuleResourcePatch alertRulesResource)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourcegroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/microsoft.insights/alertrules/", false);
            uri.AppendPath(ruleName, true);
            uri.AppendQuery("api-version", "2016-03-01", true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(alertRulesResource);
            request.Content = content;
            return message;
        }

        /// <summary> Updates an existing classic metric AlertRuleResource. To update other fields use the CreateOrUpdate method. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="alertRulesResource"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="ruleName"/>, or <paramref name="alertRulesResource"/> is null. </exception>
        public async Task<Response<AlertRuleResource>> UpdateAsync(string resourceGroupName, string ruleName, AlertRuleResourcePatch alertRulesResource, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (ruleName == null)
            {
                throw new ArgumentNullException(nameof(ruleName));
            }
            if (alertRulesResource == null)
            {
                throw new ArgumentNullException(nameof(alertRulesResource));
            }

            using var message = CreateUpdateRequest(resourceGroupName, ruleName, alertRulesResource);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        AlertRuleResource value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AlertRuleResource.DeserializeAlertRuleResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Updates an existing classic metric AlertRuleResource. To update other fields use the CreateOrUpdate method. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="alertRulesResource"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="ruleName"/>, or <paramref name="alertRulesResource"/> is null. </exception>
        public Response<AlertRuleResource> Update(string resourceGroupName, string ruleName, AlertRuleResourcePatch alertRulesResource, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (ruleName == null)
            {
                throw new ArgumentNullException(nameof(ruleName));
            }
            if (alertRulesResource == null)
            {
                throw new ArgumentNullException(nameof(alertRulesResource));
            }

            using var message = CreateUpdateRequest(resourceGroupName, ruleName, alertRulesResource);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        AlertRuleResource value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AlertRuleResource.DeserializeAlertRuleResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByResourceGroupRequest(string resourceGroupName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourcegroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/microsoft.insights/alertrules", false);
            uri.AppendQuery("api-version", "2016-03-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> List the classic metric alert rules within a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public async Task<Response<AlertRuleResourceCollection>> ListByResourceGroupAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var message = CreateListByResourceGroupRequest(resourceGroupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AlertRuleResourceCollection value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AlertRuleResourceCollection.DeserializeAlertRuleResourceCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> List the classic metric alert rules within a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public Response<AlertRuleResourceCollection> ListByResourceGroup(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var message = CreateListByResourceGroupRequest(resourceGroupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AlertRuleResourceCollection value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AlertRuleResourceCollection.DeserializeAlertRuleResourceCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListBySubscriptionRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/microsoft.insights/alertrules", false);
            uri.AppendQuery("api-version", "2016-03-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> List the classic metric alert rules within a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<AlertRuleResourceCollection>> ListBySubscriptionAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateListBySubscriptionRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AlertRuleResourceCollection value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AlertRuleResourceCollection.DeserializeAlertRuleResourceCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> List the classic metric alert rules within a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<AlertRuleResourceCollection> ListBySubscription(CancellationToken cancellationToken = default)
        {
            using var message = CreateListBySubscriptionRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AlertRuleResourceCollection value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AlertRuleResourceCollection.DeserializeAlertRuleResourceCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
