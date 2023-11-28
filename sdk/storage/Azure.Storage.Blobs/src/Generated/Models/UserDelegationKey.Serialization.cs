// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.Xml.Linq;
using Azure.Core;

namespace Azure.Storage.Blobs.Models
{
    public partial class UserDelegationKey
    {
        internal static UserDelegationKey DeserializeUserDelegationKey(XElement element, ModelReaderWriterOptions options = null)
        {
            string signedObjectId = default;
            string signedTenantId = default;
            DateTimeOffset signedStartsOn = default;
            DateTimeOffset signedExpiresOn = default;
            string signedService = default;
            string signedVersion = default;
            string value = default;
            if (element.Element("SignedOid") is XElement signedOidElement)
            {
                signedObjectId = (string)signedOidElement;
            }
            if (element.Element("SignedTid") is XElement signedTidElement)
            {
                signedTenantId = (string)signedTidElement;
            }
            if (element.Element("SignedStart") is XElement signedStartElement)
            {
                signedStartsOn = signedStartElement.GetDateTimeOffsetValue("O");
            }
            if (element.Element("SignedExpiry") is XElement signedExpiryElement)
            {
                signedExpiresOn = signedExpiryElement.GetDateTimeOffsetValue("O");
            }
            if (element.Element("SignedService") is XElement signedServiceElement)
            {
                signedService = (string)signedServiceElement;
            }
            if (element.Element("SignedVersion") is XElement signedVersionElement)
            {
                signedVersion = (string)signedVersionElement;
            }
            if (element.Element("Value") is XElement valueElement)
            {
                value = (string)valueElement;
            }
            return new UserDelegationKey(signedObjectId, signedTenantId, signedStartsOn, signedExpiresOn, signedService, signedVersion, value);
        }
    }
}
