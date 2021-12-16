// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Microsoft.Extensions.Logging;

namespace Microsoft.Azure.WebJobs.Extensions.Tables.Tests.Samples
{
    #region Snippet:OutputMultipleModel

    public class OutputMultipleModel
    {
        [FunctionName("OutputMultipleModel")]
        public static void Run([Table("MyTable")] IAsyncCollector<MyEntity> collector)
        {
            for (int i = 0; i < 10; i++)
            {
                collector.AddAsync(new MyEntity()
                {
                    PartitionKey = "<PartitionKey>",
                    RowKey = i.ToString(),
                    Text = i.ToString()
                });
            }
        }
    }
    #endregion
}