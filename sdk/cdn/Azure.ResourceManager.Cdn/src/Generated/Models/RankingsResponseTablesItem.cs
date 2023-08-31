// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The RankingsResponseTablesItem. </summary>
    public partial class RankingsResponseTablesItem
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RankingsResponseTablesItem"/>. </summary>
        internal RankingsResponseTablesItem()
        {
            Data = new ChangeTrackingList<RankingsResponseTablesPropertiesItemsItem>();
        }

        /// <summary> Initializes a new instance of <see cref="RankingsResponseTablesItem"/>. </summary>
        /// <param name="ranking"></param>
        /// <param name="data"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RankingsResponseTablesItem(string ranking, IReadOnlyList<RankingsResponseTablesPropertiesItemsItem> data, Dictionary<string, BinaryData> rawData)
        {
            Ranking = ranking;
            Data = data;
            _rawData = rawData;
        }

        /// <summary> Gets the ranking. </summary>
        public string Ranking { get; }
        /// <summary> Gets the data. </summary>
        public IReadOnlyList<RankingsResponseTablesPropertiesItemsItem> Data { get; }
    }
}
