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
    /// &#x60;&#x60;&#x60;JSON   \&quot;details\&quot;: {     \&quot;redirect_url\&quot;: \&quot;http://redirect.back.to\&quot;   } &#x60;&#x60;&#x60;
    /// </summary>
    [DataContract]
    public partial class PayinMethodDetailsNGNBank :  IEquatable<PayinMethodDetailsNGNBank>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayinMethodDetailsNGNBank" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PayinMethodDetailsNGNBank() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PayinMethodDetailsNGNBank" /> class.
        /// </summary>
        /// <param name="redirectUrl">This is where the user should be redirected back when the payment has been finished (required).</param>
        public PayinMethodDetailsNGNBank(string redirectUrl = default(string))
        {
            this.RedirectUrl = redirectUrl;
        }
        
        /// <summary>
        /// This is where the user should be redirected back when the payment has been finished
        /// </summary>
        /// <value>This is where the user should be redirected back when the payment has been finished</value>
        [DataMember(Name="redirect_url", EmitDefaultValue=false)]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayinMethodDetailsNGNBank {\n");
            sb.Append("  RedirectUrl: ").Append(RedirectUrl).Append("\n");
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
            return this.Equals(input as PayinMethodDetailsNGNBank);
        }

        /// <summary>
        /// Returns true if PayinMethodDetailsNGNBank instances are equal
        /// </summary>
        /// <param name="input">Instance of PayinMethodDetailsNGNBank to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayinMethodDetailsNGNBank input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RedirectUrl == input.RedirectUrl ||
                    (this.RedirectUrl != null &&
                    this.RedirectUrl.Equals(input.RedirectUrl))
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
                if (this.RedirectUrl != null)
                    hashCode = hashCode * 59 + this.RedirectUrl.GetHashCode();
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
