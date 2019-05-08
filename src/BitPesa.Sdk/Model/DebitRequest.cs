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
    /// DebitRequest
    /// </summary>
    [DataContract]
    public partial class DebitRequest :  IEquatable<DebitRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DebitRequest" /> class.
        /// </summary>
        /// <param name="debit">debit.</param>
        public DebitRequest(Debit debit = default(Debit))
        {
            this.Debit = debit;
        }
        
        /// <summary>
        /// Gets or Sets Debit
        /// </summary>
        [DataMember(Name="debit", EmitDefaultValue=)]
        public Debit Debit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DebitRequest {\n");
            sb.Append("  Debit: ").Append(Debit).Append("\n");
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
            return this.Equals(input as DebitRequest);
        }

        /// <summary>
        /// Returns true if DebitRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DebitRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DebitRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Debit == input.Debit ||
                    (this.Debit != null &&
                    this.Debit.Equals(input.Debit))
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
                if (this.Debit != null)
                    hashCode = hashCode * 59 + this.Debit.GetHashCode();
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
