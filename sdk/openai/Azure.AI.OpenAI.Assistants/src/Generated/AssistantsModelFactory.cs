// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.OpenAI.Assistants
{
    /// <summary> Model factory for models. </summary>
    public static partial class AssistantsModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Assistants.AssistantCreationOptions"/>. </summary>
        /// <param name="model"> The ID of the model to use. </param>
        /// <param name="name"> The name of the new assistant. </param>
        /// <param name="description"> The description of the new assistant. </param>
        /// <param name="instructions"> The system instructions for the new assistant to use. </param>
        /// <param name="tools">
        /// The collection of tools to enable for the new assistant.
        /// Please note <see cref="ToolDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="CodeInterpreterToolDefinition"/>, <see cref="FunctionToolDefinition"/> and <see cref="RetrievalToolDefinition"/>.
        /// </param>
        /// <param name="fileIds"> A list of previously uploaded file IDs to attach to the assistant. </param>
        /// <param name="metadata"> A set of up to 16 key/value pairs that can be attached to an object, used for storing additional information about that object in a structured format. Keys may be up to 64 characters in length and values may be up to 512 characters in length. </param>
        /// <returns> A new <see cref="Assistants.AssistantCreationOptions"/> instance for mocking. </returns>
        public static AssistantCreationOptions AssistantCreationOptions(string model = null, string name = null, string description = null, string instructions = null, IEnumerable<ToolDefinition> tools = null, IEnumerable<string> fileIds = null, IDictionary<string, string> metadata = null)
        {
            tools ??= new List<ToolDefinition>();
            fileIds ??= new List<string>();
            metadata ??= new Dictionary<string, string>();

            return new AssistantCreationOptions(
                model,
                name,
                description,
                instructions,
                tools?.ToList(),
                fileIds?.ToList(),
                metadata,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Assistants.ThreadInitializationMessage"/>. </summary>
        /// <param name="role"> The role associated with the assistant thread message. Currently, only 'user' is supported when providing initial messages to a new thread. </param>
        /// <param name="content"> The textual content of the initial message. Currently, robust input including images and annotated text may only be provided via a separate call to the create message API. </param>
        /// <param name="fileIds">
        /// A list of file IDs that the assistant should use. Useful for tools like retrieval and code_interpreter that can
        /// access files.
        /// </param>
        /// <param name="metadata"> A set of up to 16 key/value pairs that can be attached to an object, used for storing additional information about that object in a structured format. Keys may be up to 64 characters in length and values may be up to 512 characters in length. </param>
        /// <returns> A new <see cref="Assistants.ThreadInitializationMessage"/> instance for mocking. </returns>
        public static ThreadInitializationMessage ThreadInitializationMessage(MessageRole role = default, string content = null, IEnumerable<string> fileIds = null, IDictionary<string, string> metadata = null)
        {
            fileIds ??= new List<string>();
            metadata ??= new Dictionary<string, string>();

            return new ThreadInitializationMessage(role, content, fileIds?.ToList(), metadata, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Assistants.CreateRunOptions"/>. </summary>
        /// <param name="assistantId"> The ID of the assistant that should run the thread. </param>
        /// <param name="overrideModelName"> The overridden model name that the assistant should use to run the thread. </param>
        /// <param name="overrideInstructions"> The overridden system instructions that the assistant should use to run the thread. </param>
        /// <param name="additionalInstructions">
        /// Additional instructions to append at the end of the instructions for the run. This is useful for modifying the behavior
        /// on a per-run basis without overriding other instructions.
        /// </param>
        /// <param name="overrideTools">
        /// The overridden list of enabled tools that the assistant should use to run the thread.
        /// Please note <see cref="ToolDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="CodeInterpreterToolDefinition"/>, <see cref="FunctionToolDefinition"/> and <see cref="RetrievalToolDefinition"/>.
        /// </param>
        /// <param name="metadata"> A set of up to 16 key/value pairs that can be attached to an object, used for storing additional information about that object in a structured format. Keys may be up to 64 characters in length and values may be up to 512 characters in length. </param>
        /// <returns> A new <see cref="Assistants.CreateRunOptions"/> instance for mocking. </returns>
        public static CreateRunOptions CreateRunOptions(string assistantId = null, string overrideModelName = null, string overrideInstructions = null, string additionalInstructions = null, IEnumerable<ToolDefinition> overrideTools = null, IDictionary<string, string> metadata = null)
        {
            overrideTools ??= new List<ToolDefinition>();
            metadata ??= new Dictionary<string, string>();

            return new CreateRunOptions(
                assistantId,
                overrideModelName,
                overrideInstructions,
                additionalInstructions,
                overrideTools?.ToList(),
                metadata,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Assistants.RunError"/>. </summary>
        /// <param name="code"> The status for the error. </param>
        /// <param name="message"> The human-readable text associated with the error. </param>
        /// <returns> A new <see cref="Assistants.RunError"/> instance for mocking. </returns>
        public static RunError RunError(string code = null, string message = null)
        {
            return new RunError(code, message, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Assistants.CreateAndRunThreadOptions"/>. </summary>
        /// <param name="assistantId"> The ID of the assistant for which the thread should be created. </param>
        /// <param name="thread"> The details used to create the new thread. </param>
        /// <param name="overrideModelName"> The overridden model that the assistant should use to run the thread. </param>
        /// <param name="overrideInstructions"> The overridden system instructions the assistant should use to run the thread. </param>
        /// <param name="overrideTools">
        /// The overridden list of enabled tools the assistant should use to run the thread.
        /// Please note <see cref="ToolDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="CodeInterpreterToolDefinition"/>, <see cref="FunctionToolDefinition"/> and <see cref="RetrievalToolDefinition"/>.
        /// </param>
        /// <param name="metadata"> A set of up to 16 key/value pairs that can be attached to an object, used for storing additional information about that object in a structured format. Keys may be up to 64 characters in length and values may be up to 512 characters in length. </param>
        /// <returns> A new <see cref="Assistants.CreateAndRunThreadOptions"/> instance for mocking. </returns>
        public static CreateAndRunThreadOptions CreateAndRunThreadOptions(string assistantId = null, AssistantThreadCreationOptions thread = null, string overrideModelName = null, string overrideInstructions = null, IEnumerable<ToolDefinition> overrideTools = null, IDictionary<string, string> metadata = null)
        {
            overrideTools ??= new List<ToolDefinition>();
            metadata ??= new Dictionary<string, string>();

            return new CreateAndRunThreadOptions(
                assistantId,
                thread,
                overrideModelName,
                overrideInstructions,
                overrideTools?.ToList(),
                metadata,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Assistants.RunStepError"/>. </summary>
        /// <param name="code"> The error code for this error. </param>
        /// <param name="message"> The human-readable text associated with this error. </param>
        /// <returns> A new <see cref="Assistants.RunStepError"/> instance for mocking. </returns>
        public static RunStepError RunStepError(RunStepErrorCode code = default, string message = null)
        {
            return new RunStepError(code, message, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Assistants.RequiredToolCall"/>. </summary>
        /// <param name="type"> The object type for the required tool call. </param>
        /// <param name="id"> The ID of the tool call. This ID must be referenced when submitting tool outputs. </param>
        /// <returns> A new <see cref="Assistants.RequiredToolCall"/> instance for mocking. </returns>
        public static RequiredToolCall RequiredToolCall(string type = null, string id = null)
        {
            return new UnknownRequiredToolCall(type, id, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Assistants.RunStepToolCall"/>. </summary>
        /// <param name="type"> The object type. </param>
        /// <param name="id"> The ID of the tool call. This ID must be referenced when you submit tool outputs. </param>
        /// <returns> A new <see cref="Assistants.RunStepToolCall"/> instance for mocking. </returns>
        public static RunStepToolCall RunStepToolCall(string type = null, string id = null)
        {
            return new UnknownRunStepToolCall(type, id, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Assistants.RunStepRetrievalToolCall"/>. </summary>
        /// <param name="id"> The ID of the tool call. This ID must be referenced when you submit tool outputs. </param>
        /// <param name="retrieval"> The key/value pairs produced by the retrieval tool. </param>
        /// <returns> A new <see cref="Assistants.RunStepRetrievalToolCall"/> instance for mocking. </returns>
        public static RunStepRetrievalToolCall RunStepRetrievalToolCall(string id = null, IReadOnlyDictionary<string, string> retrieval = null)
        {
            retrieval ??= new Dictionary<string, string>();

            return new RunStepRetrievalToolCall("retrieval", id, serializedAdditionalRawData: null, retrieval);
        }

        /// <summary> Initializes a new instance of <see cref="Assistants.RunStepCodeInterpreterLogOutput"/>. </summary>
        /// <param name="logs"> The serialized log output emitted by the code interpreter. </param>
        /// <returns> A new <see cref="Assistants.RunStepCodeInterpreterLogOutput"/> instance for mocking. </returns>
        public static RunStepCodeInterpreterLogOutput RunStepCodeInterpreterLogOutput(string logs = null)
        {
            return new RunStepCodeInterpreterLogOutput("logs", serializedAdditionalRawData: null, logs);
        }

        /// <summary> Initializes a new instance of <see cref="Assistants.RunStepCodeInterpreterImageOutput"/>. </summary>
        /// <param name="image"> Referential information for the image associated with this output. </param>
        /// <returns> A new <see cref="Assistants.RunStepCodeInterpreterImageOutput"/> instance for mocking. </returns>
        public static RunStepCodeInterpreterImageOutput RunStepCodeInterpreterImageOutput(RunStepCodeInterpreterImageReference image = null)
        {
            return new RunStepCodeInterpreterImageOutput("image", serializedAdditionalRawData: null, image);
        }

        /// <summary> Initializes a new instance of <see cref="Assistants.RunStepCodeInterpreterImageReference"/>. </summary>
        /// <param name="fileId"> The ID of the file associated with this image. </param>
        /// <returns> A new <see cref="Assistants.RunStepCodeInterpreterImageReference"/> instance for mocking. </returns>
        public static RunStepCodeInterpreterImageReference RunStepCodeInterpreterImageReference(string fileId = null)
        {
            return new RunStepCodeInterpreterImageReference(fileId, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Assistants.MessageTextAnnotation"/>. </summary>
        /// <param name="type"> The object type. </param>
        /// <param name="text"> The textual content associated with this text annotation item. </param>
        /// <param name="startIndex"> The first text index associated with this text annotation. </param>
        /// <param name="endIndex"> The last text index associated with this text annotation. </param>
        /// <returns> A new <see cref="Assistants.MessageTextAnnotation"/> instance for mocking. </returns>
        public static MessageTextAnnotation MessageTextAnnotation(string type = null, string text = null, int startIndex = default, int endIndex = default)
        {
            return new UnknownMessageTextAnnotation(type, text, startIndex, endIndex, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Assistants.RunStepMessageCreationDetails"/>. </summary>
        /// <param name="messageCreation"> Information about the message creation associated with this run step. </param>
        /// <returns> A new <see cref="Assistants.RunStepMessageCreationDetails"/> instance for mocking. </returns>
        public static RunStepMessageCreationDetails RunStepMessageCreationDetails(RunStepMessageCreationReference messageCreation = null)
        {
            return new RunStepMessageCreationDetails(RunStepType.MessageCreation, serializedAdditionalRawData: null, messageCreation);
        }

        /// <summary> Initializes a new instance of <see cref="Assistants.RunStepMessageCreationReference"/>. </summary>
        /// <param name="messageId"> The ID of the message created by this run step. </param>
        /// <returns> A new <see cref="Assistants.RunStepMessageCreationReference"/> instance for mocking. </returns>
        public static RunStepMessageCreationReference RunStepMessageCreationReference(string messageId = null)
        {
            return new RunStepMessageCreationReference(messageId, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Assistants.RunStepToolCallDetails"/>. </summary>
        /// <param name="toolCalls">
        /// A list of tool call details for this run step.
        /// Please note <see cref="Assistants.RunStepToolCall"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="Assistants.RunStepCodeInterpreterToolCall"/>, <see cref="Assistants.RunStepFunctionToolCall"/> and <see cref="Assistants.RunStepRetrievalToolCall"/>.
        /// </param>
        /// <returns> A new <see cref="Assistants.RunStepToolCallDetails"/> instance for mocking. </returns>
        public static RunStepToolCallDetails RunStepToolCallDetails(IEnumerable<RunStepToolCall> toolCalls = null)
        {
            toolCalls ??= new List<RunStepToolCall>();

            return new RunStepToolCallDetails(RunStepType.ToolCalls, serializedAdditionalRawData: null, toolCalls?.ToList());
        }
    }
}
