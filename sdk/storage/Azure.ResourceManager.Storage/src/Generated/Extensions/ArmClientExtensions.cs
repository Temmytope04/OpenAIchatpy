// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Storage
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public static partial class ArmClientExtensions
    {
        #region StorageAccount
        /// <summary> Gets an object representing a StorageAccount along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StorageAccount" /> object. </returns>
        public static StorageAccount GetStorageAccount(this ArmClient armClient, ResourceIdentifier id)
        {
            StorageAccount.ValidateResourceId(id);
            return new StorageAccount(armClient, id);
        }
        #endregion

        #region DeletedAccount
        /// <summary> Gets an object representing a DeletedAccount along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DeletedAccount" /> object. </returns>
        public static DeletedAccount GetDeletedAccount(this ArmClient armClient, ResourceIdentifier id)
        {
            DeletedAccount.ValidateResourceId(id);
            return new DeletedAccount(armClient, id);
        }
        #endregion

        #region ManagementPolicy
        /// <summary> Gets an object representing a ManagementPolicy along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ManagementPolicy" /> object. </returns>
        public static ManagementPolicy GetManagementPolicy(this ArmClient armClient, ResourceIdentifier id)
        {
            ManagementPolicy.ValidateResourceId(id);
            return new ManagementPolicy(armClient, id);
        }
        #endregion

        #region BlobInventoryPolicy
        /// <summary> Gets an object representing a BlobInventoryPolicy along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BlobInventoryPolicy" /> object. </returns>
        public static BlobInventoryPolicy GetBlobInventoryPolicy(this ArmClient armClient, ResourceIdentifier id)
        {
            BlobInventoryPolicy.ValidateResourceId(id);
            return new BlobInventoryPolicy(armClient, id);
        }
        #endregion

        #region PrivateEndpointConnection
        /// <summary> Gets an object representing a PrivateEndpointConnection along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateEndpointConnection" /> object. </returns>
        public static PrivateEndpointConnection GetPrivateEndpointConnection(this ArmClient armClient, ResourceIdentifier id)
        {
            PrivateEndpointConnection.ValidateResourceId(id);
            return new PrivateEndpointConnection(armClient, id);
        }
        #endregion

        #region ObjectReplicationPolicy
        /// <summary> Gets an object representing a ObjectReplicationPolicy along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ObjectReplicationPolicy" /> object. </returns>
        public static ObjectReplicationPolicy GetObjectReplicationPolicy(this ArmClient armClient, ResourceIdentifier id)
        {
            ObjectReplicationPolicy.ValidateResourceId(id);
            return new ObjectReplicationPolicy(armClient, id);
        }
        #endregion

        #region LocalUser
        /// <summary> Gets an object representing a LocalUser along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="LocalUser" /> object. </returns>
        public static LocalUser GetLocalUser(this ArmClient armClient, ResourceIdentifier id)
        {
            LocalUser.ValidateResourceId(id);
            return new LocalUser(armClient, id);
        }
        #endregion

        #region EncryptionScope
        /// <summary> Gets an object representing a EncryptionScope along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EncryptionScope" /> object. </returns>
        public static EncryptionScope GetEncryptionScope(this ArmClient armClient, ResourceIdentifier id)
        {
            EncryptionScope.ValidateResourceId(id);
            return new EncryptionScope(armClient, id);
        }
        #endregion

        #region BlobService
        /// <summary> Gets an object representing a BlobService along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BlobService" /> object. </returns>
        public static BlobService GetBlobService(this ArmClient armClient, ResourceIdentifier id)
        {
            BlobService.ValidateResourceId(id);
            return new BlobService(armClient, id);
        }
        #endregion

        #region BlobContainer
        /// <summary> Gets an object representing a BlobContainer along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BlobContainer" /> object. </returns>
        public static BlobContainer GetBlobContainer(this ArmClient armClient, ResourceIdentifier id)
        {
            BlobContainer.ValidateResourceId(id);
            return new BlobContainer(armClient, id);
        }
        #endregion

        #region ImmutabilityPolicy
        /// <summary> Gets an object representing a ImmutabilityPolicy along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ImmutabilityPolicy" /> object. </returns>
        public static ImmutabilityPolicy GetImmutabilityPolicy(this ArmClient armClient, ResourceIdentifier id)
        {
            ImmutabilityPolicy.ValidateResourceId(id);
            return new ImmutabilityPolicy(armClient, id);
        }
        #endregion

        #region FileService
        /// <summary> Gets an object representing a FileService along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FileService" /> object. </returns>
        public static FileService GetFileService(this ArmClient armClient, ResourceIdentifier id)
        {
            FileService.ValidateResourceId(id);
            return new FileService(armClient, id);
        }
        #endregion

        #region FileShare
        /// <summary> Gets an object representing a FileShare along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FileShare" /> object. </returns>
        public static FileShare GetFileShare(this ArmClient armClient, ResourceIdentifier id)
        {
            FileShare.ValidateResourceId(id);
            return new FileShare(armClient, id);
        }
        #endregion

        #region QueueService
        /// <summary> Gets an object representing a QueueService along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="QueueService" /> object. </returns>
        public static QueueService GetQueueService(this ArmClient armClient, ResourceIdentifier id)
        {
            QueueService.ValidateResourceId(id);
            return new QueueService(armClient, id);
        }
        #endregion

        #region StorageQueue
        /// <summary> Gets an object representing a StorageQueue along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StorageQueue" /> object. </returns>
        public static StorageQueue GetStorageQueue(this ArmClient armClient, ResourceIdentifier id)
        {
            StorageQueue.ValidateResourceId(id);
            return new StorageQueue(armClient, id);
        }
        #endregion

        #region TableService
        /// <summary> Gets an object representing a TableService along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="TableService" /> object. </returns>
        public static TableService GetTableService(this ArmClient armClient, ResourceIdentifier id)
        {
            TableService.ValidateResourceId(id);
            return new TableService(armClient, id);
        }
        #endregion

        #region Table
        /// <summary> Gets an object representing a Table along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="Table" /> object. </returns>
        public static Table GetTable(this ArmClient armClient, ResourceIdentifier id)
        {
            Table.ValidateResourceId(id);
            return new Table(armClient, id);
        }
        #endregion
    }
}
