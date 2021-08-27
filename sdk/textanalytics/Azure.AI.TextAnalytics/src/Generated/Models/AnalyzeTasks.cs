// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The TasksStateTasks. </summary>
    internal partial class AnalyzeTasks
    {
        /// <summary> Initializes a new instance of AnalyzeTasks. </summary>
        /// <param name="completed"></param>
        /// <param name="failed"></param>
        /// <param name="inProgress"></param>
        /// <param name="total"></param>
        internal AnalyzeTasks(int completed, int failed, int inProgress, int total)
        {
            Completed = completed;
            Failed = failed;
            InProgress = inProgress;
            Total = total;
            EntityRecognitionTasks = new ChangeTrackingList<EntityRecognitionTasksItem>();
            EntityRecognitionPiiTasks = new ChangeTrackingList<EntityRecognitionPiiTasksItem>();
            KeyPhraseExtractionTasks = new ChangeTrackingList<KeyPhraseExtractionTasksItem>();
            EntityLinkingTasks = new ChangeTrackingList<EntityLinkingTasksItem>();
            SentimentAnalysisTasks = new ChangeTrackingList<SentimentAnalysisTasksItem>();
            ExtractiveSummarizationTasks = new ChangeTrackingList<ExtractiveSummarizationTasksItem>();
            CustomEntityRecognitionTasks = new ChangeTrackingList<TasksStateTasksCustomEntityRecognitionTasksItem>();
            CustomSingleClassificationTasks = new ChangeTrackingList<TasksStateTasksCustomSingleClassificationTasksItem>();
            CustomMultiClassificationTasks = new ChangeTrackingList<TasksStateTasksCustomMultiClassificationTasksItem>();
        }

        /// <summary> Initializes a new instance of AnalyzeTasks. </summary>
        /// <param name="completed"></param>
        /// <param name="failed"></param>
        /// <param name="inProgress"></param>
        /// <param name="total"></param>
        /// <param name="entityRecognitionTasks"></param>
        /// <param name="entityRecognitionPiiTasks"></param>
        /// <param name="keyPhraseExtractionTasks"></param>
        /// <param name="entityLinkingTasks"></param>
        /// <param name="sentimentAnalysisTasks"></param>
        /// <param name="extractiveSummarizationTasks"></param>
        /// <param name="customEntityRecognitionTasks"></param>
        /// <param name="customSingleClassificationTasks"></param>
        /// <param name="customMultiClassificationTasks"></param>
        internal AnalyzeTasks(int completed, int failed, int inProgress, int total, IReadOnlyList<EntityRecognitionTasksItem> entityRecognitionTasks, IReadOnlyList<EntityRecognitionPiiTasksItem> entityRecognitionPiiTasks, IReadOnlyList<KeyPhraseExtractionTasksItem> keyPhraseExtractionTasks, IReadOnlyList<EntityLinkingTasksItem> entityLinkingTasks, IReadOnlyList<SentimentAnalysisTasksItem> sentimentAnalysisTasks, IReadOnlyList<ExtractiveSummarizationTasksItem> extractiveSummarizationTasks, IReadOnlyList<TasksStateTasksCustomEntityRecognitionTasksItem> customEntityRecognitionTasks, IReadOnlyList<TasksStateTasksCustomSingleClassificationTasksItem> customSingleClassificationTasks, IReadOnlyList<TasksStateTasksCustomMultiClassificationTasksItem> customMultiClassificationTasks)
        {
            Completed = completed;
            Failed = failed;
            InProgress = inProgress;
            Total = total;
            EntityRecognitionTasks = entityRecognitionTasks;
            EntityRecognitionPiiTasks = entityRecognitionPiiTasks;
            KeyPhraseExtractionTasks = keyPhraseExtractionTasks;
            EntityLinkingTasks = entityLinkingTasks;
            SentimentAnalysisTasks = sentimentAnalysisTasks;
            ExtractiveSummarizationTasks = extractiveSummarizationTasks;
            CustomEntityRecognitionTasks = customEntityRecognitionTasks;
            CustomSingleClassificationTasks = customSingleClassificationTasks;
            CustomMultiClassificationTasks = customMultiClassificationTasks;
        }

        /// <summary> Gets the completed. </summary>
        public int Completed { get; }
        /// <summary> Gets the failed. </summary>
        public int Failed { get; }
        /// <summary> Gets the in progress. </summary>
        public int InProgress { get; }
        /// <summary> Gets the total. </summary>
        public int Total { get; }
        /// <summary> Gets the entity recognition tasks. </summary>
        public IReadOnlyList<EntityRecognitionTasksItem> EntityRecognitionTasks { get; }
        /// <summary> Gets the entity recognition pii tasks. </summary>
        public IReadOnlyList<EntityRecognitionPiiTasksItem> EntityRecognitionPiiTasks { get; }
        /// <summary> Gets the key phrase extraction tasks. </summary>
        public IReadOnlyList<KeyPhraseExtractionTasksItem> KeyPhraseExtractionTasks { get; }
        /// <summary> Gets the entity linking tasks. </summary>
        public IReadOnlyList<EntityLinkingTasksItem> EntityLinkingTasks { get; }
        /// <summary> Gets the sentiment analysis tasks. </summary>
        public IReadOnlyList<SentimentAnalysisTasksItem> SentimentAnalysisTasks { get; }
        /// <summary> Gets the extractive summarization tasks. </summary>
        public IReadOnlyList<ExtractiveSummarizationTasksItem> ExtractiveSummarizationTasks { get; }
        public IReadOnlyList<TasksStateTasksCustomEntityRecognitionTasksItem> CustomEntityRecognitionTasks { get; }
        public IReadOnlyList<TasksStateTasksCustomSingleClassificationTasksItem> CustomSingleClassificationTasks { get; }
        public IReadOnlyList<TasksStateTasksCustomMultiClassificationTasksItem> CustomMultiClassificationTasks { get; }
    }
}
