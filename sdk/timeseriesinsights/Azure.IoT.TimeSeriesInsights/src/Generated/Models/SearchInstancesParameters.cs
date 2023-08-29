// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.IoT.TimeSeriesInsights
{
    /// <summary> Parameters of how to return time series instances by search instances call. </summary>
    internal partial class SearchInstancesParameters
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SearchInstancesParameters"/>. </summary>
        public SearchInstancesParameters()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SearchInstancesParameters"/>. </summary>
        /// <param name="recursive"> Definition of which instances are returned. When recursive is set to 'true', all instances that have the path that starts with path the path parameter are returned. When recursive is set to 'false', only instances that have the path that exactly matches the path parameter are returned. Using recursive search allows to implement search user experience, while using non-recursive search allows to implement navigation experience. Optional, default is 'true'. </param>
        /// <param name="sort"> Definition of how time series instances are sorted before being returned by search instances call - relevance or alphabetical. Optional, default is "Rank". </param>
        /// <param name="highlights"> Definition of highlighted search results or not. When it is set to 'true', the highlighted search results are returned. When it is set to 'false', the highlighted search results are not returned. Default is 'true'. </param>
        /// <param name="pageSize"> Maximum number of instances expected in each page of the result. Defaults to 10 when not set. Ranges from 1 to 100. If there are results beyond the page size, the user can use the continuation token to fetch the next page. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SearchInstancesParameters(bool? recursive, InstancesSortParameter sort, bool? highlights, int? pageSize, Dictionary<string, BinaryData> rawData)
        {
            Recursive = recursive;
            Sort = sort;
            Highlights = highlights;
            PageSize = pageSize;
            _rawData = rawData;
        }

        /// <summary> Definition of which instances are returned. When recursive is set to 'true', all instances that have the path that starts with path the path parameter are returned. When recursive is set to 'false', only instances that have the path that exactly matches the path parameter are returned. Using recursive search allows to implement search user experience, while using non-recursive search allows to implement navigation experience. Optional, default is 'true'. </summary>
        public bool? Recursive { get; set; }
        /// <summary> Definition of how time series instances are sorted before being returned by search instances call - relevance or alphabetical. Optional, default is "Rank". </summary>
        public InstancesSortParameter Sort { get; set; }
        /// <summary> Definition of highlighted search results or not. When it is set to 'true', the highlighted search results are returned. When it is set to 'false', the highlighted search results are not returned. Default is 'true'. </summary>
        public bool? Highlights { get; set; }
        /// <summary> Maximum number of instances expected in each page of the result. Defaults to 10 when not set. Ranges from 1 to 100. If there are results beyond the page size, the user can use the continuation token to fetch the next page. </summary>
        public int? PageSize { get; set; }
    }
}
