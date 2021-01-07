// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Storage.Queues.Models;

namespace Azure.Storage.Queues
{
    internal partial class MessagesRestClient
    {
        private string url;
        private string version;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of MessagesRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="url"> The URL of the service account, queue or message that is the targe of the desired operation. </param>
        /// <param name="version"> Specifies the version of the operation to use for this request. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="url"/> or <paramref name="version"/> is null. </exception>
        public MessagesRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string url, string version = "2018-03-28")
        {
            if (url == null)
            {
                throw new ArgumentNullException(nameof(url));
            }
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            this.url = url;
            this.version = version;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateDequeueRequest(string queueName, int? numberOfMessages, int? visibilitytimeout, int? timeout)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(url, false);
            uri.AppendPath("/", false);
            uri.AppendPath(queueName, true);
            uri.AppendPath("/messages", false);
            if (numberOfMessages != null)
            {
                uri.AppendQuery("numofmessages", numberOfMessages.Value, true);
            }
            if (visibilitytimeout != null)
            {
                uri.AppendQuery("visibilitytimeout", visibilitytimeout.Value, true);
            }
            if (timeout != null)
            {
                uri.AppendQuery("timeout", timeout.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("x-ms-version", version);
            request.Headers.Add("Accept", "application/xml");
            return message;
        }

        /// <summary> The Dequeue operation retrieves one or more messages from the front of the queue. </summary>
        /// <param name="queueName"> The queue name. </param>
        /// <param name="numberOfMessages"> Optional. A nonzero integer value that specifies the number of messages to retrieve from the queue, up to a maximum of 32. If fewer are visible, the visible messages are returned. By default, a single message is retrieved from the queue with this operation. </param>
        /// <param name="visibilitytimeout"> Optional. Specifies the new visibility timeout value, in seconds, relative to server time. The default value is 30 seconds. A specified value must be larger than or equal to 1 second, and cannot be larger than 7 days, or larger than 2 hours on REST protocol versions prior to version 2011-08-18. The visibility timeout of a message can be set to a value later than the expiry time. </param>
        /// <param name="timeout"> The The timeout parameter is expressed in seconds. For more information, see &lt;a href=&quot;https://docs.microsoft.com/en-us/rest/api/storageservices/setting-timeouts-for-queue-service-operations&gt;Setting Timeouts for Queue Service Operations.&lt;/a&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="queueName"/> is null. </exception>
        public async Task<ResponseWithHeaders<IReadOnlyList<DequeuedMessageItem>, MessagesDequeueHeaders>> DequeueAsync(string queueName, int? numberOfMessages = null, int? visibilitytimeout = null, int? timeout = null, CancellationToken cancellationToken = default)
        {
            if (queueName == null)
            {
                throw new ArgumentNullException(nameof(queueName));
            }

            using var message = CreateDequeueRequest(queueName, numberOfMessages, visibilitytimeout, timeout);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new MessagesDequeueHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<DequeuedMessageItem> value = default;
                        var document = XDocument.Load(message.Response.ContentStream, LoadOptions.PreserveWhitespace);
                        if (document.Element("QueueMessagesList") is XElement queueMessagesListElement)
                        {
                            var array = new List<DequeuedMessageItem>();
                            foreach (var e in queueMessagesListElement.Elements("QueueMessage"))
                            {
                                array.Add(DequeuedMessageItem.DeserializeDequeuedMessageItem(e));
                            }
                            value = array;
                        }
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> The Dequeue operation retrieves one or more messages from the front of the queue. </summary>
        /// <param name="queueName"> The queue name. </param>
        /// <param name="numberOfMessages"> Optional. A nonzero integer value that specifies the number of messages to retrieve from the queue, up to a maximum of 32. If fewer are visible, the visible messages are returned. By default, a single message is retrieved from the queue with this operation. </param>
        /// <param name="visibilitytimeout"> Optional. Specifies the new visibility timeout value, in seconds, relative to server time. The default value is 30 seconds. A specified value must be larger than or equal to 1 second, and cannot be larger than 7 days, or larger than 2 hours on REST protocol versions prior to version 2011-08-18. The visibility timeout of a message can be set to a value later than the expiry time. </param>
        /// <param name="timeout"> The The timeout parameter is expressed in seconds. For more information, see &lt;a href=&quot;https://docs.microsoft.com/en-us/rest/api/storageservices/setting-timeouts-for-queue-service-operations&gt;Setting Timeouts for Queue Service Operations.&lt;/a&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="queueName"/> is null. </exception>
        public ResponseWithHeaders<IReadOnlyList<DequeuedMessageItem>, MessagesDequeueHeaders> Dequeue(string queueName, int? numberOfMessages = null, int? visibilitytimeout = null, int? timeout = null, CancellationToken cancellationToken = default)
        {
            if (queueName == null)
            {
                throw new ArgumentNullException(nameof(queueName));
            }

            using var message = CreateDequeueRequest(queueName, numberOfMessages, visibilitytimeout, timeout);
            _pipeline.Send(message, cancellationToken);
            var headers = new MessagesDequeueHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<DequeuedMessageItem> value = default;
                        var document = XDocument.Load(message.Response.ContentStream, LoadOptions.PreserveWhitespace);
                        if (document.Element("QueueMessagesList") is XElement queueMessagesListElement)
                        {
                            var array = new List<DequeuedMessageItem>();
                            foreach (var e in queueMessagesListElement.Elements("QueueMessage"))
                            {
                                array.Add(DequeuedMessageItem.DeserializeDequeuedMessageItem(e));
                            }
                            value = array;
                        }
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateClearRequest(string queueName, int? timeout)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(url, false);
            uri.AppendPath("/", false);
            uri.AppendPath(queueName, true);
            uri.AppendPath("/messages", false);
            if (timeout != null)
            {
                uri.AppendQuery("timeout", timeout.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("x-ms-version", version);
            request.Headers.Add("Accept", "application/xml");
            return message;
        }

        /// <summary> The Clear operation deletes all messages from the specified queue. </summary>
        /// <param name="queueName"> The queue name. </param>
        /// <param name="timeout"> The The timeout parameter is expressed in seconds. For more information, see &lt;a href=&quot;https://docs.microsoft.com/en-us/rest/api/storageservices/setting-timeouts-for-queue-service-operations&gt;Setting Timeouts for Queue Service Operations.&lt;/a&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="queueName"/> is null. </exception>
        public async Task<ResponseWithHeaders<MessagesClearHeaders>> ClearAsync(string queueName, int? timeout = null, CancellationToken cancellationToken = default)
        {
            if (queueName == null)
            {
                throw new ArgumentNullException(nameof(queueName));
            }

            using var message = CreateClearRequest(queueName, timeout);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new MessagesClearHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 204:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> The Clear operation deletes all messages from the specified queue. </summary>
        /// <param name="queueName"> The queue name. </param>
        /// <param name="timeout"> The The timeout parameter is expressed in seconds. For more information, see &lt;a href=&quot;https://docs.microsoft.com/en-us/rest/api/storageservices/setting-timeouts-for-queue-service-operations&gt;Setting Timeouts for Queue Service Operations.&lt;/a&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="queueName"/> is null. </exception>
        public ResponseWithHeaders<MessagesClearHeaders> Clear(string queueName, int? timeout = null, CancellationToken cancellationToken = default)
        {
            if (queueName == null)
            {
                throw new ArgumentNullException(nameof(queueName));
            }

            using var message = CreateClearRequest(queueName, timeout);
            _pipeline.Send(message, cancellationToken);
            var headers = new MessagesClearHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 204:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateEnqueueRequest(string queueName, QueueMessage queueMessage, int? visibilitytimeout, int? messageTimeToLive, int? timeout)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(url, false);
            uri.AppendPath("/", false);
            uri.AppendPath(queueName, true);
            uri.AppendPath("/messages", false);
            if (visibilitytimeout != null)
            {
                uri.AppendQuery("visibilitytimeout", visibilitytimeout.Value, true);
            }
            if (messageTimeToLive != null)
            {
                uri.AppendQuery("messagettl", messageTimeToLive.Value, true);
            }
            if (timeout != null)
            {
                uri.AppendQuery("timeout", timeout.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("x-ms-version", version);
            request.Headers.Add("Accept", "application/xml");
            request.Headers.Add("Content-Type", "application/xml");
            var content = new XmlWriterContent();
            content.XmlWriter.WriteObjectValue(queueMessage, "QueueMessage");
            request.Content = content;
            return message;
        }

        /// <summary> The Enqueue operation adds a new message to the back of the message queue. A visibility timeout can also be specified to make the message invisible until the visibility timeout expires. A message must be in a format that can be included in an XML request with UTF-8 encoding. The encoded message can be up to 64 KB in size for versions 2011-08-18 and newer, or 8 KB in size for previous versions. </summary>
        /// <param name="queueName"> The queue name. </param>
        /// <param name="queueMessage"> A Message object which can be stored in a Queue. </param>
        /// <param name="visibilitytimeout"> Optional. If specified, the request must be made using an x-ms-version of 2011-08-18 or later. If not specified, the default value is 0. Specifies the new visibility timeout value, in seconds, relative to server time. The new value must be larger than or equal to 0, and cannot be larger than 7 days. The visibility timeout of a message cannot be set to a value later than the expiry time. visibilitytimeout should be set to a value smaller than the time-to-live value. </param>
        /// <param name="messageTimeToLive"> Optional. Specifies the time-to-live interval for the message, in seconds. Prior to version 2017-07-29, the maximum time-to-live allowed is 7 days. For version 2017-07-29 or later, the maximum time-to-live can be any positive number, as well as -1 indicating that the message does not expire. If this parameter is omitted, the default time-to-live is 7 days. </param>
        /// <param name="timeout"> The The timeout parameter is expressed in seconds. For more information, see &lt;a href=&quot;https://docs.microsoft.com/en-us/rest/api/storageservices/setting-timeouts-for-queue-service-operations&gt;Setting Timeouts for Queue Service Operations.&lt;/a&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="queueName"/> or <paramref name="queueMessage"/> is null. </exception>
        public async Task<ResponseWithHeaders<IReadOnlyList<SendReceipt>, MessagesEnqueueHeaders>> EnqueueAsync(string queueName, QueueMessage queueMessage, int? visibilitytimeout = null, int? messageTimeToLive = null, int? timeout = null, CancellationToken cancellationToken = default)
        {
            if (queueName == null)
            {
                throw new ArgumentNullException(nameof(queueName));
            }
            if (queueMessage == null)
            {
                throw new ArgumentNullException(nameof(queueMessage));
            }

            using var message = CreateEnqueueRequest(queueName, queueMessage, visibilitytimeout, messageTimeToLive, timeout);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new MessagesEnqueueHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        IReadOnlyList<SendReceipt> value = default;
                        var document = XDocument.Load(message.Response.ContentStream, LoadOptions.PreserveWhitespace);
                        if (document.Element("QueueMessagesList") is XElement queueMessagesListElement)
                        {
                            var array = new List<SendReceipt>();
                            foreach (var e in queueMessagesListElement.Elements("QueueMessage"))
                            {
                                array.Add(SendReceipt.DeserializeSendReceipt(e));
                            }
                            value = array;
                        }
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> The Enqueue operation adds a new message to the back of the message queue. A visibility timeout can also be specified to make the message invisible until the visibility timeout expires. A message must be in a format that can be included in an XML request with UTF-8 encoding. The encoded message can be up to 64 KB in size for versions 2011-08-18 and newer, or 8 KB in size for previous versions. </summary>
        /// <param name="queueName"> The queue name. </param>
        /// <param name="queueMessage"> A Message object which can be stored in a Queue. </param>
        /// <param name="visibilitytimeout"> Optional. If specified, the request must be made using an x-ms-version of 2011-08-18 or later. If not specified, the default value is 0. Specifies the new visibility timeout value, in seconds, relative to server time. The new value must be larger than or equal to 0, and cannot be larger than 7 days. The visibility timeout of a message cannot be set to a value later than the expiry time. visibilitytimeout should be set to a value smaller than the time-to-live value. </param>
        /// <param name="messageTimeToLive"> Optional. Specifies the time-to-live interval for the message, in seconds. Prior to version 2017-07-29, the maximum time-to-live allowed is 7 days. For version 2017-07-29 or later, the maximum time-to-live can be any positive number, as well as -1 indicating that the message does not expire. If this parameter is omitted, the default time-to-live is 7 days. </param>
        /// <param name="timeout"> The The timeout parameter is expressed in seconds. For more information, see &lt;a href=&quot;https://docs.microsoft.com/en-us/rest/api/storageservices/setting-timeouts-for-queue-service-operations&gt;Setting Timeouts for Queue Service Operations.&lt;/a&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="queueName"/> or <paramref name="queueMessage"/> is null. </exception>
        public ResponseWithHeaders<IReadOnlyList<SendReceipt>, MessagesEnqueueHeaders> Enqueue(string queueName, QueueMessage queueMessage, int? visibilitytimeout = null, int? messageTimeToLive = null, int? timeout = null, CancellationToken cancellationToken = default)
        {
            if (queueName == null)
            {
                throw new ArgumentNullException(nameof(queueName));
            }
            if (queueMessage == null)
            {
                throw new ArgumentNullException(nameof(queueMessage));
            }

            using var message = CreateEnqueueRequest(queueName, queueMessage, visibilitytimeout, messageTimeToLive, timeout);
            _pipeline.Send(message, cancellationToken);
            var headers = new MessagesEnqueueHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        IReadOnlyList<SendReceipt> value = default;
                        var document = XDocument.Load(message.Response.ContentStream, LoadOptions.PreserveWhitespace);
                        if (document.Element("QueueMessagesList") is XElement queueMessagesListElement)
                        {
                            var array = new List<SendReceipt>();
                            foreach (var e in queueMessagesListElement.Elements("QueueMessage"))
                            {
                                array.Add(SendReceipt.DeserializeSendReceipt(e));
                            }
                            value = array;
                        }
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePeekRequest(string queueName, int? numberOfMessages, int? timeout)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(url, false);
            uri.AppendPath("/", false);
            uri.AppendPath(queueName, true);
            uri.AppendPath("/messages", false);
            uri.AppendQuery("peekonly", "true", true);
            if (numberOfMessages != null)
            {
                uri.AppendQuery("numofmessages", numberOfMessages.Value, true);
            }
            if (timeout != null)
            {
                uri.AppendQuery("timeout", timeout.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("x-ms-version", version);
            request.Headers.Add("Accept", "application/xml");
            return message;
        }

        /// <summary> The Peek operation retrieves one or more messages from the front of the queue, but does not alter the visibility of the message. </summary>
        /// <param name="queueName"> The queue name. </param>
        /// <param name="numberOfMessages"> Optional. A nonzero integer value that specifies the number of messages to retrieve from the queue, up to a maximum of 32. If fewer are visible, the visible messages are returned. By default, a single message is retrieved from the queue with this operation. </param>
        /// <param name="timeout"> The The timeout parameter is expressed in seconds. For more information, see &lt;a href=&quot;https://docs.microsoft.com/en-us/rest/api/storageservices/setting-timeouts-for-queue-service-operations&gt;Setting Timeouts for Queue Service Operations.&lt;/a&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="queueName"/> is null. </exception>
        public async Task<ResponseWithHeaders<IReadOnlyList<PeekedMessageItem>, MessagesPeekHeaders>> PeekAsync(string queueName, int? numberOfMessages = null, int? timeout = null, CancellationToken cancellationToken = default)
        {
            if (queueName == null)
            {
                throw new ArgumentNullException(nameof(queueName));
            }

            using var message = CreatePeekRequest(queueName, numberOfMessages, timeout);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new MessagesPeekHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<PeekedMessageItem> value = default;
                        var document = XDocument.Load(message.Response.ContentStream, LoadOptions.PreserveWhitespace);
                        if (document.Element("QueueMessagesList") is XElement queueMessagesListElement)
                        {
                            var array = new List<PeekedMessageItem>();
                            foreach (var e in queueMessagesListElement.Elements("QueueMessage"))
                            {
                                array.Add(PeekedMessageItem.DeserializePeekedMessageItem(e));
                            }
                            value = array;
                        }
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> The Peek operation retrieves one or more messages from the front of the queue, but does not alter the visibility of the message. </summary>
        /// <param name="queueName"> The queue name. </param>
        /// <param name="numberOfMessages"> Optional. A nonzero integer value that specifies the number of messages to retrieve from the queue, up to a maximum of 32. If fewer are visible, the visible messages are returned. By default, a single message is retrieved from the queue with this operation. </param>
        /// <param name="timeout"> The The timeout parameter is expressed in seconds. For more information, see &lt;a href=&quot;https://docs.microsoft.com/en-us/rest/api/storageservices/setting-timeouts-for-queue-service-operations&gt;Setting Timeouts for Queue Service Operations.&lt;/a&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="queueName"/> is null. </exception>
        public ResponseWithHeaders<IReadOnlyList<PeekedMessageItem>, MessagesPeekHeaders> Peek(string queueName, int? numberOfMessages = null, int? timeout = null, CancellationToken cancellationToken = default)
        {
            if (queueName == null)
            {
                throw new ArgumentNullException(nameof(queueName));
            }

            using var message = CreatePeekRequest(queueName, numberOfMessages, timeout);
            _pipeline.Send(message, cancellationToken);
            var headers = new MessagesPeekHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<PeekedMessageItem> value = default;
                        var document = XDocument.Load(message.Response.ContentStream, LoadOptions.PreserveWhitespace);
                        if (document.Element("QueueMessagesList") is XElement queueMessagesListElement)
                        {
                            var array = new List<PeekedMessageItem>();
                            foreach (var e in queueMessagesListElement.Elements("QueueMessage"))
                            {
                                array.Add(PeekedMessageItem.DeserializePeekedMessageItem(e));
                            }
                            value = array;
                        }
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
