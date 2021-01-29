// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Xml.Linq;
using Azure.Core;

namespace Azure.Storage.Blobs.Models
{
    public partial class UserDelegationKey
    {
        internal static UserDelegationKey DeserializeUserDelegationKey(XElement element)
        {
            string signedOid = default;
            string signedTid = default;
            DateTimeOffset signedStart = default;
            DateTimeOffset signedExpiry = default;
            string signedService = default;
            string signedVersion = default;
            string value = default;
            if (element.Element("SignedOid") is XElement signedOidElement)
            {
                signedOid = (string)signedOidElement;
            }
            if (element.Element("SignedTid") is XElement signedTidElement)
            {
                signedTid = (string)signedTidElement;
            }
            if (element.Element("SignedStart") is XElement signedStartElement)
            {
                signedStart = signedStartElement.GetDateTimeOffsetValue("O");
            }
            if (element.Element("SignedExpiry") is XElement signedExpiryElement)
            {
                signedExpiry = signedExpiryElement.GetDateTimeOffsetValue("O");
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
            return new UserDelegationKey(signedOid, signedTid, signedStart, signedExpiry, signedService, signedVersion, value);
        }
    }
}
