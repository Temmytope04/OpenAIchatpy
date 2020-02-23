// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;

namespace Azure.AI.Search.Models
{
    internal static class QueryTypeExtensions
    {
        public static string ToSerialString(this QueryType value) => value switch
        {
            QueryType.Simple => "simple",
            QueryType.Full => "full",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown QueryType value.")
        };

        public static QueryType ToQueryType(this string value) => value switch
        {
            "simple" => QueryType.Simple,
            "full" => QueryType.Full,
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown QueryType value.")
        };
    }
}
