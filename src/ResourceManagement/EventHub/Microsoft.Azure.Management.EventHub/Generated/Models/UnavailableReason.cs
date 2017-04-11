// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.EventHub.Models
{
    using Azure;
    using Management;
    using EventHub;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for UnavailableReason.
    /// </summary>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UnavailableReason
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "InvalidName")]
        InvalidName,
        [EnumMember(Value = "SubscriptionIsDisabled")]
        SubscriptionIsDisabled,
        [EnumMember(Value = "NameInUse")]
        NameInUse,
        [EnumMember(Value = "NameInLockdown")]
        NameInLockdown,
        [EnumMember(Value = "TooManyNamespaceInCurrentSubscription")]
        TooManyNamespaceInCurrentSubscription
    }
}

