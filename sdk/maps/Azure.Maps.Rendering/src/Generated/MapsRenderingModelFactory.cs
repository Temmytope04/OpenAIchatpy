// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Linq;

namespace Azure.Maps.Rendering
{
    /// <summary> Model factory for models. </summary>
    public static partial class MapsRenderingModelFactory
    {
        /// <summary> Initializes a new instance of CopyrightCaption. </summary>
        /// <param name="formatVersion"> Format Version property. </param>
        /// <param name="copyright"> Copyrights Caption property. </param>
        /// <returns> A new <see cref="Rendering.CopyrightCaption"/> instance for mocking. </returns>
        public static CopyrightCaption CopyrightCaption(string formatVersion = null, string copyright = null)
        {
            return new CopyrightCaption(formatVersion, copyright);
        }

        /// <summary> Initializes a new instance of RenderCopyright. </summary>
        /// <param name="formatVersion"> Format Version property. </param>
        /// <param name="generalCopyrights"> General Copyrights array. </param>
        /// <param name="regionalCopyrights"> Regions array. </param>
        /// <returns> A new <see cref="Rendering.RenderCopyright"/> instance for mocking. </returns>
        public static RenderCopyright RenderCopyright(string formatVersion = null, IEnumerable<string> generalCopyrights = null, IEnumerable<RegionalCopyright> regionalCopyrights = null)
        {
            generalCopyrights ??= new List<string>();
            regionalCopyrights ??= new List<RegionalCopyright>();

            return new RenderCopyright(formatVersion, generalCopyrights?.ToList(), regionalCopyrights?.ToList());
        }

        /// <summary> Initializes a new instance of RegionalCopyright. </summary>
        /// <param name="copyrights"> Copyrights array. </param>
        /// <param name="country"> Country property. </param>
        /// <returns> A new <see cref="Rendering.RegionalCopyright"/> instance for mocking. </returns>
        public static RegionalCopyright RegionalCopyright(IEnumerable<string> copyrights = null, RegionalCopyrightCountry country = null)
        {
            copyrights ??= new List<string>();

            return new RegionalCopyright(copyrights?.ToList(), country);
        }

        /// <summary> Initializes a new instance of RegionalCopyrightCountry. </summary>
        /// <param name="iso3"> ISO3 property. </param>
        /// <param name="label"> Label property. </param>
        /// <returns> A new <see cref="Rendering.RegionalCopyrightCountry"/> instance for mocking. </returns>
        public static RegionalCopyrightCountry RegionalCopyrightCountry(string iso3 = null, string label = null)
        {
            return new RegionalCopyrightCountry(iso3, label);
        }
    }
}
