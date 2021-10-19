﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.AI.TextAnalytics.Tests
{
    [ServiceVersion(Min = TextAnalyticsClientOptions.ServiceVersion.V3_2_Preview_2)]
    public class ExtractSummaryTests : TextAnalyticsClientLiveTestBase
    {
        public ExtractSummaryTests(bool isAsync, TextAnalyticsClientOptions.ServiceVersion serviceVersion)
            : base(isAsync, serviceVersion)
        {
        }

        private const int ExtractSummaryMaxSentenceCount = 5;

        private const string ExtractSummaryDocument1 =
            "No roads or rails connect the 39,000 people dispersed across Nunavut, a territory in northeastern Canada that spans three time zones and features fjord-cut isles that stretch into the Arctic Circle off the west coast of Greenland. About 80% of the population is of Inuit descent with cultural ties to the land that date back more than 4,000 years."
            + " Today, low-bandwidth satellite internet service links the people of Nunavut to each other and with the rest of the world."
            + " The Government of Nunavut relies on this internet link to provide healthcare, education, housing and family, and financial and other services to 25 communities. The smallest, Grise Fiord, has a population of 130; the largest, the capital, Iqaluit, has 8,500 people. About 3,100 people work full-time for the government, which has an office in each community. Another 3,000 people work for the government as relief workers, casual, term or contractors."
            + " Managing information technology for this dispersed and elastic workforce is a constant challenge for Martin Joy, director of information communication and technology for the Government of Nunavut."
            + " “Traditionally, in IT, you would have to send a device or mail a device to that end user. In Nunavut, there is no road, there is no logistical framework that allows us to move stuff cost-effectively, so everything has to be flown,” he explained. “Based on weather, based on the types of cargo flows, that could take a considerable amount of time. It could take two to three weeks for us to get a user a device to get them onboarded securely into our environment.”"
            + " “Now, with Windows 365, we can do that within less than an hour of the account being created,” he said."
            + " Windows 365 puts Microsoft’s flagship operating system in the cloud. Users select Windows 10 or Windows 11, once it is generally available later this calendar year, along with a configuration of processing power, storage and memory that suits their needs. They then access their Cloud PC through a native application or web browser on any device, from anywhere with an internet connection."
            + " The creation of the Cloud PC follows other products and services to the cloud, from Windows Server on Azure to the suite of Microsoft Office productivity applications in Microsoft 365. Windows is already accessible in the cloud via Azure Virtual Desktop, which offers customers flexibility to create and run their own virtualization service. Windows 365 is a new virtualization technology for Windows that is easy to set up and deploy for today’s login-from-anywhere, mobile and elastic workforces."
            + " “Windows 365 is really going to make a huge difference for organizations that wanted to try virtualization for various reasons but could not – maybe it was too costly, too complex or they didn’t have the expertise in house to do it,” said Wangui McKelvey, general manager of Microsoft 365, who works from a home office in Atlanta, Georgia."
            + " With Windows 365, she added, IT admins can manage and deploy Cloud PCs using the same tools they use today to manage physical PCs."
            + " The remote and hybrid workforces of today and tomorrow were top of mind for Scott Manchester when he set out to develop Windows 365. The director of program management for Windows 365 in Redmond, Washington, wanted to deliver an experience with the look, feel and security of a traditional Windows PC, only accessed through a native app or web browser on a device of the user’s choosing from anywhere with an internet connection."
            + " “You want them to be able to get access to their corporate resources, applications, databases and HR tools, and do all the things they do in a typical workday sitting in the office – you want them to have that same experience,” he said. “And you want them to have that experience in such a way that it feels familiar to them. It’s not this jolting thing that takes away all the things they love about Windows.”"
            + " Virtualization, he noted, can be challenging to set up and maintain, especially for organizations without dedicated IT resources. IT consulting firms do brisk business working with companies to set up virtualization solutions and staffing help desks to field calls from employees when they run into complications. Manchester knows this because he worked on Microsoft’s Windows virtualization technologies for nearly two decades prior to leading the development of Windows 365."
            + " The inspiration for Windows 365 came earlier, when he was assigned to an internal team at Microsoft working on a project, code named Arcadia, a consumer-facing service that would stream video games from the cloud. The target audience – gamers – lacks an IT department to lean on when things glitch. “That started me thinking, ‘How do we build something that doesn’t require IT intervention, something that could truly scale to the consumer market?’” Manchester said."
            + " The consumer experience was Manchester’s benchmark when he started work on virtualization."
            + " “I took note of every time there was something that didn’t quite deliver on that,” he said. “And, as I started meeting with customers and partners and learning about how they fill in these gaps either by setting expectations of their workforce or having an IT department that picks up the phone and deals with those situations, I realized we had some ground to cover.”"
            + " Covering that ground led to improvements in Microsoft’s business offering now known as Azure Virtual Desktop. This offering continues to experience accelerated growth among customers who need full customization and control over their operating environment and have the resources for dedicated IT staff to support the system, Manchester noted. Windows 365 is for the approximate 80% of the marketplace that lacks the need for full customization or the resources for dedicated IT."
            + " To lead the development of Windows 365, Manchester leaned into his Arcadia mindset."
            + " “When we built this team, we brought in a couple of leaders who had experience with virtualization, but for the most part we brought in people who had experience with Windows and experience with consumer experiences because that was the bar we wanted to set,” he said."
            + "  Soon after this bar was set, and the first batch of hires made – a handful of experts in virtualization and user experience – COVID-19 hit and changed the world."
            + " “We hired everybody else during the pandemic,” Manchester said. “They were remote. They were living all over the U.S., Australia, Europe and China. Many of them have never set foot in the office. And as soon as we got far enough along with the development, we moved those people to use the service. People who never used virtualization before, had no expectations – their bar was the experience they had on their laptop – and we basically used Windows 365 to build Windows 365.”"
            + " As the team used the service and encountered bugs in the system, they worked through and solved them on their way to creating a unique category of virtualization, the Cloud PC."
            + " “We’re giving you Windows from the cloud,” Manchester said.";

        private const string ExtractSummaryDocument2 =
            "Windows 365 was in the works before COVID-19 sent companies around the world on a scramble to secure solutions to support employees suddenly forced to work from home, but “what really put the firecracker behind it was the pandemic, it accelerated everything,” McKelvey said. She explained that customers were asking, “’How do we create an experience for people that makes them still feel connected to the company without the physical presence of being there?”"
            + " In this new world of Windows 365, remote workers flip the lid on their laptop, bootup the family workstation or clip a keyboard onto a tablet, launch a native app or modern web browser and login to their Windows 365 account. From there, their Cloud PC appears with their background, apps, settings and content just as they left it when they last were last there – in the office, at home or a coffee shop."
            + " “And then, when you’re done, you’re done. You won’t have any issues around security because you’re not saving anything on your device,” McKelvey said, noting that all the data is stored in the cloud."
            + " The ability to login to a Cloud PC from anywhere on any device is part of Microsoft’s larger strategy around tailoring products such as Microsoft Teams and Microsoft 365 for the post-pandemic hybrid workforce of the future, she added. It enables employees accustomed to working from home to continue working from home; it enables companies to hire interns from halfway around the world; it allows startups to scale without requiring IT expertise."
            + " “I think this will be interesting for those organizations who, for whatever reason, have shied away from virtualization. This is giving them an opportunity to try it in a way that their regular, everyday endpoint admin could manage,” McKelvey said."
            + " The simplicity of Windows 365 won over Dean Wells, the corporate chief information officer for the Government of Nunavut. His team previously attempted to deploy a traditional virtual desktop infrastructure and found it inefficient and unsustainable given the limitations of low-bandwidth satellite internet and the constant need for IT staff to manage the network and infrastructure."
            + " We didn’t run it for very long,” he said. “It didn’t turn out the way we had hoped. So, we actually had terminated the project and rolled back out to just regular PCs.”"
            + " He re-evaluated this decision after the Government of Nunavut was hit by a ransomware attack in November 2019 that took down everything from the phone system to the government’s servers. Microsoft helped rebuild the system, moving the government to Teams, SharePoint, OneDrive and Microsoft 365. Manchester’s team recruited the Government of Nunavut to pilot Windows 365. Wells was intrigued, especially by the ability to manage the elastic workforce securely and seamlessly."
            + " “The impact that I believe we are finding, and the impact that we’re going to find going forward, is being able to access specialists from outside the territory and organizations outside the territory to come in and help us with our projects, being able to get people on staff with us to help us deliver the day-to-day expertise that we need to run the government,” he said."
            + " “Being able to improve healthcare, being able to improve education, economic development is going to improve the quality of life in the communities.”";

        private static readonly List<string> s_extractSummaryBatchConvenienceDocuments = new List<string>
        {
            ExtractSummaryDocument1,
            ExtractSummaryDocument2
        };

        private static List<TextDocumentInput> s_extractSummaryBatchDocuments = new List<TextDocumentInput>
        {
            new TextDocumentInput("1", ExtractSummaryDocument1)
            {
                 Language = "en",
            },
            new TextDocumentInput("2", ExtractSummaryDocument2)
            {
                 Language = "en",
            }
        };

        [RecordedTest]
        public async Task ExtractSummaryWithDisableServiceLogs()
        {
            TextAnalyticsClient client = GetClient();

            TextAnalyticsActions batchActions = new TextAnalyticsActions()
            {
                ExtractSummaryActions = new List<ExtractSummaryAction>() { new ExtractSummaryAction() { DisableServiceLogs = true } }
            };

            AnalyzeActionsOperation operation = await client.StartAnalyzeActionsAsync(s_extractSummaryBatchConvenienceDocuments, batchActions);

            await operation.WaitForCompletionAsync();

            // Take the first page
            AnalyzeActionsResult resultCollection = operation.Value.ToEnumerableAsync().Result.FirstOrDefault();

            IReadOnlyCollection<ExtractSummaryActionResult> extractSummaryActionsResults = resultCollection.ExtractSummaryResults;

            Assert.IsNotNull(extractSummaryActionsResults);
            Assert.AreEqual(2, extractSummaryActionsResults.FirstOrDefault().DocumentsResults.Count);
        }

        [RecordedTest]
        public async Task ExtractSummaryBatchWithRankOrderTest()
        {
            TextAnalyticsClient client = GetClient();

            TextAnalyticsActions batchActions = new TextAnalyticsActions()
            {
                ExtractSummaryActions = new List<ExtractSummaryAction>()
                {
                    new ExtractSummaryAction()
                    {
                        MaxSentenceCount = ExtractSummaryMaxSentenceCount,
                        OrderBy = SummarySentencesOrder.Rank
                    }
                }
            };

            AnalyzeActionsOperation operation = await client.StartAnalyzeActionsAsync(s_extractSummaryBatchDocuments, batchActions);

            await operation.WaitForCompletionAsync();

            // Take the first page
            AnalyzeActionsResult resultCollection = operation.Value.ToEnumerableAsync().Result.FirstOrDefault();

            IReadOnlyCollection<ExtractSummaryActionResult> summaryActionsResults = resultCollection.ExtractSummaryResults;
            ExtractSummaryResultCollection summaryDocumentsResults = summaryActionsResults.FirstOrDefault().DocumentsResults;

            ValidateSummaryBatchResult(summaryDocumentsResults, SummarySentencesOrder.Rank);
        }

        [RecordedTest]
        public async Task ExtractSummaryBatchWithErrorTest()
        {
            TextAnalyticsClient client = GetClient();

            var documents = new List<string>
            {
                "Subject is taking 100mg of ibuprofen twice daily",
                "",
            };
            TextAnalyticsActions batchActions = new TextAnalyticsActions()
            {
                ExtractSummaryActions = new List<ExtractSummaryAction>()
                {
                    new ExtractSummaryAction()
                }
            };

            AnalyzeActionsOperation operation = await client.StartAnalyzeActionsAsync(documents, batchActions, "en");
            await operation.WaitForCompletionAsync();

            // Take the first page
            AnalyzeActionsResult resultCollection = operation.Value.ToEnumerableAsync().Result.FirstOrDefault();

            List<ExtractSummaryActionResult> summaryActions = resultCollection.ExtractSummaryResults.ToList();

            Assert.AreEqual(1, summaryActions.Count);

            ExtractSummaryResultCollection documentsResults = summaryActions[0].DocumentsResults;
            Assert.IsFalse(documentsResults[0].HasError);
            Assert.IsTrue(documentsResults[1].HasError);
            Assert.AreEqual(TextAnalyticsErrorCode.InvalidDocument, documentsResults[1].Error.ErrorCode.ToString());
        }

        [RecordedTest]
        public async Task ExtractSummaryBatchConvenienceTest()
        {
            TextAnalyticsClient client = GetClient();

            TextAnalyticsActions batchActions = new TextAnalyticsActions()
            {
                ExtractSummaryActions = new List<ExtractSummaryAction>()
                {
                    new ExtractSummaryAction() { MaxSentenceCount = ExtractSummaryMaxSentenceCount }
                }
            };

            AnalyzeActionsOperation operation = await client.StartAnalyzeActionsAsync(s_extractSummaryBatchConvenienceDocuments, batchActions);

            await operation.WaitForCompletionAsync();

            // Take the first page
            AnalyzeActionsResult resultCollection = operation.Value.ToEnumerableAsync().Result.FirstOrDefault();

            IReadOnlyCollection<ExtractSummaryActionResult> summaryActionsResults = resultCollection.ExtractSummaryResults;
            ExtractSummaryResultCollection summaryDocumentsResults = summaryActionsResults.FirstOrDefault().DocumentsResults;

            ValidateSummaryBatchResult(summaryDocumentsResults);
        }

        [RecordedTest]
        public async Task ExtractSummaryBatchConvenienceWithStatisticsTest()
        {
            TextAnalyticsClient client = GetClient();

            TextAnalyticsActions batchActions = new TextAnalyticsActions()
            {
                ExtractSummaryActions = new List<ExtractSummaryAction>()
                {
                    new ExtractSummaryAction() { MaxSentenceCount = ExtractSummaryMaxSentenceCount }
                }
            };

            AnalyzeActionsOptions options = new AnalyzeActionsOptions()
            {
                IncludeStatistics = true
            };

            AnalyzeActionsOperation operation = await client.StartAnalyzeActionsAsync(s_extractSummaryBatchConvenienceDocuments, batchActions, "en", options);

            await operation.WaitForCompletionAsync();

            // Take the first page
            AnalyzeActionsResult resultCollection = operation.Value.ToEnumerableAsync().Result.FirstOrDefault();

            IReadOnlyCollection<ExtractSummaryActionResult> summaryActionsResults = resultCollection.ExtractSummaryResults;
            ExtractSummaryResultCollection summaryDocumentsResults = summaryActionsResults.FirstOrDefault().DocumentsResults;

            ValidateSummaryBatchResult(summaryDocumentsResults, includeStatistics: true);
        }

        [RecordedTest]
        public async Task ExtractSummaryBatchTest()
        {
            TextAnalyticsClient client = GetClient();

            TextAnalyticsActions batchActions = new TextAnalyticsActions()
            {
                ExtractSummaryActions = new List<ExtractSummaryAction>()
                {
                    new ExtractSummaryAction() { MaxSentenceCount = ExtractSummaryMaxSentenceCount }
                }
            };

            AnalyzeActionsOperation operation = await client.StartAnalyzeActionsAsync(s_extractSummaryBatchDocuments, batchActions);

            await operation.WaitForCompletionAsync();

            // Take the first page
            AnalyzeActionsResult resultCollection = operation.Value.ToEnumerableAsync().Result.FirstOrDefault();

            IReadOnlyCollection<ExtractSummaryActionResult> summaryActionsResults = resultCollection.ExtractSummaryResults;
            ExtractSummaryResultCollection summaryDocumentsResults = summaryActionsResults.FirstOrDefault().DocumentsResults;

            ValidateSummaryBatchResult(summaryDocumentsResults);
        }

        [RecordedTest]
        public async Task ExtractSummaryBatchWithStatisticsTest()
        {
            TextAnalyticsClient client = GetClient();

            TextAnalyticsActions batchActions = new TextAnalyticsActions()
            {
                ExtractSummaryActions = new List<ExtractSummaryAction>()
                {
                    new ExtractSummaryAction() { MaxSentenceCount = ExtractSummaryMaxSentenceCount }
                }
            };

            AnalyzeActionsOptions options = new AnalyzeActionsOptions()
            {
                IncludeStatistics = true
            };

            AnalyzeActionsOperation operation = await client.StartAnalyzeActionsAsync(s_extractSummaryBatchDocuments, batchActions, options);

            await operation.WaitForCompletionAsync();

            // Take the first page
            AnalyzeActionsResult resultCollection = operation.Value.ToEnumerableAsync().Result.FirstOrDefault();

            IReadOnlyCollection<ExtractSummaryActionResult> summaryActionsResults = resultCollection.ExtractSummaryResults;
            ExtractSummaryResultCollection summaryDocumentsResults = summaryActionsResults.FirstOrDefault().DocumentsResults;

            ValidateSummaryBatchResult(summaryDocumentsResults, includeStatistics: true);
        }

        [RecordedTest]
        public async Task ExtractSummaryWithMultipleActions()
        {
            TextAnalyticsClient client = GetClient();

            TextAnalyticsActions batchActions = new TextAnalyticsActions()
            {
                ExtractSummaryActions = new List<ExtractSummaryAction>()
                {
                    new ExtractSummaryAction()
                    {
                        DisableServiceLogs = true,
                        ActionName = "ExtractSummaryWithDisabledServiceLogs"
                    },
                    new ExtractSummaryAction()
                    {
                        ActionName = "ExtractSummary"
                    }
                }
            };

            AnalyzeActionsOperation operation = await client.StartAnalyzeActionsAsync(s_extractSummaryBatchDocuments, batchActions);

            await operation.WaitForCompletionAsync();

            // Take the first page
            AnalyzeActionsResult resultCollection = operation.Value.ToEnumerableAsync().Result.FirstOrDefault();

            IReadOnlyCollection<ExtractSummaryActionResult> ExtractSummaryActionsResults = resultCollection.ExtractSummaryResults;

            Assert.IsNotNull(ExtractSummaryActionsResults);
            Assert.AreEqual(2, ExtractSummaryActionsResults.Count);

            Assert.AreEqual("ExtractSummaryWithDisabledServiceLogs", ExtractSummaryActionsResults.ElementAt(0).ActionName);
            Assert.AreEqual("ExtractSummary", ExtractSummaryActionsResults.ElementAt(1).ActionName);
        }

        private void ValidateSummaryDocumentResult(SummarySentenceCollection sentences, SummarySentencesOrder expectedOrder)
        {
            Assert.IsNotNull(sentences.Warnings);
            Assert.LessOrEqual(sentences.Count, ExtractSummaryMaxSentenceCount);

            for (int i = 0; i < sentences.Count; i++)
            {
                SummarySentence sentence = sentences[i];

                Assert.True(s_extractSummaryBatchConvenienceDocuments.Any(document => document.Contains(sentence.Text)));
                Assert.GreaterOrEqual(sentence.Offset, 0);
                Assert.GreaterOrEqual(sentence.RankScore, 0.0);
                Assert.LessOrEqual(sentence.RankScore, 1.0);
                Assert.AreEqual(sentence.Text.Length, sentence.Length);

                if (i > 0)
                {
                    SummarySentence previousSentence = sentences[i - 1];

                    if (expectedOrder == SummarySentencesOrder.Offset)
                    {
                        Assert.Greater(sentence.Offset, previousSentence.Offset);
                    }
                    else if (expectedOrder == SummarySentencesOrder.Rank)
                    {
                        Assert.LessOrEqual(sentence.RankScore, previousSentence.RankScore);
                    }
                }
            }
        }

        private void ValidateSummaryBatchResult(ExtractSummaryResultCollection results, SummarySentencesOrder expectedOrder = SummarySentencesOrder.Offset, bool includeStatistics = false)
        {
            Assert.That(results.ModelVersion, Is.Not.Null.And.Not.Empty);

            if (includeStatistics)
            {
                Assert.IsNotNull(results.Statistics);
                Assert.Greater(results.Statistics.DocumentCount, 0);
                Assert.Greater(results.Statistics.TransactionCount, 0);
                Assert.GreaterOrEqual(results.Statistics.InvalidDocumentCount, 0);
                Assert.GreaterOrEqual(results.Statistics.ValidDocumentCount, 0);
            }
            else
            {
                Assert.IsNull(results.Statistics);
            }

            foreach (ExtractSummaryResult result in results)
            {
                Assert.That(result.Id, Is.Not.Null.And.Not.Empty);
                Assert.False(result.HasError);

                if (includeStatistics)
                {
                    Assert.GreaterOrEqual(result.Statistics.CharacterCount, 0);
                    Assert.Greater(result.Statistics.TransactionCount, 0);
                }
                else
                {
                    Assert.AreEqual(0, result.Statistics.CharacterCount);
                    Assert.AreEqual(0, result.Statistics.TransactionCount);
                }

                ValidateSummaryDocumentResult(result.Sentences, expectedOrder);
            }
        }
    }
}
