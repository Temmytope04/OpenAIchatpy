// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Storage.Files.DataLake.Models
{
    /// <summary> Properties of a blob. </summary>
    internal partial class BlobPropertiesInternal
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BlobPropertiesInternal"/>. </summary>
        /// <param name="lastModified"></param>
        /// <param name="etag"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="etag"/> is null. </exception>
        internal BlobPropertiesInternal(DateTimeOffset lastModified, string etag)
        {
            Argument.AssertNotNull(etag, nameof(etag));

            LastModified = lastModified;
            Etag = etag;
        }

        /// <summary> Initializes a new instance of <see cref="BlobPropertiesInternal"/>. </summary>
        /// <param name="creationTime"></param>
        /// <param name="lastModified"></param>
        /// <param name="etag"></param>
        /// <param name="contentLength"> Size in bytes. </param>
        /// <param name="contentType"></param>
        /// <param name="contentEncoding"></param>
        /// <param name="contentLanguage"></param>
        /// <param name="contentMD5"></param>
        /// <param name="contentDisposition"></param>
        /// <param name="cacheControl"></param>
        /// <param name="blobSequenceNumber"></param>
        /// <param name="copyId"></param>
        /// <param name="copySource"></param>
        /// <param name="copyProgress"></param>
        /// <param name="copyCompletionTime"></param>
        /// <param name="copyStatusDescription"></param>
        /// <param name="serverEncrypted"></param>
        /// <param name="incrementalCopy"></param>
        /// <param name="destinationSnapshot"></param>
        /// <param name="deletedTime"></param>
        /// <param name="remainingRetentionDays"></param>
        /// <param name="accessTierInferred"></param>
        /// <param name="customerProvidedKeySha256"></param>
        /// <param name="encryptionScope"> The name of the encryption scope under which the blob is encrypted. </param>
        /// <param name="accessTierChangeTime"></param>
        /// <param name="tagCount"></param>
        /// <param name="expiresOn"></param>
        /// <param name="isSealed"></param>
        /// <param name="lastAccessedOn"></param>
        /// <param name="deleteTime"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BlobPropertiesInternal(DateTimeOffset? creationTime, DateTimeOffset lastModified, string etag, long? contentLength, string contentType, string contentEncoding, string contentLanguage, byte[] contentMD5, string contentDisposition, string cacheControl, long? blobSequenceNumber, string copyId, string copySource, string copyProgress, DateTimeOffset? copyCompletionTime, string copyStatusDescription, bool? serverEncrypted, bool? incrementalCopy, string destinationSnapshot, DateTimeOffset? deletedTime, int? remainingRetentionDays, bool? accessTierInferred, string customerProvidedKeySha256, string encryptionScope, DateTimeOffset? accessTierChangeTime, int? tagCount, DateTimeOffset? expiresOn, bool? isSealed, DateTimeOffset? lastAccessedOn, DateTimeOffset? deleteTime, Dictionary<string, BinaryData> rawData)
        {
            CreationTime = creationTime;
            LastModified = lastModified;
            Etag = etag;
            ContentLength = contentLength;
            ContentType = contentType;
            ContentEncoding = contentEncoding;
            ContentLanguage = contentLanguage;
            ContentMD5 = contentMD5;
            ContentDisposition = contentDisposition;
            CacheControl = cacheControl;
            BlobSequenceNumber = blobSequenceNumber;
            CopyId = copyId;
            CopySource = copySource;
            CopyProgress = copyProgress;
            CopyCompletionTime = copyCompletionTime;
            CopyStatusDescription = copyStatusDescription;
            ServerEncrypted = serverEncrypted;
            IncrementalCopy = incrementalCopy;
            DestinationSnapshot = destinationSnapshot;
            DeletedTime = deletedTime;
            RemainingRetentionDays = remainingRetentionDays;
            AccessTierInferred = accessTierInferred;
            CustomerProvidedKeySha256 = customerProvidedKeySha256;
            EncryptionScope = encryptionScope;
            AccessTierChangeTime = accessTierChangeTime;
            TagCount = tagCount;
            ExpiresOn = expiresOn;
            IsSealed = isSealed;
            LastAccessedOn = lastAccessedOn;
            DeleteTime = deleteTime;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="BlobPropertiesInternal"/> for deserialization. </summary>
        internal BlobPropertiesInternal()
        {
        }

        /// <summary> Gets the creation time. </summary>
        public DateTimeOffset? CreationTime { get; }
        /// <summary> Gets the last modified. </summary>
        public DateTimeOffset LastModified { get; }
        /// <summary> Gets the etag. </summary>
        public string Etag { get; }
        /// <summary> Size in bytes. </summary>
        public long? ContentLength { get; }
        /// <summary> Gets the content type. </summary>
        public string ContentType { get; }
        /// <summary> Gets the content encoding. </summary>
        public string ContentEncoding { get; }
        /// <summary> Gets the content language. </summary>
        public string ContentLanguage { get; }
        /// <summary> Gets the content md 5. </summary>
        public byte[] ContentMD5 { get; }
        /// <summary> Gets the content disposition. </summary>
        public string ContentDisposition { get; }
        /// <summary> Gets the cache control. </summary>
        public string CacheControl { get; }
        /// <summary> Gets the blob sequence number. </summary>
        public long? BlobSequenceNumber { get; }
        /// <summary> Gets the copy id. </summary>
        public string CopyId { get; }
        /// <summary> Gets the copy source. </summary>
        public string CopySource { get; }
        /// <summary> Gets the copy progress. </summary>
        public string CopyProgress { get; }
        /// <summary> Gets the copy completion time. </summary>
        public DateTimeOffset? CopyCompletionTime { get; }
        /// <summary> Gets the copy status description. </summary>
        public string CopyStatusDescription { get; }
        /// <summary> Gets the server encrypted. </summary>
        public bool? ServerEncrypted { get; }
        /// <summary> Gets the incremental copy. </summary>
        public bool? IncrementalCopy { get; }
        /// <summary> Gets the destination snapshot. </summary>
        public string DestinationSnapshot { get; }
        /// <summary> Gets the deleted time. </summary>
        public DateTimeOffset? DeletedTime { get; }
        /// <summary> Gets the remaining retention days. </summary>
        public int? RemainingRetentionDays { get; }
        /// <summary> Gets the access tier inferred. </summary>
        public bool? AccessTierInferred { get; }
        /// <summary> Gets the customer provided key sha 256. </summary>
        public string CustomerProvidedKeySha256 { get; }
        /// <summary> The name of the encryption scope under which the blob is encrypted. </summary>
        public string EncryptionScope { get; }
        /// <summary> Gets the access tier change time. </summary>
        public DateTimeOffset? AccessTierChangeTime { get; }
        /// <summary> Gets the tag count. </summary>
        public int? TagCount { get; }
        /// <summary> Gets the expires on. </summary>
        public DateTimeOffset? ExpiresOn { get; }
        /// <summary> Gets the is sealed. </summary>
        public bool? IsSealed { get; }
        /// <summary> Gets the last accessed on. </summary>
        public DateTimeOffset? LastAccessedOn { get; }
        /// <summary> Gets the delete time. </summary>
        public DateTimeOffset? DeleteTime { get; }
    }
}
