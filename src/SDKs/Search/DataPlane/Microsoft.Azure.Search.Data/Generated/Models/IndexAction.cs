// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Search.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class IndexAction
    {
        /// <summary>
        /// Initializes a new instance of the IndexAction class.
        /// </summary>
        public IndexAction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IndexAction class.
        /// </summary>
        /// <param name="searchAction">Possible values include: 'upload',
        /// 'merge', 'mergeOrUpload', 'delete'</param>
        public IndexAction(SearchActionType searchAction, object document)
        {
            SearchAction = searchAction;
            Document = document;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'upload', 'merge',
        /// 'mergeOrUpload', 'delete'
        /// </summary>
        [JsonProperty(PropertyName = "searchAction")]
        public SearchActionType SearchAction { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "document")]
        public object Document { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Document == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Document");
            }
        }
    }
}
