// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> Restore Settings  of the vault. </summary>
    internal partial class RestoreSettings
    {
        /// <summary> Initializes a new instance of RestoreSettings. </summary>
        public RestoreSettings()
        {
        }

        /// <summary> Initializes a new instance of RestoreSettings. </summary>
        /// <param name="crossSubscriptionRestoreSettings"> Settings for CrossSubscriptionRestore. </param>
        internal RestoreSettings(CrossSubscriptionRestoreSettings crossSubscriptionRestoreSettings)
        {
            CrossSubscriptionRestoreSettings = crossSubscriptionRestoreSettings;
        }

        /// <summary> Settings for CrossSubscriptionRestore. </summary>
        internal CrossSubscriptionRestoreSettings CrossSubscriptionRestoreSettings { get; set; }
        /// <summary> Gets or sets the cross subscription restore state. </summary>
        public CrossSubscriptionRestoreState? CrossSubscriptionRestoreState
        {
            get => CrossSubscriptionRestoreSettings is null ? default : CrossSubscriptionRestoreSettings.CrossSubscriptionRestoreState;
            set
            {
                if (CrossSubscriptionRestoreSettings is null)
                    CrossSubscriptionRestoreSettings = new CrossSubscriptionRestoreSettings();
                CrossSubscriptionRestoreSettings.CrossSubscriptionRestoreState = value;
            }
        }
    }
}
