// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure;

namespace Azure.AI.OpenAI
{
    /// <summary> Model factory for models. </summary>
    public static partial class AzureOpenAIModelFactory
    {
        /// <summary> Initializes a new instance of AudioTranscriptionSegment. </summary>
        /// <param name="id"> Segment identifier. </param>
        /// <param name="start"> Segment start offset. </param>
        /// <param name="end"> Segment end offset. </param>
        /// <param name="text"> Segment text. </param>
        /// <param name="temperature"> Temperature. </param>
        /// <param name="averageLogProb"> Average log probability. </param>
        /// <param name="compressionRatio"> Compression ratio. </param>
        /// <param name="noSpeechProb"> Probability of 'no speech'. </param>
        /// <param name="tokens"> Tokens in this segment. </param>
        /// <param name="seek"> TODO. </param>
        /// <returns> A new <see cref="OpenAI.AudioTranscriptionSegment"/> instance for mocking. </returns>
        public static AudioTranscriptionSegment AudioTranscriptionSegment(int id = default, float start = default, float end = default, string text = null, float temperature = default, float averageLogProb = default, float compressionRatio = default, float noSpeechProb = default, IEnumerable<int> tokens = null, int seek = default)
        {
            tokens ??= new List<int>();

            return new AudioTranscriptionSegment(id, start, end, text, temperature, averageLogProb, compressionRatio, noSpeechProb, tokens?.ToList(), seek);
        }

        /// <summary> Initializes a new instance of Completions. </summary>
        /// <param name="id"> A unique identifier associated with this completions response. </param>
        /// <param name="created">
        /// The first timestamp associated with generation activity for this completions response,
        /// represented as seconds since the beginning of the Unix epoch of 00:00 on 1 Jan 1970.
        /// </param>
        /// <param name="promptFilterResults">
        /// Content filtering results for zero or more prompts in the request. In a streaming request,
        /// results for different prompts may arrive at different times or in different orders.
        /// </param>
        /// <param name="choices">
        /// The collection of completions choices associated with this completions response.
        /// Generally, `n` choices are generated per provided prompt with a default value of 1.
        /// Token limits and other settings may limit the number of choices generated.
        /// </param>
        /// <param name="usage"> Usage information for tokens processed and generated as part of this completions operation. </param>
        /// <returns> A new <see cref="OpenAI.Completions"/> instance for mocking. </returns>
        public static Completions Completions(string id = null, DateTimeOffset created = default, IEnumerable<PromptFilterResult> promptFilterResults = null, IEnumerable<Choice> choices = null, CompletionsUsage usage = null)
        {
            promptFilterResults ??= new List<PromptFilterResult>();
            choices ??= new List<Choice>();

            return new Completions(id, created, promptFilterResults?.ToList(), choices?.ToList(), usage);
        }

        /// <summary> Initializes a new instance of PromptFilterResult. </summary>
        /// <param name="promptIndex"> The index of this prompt in the set of prompt results. </param>
        /// <param name="contentFilterResults"> Content filtering results for this prompt. </param>
        /// <returns> A new <see cref="OpenAI.PromptFilterResult"/> instance for mocking. </returns>
        public static PromptFilterResult PromptFilterResult(int promptIndex = default, ContentFilterResults contentFilterResults = null)
        {
            return new PromptFilterResult(promptIndex, contentFilterResults);
        }

        /// <summary> Initializes a new instance of ContentFilterResults. </summary>
        /// <param name="sexual">
        /// Describes language related to anatomical organs and genitals, romantic relationships,
        ///  acts portrayed in erotic or affectionate terms, physical sexual acts, including
        ///  those portrayed as an assault or a forced sexual violent act against one’s will,
        ///  prostitution, pornography, and abuse.
        /// </param>
        /// <param name="violence">
        /// Describes language related to physical actions intended to hurt, injure, damage, or
        /// kill someone or something; describes weapons, etc.
        /// </param>
        /// <param name="hate">
        /// Describes language attacks or uses that include pejorative or discriminatory language
        /// with reference to a person or identity group on the basis of certain differentiating
        /// attributes of these groups including but not limited to race, ethnicity, nationality,
        /// gender identity and expression, sexual orientation, religion, immigration status, ability
        /// status, personal appearance, and body size.
        /// </param>
        /// <param name="selfHarm">
        /// Describes language related to physical actions intended to purposely hurt, injure,
        /// or damage one’s body, or kill oneself.
        /// </param>
        /// <param name="error">
        /// Describes an error returned if the content filtering system is
        /// down or otherwise unable to complete the operation in time.
        /// </param>
        /// <returns> A new <see cref="OpenAI.ContentFilterResults"/> instance for mocking. </returns>
        public static ContentFilterResults ContentFilterResults(ContentFilterResult sexual = null, ContentFilterResult violence = null, ContentFilterResult hate = null, ContentFilterResult selfHarm = null, ResponseError error = null)
        {
            return new ContentFilterResults(sexual, violence, hate, selfHarm, error);
        }

