// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The SecuritySolutionsReferenceData. </summary>
    public partial class SecuritySolutionsReferenceData : ResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SecuritySolutionsReferenceData"/>. </summary>
        /// <param name="securityFamily"> The security family of the security solution. </param>
        /// <param name="alertVendorName"> The security solutions' vendor name. </param>
        /// <param name="packageInfoUri"> The security solutions' package info url. </param>
        /// <param name="productName"> The security solutions' product name. </param>
        /// <param name="publisher"> The security solutions' publisher. </param>
        /// <param name="publisherDisplayName"> The security solutions' publisher display name. </param>
        /// <param name="template"> The security solutions' template. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="alertVendorName"/>, <paramref name="packageInfoUri"/>, <paramref name="productName"/>, <paramref name="publisher"/>, <paramref name="publisherDisplayName"/> or <paramref name="template"/> is null. </exception>
        public SecuritySolutionsReferenceData(SecurityFamily securityFamily, string alertVendorName, Uri packageInfoUri, string productName, string publisher, string publisherDisplayName, string template)
        {
            if (alertVendorName == null)
            {
                throw new ArgumentNullException(nameof(alertVendorName));
            }
            if (packageInfoUri == null)
            {
                throw new ArgumentNullException(nameof(packageInfoUri));
            }
            if (productName == null)
            {
                throw new ArgumentNullException(nameof(productName));
            }
            if (publisher == null)
            {
                throw new ArgumentNullException(nameof(publisher));
            }
            if (publisherDisplayName == null)
            {
                throw new ArgumentNullException(nameof(publisherDisplayName));
            }
            if (template == null)
            {
                throw new ArgumentNullException(nameof(template));
            }

            SecurityFamily = securityFamily;
            AlertVendorName = alertVendorName;
            PackageInfoUri = packageInfoUri;
            ProductName = productName;
            Publisher = publisher;
            PublisherDisplayName = publisherDisplayName;
            Template = template;
        }

        /// <summary> Initializes a new instance of <see cref="SecuritySolutionsReferenceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="securityFamily"> The security family of the security solution. </param>
        /// <param name="alertVendorName"> The security solutions' vendor name. </param>
        /// <param name="packageInfoUri"> The security solutions' package info url. </param>
        /// <param name="productName"> The security solutions' product name. </param>
        /// <param name="publisher"> The security solutions' publisher. </param>
        /// <param name="publisherDisplayName"> The security solutions' publisher display name. </param>
        /// <param name="template"> The security solutions' template. </param>
        /// <param name="location"> Location where the resource is stored. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SecuritySolutionsReferenceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SecurityFamily securityFamily, string alertVendorName, Uri packageInfoUri, string productName, string publisher, string publisherDisplayName, string template, AzureLocation? location, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            SecurityFamily = securityFamily;
            AlertVendorName = alertVendorName;
            PackageInfoUri = packageInfoUri;
            ProductName = productName;
            Publisher = publisher;
            PublisherDisplayName = publisherDisplayName;
            Template = template;
            Location = location;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SecuritySolutionsReferenceData"/> for deserialization. </summary>
        internal SecuritySolutionsReferenceData()
        {
        }

        /// <summary> The security family of the security solution. </summary>
        public SecurityFamily SecurityFamily { get; set; }
        /// <summary> The security solutions' vendor name. </summary>
        public string AlertVendorName { get; set; }
        /// <summary> The security solutions' package info url. </summary>
        public Uri PackageInfoUri { get; set; }
        /// <summary> The security solutions' product name. </summary>
        public string ProductName { get; set; }
        /// <summary> The security solutions' publisher. </summary>
        public string Publisher { get; set; }
        /// <summary> The security solutions' publisher display name. </summary>
        public string PublisherDisplayName { get; set; }
        /// <summary> The security solutions' template. </summary>
        public string Template { get; set; }
        /// <summary> Location where the resource is stored. </summary>
        public AzureLocation? Location { get; }
    }
}
