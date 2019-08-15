﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Azure.Messaging.ServiceBus.Amqp
{
    using Microsoft.Azure.Amqp;
    using System;

    internal abstract class ActiveClientLinkObject
    {
        private readonly string[] requiredClaims;

        protected ActiveClientLinkObject(AmqpObject amqpLinkObject,  Uri endpointUri, string[] audience, string[] requiredClaims, DateTime authorizationValidUntilUtc)
        {
            this.LinkObject = amqpLinkObject;
            this.EndpointUri = endpointUri;
            this.Audience = audience;
            this.requiredClaims = requiredClaims;
            this.AuthorizationValidUntilUtc = authorizationValidUntilUtc;
        }

        public AmqpObject LinkObject { get; }

        public string[] Audience { get; }

        public Uri EndpointUri { get; }

        public string[] RequiredClaims => (string[])this.requiredClaims.Clone();

        public DateTime AuthorizationValidUntilUtc { get; set; }

        public abstract AmqpConnection Connection { get; }
    }
}
