// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.12.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Resources.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Tag count.
    /// </summary>
    public partial class TagCount
    {
        /// <summary>
        /// Initializes a new instance of the TagCount class.
        /// </summary>
        public TagCount() { }

        /// <summary>
        /// Initializes a new instance of the TagCount class.
        /// </summary>
        public TagCount(string type = default(string), string value = default(string))
        {
            Type = type;
            Value = value;
        }

        /// <summary>
        /// Type of count.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Value of count.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

    }
}