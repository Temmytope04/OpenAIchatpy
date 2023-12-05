// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Represents the publisher information of a process/rule. </summary>
    public partial class SecurityCenterPublisherInfo
    {
        /// <summary> Initializes a new instance of <see cref="SecurityCenterPublisherInfo"/>. </summary>
        public SecurityCenterPublisherInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SecurityCenterPublisherInfo"/>. </summary>
        /// <param name="publisherName"> The Subject field of the x.509 certificate used to sign the code, using the following fields -  O = Organization, L = Locality, S = State or Province, and C = Country. </param>
        /// <param name="productName"> The product name taken from the file's version resource. </param>
        /// <param name="binaryName"> The "OriginalName" field taken from the file's version resource. </param>
        /// <param name="version"> The binary file version taken from the file's version resource. </param>
        internal SecurityCenterPublisherInfo(string publisherName, string productName, string binaryName, string version)
        {
            PublisherName = publisherName;
            ProductName = productName;
            BinaryName = binaryName;
            Version = version;
        }

        /// <summary> The Subject field of the x.509 certificate used to sign the code, using the following fields -  O = Organization, L = Locality, S = State or Province, and C = Country. </summary>
        public string PublisherName { get; set; }
        /// <summary> The product name taken from the file's version resource. </summary>
        public string ProductName { get; set; }
        /// <summary> The "OriginalName" field taken from the file's version resource. </summary>
        public string BinaryName { get; set; }
        /// <summary> The binary file version taken from the file's version resource. </summary>
        public string Version { get; set; }
    }
}
