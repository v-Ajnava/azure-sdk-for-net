// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Relay.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Relay;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ProvisioningStateEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProvisioningStateEnum
    {
        [EnumMember(Value = "Created")]
        Created,
        [EnumMember(Value = "Succeeded")]
        Succeeded,
        [EnumMember(Value = "Deleted")]
        Deleted,
        [EnumMember(Value = "Failed")]
        Failed,
        [EnumMember(Value = "Updating")]
        Updating,
        [EnumMember(Value = "Unknown")]
        Unknown
    }
}
