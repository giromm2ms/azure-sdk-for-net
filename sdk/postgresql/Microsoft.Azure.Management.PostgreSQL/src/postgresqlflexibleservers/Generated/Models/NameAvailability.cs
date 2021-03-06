// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.PostgreSQL.FlexibleServers.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents a resource name availability.
    /// </summary>
    public partial class NameAvailability
    {
        /// <summary>
        /// Initializes a new instance of the NameAvailability class.
        /// </summary>
        public NameAvailability()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NameAvailability class.
        /// </summary>
        /// <param name="message">Error Message.</param>
        /// <param name="nameAvailable">Indicates whether the resource name is
        /// available.</param>
        /// <param name="name">name of the PostgreSQL server.</param>
        /// <param name="type">type of the server</param>
        public NameAvailability(string message = default(string), bool? nameAvailable = default(bool?), string name = default(string), string type = default(string))
        {
            Message = message;
            NameAvailable = nameAvailable;
            Name = name;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets error Message.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets indicates whether the resource name is available.
        /// </summary>
        [JsonProperty(PropertyName = "nameAvailable")]
        public bool? NameAvailable { get; set; }

        /// <summary>
        /// Gets or sets name of the PostgreSQL server.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets type of the server
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
