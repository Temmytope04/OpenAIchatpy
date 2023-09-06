// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Support.Models
{
    /// <summary> Contact information associated with the support ticket. </summary>
    public partial class SupportContactProfileContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SupportContactProfileContent"/>. </summary>
        public SupportContactProfileContent()
        {
            AdditionalEmailAddresses = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="SupportContactProfileContent"/>. </summary>
        /// <param name="firstName"> First name. </param>
        /// <param name="lastName"> Last name. </param>
        /// <param name="preferredContactMethod"> Preferred contact method. </param>
        /// <param name="primaryEmailAddress"> Primary email address. </param>
        /// <param name="additionalEmailAddresses"> Email addresses listed will be copied on any correspondence about the support ticket. </param>
        /// <param name="phoneNumber"> Phone number. This is required if preferred contact method is phone. </param>
        /// <param name="preferredTimeZone"> Time zone of the user. This is the name of the time zone from [Microsoft Time Zone Index Values](https://support.microsoft.com/help/973627/microsoft-time-zone-index-values). </param>
        /// <param name="country"> Country of the user. This is the ISO 3166-1 alpha-3 code. </param>
        /// <param name="preferredSupportLanguage"> Preferred language of support from Azure. Support languages vary based on the severity you choose for your support ticket. Learn more at [Azure Severity and responsiveness](https://azure.microsoft.com/support/plans/response/). Use the standard language-country code. Valid values are 'en-us' for English, 'zh-hans' for Chinese, 'es-es' for Spanish, 'fr-fr' for French, 'ja-jp' for Japanese, 'ko-kr' for Korean, 'ru-ru' for Russian, 'pt-br' for Portuguese, 'it-it' for Italian, 'zh-tw' for Chinese and 'de-de' for German. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SupportContactProfileContent(string firstName, string lastName, PreferredContactMethod? preferredContactMethod, string primaryEmailAddress, IList<string> additionalEmailAddresses, string phoneNumber, string preferredTimeZone, string country, string preferredSupportLanguage, Dictionary<string, BinaryData> rawData)
        {
            FirstName = firstName;
            LastName = lastName;
            PreferredContactMethod = preferredContactMethod;
            PrimaryEmailAddress = primaryEmailAddress;
            AdditionalEmailAddresses = additionalEmailAddresses;
            PhoneNumber = phoneNumber;
            PreferredTimeZone = preferredTimeZone;
            Country = country;
            PreferredSupportLanguage = preferredSupportLanguage;
            _rawData = rawData;
        }

        /// <summary> First name. </summary>
        public string FirstName { get; set; }
        /// <summary> Last name. </summary>
        public string LastName { get; set; }
        /// <summary> Preferred contact method. </summary>
        public PreferredContactMethod? PreferredContactMethod { get; set; }
        /// <summary> Primary email address. </summary>
        public string PrimaryEmailAddress { get; set; }
        /// <summary> Email addresses listed will be copied on any correspondence about the support ticket. </summary>
        public IList<string> AdditionalEmailAddresses { get; }
        /// <summary> Phone number. This is required if preferred contact method is phone. </summary>
        public string PhoneNumber { get; set; }
        /// <summary> Time zone of the user. This is the name of the time zone from [Microsoft Time Zone Index Values](https://support.microsoft.com/help/973627/microsoft-time-zone-index-values). </summary>
        public string PreferredTimeZone { get; set; }
        /// <summary> Country of the user. This is the ISO 3166-1 alpha-3 code. </summary>
        public string Country { get; set; }
        /// <summary> Preferred language of support from Azure. Support languages vary based on the severity you choose for your support ticket. Learn more at [Azure Severity and responsiveness](https://azure.microsoft.com/support/plans/response/). Use the standard language-country code. Valid values are 'en-us' for English, 'zh-hans' for Chinese, 'es-es' for Spanish, 'fr-fr' for French, 'ja-jp' for Japanese, 'ko-kr' for Korean, 'ru-ru' for Russian, 'pt-br' for Portuguese, 'it-it' for Italian, 'zh-tw' for Chinese and 'de-de' for German. </summary>
        public string PreferredSupportLanguage { get; set; }
    }
}
