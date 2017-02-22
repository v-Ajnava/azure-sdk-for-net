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
    /// Description of a Namespace AuthorizationRules.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class SharedAccessAuthorizationRuleResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SharedAccessAuthorizationRuleResource class.
        /// </summary>
        public SharedAccessAuthorizationRuleResource() { }

        /// <summary>
        /// Initializes a new instance of the
        /// SharedAccessAuthorizationRuleResource class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="rights">The rights associated with the rule.</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        public SharedAccessAuthorizationRuleResource(string location, System.Collections.Generic.IList<string> rights, string id = default(string), string name = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>))
            : base(location, id, name, type, tags)
        {
            Rights = rights;
        }

        /// <summary>
        /// Gets or sets the rights associated with the rule.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.rights")]
        public System.Collections.Generic.IList<string> Rights { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Rights == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Rights");
            }
            if (this.Rights != null)
            {
                if (this.Rights.Count != this.Rights.Distinct().Count())
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.UniqueItems, "Rights");
                }
            }
        }
    }
}
