﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Azure.Messaging.EventHubs.Errors;
using Azure.Messaging.EventHubs.Metadata;
using Azure.Messaging.EventHubs.Tests.Infrastructure;
using NUnit.Framework;

namespace Azure.Messaging.EventHubs.Tests
{
    /// <summary>
    ///   The suite of live tests for the <see cref="EventHubProducerClientClient" />
    ///   class.
    /// </summary>
    ///
    /// <remarks>
    ///   These tests have a dependency on live Azure services and may
    ///   incur costs for the associated Azure subscription.
    /// </remarks>
    ///
    [TestFixture]
    [Category(TestCategory.Live)]
    [Category(TestCategory.DisallowVisualStudioLiveUnitTesting)]
    public class EventHubProducerClientLiveTests
    {
        /// <summary>The maximum number of times that the receive loop should iterate to collect the expected number of messages.</summary>
        private const int ReceiveRetryLimit = 10;

        /// <summary>
        ///   Verifies that the <see cref="EventHubProducerClient" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        [TestCase(TransportType.AmqpTcp)]
        [TestCase(TransportType.AmqpWebSockets)]
        public async Task ProducerWithNoOptionsCanSend(TransportType transportType)
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var connection = new EventHubConnection(connectionString, new EventHubConnectionOptions { TransportType = transportType }))
                await using (var producer = new EventHubProducerClient(connection))
                {
                    EventData[] events = new[] { new EventData(Encoding.UTF8.GetBytes("AWord")) };
                    Assert.That(async () => await producer.SendAsync(events), Throws.Nothing);
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubProducerClient" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        [TestCase(TransportType.AmqpTcp)]
        [TestCase(TransportType.AmqpWebSockets)]
        public async Task ProducerWithOptionsCanSend(TransportType transportType)
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                var producerOptions = new EventHubProducerClientOptions
                {
                    RetryOptions = new RetryOptions { MaximumRetries = 5 },
                    ConnectionOptions = new EventHubConnectionOptions { TransportType = transportType }
                };

                await using (var producer = new EventHubProducerClient(connectionString, producerOptions))
                {
                    EventData[] events = new[] { new EventData(Encoding.UTF8.GetBytes("AWord")) };
                    Assert.That(async () => await producer.SendAsync(events), Throws.Nothing);
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubProducerClient" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        [Description("Partition Affinity Refactor")]
        public async Task ProducerCanSendToASpecificPartition()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var connection = new EventHubConnection(connectionString))
                {
                    var partition = (await connection.GetPartitionIdsAsync(new RetryOptions().ToRetryPolicy())).First();
                    var producerOptions = new EventHubProducerClientOptions { PartitionId = partition };

                    await using (var producer = new EventHubProducerClient(connection, producerOptions))
                    {
                        EventData[] events = new[] { new EventData(Encoding.UTF8.GetBytes("AWord")) };
                        Assert.That(async () => await producer.SendAsync(events), Throws.Nothing);
                    }
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubProducerClient" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task ProducerCanSendEventsWithCustomProperties()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                EventData[] events = new[]
                {
                    new EventData(new byte[] { 0x22, 0x33 }),
                    new EventData(Encoding.UTF8.GetBytes("This is a really long string of stuff that I wanted to type because I like to")),
                    new EventData(Encoding.UTF8.GetBytes("I wanted to type because I like to")),
                    new EventData(Encoding.UTF8.GetBytes("If you are reading this, you really like test cases"))
                };

                for (var index = 0; index < events.Length; ++index)
                {
                    events[index].Properties[index.ToString()] = "some value";
                    events[index].Properties["Type"] = $"com.microsoft.test.Type{ index }";
                }

                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var producer = new EventHubProducerClient(connectionString))
                {
                    Assert.That(async () => await producer.SendAsync(events), Throws.Nothing);
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubProducerClient" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task ProducerCanSendEventsUsingAPartitionHashKey()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(2))
            {
                IEnumerable<EventData> events = Enumerable
                    .Range(0, 25)
                    .Select(index => new EventData(Encoding.UTF8.GetBytes(new string('X', index + 5))));

                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var producer = new EventHubProducerClient(connectionString))
                {
                    var batchOptions = new SendOptions { PartitionKey = "some123key-!d" };
                    Assert.That(async () => await producer.SendAsync(events, batchOptions), Throws.Nothing);
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubProducerClient" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task ProducerCanSendMultipleSetsOfEventsUsingAPartitionHashKey()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(2))
            {
                var batchOptions = new SendOptions { PartitionKey = "some123key-!d" };

                for (var index = 0; index < 5; ++index)
                {
                    IEnumerable<EventData> events = Enumerable
                        .Range(0, 25)
                        .Select(index => new EventData(Encoding.UTF8.GetBytes(new string((char)(65 + index), index + 5))));

                    var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                    await using (var producer = new EventHubProducerClient(connectionString))
                    {
                        Assert.That(async () => await producer.SendAsync(events, batchOptions), Throws.Nothing, $"Batch { index } should not have thrown an exception.");
                    }
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubProducerClient" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task ProducerCanSendAnEventBatchUsingAPartitionHashKey()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(2))
            {
                IEnumerable<EventData> events = Enumerable
                    .Range(0, 25)
                    .Select(index => new EventData(Encoding.UTF8.GetBytes(new string('X', index + 5))));

                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);
                var batchOptions = new BatchOptions { PartitionKey = "some123key-!d" };

                await using (var producer = new EventHubProducerClient(connectionString))
                {
                    using EventDataBatch batch = await producer.CreateBatchAsync(batchOptions);

                    foreach (EventData eventData in events)
                    {
                        Assert.That(() => batch.TryAdd(eventData), Is.True, "An event was rejected by the batch; all events should be accepted.");
                    }

                    Assert.That(async () => await producer.SendAsync(batch), Throws.Nothing);
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubProducerClient" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task ProducerCanSendSingleZeroLengthEvent()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var producer = new EventHubProducerClient(connectionString))
                {
                    var singleEvent = new EventData(Array.Empty<byte>());
                    Assert.That(async () => await producer.SendAsync(singleEvent), Throws.Nothing);
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubProducerClient" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task ProducerCanSendSingleLargeEvent()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var producer = new EventHubProducerClient(connectionString, new EventHubProducerClientOptions { RetryOptions = new RetryOptions { TryTimeout = TimeSpan.FromMinutes(5) } }))
                {
                    // Actual limit is 1046520 for a single event.
                    var singleEvent = new EventData(new byte[100000]);

                    Assert.That(async () => await producer.SendAsync(singleEvent), Throws.Nothing);
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubProducerClient" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task ProducerCanSendSingleLargeEventInASet()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var producer = new EventHubProducerClient(connectionString, new EventHubProducerClientOptions { RetryOptions = new RetryOptions { TryTimeout = TimeSpan.FromMinutes(5) } }))
                {
                    // Actual limit is 1046520 for a single event.
                    EventData[] eventSet = new[] { new EventData(new byte[100000]) };

                    Assert.That(async () => await producer.SendAsync(eventSet), Throws.Nothing);
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubProducerClient" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task ProducerCannotSendSingleEventLargerThanMaximumSize()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var producer = new EventHubProducerClient(connectionString))
                {
                    // Actual limit is 1046520 for a single event.
                    var singleEvent = new EventData(new byte[1500000]);
                    EventData[] eventBatch = new[] { new EventData(new byte[1500000]) };

                    Assert.That(async () => await producer.SendAsync(singleEvent), Throws.TypeOf<MessageSizeExceededException>());
                    Assert.That(async () => await producer.SendAsync(eventBatch), Throws.TypeOf<MessageSizeExceededException>());
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubProducerClient" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task ProducerCanSendASetOfEvents()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var producer = new EventHubProducerClient(connectionString))
                {
                    EventData[] events = new[]
                    {
                        new EventData(Encoding.UTF8.GetBytes("This is a message")),
                        new EventData(Encoding.UTF8.GetBytes("This is another message")),
                        new EventData(Encoding.UTF8.GetBytes("So many messages"))
                    };

                    Assert.That(async () => await producer.SendAsync(events), Throws.Nothing);
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubProducerClient" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task ProducerCanSendZeroLengthSet()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var producer = new EventHubProducerClient(connectionString))
                {
                    EventData[] events = new[]
                    {
                        new EventData(Array.Empty<byte>()),
                        new EventData(Array.Empty<byte>()),
                        new EventData(Array.Empty<byte>())
                    };

                    Assert.That(async () => await producer.SendAsync(events), Throws.Nothing);
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubProducerClient" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task ProducerCanSendLargeSet()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var producer = new EventHubProducerClient(connectionString, new EventHubProducerClientOptions { RetryOptions = new RetryOptions { TryTimeout = TimeSpan.FromMinutes(5) } }))
                {
                    // Actual limit is 1046520 for a single event.
                    EventData[] events = new[]
                    {
                        new EventData(new byte[100000 / 3]),
                        new EventData(new byte[100000 / 3]),
                        new EventData(new byte[100000 / 3])
                    };

                    Assert.That(async () => await producer.SendAsync(events), Throws.Nothing);
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubProducerClient" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task ProducerCanSendAnEventBatch()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var producer = new EventHubProducerClient(connectionString))
                {
                    using EventDataBatch batch = await producer.CreateBatchAsync();

                    batch.TryAdd(new EventData(Encoding.UTF8.GetBytes("This is a message")));
                    batch.TryAdd(new EventData(Encoding.UTF8.GetBytes("This is another message")));
                    batch.TryAdd(new EventData(Encoding.UTF8.GetBytes("So many messages")));

                    Assert.That(batch.Count, Is.EqualTo(3), "The batch should contain all 3 events.");
                    Assert.That(async () => await producer.SendAsync(batch), Throws.Nothing);
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubProducerClient" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task ProducerCanSendZeroLengthEventBatch()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var producer = new EventHubProducerClient(connectionString))
                {
                    using EventDataBatch batch = await producer.CreateBatchAsync();
                    batch.TryAdd(new EventData(Array.Empty<byte>()));

                    Assert.That(batch.Count, Is.EqualTo(1), "The batch should contain a single event.");
                    Assert.That(async () => await producer.SendAsync(batch), Throws.Nothing);
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubProducerClient" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task ProducerCanSendLargeEventBatch()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var producer = new EventHubProducerClient(connectionString, new EventHubProducerClientOptions { RetryOptions = new RetryOptions { TryTimeout = TimeSpan.FromMinutes(5) } }))
                {
                    using EventDataBatch batch = await producer.CreateBatchAsync();

                    // Actual limit is 1046520 for a single event.
                    batch.TryAdd(new EventData(new byte[100000 / 3]));
                    batch.TryAdd(new EventData(new byte[100000 / 3]));
                    batch.TryAdd(new EventData(new byte[100000 / 3]));

                    Assert.That(batch.Count, Is.EqualTo(3), "The batch should contain all 3 events.");
                    Assert.That(async () => await producer.SendAsync(batch), Throws.Nothing);
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubProducerClient" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task ProducerCannotSendSetLargerThanMaximumSize()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var producer = new EventHubProducerClient(connectionString))
                {
                    // Actual limit is 1046520 for a single event.
                    EventData[] events = new[]
                    {
                        new EventData(new byte[1500000 / 3]),
                        new EventData(new byte[1500000 / 3]),
                        new EventData(new byte[1500000 / 3])
                    };

                    Assert.That(async () => await producer.SendAsync(events), Throws.TypeOf<MessageSizeExceededException>());
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubProducerClient" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task ProducerCanSendSetToASpecificPartition()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var connection = new EventHubConnection(connectionString))
                {
                    var partition = (await connection.GetPartitionIdsAsync(new RetryOptions().ToRetryPolicy())).First();
                    var producerOptions = new EventHubProducerClientOptions { PartitionId = partition };

                    await using (var producer = new EventHubProducerClient(connection, producerOptions))
                    {
                        EventData[] events = new[]
                        {
                            new EventData(Encoding.UTF8.GetBytes("This is a message")),
                            new EventData(Encoding.UTF8.GetBytes("This is another message")),
                            new EventData(Encoding.UTF8.GetBytes("Do we need more messages"))
                        };

                        Assert.That(async () => await producer.SendAsync(events), Throws.Nothing);
                    }
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubProducerClient" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task ProducerCanSendWhenPartitionIsNull()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var connection = new EventHubConnection(connectionString))
                {
                    var producerOptions = new EventHubProducerClientOptions { PartitionId = null };

                    await using (var producer = new EventHubProducerClient(connection, producerOptions))
                    {
                        EventData[] events = new[] { new EventData(Encoding.UTF8.GetBytes("Will it work")) };
                        Assert.That(async () => await producer.SendAsync(events), Throws.Nothing);
                    }
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubProducerClient" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        [TestCase(true)]
        [TestCase(false)]
        public async Task ProducerCannotSendWhenClosed(bool sync)
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var producer = new EventHubProducerClient(connectionString))
                {
                    EventData[] events = new[] { new EventData(Encoding.UTF8.GetBytes("Dummy event")) };
                    Assert.That(async () => await producer.SendAsync(events), Throws.Nothing);

                    if (sync)
                    {
                        producer.Close();
                    }
                    else
                    {
                        await producer.CloseAsync();
                    }

                    Assert.That(async () => await producer.SendAsync(events), Throws.TypeOf<EventHubsClientClosedException>());
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubProducerClient" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        [TestCase("XYZ")]
        [TestCase("-1")]
        [TestCase("1000")]
        [TestCase("-")]
        public async Task ProducerCannotSendToInvalidPartition(string invalidPartition)
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var connection = new EventHubConnection(connectionString))
                {
                    EventData[] events = new[] { new EventData(Encoding.UTF8.GetBytes("Lorem Ipsum")) };

                    await using (var producer = new EventHubProducerClient(connection, new EventHubProducerClientOptions { PartitionId = invalidPartition }))
                    {
                        Assert.That(async () => await producer.SendAsync(events), Throws.TypeOf<ArgumentOutOfRangeException>());
                    }
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubProducerClient" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task SendUpdatesPartitionProperties()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var connection = new EventHubConnection(connectionString))
                {
                    var partition = (await connection.GetPartitionIdsAsync(new RetryOptions().ToRetryPolicy())).First();
                    EventData[] events = new[] { new EventData(Encoding.UTF8.GetBytes("I should update stuff")) };

                    await using (var producer = new EventHubProducerClient(connection, new EventHubProducerClientOptions { PartitionId = partition }))
                    {
                        // Sending events beforehand so the partition has some information.

                        await producer.SendAsync(events);

                        PartitionProperties oldPartitionProperties = await producer.GetPartitionPropertiesAsync(partition);

                        Assert.That(oldPartitionProperties, Is.Not.Null, "A set of partition properties should have been returned.");

                        await producer.SendAsync(events);

                        PartitionProperties newPartitionProperties = await producer.GetPartitionPropertiesAsync(partition);

                        Assert.That(newPartitionProperties, Is.Not.Null, "A set of partition properties should have been returned.");

                        // The following properties should not have been altered.

                        Assert.That(newPartitionProperties.Id, Is.EqualTo(oldPartitionProperties.Id));
                        Assert.That(newPartitionProperties.EventHubName, Is.EqualTo(oldPartitionProperties.EventHubName));
                        Assert.That(newPartitionProperties.BeginningSequenceNumber, Is.EqualTo(oldPartitionProperties.BeginningSequenceNumber));

                        // The following properties should have been updated.

                        Assert.That(newPartitionProperties.LastEnqueuedSequenceNumber, Is.GreaterThan(oldPartitionProperties.LastEnqueuedSequenceNumber));
                        Assert.That(newPartitionProperties.LastEnqueuedOffset, Is.GreaterThan(oldPartitionProperties.LastEnqueuedOffset));
                    }
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubProducerClient" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task SendDoesNotUpdatePartitionPropertiesWhenSendingToDifferentPartition()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(2))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var connection = new EventHubConnection(connectionString))
                {
                    var partitionIds = await connection.GetPartitionIdsAsync(new RetryOptions().ToRetryPolicy());
                    EventData[] events = new[] { new EventData(Encoding.UTF8.GetBytes("I should not update stuff")) };

                    await using (var producer0 = new EventHubProducerClient(connection, new EventHubProducerClientOptions { PartitionId = partitionIds[0] }))
                    await using (var producer1 = new EventHubProducerClient(connection, new EventHubProducerClientOptions { PartitionId = partitionIds[1] }))
                    {
                        // Sending events beforehand so the partition has some information.

                        await producer0.SendAsync(events);

                        PartitionProperties oldPartitionProperties = await producer0.GetPartitionPropertiesAsync(partitionIds[0]);

                        Assert.That(oldPartitionProperties, Is.Not.Null, "A set of partition properties should have been returned.");

                        await producer1.SendAsync(events);

                        PartitionProperties newPartitionProperties = await producer1.GetPartitionPropertiesAsync(partitionIds[0]);

                        Assert.That(newPartitionProperties, Is.Not.Null, "A set of partition properties should have been returned.");

                        // All properties should remain the same.

                        Assert.That(newPartitionProperties.Id, Is.EqualTo(oldPartitionProperties.Id));
                        Assert.That(newPartitionProperties.EventHubName, Is.EqualTo(oldPartitionProperties.EventHubName));
                        Assert.That(newPartitionProperties.BeginningSequenceNumber, Is.EqualTo(oldPartitionProperties.BeginningSequenceNumber));
                        Assert.That(newPartitionProperties.LastEnqueuedSequenceNumber, Is.EqualTo(oldPartitionProperties.LastEnqueuedSequenceNumber));
                        Assert.That(newPartitionProperties.LastEnqueuedOffset, Is.EqualTo(oldPartitionProperties.LastEnqueuedOffset));
                    }
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubProducerClient" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        [TestCase(true)]
        [TestCase(false)]
        public async Task ProducerDoesNotSendToSpecificPartitionWhenPartitionIdIsNotSpecified(bool nullPartition)
        {
            var partitions = 10;

            await using (EventHubScope scope = await EventHubScope.CreateAsync(partitions))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var connection = new EventHubConnection(connectionString))
                {
                    var producerOptions = new EventHubProducerClientOptions { };

                    if (nullPartition)
                    {
                        producerOptions.PartitionId = null;
                    }

                    await using (var producer = new EventHubProducerClient(connection, producerOptions))
                    {
                        var batches = 30;
                        var partitionIds = await producer.GetPartitionIdsAsync();
                        var partitionsCount = 0;
                        var consumers = new List<EventHubConsumerClient>();
                        var receivers = new List<PartitionReceiver>();

                        try
                        {
                            for (var index = 0; index < partitions; index++)
                            {
                                consumers.Add(new EventHubConsumerClient(EventHubConsumerClient.DefaultConsumerGroupName, partitionIds[index], EventPosition.Latest, connection));
                                receivers.Add(consumers[index].CreatePartitionReceiver(partitionIds[index], EventPosition.Latest));

                                // Initiate an operation to force the consumer to connect and set its position at the
                                // end of the event stream.

                                await receivers[index].ReceiveAsync(1, TimeSpan.Zero);
                            }

                            // Send the batches of events.

                            for (var index = 0; index < batches; index++)
                            {
                                await producer.SendAsync(new EventData(Encoding.UTF8.GetBytes("It's not healthy to send so many messages")));
                            }

                            // Receive the events; because there is some non-determinism in the messaging flow, the
                            // sent events may not be immediately available.  Allow for a small number of attempts to receive, in order
                            // to account for availability delays.

                            foreach (PartitionReceiver receiver in receivers)
                            {
                                var receivedEvents = new List<EventData>();
                                var index = 0;

                                while (++index < ReceiveRetryLimit)
                                {
                                    receivedEvents.AddRange(await receiver.ReceiveAsync(batches + 10, TimeSpan.FromMilliseconds(25)));
                                }

                                if (receivedEvents.Count > 0)
                                {
                                    partitionsCount++;
                                }
                            }
                        }
                        finally
                        {
                            await Task.WhenAll(receivers.Select(receiver => receiver.CloseAsync()));
                            await Task.WhenAll(consumers.Select(consumer => consumer.CloseAsync()));
                        }

                        Assert.That(partitionsCount, Is.GreaterThan(1));
                    }
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubProducerClient" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task ProducerSendsEventsInTheSameSetToTheSamePartition()
        {
            var partitions = 10;

            await using (EventHubScope scope = await EventHubScope.CreateAsync(partitions))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var connection = new EventHubConnection(connectionString))
                await using (var producer = new EventHubProducerClient(connection))
                {
                    var eventBatch = Enumerable
                        .Range(0, 30)
                        .Select(index => new EventData(Encoding.UTF8.GetBytes("I'm getting used to this amount of messages")))
                        .ToList();

                    var partitionIds = await producer.GetPartitionIdsAsync();
                    var partitionsCount = 0;
                    var receivedEventsCount = 0;
                    var consumers = new List<EventHubConsumerClient>();
                    var receivers = new List<PartitionReceiver>();

                    try
                    {
                        for (var index = 0; index < partitions; index++)
                        {
                            consumers.Add(new EventHubConsumerClient(EventHubConsumerClient.DefaultConsumerGroupName, partitionIds[index], EventPosition.Latest, connection));
                            receivers.Add(consumers[index].CreatePartitionReceiver(partitionIds[index], EventPosition.Latest));

                            // Initiate an operation to force the consumer to connect and set its position at the
                            // end of the event stream.

                            await receivers[index].ReceiveAsync(1, TimeSpan.Zero);
                        }

                        // Send the batch of events.

                        await producer.SendAsync(eventBatch);

                        // Receive the events; because there is some non-determinism in the messaging flow, the
                        // sent events may not be immediately available.  Allow for a small number of attempts to receive, in order
                        // to account for availability delays.

                        foreach (PartitionReceiver receiver in receivers)
                        {
                            var receivedEvents = new List<EventData>();
                            var index = 0;

                            while (++index < ReceiveRetryLimit)
                            {
                                receivedEvents.AddRange(await receiver.ReceiveAsync(eventBatch.Count + 10, TimeSpan.FromMilliseconds(25)));
                            }

                            if (receivedEvents.Count > 0)
                            {
                                partitionsCount++;
                                receivedEventsCount += receivedEvents.Count;
                            }
                        }
                    }
                    finally
                    {
                        await Task.WhenAll(receivers.Select(receiver => receiver.CloseAsync()));
                        await Task.WhenAll(consumers.Select(consumer => consumer.CloseAsync()));
                    }

                    Assert.That(partitionsCount, Is.EqualTo(1));
                    Assert.That(receivedEventsCount, Is.EqualTo(eventBatch.Count));
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubProducerClient" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task ProducerSendsEventsWithTheSamePartitionHashKeyToTheSamePartition()
        {
            var partitions = 10;
            var partitionKey = "some123key-!d";

            await using (EventHubScope scope = await EventHubScope.CreateAsync(partitions))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var connection = new EventHubConnection(connectionString))
                await using (var producer = new EventHubProducerClient(connection))
                {
                    var batches = 5;
                    var partitionIds = await producer.GetPartitionIdsAsync();
                    var partitionsCount = 0;
                    var receivedEventsCount = 0;
                    var consumers = new List<EventHubConsumerClient>();
                    var receivers = new List<PartitionReceiver>();

                    try
                    {
                        for (var index = 0; index < partitions; index++)
                        {
                            consumers.Add(new EventHubConsumerClient(EventHubConsumerClient.DefaultConsumerGroupName, partitionIds[index], EventPosition.Latest, connection));
                            receivers.Add(consumers[index].CreatePartitionReceiver(partitionIds[index], EventPosition.Latest));

                            // Initiate an operation to force the consumer to connect and set its position at the
                            // end of the event stream.

                            await receivers[index].ReceiveAsync(1, TimeSpan.Zero);
                        }

                        // Send the batches of events.

                        var batchOptions = new SendOptions { PartitionKey = partitionKey };

                        for (var index = 0; index < batches; index++)
                        {
                            await producer.SendAsync(new EventData(Encoding.UTF8.GetBytes($"Just a few messages ({ index })")), batchOptions);
                        }

                        // Receive the events; because there is some non-determinism in the messaging flow, the
                        // sent events may not be immediately available.  Allow for a small number of attempts to receive, in order
                        // to account for availability delays.

                        foreach (PartitionReceiver receiver in receivers)
                        {
                            var receivedEvents = new List<EventData>();
                            var index = 0;

                            while (++index < ReceiveRetryLimit)
                            {
                                receivedEvents.AddRange(await receiver.ReceiveAsync(batches + 10, TimeSpan.FromMilliseconds(25)));
                            }

                            if (receivedEvents.Count > 0)
                            {
                                partitionsCount++;
                                receivedEventsCount += receivedEvents.Count;

                                foreach (EventData receivedEvent in receivedEvents)
                                {
                                    Assert.That(receivedEvent.PartitionKey, Is.EqualTo(partitionKey));
                                }
                            }
                        }
                    }
                    finally
                    {
                        await Task.WhenAll(receivers.Select(receiver => receiver.CloseAsync()));
                        await Task.WhenAll(consumers.Select(consumer => consumer.CloseAsync()));
                    }

                    Assert.That(partitionsCount, Is.EqualTo(1));
                    Assert.That(receivedEventsCount, Is.EqualTo(batches));
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubProducerClient" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task ProducerCannotSendWhenProxyIsInvalid()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                var producerOptions = new EventHubProducerClientOptions
                {
                    RetryOptions = new RetryOptions { TryTimeout = TimeSpan.FromMinutes(2) },

                    ConnectionOptions = new EventHubConnectionOptions
                    {
                        Proxy = new WebProxy("http://1.2.3.4:9999"),
                        TransportType = TransportType.AmqpWebSockets
                    }
                };

                await using (var invalidProxyProducer = new EventHubProducerClient(connectionString, producerOptions))
                {
                    Assert.That(async () => await invalidProxyProducer.SendAsync(new EventData(new byte[1])), Throws.InstanceOf<WebSocketException>().Or.InstanceOf<TimeoutException>());
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubProducerClient" /> is able to
        ///   connect to the Event Hubs service.
        /// </summary>
        ///
        [Test]
        [TestCase(TransportType.AmqpTcp)]
        [TestCase(TransportType.AmqpWebSockets)]
        public async Task ProducerCanRetrieveEventHubProperties(TransportType transportType)
        {
            var partitionCount = 4;

            await using (EventHubScope scope = await EventHubScope.CreateAsync(partitionCount))
            {
                var connectionString = TestEnvironment.EventHubsConnectionString;
                var producerOptions = new EventHubProducerClientOptions { ConnectionOptions = new EventHubConnectionOptions { TransportType = transportType } };

                await using (var producer = new EventHubProducerClient(connectionString, scope.EventHubName, producerOptions))
                {
                    EventHubProperties properties = await producer.GetEventHubPropertiesAsync();

                    Assert.That(properties, Is.Not.Null, "A set of properties should have been returned.");
                    Assert.That(properties.Name, Is.EqualTo(scope.EventHubName), "The property Event Hub name should match the scope.");
                    Assert.That(properties.PartitionIds.Length, Is.EqualTo(partitionCount), "The properties should have the requested number of partitions.");
                    Assert.That(properties.CreatedAt, Is.EqualTo(DateTimeOffset.UtcNow).Within(TimeSpan.FromSeconds(60)), "The Event Hub should have been created just about now.");
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubProducerClient" /> is able to
        ///   connect to the Event Hubs service.
        /// </summary>
        ///
        [Test]
        [TestCase(TransportType.AmqpTcp)]
        [TestCase(TransportType.AmqpWebSockets)]
        public async Task ProducerCanRetrievePartitionProperties(TransportType transportType)
        {
            var partitionCount = 4;

            await using (EventHubScope scope = await EventHubScope.CreateAsync(partitionCount))
            {
                var options = new EventHubConnectionOptions();
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);
                var producerOptions = new EventHubProducerClientOptions { ConnectionOptions = new EventHubConnectionOptions { TransportType = transportType } };

                await using (var producer = new EventHubProducerClient(connectionString, scope.EventHubName, producerOptions))
                {
                    var cancellation = new CancellationTokenSource(TimeSpan.FromSeconds(20));
                    var properties = await producer.GetEventHubPropertiesAsync();
                    var partition = properties.PartitionIds.First();
                    var partitionProperties = await producer.GetPartitionPropertiesAsync(partition, cancellation.Token);

                    Assert.That(partitionProperties, Is.Not.Null, "A set of partition properties should have been returned.");
                    Assert.That(partitionProperties.Id, Is.EqualTo(partition), "The partition identifier should match.");
                    Assert.That(partitionProperties.EventHubName, Is.EqualTo(scope.EventHubName).Using((IEqualityComparer<string>)StringComparer.InvariantCultureIgnoreCase), "The Event Hub path should match.");
                    Assert.That(partitionProperties.BeginningSequenceNumber, Is.Not.EqualTo(default(long)), "The beginning sequence number should have been populated.");
                    Assert.That(partitionProperties.LastEnqueuedSequenceNumber, Is.Not.EqualTo(default(long)), "The last sequence number should have been populated.");
                    Assert.That(partitionProperties.LastEnqueuedOffset, Is.Not.EqualTo(default(long)), "The last offset should have been populated.");
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubProducerClient" /> is able to
        ///   connect to the Event Hubs service.
        /// </summary>
        ///
        [Test]
        public async Task ConnectionTransportPartitionIdsMatchPartitionProperties()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(4))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var producer = new EventHubProducerClient(connectionString))
                {
                    EventHubProperties properties = await producer.GetEventHubPropertiesAsync();
                    var partitions = await producer.GetPartitionIdsAsync();

                    Assert.That(properties, Is.Not.Null, "A set of properties should have been returned.");
                    Assert.That(properties.PartitionIds, Is.Not.Null, "A set of partition identifiers for the properties should have been returned.");
                    Assert.That(partitions, Is.Not.Null, "A set of partition identifiers should have been returned.");
                    Assert.That(partitions, Is.EquivalentTo(properties.PartitionIds), "The partition identifiers returned directly should match those returned with properties.");
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubProducerClient" /> is able to
        ///   connect to the Event Hubs service.
        /// </summary>
        ///
        [Test]
        [TestCase(true)]
        [TestCase(false)]
        public async Task ProducerCannotRetrieveMetadataWhenClosed(bool sync)
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var producer = new EventHubProducerClient(connectionString))
                {
                    var partition = (await producer.GetPartitionIdsAsync()).First();

                    Assert.That(async () => await producer.GetEventHubPropertiesAsync(), Throws.Nothing);
                    Assert.That(async () => await producer.GetPartitionPropertiesAsync(partition), Throws.Nothing);

                    if (sync)
                    {
                        producer.Close();
                    }
                    else
                    {
                        await producer.CloseAsync();
                    }

                    await Task.Delay(TimeSpan.FromSeconds(5));

                    Assert.That(async () => await producer.GetPartitionIdsAsync(), Throws.TypeOf<EventHubsClientClosedException>());
                    Assert.That(async () => await producer.GetEventHubPropertiesAsync(), Throws.TypeOf<EventHubsClientClosedException>());
                    Assert.That(async () => await producer.GetPartitionPropertiesAsync(partition), Throws.TypeOf<EventHubsClientClosedException>());
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubProducerClient" /> is able to
        ///   connect to the Event Hubs service.
        /// </summary>
        ///
        [Test]
        [TestCase("XYZ")]
        [TestCase("-1")]
        [TestCase("1000")]
        [TestCase("-")]
        public async Task ProducerCannotRetrievePartitionPropertiesWhenPartitionIdIsInvalid(string invalidPartition)
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var producer = new EventHubProducerClient(connectionString))
                {
                    Assert.That(async () => await producer.GetPartitionPropertiesAsync(invalidPartition), Throws.TypeOf<ArgumentOutOfRangeException>());
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubProducerClient" /> is able to
        ///   connect to the Event Hubs service.
        /// </summary>
        ///
        [Test]
        public async Task ProducerCannotRetrieveMetadataWhenProxyIsInvalid()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                var invalidProxyOptions = new EventHubProducerClientOptions
                {
                    RetryOptions = new RetryOptions { TryTimeout = TimeSpan.FromMinutes(2) },

                    ConnectionOptions = new EventHubConnectionOptions
                    {
                        Proxy = new WebProxy("http://1.2.3.4:9999"),
                        TransportType = TransportType.AmqpWebSockets
                    }
                };

                await using (var producer = new EventHubProducerClient(connectionString))
                await using (var invalidProxyProducer = new EventHubProducerClient(connectionString, invalidProxyOptions))
                {
                    var partition = (await producer.GetPartitionIdsAsync()).First();

                    Assert.That(async () => await invalidProxyProducer.GetPartitionIdsAsync(), Throws.InstanceOf<WebSocketException>().Or.InstanceOf<TimeoutException>());
                    Assert.That(async () => await invalidProxyProducer.GetEventHubPropertiesAsync(), Throws.InstanceOf<WebSocketException>().Or.InstanceOf<TimeoutException>());
                    Assert.That(async () => await invalidProxyProducer.GetPartitionPropertiesAsync(partition), Throws.InstanceOf<WebSocketException>().Or.InstanceOf<TimeoutException>());
                }
            }
        }
    }
}
