﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Azure.Messaging.ServiceBus.Amqp
{
    using System;
    using Microsoft.Azure.Amqp;
    using Azure.Messaging.ServiceBus.Primitives;

    internal class AmqpRequestResponseLinkCreator : AmqpLinkCreator
    {
        private readonly string entityPath;

        public AmqpRequestResponseLinkCreator(string entityPath, ServiceBusConnection serviceBusConnection, Uri endpointAddress, string[] audience, string[] requiredClaims, AmqpLinkSettings linkSettings, string clientId)
            : base(entityPath, serviceBusConnection, endpointAddress, audience, requiredClaims, linkSettings, clientId)
        {
            this.entityPath = entityPath;
        }

        protected override AmqpObject OnCreateAmqpLink(AmqpConnection connection, AmqpLinkSettings linkSettings, AmqpSession amqpSession)
        {
            AmqpObject link = new RequestResponseAmqpLink(AmqpClientConstants.EntityTypeManagement, amqpSession, this.entityPath, linkSettings.Properties);
            linkSettings.LinkName = $"{connection.Settings.ContainerId};{connection.Identifier}:{amqpSession.Identifier}:{link.Identifier}:{this.ClientId}";
            return link;
        }
    }
}