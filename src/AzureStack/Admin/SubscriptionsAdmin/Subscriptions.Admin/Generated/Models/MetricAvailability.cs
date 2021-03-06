// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Subscriptions.Admin.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Metric Definition
    /// </summary>
    public partial class MetricAvailability
    {
        /// <summary>
        /// Initializes a new instance of the MetricAvailability class.
        /// </summary>
        public MetricAvailability()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MetricAvailability class.
        /// </summary>
        /// <param name="timeGrain">The time grain. Metrics will be available
        /// for this time grain.</param>
        /// <param name="retention">the retention. Metrics may be queried for
        /// this interval.</param>
        public MetricAvailability(string timeGrain = default(string), string retention = default(string))
        {
            TimeGrain = timeGrain;
            Retention = retention;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the time grain. Metrics will be available for this
        /// time grain.
        /// </summary>
        [JsonProperty(PropertyName = "timeGrain")]
        public string TimeGrain { get; set; }

        /// <summary>
        /// Gets or sets the retention. Metrics may be queried for this
        /// interval.
        /// </summary>
        [JsonProperty(PropertyName = "retention")]
        public string Retention { get; set; }

    }
}
