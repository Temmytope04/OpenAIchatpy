// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Storage.Files.Shares.Models
{
    /// <summary> A listed Azure Storage handle item. </summary>
    internal partial class HandleItem
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="HandleItem"/>. </summary>
        /// <param name="handleId"> XSMB service handle ID. </param>
        /// <param name="path"></param>
        /// <param name="fileId"> FileId uniquely identifies the file or directory. </param>
        /// <param name="sessionId"> SMB session ID in context of which the file handle was opened. </param>
        /// <param name="clientIp"> Client IP that opened the handle. </param>
        /// <param name="openTime"> Time when the session that previously opened the handle has last been reconnected. (UTC). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="handleId"/>, <paramref name="path"/>, <paramref name="fileId"/>, <paramref name="sessionId"/> or <paramref name="clientIp"/> is null. </exception>
        internal HandleItem(string handleId, StringEncoded path, string fileId, string sessionId, string clientIp, DateTimeOffset openTime)
        {
            Argument.AssertNotNull(handleId, nameof(handleId));
            Argument.AssertNotNull(path, nameof(path));
            Argument.AssertNotNull(fileId, nameof(fileId));
            Argument.AssertNotNull(sessionId, nameof(sessionId));
            Argument.AssertNotNull(clientIp, nameof(clientIp));

            HandleId = handleId;
            Path = path;
            FileId = fileId;
            SessionId = sessionId;
            ClientIp = clientIp;
            OpenTime = openTime;
            AccessRightList = new ChangeTrackingList<AccessRight>();
        }

        /// <summary> Initializes a new instance of <see cref="HandleItem"/>. </summary>
        /// <param name="handleId"> XSMB service handle ID. </param>
        /// <param name="path"></param>
        /// <param name="fileId"> FileId uniquely identifies the file or directory. </param>
        /// <param name="parentId"> ParentId uniquely identifies the parent directory of the object. </param>
        /// <param name="sessionId"> SMB session ID in context of which the file handle was opened. </param>
        /// <param name="clientIp"> Client IP that opened the handle. </param>
        /// <param name="openTime"> Time when the session that previously opened the handle has last been reconnected. (UTC). </param>
        /// <param name="lastReconnectTime"> Time handle was last connected to (UTC). </param>
        /// <param name="accessRightList"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal HandleItem(string handleId, StringEncoded path, string fileId, string parentId, string sessionId, string clientIp, DateTimeOffset openTime, DateTimeOffset? lastReconnectTime, IReadOnlyList<AccessRight> accessRightList, Dictionary<string, BinaryData> rawData)
        {
            HandleId = handleId;
            Path = path;
            FileId = fileId;
            ParentId = parentId;
            SessionId = sessionId;
            ClientIp = clientIp;
            OpenTime = openTime;
            LastReconnectTime = lastReconnectTime;
            AccessRightList = accessRightList;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="HandleItem"/> for deserialization. </summary>
        internal HandleItem()
        {
        }

        /// <summary> XSMB service handle ID. </summary>
        public string HandleId { get; }
        /// <summary> Gets the path. </summary>
        public StringEncoded Path { get; }
        /// <summary> FileId uniquely identifies the file or directory. </summary>
        public string FileId { get; }
        /// <summary> ParentId uniquely identifies the parent directory of the object. </summary>
        public string ParentId { get; }
        /// <summary> SMB session ID in context of which the file handle was opened. </summary>
        public string SessionId { get; }
        /// <summary> Client IP that opened the handle. </summary>
        public string ClientIp { get; }
        /// <summary> Time when the session that previously opened the handle has last been reconnected. (UTC). </summary>
        public DateTimeOffset OpenTime { get; }
        /// <summary> Time handle was last connected to (UTC). </summary>
        public DateTimeOffset? LastReconnectTime { get; }
        /// <summary> Gets the access right list. </summary>
        public IReadOnlyList<AccessRight> AccessRightList { get; }
    }
}
