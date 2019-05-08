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
    /// SenderListResponse
    /// </summary>
    [DataContract]
    public partial class SenderListResponse :  IEquatable<SenderListResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SenderListResponse" /> class.
        /// </summary>
        /// <param name="meta">meta.</param>
        public SenderListResponse(PaginationMeta meta = default(PaginationMeta))
        {
            this.Meta = meta;
        }
        
        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        [DataMember(Name="object", EmitDefaultValue=)]
        public List<Sender> Object { get; private set; }

        /// <summary>
        /// Gets or Sets Meta
        /// </summary>
        [DataMember(Name="meta", EmitDefaultValue=)]
        public PaginationMeta Meta { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SenderListResponse {\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
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
            return this.Equals(input as SenderListResponse);
        }

        /// <summary>
        /// Returns true if SenderListResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SenderListResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SenderListResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Object == input.Object ||
                    this.Object != null &&
                    this.Object.SequenceEqual(input.Object)
                ) && 
                (
                    this.Meta == input.Meta ||
                    (this.Meta != null &&
                    this.Meta.Equals(input.Meta))
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
                if (this.Object != null)
                    hashCode = hashCode * 59 + this.Object.GetHashCode();
                if (this.Meta != null)
                    hashCode = hashCode * 59 + this.Meta.GetHashCode();
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
