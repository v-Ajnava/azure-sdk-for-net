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
    public partial class X12AcknowledgementSettings
    {
        /// <summary>
        /// Initializes a new instance of the X12AcknowledgementSettings class.
        /// </summary>
        public X12AcknowledgementSettings() { }

        /// <summary>
        /// Initializes a new instance of the X12AcknowledgementSettings class.
        /// </summary>
        public X12AcknowledgementSettings(bool? needTechnicalAcknowledgement = default(bool?), bool? batchTechnicalAcknowledgements = default(bool?), bool? needFunctionalAcknowledgement = default(bool?), string functionalAcknowledgementVersion = default(string), bool? batchFunctionalAcknowledgements = default(bool?), bool? needImplementationAcknowledgement = default(bool?), string implementationAcknowledgementVersion = default(string), bool? batchImplementationAcknowledgements = default(bool?), bool? needLoopForValidMessages = default(bool?), bool? sendSynchronousAcknowledgement = default(bool?), string acknowledgementControlNumberPrefix = default(string), string acknowledgementControlNumberSuffix = default(string), int? acknowledgementControlNumberLowerBound = default(int?), int? acknowledgementControlNumberUpperBound = default(int?), bool? rolloverAcknowledgementControlNumber = default(bool?))
        {
            NeedTechnicalAcknowledgement = needTechnicalAcknowledgement;
            BatchTechnicalAcknowledgements = batchTechnicalAcknowledgements;
            NeedFunctionalAcknowledgement = needFunctionalAcknowledgement;
            FunctionalAcknowledgementVersion = functionalAcknowledgementVersion;
            BatchFunctionalAcknowledgements = batchFunctionalAcknowledgements;
            NeedImplementationAcknowledgement = needImplementationAcknowledgement;
            ImplementationAcknowledgementVersion = implementationAcknowledgementVersion;
            BatchImplementationAcknowledgements = batchImplementationAcknowledgements;
            NeedLoopForValidMessages = needLoopForValidMessages;
            SendSynchronousAcknowledgement = sendSynchronousAcknowledgement;
            AcknowledgementControlNumberPrefix = acknowledgementControlNumberPrefix;
            AcknowledgementControlNumberSuffix = acknowledgementControlNumberSuffix;
            AcknowledgementControlNumberLowerBound = acknowledgementControlNumberLowerBound;
            AcknowledgementControlNumberUpperBound = acknowledgementControlNumberUpperBound;
            RolloverAcknowledgementControlNumber = rolloverAcknowledgementControlNumber;
        }

        /// <summary>
        /// Gets or sets a value indicating whether technical acknowledgement
        /// is needed.
        /// </summary>
        [JsonProperty(PropertyName = "needTechnicalAcknowledgement")]
        public bool? NeedTechnicalAcknowledgement { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to batch the technical
        /// acknowledgements.
        /// </summary>
        [JsonProperty(PropertyName = "batchTechnicalAcknowledgements")]
        public bool? BatchTechnicalAcknowledgements { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether functional acknowledgement
        /// is needed.
        /// </summary>
        [JsonProperty(PropertyName = "needFunctionalAcknowledgement")]
        public bool? NeedFunctionalAcknowledgement { get; set; }

        /// <summary>
        /// Gets or sets the functional acknowledgement version.
        /// </summary>
        [JsonProperty(PropertyName = "functionalAcknowledgementVersion")]
        public string FunctionalAcknowledgementVersion { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to batch functional
        /// acknowledgements.
        /// </summary>
        [JsonProperty(PropertyName = "batchFunctionalAcknowledgements")]
        public bool? BatchFunctionalAcknowledgements { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether implementation
        /// acknowledgement is needed.
        /// </summary>
        [JsonProperty(PropertyName = "needImplementationAcknowledgement")]
        public bool? NeedImplementationAcknowledgement { get; set; }

        /// <summary>
        /// Gets or sets the implementation acknowledgement version.
        /// </summary>
        [JsonProperty(PropertyName = "implementationAcknowledgementVersion")]
        public string ImplementationAcknowledgementVersion { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to batch implementation
        /// acknowledgements.
        /// </summary>
        [JsonProperty(PropertyName = "batchImplementationAcknowledgements")]
        public bool? BatchImplementationAcknowledgements { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether a loop is needed for valid
        /// messages.
        /// </summary>
        [JsonProperty(PropertyName = "needLoopForValidMessages")]
        public bool? NeedLoopForValidMessages { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to send synchronous
        /// acknowledgement.
        /// </summary>
        [JsonProperty(PropertyName = "sendSynchronousAcknowledgement")]
        public bool? SendSynchronousAcknowledgement { get; set; }

        /// <summary>
        /// Gets or sets the acknowledgement control number prefix.
        /// </summary>
        [JsonProperty(PropertyName = "acknowledgementControlNumberPrefix")]
        public string AcknowledgementControlNumberPrefix { get; set; }

        /// <summary>
        /// Gets or sets the acknowledgement control number suffix.
        /// </summary>
        [JsonProperty(PropertyName = "acknowledgementControlNumberSuffix")]
        public string AcknowledgementControlNumberSuffix { get; set; }

        /// <summary>
        /// Gets or sets the acknowledgement control number lower bound.
        /// </summary>
        [JsonProperty(PropertyName = "acknowledgementControlNumberLowerBound")]
        public int? AcknowledgementControlNumberLowerBound { get; set; }

        /// <summary>
        /// Gets or sets the acknowledgement control number upper bound.
        /// </summary>
        [JsonProperty(PropertyName = "acknowledgementControlNumberUpperBound")]
        public int? AcknowledgementControlNumberUpperBound { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to rollover
        /// acknowledgement control number.
        /// </summary>
        [JsonProperty(PropertyName = "rolloverAcknowledgementControlNumber")]
        public bool? RolloverAcknowledgementControlNumber { get; set; }

    }
}
