// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Health.Insights.ClinicalMatching;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.Health.Insights.ClinicalMatching.Samples
{
    public class Samples_ClinicalMatchingClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_MatchTrials_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ClinicalMatchingClient client = new ClinicalMatchingClient(endpoint, credential);

            RequestContent content = RequestContent.Create(new
            {
                patients = new List<object>()
{
new
{
id = "<id>",
}
},
            });
            Operation<BinaryData> operation = client.MatchTrials(WaitUntil.Completed, content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("jobId").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("expirationDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastUpdateDateTime").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_MatchTrials_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ClinicalMatchingClient client = new ClinicalMatchingClient(endpoint, credential);

            RequestContent content = RequestContent.Create(new
            {
                patients = new List<object>()
{
new
{
id = "<id>",
}
},
            });
            Operation<BinaryData> operation = await client.MatchTrialsAsync(WaitUntil.Completed, content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("jobId").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("expirationDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastUpdateDateTime").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_MatchTrials_ShortVersion_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ClinicalMatchingClient client = new ClinicalMatchingClient(endpoint, credential);

            TrialMatcherData trialMatcherData = new TrialMatcherData(new List<PatientRecord>()
{
new PatientRecord("<id>")
});
            Operation<TrialMatcherResult> operation = client.MatchTrials(WaitUntil.Completed, trialMatcherData);
            TrialMatcherResult responseData = operation.Value;
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_MatchTrials_ShortVersion_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ClinicalMatchingClient client = new ClinicalMatchingClient(endpoint, credential);

            TrialMatcherData trialMatcherData = new TrialMatcherData(new List<PatientRecord>()
{
new PatientRecord("<id>")
});
            Operation<TrialMatcherResult> operation = await client.MatchTrialsAsync(WaitUntil.Completed, trialMatcherData);
            TrialMatcherResult responseData = operation.Value;
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_MatchTrials_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ClinicalMatchingClient client = new ClinicalMatchingClient(endpoint, credential);

            RequestContent content = RequestContent.Create(new
            {
                patients = new List<object>()
{
new
{
id = "<id>",
info = new
{
sex = "female",
birthDate = "2022-05-10",
clinicalInfo = new List<object>()
{
new
{
system = "<system>",
code = "<code>",
name = "<name>",
value = "<value>",
}
},
},
data = new List<object>()
{
new
{
type = "note",
clinicalType = "consultation",
id = "<id>",
language = "<language>",
createdDateTime = "2022-05-10T14:57:31.2311892-04:00",
content = new
{
sourceType = "inline",
value = "<value>",
},
}
},
}
},
                configuration = new
                {
                    verbose = true,
                    includeEvidence = true,
                    clinicalTrials = new
                    {
                        customTrials = new List<object>()
{
new
{
id = "<id>",
eligibilityCriteriaText = "<eligibilityCriteriaText>",
demographics = new
{
acceptedSex = "all",
acceptedAgeRange = new
{
minimumAge = new
{
unit = "years",
value = 123.45F,
},
},
},
metadata = new
{
phases = new List<object>()
{
"notApplicable"
},
studyType = "interventional",
recruitmentStatus = "unknownStatus",
conditions = new List<object>()
{
"<conditions>"
},
sponsors = new List<object>()
{
"<sponsors>"
},
contacts = new List<object>()
{
new
{
name = "<name>",
email = "<email>",
phone = "<phone>",
}
},
facilities = new List<object>()
{
new
{
name = "<name>",
city = "<city>",
state = "<state>",
countryOrRegion = "<countryOrRegion>",
}
},
},
}
},
                        registryFilters = new List<object>()
{
new
{
conditions = new List<object>()
{
"<conditions>"
},
studyTypes = new List<object>()
{
"interventional"
},
recruitmentStatuses = new List<object>()
{
"unknownStatus"
},
sponsors = new List<object>()
{
"<sponsors>"
},
phases = new List<object>()
{
"notApplicable"
},
purposes = new List<object>()
{
"notApplicable"
},
ids = new List<object>()
{
"<ids>"
},
sources = new List<object>()
{
"custom"
},
facilityNames = new List<object>()
{
"<facilityNames>"
},
facilityLocations = new List<object>()
{
new
{
city = "<city>",
state = "<state>",
countryOrRegion = "<countryOrRegion>",
}
},
facilityAreas = new List<object>()
{
new
{
type = "Feature",
geometry = new
{
type = "Point",
coordinates = new List<object>()
{
123.45F
},
},
properties = new
{
subType = "Circle",
radius = 123.45,
},
}
},
}
},
                    },
                },
            });
            Operation<BinaryData> operation = client.MatchTrials(WaitUntil.Completed, content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("jobId").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("expirationDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastUpdateDateTime").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("target").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("innererror").GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("confidenceScore").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("eligibilityCriteriaEvidence").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("patientDataEvidence").GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("patientDataEvidence").GetProperty("text").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("patientDataEvidence").GetProperty("offset").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("patientDataEvidence").GetProperty("length").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("patientInfoEvidence").GetProperty("system").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("patientInfoEvidence").GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("patientInfoEvidence").GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("patientInfoEvidence").GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("importance").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("source").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("metadata").GetProperty("phases")[0].ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("metadata").GetProperty("studyType").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("metadata").GetProperty("recruitmentStatus").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("metadata").GetProperty("conditions")[0].ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("metadata").GetProperty("sponsors")[0].ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("metadata").GetProperty("contacts")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("metadata").GetProperty("contacts")[0].GetProperty("email").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("metadata").GetProperty("contacts")[0].GetProperty("phone").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("metadata").GetProperty("facilities")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("metadata").GetProperty("facilities")[0].GetProperty("city").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("metadata").GetProperty("facilities")[0].GetProperty("state").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("metadata").GetProperty("facilities")[0].GetProperty("countryOrRegion").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("neededClinicalInfo")[0].GetProperty("system").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("neededClinicalInfo")[0].GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("neededClinicalInfo")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("neededClinicalInfo")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("neededClinicalInfo")[0].GetProperty("semanticType").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("neededClinicalInfo")[0].GetProperty("category").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("modelVersion").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("knowledgeGraphLastUpdateDate").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_MatchTrials_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ClinicalMatchingClient client = new ClinicalMatchingClient(endpoint, credential);

            RequestContent content = RequestContent.Create(new
            {
                patients = new List<object>()
{
new
{
id = "<id>",
info = new
{
sex = "female",
birthDate = "2022-05-10",
clinicalInfo = new List<object>()
{
new
{
system = "<system>",
code = "<code>",
name = "<name>",
value = "<value>",
}
},
},
data = new List<object>()
{
new
{
type = "note",
clinicalType = "consultation",
id = "<id>",
language = "<language>",
createdDateTime = "2022-05-10T14:57:31.2311892-04:00",
content = new
{
sourceType = "inline",
value = "<value>",
},
}
},
}
},
                configuration = new
                {
                    verbose = true,
                    includeEvidence = true,
                    clinicalTrials = new
                    {
                        customTrials = new List<object>()
{
new
{
id = "<id>",
eligibilityCriteriaText = "<eligibilityCriteriaText>",
demographics = new
{
acceptedSex = "all",
acceptedAgeRange = new
{
minimumAge = new
{
unit = "years",
value = 123.45F,
},
},
},
metadata = new
{
phases = new List<object>()
{
"notApplicable"
},
studyType = "interventional",
recruitmentStatus = "unknownStatus",
conditions = new List<object>()
{
"<conditions>"
},
sponsors = new List<object>()
{
"<sponsors>"
},
contacts = new List<object>()
{
new
{
name = "<name>",
email = "<email>",
phone = "<phone>",
}
},
facilities = new List<object>()
{
new
{
name = "<name>",
city = "<city>",
state = "<state>",
countryOrRegion = "<countryOrRegion>",
}
},
},
}
},
                        registryFilters = new List<object>()
{
new
{
conditions = new List<object>()
{
"<conditions>"
},
studyTypes = new List<object>()
{
"interventional"
},
recruitmentStatuses = new List<object>()
{
"unknownStatus"
},
sponsors = new List<object>()
{
"<sponsors>"
},
phases = new List<object>()
{
"notApplicable"
},
purposes = new List<object>()
{
"notApplicable"
},
ids = new List<object>()
{
"<ids>"
},
sources = new List<object>()
{
"custom"
},
facilityNames = new List<object>()
{
"<facilityNames>"
},
facilityLocations = new List<object>()
{
new
{
city = "<city>",
state = "<state>",
countryOrRegion = "<countryOrRegion>",
}
},
facilityAreas = new List<object>()
{
new
{
type = "Feature",
geometry = new
{
type = "Point",
coordinates = new List<object>()
{
123.45F
},
},
properties = new
{
subType = "Circle",
radius = 123.45,
},
}
},
}
},
                    },
                },
            });
            Operation<BinaryData> operation = await client.MatchTrialsAsync(WaitUntil.Completed, content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("jobId").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("expirationDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastUpdateDateTime").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("target").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("innererror").GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("confidenceScore").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("eligibilityCriteriaEvidence").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("patientDataEvidence").GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("patientDataEvidence").GetProperty("text").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("patientDataEvidence").GetProperty("offset").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("patientDataEvidence").GetProperty("length").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("patientInfoEvidence").GetProperty("system").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("patientInfoEvidence").GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("patientInfoEvidence").GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("patientInfoEvidence").GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("importance").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("source").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("metadata").GetProperty("phases")[0].ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("metadata").GetProperty("studyType").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("metadata").GetProperty("recruitmentStatus").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("metadata").GetProperty("conditions")[0].ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("metadata").GetProperty("sponsors")[0].ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("metadata").GetProperty("contacts")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("metadata").GetProperty("contacts")[0].GetProperty("email").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("metadata").GetProperty("contacts")[0].GetProperty("phone").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("metadata").GetProperty("facilities")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("metadata").GetProperty("facilities")[0].GetProperty("city").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("metadata").GetProperty("facilities")[0].GetProperty("state").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("metadata").GetProperty("facilities")[0].GetProperty("countryOrRegion").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("neededClinicalInfo")[0].GetProperty("system").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("neededClinicalInfo")[0].GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("neededClinicalInfo")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("neededClinicalInfo")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("neededClinicalInfo")[0].GetProperty("semanticType").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("neededClinicalInfo")[0].GetProperty("category").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("modelVersion").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("knowledgeGraphLastUpdateDate").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_MatchTrials_AllParameters_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ClinicalMatchingClient client = new ClinicalMatchingClient(endpoint, credential);

            TrialMatcherData trialMatcherData = new TrialMatcherData(new List<PatientRecord>()
{
new PatientRecord("<id>")
{
Info = new PatientInfo()
{
Sex = PatientInfoSex.Female,
BirthDate = DateTimeOffset.Parse("2022-05-10"),
ClinicalInfo =
{
new ClinicalCodedElement("<system>","<code>")
{
Name = "<name>",
Value = "<value>",
}
},
},
Data =
{
new PatientDocument(DocumentType.Note,"<id>",new DocumentContent(DocumentContentSourceType.Inline,"<value>"))
{
ClinicalType = ClinicalDocumentType.Consultation,
Language = "<language>",
CreatedDateTime = DateTimeOffset.Parse("2022-05-10T14:57:31.2311892-04:00"),
}
},
}
})
            {
                Configuration = new TrialMatcherModelConfiguration(new ClinicalTrials()
                {
                    CustomTrials =
{
new ClinicalTrialDetails("<id>",new ClinicalTrialMetadata(new List<string>()
{
"<conditions>"
})
{
Phases =
{
ClinicalTrialPhase.NotApplicable
},
StudyType = ClinicalTrialStudyType.Interventional,
RecruitmentStatus = ClinicalTrialRecruitmentStatus.UnknownStatus,
Sponsors =
{
"<sponsors>"
},
Contacts =
{
new ContactDetails()
{
Name = "<name>",
Email = "<email>",
Phone = "<phone>",
}
},
Facilities =
{
new ClinicalTrialResearchFacility("<name>","<countryOrRegion>")
{
City = "<city>",
State = "<state>",
}
},
})
{
EligibilityCriteriaText = "<eligibilityCriteriaText>",
Demographics = new ClinicalTrialDemographics()
{
AcceptedSex = ClinicalTrialAcceptedSex.All,
AcceptedAgeRange = new AcceptedAgeRange()
{
MinimumAge = new AcceptedAge(AgeUnit.Years,123.45F),
MaximumAge = null,
},
},
}
},
                    RegistryFilters =
{
new ClinicalTrialRegistryFilter()
{
Conditions =
{
"<conditions>"
},
StudyTypes =
{
ClinicalTrialStudyType.Interventional
},
RecruitmentStatuses =
{
ClinicalTrialRecruitmentStatus.UnknownStatus
},
Sponsors =
{
"<sponsors>"
},
Phases =
{
ClinicalTrialPhase.NotApplicable
},
Purposes =
{
ClinicalTrialPurpose.NotApplicable
},
Ids =
{
"<ids>"
},
Sources =
{
ClinicalTrialSource.Custom
},
FacilityNames =
{
"<facilityNames>"
},
FacilityLocations =
{
new GeographicLocation("<countryOrRegion>")
{
City = "<city>",
State = "<state>",
}
},
FacilityAreas =
{
new GeographicArea(GeoJsonType.Feature,new AreaGeometry(GeoJsonGeometryType.Point,new List<float>()
{
123.45F
}),new AreaProperties(GeoJsonPropertiesSubType.Circle,123.45))
},
}
},
                })
                {
                    Verbose = true,
                    IncludeEvidence = true,
                },
            };
            Operation<TrialMatcherResult> operation = client.MatchTrials(WaitUntil.Completed, trialMatcherData);
            TrialMatcherResult responseData = operation.Value;
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_MatchTrials_AllParameters_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ClinicalMatchingClient client = new ClinicalMatchingClient(endpoint, credential);

            TrialMatcherData trialMatcherData = new TrialMatcherData(new List<PatientRecord>()
{
new PatientRecord("<id>")
{
Info = new PatientInfo()
{
Sex = PatientInfoSex.Female,
BirthDate = DateTimeOffset.Parse("2022-05-10"),
ClinicalInfo =
{
new ClinicalCodedElement("<system>","<code>")
{
Name = "<name>",
Value = "<value>",
}
},
},
Data =
{
new PatientDocument(DocumentType.Note,"<id>",new DocumentContent(DocumentContentSourceType.Inline,"<value>"))
{
ClinicalType = ClinicalDocumentType.Consultation,
Language = "<language>",
CreatedDateTime = DateTimeOffset.Parse("2022-05-10T14:57:31.2311892-04:00"),
}
},
}
})
            {
                Configuration = new TrialMatcherModelConfiguration(new ClinicalTrials()
                {
                    CustomTrials =
{
new ClinicalTrialDetails("<id>",new ClinicalTrialMetadata(new List<string>()
{
"<conditions>"
})
{
Phases =
{
ClinicalTrialPhase.NotApplicable
},
StudyType = ClinicalTrialStudyType.Interventional,
RecruitmentStatus = ClinicalTrialRecruitmentStatus.UnknownStatus,
Sponsors =
{
"<sponsors>"
},
Contacts =
{
new ContactDetails()
{
Name = "<name>",
Email = "<email>",
Phone = "<phone>",
}
},
Facilities =
{
new ClinicalTrialResearchFacility("<name>","<countryOrRegion>")
{
City = "<city>",
State = "<state>",
}
},
})
{
EligibilityCriteriaText = "<eligibilityCriteriaText>",
Demographics = new ClinicalTrialDemographics()
{
AcceptedSex = ClinicalTrialAcceptedSex.All,
AcceptedAgeRange = new AcceptedAgeRange()
{
MinimumAge = new AcceptedAge(AgeUnit.Years,123.45F),
MaximumAge = null,
},
},
}
},
                    RegistryFilters =
{
new ClinicalTrialRegistryFilter()
{
Conditions =
{
"<conditions>"
},
StudyTypes =
{
ClinicalTrialStudyType.Interventional
},
RecruitmentStatuses =
{
ClinicalTrialRecruitmentStatus.UnknownStatus
},
Sponsors =
{
"<sponsors>"
},
Phases =
{
ClinicalTrialPhase.NotApplicable
},
Purposes =
{
ClinicalTrialPurpose.NotApplicable
},
Ids =
{
"<ids>"
},
Sources =
{
ClinicalTrialSource.Custom
},
FacilityNames =
{
"<facilityNames>"
},
FacilityLocations =
{
new GeographicLocation("<countryOrRegion>")
{
City = "<city>",
State = "<state>",
}
},
FacilityAreas =
{
new GeographicArea(GeoJsonType.Feature,new AreaGeometry(GeoJsonGeometryType.Point,new List<float>()
{
123.45F
}),new AreaProperties(GeoJsonPropertiesSubType.Circle,123.45))
},
}
},
                })
                {
                    Verbose = true,
                    IncludeEvidence = true,
                },
            };
            Operation<TrialMatcherResult> operation = await client.MatchTrialsAsync(WaitUntil.Completed, trialMatcherData);
            TrialMatcherResult responseData = operation.Value;
        }
    }
}
