// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Template.Models
{
    /// <summary> Model to illustrate a nested model that only appears on a nested model. </summary>
    public partial class NestedRoundTripOnlyModel
    {
        /// <summary> Initializes a new instance of NestedRoundTripOnlyModel. </summary>
        /// <param name="requiredString"> Required string, illustrating a reference type property. </param>
        /// <param name="requiredInt"> Required int, illustrating a value type property. </param>
        /// <param name="requiredStringList"> Required collection of strings, illustrating a collection of reference types. </param>
        /// <param name="requiredIntList"> Required collection of ints, illustrating a collection of value types. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="requiredString"/>, <paramref name="requiredStringList"/> or <paramref name="requiredIntList"/> is null. </exception>
        public NestedRoundTripOnlyModel(string requiredString, int requiredInt, IEnumerable<string> requiredStringList, IEnumerable<int> requiredIntList)
        {
            if (requiredString == null)
            {
                throw new ArgumentNullException(nameof(requiredString));
            }
            if (requiredStringList == null)
            {
                throw new ArgumentNullException(nameof(requiredStringList));
            }
            if (requiredIntList == null)
            {
                throw new ArgumentNullException(nameof(requiredIntList));
            }

            RequiredString = requiredString;
            RequiredInt = requiredInt;
            RequiredStringList = requiredStringList.ToList();
            RequiredIntList = requiredIntList.ToList();
        }

        /// <summary> Initializes a new instance of NestedRoundTripOnlyModel. </summary>
        /// <param name="requiredString"> Required string, illustrating a reference type property. </param>
        /// <param name="requiredInt"> Required int, illustrating a value type property. </param>
        /// <param name="requiredStringList"> Required collection of strings, illustrating a collection of reference types. </param>
        /// <param name="requiredIntList"> Required collection of ints, illustrating a collection of value types. </param>
        internal NestedRoundTripOnlyModel(string requiredString, int requiredInt, IList<string> requiredStringList, IList<int> requiredIntList)
        {
            RequiredString = requiredString;
            RequiredInt = requiredInt;
            RequiredStringList = requiredStringList;
            RequiredIntList = requiredIntList;
        }

        /// <summary> Required string, illustrating a reference type property. </summary>
        public string RequiredString { get; set; }
        /// <summary> Required int, illustrating a value type property. </summary>
        public int RequiredInt { get; set; }
        /// <summary> Required collection of strings, illustrating a collection of reference types. </summary>
        public IList<string> RequiredStringList { get; }
        /// <summary> Required collection of ints, illustrating a collection of value types. </summary>
        public IList<int> RequiredIntList { get; }
    }
}
