﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.AI.MetricsAdvisor.Models;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Administration
{
    /// <summary>
    /// An alert notification to be triggered after an anomaly is detected by Metrics Advisor.
    /// </summary>
    [CodeGenModel("HookInfo")]
    public abstract partial class NotificationHook
    {
        internal NotificationHook(string name)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            Name = name;
            Administrators = new ChangeTrackingList<string>();
        }

        internal NotificationHook(NotificationHookKind hookType, string id, string name, string description, string internalExternalLink, IList<string> administrators)
        {
            HookKind = hookType;
            Id = id;
            Name = name;
            Description = description;
            ExternalUri = string.IsNullOrEmpty(internalExternalLink) ? null : new Uri(internalExternalLink);
            Administrators = administrators;
        }

        /// <summary>
        /// The unique identifier for the hook.
        /// </summary>
        [CodeGenMember("HookId")]
        public string Id { get; }

        /// <summary>
        /// The name of the hook.
        /// </summary>
        [CodeGenMember("HookName")]
        public string Name { get; set; }

        /// <summary>
        /// The list of users with administrative rights to manage this hook. Each element in this list represents a user with
        /// administrator access, but the value of each <c>string</c> element depends on the type of authentication to be used by
        /// this administrator when communicating with the service. If <see cref="MetricsAdvisorKeyCredential"/> authentication will
        /// be used, the <c>string</c> must be the user's email address. If AAD authentication will be used instead, the <c>string</c>
        /// must uniquely identify the user's principal. For instance, for a <c>ClientSecretCredential</c>, the <c>string</c> must be
        /// the client ID.
        /// </summary>
        [CodeGenMember("Admins")]
        public IList<string> Administrators { get; }

        /// <summary>
        /// The hook kind.
        /// </summary>
        [CodeGenMember("HookType")]
        public NotificationHookKind HookKind { get; internal set; }

        /// <summary>
        /// The hook description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Optional field which enables a customized redirect, such as for troubleshooting notes.
        /// </summary>
        public Uri ExternalUri { get; set; }

        /// <summary>
        /// Used by CodeGen during serialization.
        /// </summary>
        [CodeGenMember("ExternalLink")]
        internal string InternalExternalLink => ExternalUri?.AbsoluteUri;

        internal static HookInfoPatch GetPatchModel(NotificationHook hook)
        {
            HookInfoPatch patch = hook switch
            {
                EmailNotificationHook h => new EmailHookInfoPatch()
                {
                    HookParameter = new() { ToList = h.EmailsToAlert }
                },
                WebNotificationHook h => new WebhookHookInfoPatch()
                {
                    HookParameter = new()
                    {
                        Endpoint = h.Endpoint?.AbsoluteUri,
                        Username = h.Username,
                        Password = h.Password,
                        CertificateKey = h.CertificateKey,
                        CertificatePassword = h.CertificatePassword,
                        Headers = h.Headers
                    }
                },
                _ => new HookInfoPatch()
            };

            patch.HookType = hook.HookKind;
            patch.HookName = hook.Name;
            patch.Description = hook.Description;
            patch.ExternalLink = hook.ExternalUri?.AbsoluteUri;
            patch.Admins = hook.Administrators;

            return patch;
        }

        internal static NotificationHook DeserializeNotificationHook(JsonElement element)
        {
            if (element.TryGetProperty("hookType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Email":
                        return EmailNotificationHook.DeserializeEmailNotificationHook(element);
                    case "Webhook":
                        return WebNotificationHook.DeserializeWebNotificationHook(element);
                }
            }
            NotificationHookKind hookType = default;
            Optional<string> hookId = default;
            string hookName = default;
            Optional<string> description = default;
            Optional<string> externalLink = default;
            Optional<IList<string>> admins = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hookType"))
                {
                    hookType = new NotificationHookKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("hookId"))
                {
                    hookId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hookName"))
                {
                    hookName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("externalLink"))
                {
                    externalLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("admins"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    admins = array;
                    continue;
                }
            }
            return new UnknownNotificationHook(hookType, hookId.Value, hookName, description.Value, externalLink.Value, Optional.ToList(admins));
        }

        private class UnknownNotificationHook : NotificationHook
        {
            public UnknownNotificationHook(NotificationHookKind hookType, string id, string name, string description, string internalExternalLink, IList<string> administrators)
                : base(hookType, id, name, description, internalExternalLink, administrators)
            {
            }
        }
    }
}
