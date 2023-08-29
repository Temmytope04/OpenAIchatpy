// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.Translation.Text
{
    /// <summary> Script definition with list of script into which given script can be translitered. </summary>
    public partial class TransliterableScript : CommonScriptModel
    {
        /// <summary> Initializes a new instance of TransliterableScript. </summary>
        /// <param name="code"> Code identifying the script. </param>
        /// <param name="name"> Display name of the script in the locale requested via Accept-Language header. </param>
        /// <param name="nativeName"> Display name of the language in the locale native for the language. </param>
        /// <param name="dir"> Directionality, which is rtl for right-to-left languages or ltr for left-to-right languages. </param>
        /// <param name="toScripts"> List of scripts available to convert text to. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="code"/>, <paramref name="name"/>, <paramref name="nativeName"/>, <paramref name="dir"/> or <paramref name="toScripts"/> is null. </exception>
        internal TransliterableScript(string code, string name, string nativeName, string dir, IEnumerable<CommonScriptModel> toScripts) : base(code, name, nativeName, dir)
        {
            Argument.AssertNotNull(code, nameof(code));
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(nativeName, nameof(nativeName));
            Argument.AssertNotNull(dir, nameof(dir));
            Argument.AssertNotNull(toScripts, nameof(toScripts));

            ToScripts = toScripts.ToList();
        }

        /// <summary> Initializes a new instance of TransliterableScript. </summary>
        /// <param name="code"> Code identifying the script. </param>
        /// <param name="name"> Display name of the script in the locale requested via Accept-Language header. </param>
        /// <param name="nativeName"> Display name of the language in the locale native for the language. </param>
        /// <param name="dir"> Directionality, which is rtl for right-to-left languages or ltr for left-to-right languages. </param>
        /// <param name="toScripts"> List of scripts available to convert text to. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal TransliterableScript(string code, string name, string nativeName, string dir, IReadOnlyList<CommonScriptModel> toScripts, Dictionary<string, BinaryData> rawData) : base(code, name, nativeName, dir, rawData)
        {
            ToScripts = toScripts;
        }

        /// <summary> Initializes a new instance of <see cref="TransliterableScript"/> for deserialization. </summary>
        internal TransliterableScript()
        {
        }

        /// <summary> List of scripts available to convert text to. </summary>
        public IReadOnlyList<CommonScriptModel> ToScripts { get; }
    }
}
