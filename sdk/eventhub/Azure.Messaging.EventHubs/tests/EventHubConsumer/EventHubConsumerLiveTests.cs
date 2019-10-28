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
    ///   The suite of live tests for the <see cref="EventHubConsumer" />
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
    public class EventHubConsumerLiveTests
    {
        /// <summary>The maximum number of times that the receive loop should iterate to collect the expected number of messages.</summary>
        private const int ReceiveRetryLimit = 10;

        /// <summary>
        ///   Verifies that the <see cref="EventHubConsumer" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        [TestCase(TransportType.AmqpTcp)]
        [TestCase(TransportType.AmqpWebSockets)]
        public async Task ConsumerWithNoOptionsCanReceive(TransportType transportType)
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var client = new EventHubClient(connectionString, new EventHubClientOptions { TransportType = transportType }))
                {
                    var partition = (await client.GetPartitionIdsAsync()).First();

                    await using (EventHubConsumer consumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partition, EventPosition.Latest))
                    {
                        Assert.That(async () => await consumer.ReceiveAsync(1, TimeSpan.Zero), Throws.Nothing);
                    }
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubConsumer" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        [TestCase(TransportType.AmqpTcp)]
        [TestCase(TransportType.AmqpWebSockets)]
        public async Task ConsumerWithOptionsCanReceive(TransportType transportType)
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);
                var options = new EventHubConsumerOptions { Identifier = "FakeIdentifier" };

                await using (var client = new EventHubClient(connectionString, new EventHubClientOptions { TransportType = transportType }))
                {
                    var partition = (await client.GetPartitionIdsAsync()).First();

                    await using (EventHubConsumer consumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partition, EventPosition.Latest, options))
                    {
                        Assert.That(async () => await consumer.ReceiveAsync(1, TimeSpan.Zero), Throws.Nothing);
                    }
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubConsumer" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task ReceiveCanReadOneEventBatchFromAnEventSet()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                EventData[] eventSet = new[]
                {
                    new EventData(Encoding.UTF8.GetBytes("One")),
                    new EventData(Encoding.UTF8.GetBytes("Two")),
                    new EventData(Encoding.UTF8.GetBytes("Three"))
                };

                await using (var client = new EventHubClient(connectionString))
                {
                    var partition = (await client.GetPartitionIdsAsync()).First();

                    await using (EventHubProducer producer = client.CreateProducer(new EventHubProducerOptions { PartitionId = partition }))
                    await using (EventHubConsumer consumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partition, EventPosition.Latest))
                    {
                        // Initiate an operation to force the consumer to connect and set its position at the
                        // end of the event stream.

                        Assert.That(async () => await consumer.ReceiveAsync(1, TimeSpan.Zero), Throws.Nothing);

                        // Send the batch of events.

                        await producer.SendAsync(eventSet);

                        // Receive the events; because there is some non-determinism in the messaging flow, the
                        // sent events may not be immediately available.  Allow for a small number of attempts to receive, in order
                        // to account for availability delays.

                        var receivedEvents = new List<EventData>();
                        var index = 0;

                        while ((receivedEvents.Count < eventSet.Length) && (++index < ReceiveRetryLimit))
                        {
                            receivedEvents.AddRange(await consumer.ReceiveAsync(eventSet.Length + 10, TimeSpan.FromMilliseconds(25)));
                        }

                        // Validate the events; once nulls have been removed, they should have been received in the order they were added to the batch.
                        // Because there's a custom equality check, the built-in collection comparison is not adequate.

                        index = 0;

                        Assert.That(receivedEvents, Is.Not.Empty, "There should have been a set of events received.");

                        foreach (EventData receivedEvent in receivedEvents)
                        {
                            Assert.That(receivedEvent.IsEquivalentTo(eventSet[index]), Is.True, $"The received event at index: { index } did not match the sent batch.");
                            ++index;
                        }

                        Assert.That(index, Is.EqualTo(eventSet.Length), "The number of received events did not match the batch size.");
                    }
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubConsumer" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task ReceiveCanReadOneEventBatchFromAnEventBatch()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                EventData[] eventSet = new[]
                {
                    new EventData(Encoding.UTF8.GetBytes("One")),
                    new EventData(Encoding.UTF8.GetBytes("Two")),
                    new EventData(Encoding.UTF8.GetBytes("Three"))
                };

                await using (var client = new EventHubClient(connectionString))
                {
                    var partition = (await client.GetPartitionIdsAsync()).First();

                    await using (EventHubProducer producer = client.CreateProducer(new EventHubProducerOptions { PartitionId = partition }))
                    await using (EventHubConsumer consumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partition, EventPosition.Latest))
                    {
                        // Create the batch of events to publish.

                        using EventDataBatch eventBatch = await producer.CreateBatchAsync();

                        foreach (EventData eventData in eventSet)
                        {
                            eventBatch.TryAdd(eventData);
                        }

                        // Initiate an operation to force the consumer to connect and set its position at the
                        // end of the event stream.

                        Assert.That(async () => await consumer.ReceiveAsync(1, TimeSpan.Zero), Throws.Nothing);

                        // Send the batch of events.

                        await producer.SendAsync(eventBatch);

                        // Receive the events; because there is some non-determinism in the messaging flow, the
                        // sent events may not be immediately available.  Allow for a small number of attempts to receive, in order
                        // to account for availability delays.

                        var receivedEvents = new List<EventData>();
                        var index = 0;

                        while ((receivedEvents.Count < eventBatch.Count) && (++index < ReceiveRetryLimit))
                        {
                            receivedEvents.AddRange(await consumer.ReceiveAsync(eventBatch.Count + 10, TimeSpan.FromMilliseconds(25)));
                        }

                        // Validate the events; once nulls have been removed, they should have been received in the order they were added to the batch.
                        // Because there's a custom equality check, the built-in collection comparison is not adequate.

                        index = 0;

                        Assert.That(receivedEvents, Is.Not.Empty, "There should have been a set of events received.");

                        foreach (EventData receivedEvent in receivedEvents)
                        {
                            Assert.That(receivedEvent.IsEquivalentTo(eventSet[index]), Is.True, $"The received event at index: { index } did not match the sent batch.");
                            ++index;
                        }

                        Assert.That(index, Is.EqualTo(eventBatch.Count), "The number of received events did not match the batch size.");
                    }
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubConsumer" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task ReceiveCanReadMultipleEventBatches()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                EventData[] eventSet = new[]
                {
                    new EventData(Encoding.UTF8.GetBytes("One")),
                    new EventData(Encoding.UTF8.GetBytes("Two")),
                    new EventData(Encoding.UTF8.GetBytes("Three")),
                    new EventData(Encoding.UTF8.GetBytes("Four")),
                    new EventData(Encoding.UTF8.GetBytes("Five")),
                    new EventData(Encoding.UTF8.GetBytes("Six")),
                    new EventData(Encoding.UTF8.GetBytes("Seven")),
                    new EventData(Encoding.UTF8.GetBytes("Eight")),
                    new EventData(Encoding.UTF8.GetBytes("Nine")),
                    new EventData(Encoding.UTF8.GetBytes("Ten")),
                    new EventData(Encoding.UTF8.GetBytes("Eleven")),
                    new EventData(Encoding.UTF8.GetBytes("Twelve")),
                    new EventData(Encoding.UTF8.GetBytes("Thirteen")),
                    new EventData(Encoding.UTF8.GetBytes("Fourteen")),
                    new EventData(Encoding.UTF8.GetBytes("Fifteen"))
                };

                await using (var client = new EventHubClient(connectionString))
                {
                    var partition = (await client.GetPartitionIdsAsync()).First();

                    await using (EventHubProducer producer = client.CreateProducer(new EventHubProducerOptions { PartitionId = partition }))
                    await using (EventHubConsumer consumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partition, EventPosition.Latest))
                    {
                        // Create the batch of events to publish.

                        using EventDataBatch eventBatch = await producer.CreateBatchAsync();

                        foreach (EventData eventData in eventSet)
                        {
                            if (!eventBatch.TryAdd(eventData))
                            {
                                Assert.Fail("All of the events could not be added to the batch.");
                            }
                        }

                        // Initiate an operation to force the consumer to connect and set its position at the
                        // end of the event stream.

                        Assert.That(async () => await consumer.ReceiveAsync(1, TimeSpan.Zero), Throws.Nothing);

                        // Send the batch of events, receive and validate them.

                        await producer.SendAsync(eventBatch);

                        // Receive the events; because there is some non-determinism in the messaging flow, the
                        // sent events may not be immediately available.  Allow for a small number of attempts to receive, in order
                        // to account for availability delays.

                        var receivedEvents = new List<EventData>();
                        var index = 0;
                        var batchNumber = 1;
                        var setSize = (eventSet.Length / 3);

                        while ((receivedEvents.Count < eventSet.Length) && (++index < eventSet.Length + ReceiveRetryLimit))
                        {
                            IEnumerable<EventData> currentReceiveBatch = await consumer.ReceiveAsync(setSize, TimeSpan.FromMilliseconds(25));
                            receivedEvents.AddRange(currentReceiveBatch);

                            Assert.That(currentReceiveBatch, Is.Not.Empty, $"There should have been a set of events received for batch number: { batchNumber }.");

                            ++batchNumber;
                        }

                        // Validate the events; once nulls have been removed, they should have been received in the order they were added to the batch.
                        // Because there's a custom equality check, the built-in collection comparison is not adequate.

                        index = 0;

                        foreach (EventData receivedEvent in receivedEvents)
                        {
                            Assert.That(receivedEvent.IsEquivalentTo(eventSet[index]), Is.True, $"The received event at index: { index } did not match the sent batch.");
                            ++index;
                        }

                        Assert.That(index, Is.EqualTo(eventSet.Length), "The number of received events did not match the batch size.");
                    }
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubConsumer" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task ReceiveCanReadSingleEvent()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                EventData[] eventBatch = new[]
                {
                    new EventData(Encoding.UTF8.GetBytes("Lonely"))
                };

                await using (var client = new EventHubClient(connectionString))
                {
                    var partition = (await client.GetPartitionIdsAsync()).First();

                    await using (EventHubProducer producer = client.CreateProducer(new EventHubProducerOptions { PartitionId = partition }))
                    await using (EventHubConsumer consumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partition, EventPosition.Latest))
                    {
                        // Initiate an operation to force the consumer to connect and set its position at the
                        // end of the event stream.

                        Assert.That(async () => await consumer.ReceiveAsync(1, TimeSpan.Zero), Throws.Nothing);

                        // Send the batch of events.

                        await producer.SendAsync(eventBatch);

                        // Receive the events; because there is some non-determinism in the messaging flow, the
                        // sent events may not be immediately available.  Allow for a small number of attempts to receive, in order
                        // to account for availability delays.

                        var receivedEvents = new List<EventData>();
                        var index = 0;

                        while ((receivedEvents.Count < eventBatch.Length) && (++index < ReceiveRetryLimit))
                        {
                            receivedEvents.AddRange(await consumer.ReceiveAsync(eventBatch.Length + 10, TimeSpan.FromMilliseconds(25)));
                        }

                        // Validate the events; once nulls have been removed, they should have been received in the order they were added to the batch.
                        // Because there's a custom equality check, the built-in collection comparison is not adequate.

                        index = 0;

                        foreach (EventData receivedEvent in receivedEvents)
                        {
                            Assert.That(receivedEvent.IsEquivalentTo(eventBatch[index]), Is.True, $"The received event at index: { index } did not match the sent batch.");
                            ++index;
                        }

                        Assert.That(index, Is.EqualTo(eventBatch.Length), "The number of received events did not match the batch size.");
                    }
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubConsumer" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task ReceiveCanReadSingleZeroLengthEvent()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                EventData[] eventBatch = new[]
                {
                    new EventData(new byte[0])
                };

                await using (var client = new EventHubClient(connectionString))
                {
                    var partition = (await client.GetPartitionIdsAsync()).First();

                    await using (EventHubProducer producer = client.CreateProducer(new EventHubProducerOptions { PartitionId = partition }))
                    await using (EventHubConsumer consumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partition, EventPosition.Latest))
                    {
                        // Initiate an operation to force the consumer to connect and set its position at the
                        // end of the event stream.

                        Assert.That(async () => await consumer.ReceiveAsync(1, TimeSpan.Zero), Throws.Nothing);

                        // Send the batch of events.

                        await producer.SendAsync(eventBatch);

                        // Receive the events; because there is some non-determinism in the messaging flow, the
                        // sent events may not be immediately available.  Allow for a small number of attempts to receive, in order
                        // to account for availability delays.

                        var receivedEvents = new List<EventData>();
                        var index = 0;

                        while ((receivedEvents.Count < eventBatch.Length) && (++index < ReceiveRetryLimit))
                        {
                            receivedEvents.AddRange(await consumer.ReceiveAsync(eventBatch.Length + 10, TimeSpan.FromMilliseconds(25)));
                        }

                        // Validate the events; once nulls have been removed, they should have been received in the order they were added to the batch.
                        // Because there's a custom equality check, the built-in collection comparison is not adequate.

                        index = 0;

                        foreach (EventData receivedEvent in receivedEvents)
                        {
                            Assert.That(receivedEvent.IsEquivalentTo(eventBatch[index]), Is.True, $"The received event at index: { index } did not match the sent batch.");
                            ++index;
                        }

                        Assert.That(index, Is.EqualTo(eventBatch.Length), "The number of received events did not match the batch size.");
                    }
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubConsumer" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task ReceiveCanReadOneZeroLengthEventSet()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                EventData[] eventSet = new[]
                {
                    new EventData(new byte[0]),
                    new EventData(new byte[0]),
                    new EventData(new byte[0])
                };

                await using (var client = new EventHubClient(connectionString))
                {
                    var partition = (await client.GetPartitionIdsAsync()).First();

                    await using (EventHubProducer producer = client.CreateProducer(new EventHubProducerOptions { PartitionId = partition }))
                    await using (EventHubConsumer consumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partition, EventPosition.Latest))
                    {
                        // Initiate an operation to force the consumer to connect and set its position at the
                        // end of the event stream.

                        Assert.That(async () => await consumer.ReceiveAsync(1, TimeSpan.Zero), Throws.Nothing);

                        // Send the set of events.

                        await producer.SendAsync(eventSet);

                        // Receive the events; because there is some non-determinism in the messaging flow, the
                        // sent events may not be immediately available.  Allow for a small number of attempts to receive, in order
                        // to account for availability delays.

                        var receivedEvents = new List<EventData>();
                        var index = 0;

                        while ((receivedEvents.Count < eventSet.Length) && (++index < ReceiveRetryLimit))
                        {
                            receivedEvents.AddRange(await consumer.ReceiveAsync(eventSet.Length + 10, TimeSpan.FromMilliseconds(25)));
                        }

                        // Validate the events; once nulls have been removed, they should have been received in the order they were added to the batch.
                        // Because there's a custom equality check, the built-in collection comparison is not adequate.

                        index = 0;

                        Assert.That(receivedEvents, Is.Not.Empty, "There should have been a set of events received.");

                        foreach (EventData receivedEvent in receivedEvents)
                        {
                            Assert.That(receivedEvent.IsEquivalentTo(eventSet[index]), Is.True, $"The received event at index: { index } did not match the sent batch.");
                            ++index;
                        }

                        Assert.That(index, Is.EqualTo(eventSet.Length), "The number of received events did not match the batch size.");
                    }
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubConsumer" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task ReceiveCanReadLargeEvent()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                // The actual limit is 1046520 for a single event

                EventData[] eventBatch = new[]
                {
                    new EventData(new byte[100000])
                };

                await using (var client = new EventHubClient(connectionString, new EventHubClientOptions { RetryOptions = new RetryOptions { TryTimeout = TimeSpan.FromMinutes(5) } }))
                {
                    var partition = (await client.GetPartitionIdsAsync()).First();

                    await using (EventHubProducer producer = client.CreateProducer(new EventHubProducerOptions { PartitionId = partition }))
                    await using (EventHubConsumer consumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partition, EventPosition.Latest))
                    {
                        // Initiate an operation to force the consumer to connect and set its position at the
                        // end of the event stream.

                        Assert.That(async () => await consumer.ReceiveAsync(1, TimeSpan.Zero), Throws.Nothing);

                        // Send the batch of events.

                        await producer.SendAsync(eventBatch);

                        // A short delay is necessary to persist the large event.

                        await Task.Delay(TimeSpan.FromSeconds(5));

                        // Receive the events; because there is some non-determinism in the messaging flow, the
                        // sent events may not be immediately available.  Allow for a small number of attempts to receive, in order
                        // to account for availability delays.

                        var receivedEvents = new List<EventData>();
                        var index = 0;

                        while ((receivedEvents.Count < eventBatch.Length) && (++index < ReceiveRetryLimit))
                        {
                            receivedEvents.AddRange(await consumer.ReceiveAsync(eventBatch.Length + 10, TimeSpan.FromMilliseconds(500)));
                        }

                        // Validate the events; once nulls have been removed, they should have been received in the order they were added to the batch.
                        // Because there's a custom equality check, the built-in collection comparison is not adequate.

                        index = 0;

                        foreach (EventData receivedEvent in receivedEvents)
                        {
                            Assert.That(receivedEvent.IsEquivalentTo(eventBatch[index]), Is.True, $"The received event at index: { index } did not match the sent batch.");
                            ++index;
                        }

                        Assert.That(index, Is.EqualTo(eventBatch.Length), "The number of received events did not match the batch size.");
                    }
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubConsumer" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task ReceiveCanReadEventWithCustomProperties()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                EventData[] eventBatch = new[]
                {
                    new EventData(new byte[] { 0x22, 0x33 }),
                    new EventData(Encoding.UTF8.GetBytes("This is a really long string of stuff that I wanted to type because I like to")),
                    new EventData(Encoding.UTF8.GetBytes("I wanted to type because I like to")),
                    new EventData(Encoding.UTF8.GetBytes("If you are reading this, you really like test cases"))
                };

                for (var index = 0; index < eventBatch.Length; ++index)
                {
                    eventBatch[index].Properties[index.ToString()] = "some value";
                    eventBatch[index].Properties["Type"] = $"com.microsoft.test.Type{ index }";
                }

                await using (var client = new EventHubClient(connectionString))
                {
                    var partition = (await client.GetPartitionIdsAsync()).First();

                    await using (EventHubProducer producer = client.CreateProducer(new EventHubProducerOptions { PartitionId = partition }))
                    await using (EventHubConsumer consumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partition, EventPosition.Latest))
                    {
                        // Initiate an operation to force the consumer to connect and set its position at the
                        // end of the event stream.

                        Assert.That(async () => await consumer.ReceiveAsync(1, TimeSpan.Zero), Throws.Nothing);

                        // Send the batch of events.

                        await producer.SendAsync(eventBatch);

                        // Receive the events; because there is some non-determinism in the messaging flow, the
                        // sent events may not be immediately available.  Allow for a small number of attempts to receive, in order
                        // to account for availability delays.

                        var receivedEvents = new List<EventData>();
                        var index = 0;

                        while ((receivedEvents.Count < eventBatch.Length) && (++index < ReceiveRetryLimit))
                        {
                            receivedEvents.AddRange(await consumer.ReceiveAsync(eventBatch.Length + 10, TimeSpan.FromMilliseconds(25)));
                        }

                        // Validate the events; once nulls have been removed, they should have been received in the order they were added to the batch.
                        // Because there's a custom equality check, the built-in collection comparison is not adequate.

                        index = 0;

                        foreach (EventData receivedEvent in receivedEvents)
                        {
                            Assert.That(receivedEvent.IsEquivalentTo(eventBatch[index]), Is.True, $"The received event at index: { index } did not match the sent batch.");
                            ++index;
                        }

                        Assert.That(index, Is.EqualTo(eventBatch.Length), "The number of received events did not match the batch size.");
                    }
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubConsumer" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task ConsumerCanReceiveFromLatestEvent()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var client = new EventHubClient(connectionString))
                {
                    var partition = (await client.GetPartitionIdsAsync()).First();

                    await using (EventHubConsumer consumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partition, EventPosition.Latest))
                    await using (EventHubProducer producer = client.CreateProducer(new EventHubProducerOptions { PartitionId = partition }))
                    {
                        // Sending some events beforehand so the partition has some information.
                        // We are not expecting to receive these.

                        for (int i = 0; i < 10; i++)
                        {
                            await producer.SendAsync(new EventData(new byte[1]));
                        }

                        // Initiate an operation to force the consumer to connect and set its position at the
                        // end of the event stream.

                        Assert.That(async () => await consumer.ReceiveAsync(1, TimeSpan.Zero), Throws.Nothing);

                        // Send a single event.

                        var stampEvent = new EventData(new byte[1]);
                        stampEvent.Properties["stamp"] = Guid.NewGuid().ToString();

                        await producer.SendAsync(stampEvent);

                        // Receive and validate the events; because there is some non-determinism in the messaging flow, the
                        // sent events may not be immediately available.  Allow for a small number of attempts to receive, in order
                        // to account for availability delays.

                        var expectedEventsCount = 1;
                        var receivedEvents = new List<EventData>();
                        var index = 0;

                        while ((receivedEvents.Count < expectedEventsCount) && (++index < ReceiveRetryLimit))
                        {
                            receivedEvents.AddRange(await consumer.ReceiveAsync(expectedEventsCount + 10, TimeSpan.FromMilliseconds(25)));
                        }

                        Assert.That(receivedEvents.Count, Is.EqualTo(expectedEventsCount), $"The number of received events should be { expectedEventsCount }.");
                        Assert.That(receivedEvents.Single().IsEquivalentTo(stampEvent), Is.True, "The received event did not match the sent event.");

                        // Next receive on this partition shouldn't return any more messages.

                        Assert.That(await consumer.ReceiveAsync(10, TimeSpan.FromSeconds(2)), Is.Empty);
                    }
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubConsumer" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task ConsumerCanReceiveFromEarliestEvent()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var client = new EventHubClient(connectionString))
                {
                    var partition = (await client.GetPartitionIdsAsync()).First();

                    await using (EventHubConsumer consumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partition, EventPosition.Earliest))
                    await using (EventHubProducer producer = client.CreateProducer(new EventHubProducerOptions { PartitionId = partition }))
                    {
                        // Sending some events beforehand so the partition has some information.

                        var expectedEventsCount = 10;

                        for (int i = 0; i < expectedEventsCount; i++)
                        {
                            await producer.SendAsync(new EventData(new byte[1]));
                        }

                        // Receive and validate the events; because there is some non-determinism in the messaging flow, the
                        // sent events may not be immediately available.  Allow for a small number of attempts to receive, in order
                        // to account for availability delays.

                        var receivedEvents = new List<EventData>();
                        var index = 0;

                        while ((receivedEvents.Count < expectedEventsCount) && (++index < ReceiveRetryLimit))
                        {
                            receivedEvents.AddRange(await consumer.ReceiveAsync(expectedEventsCount + 10, TimeSpan.FromMilliseconds(25)));
                        }

                        Assert.That(receivedEvents.Count, Is.EqualTo(expectedEventsCount), $"The number of received events should be { expectedEventsCount }.");
                    }
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubConsumer" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task ConsumerCanReceiveFromOffset()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var client = new EventHubClient(connectionString))
                {
                    var partition = (await client.GetPartitionIdsAsync()).First();

                    await using (EventHubProducer producer = client.CreateProducer(new EventHubProducerOptions { PartitionId = partition }))
                    {
                        // Sending some events beforehand so the partition has some information.

                        for (var i = 0; i < 10; i++)
                        {
                            await producer.SendAsync(new EventData(new byte[1]));
                        }

                        // Store last enqueued offset.

                        var offset = (await client.GetPartitionPropertiesAsync(partition)).LastEnqueuedOffset;

                        await using (EventHubConsumer consumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partition, EventPosition.FromOffset(offset)))
                        {
                            // Send a single event which is expected to go to the end of stream.

                            var stampEvent = new EventData(new byte[1]);
                            stampEvent.Properties["stamp"] = Guid.NewGuid().ToString();

                            await producer.SendAsync(stampEvent);

                            // Receive and validate the events; because there is some non-determinism in the messaging flow, the
                            // sent events may not be immediately available.  Allow for a small number of attempts to receive, in order
                            // to account for availability delays.

                            var expectedEventsCount = 2;
                            var receivedEvents = new List<EventData>();
                            var index = 0;

                            while ((receivedEvents.Count < expectedEventsCount) && (++index < ReceiveRetryLimit))
                            {
                                receivedEvents.AddRange(await consumer.ReceiveAsync(expectedEventsCount + 10, TimeSpan.FromMilliseconds(25)));
                            }

                            Assert.That(receivedEvents.Count, Is.EqualTo(expectedEventsCount), $"The number of received events should be { expectedEventsCount }.");
                            Assert.That(receivedEvents.Last().IsEquivalentTo(stampEvent), Is.True, "The received event did not match the sent event.");

                            // Next receive on this partition shouldn't return any more messages.

                            Assert.That(await consumer.ReceiveAsync(10, TimeSpan.FromSeconds(2)), Is.Empty);
                        }
                    }
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubConsumer" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task ConsumerCanReceiveFromEnqueuedTime()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var client = new EventHubClient(connectionString))
                {
                    var partition = (await client.GetPartitionIdsAsync()).First();

                    await using (EventHubProducer producer = client.CreateProducer(new EventHubProducerOptions { PartitionId = partition }))
                    {
                        // Sending some events beforehand so the partition has some information.

                        for (var i = 0; i < 10; i++)
                        {
                            await producer.SendAsync(new EventData(new byte[1]));
                        }

                        // Store last enqueued time.

                        DateTimeOffset enqueuedTime = (await client.GetPartitionPropertiesAsync(partition)).LastEnqueuedTime;

                        await using (EventHubConsumer consumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partition, EventPosition.FromEnqueuedTime(enqueuedTime)))
                        {
                            // Send a single event which is expected to go to the end of stream.
                            // We are expecting to receive only this message.

                            var stampEvent = new EventData(new byte[1]);
                            stampEvent.Properties["stamp"] = Guid.NewGuid().ToString();

                            await producer.SendAsync(stampEvent);

                            // Receive and validate the events; because there is some non-determinism in the messaging flow, the
                            // sent events may not be immediately available.  Allow for a small number of attempts to receive, in order
                            // to account for availability delays.

                            var expectedEventsCount = 1;
                            var receivedEvents = new List<EventData>();
                            var index = 0;

                            while ((receivedEvents.Count < expectedEventsCount) && (++index < ReceiveRetryLimit))
                            {
                                receivedEvents.AddRange(await consumer.ReceiveAsync(expectedEventsCount + 10, TimeSpan.FromMilliseconds(25)));
                            }

                            Assert.That(receivedEvents.Count, Is.EqualTo(expectedEventsCount), $"The number of received events should be { expectedEventsCount }.");
                            Assert.That(receivedEvents.Single().IsEquivalentTo(stampEvent), Is.True, "The received event did not match the sent event.");

                            // Next receive on this partition shouldn't return any more messages.

                            Assert.That(await consumer.ReceiveAsync(10, TimeSpan.FromSeconds(2)), Is.Empty);
                        }
                    }
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubConsumer" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        [TestCase(true)]
        [TestCase(false)]
        public async Task ConsumerCanReceiveFromSequenceNumber(bool isInclusive)
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var client = new EventHubClient(connectionString))
                {
                    var partition = (await client.GetPartitionIdsAsync()).First();

                    await using (EventHubProducer producer = client.CreateProducer(new EventHubProducerOptions { PartitionId = partition }))
                    {
                        // Sending some events beforehand so the partition has some information.

                        for (var i = 0; i < 10; i++)
                        {
                            await producer.SendAsync(new EventData(new byte[1]));
                        }

                        // Store last enqueued sequence number.

                        var sequenceNumber = (await client.GetPartitionPropertiesAsync(partition)).LastEnqueuedSequenceNumber;

                        await using (EventHubConsumer consumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partition, EventPosition.FromSequenceNumber(sequenceNumber, isInclusive)))
                        {
                            // Send a single event which is expected to go to the end of stream.

                            var stampEvent = new EventData(new byte[1]);
                            stampEvent.Properties["stamp"] = Guid.NewGuid().ToString();

                            await producer.SendAsync(stampEvent);

                            // Receive and validate the events; because there is some non-determinism in the messaging flow, the
                            // sent events may not be immediately available.  Allow for a small number of attempts to receive, in order
                            // to account for availability delays.

                            var expectedEventsCount = isInclusive ? 2 : 1;
                            var receivedEvents = new List<EventData>();
                            var index = 0;

                            while ((receivedEvents.Count < expectedEventsCount) && (++index < ReceiveRetryLimit))
                            {
                                receivedEvents.AddRange(await consumer.ReceiveAsync(expectedEventsCount + 10, TimeSpan.FromMilliseconds(25)));
                            }

                            Assert.That(receivedEvents.Count, Is.EqualTo(expectedEventsCount), $"The number of received events should be { expectedEventsCount }.");
                            Assert.That(receivedEvents.Last().IsEquivalentTo(stampEvent), Is.True, "The received event did not match the sent event.");

                            // Next receive on this partition shouldn't return any more messages.

                            Assert.That(await consumer.ReceiveAsync(10, TimeSpan.FromSeconds(2)), Is.Empty);
                        }
                    }
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubConsumer" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task ConsumerCanReceivePartitionMetrics()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);
                var consumerOptions = new EventHubConsumerOptions { TrackLastEnqueuedEventInformation = true };

                EventData[] eventSet = new[]
                {
                    new EventData(Encoding.UTF8.GetBytes("One")),
                    new EventData(Encoding.UTF8.GetBytes("Two")),
                    new EventData(Encoding.UTF8.GetBytes("Three"))
                };

                await using (var client = new EventHubClient(connectionString))
                {
                    var partition = (await client.GetPartitionIdsAsync()).First();

                    await using (EventHubProducer producer = client.CreateProducer(new EventHubProducerOptions { PartitionId = partition }))
                    await using (EventHubConsumer consumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partition, EventPosition.Latest, consumerOptions))
                    {
                        // Initiate an operation to force the consumer to connect and set its position at the
                        // end of the event stream.

                        Assert.That(async () => await consumer.ReceiveAsync(1, TimeSpan.Zero), Throws.Nothing);

                        // Send the batch of events.

                        await producer.SendAsync(eventSet);

                        // Receive the events; because there is some non-determinism in the messaging flow, the
                        // sent events may not be immediately available.  Allow for a small number of attempts to receive, in order
                        // to account for availability delays.

                        var receivedEvents = new List<EventData>();
                        var index = 0;

                        while ((receivedEvents.Count < eventSet.Length) && (++index < ReceiveRetryLimit))
                        {
                            receivedEvents.AddRange(await consumer.ReceiveAsync(eventSet.Length + 10, TimeSpan.FromMilliseconds(25)));
                        }

                        // Validate the partition metrics were received and populated.

                        Assert.That(receivedEvents, Is.Not.Empty, "There should have been a set of events received.");

                        var currentMetrics = consumer.ReadLastEnqueuedEventInformation();
                        Assert.That(currentMetrics, Is.Not.Null, "There should be a partition metrics instance.");
                        Assert.That(currentMetrics.LastEnqueuedSequenceNumber.HasValue, Is.True, "There should be a last sequence number populated.");
                        Assert.That(currentMetrics.LastEnqueuedOffset.HasValue, Is.True, "There should be a last offset populated.");
                        Assert.That(currentMetrics.LastEnqueuedTime.HasValue, Is.True, "There should be a last enqueued time populated.");
                        Assert.That(currentMetrics.InformationReceived.HasValue, Is.True, "There should be a last update time populated.");

                        // Capture the metrics update time for comparison against the second batch in order to
                        // ensure that metrics are updated each time events are received.  Pause for a moment to
                        // be sure that receiving has some delta in time stamp.

                        var previousMetrics = new LastEnqueuedEventProperties(
                            currentMetrics.EventHubName,
                            currentMetrics.PartitionId,
                            currentMetrics.LastEnqueuedSequenceNumber,
                            currentMetrics.LastEnqueuedOffset,
                            currentMetrics.LastEnqueuedTime,
                            currentMetrics.InformationReceived);

                        await Task.Delay(TimeSpan.FromSeconds(15));

                        // Send another batch of events and receive them.

                        await producer.SendAsync(eventSet);

                        receivedEvents.Clear();
                        index = 0;

                        while ((receivedEvents.Count < eventSet.Length) && (++index < ReceiveRetryLimit))
                        {
                            receivedEvents.AddRange(await consumer.ReceiveAsync(eventSet.Length + 10, TimeSpan.FromMilliseconds(25)));
                        }

                        // Validate that metrics have been updated or remain stable.

                        Assert.That(receivedEvents, Is.Not.Empty, "There should have been a set of events received.");

                        currentMetrics = consumer.ReadLastEnqueuedEventInformation();
                        Assert.That(currentMetrics, Is.Not.Null, "There should be a partition metrics instance.");
                        Assert.That(currentMetrics.LastEnqueuedSequenceNumber.Value, Is.Not.EqualTo(previousMetrics.LastEnqueuedSequenceNumber), "The last sequence number should have been updated.");
                        Assert.That(currentMetrics.LastEnqueuedOffset.Value, Is.Not.EqualTo(previousMetrics.LastEnqueuedOffset), "The last offset should have been updated.");
                        Assert.That(currentMetrics.LastEnqueuedTime.Value, Is.Not.EqualTo(previousMetrics.LastEnqueuedTime), "The last enqueue time should have been updated.");
                        Assert.That(currentMetrics.InformationReceived.Value, Is.GreaterThan(previousMetrics.InformationReceived), "The last update time should have been incremented.");
                    }
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubConsumer" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task ConsumerReceivesSystemProperties()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                EventData[] eventSet = new[]
                {
                    new EventData(Encoding.UTF8.GetBytes("One")),
                    new EventData(Encoding.UTF8.GetBytes("Two")),
                    new EventData(Encoding.UTF8.GetBytes("Three"))
                };

                await using (var client = new EventHubClient(connectionString))
                {
                    var partition = (await client.GetPartitionIdsAsync()).First();

                    await using (EventHubProducer producer = client.CreateProducer(new EventHubProducerOptions { PartitionId = partition }))
                    await using (EventHubConsumer consumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partition, EventPosition.Latest))
                    {
                        // Initiate an operation to force the consumer to connect and set its position at the
                        // end of the event stream.

                        Assert.That(async () => await consumer.ReceiveAsync(1, TimeSpan.Zero), Throws.Nothing);

                        // Send the batch of events.

                        await producer.SendAsync(eventSet);

                        // Receive the events; because there is some non-determinism in the messaging flow, the
                        // sent events may not be immediately available.  Allow for a small number of attempts to receive, in order
                        // to account for availability delays.

                        var receivedEvents = new List<EventData>();
                        var index = 0;

                        while ((receivedEvents.Count < eventSet.Length) && (++index < ReceiveRetryLimit))
                        {
                            receivedEvents.AddRange(await consumer.ReceiveAsync(eventSet.Length + 10, TimeSpan.FromMilliseconds(25)));
                        }

                        // Validate the partition metrics were received and populated.

                        Assert.That(receivedEvents, Is.Not.Empty, "There should have been a set of events received.");
                        Assert.That(receivedEvents[0].SequenceNumber.HasValue, Is.True, "There should be a sequence number populated.");
                        Assert.That(receivedEvents[0].Offset.HasValue, Is.True, "There should be an offset populated.");
                        Assert.That(receivedEvents[0].EnqueuedTime.HasValue, Is.True, "There should be an enqueued time populated.");
                    }
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubConsumer" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task SubscribeCanReceiveEventsFromTheEnumerable()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                EventData[] eventSet = new[]
                {
                    new EventData(Encoding.UTF8.GetBytes("One")),
                    new EventData(Encoding.UTF8.GetBytes("Two")),
                    new EventData(Encoding.UTF8.GetBytes("Three")),
                    new EventData(Encoding.UTF8.GetBytes("Four")),
                    new EventData(Encoding.UTF8.GetBytes("Five")),
                    new EventData(Encoding.UTF8.GetBytes("Six")),
                    new EventData(Encoding.UTF8.GetBytes("Seven")),
                    new EventData(Encoding.UTF8.GetBytes("Eight")),
                    new EventData(Encoding.UTF8.GetBytes("Nine")),
                    new EventData(Encoding.UTF8.GetBytes("Ten")),
                    new EventData(Encoding.UTF8.GetBytes("Eleven")),
                    new EventData(Encoding.UTF8.GetBytes("Twelve")),
                    new EventData(Encoding.UTF8.GetBytes("Thirteen")),
                    new EventData(Encoding.UTF8.GetBytes("Fourteen")),
                    new EventData(Encoding.UTF8.GetBytes("Fifteen"))
                };

                await using (var client = new EventHubClient(connectionString))
                {
                    var partition = (await client.GetPartitionIdsAsync()).First();

                    await using (EventHubProducer producer = client.CreateProducer(new EventHubProducerOptions { PartitionId = partition }))
                    await using (EventHubConsumer consumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partition, EventPosition.Earliest))
                    {
                        // Create the batch of events to publish.

                        using EventDataBatch eventBatch = await producer.CreateBatchAsync();

                        foreach (EventData eventData in eventSet)
                        {
                            if (!eventBatch.TryAdd(eventData))
                            {
                                Assert.Fail("All of the events could not be added to the batch.");
                            }
                        }

                        // Send the batch of events, receive and validate them.

                        await producer.SendAsync(eventBatch);

                        // Receive the events; when there have been multiple consecutive empty events emitted due to
                        // exceeding the maximum wait time, assume the batch is complete and terminate.

                        var consecutiveEmpties = 0;
                        var maximumWaitTime = TimeSpan.FromMilliseconds(50);
                        var receivedEvents = new List<EventData>();

                        using var cancellation = new CancellationTokenSource(TimeSpan.FromSeconds(90));

                        await foreach (EventData receivedEvent in consumer.SubscribeToEvents(maximumWaitTime, cancellation.Token))
                        {
                            receivedEvents.Add(receivedEvent);
                            consecutiveEmpties = (receivedEvent == null) ? consecutiveEmpties + 1 : 0;

                            // Stop iterating if there have been too many consecutive empty emits; that is
                            // a sign that the partition is empty.

                            if (consecutiveEmpties > 15)
                            {
                                break;
                            }
                            else if (consecutiveEmpties % 5 == 0)
                            {
                                // If we have a smaller number of consecutive empty emits, then pause for a moment to
                                // account for the non-determinism of availability after an event was published.

                                await Task.Delay(TimeSpan.FromSeconds(0.5)).ConfigureAwait(false);
                            }
                        }

                        Assert.That(cancellation.IsCancellationRequested, Is.False, "The iteration should have completed normally.");
                        Assert.That(receivedEvents.Count, Is.AtLeast(eventSet.Length), "The number of received events should be at least the number of events sent.");

                        // Validate the events; once nulls have been removed, they should have been received in the order they were added to the batch.
                        // Because there's a custom equality check, the built-in collection comparison is not adequate.

                        var index = 0;
                        receivedEvents = receivedEvents.Where(item => item != null).ToList();

                        foreach (EventData receivedEvent in receivedEvents)
                        {
                            Assert.That(receivedEvent.IsEquivalentTo(eventSet[index]), Is.True, $"The received event at index: { index } did not match the sent batch.");
                            ++index;
                        }

                        Assert.That(index, Is.EqualTo(eventSet.Length), "The number of received events did not match the batch size.");
                    }
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubConsumer" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task SubscribeCanReceiveBatchedEventsFromTheEnumerable()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                EventData[] firstEvents = new[]
                {
                    new EventData(Encoding.UTF8.GetBytes("One")),
                    new EventData(Encoding.UTF8.GetBytes("Two")),
                    new EventData(Encoding.UTF8.GetBytes("Three")),
                    new EventData(Encoding.UTF8.GetBytes("Four")),
                    new EventData(Encoding.UTF8.GetBytes("Five")),
                    new EventData(Encoding.UTF8.GetBytes("Six")),
                    new EventData(Encoding.UTF8.GetBytes("Seven")),
                    new EventData(Encoding.UTF8.GetBytes("Eight"))
                };

                EventData[] secondEvents = new[]
                {
                    new EventData(Encoding.UTF8.GetBytes("Nine")),
                    new EventData(Encoding.UTF8.GetBytes("Ten")),
                    new EventData(Encoding.UTF8.GetBytes("Eleven")),
                    new EventData(Encoding.UTF8.GetBytes("Twelve")),
                    new EventData(Encoding.UTF8.GetBytes("Thirteen")),
                    new EventData(Encoding.UTF8.GetBytes("Fourteen")),
                    new EventData(Encoding.UTF8.GetBytes("Fifteen"))
                };

                EventData[] eventSet = firstEvents.Concat(secondEvents).ToArray();

                await using (var client = new EventHubClient(connectionString))
                {
                    var partition = (await client.GetPartitionIdsAsync()).First();

                    await using (EventHubProducer producer = client.CreateProducer(new EventHubProducerOptions { PartitionId = partition }))
                    await using (EventHubConsumer consumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partition, EventPosition.Earliest))
                    {
                        // Create the batch of events to publish.

                        using EventDataBatch firstBatch = await producer.CreateBatchAsync();
                        using EventDataBatch secondBatch = await producer.CreateBatchAsync();

                        foreach (EventData eventData in firstEvents)
                        {
                            if (!firstBatch.TryAdd(eventData))
                            {
                                Assert.Fail("All of the events could not be added to the batch.");
                            }
                        }

                        foreach (EventData eventData in secondEvents)
                        {
                            if (!secondBatch.TryAdd(eventData))
                            {
                                Assert.Fail("All of the events could not be added to the batch.");
                            }
                        }

                        // Send the batches of events, receive and validate them.

                        await producer.SendAsync(firstBatch);

                        Task secondSend = new Task(async () =>
                        {
                            await Task.Delay(15).ConfigureAwait(false);
                            await producer.SendAsync(secondBatch).ConfigureAwait(false);
                        });

                        // Receive the events; when there have been multiple consecutive empty events emitted due to
                        // exceeding the maximum wait time, assume the batch is complete and terminate.

                        var consecutiveEmpties = 0;
                        var maximumWaitTime = TimeSpan.FromMilliseconds(25);
                        var receivedEvents = new List<EventData>();

                        using var cancellation = new CancellationTokenSource(TimeSpan.FromSeconds(90));

                        await foreach (EventData receivedEvent in consumer.SubscribeToEvents(maximumWaitTime, cancellation.Token))
                        {
                            secondSend?.Start();

                            receivedEvents.Add(receivedEvent);
                            consecutiveEmpties = (receivedEvent == null) ? consecutiveEmpties + 1 : 0;

                            // Stop iterating if there have been too many consecutive empty emits; that is
                            // a sign that the partition is empty.

                            if (consecutiveEmpties > 25)
                            {
                                break;
                            }
                            else if (consecutiveEmpties % 5 == 0)
                            {
                                // If we have a smaller number of consecutive empty emits, then pause for a moment to
                                // account for the non-determinism of availability after an event was published.

                                await Task.Delay(TimeSpan.FromSeconds(0.5)).ConfigureAwait(false);
                            }

                            if (secondSend != null)
                            {
                                await secondSend.ConfigureAwait(false);
                                secondSend = null;
                            }
                        }

                        Assert.That(cancellation.IsCancellationRequested, Is.False, "The iteration should have completed normally.");
                        Assert.That(receivedEvents.Count, Is.AtLeast(eventSet.Length), "The number of received events should be at least the number of events sent.");

                        // Validate the events; once nulls have been removed, they should have been received in the order they were added to the batch.
                        // Because there's a custom equality check, the built-in collection comparison is not adequate.

                        var index = 0;
                        receivedEvents = receivedEvents.Where(item => item != null).ToList();

                        foreach (EventData receivedEvent in receivedEvents)
                        {
                            Assert.That(receivedEvent.IsEquivalentTo(eventSet[index]), Is.True, $"The received event at index: { index } did not match the sent batch.");
                            ++index;
                        }

                        Assert.That(index, Is.EqualTo(eventSet.Length), "The number of received events did not match the batch size.");
                    }
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubConsumer" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        [TestCase(true)]
        [TestCase(false)]
        public async Task ConsumerCannotReceiveWhenClosed(bool sync)
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                EventData[] eventBatch = new[] { new EventData(Encoding.UTF8.GetBytes("This message won't be sent")) };

                await using (var client = new EventHubClient(connectionString))
                {
                    var partition = (await client.GetPartitionIdsAsync()).First();

                    await using (EventHubConsumer consumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partition, EventPosition.Latest))
                    {
                        Assert.That(async () => await consumer.ReceiveAsync(1, TimeSpan.Zero), Throws.Nothing);

                        if (sync)
                        {
                            consumer.Close();
                        }
                        else
                        {
                            await consumer.CloseAsync();
                        }

                        Assert.That(async () => await consumer.ReceiveAsync(1, TimeSpan.Zero), Throws.InstanceOf<EventHubsClientClosedException>().Or.InstanceOf<ObjectDisposedException>());
                    }
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubConsumer" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        [TestCase("XYZ")]
        [TestCase("-1")]
        [TestCase("1000")]
        [TestCase("-")]
        public async Task ConsumerCannotReceiveFromInvalidPartition(string invalidPartition)
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var client = new EventHubClient(connectionString))
                await using (EventHubConsumer consumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, invalidPartition, EventPosition.Latest))
                {
                    Assert.That(async () => await consumer.ReceiveAsync(1, TimeSpan.Zero), Throws.InstanceOf<ArgumentOutOfRangeException>());
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubConsumer" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        [TestCase(1)]
        [TestCase(3)]
        [TestCase(6)]
        [TestCase(10)]
        [TestCase(20)]
        [TestCase(50)]
        public async Task ConsumerCannotReceiveMoreThanMaximumMessageCountMessages(int maximumMessageCount)
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                var eventBatch = Enumerable
                    .Range(0, 20 * maximumMessageCount)
                    .Select(index => new EventData(new byte[10]))
                    .ToList();

                await using (var client = new EventHubClient(connectionString))
                {
                    var partition = (await client.GetPartitionIdsAsync()).First();

                    await using (EventHubProducer producer = client.CreateProducer(new EventHubProducerOptions { PartitionId = partition }))
                    await using (EventHubConsumer consumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partition, EventPosition.Latest))
                    {
                        // Initiate an operation to force the consumer to connect and set its position at the
                        // end of the event stream.

                        Assert.That(async () => await consumer.ReceiveAsync(1, TimeSpan.Zero), Throws.Nothing);

                        // Send the batch of events.

                        await producer.SendAsync(eventBatch);

                        // Receive and validate the events.

                        var index = 0;

                        while (index < eventBatch.Count)
                        {
                            var receivedEvents = (await consumer.ReceiveAsync(maximumMessageCount, TimeSpan.FromSeconds(10))).ToList();
                            index += receivedEvents.Count;

                            Assert.That(receivedEvents.Count, Is.LessThanOrEqualTo(maximumMessageCount));
                        }
                    }
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubConsumer" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task ConsumerCannotReceiveFromNonExistentConsumerGroup()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var client = new EventHubClient(connectionString))
                {
                    var partition = (await client.GetPartitionIdsAsync()).First();

                    await using (EventHubConsumer consumer = client.CreateConsumer("nonExistentConsumerGroup", partition, EventPosition.Latest))
                    {
                        Assert.That(async () => await consumer.ReceiveAsync(1, TimeSpan.Zero), Throws.InstanceOf<EventHubsResourceNotFoundException>());
                    }
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubConsumer" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task NoOwnerLevelConsumerCannotStartReceiving()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var client = new EventHubClient(connectionString))
                {
                    var partition = (await client.GetPartitionIdsAsync()).First();

                    EventHubConsumer exclusiveConsumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partition, EventPosition.Latest, new EventHubConsumerOptions { OwnerLevel = 20 });

                    await exclusiveConsumer.ReceiveAsync(1, TimeSpan.FromSeconds(2));

                    EventHubConsumer nonExclusiveConsumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partition, EventPosition.Latest);

                    Assert.That(async () => await nonExclusiveConsumer.ReceiveAsync(1, TimeSpan.Zero), Throws.InstanceOf<ConsumerDisconnectedException>());
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubConsumer" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task LowerOwnerLevelConsumerCannotStartReceiving()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var client = new EventHubClient(connectionString))
                {
                    var partition = (await client.GetPartitionIdsAsync()).First();

                    EventHubConsumer higherExclusiveConsumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partition, EventPosition.Latest, new EventHubConsumerOptions { OwnerLevel = 20 });

                    await higherExclusiveConsumer.ReceiveAsync(1, TimeSpan.FromSeconds(2));

                    EventHubConsumer lowerExclusiveConsumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partition, EventPosition.Latest, new EventHubConsumerOptions { OwnerLevel = 10 });

                    Assert.That(async () => await lowerExclusiveConsumer.ReceiveAsync(1, TimeSpan.Zero), Throws.InstanceOf<ConsumerDisconnectedException>());
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubConsumer" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task LowerOrNoOwnerLevelConsumerCanStartReceivingFromOtherPartitions()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(3))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var client = new EventHubClient(connectionString))
                {
                    var partitionIds = await client.GetPartitionIdsAsync();

                    EventHubConsumer higherExclusiveConsumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partitionIds[0], EventPosition.Latest, new EventHubConsumerOptions { OwnerLevel = 20 });

                    await higherExclusiveConsumer.ReceiveAsync(1, TimeSpan.FromSeconds(2));

                    EventHubConsumer lowerExclusiveConsumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partitionIds[1], EventPosition.Latest, new EventHubConsumerOptions { OwnerLevel = 10 });

                    Assert.That(async () => await lowerExclusiveConsumer.ReceiveAsync(1, TimeSpan.Zero), Throws.Nothing);

                    EventHubConsumer nonExclusiveConsumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partitionIds[2], EventPosition.Latest);

                    Assert.That(async () => await nonExclusiveConsumer.ReceiveAsync(1, TimeSpan.Zero), Throws.Nothing);
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubConsumer" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task LowerOrNoOwnerLevelConsumerCanStartReceivingFromOtherConsumerGroups()
        {
            var consumerGroups = new[]
            {
                "notdefault",
                "notdefault2"
            };

            await using (EventHubScope scope = await EventHubScope.CreateAsync(1, consumerGroups))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var client = new EventHubClient(connectionString))
                {
                    var partition = (await client.GetPartitionIdsAsync()).First();

                    EventHubConsumer higherExclusiveConsumer = client.CreateConsumer(consumerGroups[0], partition, EventPosition.Latest, new EventHubConsumerOptions { OwnerLevel = 20 });

                    await higherExclusiveConsumer.ReceiveAsync(1, TimeSpan.FromSeconds(2));

                    EventHubConsumer lowerExclusiveConsumer = client.CreateConsumer(consumerGroups[1], partition, EventPosition.Latest, new EventHubConsumerOptions { OwnerLevel = 10 });

                    Assert.That(async () => await lowerExclusiveConsumer.ReceiveAsync(1, TimeSpan.Zero), Throws.Nothing);

                    EventHubConsumer nonExclusiveConsumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partition, EventPosition.Latest);

                    Assert.That(async () => await nonExclusiveConsumer.ReceiveAsync(1, TimeSpan.Zero), Throws.Nothing);
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubConsumer" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task OwnerConsumerClosesNoOwnerLevelConsumer()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var client = new EventHubClient(connectionString))
                {
                    var partition = (await client.GetPartitionIdsAsync()).First();

                    EventHubConsumer exclusiveConsumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partition, EventPosition.Latest, new EventHubConsumerOptions { OwnerLevel = 20 });
                    EventHubConsumer nonExclusiveConsumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partition, EventPosition.Latest);

                    await nonExclusiveConsumer.ReceiveAsync(1, TimeSpan.FromSeconds(2));
                    await exclusiveConsumer.ReceiveAsync(1, TimeSpan.FromSeconds(2));

                    await Task.Delay(TimeSpan.FromSeconds(5));

                    Assert.That(async () => await nonExclusiveConsumer.ReceiveAsync(1, TimeSpan.Zero), Throws.InstanceOf<ConsumerDisconnectedException>());
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubConsumer" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task OwnerConsumerClosesLowerOwnerLevelConsumer()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var client = new EventHubClient(connectionString))
                {
                    var partition = (await client.GetPartitionIdsAsync()).First();

                    EventHubConsumer higherExclusiveConsumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partition, EventPosition.Latest, new EventHubConsumerOptions { OwnerLevel = 20 });
                    EventHubConsumer lowerExclusiveConsumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partition, EventPosition.Latest, new EventHubConsumerOptions { OwnerLevel = 10 });

                    await lowerExclusiveConsumer.ReceiveAsync(1, TimeSpan.FromSeconds(2));
                    await higherExclusiveConsumer.ReceiveAsync(1, TimeSpan.FromSeconds(2));

                    await Task.Delay(TimeSpan.FromSeconds(5));

                    Assert.That(async () => await lowerExclusiveConsumer.ReceiveAsync(1, TimeSpan.Zero), Throws.InstanceOf<ConsumerDisconnectedException>());
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubConsumer" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task OwnerConsumerDoesNotCloseLowerOrNoOwnerLevelConsumersFromOtherPartitions()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(3))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var client = new EventHubClient(connectionString))
                {
                    var partitionIds = await client.GetPartitionIdsAsync();

                    EventHubConsumer higherExclusiveConsumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partitionIds[0], EventPosition.Latest, new EventHubConsumerOptions { OwnerLevel = 20 });
                    EventHubConsumer lowerExclusiveConsumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partitionIds[1], EventPosition.Latest, new EventHubConsumerOptions { OwnerLevel = 10 });
                    EventHubConsumer nonExclusiveConsumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partitionIds[2], EventPosition.Latest);

                    await nonExclusiveConsumer.ReceiveAsync(1, TimeSpan.FromSeconds(2));
                    await lowerExclusiveConsumer.ReceiveAsync(1, TimeSpan.FromSeconds(2));
                    await higherExclusiveConsumer.ReceiveAsync(1, TimeSpan.FromSeconds(2));

                    Assert.That(async () => await lowerExclusiveConsumer.ReceiveAsync(1, TimeSpan.Zero), Throws.Nothing);
                    Assert.That(async () => await nonExclusiveConsumer.ReceiveAsync(1, TimeSpan.Zero), Throws.Nothing);
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubConsumer" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task OwnerConsumerDoesNotCloseLowerOrNoOwnerLevelConsumersFromOtherConsumerGroups()
        {
            var consumerGroups = new[]
            {
                "notdefault",
                "notdefault2"
            };

            await using (EventHubScope scope = await EventHubScope.CreateAsync(1, consumerGroups))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var client = new EventHubClient(connectionString))
                {
                    var partition = (await client.GetPartitionIdsAsync()).First();

                    EventHubConsumer higherExclusiveConsumer = client.CreateConsumer(consumerGroups[0], partition, EventPosition.Latest, new EventHubConsumerOptions { OwnerLevel = 20 });
                    EventHubConsumer lowerExclusiveConsumer = client.CreateConsumer(consumerGroups[1], partition, EventPosition.Latest, new EventHubConsumerOptions { OwnerLevel = 10 });
                    EventHubConsumer nonExclusiveConsumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partition, EventPosition.Latest);

                    await higherExclusiveConsumer.ReceiveAsync(1, TimeSpan.FromSeconds(2));

                    Assert.That(async () => await lowerExclusiveConsumer.ReceiveAsync(1, TimeSpan.Zero), Throws.Nothing);
                    Assert.That(async () => await nonExclusiveConsumer.ReceiveAsync(1, TimeSpan.Zero), Throws.Nothing);
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubConsumer" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task FailingToCreateOwnerConsumerDoesNotCompromiseReceiveBehavior()
        {
            var customConsumerGroup = "anotherConsumerGroup";

            await using (EventHubScope scope = await EventHubScope.CreateAsync(2, new[] { customConsumerGroup }))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var client = new EventHubClient(connectionString))
                {
                    var partitionIds = await client.GetPartitionIdsAsync();

                    EventHubConsumer nonExclusiveConsumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partitionIds[0], EventPosition.Latest);
                    EventHubConsumer exclusiveConsumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partitionIds[0], EventPosition.Latest, new EventHubConsumerOptions { OwnerLevel = 20 });

                    await exclusiveConsumer.ReceiveAsync(1, TimeSpan.FromSeconds(2));

                    // Failing at consumer creation should not compromise future ReceiveAsync calls.

                    Assert.That(async () => await nonExclusiveConsumer.ReceiveAsync(1, TimeSpan.Zero), Throws.InstanceOf<ConsumerDisconnectedException>());

                    // It should be possible to create new valid consumers.

                    EventHubConsumer newExclusiveConsumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partitionIds[0], EventPosition.Latest, new EventHubConsumerOptions { OwnerLevel = 30 });
                    EventHubConsumer anotherPartitionConsumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partitionIds[1], EventPosition.Latest);
                    EventHubConsumer anotherConsumerGroupConsumer = client.CreateConsumer(customConsumerGroup, partitionIds[0], EventPosition.Latest);

                    Assert.That(async () => await newExclusiveConsumer.ReceiveAsync(1, TimeSpan.Zero), Throws.Nothing);
                    Assert.That(async () => await anotherPartitionConsumer.ReceiveAsync(1, TimeSpan.Zero), Throws.Nothing);
                    Assert.That(async () => await anotherConsumerGroupConsumer.ReceiveAsync(1, TimeSpan.Zero), Throws.Nothing);

                    // Proper exceptions should be thrown as well.

                    EventHubConsumer invalidPartitionConsumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, "XYZ", EventPosition.Latest);
                    EventHubConsumer invalidConsumerGroupConsumer = client.CreateConsumer("imNotAConsumerGroup", partitionIds[0], EventPosition.Latest);

                    Assert.That(async () => await nonExclusiveConsumer.ReceiveAsync(1, TimeSpan.Zero), Throws.InstanceOf<ConsumerDisconnectedException>());
                    Assert.That(async () => await invalidPartitionConsumer.ReceiveAsync(1, TimeSpan.Zero), Throws.InstanceOf<ArgumentOutOfRangeException>());
                    Assert.That(async () => await invalidConsumerGroupConsumer.ReceiveAsync(1, TimeSpan.Zero), Throws.InstanceOf<EventHubsResourceNotFoundException>());
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubConsumer" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task FailingToCreateInvalidPartitionConsumerDoesNotCompromiseReceiveBehavior()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var client = new EventHubClient(connectionString))
                {
                    var partition = (await client.GetPartitionIdsAsync()).First();

                    EventHubConsumer invalidPartitionConsumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, "XYZ", EventPosition.Latest);

                    // Failing at consumer creation should not compromise future ReceiveAsync calls.

                    Assert.That(async () => await invalidPartitionConsumer.ReceiveAsync(1, TimeSpan.Zero), Throws.InstanceOf<ArgumentOutOfRangeException>());

                    // It should be possible to create new valid consumers.

                    EventHubConsumer exclusiveConsumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partition, EventPosition.Latest, new EventHubConsumerOptions { OwnerLevel = 20 });

                    Assert.That(async () => await exclusiveConsumer.ReceiveAsync(1, TimeSpan.Zero), Throws.Nothing);

                    // Proper exceptions should be thrown as well.

                    EventHubConsumer nonExclusiveConsumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partition, EventPosition.Latest);
                    EventHubConsumer invalidConsumerGroupConsumer = client.CreateConsumer("imNotAConsumerGroup", partition, EventPosition.Latest);

                    Assert.That(async () => await nonExclusiveConsumer.ReceiveAsync(1, TimeSpan.Zero), Throws.InstanceOf<ConsumerDisconnectedException>());
                    Assert.That(async () => await invalidPartitionConsumer.ReceiveAsync(1, TimeSpan.Zero), Throws.InstanceOf<ArgumentOutOfRangeException>());
                    Assert.That(async () => await invalidConsumerGroupConsumer.ReceiveAsync(1, TimeSpan.Zero), Throws.InstanceOf<EventHubsResourceNotFoundException>());
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubConsumer" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task FailingToCreateInvalidConsumerGroupConsumerDoesNotCompromiseReceiveBehavior()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var client = new EventHubClient(connectionString))
                {
                    var partition = (await client.GetPartitionIdsAsync()).First();

                    EventHubConsumer invalidConsumerGroupConsumer = client.CreateConsumer("imNotAConsumerGroup", partition, EventPosition.Latest);

                    // Failing at consumer creation should not compromise future ReceiveAsync calls.

                    Assert.That(async () => await invalidConsumerGroupConsumer.ReceiveAsync(1, TimeSpan.Zero), Throws.InstanceOf<EventHubsResourceNotFoundException>());

                    // It should be possible to create new valid consumers.

                    EventHubConsumer exclusiveConsumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partition, EventPosition.Latest, new EventHubConsumerOptions { OwnerLevel = 20 });

                    Assert.That(async () => await exclusiveConsumer.ReceiveAsync(1, TimeSpan.Zero), Throws.Nothing);

                    // Proper exceptions should be thrown as well.

                    EventHubConsumer nonExclusiveConsumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partition, EventPosition.Latest);
                    EventHubConsumer invalidPartitionConsumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, "XYZ", EventPosition.Latest);

                    Assert.That(async () => await nonExclusiveConsumer.ReceiveAsync(1, TimeSpan.Zero), Throws.InstanceOf<ConsumerDisconnectedException>());
                    Assert.That(async () => await invalidPartitionConsumer.ReceiveAsync(1, TimeSpan.Zero), Throws.InstanceOf<ArgumentOutOfRangeException>());
                    Assert.That(async () => await invalidConsumerGroupConsumer.ReceiveAsync(1, TimeSpan.Zero), Throws.InstanceOf<EventHubsResourceNotFoundException>());
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubConsumer" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task ConsumerCannotReceiveEventsSentToAnotherPartition()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(2))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                EventData[] eventBatch = new[]
                {
                    new EventData(Encoding.UTF8.GetBytes("One")),
                    new EventData(Encoding.UTF8.GetBytes("Two")),
                    new EventData(Encoding.UTF8.GetBytes("Three"))
                };

                await using (var client = new EventHubClient(connectionString))
                {
                    var partitionIds = await client.GetPartitionIdsAsync();

                    await using (EventHubProducer producer = client.CreateProducer(new EventHubProducerOptions { PartitionId = partitionIds[0] }))
                    await using (EventHubConsumer consumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partitionIds[1], EventPosition.Latest))
                    {
                        // Initiate an operation to force the consumer to connect and set its position at the
                        // end of the event stream.

                        Assert.That(async () => await consumer.ReceiveAsync(1, TimeSpan.Zero), Throws.Nothing);

                        // Send the batches of events.

                        var batches = 3;

                        for (var batchesCount = 0; batchesCount < batches; batchesCount++)
                        {
                            await producer.SendAsync(eventBatch);
                        }

                        // Receive and validate the events; because there is some non-determinism in the messaging flow, the
                        // sent events may not be immediately available.  Allow for a small number of attempts to receive, in order
                        // to account for availability delays.

                        var receivedEvents = new List<EventData>();
                        var index = 0;

                        while (++index < ReceiveRetryLimit)
                        {
                            receivedEvents.AddRange(await consumer.ReceiveAsync(batches * eventBatch.Length + 10, TimeSpan.FromMilliseconds(25)));
                        }

                        Assert.That(receivedEvents, Is.Empty, "There should not have been a set of events received.");
                    }
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubConsumer" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task ConsumersInDifferentConsumerGroupsShouldAllReceiveEvents()
        {
            var customConsumerGroup = "anotherConsumerGroup";

            await using (EventHubScope scope = await EventHubScope.CreateAsync(1, new[] { customConsumerGroup }))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                EventData[] eventBatch = new[]
                {
                    new EventData(Encoding.UTF8.GetBytes("One")),
                    new EventData(Encoding.UTF8.GetBytes("Two")),
                    new EventData(Encoding.UTF8.GetBytes("Three"))
                };

                await using (var client = new EventHubClient(connectionString))
                {
                    var partition = (await client.GetPartitionIdsAsync()).First();

                    await using (EventHubProducer producer = client.CreateProducer(new EventHubProducerOptions { PartitionId = partition }))
                    await using (EventHubConsumer consumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partition, EventPosition.Latest))
                    await using (EventHubConsumer anotherConsumer = client.CreateConsumer(customConsumerGroup, partition, EventPosition.Latest))
                    {
                        // Initiate an operation to force the consumers to connect and set their positions at the
                        // end of the event stream.

                        Assert.That(async () => await consumer.ReceiveAsync(1, TimeSpan.Zero), Throws.Nothing);
                        Assert.That(async () => await anotherConsumer.ReceiveAsync(1, TimeSpan.Zero), Throws.Nothing);

                        // Send the batch of events.

                        await producer.SendAsync(eventBatch);

                        // Receive and validate the events; because there is some non-determinism in the messaging flow, the
                        // sent events may not be immediately available.  Allow for a small number of attempts to receive, in order
                        // to account for availability delays.

                        var receivedEvents = new List<EventData>();
                        var index = 0;

                        while ((receivedEvents.Count < eventBatch.Length) && (++index < ReceiveRetryLimit))
                        {
                            receivedEvents.AddRange(await consumer.ReceiveAsync(eventBatch.Length + 10, TimeSpan.FromMilliseconds(25)));
                        }

                        Assert.That(receivedEvents.Count, Is.EqualTo(eventBatch.Length), $"The number of received events in consumer group { consumer.ConsumerGroup } did not match the batch size.");

                        receivedEvents.Clear();
                        index = 0;

                        while ((receivedEvents.Count < eventBatch.Length) && (++index < ReceiveRetryLimit))
                        {
                            receivedEvents.AddRange(await anotherConsumer.ReceiveAsync(eventBatch.Length + 10, TimeSpan.FromMilliseconds(25)));
                        }

                        Assert.That(receivedEvents.Count, Is.EqualTo(eventBatch.Length), $"The number of received events in consumer group { anotherConsumer.ConsumerGroup } did not match the batch size.");
                    }
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubConsumer" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        [TestCase(2)]
        [TestCase(4)]
        [TestCase(15)]
        public async Task ReceiveStopsWhenMaximumWaitTimeIsReached(int maximumWaitTimeInSecs)
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var client = new EventHubClient(connectionString))
                {
                    var partition = (await client.GetPartitionIdsAsync()).First();

                    await using (EventHubProducer producer = client.CreateProducer(new EventHubProducerOptions { PartitionId = partition }))
                    await using (EventHubConsumer consumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partition, EventPosition.Latest))
                    {
                        // Initiate an operation to force the consumers to connect and set their positions at the
                        // end of the event stream.

                        await consumer.ReceiveAsync(1, TimeSpan.Zero);

                        // The consumer will wait until maximum wait time is reached because there are no messages to receive.

                        DateTime startTime = DateTime.UtcNow;

                        await consumer.ReceiveAsync(1, TimeSpan.FromSeconds(maximumWaitTimeInSecs));

                        var elapsedTime = DateTime.UtcNow.Subtract(startTime).TotalSeconds;

                        Assert.That(elapsedTime, Is.GreaterThan(maximumWaitTimeInSecs - 0.1));
                        Assert.That(elapsedTime, Is.LessThan(maximumWaitTimeInSecs + 5));
                    }
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubConsumer" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        [TestCase(3)]
        [TestCase(7)]
        [TestCase(12)]
        public async Task ReceiveStopsWhenDefaultMaximumWaitTimeIsReachedIfMaximumWaitTimeIsNotProvided(int defaultMaximumWaitTimeInSecs)
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var client = new EventHubClient(connectionString))
                {
                    var partition = (await client.GetPartitionIdsAsync()).First();
                    var consumerOptions = new EventHubConsumerOptions
                    {
                        DefaultMaximumReceiveWaitTime = TimeSpan.FromSeconds(defaultMaximumWaitTimeInSecs)
                    };

                    await using (EventHubProducer producer = client.CreateProducer(new EventHubProducerOptions { PartitionId = partition }))
                    await using (EventHubConsumer consumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partition, EventPosition.Latest, consumerOptions))
                    {
                        var maximumWaitTimeInSecs = 10;

                        // Initiate an operation to force the consumers to connect and set their positions at the
                        // end of the event stream.

                        await consumer.ReceiveAsync(1, TimeSpan.Zero);

                        // The consumer will wait until default maximum wait time is reached because there are no messages to receive.

                        DateTime startTime = DateTime.UtcNow;

                        await consumer.ReceiveAsync(1);

                        var elapsedTime = DateTime.UtcNow.Subtract(startTime).TotalSeconds;

                        Assert.That(elapsedTime, Is.GreaterThan(defaultMaximumWaitTimeInSecs - 0.1));
                        Assert.That(elapsedTime, Is.LessThan(defaultMaximumWaitTimeInSecs + 5));

                        // The consumer will wait until maximum wait time is reached because there are no messages to receive.

                        startTime = DateTime.UtcNow;

                        await consumer.ReceiveAsync(1, TimeSpan.FromSeconds(maximumWaitTimeInSecs));

                        elapsedTime = DateTime.UtcNow.Subtract(startTime).TotalSeconds;

                        Assert.That(elapsedTime, Is.GreaterThan(maximumWaitTimeInSecs - 0.1));
                        Assert.That(elapsedTime, Is.LessThan(maximumWaitTimeInSecs + 5));
                    }
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubConsumer" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task QuotaExceedExceptionMessageContainsExistingConsumersIdentifiers()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var client = new EventHubClient(connectionString))
                {
                    var partition = (await client.GetPartitionIdsAsync()).First();
                    var consumers = new List<EventHubConsumer>();
                    var maximumConsumersQuota = 5;

                    try
                    {
                        for (int i = 0; i < maximumConsumersQuota; i++)
                        {
                            var consumerOptions = new EventHubConsumerOptions { Identifier = $"consumer{i}" };
                            EventHubConsumer newConsumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partition, EventPosition.Latest, consumerOptions);

                            // Issue a receive call so link will become active.

                            Assert.That(async () => await newConsumer.ReceiveAsync(1, TimeSpan.Zero), Throws.Nothing);

                            consumers.Add(newConsumer);
                        }

                        // Attempt to create 6th consumer. This should fail.

                        EventHubConsumer failConsumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partition, EventPosition.Latest);

                        await failConsumer.ReceiveAsync(1, TimeSpan.Zero);

                        throw new InvalidOperationException("6th consumer should have encountered QuotaExceededException.");
                    }
                    catch (QuotaExceededException ex)
                    {
                        foreach (EventHubConsumer consumer in consumers)
                        {
                            Assert.That(ex.Message.Contains(consumer.Identifier), Is.True, $"QuotaExceededException message is missing consumer identifier '{consumer.Identifier}')");
                        }
                    }
                    finally
                    {
                        await Task.WhenAll(consumers.Select(consumer => consumer.CloseAsync()));
                    }
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubConsumer" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task SmallReceiveWaitTimeDoesNotThrowEventHubsTimeoutException()
        {
            // Issue receives with 1 second so that some of the Receive calls will timeout while creating AMQP link.
            // Even those Receive calls should return NULL instead of bubbling the exception up.

            var receiveTimeoutInSeconds = 1;

            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var client = new EventHubClient(connectionString))
                {
                    var partition = (await client.GetPartitionIdsAsync()).First();

                    IEnumerable<Task> tasks = Enumerable.Range(0, 10)
                        .Select(async i =>
                        {
                            await using (EventHubConsumer consumer = client.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partition, EventPosition.Latest))
                            {
                                Assert.That(async () => await consumer.ReceiveAsync(1, TimeSpan.FromSeconds(receiveTimeoutInSeconds)), Throws.Nothing);
                            }
                        });

                    await Task.WhenAll(tasks);
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubConsumer" /> is able to
        ///   connect to the Event Hubs service and perform operations.
        /// </summary>
        ///
        [Test]
        public async Task ConsumerCannotReceiveWhenProxyIsInvalid()
        {
            await using (EventHubScope scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);
                var clientOptions = new EventHubClientOptions
                {
                    Proxy = new WebProxy("http://1.2.3.4:9999"),
                    TransportType = TransportType.AmqpWebSockets,
                    RetryOptions = new RetryOptions { TryTimeout = TimeSpan.FromMinutes(2) }
                };

                await using (var client = new EventHubClient(connectionString))
                await using (var invalidProxyClient = new EventHubClient(connectionString, clientOptions))
                {
                    var partition = (await client.GetPartitionIdsAsync()).First();

                    await using (EventHubConsumer invalidProxyConsumer = invalidProxyClient.CreateConsumer(EventHubConsumer.DefaultConsumerGroupName, partition, EventPosition.Latest))
                    {
                        Assert.That(async () => await invalidProxyConsumer.ReceiveAsync(1, TimeSpan.Zero), Throws.InstanceOf<WebSocketException>().Or.InstanceOf<TimeoutException>());
                    }
                }
            }
        }
    }
}
