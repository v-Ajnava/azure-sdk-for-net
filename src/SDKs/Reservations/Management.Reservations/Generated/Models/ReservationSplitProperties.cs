// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Reservations.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ReservationSplitProperties
    {
        /// <summary>
        /// Initializes a new instance of the ReservationSplitProperties class.
        /// </summary>
        public ReservationSplitProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ReservationSplitProperties class.
        /// </summary>
        /// <param name="splitDestinations">List of destination Resource Id
        /// that are created due to split. Format of the resource Id is
        /// /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}</param>
        /// <param name="splitSource">Resource Id of the Reservation from which
        /// this is split. Format of the resource Id is
        /// /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}</param>
        public ReservationSplitProperties(IList<string> splitDestinations = default(IList<string>), string splitSource = default(string))
        {
            SplitDestinations = splitDestinations;
            SplitSource = splitSource;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of destination Resource Id that are created due
        /// to split. Format of the resource Id is
        /// /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}
        /// </summary>
        [JsonProperty(PropertyName = "splitDestinations")]
        public IList<string> SplitDestinations { get; set; }

        /// <summary>
        /// Gets or sets resource Id of the Reservation from which this is
        /// split. Format of the resource Id is
        /// /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}
        /// </summary>
        [JsonProperty(PropertyName = "splitSource")]
        public string SplitSource { get; set; }

    }
}
