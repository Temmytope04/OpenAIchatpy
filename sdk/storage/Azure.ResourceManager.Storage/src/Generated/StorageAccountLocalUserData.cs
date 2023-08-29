// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Storage.Models;

namespace Azure.ResourceManager.Storage
{
    /// <summary>
    /// A class representing the StorageAccountLocalUser data model.
    /// The local user associated with the storage accounts.
    /// </summary>
    public partial class StorageAccountLocalUserData : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="StorageAccountLocalUserData"/>. </summary>
        public StorageAccountLocalUserData()
        {
            PermissionScopes = new ChangeTrackingList<StoragePermissionScope>();
            SshAuthorizedKeys = new ChangeTrackingList<StorageSshPublicKey>();
        }

        /// <summary> Initializes a new instance of <see cref="StorageAccountLocalUserData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="permissionScopes"> The permission scopes of the local user. </param>
        /// <param name="homeDirectory"> Optional, local user home directory. </param>
        /// <param name="sshAuthorizedKeys"> Optional, local user ssh authorized keys for SFTP. </param>
        /// <param name="sid"> A unique Security Identifier that is generated by the server. </param>
        /// <param name="hasSharedKey"> Indicates whether shared key exists. Set it to false to remove existing shared key. </param>
        /// <param name="hasSshKey"> Indicates whether ssh key exists. Set it to false to remove existing SSH key. </param>
        /// <param name="hasSshPassword"> Indicates whether ssh password exists. Set it to false to remove existing SSH password. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageAccountLocalUserData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IList<StoragePermissionScope> permissionScopes, string homeDirectory, IList<StorageSshPublicKey> sshAuthorizedKeys, string sid, bool? hasSharedKey, bool? hasSshKey, bool? hasSshPassword, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            PermissionScopes = permissionScopes;
            HomeDirectory = homeDirectory;
            SshAuthorizedKeys = sshAuthorizedKeys;
            Sid = sid;
            HasSharedKey = hasSharedKey;
            HasSshKey = hasSshKey;
            HasSshPassword = hasSshPassword;
            _rawData = rawData;
        }

        /// <summary> The permission scopes of the local user. </summary>
        public IList<StoragePermissionScope> PermissionScopes { get; }
        /// <summary> Optional, local user home directory. </summary>
        public string HomeDirectory { get; set; }
        /// <summary> Optional, local user ssh authorized keys for SFTP. </summary>
        public IList<StorageSshPublicKey> SshAuthorizedKeys { get; }
        /// <summary> A unique Security Identifier that is generated by the server. </summary>
        public string Sid { get; }
        /// <summary> Indicates whether shared key exists. Set it to false to remove existing shared key. </summary>
        public bool? HasSharedKey { get; set; }
        /// <summary> Indicates whether ssh key exists. Set it to false to remove existing SSH key. </summary>
        public bool? HasSshKey { get; set; }
        /// <summary> Indicates whether ssh password exists. Set it to false to remove existing SSH password. </summary>
        public bool? HasSshPassword { get; set; }
    }
}
