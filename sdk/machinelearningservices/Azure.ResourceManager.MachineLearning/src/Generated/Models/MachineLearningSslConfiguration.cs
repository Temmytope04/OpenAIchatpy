// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The ssl configuration for scoring. </summary>
    public partial class MachineLearningSslConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningSslConfiguration"/>. </summary>
        public MachineLearningSslConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningSslConfiguration"/>. </summary>
        /// <param name="status"> Enable or disable ssl for scoring. </param>
        /// <param name="cert"> Cert data. </param>
        /// <param name="key"> Key data. </param>
        /// <param name="cname"> CNAME of the cert. </param>
        /// <param name="leafDomainLabel"> Leaf domain label of public endpoint. </param>
        /// <param name="overwriteExistingDomain"> Indicates whether to overwrite existing domain label. </param>
        internal MachineLearningSslConfiguration(MachineLearningSslConfigStatus? status, string cert, string key, string cname, string leafDomainLabel, bool? overwriteExistingDomain)
        {
            Status = status;
            Cert = cert;
            Key = key;
            Cname = cname;
            LeafDomainLabel = leafDomainLabel;
            OverwriteExistingDomain = overwriteExistingDomain;
        }

        /// <summary> Enable or disable ssl for scoring. </summary>
        public MachineLearningSslConfigStatus? Status { get; set; }
        /// <summary> Cert data. </summary>
        public string Cert { get; set; }
        /// <summary> Key data. </summary>
        public string Key { get; set; }
        /// <summary> CNAME of the cert. </summary>
        public string Cname { get; set; }
        /// <summary> Leaf domain label of public endpoint. </summary>
        public string LeafDomainLabel { get; set; }
        /// <summary> Indicates whether to overwrite existing domain label. </summary>
        public bool? OverwriteExistingDomain { get; set; }
    }
}
