// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> BareMetalMachineRunDataExtractsParameters represents the body of request containing list of curated data extraction commands to run on the bare metal machine. </summary>
    public partial class BareMetalMachineRunDataExtractsContent
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

        /// <summary> Initializes a new instance of <see cref="BareMetalMachineRunDataExtractsContent"/>. </summary>
        /// <param name="commands"> The list of curated data extraction commands to be executed directly against the target machine. </param>
        /// <param name="limitTimeSeconds">
        /// The maximum time the commands are allowed to run.
        /// If the execution time exceeds the maximum, the script will be stopped, any output produced until then will be captured, and the exit code matching a timeout will be returned (252).
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="commands"/> is null. </exception>
        public BareMetalMachineRunDataExtractsContent(IEnumerable<BareMetalMachineCommandSpecification> commands, long limitTimeSeconds)
        {
            Argument.AssertNotNull(commands, nameof(commands));

            Commands = commands.ToList();
            LimitTimeSeconds = limitTimeSeconds;
        }

        /// <summary> Initializes a new instance of <see cref="BareMetalMachineRunDataExtractsContent"/>. </summary>
        /// <param name="commands"> The list of curated data extraction commands to be executed directly against the target machine. </param>
        /// <param name="limitTimeSeconds">
        /// The maximum time the commands are allowed to run.
        /// If the execution time exceeds the maximum, the script will be stopped, any output produced until then will be captured, and the exit code matching a timeout will be returned (252).
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BareMetalMachineRunDataExtractsContent(IList<BareMetalMachineCommandSpecification> commands, long limitTimeSeconds, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Commands = commands;
            LimitTimeSeconds = limitTimeSeconds;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BareMetalMachineRunDataExtractsContent"/> for deserialization. </summary>
        internal BareMetalMachineRunDataExtractsContent()
        {
        }

        /// <summary> The list of curated data extraction commands to be executed directly against the target machine. </summary>
        public IList<BareMetalMachineCommandSpecification> Commands { get; }
        /// <summary>
        /// The maximum time the commands are allowed to run.
        /// If the execution time exceeds the maximum, the script will be stopped, any output produced until then will be captured, and the exit code matching a timeout will be returned (252).
        /// </summary>
        public long LimitTimeSeconds { get; }
    }
}
