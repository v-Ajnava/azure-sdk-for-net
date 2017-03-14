// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Relay.Models
{
    using System.Linq;

    /// <summary>
    /// Parameters supplied to the Patch Namespace operation.
    /// </summary>
    public partial class NamespaceUpdateParameter
    {
        /// <summary>
        /// Initializes a new instance of the NamespaceUpdateParameter class.
        /// </summary>
        public NamespaceUpdateParameter()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NamespaceUpdateParameter class.
        /// </summary>
        /// <param name="tags">Resource tags</param>
        public NamespaceUpdateParameter(System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>))
        {
            Tags = tags;
        }
        /// <summary>
        /// Static constructor for NamespaceUpdateParameter class.
        /// </summary>
        static NamespaceUpdateParameter()
        {
            Sku = new Sku();
        }

        /// <summary>
        /// Gets or sets resource tags
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tags")]
        public System.Collections.Generic.IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// The sku of the created namespace
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sku")]
        public static Sku Sku { get; private set; }

    }
}