        /// <summary> Initializes a new instance of ContentFilterResult. </summary>
        /// <param name="severity"> Ratings for the intensity and risk level of filtered content. </param>
        /// <param name="filtered"> A value indicating whether or not the content has been filtered. </param>
        /// <returns> A new <see cref="OpenAI.ContentFilterResult"/> instance for mocking. </returns>
        public static ContentFilterResult ContentFilterResult(ContentFilterSeverity severity = default, bool filtered = default)
        {
            return new ContentFilterResult(severity, filtered);
        }

        /// <summary> Initializes a new instance of Choice. </summary>
        /// <param name="text"> The generated text for a given completions prompt. </param>
        /// <param name="index"> The ordered index associated with this completions choice. </param>
        /// <param name="contentFilterResults">
        /// Information about the content filtering category (hate, sexual, violence, self_harm), if it
        /// has been detected, as well as the severity level (very_low, low, medium, high-scale that
        /// determines the intensity and risk level of harmful content) and if it has been filtered or not.
        /// </param>
        /// <param name="logProbabilityModel"> The log probabilities model for tokens associated with this completions choice. </param>
        /// <param name="finishReason"> Reason for finishing. </param>
        /// <returns> A new <see cref="OpenAI.Choice"/> instance for mocking. </returns>
        public static Choice Choice(string text = null, int index = default, ContentFilterResults contentFilterResults = null, CompletionsLogProbabilityModel logProbabilityModel = null, CompletionsFinishReason? finishReason = null)
        {
            return new Choice(text, index, contentFilterResults, logProbabilityModel, finishReason);
        }

        /// <summary> Initializes a new instance of CompletionsLogProbabilityModel. </summary>
        /// <param name="tokens"> The textual forms of tokens evaluated in this probability model. </param>
        /// <param name="tokenLogProbabilities"> A collection of log probability values for the tokens in this completions data. </param>
        /// <param name="topLogProbabilities"> A mapping of tokens to maximum log probability values in this completions data. </param>
        /// <param name="textOffsets"> The text offsets associated with tokens in this completions data. </param>
        /// <returns> A new <see cref="OpenAI.CompletionsLogProbabilityModel"/> instance for mocking. </returns>
        public static CompletionsLogProbabilityModel CompletionsLogProbabilityModel(IEnumerable<string> tokens = null, IEnumerable<float?> tokenLogProbabilities = null, IEnumerable<IDictionary<string, float?>> topLogProbabilities = null, IEnumerable<int> textOffsets = null)
        {
            tokens ??= new List<string>();
            tokenLogProbabilities ??= new List<float?>();
            topLogProbabilities ??= new List<IDictionary<string, float?>>();
            textOffsets ??= new List<int>();

            return new CompletionsLogProbabilityModel(tokens?.ToList(), tokenLogProbabilities?.ToList(), topLogProbabilities?.ToList(), textOffsets?.ToList());
        }

        /// <summary> Initializes a new instance of CompletionsUsage. </summary>
        /// <param name="completionTokens"> The number of tokens generated across all completions emissions. </param>
        /// <param name="promptTokens"> The number of tokens in the provided prompts for the completions request. </param>
        /// <param name="totalTokens"> The total number of tokens processed for the completions request and response. </param>
        /// <returns> A new <see cref="OpenAI.CompletionsUsage"/> instance for mocking. </returns>
        public static CompletionsUsage CompletionsUsage(int completionTokens = default, int promptTokens = default, int totalTokens = default)
        {
            return new CompletionsUsage(completionTokens, promptTokens, totalTokens);
        }

