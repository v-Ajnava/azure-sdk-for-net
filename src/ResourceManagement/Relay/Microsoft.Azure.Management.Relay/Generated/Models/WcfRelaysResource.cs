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
    /// Description of WcfRelays Resource.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class WcfRelaysResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the WcfRelaysResource class.
        /// </summary>
        public WcfRelaysResource() { }

        /// <summary>
        /// Initializes a new instance of the WcfRelaysResource class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="relayType">WCFRelay Type. Possible values include:
        /// 'NetTcp', 'Http'</param>
        /// <param name="createdAt">The time the WCFRelay was created.</param>
        /// <param name="updatedAt">The time the namespace was updated.</param>
        /// <param name="listenerCount">The number of listeners for this
        /// relay. min : 1 and max:25 supported</param>
        /// <param name="requiresClientAuthorization">true if client
        /// authorization is needed for this relay; otherwise, false.</param>
        /// <param name="requiresTransportSecurity">true if transport security
        /// is needed for this relay; otherwise, false.</param>
        /// <param name="isDynamic">true if the relay is dynamic; otherwise,
        /// false.</param>
        /// <param name="userMetadata">usermetadata is a placeholder to store
        /// user-defined string data for the HybridConnection endpoint.e.g.
        /// it can be used to store  descriptive data, such as list of teams
        /// and their contact information also user-defined configuration
        /// settings can be stored.</param>
        public WcfRelaysResource(string location, string id = default(string), string name = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), string relayType = default(string), System.DateTime? createdAt = default(System.DateTime?), System.DateTime? updatedAt = default(System.DateTime?), int? listenerCount = default(int?), bool? requiresClientAuthorization = default(bool?), bool? requiresTransportSecurity = default(bool?), bool? isDynamic = default(bool?), string userMetadata = default(string))
            : base(location, id, name, type, tags)
        {
            RelayType = relayType;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            ListenerCount = listenerCount;
            RequiresClientAuthorization = requiresClientAuthorization;
            RequiresTransportSecurity = requiresTransportSecurity;
            IsDynamic = isDynamic;
            UserMetadata = userMetadata;
        }

        /// <summary>
        /// Gets or sets wCFRelay Type. Possible values include: 'NetTcp',
        /// 'Http'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.relayType")]
        public string RelayType { get; set; }

        /// <summary>
        /// Gets the time the WCFRelay was created.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.createdAt")]
        public System.DateTime? CreatedAt { get; private set; }

        /// <summary>
        /// Gets the time the namespace was updated.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.updatedAt")]
        public System.DateTime? UpdatedAt { get; private set; }

        /// <summary>
        /// Gets the number of listeners for this relay. min : 1 and max:25
        /// supported
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.listenerCount")]
        public int? ListenerCount { get; private set; }

        /// <summary>
        /// Gets or sets true if client authorization is needed for this
        /// relay; otherwise, false.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.requiresClientAuthorization")]
        public bool? RequiresClientAuthorization { get; set; }

        /// <summary>
        /// Gets or sets true if transport security is needed for this relay;
        /// otherwise, false.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.requiresTransportSecurity")]
        public bool? RequiresTransportSecurity { get; set; }

        /// <summary>
        /// Gets true if the relay is dynamic; otherwise, false.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.isDynamic")]
        public bool? IsDynamic { get; private set; }

        /// <summary>
        /// Gets or sets usermetadata is a placeholder to store user-defined
        /// string data for the HybridConnection endpoint.e.g. it can be used
        /// to store  descriptive data, such as list of teams and their
        /// contact information also user-defined configuration settings can
        /// be stored.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.userMetadata")]
        public string UserMetadata { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
