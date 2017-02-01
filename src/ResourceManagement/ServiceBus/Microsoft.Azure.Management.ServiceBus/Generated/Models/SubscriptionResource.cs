// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ServiceBus.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Description of subscription resource.
    /// </summary>
    [JsonTransformation]
    public partial class SubscriptionResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the SubscriptionResource class.
        /// </summary>
        public SubscriptionResource() { }

        /// <summary>
        /// Initializes a new instance of the SubscriptionResource class.
        /// </summary>
        public SubscriptionResource(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), DateTime? accessedAt = default(DateTime?), string autoDeleteOnIdle = default(string), MessageCountDetails countDetails = default(MessageCountDetails), DateTime? createdAt = default(DateTime?), string defaultMessageTimeToLive = default(string), bool? deadLetteringOnFilterEvaluationExceptions = default(bool?), bool? deadLetteringOnMessageExpiration = default(bool?), bool? enableBatchedOperations = default(bool?), EntityAvailabilityStatus? entityAvailabilityStatus = default(EntityAvailabilityStatus?), bool? isReadOnly = default(bool?), string lockDuration = default(string), int? maxDeliveryCount = default(int?), long? messageCount = default(long?), bool? requiresSession = default(bool?), EntityStatus? status = default(EntityStatus?), DateTime? updatedAt = default(DateTime?))
            : base(location, id, name, type, tags)
        {
            AccessedAt = accessedAt;
            AutoDeleteOnIdle = autoDeleteOnIdle;
            CountDetails = countDetails;
            CreatedAt = createdAt;
            DefaultMessageTimeToLive = defaultMessageTimeToLive;
            DeadLetteringOnFilterEvaluationExceptions = deadLetteringOnFilterEvaluationExceptions;
            DeadLetteringOnMessageExpiration = deadLetteringOnMessageExpiration;
            EnableBatchedOperations = enableBatchedOperations;
            EntityAvailabilityStatus = entityAvailabilityStatus;
            IsReadOnly = isReadOnly;
            LockDuration = lockDuration;
            MaxDeliveryCount = maxDeliveryCount;
            MessageCount = messageCount;
            RequiresSession = requiresSession;
            Status = status;
            UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Last time there was a receive request to this subscription.
        /// </summary>
        [JsonProperty(PropertyName = "properties.accessedAt")]
        public DateTime? AccessedAt { get; set; }

        /// <summary>
        /// TimeSpan idle interval after which the topic is automatically
        /// deleted. The minimum duration is 5 minutes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.autoDeleteOnIdle")]
        public string AutoDeleteOnIdle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.countDetails")]
        public MessageCountDetails CountDetails { get; set; }

        /// <summary>
        /// Exact time the message was created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdAt")]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Default message time to live value. This is the duration after
        /// which the message expires, starting from when the message is sent
        /// to Service Bus. This is the default value used when TimeToLive is
        /// not set on a message itself.
        /// </summary>
        [JsonProperty(PropertyName = "properties.defaultMessageTimeToLive")]
        public string DefaultMessageTimeToLive { get; set; }

        /// <summary>
        /// Value that indicates whether a subscription has dead letter
        /// support on filter evaluation exceptions.
        /// </summary>
        [JsonProperty(PropertyName = "properties.deadLetteringOnFilterEvaluationExceptions")]
        public bool? DeadLetteringOnFilterEvaluationExceptions { get; set; }

        /// <summary>
        /// Value that indicates whether a subscription has dead letter
        /// support when a message expires.
        /// </summary>
        [JsonProperty(PropertyName = "properties.deadLetteringOnMessageExpiration")]
        public bool? DeadLetteringOnMessageExpiration { get; set; }

        /// <summary>
        /// Value that indicates whether server-side batched operations are
        /// enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableBatchedOperations")]
        public bool? EnableBatchedOperations { get; set; }

        /// <summary>
        /// Entity availability status for the topic. Possible values include:
        /// 'Available', 'Limited', 'Renaming', 'Restoring', 'Unknown'
        /// </summary>
        [JsonProperty(PropertyName = "properties.entityAvailabilityStatus")]
        public EntityAvailabilityStatus? EntityAvailabilityStatus { get; set; }

        /// <summary>
        /// Value that indicates whether the entity description is read-only.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isReadOnly")]
        public bool? IsReadOnly { get; set; }

        /// <summary>
        /// The lock duration time span for the subscription.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lockDuration")]
        public string LockDuration { get; set; }

        /// <summary>
        /// Number of maximum deliveries.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxDeliveryCount")]
        public int? MaxDeliveryCount { get; set; }

        /// <summary>
        /// Number of messages.
        /// </summary>
        [JsonProperty(PropertyName = "properties.messageCount")]
        public long? MessageCount { get; set; }

        /// <summary>
        /// Value indicating if a subscription supports the concept of
        /// sessions.
        /// </summary>
        [JsonProperty(PropertyName = "properties.requiresSession")]
        public bool? RequiresSession { get; set; }

        /// <summary>
        /// Enumerates the possible values for the status of a messaging
        /// entity. Possible values include: 'Active', 'Creating',
        /// 'Deleting', 'Disabled', 'ReceiveDisabled', 'Renaming',
        /// 'Restoring', 'SendDisabled', 'Unknown'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public EntityStatus? Status { get; set; }

        /// <summary>
        /// The exact time the message was updated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
