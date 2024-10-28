// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    internal partial class AddParticipantRequestInternal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SourceCallerIdNumber))
            {
                writer.WritePropertyName("sourceCallerIdNumber"u8);
                writer.WriteObjectValue(SourceCallerIdNumber);
            }
            if (Optional.IsDefined(SourceDisplayName))
            {
                writer.WritePropertyName("sourceDisplayName"u8);
                writer.WriteStringValue(SourceDisplayName);
            }
            writer.WritePropertyName("participantToAdd"u8);
            writer.WriteObjectValue(ParticipantToAdd);
            if (Optional.IsDefined(InvitationTimeoutInSeconds))
            {
                writer.WritePropertyName("invitationTimeoutInSeconds"u8);
                writer.WriteNumberValue(InvitationTimeoutInSeconds.Value);
            }
            if (Optional.IsDefined(OperationContext))
            {
                writer.WritePropertyName("operationContext"u8);
                writer.WriteStringValue(OperationContext);
            }
            if (Optional.IsDefined(OperationCallbackUri))
            {
                writer.WritePropertyName("operationCallbackUri"u8);
                writer.WriteStringValue(OperationCallbackUri);
            }
            if (Optional.IsDefined(CustomCallingContext))
            {
                writer.WritePropertyName("customCallingContext"u8);
                writer.WriteObjectValue(CustomCallingContext);
            }
            writer.WriteEndObject();
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
