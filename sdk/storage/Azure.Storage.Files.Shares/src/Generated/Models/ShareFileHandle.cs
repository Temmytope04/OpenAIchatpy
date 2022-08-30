// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Storage.Files.Shares.Models
{
    /// <summary> A listed Azure Storage handle item. </summary>
    public partial class ShareFileHandle
    {
        /// <summary> Initializes a new instance of ShareFileHandle. </summary>
        /// <param name="handleId"> XSMB service handle ID. </param>
        /// <param name="path"></param>
        /// <param name="fileId"> FileId uniquely identifies the file or directory. </param>
        /// <param name="sessionId"> SMB session ID in context of which the file handle was opened. </param>
        /// <param name="clientIp"> Client IP that opened the handle. </param>
        /// <param name="openedOn"> Time when the session that previously opened the handle has last been reconnected. (UTC). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="handleId"/>, <paramref name="path"/>, <paramref name="fileId"/>, <paramref name="sessionId"/> or <paramref name="clientIp"/> is null. </exception>
        internal ShareFileHandle(string handleId, StringEncoded path, string fileId, string sessionId, string clientIp, DateTimeOffset? openedOn)
        {
            if (handleId == null)
            {
                throw new ArgumentNullException(nameof(handleId));
            }
            if (path == null)
            {
                throw new ArgumentNullException(nameof(path));
            }
            if (fileId == null)
            {
                throw new ArgumentNullException(nameof(fileId));
            }
            if (sessionId == null)
            {
                throw new ArgumentNullException(nameof(sessionId));
            }
            if (clientIp == null)
            {
                throw new ArgumentNullException(nameof(clientIp));
            }

            HandleId = handleId;
            Path = path;
            FileId = fileId;
            SessionId = sessionId;
            ClientIp = clientIp;
            OpenedOn = openedOn;
        }

        /// <summary> Initializes a new instance of ShareFileHandle. </summary>
        /// <param name="handleId"> XSMB service handle ID. </param>
        /// <param name="path"></param>
        /// <param name="fileId"> FileId uniquely identifies the file or directory. </param>
        /// <param name="parentId"> ParentId uniquely identifies the parent directory of the object. </param>
        /// <param name="sessionId"> SMB session ID in context of which the file handle was opened. </param>
        /// <param name="clientIp"> Client IP that opened the handle. </param>
        /// <param name="openedOn"> Time when the session that previously opened the handle has last been reconnected. (UTC). </param>
        /// <param name="lastReconnectedOn"> Time handle was last connected to (UTC). </param>
        internal ShareFileHandle(string handleId, StringEncoded path, string fileId, string parentId, string sessionId, string clientIp, DateTimeOffset? openedOn, DateTimeOffset? lastReconnectedOn)
        {
            HandleId = handleId;
            Path = path;
            FileId = fileId;
            ParentId = parentId;
            SessionId = sessionId;
            ClientIp = clientIp;
            OpenedOn = openedOn;
            LastReconnectedOn = lastReconnectedOn;
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
    }
}
