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
    using System.Linq;

    /// <summary>
    /// Description of a Check Name availability request properties.
    /// </summary>
    public partial class CheckNameAvailabilityResult
    {
        /// <summary>
        /// Initializes a new instance of the CheckNameAvailabilityResult
        /// class.
        /// </summary>
        public CheckNameAvailabilityResult()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CheckNameAvailabilityResult
        /// class.
        /// </summary>
        /// <param name="message">The detailed info regarding the reason
        /// associated with the namespace.</param>
        /// <param name="nameAvailable">Value indicating namespace is
        /// availability, true if the namespace is available; otherwise,
        /// false.</param>
        /// <param name="reason">The reason for unavailability of a namespace.
        /// Possible values include: 'None', 'InvalidName',
        /// 'SubscriptionIsDisabled', 'NameInUse', 'NameInLockdown',
        /// 'TooManyNamespaceInCurrentSubscription'</param>
        public CheckNameAvailabilityResult(string message = default(string), bool? nameAvailable = default(bool?), UnavailableReason? reason = default(UnavailableReason?))
        {
            Message = message;
            NameAvailable = nameAvailable;
            Reason = reason;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the detailed info regarding the reason associated with the
        /// namespace.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; private set; }

        /// <summary>
        /// Gets or sets value indicating namespace is availability, true if
        /// the namespace is available; otherwise, false.
        /// </summary>
        [JsonProperty(PropertyName = "nameAvailable")]
        public bool? NameAvailable { get; set; }

        /// <summary>
        /// Gets or sets the reason for unavailability of a namespace. Possible
        /// values include: 'None', 'InvalidName', 'SubscriptionIsDisabled',
        /// 'NameInUse', 'NameInLockdown',
        /// 'TooManyNamespaceInCurrentSubscription'
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public UnavailableReason? Reason { get; set; }

    }
}
