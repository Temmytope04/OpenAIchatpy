// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The TasksState. </summary>
    internal partial class TasksState
    {
        /// <summary> Initializes a new instance of <see cref="TasksState"/>. </summary>
        /// <param name="tasks"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="tasks"/> is null. </exception>
        internal TasksState(AnalyzeTasks tasks)
        {
            if (tasks == null)
            {
                throw new ArgumentNullException(nameof(tasks));
            }

            Tasks = tasks;
        }

        /// <summary> Gets the tasks. </summary>
        public AnalyzeTasks Tasks { get; }
    }
}
