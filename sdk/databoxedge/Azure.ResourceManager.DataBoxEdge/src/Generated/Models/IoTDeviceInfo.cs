// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Metadata of IoT device/IoT Edge device to be configured. </summary>
    public partial class IoTDeviceInfo
    {
        /// <summary> Initializes a new instance of IoTDeviceInfo. </summary>
        /// <param name="deviceId"> ID of the IoT device/edge device. </param>
        /// <param name="ioTHostHub"> Host name for the IoT hub associated to the device. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deviceId"/> or <paramref name="ioTHostHub"/> is null. </exception>
        public IoTDeviceInfo(string deviceId, string ioTHostHub)
        {
            if (deviceId == null)
            {
                throw new ArgumentNullException(nameof(deviceId));
            }
            if (ioTHostHub == null)
            {
                throw new ArgumentNullException(nameof(ioTHostHub));
            }

            DeviceId = deviceId;
            IoTHostHub = ioTHostHub;
        }

        /// <summary> Initializes a new instance of IoTDeviceInfo. </summary>
        /// <param name="deviceId"> ID of the IoT device/edge device. </param>
        /// <param name="ioTHostHub"> Host name for the IoT hub associated to the device. </param>
        /// <param name="ioTHostHubId"> Id for the IoT hub associated to the device. </param>
        /// <param name="authentication"> Encrypted IoT device/IoT edge device connection string. </param>
        internal IoTDeviceInfo(string deviceId, string ioTHostHub, string ioTHostHubId, Authentication authentication)
        {
            DeviceId = deviceId;
            IoTHostHub = ioTHostHub;
            IoTHostHubId = ioTHostHubId;
            Authentication = authentication;
        }

        /// <summary> ID of the IoT device/edge device. </summary>
        public string DeviceId { get; set; }
        /// <summary> Host name for the IoT hub associated to the device. </summary>
        public string IoTHostHub { get; set; }
        /// <summary> Id for the IoT hub associated to the device. </summary>
        public string IoTHostHubId { get; set; }
        /// <summary> Encrypted IoT device/IoT edge device connection string. </summary>
        internal Authentication Authentication { get; set; }
        /// <summary> Connection string based on the symmetric key. </summary>
        public AsymmetricEncryptedSecret SymmetricKeyConnectionString
        {
            get => Authentication is null ? default : Authentication.SymmetricKeyConnectionString;
            set
            {
                if (Authentication is null)
                    Authentication = new Authentication();
                Authentication.SymmetricKeyConnectionString = value;
            }
        }
    }
}
