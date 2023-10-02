// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Search.Documents.Models
{
    /// <summary>
    /// The query parameters for vector and hybrid search queries.
    /// Please note <see cref="VectorQuery"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="RawVectorQuery"/>.
    /// </summary>
    public abstract partial class VectorQuery
    {
        /// <summary> Initializes a new instance of VectorQuery. </summary>
        protected VectorQuery()
        {
        }

        /// <summary> Initializes a new instance of VectorQuery. </summary>
        /// <param name="kind"> The kind of vector query being performed. </param>
        /// <param name="kNearestNeighborsCount"> Number of nearest neighbors to return as top hits. </param>
        /// <param name="fieldsRaw"> Vector Fields of type Collection(Edm.Single) to be included in the vector searched. </param>
        /// <param name="exhaustive"> When true, triggers an exhaustive k-nearest neighbor search across all vectors within the vector index. Useful for scenarios where exact matches are critical, such as determining ground truth values. </param>
        internal VectorQuery(VectorQueryKind kind, int? kNearestNeighborsCount, string fieldsRaw, bool? exhaustive)
        {
            Kind = kind;
            KNearestNeighborsCount = kNearestNeighborsCount;
            FieldsRaw = fieldsRaw;
            Exhaustive = exhaustive;
        }

        /// <summary> The kind of vector query being performed. </summary>
        internal VectorQueryKind Kind { get; set; }
        /// <summary> Number of nearest neighbors to return as top hits. </summary>
        public int? KNearestNeighborsCount { get; set; }
        /// <summary> When true, triggers an exhaustive k-nearest neighbor search across all vectors within the vector index. Useful for scenarios where exact matches are critical, such as determining ground truth values. </summary>
        public bool? Exhaustive { get; set; }
    }
}