        /// <summary> Initializes a new instance of ChatCompletions. </summary>
        /// <param name="id"> A unique identifier associated with this chat completions response. </param>
        /// <param name="created">
        /// The first timestamp associated with generation activity for this completions response,
        /// represented as seconds since the beginning of the Unix epoch of 00:00 on 1 Jan 1970.
        /// </param>
        /// <param name="choices">
        /// The collection of completions choices associated with this completions response.
        /// Generally, `n` choices are generated per provided prompt with a default value of 1.
        /// Token limits and other settings may limit the number of choices generated.
        /// </param>
        /// <param name="promptFilterResults">
        /// Content filtering results for zero or more prompts in the request. In a streaming request,
        /// results for different prompts may arrive at different times or in different orders.
        /// </param>
        /// <param name="usage"> Usage information for tokens processed and generated as part of this completions operation. </param>
        /// <returns> A new <see cref="OpenAI.ChatCompletions"/> instance for mocking. </returns>
        public static ChatCompletions ChatCompletions(string id = null, DateTimeOffset created = default, IEnumerable<ChatChoice> choices = null, IEnumerable<PromptFilterResult> promptFilterResults = null, CompletionsUsage usage = null)
        {
            choices ??= new List<ChatChoice>();
            promptFilterResults ??= new List<PromptFilterResult>();

            return new ChatCompletions(id, created, choices?.ToList(), promptFilterResults?.ToList(), usage);
        }

        /// <summary> Initializes a new instance of Embeddings. </summary>
        /// <param name="data"> Embedding values for the prompts submitted in the request. </param>
        /// <param name="usage"> Usage counts for tokens input using the embeddings API. </param>
        /// <returns> A new <see cref="OpenAI.Embeddings"/> instance for mocking. </returns>
        public static Embeddings Embeddings(IEnumerable<EmbeddingItem> data = null, EmbeddingsUsage usage = null)
        {
            data ??= new List<EmbeddingItem>();

            return new Embeddings(data?.ToList(), usage);
        }

        /// <summary> Initializes a new instance of EmbeddingItem. </summary>
        /// <param name="embedding">
        /// List of embeddings value for the input prompt. These represent a measurement of the
        /// vector-based relatedness of the provided input.
        /// </param>
        /// <param name="index"> Index of the prompt to which the EmbeddingItem corresponds. </param>
        /// <returns> A new <see cref="OpenAI.EmbeddingItem"/> instance for mocking. </returns>
        public static EmbeddingItem EmbeddingItem(IEnumerable<float> embedding = null, int index = default)
        {
            embedding ??= new List<float>();

            return new EmbeddingItem(embedding?.ToList(), index);
        }

        /// <summary> Initializes a new instance of EmbeddingsUsage. </summary>
        /// <param name="promptTokens"> Number of tokens sent in the original request. </param>
        /// <param name="totalTokens"> Total number of tokens transacted in this request/response. </param>
        /// <returns> A new <see cref="OpenAI.EmbeddingsUsage"/> instance for mocking. </returns>
        public static EmbeddingsUsage EmbeddingsUsage(int promptTokens = default, int totalTokens = default)
        {
            return new EmbeddingsUsage(promptTokens, totalTokens);
        }

        /// <summary> Initializes a new instance of ImageGenerations. </summary>
        /// <param name="created"> A timestamp when this job or item was created (in unix epochs). </param>
        /// <param name="data"> The images generated by the operator. </param>
        /// <returns> A new <see cref="OpenAI.ImageGenerations"/> instance for mocking. </returns>
        public static ImageGenerations ImageGenerations(DateTimeOffset created = default, IEnumerable<ImageLocation> data = null)
        {
            data ??= new List<ImageLocation>();

            return new ImageGenerations(created, data?.ToList());
        }

        /// <summary> Initializes a new instance of ImageLocation. </summary>
        /// <param name="url"> The URL that provides temporary access to download the generated image. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="url"/> is null. </exception>
        /// <returns> A new <see cref="OpenAI.ImageLocation"/> instance for mocking. </returns>
        public static ImageLocation ImageLocation(Uri url = null)
        {
            if (url == null)
            {
                throw new ArgumentNullException(nameof(url));
            }

            return new ImageLocation(url);
        }
    }
}
