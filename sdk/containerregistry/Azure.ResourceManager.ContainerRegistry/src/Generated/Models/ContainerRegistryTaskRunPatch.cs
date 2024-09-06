// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The parameters for updating a task run. </summary>
    public partial class ContainerRegistryTaskRunPatch
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

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryTaskRunPatch"/>. </summary>
        public ContainerRegistryTaskRunPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryTaskRunPatch"/>. </summary>
        /// <param name="identity"> Identity for the resource. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="tags"> The ARM resource tags. </param>
        /// <param name="runRequest">
        /// The request (parameters) for the new run
        /// Please note <see cref="ContainerRegistryRunContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ContainerRegistryDockerBuildContent"/>, <see cref="ContainerRegistryEncodedTaskRunContent"/>, <see cref="ContainerRegistryFileTaskRunContent"/> and <see cref="ContainerRegistryTaskRunContent"/>.
        /// </param>
        /// <param name="forceUpdateTag"> How the run should be forced to rerun even if the run request configuration has not changed. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerRegistryTaskRunPatch(ManagedServiceIdentity identity, AzureLocation? location, IDictionary<string, string> tags, ContainerRegistryRunContent runRequest, string forceUpdateTag, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Identity = identity;
            Location = location;
            Tags = tags;
            RunRequest = runRequest;
            ForceUpdateTag = forceUpdateTag;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Identity for the resource. </summary>
        [WirePath("identity")]
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The location of the resource. </summary>
        [WirePath("location")]
        public AzureLocation? Location { get; set; }
        /// <summary> The ARM resource tags. </summary>
        [WirePath("tags")]
        public IDictionary<string, string> Tags { get; }
        /// <summary>
        /// The request (parameters) for the new run
        /// Please note <see cref="ContainerRegistryRunContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ContainerRegistryDockerBuildContent"/>, <see cref="ContainerRegistryEncodedTaskRunContent"/>, <see cref="ContainerRegistryFileTaskRunContent"/> and <see cref="ContainerRegistryTaskRunContent"/>.
        /// </summary>
        [WirePath("properties.runRequest")]
        public ContainerRegistryRunContent RunRequest { get; set; }
        /// <summary> How the run should be forced to rerun even if the run request configuration has not changed. </summary>
        [WirePath("properties.forceUpdateTag")]
        public string ForceUpdateTag { get; set; }
    }
}
