// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.KeyVault.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.KeyVault;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Properties of the X509 component of a certificate.
    /// </summary>
    public partial class X509CertificateProperties
    {
        /// <summary>
        /// Initializes a new instance of the X509CertificateProperties class.
        /// </summary>
        public X509CertificateProperties()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the X509CertificateProperties class.
        /// </summary>
        /// <param name="subject">The subject name. Should be a valid X509
        /// distinguished Name.</param>
        /// <param name="ekus">The enhanced key usage.</param>
        /// <param name="subjectAlternativeNames">The subject alternative
        /// names.</param>
        /// <param name="keyUsage">List of key usages.</param>
        /// <param name="validityInMonths">The duration that the ceritifcate is
        /// valid in months.</param>
        public X509CertificateProperties(string subject = default(string), IList<string> ekus = default(IList<string>), SubjectAlternativeNames subjectAlternativeNames = default(SubjectAlternativeNames), IList<string> keyUsage = default(IList<string>), int? validityInMonths = default(int?))
        {
            Subject = subject;
            Ekus = ekus;
            SubjectAlternativeNames = subjectAlternativeNames;
            KeyUsage = keyUsage;
            ValidityInMonths = validityInMonths;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the subject name. Should be a valid X509 distinguished
        /// Name.
        /// </summary>
        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets the enhanced key usage.
        /// </summary>
        [JsonProperty(PropertyName = "ekus")]
        public IList<string> Ekus { get; set; }

        /// <summary>
        /// Gets or sets the subject alternative names.
        /// </summary>
        [JsonProperty(PropertyName = "sans")]
        public SubjectAlternativeNames SubjectAlternativeNames { get; set; }

        /// <summary>
        /// Gets or sets list of key usages.
        /// </summary>
        [JsonProperty(PropertyName = "key_usage")]
        public IList<string> KeyUsage { get; set; }

        /// <summary>
        /// Gets or sets the duration that the ceritifcate is valid in months.
        /// </summary>
        [JsonProperty(PropertyName = "validity_months")]
        public int? ValidityInMonths { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ValidityInMonths < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "ValidityInMonths", 0);
            }
        }
    }
}
