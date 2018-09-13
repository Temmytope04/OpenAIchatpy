// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Dns.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes a DNS record set (a collection of DNS records with the same
    /// name and type).
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class RecordSet : IResource
    {
        /// <summary>
        /// Initializes a new instance of the RecordSet class.
        /// </summary>
        public RecordSet()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RecordSet class.
        /// </summary>
        /// <param name="id">The ID of the record set.</param>
        /// <param name="name">The name of the record set.</param>
        /// <param name="type">The type of the record set.</param>
        /// <param name="etag">The etag of the record set.</param>
        /// <param name="metadata">The metadata attached to the record
        /// set.</param>
        /// <param name="tTL">The TTL (time-to-live) of the records in the
        /// record set.</param>
        /// <param name="fqdn">Fully qualified domain name of the record
        /// set.</param>
        /// <param name="provisioningState">provisioning State of the record
        /// set.</param>
        /// <param name="targetResource">A reference to an azure resource from
        /// where the dns resource value is taken.</param>
        /// <param name="aRecords">The list of A records in the record
        /// set.</param>
        /// <param name="aaaaRecords">The list of AAAA records in the record
        /// set.</param>
        /// <param name="mxRecords">The list of MX records in the record
        /// set.</param>
        /// <param name="nsRecords">The list of NS records in the record
        /// set.</param>
        /// <param name="ptrRecords">The list of PTR records in the record
        /// set.</param>
        /// <param name="srvRecords">The list of SRV records in the record
        /// set.</param>
        /// <param name="txtRecords">The list of TXT records in the record
        /// set.</param>
        /// <param name="cnameRecord">The CNAME record in the  record
        /// set.</param>
        /// <param name="soaRecord">The SOA record in the record set.</param>
        /// <param name="caaRecords">The list of CAA records in the record
        /// set.</param>
        public RecordSet(string id = default(string), string name = default(string), string type = default(string), string etag = default(string), IDictionary<string, string> metadata = default(IDictionary<string, string>), long? tTL = default(long?), string fqdn = default(string), string provisioningState = default(string), SubResource targetResource = default(SubResource), IList<ARecord> aRecords = default(IList<ARecord>), IList<AaaaRecord> aaaaRecords = default(IList<AaaaRecord>), IList<MxRecord> mxRecords = default(IList<MxRecord>), IList<NsRecord> nsRecords = default(IList<NsRecord>), IList<PtrRecord> ptrRecords = default(IList<PtrRecord>), IList<SrvRecord> srvRecords = default(IList<SrvRecord>), IList<TxtRecord> txtRecords = default(IList<TxtRecord>), CnameRecord cnameRecord = default(CnameRecord), SoaRecord soaRecord = default(SoaRecord), IList<CaaRecord> caaRecords = default(IList<CaaRecord>))
        {
            Id = id;
            Name = name;
            Type = type;
            Etag = etag;
            Metadata = metadata;
            TTL = tTL;
            Fqdn = fqdn;
            ProvisioningState = provisioningState;
            TargetResource = targetResource;
            ARecords = aRecords;
            AaaaRecords = aaaaRecords;
            MxRecords = mxRecords;
            NsRecords = nsRecords;
            PtrRecords = ptrRecords;
            SrvRecords = srvRecords;
            TxtRecords = txtRecords;
            CnameRecord = cnameRecord;
            SoaRecord = soaRecord;
            CaaRecords = caaRecords;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the ID of the record set.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the name of the record set.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the type of the record set.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or sets the etag of the record set.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Gets or sets the metadata attached to the record set.
        /// </summary>
        [JsonProperty(PropertyName = "properties.metadata")]
        public IDictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets or sets the TTL (time-to-live) of the records in the record
        /// set.
        /// </summary>
        [JsonProperty(PropertyName = "properties.TTL")]
        public long? TTL { get; set; }

        /// <summary>
        /// Gets fully qualified domain name of the record set.
        /// </summary>
        [JsonProperty(PropertyName = "properties.fqdn")]
        public string Fqdn { get; private set; }

        /// <summary>
        /// Gets provisioning State of the record set.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets a reference to an azure resource from where the dns
        /// resource value is taken.
        /// </summary>
        [JsonProperty(PropertyName = "properties.targetResource")]
        public SubResource TargetResource { get; set; }

        /// <summary>
        /// Gets or sets the list of A records in the record set.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ARecords")]
        public IList<ARecord> ARecords { get; set; }

        /// <summary>
        /// Gets or sets the list of AAAA records in the record set.
        /// </summary>
        [JsonProperty(PropertyName = "properties.AAAARecords")]
        public IList<AaaaRecord> AaaaRecords { get; set; }

        /// <summary>
        /// Gets or sets the list of MX records in the record set.
        /// </summary>
        [JsonProperty(PropertyName = "properties.MXRecords")]
        public IList<MxRecord> MxRecords { get; set; }

        /// <summary>
        /// Gets or sets the list of NS records in the record set.
        /// </summary>
        [JsonProperty(PropertyName = "properties.NSRecords")]
        public IList<NsRecord> NsRecords { get; set; }

        /// <summary>
        /// Gets or sets the list of PTR records in the record set.
        /// </summary>
        [JsonProperty(PropertyName = "properties.PTRRecords")]
        public IList<PtrRecord> PtrRecords { get; set; }

        /// <summary>
        /// Gets or sets the list of SRV records in the record set.
        /// </summary>
        [JsonProperty(PropertyName = "properties.SRVRecords")]
        public IList<SrvRecord> SrvRecords { get; set; }

        /// <summary>
        /// Gets or sets the list of TXT records in the record set.
        /// </summary>
        [JsonProperty(PropertyName = "properties.TXTRecords")]
        public IList<TxtRecord> TxtRecords { get; set; }

        /// <summary>
        /// Gets or sets the CNAME record in the  record set.
        /// </summary>
        [JsonProperty(PropertyName = "properties.CNAMERecord")]
        public CnameRecord CnameRecord { get; set; }

        /// <summary>
        /// Gets or sets the SOA record in the record set.
        /// </summary>
        [JsonProperty(PropertyName = "properties.SOARecord")]
        public SoaRecord SoaRecord { get; set; }

        /// <summary>
        /// Gets or sets the list of CAA records in the record set.
        /// </summary>
        [JsonProperty(PropertyName = "properties.caaRecords")]
        public IList<CaaRecord> CaaRecords { get; set; }

    }
}
