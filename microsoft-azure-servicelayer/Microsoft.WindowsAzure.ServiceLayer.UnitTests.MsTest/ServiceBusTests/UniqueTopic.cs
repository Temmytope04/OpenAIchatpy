﻿//
// Copyright 2012 Microsoft Corporation
// 
// Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//    http://www.apache.org/licenses/LICENSE-2.0
// 
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.ServiceLayer.ServiceBus;

namespace Microsoft.WindowsAzure.ServiceLayer.UnitTests.MsTest.ServiceBusTests
{
    /// <summary>
    /// Class for generating unique topics.
    /// </summary>
    internal class UniqueTopic: IDisposable
    {
        /// <summary>
        /// Gets the topic name.
        /// </summary>
        internal string TopicName { get; private set; }

        /// <summary>
        /// Creates a unique topic.
        /// </summary>
        internal UniqueTopic()
        {
            TopicName = Configuration.GetUniqueTopicName();
            Configuration.ServiceBus.CreateTopicAsync(TopicName).AsTask().Wait();
        }

        /// <summary>
        /// Deletes the queue.
        /// </summary>
        void IDisposable.Dispose()
        {
            Configuration.ServiceBus.DeleteTopicAsync(TopicName).AsTask().Wait();
        }
    }
}
