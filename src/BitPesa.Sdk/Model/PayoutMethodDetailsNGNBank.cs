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
    /// &#x60;&#x60;&#x60;JSON   \&quot;details\&quot;: {     \&quot;first_name\&quot;: \&quot;First\&quot;,     \&quot;last_name\&quot;: \&quot;Last\&quot;,     \&quot;bank_code\&quot;: \&quot;058\&quot;,     \&quot;bank_account\&quot;: \&quot;123456789\&quot;,     \&quot;bank_account_type\&quot;: \&quot;10\&quot;       # 10 for saving       # 20 for current accounts   } &#x60;&#x60;&#x60;  The valid bank_code values are:  - Access Bank: 044 - Diamond Bank: 063 - EcoBank: 050 - FCMB Bank: 214 - Fidelity Bank: 070 - First Bank of Nigeria: 011 - Guaranty Trust Bank : 058 - Heritage Bank: 030 - Jaiz Bank: 301 - Keystone: 082 - Mainstreet: 014 - Polaris Bank: 076 - Stanbic IBTC Bank: 039 - Sterling bank: 232 - Union Bank: 032 - United Bank for Africa: 033 - Unity Bank: 215 - Wema Bank: 035 - Zenith International: 057
    /// </summary>
    [DataContract]
    public partial class PayoutMethodDetailsNGNBank :  IEquatable<PayoutMethodDetailsNGNBank>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutMethodDetailsNGNBank" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PayoutMethodDetailsNGNBank() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutMethodDetailsNGNBank" /> class.
        /// </summary>
        /// <param name="firstName">firstName (required).</param>
        /// <param name="lastName">lastName (required).</param>
        /// <param name="bankCode">bankCode (required).</param>
        /// <param name="bankAccount">bankAccount (required).</param>
        /// <param name="bankAccountType">bankAccountType (required).</param>
        public PayoutMethodDetailsNGNBank(string firstName = default(string), string lastName = default(string), string bankCode = default(string), string bankAccount = default(string), PayoutMethodBankAccountTypeEnum bankAccountType = default(PayoutMethodBankAccountTypeEnum))
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BankCode = bankCode;
            this.BankAccount = bankAccount;
            this.BankAccountType = bankAccountType;
        }
        
        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="first_name", EmitDefaultValue=)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="last_name", EmitDefaultValue=)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets BankCode
        /// </summary>
        [DataMember(Name="bank_code", EmitDefaultValue=)]
        public string BankCode { get; set; }

        /// <summary>
        /// Gets or Sets BankAccount
        /// </summary>
        [DataMember(Name="bank_account", EmitDefaultValue=)]
        public string BankAccount { get; set; }

        /// <summary>
        /// Gets or Sets BankAccountType
        /// </summary>
        [DataMember(Name="bank_account_type", EmitDefaultValue=)]
        public PayoutMethodBankAccountTypeEnum BankAccountType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayoutMethodDetailsNGNBank {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  BankCode: ").Append(BankCode).Append("\n");
            sb.Append("  BankAccount: ").Append(BankAccount).Append("\n");
            sb.Append("  BankAccountType: ").Append(BankAccountType).Append("\n");
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
            return this.Equals(input as PayoutMethodDetailsNGNBank);
        }

        /// <summary>
        /// Returns true if PayoutMethodDetailsNGNBank instances are equal
        /// </summary>
        /// <param name="input">Instance of PayoutMethodDetailsNGNBank to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayoutMethodDetailsNGNBank input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.BankCode == input.BankCode ||
                    (this.BankCode != null &&
                    this.BankCode.Equals(input.BankCode))
                ) && 
                (
                    this.BankAccount == input.BankAccount ||
                    (this.BankAccount != null &&
                    this.BankAccount.Equals(input.BankAccount))
                ) && 
                (
                    this.BankAccountType == input.BankAccountType ||
                    (this.BankAccountType != null &&
                    this.BankAccountType.Equals(input.BankAccountType))
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
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.BankCode != null)
                    hashCode = hashCode * 59 + this.BankCode.GetHashCode();
                if (this.BankAccount != null)
                    hashCode = hashCode * 59 + this.BankAccount.GetHashCode();
                if (this.BankAccountType != null)
                    hashCode = hashCode * 59 + this.BankAccountType.GetHashCode();
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
