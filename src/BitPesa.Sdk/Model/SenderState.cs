/* 
 * BitPesa API
 *
 * Reference documentation for the BitPesa API V1
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = BitPesa.Sdk.Client.OpenAPIDateConverter;

namespace BitPesa.Sdk.Model
{
    /// <summary>
    /// The state of the sender. Can be one of the following:  - &#x60;initial&#x60;: When a sender is created and has not been through any KYC checking (cannot transact) - &#x60;verified&#x60;: A sender has passed sanction list checks (cannot transact) - &#x60;approved&#x60;: The sender has passed both KYC and sanction checks (can transact) - &#x60;banned&#x60;: An admin has banned the sender (cannot transact) - &#x60;rejected&#x60;: The sender has failed sanction list checks (cannot transact) - &#x60;disabled&#x60;: A sender is put into this state as a result of a delete request via the API (cannot transact)
    /// </summary>
    /// <value>The state of the sender. Can be one of the following:  - &#x60;initial&#x60;: When a sender is created and has not been through any KYC checking (cannot transact) - &#x60;verified&#x60;: A sender has passed sanction list checks (cannot transact) - &#x60;approved&#x60;: The sender has passed both KYC and sanction checks (can transact) - &#x60;banned&#x60;: An admin has banned the sender (cannot transact) - &#x60;rejected&#x60;: The sender has failed sanction list checks (cannot transact) - &#x60;disabled&#x60;: A sender is put into this state as a result of a delete request via the API (cannot transact)</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum SenderState
    {
        /// <summary>
        /// Enum Initial for value: initial
        /// </summary>
        [EnumMember(Value = "initial")]
        Initial = 1,

        /// <summary>
        /// Enum Verified for value: verified
        /// </summary>
        [EnumMember(Value = "verified")]
        Verified = 2,

        /// <summary>
        /// Enum Approved for value: approved
        /// </summary>
        [EnumMember(Value = "approved")]
        Approved = 3,

        /// <summary>
        /// Enum Banned for value: banned
        /// </summary>
        [EnumMember(Value = "banned")]
        Banned = 4,

        /// <summary>
        /// Enum Rejected for value: rejected
        /// </summary>
        [EnumMember(Value = "rejected")]
        Rejected = 5,

        /// <summary>
        /// Enum Disabled for value: disabled
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled = 6

    }

}
