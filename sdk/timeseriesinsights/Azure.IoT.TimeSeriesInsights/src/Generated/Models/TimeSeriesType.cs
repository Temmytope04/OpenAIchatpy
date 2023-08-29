// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.IoT.TimeSeriesInsights
{
    /// <summary> Time series type defines variables or formulas for doing computation on events associated with time series instances. Each time series instance is associated with exactly one type. A type can have one or more variables. For example, a time series instance might be of type Temperature Sensor, which consists of the variables avg temperature, min temperature, and max temperature. </summary>
    public partial class TimeSeriesType
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="TimeSeriesType"/>. </summary>
        /// <param name="name"> User-given unique name for the type. Mutable, not null. </param>
        /// <param name="variables">
        /// Different variables associated with the type. Not empty, not null.
        /// Please note <see cref="TimeSeriesVariable"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AggregateVariable"/>, <see cref="CategoricalVariable"/> and <see cref="NumericVariable"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="variables"/> is null. </exception>
        public TimeSeriesType(string name, IDictionary<string, TimeSeriesVariable> variables)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(variables, nameof(variables));

            Name = name;
            Variables = variables;
        }

        /// <summary> Initializes a new instance of <see cref="TimeSeriesType"/>. </summary>
        /// <param name="id"> Case-sensitive unique type identifier that is immutable. Can be null on create or update requests, and then server generates the ID. Not null on get and delete operations. </param>
        /// <param name="name"> User-given unique name for the type. Mutable, not null. </param>
        /// <param name="description"> Description of the type. May be null. </param>
        /// <param name="variables">
        /// Different variables associated with the type. Not empty, not null.
        /// Please note <see cref="TimeSeriesVariable"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AggregateVariable"/>, <see cref="CategoricalVariable"/> and <see cref="NumericVariable"/>.
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal TimeSeriesType(string id, string name, string description, IDictionary<string, TimeSeriesVariable> variables, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            Name = name;
            Description = description;
            Variables = variables;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="TimeSeriesType"/> for deserialization. </summary>
        internal TimeSeriesType()
        {
        }

        /// <summary> Case-sensitive unique type identifier that is immutable. Can be null on create or update requests, and then server generates the ID. Not null on get and delete operations. </summary>
        public string Id { get; set; }
        /// <summary> User-given unique name for the type. Mutable, not null. </summary>
        public string Name { get; set; }
        /// <summary> Description of the type. May be null. </summary>
        public string Description { get; set; }
        /// <summary>
        /// Different variables associated with the type. Not empty, not null.
        /// Please note <see cref="TimeSeriesVariable"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AggregateVariable"/>, <see cref="CategoricalVariable"/> and <see cref="NumericVariable"/>.
        /// </summary>
        public IDictionary<string, TimeSeriesVariable> Variables { get; }
    }
}
