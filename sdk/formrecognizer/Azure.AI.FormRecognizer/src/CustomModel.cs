﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using Azure.AI.FormRecognizer.Models;
using System.Linq;

namespace Azure.AI.FormRecognizer.Training
{
    /// <summary>
    /// Description of a custom model that was trained without labels.
    /// </summary>
    public class CustomModel
    {
        internal CustomModel(Model_internal model)
        {
            LearnedPages = ConvertLearnedForms(model.Keys);
            ModelInfo = new CustomModelInfo(model.ModelInfo);
            TrainingInfo = new TrainingInfo(model.TrainResult);
        }

        /// <summary>
        /// List of forms the model learned to recognize, including form fields found in each form.
        /// </summary>
        public IReadOnlyList<CustomModelLearnedForm> LearnedPages { get; internal set; }

        /// <summary>
        /// Information about the trained model, including model ID and training completion status.
        /// </summary>
        public CustomModelInfo ModelInfo { get; internal set; }

        /// <summary>
        /// Information about documents used to train the model and errors encountered during training.
        /// </summary>
        public TrainingInfo TrainingInfo { get; internal set; }


        private static IReadOnlyList<CustomModelLearnedForm> ConvertLearnedForms(KeysResult_internal keys)
        {
            List<CustomModelLearnedForm> forms = new List<CustomModelLearnedForm>();

            foreach (var key in keys.Clusters)
            {
                CustomModelLearnedForm form = new CustomModelLearnedForm()
                {
                    FormType = key.Key,
                    // TODO: Q3
                    // https://github.com/Azure/azure-sdk-for-net/issues/10360
                    LearnedFields = new List<string>(key.Value)
                };
                forms.Add(form);
            }

            return forms;
        }
    }
}
