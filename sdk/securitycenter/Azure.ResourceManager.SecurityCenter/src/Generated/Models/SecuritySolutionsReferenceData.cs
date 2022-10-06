// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The SecuritySolutionsReferenceData. </summary>
    public partial class SecuritySolutionsReferenceData : ResourceData
    {
        /// <summary> Initializes a new instance of SecuritySolutionsReferenceData. </summary>
        /// <param name="securityFamily"> The security family of the security solution. </param>
        /// <param name="alertVendorName"> The security solutions&apos; vendor name. </param>
        /// <param name="packageInfoUri"> The security solutions&apos; package info url. </param>
        /// <param name="productName"> The security solutions&apos; product name. </param>
        /// <param name="publisher"> The security solutions&apos; publisher. </param>
        /// <param name="publisherDisplayName"> The security solutions&apos; publisher display name. </param>
        /// <param name="template"> The security solutions&apos; template. </param>
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

        /// <summary> Initializes a new instance of SecuritySolutionsReferenceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="securityFamily"> The security family of the security solution. </param>
        /// <param name="alertVendorName"> The security solutions&apos; vendor name. </param>
        /// <param name="packageInfoUri"> The security solutions&apos; package info url. </param>
        /// <param name="productName"> The security solutions&apos; product name. </param>
        /// <param name="publisher"> The security solutions&apos; publisher. </param>
        /// <param name="publisherDisplayName"> The security solutions&apos; publisher display name. </param>
        /// <param name="template"> The security solutions&apos; template. </param>
        /// <param name="location"> Location where the resource is stored. </param>
        internal SecuritySolutionsReferenceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SecurityFamily securityFamily, string alertVendorName, Uri packageInfoUri, string productName, string publisher, string publisherDisplayName, string template, AzureLocation? location) : base(id, name, resourceType, systemData)
        {
            SecurityFamily = securityFamily;
            AlertVendorName = alertVendorName;
            PackageInfoUri = packageInfoUri;
            ProductName = productName;
            Publisher = publisher;
            PublisherDisplayName = publisherDisplayName;
            Template = template;
            Location = location;
        }

        /// <summary> The security family of the security solution. </summary>
        public SecurityFamily SecurityFamily { get; set; }
        /// <summary> The security solutions&apos; vendor name. </summary>
        public string AlertVendorName { get; set; }
        /// <summary> The security solutions&apos; package info url. </summary>
        public Uri PackageInfoUri { get; set; }
        /// <summary> The security solutions&apos; product name. </summary>
        public string ProductName { get; set; }
        /// <summary> The security solutions&apos; publisher. </summary>
        public string Publisher { get; set; }
        /// <summary> The security solutions&apos; publisher display name. </summary>
        public string PublisherDisplayName { get; set; }
        /// <summary> The security solutions&apos; template. </summary>
        public string Template { get; set; }
        /// <summary> Location where the resource is stored. </summary>
        public AzureLocation? Location { get; }
    }
}
