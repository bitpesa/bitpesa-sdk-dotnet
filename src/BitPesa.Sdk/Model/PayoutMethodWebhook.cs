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
    /// PayoutMethodWebhook
    /// </summary>
    [DataContract]
    public partial class PayoutMethodWebhook :  IEquatable<PayoutMethodWebhook>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutMethodWebhook" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PayoutMethodWebhook() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutMethodWebhook" /> class.
        /// </summary>
        /// <param name="_object">_object (required).</param>
        public PayoutMethodWebhook(PayoutMethod _object = default(PayoutMethod))
        {
            this.Object = _object;
        }
        
        /// <summary>
        /// The ID of the webhook that was used to send out this callback
        /// </summary>
        /// <value>The ID of the webhook that was used to send out this callback</value>
        [DataMember(Name="webhook", EmitDefaultValue=false)]
        public Guid? Webhook { get; private set; }

        /// <summary>
        /// The event that triggered this webhook
        /// </summary>
        /// <value>The event that triggered this webhook</value>
        [DataMember(Name="event", EmitDefaultValue=false)]
        public string Event { get; private set; }

        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public PayoutMethod Object { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayoutMethodWebhook {\n");
            sb.Append("  Webhook: ").Append(Webhook).Append("\n");
            sb.Append("  Event: ").Append(Event).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
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
            return this.Equals(input as PayoutMethodWebhook);
        }

        /// <summary>
        /// Returns true if PayoutMethodWebhook instances are equal
        /// </summary>
        /// <param name="input">Instance of PayoutMethodWebhook to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayoutMethodWebhook input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Webhook == input.Webhook ||
                    (this.Webhook != null &&
                    this.Webhook.Equals(input.Webhook))
                ) && 
                (
                    this.Event == input.Event ||
                    (this.Event != null &&
                    this.Event.Equals(input.Event))
                ) && 
                (
                    this.Object == input.Object ||
                    (this.Object != null &&
                    this.Object.Equals(input.Object))
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
                if (this.Webhook != null)
                    hashCode = hashCode * 59 + this.Webhook.GetHashCode();
                if (this.Event != null)
                    hashCode = hashCode * 59 + this.Event.GetHashCode();
                if (this.Object != null)
                    hashCode = hashCode * 59 + this.Object.GetHashCode();
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
