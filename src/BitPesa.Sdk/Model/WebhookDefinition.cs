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
    /// Object that holds where to send webhooks, and what events should it be triggered with
    /// </summary>
    [DataContract]
    public partial class WebhookDefinition :  IEquatable<WebhookDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDefinition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebhookDefinition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDefinition" /> class.
        /// </summary>
        /// <param name="url">The URL to receive the webhook (required).</param>
        /// <param name="events">A list of events to subscribe to (required).</param>
        /// <param name="metadata">metadata.</param>
        public WebhookDefinition(string url = default(string), List<string> events = default(List<string>), Object metadata = default(Object))
        {
            this.Url = url;
            this.Events = events;
            this.Metadata = metadata;
        }
        
        /// <summary>
        /// The URL to receive the webhook
        /// </summary>
        /// <value>The URL to receive the webhook</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// A list of events to subscribe to
        /// </summary>
        /// <value>A list of events to subscribe to</value>
        [DataMember(Name="events", EmitDefaultValue=false)]
        public List<string> Events { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public Object Metadata { get; set; }

        /// <summary>
        /// The ID of the webhook
        /// </summary>
        /// <value>The ID of the webhook</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }

        /// <summary>
        /// The fields that have some problems and don&#39;t pass validation
        /// </summary>
        /// <value>The fields that have some problems and don&#39;t pass validation</value>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public Dictionary<string, List<ValidationErrorDescription>> Errors { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookDefinition {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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
            return this.Equals(input as WebhookDefinition);
        }

        /// <summary>
        /// Returns true if WebhookDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Events == input.Events ||
                    this.Events != null &&
                    this.Events.SequenceEqual(input.Events)
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Errors == input.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(input.Errors)
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
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Events != null)
                    hashCode = hashCode * 59 + this.Events.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Errors != null)
                    hashCode = hashCode * 59 + this.Errors.GetHashCode();
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
