// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Authorization header information.
    /// </summary>
    public partial class BackendAuthorizationHeaderCredentials
    {
        /// <summary>
        /// Initializes a new instance of the
        /// BackendAuthorizationHeaderCredentials class.
        /// </summary>
        public BackendAuthorizationHeaderCredentials()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// BackendAuthorizationHeaderCredentials class.
        /// </summary>
        /// <param name="scheme">Authentication Scheme name.</param>
        /// <param name="parameter">Authentication Parameter value.</param>
        public BackendAuthorizationHeaderCredentials(string scheme, string parameter)
        {
            Scheme = scheme;
            Parameter = parameter;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets authentication Scheme name.
        /// </summary>
        [JsonProperty(PropertyName = "scheme")]
        public string Scheme { get; set; }

        /// <summary>
        /// Gets or sets authentication Parameter value.
        /// </summary>
        [JsonProperty(PropertyName = "parameter")]
        public string Parameter { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Scheme == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Scheme");
            }
            if (Parameter == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Parameter");
            }
        }
    }
}
