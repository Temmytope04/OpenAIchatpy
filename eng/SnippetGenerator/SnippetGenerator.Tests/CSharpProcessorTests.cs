using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SnippetGenerator.Tests
{
    public class Tests
    {
        private const string Processed = "processed";

        [Test]
        [TestCaseSource(nameof(CodeInputs))]
        public async Task CSharpProcsesorFindsCodeXMLDocs(string code, string expected)
        {
            var actual = await CSharpProcessor.ProcessAsync(code, SnippetProvider);
            Assert.AreEqual(expected, actual);

            var reProcessed = await CSharpProcessor.ProcessAsync(actual, SnippetProvider);
            Assert.AreEqual(expected, reProcessed);
        }

        private ValueTask<string> SnippetProvider(string s) => new(Processed);

        public static IEnumerable<object[]> CodeInputs()
        {
            yield return new[]
            {
                @"    /// </remarks>" + Environment.NewLine +
                @"    /// <code snippet=""Snippet:A""></code>" + Environment.NewLine +
                "    foo" + Environment.NewLine +
                "        {",
                @"    /// </remarks>" + Environment.NewLine +
                @"    /// <code snippet=""Snippet:A"" language=""csharp"">" + Environment.NewLine +
                $"    /// {Processed} </code>" + Environment.NewLine +
                "    foo" + Environment.NewLine +
                "        {"
            };

            yield return new[]
            {
                @"/// <code snippet=""Snippet:B""></code>",
                @"/// <code snippet=""Snippet:B"" language=""csharp"">" + Environment.NewLine +
                $"/// {Processed} </code>"
            };

            yield return new[]
            {
                @"    /// Example of enumerating an AsyncPageable using the <c> async foreach </c> loop:" + Environment.NewLine +
                @"    /// <code snippet=""Snippet:C""></code>" + Environment.NewLine +
                "     foo",
                @"    /// Example of enumerating an AsyncPageable using the <c> async foreach </c> loop:" + Environment.NewLine +
                @"    /// <code snippet=""Snippet:C"" language=""csharp"">" + Environment.NewLine +
                $"    /// {Processed} </code>" + Environment.NewLine +
                "     foo"
            };

            yield return new[]
            {
                @"    /// Example of enumerating an AsyncPageable using the <c> async foreach </c> loop:" + Environment.NewLine +
                @"    /// <example snippet=""Snippet:Example""></example>" + Environment.NewLine +
                "     foo",
                @"    /// Example of enumerating an AsyncPageable using the <c> async foreach </c> loop:" + Environment.NewLine +
                @"    /// <example snippet=""Snippet:Example"">" + Environment.NewLine +
                @"    /// <code language=""csharp"">" + Environment.NewLine +
                $"    /// {Processed} </code>" + Environment.NewLine +
                @"    /// </example>" + Environment.NewLine +
                "     foo"
            };
        }
    }
}