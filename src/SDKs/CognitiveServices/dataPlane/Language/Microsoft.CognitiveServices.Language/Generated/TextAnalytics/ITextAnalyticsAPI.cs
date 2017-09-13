// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.CognitiveServices.Language.TextAnalytics
{
    using Microsoft.CognitiveServices;
    using Microsoft.CognitiveServices.Language;
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// The Text Analytics API is a suite of text analytics web services built
    /// with best-in-class Microsoft machine learning algorithms. The API can
    /// be used to analyze unstructured text for tasks such as sentiment
    /// analysis, key phrase extraction and language detection. No training
    /// data is needed to use this API; just bring your text data. This API
    /// uses advanced natural language processing techniques to deliver best in
    /// class predictions. Further documentation can be found in
    /// https://docs.microsoft.com/en-us/azure/cognitive-services/text-analytics/overview
    /// </summary>
    public partial interface ITextAnalyticsAPI : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Subscription key in header
        /// </summary>
        string SubscriptionKey { get; set; }

        /// <summary>
        /// Supported Azure regions for Cognitive Services endpoints. Possible
        /// values include: 'westus', 'westeurope', 'southeastasia', 'eastus2',
        /// 'westcentralus'
        /// </summary>
        AzureRegion Region { get; set; }


        /// <summary>
        /// The API returns a list of strings denoting the key talking points
        /// in the input text.
        /// </summary>
        /// <remarks>
        /// We employ techniques from Microsoft Office's sophisticated Natural
        /// Language Processing toolkit. See the &lt;a
        /// href="https://docs.microsoft.com/en-us/azure/cognitive-services/text-analytics/overview#supported-languages"&gt;Text
        /// Analytics Documentation&lt;/a&gt; for details about the languages
        /// that are supported by key phrase extraction.
        /// </remarks>
        /// <param name='input'>
        /// Collection of documents to analyze. Documents can now contain a
        /// language field to indicate the text language
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<KeyPhraseBatchResultV2>> KeyPhrasesWithHttpMessagesAsync(MultiLanguageBatchInputV2 input, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// The API returns the detected language and a numeric score between 0
        /// and 1.
        /// </summary>
        /// <remarks>
        /// Scores close to 1 indicate 100% certainty that the identified
        /// language is true. A total of 120 languages are supported.
        /// </remarks>
        /// <param name='input'>
        /// Collection of documents to analyze.
        /// </param>
        /// <param name='numberOfLanguagesToDetect'>
        /// (Optional. Deprecated) Number of languages to detect. Set to 1 by
        /// default. Irrespective of the value, the language with the highest
        /// score is returned.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<LanguageBatchResultV2>> DetectLanguageWithHttpMessagesAsync(BatchInputV2 input, int? numberOfLanguagesToDetect = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// The API returns a numeric score between 0 and 1.
        /// </summary>
        /// <remarks>
        /// Scores close to 1 indicate positive sentiment, while scores close
        /// to 0 indicate negative sentiment. Sentiment score is generated
        /// using classification techniques. The input features to the
        /// classifier include n-grams, features generated from part-of-speech
        /// tags, and word embeddings. See the &lt;a
        /// href="https://docs.microsoft.com/en-us/azure/cognitive-services/text-analytics/overview#supported-languages"&gt;Text
        /// Analytics Documentation&lt;/a&gt; for details about the languages
        /// that are supported by sentiment analysis.
        /// </remarks>
        /// <param name='input'>
        /// Collection of documents to analyze.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<SentimentBatchResultV2>> SentimentWithHttpMessagesAsync(MultiLanguageBatchInputV2 input, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
