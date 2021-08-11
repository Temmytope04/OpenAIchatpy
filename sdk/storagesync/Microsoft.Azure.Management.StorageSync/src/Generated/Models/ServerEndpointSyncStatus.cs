// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorageSync.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Server Endpoint sync status
    /// </summary>
    public partial class ServerEndpointSyncStatus
    {
        /// <summary>
        /// Initializes a new instance of the ServerEndpointSyncStatus class.
        /// </summary>
        public ServerEndpointSyncStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServerEndpointSyncStatus class.
        /// </summary>
        /// <param name="downloadHealth">Download Health Status. Possible
        /// values include: 'Unavailable', 'Healthy', 'Error'</param>
        /// <param name="uploadHealth">Upload Health Status. Possible values
        /// include: 'Unavailable', 'Healthy', 'Error'</param>
        /// <param name="combinedHealth">Combined Health Status. Possible
        /// values include: 'Unavailable', 'Healthy', 'Error'</param>
        /// <param name="syncActivity">Sync activity. Possible values include:
        /// 'Upload', 'Download', 'UploadAndDownload'</param>
        /// <param name="totalPersistentFilesNotSyncingCount">Total count of
        /// persistent files not syncing (combined upload + download).</param>
        /// <param name="lastUpdatedTimestamp">Last Updated Timestamp</param>
        /// <param name="uploadStatus">Upload Status</param>
        /// <param name="downloadStatus">Download Status</param>
        /// <param name="uploadActivity">Upload sync activity</param>
        /// <param name="downloadActivity">Download sync activity</param>
        /// <param name="offlineDataTransferStatus">Offline Data Transfer
        /// State. Possible values include: 'InProgress', 'Stopping',
        /// 'NotRunning', 'Complete'</param>
        /// <param name="backgroundDataDownloadActivity">Background data
        /// download activity</param>
        public ServerEndpointSyncStatus(string downloadHealth = default(string), string uploadHealth = default(string), string combinedHealth = default(string), string syncActivity = default(string), long? totalPersistentFilesNotSyncingCount = default(long?), System.DateTime? lastUpdatedTimestamp = default(System.DateTime?), ServerEndpointSyncSessionStatus uploadStatus = default(ServerEndpointSyncSessionStatus), ServerEndpointSyncSessionStatus downloadStatus = default(ServerEndpointSyncSessionStatus), ServerEndpointSyncActivityStatus uploadActivity = default(ServerEndpointSyncActivityStatus), ServerEndpointSyncActivityStatus downloadActivity = default(ServerEndpointSyncActivityStatus), string offlineDataTransferStatus = default(string), ServerEndpointBackgroundDataDownloadActivity backgroundDataDownloadActivity = default(ServerEndpointBackgroundDataDownloadActivity))
        {
            DownloadHealth = downloadHealth;
            UploadHealth = uploadHealth;
            CombinedHealth = combinedHealth;
            SyncActivity = syncActivity;
            TotalPersistentFilesNotSyncingCount = totalPersistentFilesNotSyncingCount;
            LastUpdatedTimestamp = lastUpdatedTimestamp;
            UploadStatus = uploadStatus;
            DownloadStatus = downloadStatus;
            UploadActivity = uploadActivity;
            DownloadActivity = downloadActivity;
            OfflineDataTransferStatus = offlineDataTransferStatus;
            BackgroundDataDownloadActivity = backgroundDataDownloadActivity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets download Health Status. Possible values include:
        /// 'Unavailable', 'Healthy', 'Error'
        /// </summary>
        [JsonProperty(PropertyName = "downloadHealth")]
        public string DownloadHealth { get; private set; }

        /// <summary>
        /// Gets upload Health Status. Possible values include: 'Unavailable',
        /// 'Healthy', 'Error'
        /// </summary>
        [JsonProperty(PropertyName = "uploadHealth")]
        public string UploadHealth { get; private set; }

        /// <summary>
        /// Gets combined Health Status. Possible values include:
        /// 'Unavailable', 'Healthy', 'Error'
        /// </summary>
        [JsonProperty(PropertyName = "combinedHealth")]
        public string CombinedHealth { get; private set; }

        /// <summary>
        /// Gets sync activity. Possible values include: 'Upload', 'Download',
        /// 'UploadAndDownload'
        /// </summary>
        [JsonProperty(PropertyName = "syncActivity")]
        public string SyncActivity { get; private set; }

        /// <summary>
        /// Gets total count of persistent files not syncing (combined upload +
        /// download).
        /// </summary>
        [JsonProperty(PropertyName = "totalPersistentFilesNotSyncingCount")]
        public long? TotalPersistentFilesNotSyncingCount { get; private set; }

        /// <summary>
        /// Gets last Updated Timestamp
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdatedTimestamp")]
        public System.DateTime? LastUpdatedTimestamp { get; private set; }

        /// <summary>
        /// Gets upload Status
        /// </summary>
        [JsonProperty(PropertyName = "uploadStatus")]
        public ServerEndpointSyncSessionStatus UploadStatus { get; private set; }

        /// <summary>
        /// Gets download Status
        /// </summary>
        [JsonProperty(PropertyName = "downloadStatus")]
        public ServerEndpointSyncSessionStatus DownloadStatus { get; private set; }

        /// <summary>
        /// Gets upload sync activity
        /// </summary>
        [JsonProperty(PropertyName = "uploadActivity")]
        public ServerEndpointSyncActivityStatus UploadActivity { get; private set; }

        /// <summary>
        /// Gets download sync activity
        /// </summary>
        [JsonProperty(PropertyName = "downloadActivity")]
        public ServerEndpointSyncActivityStatus DownloadActivity { get; private set; }

        /// <summary>
        /// Gets offline Data Transfer State. Possible values include:
        /// 'InProgress', 'Stopping', 'NotRunning', 'Complete'
        /// </summary>
        [JsonProperty(PropertyName = "offlineDataTransferStatus")]
        public string OfflineDataTransferStatus { get; private set; }

        /// <summary>
        /// Gets background data download activity
        /// </summary>
        [JsonProperty(PropertyName = "backgroundDataDownloadActivity")]
        public ServerEndpointBackgroundDataDownloadActivity BackgroundDataDownloadActivity { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TotalPersistentFilesNotSyncingCount < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "TotalPersistentFilesNotSyncingCount", 0);
            }
            if (UploadStatus != null)
            {
                UploadStatus.Validate();
            }
            if (DownloadStatus != null)
            {
                DownloadStatus.Validate();
            }
            if (UploadActivity != null)
            {
                UploadActivity.Validate();
            }
            if (DownloadActivity != null)
            {
                DownloadActivity.Validate();
            }
            if (BackgroundDataDownloadActivity != null)
            {
                BackgroundDataDownloadActivity.Validate();
            }
        }
    }
}
