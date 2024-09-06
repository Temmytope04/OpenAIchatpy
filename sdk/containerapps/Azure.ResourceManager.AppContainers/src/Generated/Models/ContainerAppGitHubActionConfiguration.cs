// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Configuration properties that define the mutable settings of a Container App SourceControl. </summary>
    public partial class ContainerAppGitHubActionConfiguration
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ContainerAppGitHubActionConfiguration"/>. </summary>
        public ContainerAppGitHubActionConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppGitHubActionConfiguration"/>. </summary>
        /// <param name="registryInfo"> Registry configurations. </param>
        /// <param name="azureCredentials"> AzureCredentials configurations. </param>
        /// <param name="contextPath"> Context path. </param>
        /// <param name="gitHubPersonalAccessToken"> One time Github PAT to configure github environment. </param>
        /// <param name="image"> Image name. </param>
        /// <param name="publishType"> Code or Image. </param>
        /// <param name="os"> Operation system. </param>
        /// <param name="runtimeStack"> Runtime stack. </param>
        /// <param name="runtimeVersion"> Runtime version. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerAppGitHubActionConfiguration(ContainerAppRegistryInfo registryInfo, ContainerAppCredentials azureCredentials, string contextPath, string gitHubPersonalAccessToken, string image, string publishType, string os, string runtimeStack, string runtimeVersion, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RegistryInfo = registryInfo;
            AzureCredentials = azureCredentials;
            ContextPath = contextPath;
            GitHubPersonalAccessToken = gitHubPersonalAccessToken;
            Image = image;
            PublishType = publishType;
            OS = os;
            RuntimeStack = runtimeStack;
            RuntimeVersion = runtimeVersion;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Registry configurations. </summary>
        [WirePath("registryInfo")]
        public ContainerAppRegistryInfo RegistryInfo { get; set; }
        /// <summary> AzureCredentials configurations. </summary>
        [WirePath("azureCredentials")]
        public ContainerAppCredentials AzureCredentials { get; set; }
        /// <summary> Context path. </summary>
        [WirePath("contextPath")]
        public string ContextPath { get; set; }
        /// <summary> One time Github PAT to configure github environment. </summary>
        [WirePath("githubPersonalAccessToken")]
        public string GitHubPersonalAccessToken { get; set; }
        /// <summary> Image name. </summary>
        [WirePath("image")]
        public string Image { get; set; }
        /// <summary> Code or Image. </summary>
        [WirePath("publishType")]
        public string PublishType { get; set; }
        /// <summary> Operation system. </summary>
        [WirePath("os")]
        public string OS { get; set; }
        /// <summary> Runtime stack. </summary>
        [WirePath("runtimeStack")]
        public string RuntimeStack { get; set; }
        /// <summary> Runtime version. </summary>
        [WirePath("runtimeVersion")]
        public string RuntimeVersion { get; set; }
    }
}
