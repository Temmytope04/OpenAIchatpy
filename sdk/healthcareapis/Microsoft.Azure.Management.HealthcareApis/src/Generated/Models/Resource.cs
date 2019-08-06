// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HealthcareApis.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The common properties of a service.
    /// </summary>
    public partial class Resource : IResource
    {
        /// <summary>
        /// Initializes a new instance of the Resource class.
        /// </summary>
        public Resource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Resource class.
        /// </summary>
        /// <param name="kind">The kind of the service. Valid values are: fhir,
        /// fhir-Stu3 and fhir-R4. Possible values include: 'fhir',
        /// 'fhir-Stu3', 'fhir-R4'</param>
        /// <param name="location">The resource location.</param>
        /// <param name="id">The resource identifier.</param>
        /// <param name="name">The resource name.</param>
        /// <param name="type">The resource type.</param>
        /// <param name="tags">The resource tags.</param>
        /// <param name="etag">An etag associated with the resource, used for
        /// optimistic concurrency when editing it.</param>
        public Resource(Kind kind, string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string etag = default(string))
        {
            Id = id;
            Name = name;
            Type = type;
            Kind = kind;
            Location = location;
            Tags = tags;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the resource identifier.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the resource name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the resource type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or sets the kind of the service. Valid values are: fhir,
        /// fhir-Stu3 and fhir-R4. Possible values include: 'fhir',
        /// 'fhir-Stu3', 'fhir-R4'
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public Kind Kind { get; set; }

        /// <summary>
        /// Gets or sets the resource location.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the resource tags.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets an etag associated with the resource, used for
        /// optimistic concurrency when editing it.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Location");
            }
            if (Name != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(Name, "^[a-z0-9][a-z0-9-]{1,21}[a-z0-9]$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "Name", "^[a-z0-9][a-z0-9-]{1,21}[a-z0-9]$");
                }
            }
        }
    }
}
