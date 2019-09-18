﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Reflection;
using Azure.Messaging.EventHubs.Core;
using NUnit.Framework;

namespace Azure.Messaging.EventHubs.Tests
{
    /// <summary>
    ///   The suite of tests for the <see cref="ClientLibraryInformation" />
    ///   class.
    /// </summary>
    ///
    [TestFixture]
    public class ClientLibraryInformationTests
    {
        /// <summary>
        ///   Validates functionality of the <see cref="ClientLibraryInformation.Current" />
        ///   property.
        /// </summary>
        ///
        [Test]
        public void CurentReturnsAnInstance()
        {
            Assert.That(ClientLibraryInformation.s_current, Is.Not.Null);
        }

        /// <summary>
        ///   Validates functionality of the <see cref="ClientLibraryInformation.Current" />
        ///   property.
        /// </summary>
        ///
        [Test]
        public void PlatformIsPopulated()
        {
            Assert.That(ClientLibraryInformation.s_current.Platform, Is.Not.Null.And.Not.Empty);
        }

        /// <summary>
        ///   Validates functionality of the <see cref="ClientLibraryInformation.Current" />
        ///   property.
        /// </summary>
        ///
        [Test]
        public void ProductCanBeAccessed()
        {
            Assert.That(() => ClientLibraryInformation.s_current.Product, Throws.Nothing);
        }

        /// <summary>
        ///   Validates functionality of the <see cref="ClientLibraryInformation.Current" />
        ///   property.
        /// </summary>
        ///
        [Test]
        public void VersionCanBeAccessed()
        {
            Assert.That(() => ClientLibraryInformation.s_current.Version, Throws.Nothing);
        }

        /// <summary>
        ///   Validates functionality of the <see cref="ClientLibraryInformation.Current" />
        ///   property.
        /// </summary>
        ///
        [Test]
        public void FrameworkCanBeAccessed()
        {
            Assert.That(() => ClientLibraryInformation.s_current.Framework, Throws.Nothing);
        }

        /// <summary>
        ///   Validates functionality of the <see cref="ClientLibraryInformation.EnumerateProperties" />
        ///   property.
        /// </summary>
        ///
        [Test]
        public void PropertiesCanBeEnumerated()
        {
            foreach (KeyValuePair<string, string> property in ClientLibraryInformation.s_current.EnumerateProperties())
            {
                PropertyInfo matchingProperty = typeof(ClientLibraryInformation).GetProperty(property.Key, BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);

                Assert.That(matchingProperty, Is.Not.Null, $"The property, { property.Key }, was not found.");
                Assert.That((string)matchingProperty.GetValue(ClientLibraryInformation.s_current, null), Is.EqualTo(property.Value), $"The value for { property.Key } should match.");
            }
        }
    }
}
