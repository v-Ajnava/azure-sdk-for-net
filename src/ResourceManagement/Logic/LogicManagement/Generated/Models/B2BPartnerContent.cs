// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.15.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// </summary>
    public partial class B2BPartnerContent
    {
        /// <summary>
        /// Initializes a new instance of the B2BPartnerContent class.
        /// </summary>
        public B2BPartnerContent() { }

        /// <summary>
        /// Initializes a new instance of the B2BPartnerContent class.
        /// </summary>
        public B2BPartnerContent(IList<BusinessIdentity> businessIdentities = default(IList<BusinessIdentity>))
        {
            BusinessIdentities = businessIdentities;
        }

        /// <summary>
        /// Gets or sets the list of partner business identities.
        /// </summary>
        [JsonProperty(PropertyName = "businessIdentities")]
        public IList<BusinessIdentity> BusinessIdentities { get; set; }

    }
}
