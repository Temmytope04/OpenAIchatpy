// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> BackupAndExport API Request. </summary>
    public partial class MySqlFlexibleServerBackupAndExportContent : MySqlFlexibleServerBackupContentBase
    {
        /// <summary> Initializes a new instance of MySqlFlexibleServerBackupAndExportContent. </summary>
        /// <param name="backupSettings"> Backup Settings. </param>
        /// <param name="targetDetails">
        /// Backup Target Store Details
        /// Please note <see cref="MySqlFlexibleServerBackupStoreDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MySqlFlexibleServerFullBackupStoreDetails"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="backupSettings"/> or <paramref name="targetDetails"/> is null. </exception>
        public MySqlFlexibleServerBackupAndExportContent(MySqlFlexibleServerBackupSettings backupSettings, MySqlFlexibleServerBackupStoreDetails targetDetails) : base(backupSettings)
        {
            Argument.AssertNotNull(backupSettings, nameof(backupSettings));
            Argument.AssertNotNull(targetDetails, nameof(targetDetails));

            TargetDetails = targetDetails;
        }

        /// <summary>
        /// Backup Target Store Details
        /// Please note <see cref="MySqlFlexibleServerBackupStoreDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MySqlFlexibleServerFullBackupStoreDetails"/>.
        /// </summary>
        public MySqlFlexibleServerBackupStoreDetails TargetDetails { get; }
    }
}
