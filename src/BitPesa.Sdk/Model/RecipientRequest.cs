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
    /// RecipientRequest
    /// </summary>
    [DataContract]
    public partial class RecipientRequest :  IEquatable<RecipientRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecipientRequest" /> class.
        /// </summary>
        /// <param name="recipient">recipient.</param>
        public RecipientRequest(Recipient recipient = default(Recipient))
        {
            this.Recipient = recipient;
        }
        
        /// <summary>
        /// Gets or Sets Recipient
        /// </summary>
        [DataMember(Name="recipient", EmitDefaultValue=)]
        public Recipient Recipient { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecipientRequest {\n");
            sb.Append("  Recipient: ").Append(Recipient).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as RecipientRequest);
        }

        /// <summary>
        /// Returns true if RecipientRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RecipientRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecipientRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Recipient == input.Recipient ||
                    (this.Recipient != null &&
                    this.Recipient.Equals(input.Recipient))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Recipient != null)
                    hashCode = hashCode * 59 + this.Recipient.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
